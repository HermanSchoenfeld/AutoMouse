using System;
using System.Drawing;
using System.Threading;
using System.Timers;
using Sphere10.AutoMouse.Properties;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Timer = System.Timers.Timer;

namespace Sphere10.AutoMouse {

	public abstract class BaseScreenMouse : IScreenMouse {

		protected readonly TimeSpan _formTimerPollPeriod = TimeSpan.FromMilliseconds(10);
		protected readonly Timer _timer;
		protected readonly SemaphoreSlim _fadeInSemaphore;
		protected readonly SemaphoreSlim _fadeOutSemaphore;
		protected readonly SemaphoreSlim _fadeToFullSemaphore;
		protected volatile AutoMouseSettings _settings;
		protected double _imageOpacity;
		protected MouseButton _mouseButton;
		protected ScreenMouseState _screenMouseState;
		protected DateTime _fadeStartTime;
		protected double _fadeStartOpacity;
		protected double _fadeEndOpacity;
		protected bool _fadingOut;

		public event EventHandler<ScreenMouseStateChangedEvent> StateChanged;
		
		event EventHandler<ScreenMouseStateChangedEvent> IScreenMouse.StateChanged {
			add { StateChanged += value; }
			remove { StateChanged -= value; }
		}

		public BaseScreenMouse(IConfigurationServices configurationServices) {
			ConfigurationServices = configurationServices;

			_imageOpacity = 0.0;
			_timer = new Timer { AutoReset = true };
			_timer.Elapsed += new ElapsedEventHandler(_timer_Elapsed); 
			_timer.Interval = (int)_formTimerPollPeriod.TotalMilliseconds;
			_fadeStartTime = DateTime.Now;
			_fadeEndOpacity = 0;
			_fadeStartOpacity = 0;
			_fadingOut = false;
			_fadeInSemaphore = new SemaphoreSlim(1);
			_fadeOutSemaphore = new SemaphoreSlim(1);
			_fadeToFullSemaphore = new SemaphoreSlim(1);
			_mouseButton = MouseButton.None;
			_screenMouseState = ScreenMouseState.Inactive;
			KeepAlive = false;

			
		}

		#region Properties
		
		public AutoMouseSettings Settings {
			get {
				if (_settings == null) {
					lock (this) {
						if (_settings == null)
						{
							_settings = UserSettings.Get<AutoMouseSettings>();
						}
					}
				}
				return _settings;
			}
		}

		public abstract int Width { get; set; }

		public abstract int Height { get; set; }

		public MouseButton PressedButton {
			get {
				return _mouseButton;
			}
			set {
				_mouseButton = value;
				if (_mouseButton.IsIn(MouseButton.Left, MouseButton.Middle, MouseButton.Right)) {
					State = ScreenMouseState.ButtonSelected;
					FadeToFullOpacity();
				} else {
					State = ScreenMouseState.Active;
				}
				LastActivityTime = DateTime.Now;
				UpdateMouseImage();
			}
		}

		public ScreenMouseState State {
			get {
				return _screenMouseState;
			}
			set {
				ScreenMouseState previousState = _screenMouseState;
				_screenMouseState = value;
				FireStateChangedEvent(new ScreenMouseStateChangedEvent { CurrentState = _screenMouseState, PreviousState = previousState } );
			}
		}

		public DateTime LastActivityTime { get; set; }

		public double ImageOpacity {
			get {
				return _imageOpacity;
			}
			set {
				_imageOpacity = value;
				UpdateMouseImage();
			}
		}

		public bool KeepAlive { get; set; }

		protected IConfigurationServices ConfigurationServices { get; set; }

		#endregion

		#region Methods
		
		public virtual void FadeIn() {
			 if (_fadeInSemaphore.Wait(0)) {
				 try {
					 _fadingOut = false;
					 if (ImageOpacity <= Settings.ScreenMouseIdleAlpha) {
						 _fadeStartTime = DateTime.Now;
						 _fadeStartOpacity = ImageOpacity;
						 _fadeEndOpacity = Settings.ScreenMouseIdleAlpha;
						 if (State == ScreenMouseState.Inactive) {
							 ExecuteInUIFriendlyContext(() => State = ScreenMouseState.Active);
						 }
					 }
				 } finally {
				 	_fadeInSemaphore.Release();
				 }
			 }
		}

