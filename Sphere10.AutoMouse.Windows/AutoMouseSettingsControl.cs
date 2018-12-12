using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Sphere10.Application;
using Sphere10.Application.WinForms;
using Sphere10.Common;
using Sphere10.Windows;

namespace Sphere10.AutoMouse.Windows
{
	[UseSettings(typeof(AutoMouseSettings))]
    public partial class AutoMouseSettingsControl : ApplicationControl, IHelpableObject
    {
		
        public AutoMouseSettingsControl() {
			InitializeComponent();
			_screenMousePictureBox.Image = AutoMouse.Properties.Resources.MouseLMRSettingsAid;
        	AutoDetectChildStateChanges = true;
        }

		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		public AutoMouseSettings Settings {
			get { return base.LocatedSettings as AutoMouseSettings; }
		}

		public override void SetLocalizedText(System.Globalization.CultureInfo culture = null) {
			//_showClickSelectorRadioButton.Text = Properties.Resources.TXT_Show_Me_The_Click_Selector_Form_When_Mouse_Stops_Moving;
			//_autoClickRadioButton.Text = Properties.Resources.TXT_Automatically_Click_The_Mouse_When_Mouse_Stops_Moving;
			//_leftButtonKeyLabel.Text = Properties.Resources.TXT_What_Key_Will_Activate_The_Click_Selector_Form;
			//_selectRadiusGroupBox.Text = Properties.Resources.TXT_What_Distance_Of_Motion_Should_Not_Be_Considered_An_AutoClick;
			//_clickGroupBox.Text = Properties.Resources.TXT_Select_The_Type_Of_Click_To_Simulate;
			//_singleClickRadioButton.Text = Properties.Resources.TXT_Single_Click;
			//_doubleClickRadioButton.Text = Properties.Resources.TXT_Double_Click;
			//_trippleClickRadioButton.Text = Properties.Resources.TXT_Triple_Click;
			//_buttonGroupBox.Text = Properties.Resources.TXT_Select_The_Mouse_Button_To_Simulate;
			//_leftButtonRadioButton.Text = Properties.Resources.TXT_Left_Button;
			//_middleButtonRadioButton.Text = Properties.Resources.TXT_Middle_Button;
			//_rightButtonRadioButton.Text = Properties.Resources.TXT_Right_Button;
		}

		protected override void PopulatePrimingData() {
			// Set priming data
			_screenMouseActivationKeyComboBox.DisplayMember = "Item1";
			_screenMouseActivationKeyComboBox.ValueMember = "Item2";
			_screenMouseActivationKeyComboBox.DataSource = new Tuple<string, Key>[] { 
					Tuple.Create("Left Shift", Key.LShiftKey),
					Tuple.Create("Right Shift", Key.RShiftKey),
			        Tuple.Create("Left Control", Key.LControlKey),
			        Tuple.Create("Right Control", Key.RControlKey),
					Tuple.Create("Alt", Key.Alt)
			    };

			_screenMouseIdleTranslucencyNumeric.Minimum = 5;
			_screenMouseIdleTranslucencyNumeric.Maximum = 100;
			_screenMouseIdleTranslucencyNumeric.Increment = 1;

			_screenMouseActiveTranslucencyNumeric.Minimum = 5;
			_screenMouseActiveTranslucencyNumeric.Maximum = 100;
			_screenMouseActiveTranslucencyNumeric.Increment = 1;

			_screenMouseTimeoutNumeric.Minimum = 1;
			_screenMouseTimeoutNumeric.Increment = 1;
			_screenMouseTimeoutNumeric.Maximum = 10;
			_screenMouseTimeoutNumeric.DecimalPlaces = 0;

			_screenMouseLeftComboBox.DisplayMember =
			_screenMouseMiddleComboBox.DisplayMember =
			_screenMouseRightComboBox.DisplayMember = "Item1";
			_screenMouseLeftComboBox.ValueMember =
			_screenMouseMiddleComboBox.ValueMember =
			_screenMouseRightComboBox.ValueMember = "Item2";

			var keyDataSource =
				from key in Enum.GetValues(typeof (Key)).Cast<Key>()
				select Tuple.Create(key.ToString(), key);

			_screenMouseLeftComboBox.DataSource = new List<Tuple<string,Key>>(keyDataSource);
			_screenMouseMiddleComboBox.DataSource = new List<Tuple<string, Key>>(keyDataSource);
			_screenMouseRightComboBox.DataSource = new List<Tuple<string, Key>>(keyDataSource);


			_clickIntervalNumeric.Minimum = 10;
			_clickIntervalNumeric.Increment = 10;
			_clickIntervalNumeric.Maximum = 500;
			_clickIntervalNumeric.DecimalPlaces = 0;

			_expandingRingRadiusNumeric.Minimum = 10;
			_expandingRingRadiusNumeric.Increment = 10;
			_expandingRingRadiusNumeric.Maximum = 100;
			_expandingRingRadiusNumeric.DecimalPlaces = 0;
		}

