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
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows;
using Sphere10.Framework.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Resources = AutoMouse.Windows.Properties.Resources;

namespace AutoMouse.Windows;

[UseSettings(typeof(AutoMouseSettings))]
public partial class AutoMouseSettingsControl : ApplicationControl, IHelpableObject {
	public AutoMouseSettingsControl() {
		InitializeComponent();
		_screenMousePictureBox.Image = Resources.MouseLMRSettingsAid;

		if (!Tools.Runtime.IsDesignMode) {
			AutoRunServices = Sphere10Framework.Instance.ServiceProvider.GetService<IAutoRunServices>();
			ProductInformationProvider = Sphere10Framework.Instance.ServiceProvider.GetService<IProductInformationProvider>();
		}
	}

	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public AutoMouseSettings Settings {
		get { return UserSettings.Get<AutoMouseSettings>(); }
	}

	protected IAutoRunServices AutoRunServices { get; }

	protected IProductInformationProvider ProductInformationProvider { get; }

	public override void SetLocalizedText(CultureInfo culture = null) {
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

	protected override void InitializeUIPrimingData() {
		_screenMouseActivationKeyComboBox.EnumType = typeof(Key);
		_screenMouseLeftComboBox.EnumType = typeof(Key);
		_screenMouseMiddleComboBox.EnumType = typeof(Key);
		_screenMouseRightComboBox.EnumType = typeof(Key);
	}

	protected override void CopyUIToModel() {
		if (_showClickSelectorRadioButton.Checked) {
			Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.AutoActivateScreenMouse;
		}
		if (_autoClickRadioButton.Checked) {
			Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.AutoClickOnMouseStop;
		}
		if (_openScreenMouseManuallyRadioButton.Checked) {
			Settings.MouseStoppedBehavior = AutoMouseSettings.AutoMouseBehavior.ManuallyActivateScreenMouse;
		}
		WinAPI.USER32.SwapMouseButton(_flipLeftRightMouseButtons.Checked);
		Settings.ShowExpandingRings = _showExpandingRingsCheckBox.Checked;
		Settings.MakeClickSound = _makeClickSoundCheckBox.Checked;
		Settings.KeyboardArrowsMoveScreenMouse = _keyboardArrowsCanMoveCheckBox.Checked;
		Settings.AutoStartProgram = _startProgramWithWindowsCheckBox.Checked;
		// Set the autorun in the OS
		if (Settings.AutoStartProgram && !AutoRunServices.DoesAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Application.ExecutablePath)) {
			AutoRunServices.SetAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Application.ExecutablePath, null);
		} else {
			AutoRunServices.RemoveAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Application.ExecutablePath);
		}
		Settings.ScreenMouseActivationKey = (Key)_screenMouseActivationKeyComboBox.SelectedEnum;
		Settings.ScreenMouseTimeout = TimeSpan.FromSeconds((double)_screenMouseTimeoutNumeric.Value);
		Settings.LeftButtonKey = (Key)_screenMouseLeftComboBox.SelectedEnum;
		Settings.MiddleButtonKey = (Key)_screenMouseMiddleComboBox.SelectedEnum;
		Settings.RightButtonKey = (Key)_screenMouseRightComboBox.SelectedEnum;

		if (_leftButtonRadioButton.Checked) {
			Settings.AutoClickButton = MouseButton.Left;
		}
		if (_middleButtonRadioButton.Checked) {
			Settings.AutoClickButton = MouseButton.Middle;
		}
		if (_rightButtonRadioButton.Checked) {
			Settings.AutoClickButton = MouseButton.Right;
		}
		if (_singleClickRadioButton.Checked) {
			Settings.AutoClickType = MouseClickType.Single;
		}
		if (_doubleClickRadioButton.Checked) {
			Settings.AutoClickType = MouseClickType.Double;
		}
		if (_trippleClickRadioButton.Checked) {
			Settings.AutoClickType = MouseClickType.Tripple;
		}
		Settings.MouseStoppedIntervalMS = (int)_mouseStoppedDuration.Value;
		Settings.MultipleClickIntervalMS = (int)_clickIntervalNumeric.Value;
		Settings.ExpandingRingRadius = (int)_expandingRingRadiusNumeric.Value;
		Settings.ScreenMouseIdleAlphaPercentage = (int)_screenMouseIdleTranslucencyNumeric.Value;
		Settings.ScreenMouseActiveAlphaPercentage = (int)_screenMouseActiveTranslucencyNumeric.Value;
		Settings.ClickFreeZoneRadius = _clickRadiusSelector.SelectedRadius;
		Settings.Save();
	}

	protected override void CopyModelToUI() {
		base.CopyModelToUI();
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
		_flipLeftRightMouseButtons.Checked = WinAPI.USER32.GetSystemMetrics(WinAPI.USER32.SystemMetric.SM_SWAPBUTTON) != 0;
		_showExpandingRingsCheckBox.Checked = Settings.ShowExpandingRings;
		_keyboardArrowsCanMoveCheckBox.Checked = Settings.KeyboardArrowsMoveScreenMouse;
		_makeClickSoundCheckBox.Checked = Settings.MakeClickSound;
		_startProgramWithWindowsCheckBox.Checked = Settings.AutoStartProgram;
		_screenMouseActivationKeyComboBox.SelectedEnum = Settings.ScreenMouseActivationKey;
		_screenMouseTimeoutNumeric.Value = (decimal)TimeSpan.FromMilliseconds(Settings.ScreenMouseTimeoutMS).TotalSeconds;
		_screenMouseLeftComboBox.SelectedEnum = Settings.LeftButtonKey;
		_screenMouseMiddleComboBox.SelectedEnum = Settings.MiddleButtonKey;
		_screenMouseRightComboBox.SelectedEnum = Settings.RightButtonKey;

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

		_mouseStoppedDuration.Value = Settings.MouseStoppedIntervalMS;
		_clickIntervalNumeric.Value = Settings.MultipleClickIntervalMS;
		_expandingRingRadiusNumeric.Value = Settings.ExpandingRingRadius;
		_screenMouseIdleTranslucencyNumeric.Value = Settings.ScreenMouseIdleAlphaPercentage;
		_screenMouseActiveTranslucencyNumeric.Value = Settings.ScreenMouseActiveAlphaPercentage;
		_clickRadiusSelector.SelectedRadius = Settings.ClickFreeZoneRadius;

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
			if (_tabControl.SelectedTab == _generalTab) {
				topicId = 300;
			} else if (_tabControl.SelectedTab == _screenMouseTab) {
				topicId = 400;
			} else if (_tabControl.SelectedTab == _autoClickTab) {
				topicId = 500;
			} else if (_tabControl.SelectedTab == _advancedTab) {
				topicId = 600;
			} else {
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