		public virtual void FadeOut() {
			if (_fadeOutSemaphore.Wait(0)) {
				try {
					if (State != ScreenMouseState.Inactive) {
						_fadeEndOpacity = 0;
						_fadingOut = true;
						_fadeStartTime = DateTime.Now;
						_fadeStartOpacity = ImageOpacity;
					}
				}
				finally {
					_fadeOutSemaphore.Release();
				}
			}
		}

		public virtual void FadeToFullOpacity() {
			if (_fadeToFullSemaphore.Wait(0)) {
				try {
					_fadingOut = false;
					if (ImageOpacity <= Settings.ScreenMouseActiveAlpha) {
						_fadeStartTime = DateTime.Now;
						_fadeStartOpacity = ImageOpacity;
						_fadeEndOpacity = Settings.ScreenMouseActiveAlpha;
						if (State == ScreenMouseState.Inactive) {
							ExecuteInUIFriendlyContext(() => State = ScreenMouseState.Active);
						}
					}
				}
				finally {
					_fadeToFullSemaphore.Release();
				}
			}
		}

		public virtual void MoveTo(int screenX, int screenY) {
			LastActivityTime = DateTime.Now;
		}

		protected abstract void ExecuteInUIFriendlyContext(Action action);

		protected abstract void SetBackgroundBitmap(Bitmap bitmap, byte opacity);

		protected virtual void OnTimerTick() {
			DateTime now = DateTime.Now;

			// Turn off Keep Alive if the setting is no longer ManuallyActivateScreenMouse
			if (Settings.MouseStoppedBehavior != AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse && KeepAlive) {
				KeepAlive = false;
			}

			// Begin to fade out if no activity
			if (State == ScreenMouseState.Active && now.Subtract(LastActivityTime) > Settings.ScreenMouseTimeout && !_fadingOut && !KeepAlive) {
				FadeOut();
			}

			// Note we are not fading out anymore when completely faded out
			if (_fadingOut && ImageOpacity == _fadeEndOpacity) {
				_fadingOut = false;
			}

			// Do the actual fade in or out by the appropriate amount in this iteration
			if (ImageOpacity != _fadeEndOpacity) {
				// s = s0 + v*t
				double fadeDuration = Settings.ScreenMouseFadeDuration.TotalSeconds.ClipTo(Tool.EPSILON, float.MaxValue);
				ImageOpacity =
					(ImageOpacity + (_fadeEndOpacity - _fadeStartOpacity) / fadeDuration * now.Subtract(_fadeStartTime).TotalSeconds)
					.ClipTo(
						Math.Min(_fadeStartOpacity, _fadeEndOpacity),
						Math.Max(_fadeStartOpacity, _fadeEndOpacity)
					);
			}
			// Form has faded out completely, so make it inactive
			if (_fadingOut && ImageOpacity <= 0) {
				_fadingOut = false;
				State = ScreenMouseState.Inactive;
			}
		}

		protected virtual void OnStateChanged(ScreenMouseStateChangedEvent @event) {
			switch(State) {
				case ScreenMouseState.Active:
					LastActivityTime = DateTime.Now;
					if (!_timer.Enabled) {
						_timer.Start();
					}
					break;
				case ScreenMouseState.Inactive:
					if (_timer.Enabled) {
						_timer.Stop();
					}
					break;
				default:
					if (!_timer.Enabled) {
						_timer.Start();
					}
					break;
			}
		}

		protected virtual void UpdateMouseImage() {
			Icon icon; 
			switch (_mouseButton) {
				case MouseButton.Left:
					icon = Resources.MouseLeftButton;
					break;
				case MouseButton.Middle:
					icon = Resources.MouseMiddleButton;
					break;
				case MouseButton.Right:
					icon = Resources.MouseRightButton;
					break;
				case MouseButton.None:
					icon = Resources.MouseNoButton;
					break;
				default:
					icon = Resources.MouseNoButton;
					break;
			}
			using (icon) {
				using (var resizedIcon = new Icon(icon, new Size(Width, Height))) {
					ExecuteInUIFriendlyContext( () => SetBackgroundBitmap(resizedIcon.ToBitmap(), (byte)(255.0 * ImageOpacity)) );
				}
			}
		}

		protected virtual void FireStateChangedEvent(ScreenMouseStateChangedEvent @event) {
			OnStateChanged(@event);
			if (StateChanged != null) {
				StateChanged(this, @event);
			}
		}

		#endregion

		#region Event Handlers

		void  _timer_Elapsed(object sender, ElapsedEventArgs e) {
			OnTimerTick();
		}

		#endregion
		
	}
}
