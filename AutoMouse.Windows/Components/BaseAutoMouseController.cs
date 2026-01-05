// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Threading;
using System.Windows.Forms;
using Sphere10.Framework.Application;
using Sphere10.Framework;


namespace AutoMouse.Windows {
	public abstract class BaseAutoMouseController : IAutoMouseController {
		private volatile AutoMouseSettings _settings;
		private volatile bool _interceptAutoMouseKeys;
		private DateTime _lastKeyDown;
		protected volatile int LastMouseX;
		protected volatile int LastMouseY;
		protected volatile int KeyDownX;
		protected volatile int KeyDownY;
		protected DecayGauge _decayGauge;

		protected BaseAutoMouseController(IMouseHook mouseHook, IKeyboardHook keyboardHook, IScreenMouse screenMouse,
			IExpandingCircleRenderer expandingCircleRenderer, ISoundMaker soundMaker,
			IUserInterfaceServices userInterfaceServices) {
			MouseHook = mouseHook;
			KeyboardHook = keyboardHook;
			ScreenMouse = screenMouse;
			ScreenMouse.StateChanged += (sender, @event) => {
				_interceptAutoMouseKeys = @event.CurrentState != ScreenMouseState.Inactive;
			};
			ScreenMouse.StateChanged += ScreenMouse_StateChanged;
			//ScreenMouse.StateChanged += (sender, @event) => {
			//	Debug.WriteLine($"{DateTime.Now:yyyy-MM-dd HH:mm:ss.fff}: State Changed: {@event.PreviousState} -> {@event.CurrentState}");
			//};
			ExpandingCircleRenderer = expandingCircleRenderer;
			UserInterfaceServices = userInterfaceServices;
			SoundMaker = soundMaker;

			_lastKeyDown = DateTime.Now;

			// Configure this object
			_settings = null;
			_interceptAutoMouseKeys = false;
			_decayGauge = DecayGauge.ScreenMouse;

			KeyboardHook.ShouldIntercept = _keyHook_ShouldIntercept;
			MouseHook.MotionStop += _mouseHook_MotionStop;
			MouseHook.Motion += _mouseHook_Motion;
			KeyboardHook.KeyDown += _keyHook_KeyDown;
			KeyboardHook.KeyUp += _keyHook_KeyUp;
		}


		protected IMouseHook MouseHook { get; private set; }

		protected IKeyboardHook KeyboardHook { get; private set; }

		protected IScreenMouse ScreenMouse { get; private set; }

		protected IExpandingCircleRenderer ExpandingCircleRenderer { get; private set; }

		protected IUserInterfaceServices UserInterfaceServices { get; private set; }

		protected ISoundMaker SoundMaker { get; private set; }

		#region Properties

		public AutoMouseSettings Settings {
			get {
				if (_settings == null) {
					lock (this) {
						if (_settings == null) {
							_settings = UserSettings.Get<AutoMouseSettings>();
							MouseHook.MovingStoppedInterval = Settings.MouseStoppedInterval;
							UserSettings.Provider.Changed += () => {
								MouseHook.MovingStoppedInterval = _settings.MouseStoppedInterval;
							};
							
						}
					}
				}

				return _settings;
			}
		}

		public bool Started { get; set; }

		public abstract int CursorCurrentPositionX { get; set; }

		public abstract int CursorCurrentPositionY { get; set; }

		#endregion

		#region Methods

		#region Mode - AutoActivateScreenMouse