        protected override void RefreshUserInterfaceWithDataSource() {
			switch (Settings.MouseStoppedBehavior) {
				case AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse:
					_showClickSelectorRadioButton.Checked = true;
					_autoClickRadioButton.Checked = false;
					_openScreenMouseManuallyRadioButton.Checked = false;
					break;
				case AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop:
					_showClickSelectorRadioButton.Checked = false;
					_autoClickRadioButton.Checked = true;
					_openScreenMouseManuallyRadioButton.Checked = false;
					break;
				case AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse:
					_showClickSelectorRadioButton.Checked = false;
					_autoClickRadioButton.Checked = false;
					_openScreenMouseManuallyRadioButton.Checked = true;
					break;
			}
            _flipLeftRightMouseButtons.Checked = Win32.GetSystemMetrics(Win32.SystemMetric.SM_SWAPBUTTON) != 0;
        	_showExpandingRingsCheckBox.Checked = Settings.ShowExpandingRings;
			_keyboardArrowsCanMoveCheckBox.Checked = Settings.KeyboardArrowsMoveScreenMouse;
			_makeClickSoundCheckBox.Checked = Settings.MakeClickSound;
        	_startProgramWithWindowsCheckBox.Checked = Settings.AutoStartProgram;
        	_screenMouseActivationKeyComboBox.SelectedValue = Settings.ScreenMouseActivationKey;
        	_screenMouseTimeoutNumeric.Value = (decimal)TimeSpan.FromMilliseconds(Settings.ScreenMouseTimeoutMS).TotalSeconds;
        	_screenMouseLeftComboBox.SelectedValue = Settings.LeftButtonKey;
			_screenMouseMiddleComboBox.SelectedValue = Settings.MiddleButtonKey;
			_screenMouseRightComboBox.SelectedValue = Settings.RightButtonKey;

			switch (Settings.AutoClickButton) {
                case MouseButton.Left:
                    _leftButtonRadioButton.Checked = true;
                    break;
                case MouseButton.Middle:
                    _middleButtonRadioButton.Checked = true;
                    break;
                case MouseButton.Right:
                    _rightButtonRadioButton.Checked = true;
                    break;
                default:
                    _leftButtonRadioButton.Checked = true;
                    break;
            }
			switch (Settings.AutoClickType) {
                case MouseClickType.Single:
                    _singleClickRadioButton.Checked = true;
                    break;
                case MouseClickType.Double:
                    _doubleClickRadioButton.Checked = true;
                    break;
                case MouseClickType.Tripple:
                    _trippleClickRadioButton.Checked = true;
                    break;
                default:
                    _singleClickRadioButton.Checked = true;
                    break;
            }

			_clickIntervalNumeric.Value = Settings.MultipleClickIntervalMS;
        	_expandingRingRadiusNumeric.Value = Settings.ExpandingRingRadius;
			_screenMouseIdleTranslucencyNumeric.Value = Settings.ScreenMouseIdleAlphaPercentage;
			_screenMouseActiveTranslucencyNumeric.Value = Settings.ScreenMouseActiveAlphaPercentage;
			_clickRadiusSelector.SelectedRadius = Settings.ClickFreeZoneRadius;
        }