		public virtual void ProcessKeyDown_AutoActivateScreenMouse(KeyEvent e) {
			if (ScreenMouse.State.IsIn(ScreenMouseState.Active) && _interceptAutoMouseKeys) {
				#region Process Button Keys

				var autoMouseButtonPressed = false;
				if (e.Key == Settings.LeftButtonKey && ScreenMouse.PressedButton != MouseButton.Left) {
					ScreenMouse.PressedButton = MouseButton.Left;
					autoMouseButtonPressed = true;
				}

				if (e.Key == Settings.MiddleButtonKey && ScreenMouse.PressedButton != MouseButton.Middle) {
					ScreenMouse.PressedButton = MouseButton.Middle;
					autoMouseButtonPressed = true;
				}

				if (e.Key == Settings.RightButtonKey && ScreenMouse.PressedButton != MouseButton.Right) {
					ScreenMouse.PressedButton = MouseButton.Right;
					autoMouseButtonPressed = true;
				}

				if (autoMouseButtonPressed && ScreenMouse.PressedButton != MouseButton.None) {
					KeyDownX = LastMouseX;
					KeyDownY = LastMouseY;
					if (Settings.ShowExpandingRings) {
						ExecuteInUIFriendlyContext(
							() =>
								ExpandingCircleRenderer.DrawExpandingCircle(CursorCurrentPositionX,
									CursorCurrentPositionY, Settings.ExpandingRingColor,
									Settings.ExpandingRingThickness, Settings.ExpandingRingRadius,
									Settings.ExpandingRingSpeedPixelsPerSecond));
					}

					if (Settings.MakeClickSound) {
						SoundMaker.PlayClickSound(ScreenMouse.PressedButton, MouseButtonState.Down);
					}

					MouseHook.Simulate(ScreenMouse.PressedButton, MouseButtonState.Down, LastMouseX, LastMouseY);
				}

				#endregion

				#region Process Arrow Keys

				if (Settings.KeyboardArrowsMoveScreenMouse) {
					_decayGauge.RegisterEvent(1);
					switch (e.Key) {
						case Key.Left:
							CursorCurrentPositionX -= (int)_decayGauge.Level.ClipTo(1, double.MaxValue);
							break;
						case Key.Right:
							CursorCurrentPositionX += (int)_decayGauge.Level.ClipTo(1, double.MaxValue);
							break;
						case Key.Up:
							CursorCurrentPositionY -= (int)_decayGauge.Level.ClipTo(1, double.MaxValue);
							break;
						case Key.Down:
							CursorCurrentPositionY += (int)_decayGauge.Level.ClipTo(1, double.MaxValue);
							break;
					}

					LastMouseX = CursorCurrentPositionX;
					LastMouseY = CursorCurrentPositionY;
					ScreenMouse.MoveTo(LastMouseX, LastMouseY);
				}

				#endregion

				#region If it a key not related to Auto Mouse (or shift/alt/control/win), then user is typing so disable screen mouse

				if (!e.Key.IsIn(Settings.LeftButtonKey, Settings.MiddleButtonKey, Settings.RightButtonKey, Key.Left, Key.Right, Key.Up, Key.Down, Key.LShiftKey, Key.RShiftKey, Key.LControlKey, Key.RControlKey, Key.LWin, Key.RWin, Key.Alt)) {
					_interceptAutoMouseKeys = false;
					ScreenMouse.FadeOut();
				}

				#endregion
			}

			_lastKeyDown = DateTime.Now;
		}

		public virtual void ProcessKeyUp_AutoActivateScreenMouse(KeyEvent e) {
			if (ScreenMouse.PressedButton != MouseButton.None) {
				MouseButton buttonLetGo = ScreenMouse.PressedButton;
				if (e.Key == Settings.LeftButtonKey && ScreenMouse.PressedButton == MouseButton.Left ||
					e.Key == Settings.MiddleButtonKey && ScreenMouse.PressedButton == MouseButton.Middle ||
					e.Key == Settings.RightButtonKey && ScreenMouse.PressedButton == MouseButton.Right) {
					ScreenMouse.PressedButton = MouseButton.None;
				}

				if (Tools.Maths.EuclideanDistance(KeyDownX, KeyDownY, LastMouseX, LastMouseY) > Settings.ClickFreeZoneRadius) {
					// If it was a drag-type operation, we also show circle on mouse up
					if (Settings.ShowExpandingRings) {
						ExecuteInUIFriendlyContext(
							() =>
								ExpandingCircleRenderer.DrawExpandingCircle(
									CursorCurrentPositionX,
									CursorCurrentPositionY,
									Settings.ExpandingRingColor2,
									Settings.ExpandingRingThickness,
									Settings.ExpandingRingRadius,
									Settings.ExpandingRingSpeedPixelsPerSecond
								)
						);
					}
				}

				if (Settings.MakeClickSound) {
					SoundMaker.PlayClickSound(ScreenMouse.PressedButton, MouseButtonState.Up);
				}

				MouseHook.Simulate(buttonLetGo, MouseButtonState.Up, LastMouseX, LastMouseY);
			}
		}

		public virtual void ProcessMotion_AutoActivateScreenMouse(MouseMoveEvent e) {
			LastMouseX = e.X;
			LastMouseY = e.Y;
			if (ScreenMouse.State != ScreenMouseState.Active && e.DistanceSinceMotionStart > Settings.ClickFreeZoneRadius) {
				ScreenMouse.FadeIn();
			}

			if (ScreenMouse.State != ScreenMouseState.Inactive) {
				ScreenMouse.MoveTo(e.X, e.Y);
			}
		}

		public virtual void ProcessMotionStop_AutoActivateScreenMouse(MouseMoveEvent e) {
		}

		public virtual void MouseFormStateChanged_AutoActivateScreenMouse(ScreenMouseStateChangedEvent e) {
			// Remove _keyHook_ShouldIntercept handler when not needed to ensure minimalist keyboard hook (critical for UX)
			switch (e.CurrentState) {
				case ScreenMouseState.Active:
				case ScreenMouseState.ButtonSelected:
					KeyboardHook.ShouldIntercept ??= _keyHook_ShouldIntercept;
					break;
				case ScreenMouseState.Inactive:
					KeyboardHook.ShouldIntercept = null;
					break;
			}
		}

		#endregion

		#region Mode - AutoClickOnMouseStop

		public virtual void ProcessKeyDown_AutoClickOnMouseStop(KeyEvent e) {
		}

		public virtual void ProcessKeyUp_AutoClickOnMouseStop(KeyEvent key) {
		}

		public virtual void ProcessMotion_AutoClickOnMouseStop(MouseMoveEvent e) {
			LastMouseX = e.X;
			LastMouseY = e.Y;
		}

		public virtual void ProcessMotionStop_AutoClickOnMouseStop(MouseMoveEvent e) {
			// If mouse is active, and user has moved beyond click free zone, set the mouse to fading
			if (e.DistanceSinceMotionStart > Settings.ClickFreeZoneRadius) {
				SimulateMouse(Settings.AutoClickButton, Settings.AutoClickType, e.X, e.Y);
			}
		}

		public virtual void MouseFormStateChanged_AutoClickOnMouseStop(ScreenMouseStateChangedEvent e) {
		}

		#endregion

		#region Mode - ManuallyActivateScreenMouse

		public virtual void ProcessKeyDown_ManuallyActivateScreenMouse(KeyEvent e) {
			ProcessKeyDown_AutoActivateScreenMouse(e);
			if (Settings.ScreenMouseActivationKey == e.Key) {
				if (ScreenMouse.State == ScreenMouseState.Inactive) {
					ScreenMouse.FadeToFullOpacity();
					ScreenMouse.KeepAlive = Settings.ScreenMouseKeepAliveOnManualActivation;
				} else {
					ScreenMouse.KeepAlive = false;
					ScreenMouse.FadeOut();
				}

				if (ScreenMouse.State != ScreenMouseState.Inactive) {
					ScreenMouse.MoveTo(LastMouseX, LastMouseY);
				}
			}
		}

		public virtual void ProcessKeyUp_ManuallyActivateScreenMouse(KeyEvent e) {
			ProcessKeyUp_AutoActivateScreenMouse(e);
		}

		public virtual void ProcessMotion_ManuallyActivateScreenMouse(MouseMoveEvent e) {
			LastMouseX = e.X;
			LastMouseY = e.Y;
			if (ScreenMouse.State != ScreenMouseState.Inactive) {
				ScreenMouse.MoveTo(e.X, e.Y);
			}
		}

		public virtual void ProcessMotionStop_ManuallyActivateScreenMouse(MouseMoveEvent e) {
			// If mouse is active, and user has moved beyond click free zone, set the mouse to fading
			if (!Settings.ScreenMouseKeepAliveOnManualActivation &&
				ScreenMouse.State == ScreenMouseState.Active &&
				e.DistanceSinceMotionStart > Settings.ClickFreeZoneRadius) {
				ScreenMouse.FadeOut();
			}

			if (ScreenMouse.State != ScreenMouseState.Inactive) {
				ScreenMouse.MoveTo(e.X, e.Y);
			}
		}

		public virtual void MouseFormStateChanged_ManuallyActivateScreenMouse(ScreenMouseStateChangedEvent e) {
			// Remove _keyHook_ShouldIntercept handler when not needed to ensure minimalist keyboard hook (critical for UX)
			switch (e.CurrentState) {
				case ScreenMouseState.Active:
				case ScreenMouseState.ButtonSelected:
					KeyboardHook.ShouldIntercept ??= _keyHook_ShouldIntercept;
					break;
				case ScreenMouseState.Inactive:
					KeyboardHook.ShouldIntercept = null;
					break;
			}
		}

		#endregion

		protected virtual void ExecuteInUIFriendlyContext(Action action) {
			UserInterfaceServices.ExecuteInUIFriendlyContext(action);
		}