		protected override void SaveUserInputToDataSource() {
			if (_showClickSelectorRadioButton.Checked) {
				Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse;
			}
			if (_autoClickRadioButton.Checked) {
				Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop;
			}
			if (_openScreenMouseManuallyRadioButton.Checked) {
				Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse;
			}
            Win32.SwapMouseButton(_flipLeftRightMouseButtons.Checked);
			Settings.ShowExpandingRings = _showExpandingRingsCheckBox.Checked;
			Settings.MakeClickSound = _makeClickSoundCheckBox.Checked;
			Settings.KeyboardArrowsMoveScreenMouse = _keyboardArrowsCanMoveCheckBox.Checked;
			Settings.AutoStartProgram = _startProgramWithWindowsCheckBox.Checked;
			// Set the autorun in the OS
			if (Settings.AutoStartProgram && !ApplicationServices.DoesAutoRun(AutoRunType.CurrentUser, ApplicationServices.ProductInformation.ProductName, System.Windows.Forms.Application.ExecutablePath)) {
				ApplicationServices.SetAutoRun(AutoRunType.CurrentUser, ApplicationServices.ProductInformation.ProductName, System.Windows.Forms.Application.ExecutablePath);
			} else {
				ApplicationServices.RemoveAutoRun(AutoRunType.CurrentUser, ApplicationServices.ProductInformation.ProductName, System.Windows.Forms.Application.ExecutablePath);
			}
			Settings.ScreenMouseActivationKey = (Key)_screenMouseActivationKeyComboBox.SelectedValue;
			Settings.ScreenMouseTimeout = TimeSpan.FromSeconds((double)_screenMouseTimeoutNumeric.Value);
			Settings.LeftButtonKey = (Key)_screenMouseLeftComboBox.SelectedValue;
			Settings.MiddleButtonKey = (Key)_screenMouseMiddleComboBox.SelectedValue;
			Settings.RightButtonKey = (Key)_screenMouseRightComboBox.SelectedValue;

			if (_leftButtonRadioButton.Checked) {
				Settings.AutoClickButton = MouseButton.Left;
			}
			if (_middleButtonRadioButton.Checked) {
				Settings.AutoClickButton = MouseButton.Middle;
			}
			if (_rightButtonRadioButton.Checked) {
				Settings.AutoClickButton = MouseButton.Right;
			}

			
			if(_singleClickRadioButton.Checked) {
			Settings.AutoClickType = MouseClickType.Single;	
			}
			if(_doubleClickRadioButton.Checked) {
				Settings.AutoClickType = MouseClickType.Double;
			}
			if(_trippleClickRadioButton.Checked) {
				Settings.AutoClickType = MouseClickType.Tripple;
			}
			Settings.MultipleClickIntervalMS = (int)_clickIntervalNumeric.Value;
			Settings.ExpandingRingRadius = (int)_expandingRingRadiusNumeric.Value;
            Settings.ScreenMouseIdleAlphaPercentage = (int)_screenMouseIdleTranslucencyNumeric.Value;
            Settings.ScreenMouseActiveAlphaPercentage = (int)_screenMouseActiveTranslucencyNumeric.Value;
			Settings.ClickFreeZoneRadius = _clickRadiusSelector.SelectedRadius;
			Settings.Save();
		}

		#region IHelpableObject Implementation

		public HelpType Type {
			get {
				return HelpType.CHM;
			}
		}

		public string FileName {
			get {
				return null; // gotten from global scope
			}
		}

		public string Url {
			get {
				return null;
			}
		}

		public int? PageNumber {
			get {
				return null;
			}
		}


		public int? HelpTopicID {
			get {
                int topicId = 1;
                if (_tabControl.SelectedTab == _generalTab)
                {
                    topicId = 300;
                }
                else if (_tabControl.SelectedTab == _screenMouseTab)
                {
                    topicId = 400;
                }
                else if (_tabControl.SelectedTab == _autoClickTab)
                {
                    topicId = 500;
                } else if (_tabControl.SelectedTab == _advancedTab)
                {
                    topicId = 600;
                }
                else
                {
                    topicId = 1;
                }
                return topicId;
			}
		}


		public int? HelpTopicAlias {
			get {
				return null;
			}
		}

		#endregion

        
       
	}
}