		public void Start() {
			if (MouseHook.Status == DeviceHookStatus.Uninstalled) {
				MouseHook.InstallHook();
			}

			if (KeyboardHook.Status == DeviceHookStatus.Uninstalled) {
				KeyboardHook.InstallHook();
			}

			MouseHook.StartHook();
			KeyboardHook.StartHook();
			Started = true;
		}

		public void Stop() {
			MouseHook.StopHook();
			KeyboardHook.StopHook();
			ScreenMouse.KeepAlive = false;
			Started = false;
		}

		public void SimulateMouse(MouseButton button, MouseClickType clickType, int centerX, int centerY) {
			var mouseActions = new List<Tuple<MouseButton, MouseButtonState, TimeSpan>>();
			switch (clickType) {
				case MouseClickType.Single:
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, TimeSpan.FromSeconds(0)));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					break;
				case MouseClickType.Double:
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, TimeSpan.FromSeconds(0)));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, Settings.MultipleClickInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					break;
				case MouseClickType.Tripple:
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, TimeSpan.FromSeconds(0)));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, Settings.MultipleClickInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Down, Settings.MultipleClickInterval));
					mouseActions.Add(Tuple.Create(button, MouseButtonState.Up, Settings.MouseUpInterval));
					break;
			}

			Tools.Lambda.ActionAsAsyncronous(
				() => mouseActions.ForEach(
					action => {
						Thread.Sleep(action.Item3);

						// Show expanding rings on click down
						if (Settings.ShowExpandingRings && action.Item2 == MouseButtonState.Down) {
							ExecuteInUIFriendlyContext(
								() =>
									ExpandingCircleRenderer.DrawExpandingCircle(centerX, centerY,
										Settings.ExpandingRingColor,
										Settings.ExpandingRingThickness, Settings.ExpandingRingRadius,
										Settings.ExpandingRingSpeedPixelsPerSecond));
						}

						// Make click sound
						if (Settings.MakeClickSound) {
							SoundMaker.PlayClickSound(action.Item1, action.Item2);
						}

						// Send actual mouse event to OS
						MouseHook.Simulate(action.Item1, action.Item2, centerX, centerY);
					}
				)
			).Invoke();
		}

		#endregion

		#region Handlers

		void ScreenMouse_StateChanged(object sender, ScreenMouseStateChangedEvent e) {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					MouseFormStateChanged_AutoActivateScreenMouse(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					MouseFormStateChanged_AutoClickOnMouseStop(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					MouseFormStateChanged_ManuallyActivateScreenMouse(e);
					break;
			}
		}

		void _keyHook_KeyDown(object sender, KeyEvent e) {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					ProcessKeyDown_AutoActivateScreenMouse(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					ProcessKeyDown_AutoClickOnMouseStop(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					ProcessKeyDown_ManuallyActivateScreenMouse(e);
					break;
			}
		}

		void _keyHook_KeyUp(object sender, KeyEvent e) {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					ProcessKeyUp_AutoActivateScreenMouse(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					ProcessKeyUp_AutoClickOnMouseStop(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					ProcessKeyUp_ManuallyActivateScreenMouse(e);
					break;
			}
		}

		private bool _keyHook_ShouldIntercept(Key key, KeyState keyState) {
			var automouseKeys =
				Settings.KeyboardArrowsMoveScreenMouse ?
				new [] { Settings.LeftButtonKey, Settings.MiddleButtonKey, Settings.RightButtonKey, Key.Left, Key.Right, Key.Up, Key.Down } :
				new [] { Settings.LeftButtonKey, Settings.MiddleButtonKey, Settings.RightButtonKey};

			return _interceptAutoMouseKeys && key.IsIn(automouseKeys);
		}


		void _mouseHook_Motion(object sender, MouseMoveEvent e) {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					ProcessMotion_AutoActivateScreenMouse(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					ProcessMotion_AutoClickOnMouseStop(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					ProcessMotion_ManuallyActivateScreenMouse(e);
					break;
			}
		}

		void _mouseHook_MotionStop(object sender, MouseMoveEvent e) {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					ProcessMotionStop_AutoActivateScreenMouse(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					ProcessMotionStop_AutoClickOnMouseStop(e);
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					ProcessMotionStop_ManuallyActivateScreenMouse(e);
					break;
			}
		}

		#endregion

		public void Dispose() {
			if (MouseHook.Status != DeviceHookStatus.Uninstalled) {
				MouseHook.UninstallHook();
			}

			if (KeyboardHook.Status != DeviceHookStatus.Uninstalled) {
				KeyboardHook.UninstallHook();
			}
		}
	}
}