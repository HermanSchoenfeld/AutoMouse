// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System.ComponentModel;
using System.Windows.Forms;

namespace AutoMouse.Windows {
	partial class AutoMouseSettingsControl {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			components = new Container();
			var resources = new ComponentResourceManager(typeof(AutoMouseSettingsControl));
			_buttonGroupBox = new GroupBox();
			arrayGrid1 = new SourceGrid.ArrayGrid();
			label25 = new Label();
			_rightButtonRadioButton = new RadioButton();
			_middleButtonRadioButton = new RadioButton();
			_leftButtonRadioButton = new RadioButton();
			_selectRadiusGroupBox = new GroupBox();
			label1 = new Label();
			_clickRadiusSelector = new ClickRadiusSelector();
			_showClickSelectorRadioButton = new RadioButton();
			_autoClickRadioButton = new RadioButton();
			_singleClickRadioButton = new RadioButton();
			_doubleClickRadioButton = new RadioButton();
			_trippleClickRadioButton = new RadioButton();
			_clickGroupBox = new GroupBox();
			label24 = new Label();
			_tabControl = new TabControl();
			_generalTab = new TabPage();
			groupBox4 = new GroupBox();
			_flipLeftRightMouseButtons = new CheckBox();
			_makeClickSoundCheckBox = new CheckBox();
			_keyboardArrowsCanMoveCheckBox = new CheckBox();
			_showExpandingRingsCheckBox = new CheckBox();
			_startProgramWithWindowsCheckBox = new CheckBox();
			groupBox2 = new GroupBox();
			_openScreenMouseManuallyRadioButton = new RadioButton();
			_screenMouseTab = new TabPage();
			groupBox5 = new GroupBox();
			_screenMouseActivationKeyComboBox = new Sphere10.Framework.Windows.Forms.EnumComboBox();
			label8 = new Label();
			label2 = new Label();
			label9 = new Label();
			label10 = new Label();
			_screenMouseTimeoutNumeric = new NumericUpDown();
			groupBox3 = new GroupBox();
			label17 = new Label();
			label16 = new Label();
			label12 = new Label();
			label11 = new Label();
			_screenMouseLeftComboBox = new Sphere10.Framework.Windows.Forms.EnumComboBox();
			label13 = new Label();
			_screenMouseMiddleComboBox = new Sphere10.Framework.Windows.Forms.EnumComboBox();
			label14 = new Label();
			_screenMousePictureBox = new PictureBox();
			_screenMouseRightComboBox = new Sphere10.Framework.Windows.Forms.EnumComboBox();
			label15 = new Label();
			_autoClickTab = new TabPage();
			_advancedTab = new TabPage();
			groupBox1 = new GroupBox();
			_mouseStoppedDuration = new NumericUpDown();
			label19 = new Label();
			label20 = new Label();
			label22 = new Label();
			label23 = new Label();
			_screenMouseActiveTranslucencyNumeric = new NumericUpDown();
			label7 = new Label();
			label18 = new Label();
			_screenMouseIdleTranslucencyNumeric = new NumericUpDown();
			label6 = new Label();
			label4 = new Label();
			_expandingRingRadiusNumeric = new NumericUpDown();
			label5 = new Label();
			label3 = new Label();
			_clickIntervalNumeric = new NumericUpDown();
			toolTip1 = new ToolTip(components);
			_buttonGroupBox.SuspendLayout();
			_selectRadiusGroupBox.SuspendLayout();
			_clickGroupBox.SuspendLayout();
			_tabControl.SuspendLayout();
			_generalTab.SuspendLayout();
			groupBox4.SuspendLayout();
			groupBox2.SuspendLayout();
			_screenMouseTab.SuspendLayout();
			groupBox5.SuspendLayout();
			((ISupportInitialize)_screenMouseTimeoutNumeric).BeginInit();
			groupBox3.SuspendLayout();
			((ISupportInitialize)_screenMousePictureBox).BeginInit();
			_autoClickTab.SuspendLayout();
			_advancedTab.SuspendLayout();
			groupBox1.SuspendLayout();
			((ISupportInitialize)_mouseStoppedDuration).BeginInit();
			((ISupportInitialize)_screenMouseActiveTranslucencyNumeric).BeginInit();
			((ISupportInitialize)_screenMouseIdleTranslucencyNumeric).BeginInit();
			((ISupportInitialize)_expandingRingRadiusNumeric).BeginInit();
			((ISupportInitialize)_clickIntervalNumeric).BeginInit();
			SuspendLayout();
			// 
			// _buttonGroupBox
			// 
			_buttonGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_buttonGroupBox.Controls.Add(arrayGrid1);
			_buttonGroupBox.Controls.Add(label25);
			_buttonGroupBox.Controls.Add(_rightButtonRadioButton);
			_buttonGroupBox.Controls.Add(_middleButtonRadioButton);
			_buttonGroupBox.Controls.Add(_leftButtonRadioButton);
			_buttonGroupBox.Location = new System.Drawing.Point(6, 121);
			_buttonGroupBox.Name = "_buttonGroupBox";
			_buttonGroupBox.Size = new System.Drawing.Size(511, 274);
			_buttonGroupBox.TabIndex = 6;
			_buttonGroupBox.TabStop = false;
			_buttonGroupBox.Text = "Auto Click Button";
			// 
			// arrayGrid1
			// 
			arrayGrid1.EnableSort = true;
			arrayGrid1.Location = new System.Drawing.Point(159, 201);
			arrayGrid1.Name = "arrayGrid1";
			arrayGrid1.SelectionMode = SourceGrid.GridSelectionMode.Cell;
			arrayGrid1.Size = new System.Drawing.Size(8, 8);
			arrayGrid1.TabIndex = 32;
			arrayGrid1.TabStop = true;
			arrayGrid1.ToolTipText = "";
			// 
			// label25
			// 
			label25.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label25.Location = new System.Drawing.Point(110, 24);
			label25.Name = "label25";
			label25.Size = new System.Drawing.Size(378, 61);
			label25.TabIndex = 31;
			label25.Text = "When auto clicking is enalbed, this will determine the button that will be simulated.";
			// 
			// _rightButtonRadioButton
			// 
			_rightButtonRadioButton.AutoSize = true;
			_rightButtonRadioButton.Location = new System.Drawing.Point(19, 68);
			_rightButtonRadioButton.Name = "_rightButtonRadioButton";
			_rightButtonRadioButton.Size = new System.Drawing.Size(53, 19);
			_rightButtonRadioButton.TabIndex = 7;
			_rightButtonRadioButton.TabStop = true;
			_rightButtonRadioButton.Text = "Right";
			_rightButtonRadioButton.UseVisualStyleBackColor = true;
			// 
			// _middleButtonRadioButton
			// 
			_middleButtonRadioButton.AutoSize = true;
			_middleButtonRadioButton.Location = new System.Drawing.Point(19, 45);
			_middleButtonRadioButton.Name = "_middleButtonRadioButton";
			_middleButtonRadioButton.Size = new System.Drawing.Size(62, 19);
			_middleButtonRadioButton.TabIndex = 6;
			_middleButtonRadioButton.TabStop = true;
			_middleButtonRadioButton.Text = "Middle";
			_middleButtonRadioButton.UseVisualStyleBackColor = true;
			// 
			// _leftButtonRadioButton
			// 
			_leftButtonRadioButton.AutoSize = true;
			_leftButtonRadioButton.Location = new System.Drawing.Point(19, 22);
			_leftButtonRadioButton.Name = "_leftButtonRadioButton";
			_leftButtonRadioButton.Size = new System.Drawing.Size(45, 19);
			_leftButtonRadioButton.TabIndex = 5;
			_leftButtonRadioButton.TabStop = true;
			_leftButtonRadioButton.Text = "Left";
			_leftButtonRadioButton.UseVisualStyleBackColor = true;
			// 
			// _selectRadiusGroupBox
			// 
			_selectRadiusGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			_selectRadiusGroupBox.Controls.Add(label1);
			_selectRadiusGroupBox.Controls.Add(_clickRadiusSelector);
			_selectRadiusGroupBox.Location = new System.Drawing.Point(9, 176);
			_selectRadiusGroupBox.Name = "_selectRadiusGroupBox";
			_selectRadiusGroupBox.Size = new System.Drawing.Size(508, 219);
			_selectRadiusGroupBox.TabIndex = 7;
			_selectRadiusGroupBox.TabStop = false;
			_selectRadiusGroupBox.Text = "Discard Zone";
			// 
			// label1
			// 
			label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			label1.Location = new System.Drawing.Point(219, 30);
			label1.Name = "label1";
			label1.Size = new System.Drawing.Size(283, 72);
			label1.TabIndex = 9;
			label1.Text = "Motion within this zone will be discarded. This means you will need to move the mouse beyond this zone to activate any of the features.";
			// 
			// _clickRadiusSelector
			// 
			_clickRadiusSelector.BackColor = System.Drawing.SystemColors.Window;
			_clickRadiusSelector.Location = new System.Drawing.Point(19, 30);
			_clickRadiusSelector.Name = "_clickRadiusSelector";
			_clickRadiusSelector.SelectedRadius = 100;
			_clickRadiusSelector.Size = new System.Drawing.Size(194, 183);
			_clickRadiusSelector.TabIndex = 8;
			// 
			// _showClickSelectorRadioButton
			// 
			_showClickSelectorRadioButton.AutoSize = true;
			_showClickSelectorRadioButton.Checked = true;
			_showClickSelectorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			_showClickSelectorRadioButton.Location = new System.Drawing.Point(19, 19);
			_showClickSelectorRadioButton.Name = "_showClickSelectorRadioButton";
			_showClickSelectorRadioButton.Size = new System.Drawing.Size(291, 17);
			_showClickSelectorRadioButton.TabIndex = 9;
			_showClickSelectorRadioButton.TabStop = true;
			_showClickSelectorRadioButton.Text = "Let me click the mouse using the keys from my keyboard";
			toolTip1.SetToolTip(_showClickSelectorRadioButton, "As you move your mouse you will be able to click the mouse by pressing keys from your keyboard (via the Screen Mouse).");
			_showClickSelectorRadioButton.UseVisualStyleBackColor = true;
			// 
			// _autoClickRadioButton
			// 
			_autoClickRadioButton.AutoSize = true;
			_autoClickRadioButton.Location = new System.Drawing.Point(19, 48);
			_autoClickRadioButton.Name = "_autoClickRadioButton";
			_autoClickRadioButton.Size = new System.Drawing.Size(352, 19);
			_autoClickRadioButton.TabIndex = 10;
			_autoClickRadioButton.Text = "Automatically click the mouse when I stop moving the mouse";
			toolTip1.SetToolTip(_autoClickRadioButton, "When you stop moving the mouse, a click will automatically be made at the cursors current position.");
			_autoClickRadioButton.UseVisualStyleBackColor = true;
			// 
			// _singleClickRadioButton
			// 
			_singleClickRadioButton.AutoSize = true;
			_singleClickRadioButton.Location = new System.Drawing.Point(19, 22);
			_singleClickRadioButton.Name = "_singleClickRadioButton";
			_singleClickRadioButton.Size = new System.Drawing.Size(57, 19);
			_singleClickRadioButton.TabIndex = 2;
			_singleClickRadioButton.TabStop = true;
			_singleClickRadioButton.Text = "Single";
			_singleClickRadioButton.UseVisualStyleBackColor = true;
			// 
			// _doubleClickRadioButton
			// 
			_doubleClickRadioButton.AutoSize = true;
			_doubleClickRadioButton.Location = new System.Drawing.Point(19, 45);
			_doubleClickRadioButton.Name = "_doubleClickRadioButton";
			_doubleClickRadioButton.Size = new System.Drawing.Size(63, 19);
			_doubleClickRadioButton.TabIndex = 3;
			_doubleClickRadioButton.TabStop = true;
			_doubleClickRadioButton.Text = "Double";
			_doubleClickRadioButton.UseVisualStyleBackColor = true;
			// 
			// _trippleClickRadioButton
			// 
			_trippleClickRadioButton.AutoSize = true;
			_trippleClickRadioButton.Location = new System.Drawing.Point(19, 68);
			_trippleClickRadioButton.Name = "_trippleClickRadioButton";
			_trippleClickRadioButton.Size = new System.Drawing.Size(53, 19);
			_trippleClickRadioButton.TabIndex = 4;
			_trippleClickRadioButton.TabStop = true;
			_trippleClickRadioButton.Text = "Triple";
			_trippleClickRadioButton.UseVisualStyleBackColor = true;
			// 
			// _clickGroupBox
			// 
			_clickGroupBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			_clickGroupBox.Controls.Add(label24);
			_clickGroupBox.Controls.Add(_trippleClickRadioButton);
			_clickGroupBox.Controls.Add(_doubleClickRadioButton);
			_clickGroupBox.Controls.Add(_singleClickRadioButton);
			_clickGroupBox.Location = new System.Drawing.Point(6, 6);
			_clickGroupBox.Name = "_clickGroupBox";
			_clickGroupBox.Size = new System.Drawing.Size(511, 109);
			_clickGroupBox.TabIndex = 5;
			_clickGroupBox.TabStop = false;
			_clickGroupBox.Text = "Auto Click Type";
			// 
			// label24
			// 
			label24.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			label24.Location = new System.Drawing.Point(110, 24);
			label24.Name = "label24";
			label24.Size = new System.Drawing.Size(375, 61);
			label24.TabIndex = 30;
			label24.Text = "When auto clicking is enabled, this will determine the type of click that will be simulated.";
			// 
			// _tabControl
			// 
			_tabControl.Controls.Add(_generalTab);
			_tabControl.Controls.Add(_screenMouseTab);
			_tabControl.Controls.Add(_autoClickTab);
			_tabControl.Controls.Add(_advancedTab);
			_tabControl.Dock = DockStyle.Fill;
			_tabControl.Location = new System.Drawing.Point(0, 0);
			_tabControl.Margin = new Padding(0);
			_tabControl.Name = "_tabControl";
			_tabControl.SelectedIndex = 0;
			_tabControl.Size = new System.Drawing.Size(531, 429);
			_tabControl.TabIndex = 22;
			// 
			// _generalTab
			// 
			_generalTab.Controls.Add(groupBox4);
			_generalTab.Controls.Add(groupBox2);
			_generalTab.Location = new System.Drawing.Point(4, 24);
			_generalTab.Name = "_generalTab";
			_generalTab.Padding = new Padding(3);
			_generalTab.Size = new System.Drawing.Size(523, 401);
			_generalTab.TabIndex = 0;
			_generalTab.Text = "General";
			_generalTab.UseVisualStyleBackColor = true;
			// 
			// groupBox4
			// 
			groupBox4.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox4.Controls.Add(_flipLeftRightMouseButtons);
			groupBox4.Controls.Add(_makeClickSoundCheckBox);
			groupBox4.Controls.Add(_keyboardArrowsCanMoveCheckBox);
			groupBox4.Controls.Add(_showExpandingRingsCheckBox);
			groupBox4.Controls.Add(_startProgramWithWindowsCheckBox);
			groupBox4.Location = new System.Drawing.Point(6, 135);
			groupBox4.Name = "groupBox4";
			groupBox4.Size = new System.Drawing.Size(511, 260);
			groupBox4.TabIndex = 34;
			groupBox4.TabStop = false;
			groupBox4.Text = "Other Options";
			// 
			// _flipLeftRightMouseButtons
			// 
			_flipLeftRightMouseButtons.AutoSize = true;
			_flipLeftRightMouseButtons.Location = new System.Drawing.Point(19, 19);
			_flipLeftRightMouseButtons.Name = "_flipLeftRightMouseButtons";
			_flipLeftRightMouseButtons.Size = new System.Drawing.Size(332, 19);
			_flipLeftRightMouseButtons.TabIndex = 40;
			_flipLeftRightMouseButtons.Text = "Flip the left and right mouse buttons for left-handed users";
			_flipLeftRightMouseButtons.UseVisualStyleBackColor = true;
			// 
			// _makeClickSoundCheckBox
			// 
			_makeClickSoundCheckBox.AutoSize = true;
			_makeClickSoundCheckBox.Location = new System.Drawing.Point(19, 88);
			_makeClickSoundCheckBox.Name = "_makeClickSoundCheckBox";
			_makeClickSoundCheckBox.Size = new System.Drawing.Size(284, 19);
			_makeClickSoundCheckBox.TabIndex = 39;
			_makeClickSoundCheckBox.Text = "Make click sound when simulating a mouse click";
			_makeClickSoundCheckBox.UseVisualStyleBackColor = true;
			// 
			// _keyboardArrowsCanMoveCheckBox
			// 
			_keyboardArrowsCanMoveCheckBox.AutoSize = true;
			_keyboardArrowsCanMoveCheckBox.Location = new System.Drawing.Point(19, 65);
			_keyboardArrowsCanMoveCheckBox.Name = "_keyboardArrowsCanMoveCheckBox";
			_keyboardArrowsCanMoveCheckBox.Size = new System.Drawing.Size(345, 19);
			_keyboardArrowsCanMoveCheckBox.TabIndex = 38;
			_keyboardArrowsCanMoveCheckBox.Text = "Allow keyboard arrows to move screen mouse (when visible)";
			_keyboardArrowsCanMoveCheckBox.UseVisualStyleBackColor = true;
			// 
			// _showExpandingRingsCheckBox
			// 
			_showExpandingRingsCheckBox.AutoSize = true;
			_showExpandingRingsCheckBox.Location = new System.Drawing.Point(19, 42);
			_showExpandingRingsCheckBox.Name = "_showExpandingRingsCheckBox";
			_showExpandingRingsCheckBox.Size = new System.Drawing.Size(253, 19);
			_showExpandingRingsCheckBox.TabIndex = 33;
			_showExpandingRingsCheckBox.Text = "Show expanding ring when a click is issued";
			_showExpandingRingsCheckBox.UseVisualStyleBackColor = true;
			// 
			// _startProgramWithWindowsCheckBox
			// 
			_startProgramWithWindowsCheckBox.AutoSize = true;
			_startProgramWithWindowsCheckBox.Location = new System.Drawing.Point(19, 111);
			_startProgramWithWindowsCheckBox.Name = "_startProgramWithWindowsCheckBox";
			_startProgramWithWindowsCheckBox.Size = new System.Drawing.Size(236, 19);
			_startProgramWithWindowsCheckBox.TabIndex = 24;
			_startProgramWithWindowsCheckBox.Text = "Start this program when Windows starts";
			_startProgramWithWindowsCheckBox.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			groupBox2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox2.Controls.Add(_openScreenMouseManuallyRadioButton);
			groupBox2.Controls.Add(_showClickSelectorRadioButton);
			groupBox2.Controls.Add(_autoClickRadioButton);
			groupBox2.Location = new System.Drawing.Point(6, 6);
			groupBox2.Name = "groupBox2";
			groupBox2.Size = new System.Drawing.Size(511, 123);
			groupBox2.TabIndex = 22;
			groupBox2.TabStop = false;
			groupBox2.Text = "Mode";
			// 
			// _openScreenMouseManuallyRadioButton
			// 
			_openScreenMouseManuallyRadioButton.AutoSize = true;
			_openScreenMouseManuallyRadioButton.Location = new System.Drawing.Point(19, 77);
			_openScreenMouseManuallyRadioButton.Name = "_openScreenMouseManuallyRadioButton";
			_openScreenMouseManuallyRadioButton.Size = new System.Drawing.Size(314, 19);
			_openScreenMouseManuallyRadioButton.TabIndex = 11;
			_openScreenMouseManuallyRadioButton.Text = "I will activate the Screen Mouse using an activation key";
			toolTip1.SetToolTip(_openScreenMouseManuallyRadioButton, "You will activate the Screen Mouse manually, and then click the mouse using keys from your keyboard.");
			_openScreenMouseManuallyRadioButton.UseVisualStyleBackColor = true;
			// 
			// _screenMouseTab
			// 
			_screenMouseTab.Controls.Add(groupBox5);
			_screenMouseTab.Controls.Add(groupBox3);
			_screenMouseTab.Location = new System.Drawing.Point(4, 24);
			_screenMouseTab.Name = "_screenMouseTab";
			_screenMouseTab.Padding = new Padding(3);
			_screenMouseTab.Size = new System.Drawing.Size(523, 401);
			_screenMouseTab.TabIndex = 1;
			_screenMouseTab.Text = "Screen Mouse";
			_screenMouseTab.UseVisualStyleBackColor = true;
			// 
			// groupBox5
			// 
			groupBox5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox5.Controls.Add(_screenMouseActivationKeyComboBox);
			groupBox5.Controls.Add(label8);
			groupBox5.Controls.Add(label2);
			groupBox5.Controls.Add(label9);
			groupBox5.Controls.Add(label10);
			groupBox5.Controls.Add(_screenMouseTimeoutNumeric);
			groupBox5.Location = new System.Drawing.Point(6, 6);
			groupBox5.Name = "groupBox5";
			groupBox5.Size = new System.Drawing.Size(511, 87);
			groupBox5.TabIndex = 32;
			groupBox5.TabStop = false;
			groupBox5.Text = "Screen Mouse Options";
			// 
			// _screenMouseActivationKeyComboBox
			// 
			_screenMouseActivationKeyComboBox.AllowEmptyOption = false;
			_screenMouseActivationKeyComboBox.DisplayMember = "Display";
			_screenMouseActivationKeyComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			_screenMouseActivationKeyComboBox.EmptyOptionText = "";
			_screenMouseActivationKeyComboBox.FormattingEnabled = true;
			_screenMouseActivationKeyComboBox.Location = new System.Drawing.Point(186, 22);
			_screenMouseActivationKeyComboBox.Name = "_screenMouseActivationKeyComboBox";
			_screenMouseActivationKeyComboBox.Size = new System.Drawing.Size(95, 23);
			_screenMouseActivationKeyComboBox.TabIndex = 23;
			_screenMouseActivationKeyComboBox.ValueMember = "Value";
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new System.Drawing.Point(296, 51);
			label8.Name = "label8";
			label8.Size = new System.Drawing.Size(169, 15);
			label8.TabIndex = 31;
			label8.Text = "fades away after these seconds";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new System.Drawing.Point(18, 26);
			label2.Name = "label2";
			label2.Size = new System.Drawing.Size(151, 15);
			label2.TabIndex = 24;
			label2.Text = "Key to show Screen Mouse:";
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new System.Drawing.Point(40, 52);
			label9.Name = "label9";
			label9.Size = new System.Drawing.Size(128, 15);
			label9.TabIndex = 30;
			label9.Text = "Screen Mouse lifespan:";
			// 
			// label10
			// 
			label10.AutoSize = true;
			label10.Location = new System.Drawing.Point(296, 25);
			label10.Name = "label10";
			label10.Size = new System.Drawing.Size(180, 15);
			label10.TabIndex = 25;
			label10.Text = "key to activate the Screen Mouse";
			// 
			// _screenMouseTimeoutNumeric
			// 
			_screenMouseTimeoutNumeric.DecimalPlaces = 2;
			_screenMouseTimeoutNumeric.Increment = new decimal(new int[] { 25, 0, 0, 131072 });
			_screenMouseTimeoutNumeric.Location = new System.Drawing.Point(186, 49);
			_screenMouseTimeoutNumeric.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
			_screenMouseTimeoutNumeric.Minimum = new decimal(new int[] { 25, 0, 0, 131072 });
			_screenMouseTimeoutNumeric.Name = "_screenMouseTimeoutNumeric";
			_screenMouseTimeoutNumeric.Size = new System.Drawing.Size(95, 23);
			_screenMouseTimeoutNumeric.TabIndex = 29;
			_screenMouseTimeoutNumeric.Value = new decimal(new int[] { 1, 0, 0, 0 });
			// 
			// groupBox3
			// 
			groupBox3.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			groupBox3.Controls.Add(label17);
			groupBox3.Controls.Add(label16);
			groupBox3.Controls.Add(label12);
			groupBox3.Controls.Add(label11);
			groupBox3.Controls.Add(_screenMouseLeftComboBox);
			groupBox3.Controls.Add(label13);
			groupBox3.Controls.Add(_screenMouseMiddleComboBox);
			groupBox3.Controls.Add(label14);
			groupBox3.Controls.Add(_screenMousePictureBox);
			groupBox3.Controls.Add(_screenMouseRightComboBox);
			groupBox3.Controls.Add(label15);
			groupBox3.Location = new System.Drawing.Point(6, 99);
			groupBox3.Name = "groupBox3";
			groupBox3.Size = new System.Drawing.Size(511, 296);
			groupBox3.TabIndex = 22;
			groupBox3.TabStop = false;
			groupBox3.Text = "Screen Mouse Keys";
			// 
			// label17
			// 
			label17.Location = new System.Drawing.Point(186, 112);
			label17.Name = "label17";
			label17.Size = new System.Drawing.Size(309, 129);
			label17.TabIndex = 29;
			label17.Text = resources.GetString("label17.Text");
			// 
			// label16
			// 
			label16.AutoSize = true;
			label16.Location = new System.Drawing.Point(296, 76);
			label16.Name = "label16";
			label16.Size = new System.Drawing.Size(197, 15);
			label16.TabIndex = 28;
			label16.Text = "will click of the mouses right button";
			// 
			// label12
			// 
			label12.AutoSize = true;
			label12.Location = new System.Drawing.Point(296, 49);
			label12.Name = "label12";
			label12.Size = new System.Drawing.Size(209, 15);
			label12.TabIndex = 27;
			label12.Text = "will click of the mouses middle button";
			// 
			// label11
			// 
			label11.AutoSize = true;
			label11.Location = new System.Drawing.Point(296, 22);
			label11.Name = "label11";
			label11.Size = new System.Drawing.Size(189, 15);
			label11.TabIndex = 26;
			label11.Text = "will click of the mouses left button";
			// 
			// _screenMouseLeftComboBox
			// 
			_screenMouseLeftComboBox.AllowEmptyOption = false;
			_screenMouseLeftComboBox.DisplayMember = "Display";
			_screenMouseLeftComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			_screenMouseLeftComboBox.EmptyOptionText = "";
			_screenMouseLeftComboBox.FormattingEnabled = true;
			_screenMouseLeftComboBox.Location = new System.Drawing.Point(186, 19);
			_screenMouseLeftComboBox.Name = "_screenMouseLeftComboBox";
			_screenMouseLeftComboBox.Size = new System.Drawing.Size(95, 23);
			_screenMouseLeftComboBox.TabIndex = 11;
			_screenMouseLeftComboBox.ValueMember = "Value";
			// 
			// label13
			// 
			label13.AutoSize = true;
			label13.Location = new System.Drawing.Point(56, 22);
			label13.Name = "label13";
			label13.Size = new System.Drawing.Size(108, 15);
			label13.TabIndex = 12;
			label13.Text = "Left Button Key (L):";
			// 
			// _screenMouseMiddleComboBox
			// 
			_screenMouseMiddleComboBox.AllowEmptyOption = false;
			_screenMouseMiddleComboBox.DisplayMember = "Display";
			_screenMouseMiddleComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			_screenMouseMiddleComboBox.EmptyOptionText = "";
			_screenMouseMiddleComboBox.FormattingEnabled = true;
			_screenMouseMiddleComboBox.Location = new System.Drawing.Point(186, 46);
			_screenMouseMiddleComboBox.Name = "_screenMouseMiddleComboBox";
			_screenMouseMiddleComboBox.Size = new System.Drawing.Size(95, 23);
			_screenMouseMiddleComboBox.TabIndex = 16;
			_screenMouseMiddleComboBox.ValueMember = "Value";
			// 
			// label14
			// 
			label14.AutoSize = true;
			label14.Location = new System.Drawing.Point(40, 49);
			label14.Name = "label14";
			label14.Size = new System.Drawing.Size(130, 15);
			label14.TabIndex = 14;
			label14.Text = "Middle Button Key (M):";
			// 
			// _screenMousePictureBox
			// 
			_screenMousePictureBox.Location = new System.Drawing.Point(31, 112);
			_screenMousePictureBox.Name = "_screenMousePictureBox";
			_screenMousePictureBox.Size = new System.Drawing.Size(123, 129);
			_screenMousePictureBox.TabIndex = 13;
			_screenMousePictureBox.TabStop = false;
			// 
			// _screenMouseRightComboBox
			// 
			_screenMouseRightComboBox.AllowEmptyOption = false;
			_screenMouseRightComboBox.DisplayMember = "Display";
			_screenMouseRightComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
			_screenMouseRightComboBox.EmptyOptionText = "";
			_screenMouseRightComboBox.FormattingEnabled = true;
			_screenMouseRightComboBox.Location = new System.Drawing.Point(186, 73);
			_screenMouseRightComboBox.Name = "_screenMouseRightComboBox";
			_screenMouseRightComboBox.Size = new System.Drawing.Size(95, 23);
			_screenMouseRightComboBox.TabIndex = 17;
			_screenMouseRightComboBox.ValueMember = "Value";
			// 
			// label15
			// 
			label15.AutoSize = true;
			label15.Location = new System.Drawing.Point(47, 76);
			label15.Name = "label15";
			label15.Size = new System.Drawing.Size(117, 15);
			label15.TabIndex = 15;
			label15.Text = "Right Button Key (R):";
			// 
			// _autoClickTab
			// 
			_autoClickTab.Controls.Add(_buttonGroupBox);
			_autoClickTab.Controls.Add(_clickGroupBox);
			_autoClickTab.Location = new System.Drawing.Point(4, 24);
			_autoClickTab.Name = "_autoClickTab";
			_autoClickTab.Padding = new Padding(3);
			_autoClickTab.Size = new System.Drawing.Size(523, 401);
			_autoClickTab.TabIndex = 2;
			_autoClickTab.Text = "Auto Click";
			_autoClickTab.UseVisualStyleBackColor = true;
			// 
			// _advancedTab
			// 
			_advancedTab.Controls.Add(groupBox1);
			_advancedTab.Controls.Add(_selectRadiusGroupBox);
			_advancedTab.Location = new System.Drawing.Point(4, 24);
			_advancedTab.Name = "_advancedTab";
			_advancedTab.Padding = new Padding(3);
			_advancedTab.Size = new System.Drawing.Size(523, 401);
			_advancedTab.TabIndex = 3;
			_advancedTab.Text = "Advanced";
			_advancedTab.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			groupBox1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			groupBox1.Controls.Add(_mouseStoppedDuration);
			groupBox1.Controls.Add(label19);
			groupBox1.Controls.Add(label20);
			groupBox1.Controls.Add(label22);
			groupBox1.Controls.Add(label23);
			groupBox1.Controls.Add(_screenMouseActiveTranslucencyNumeric);
			groupBox1.Controls.Add(label7);
			groupBox1.Controls.Add(label18);
			groupBox1.Controls.Add(_screenMouseIdleTranslucencyNumeric);
			groupBox1.Controls.Add(label6);
			groupBox1.Controls.Add(label4);
			groupBox1.Controls.Add(_expandingRingRadiusNumeric);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(_clickIntervalNumeric);
			groupBox1.Location = new System.Drawing.Point(9, 6);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new System.Drawing.Size(508, 164);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Miscellaneous Settings";
			// 
			// _mouseStoppedDuration
			// 
			_mouseStoppedDuration.Location = new System.Drawing.Point(264, 18);
			_mouseStoppedDuration.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
			_mouseStoppedDuration.Minimum = new decimal(new int[] { 100, 0, 0, 0 });
			_mouseStoppedDuration.Name = "_mouseStoppedDuration";
			_mouseStoppedDuration.Size = new System.Drawing.Size(120, 23);
			_mouseStoppedDuration.TabIndex = 14;
			_mouseStoppedDuration.Value = new decimal(new int[] { 100, 0, 0, 0 });
			// 
			// label19
			// 
			label19.AutoSize = true;
			label19.Location = new System.Drawing.Point(390, 20);
			label19.Name = "label19";
			label19.Size = new System.Drawing.Size(79, 15);
			label19.TabIndex = 16;
			label19.Text = "millisecconds";
			// 
			// label20
			// 
			label20.AutoSize = true;
			label20.Location = new System.Drawing.Point(75, 20);
			label20.Name = "label20";
			label20.Size = new System.Drawing.Size(167, 15);
			label20.TabIndex = 15;
			label20.Text = "Idle duration before auto-click";
			// 
			// label22
			// 
			label22.AutoSize = true;
			label22.Location = new System.Drawing.Point(390, 136);
			label22.Name = "label22";
			label22.Size = new System.Drawing.Size(17, 15);
			label22.TabIndex = 13;
			label22.Text = "%";
			// 
			// label23
			// 
			label23.AutoSize = true;
			label23.Location = new System.Drawing.Point(25, 136);
			label23.Name = "label23";
			label23.Size = new System.Drawing.Size(217, 15);
			label23.TabIndex = 12;
			label23.Text = "Screen Mouse translucency when active";
			// 
			// _screenMouseActiveTranslucencyNumeric
			// 
			_screenMouseActiveTranslucencyNumeric.Location = new System.Drawing.Point(264, 134);
			_screenMouseActiveTranslucencyNumeric.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
			_screenMouseActiveTranslucencyNumeric.Name = "_screenMouseActiveTranslucencyNumeric";
			_screenMouseActiveTranslucencyNumeric.Size = new System.Drawing.Size(120, 23);
			_screenMouseActiveTranslucencyNumeric.TabIndex = 11;
			_screenMouseActiveTranslucencyNumeric.Value = new decimal(new int[] { 75, 0, 0, 0 });
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new System.Drawing.Point(390, 107);
			label7.Name = "label7";
			label7.Size = new System.Drawing.Size(17, 15);
			label7.TabIndex = 10;
			label7.Text = "%";
			// 
			// label18
			// 
			label18.AutoSize = true;
			label18.Location = new System.Drawing.Point(38, 107);
			label18.Name = "label18";
			label18.Size = new System.Drawing.Size(205, 15);
			label18.TabIndex = 9;
			label18.Text = "Screen Mouse translucency when idle";
			// 
			// _screenMouseIdleTranslucencyNumeric
			// 
			_screenMouseIdleTranslucencyNumeric.Location = new System.Drawing.Point(264, 105);
			_screenMouseIdleTranslucencyNumeric.Minimum = new decimal(new int[] { 15, 0, 0, 0 });
			_screenMouseIdleTranslucencyNumeric.Name = "_screenMouseIdleTranslucencyNumeric";
			_screenMouseIdleTranslucencyNumeric.Size = new System.Drawing.Size(120, 23);
			_screenMouseIdleTranslucencyNumeric.TabIndex = 8;
			_screenMouseIdleTranslucencyNumeric.Value = new decimal(new int[] { 15, 0, 0, 0 });
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new System.Drawing.Point(390, 78);
			label6.Name = "label6";
			label6.Size = new System.Drawing.Size(37, 15);
			label6.TabIndex = 7;
			label6.Text = "pixels";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new System.Drawing.Point(114, 78);
			label4.Name = "label4";
			label4.Size = new System.Drawing.Size(129, 15);
			label4.TabIndex = 6;
			label4.Text = "Size of expanding rings";
			// 
			// _expandingRingRadiusNumeric
			// 
			_expandingRingRadiusNumeric.Location = new System.Drawing.Point(264, 76);
			_expandingRingRadiusNumeric.Name = "_expandingRingRadiusNumeric";
			_expandingRingRadiusNumeric.Size = new System.Drawing.Size(120, 23);
			_expandingRingRadiusNumeric.TabIndex = 5;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new System.Drawing.Point(390, 49);
			label5.Name = "label5";
			label5.Size = new System.Drawing.Size(79, 15);
			label5.TabIndex = 4;
			label5.Text = "millisecconds";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new System.Drawing.Point(25, 49);
			label3.Name = "label3";
			label3.Size = new System.Drawing.Size(218, 15);
			label3.TabIndex = 1;
			label3.Text = "Duration between clicks in double clicks";
			// 
			// _clickIntervalNumeric
			// 
			_clickIntervalNumeric.Location = new System.Drawing.Point(264, 47);
			_clickIntervalNumeric.Name = "_clickIntervalNumeric";
			_clickIntervalNumeric.Size = new System.Drawing.Size(120, 23);
			_clickIntervalNumeric.TabIndex = 0;
			// 
			// AutoMouseSettingsControl
			// 
			Controls.Add(_tabControl);
			Name = "AutoMouseSettingsControl";
			Size = new System.Drawing.Size(531, 429);
			_buttonGroupBox.ResumeLayout(false);
			_buttonGroupBox.PerformLayout();
			_selectRadiusGroupBox.ResumeLayout(false);
			_clickGroupBox.ResumeLayout(false);
			_clickGroupBox.PerformLayout();
			_tabControl.ResumeLayout(false);
			_generalTab.ResumeLayout(false);
			groupBox4.ResumeLayout(false);
			groupBox4.PerformLayout();
			groupBox2.ResumeLayout(false);
			groupBox2.PerformLayout();
			_screenMouseTab.ResumeLayout(false);
			groupBox5.ResumeLayout(false);
			groupBox5.PerformLayout();
			((ISupportInitialize)_screenMouseTimeoutNumeric).EndInit();
			groupBox3.ResumeLayout(false);
			groupBox3.PerformLayout();
			((ISupportInitialize)_screenMousePictureBox).EndInit();
			_autoClickTab.ResumeLayout(false);
			_advancedTab.ResumeLayout(false);
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			((ISupportInitialize)_mouseStoppedDuration).EndInit();
			((ISupportInitialize)_screenMouseActiveTranslucencyNumeric).EndInit();
			((ISupportInitialize)_screenMouseIdleTranslucencyNumeric).EndInit();
			((ISupportInitialize)_expandingRingRadiusNumeric).EndInit();
			((ISupportInitialize)_clickIntervalNumeric).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox _buttonGroupBox;
		private RadioButton _rightButtonRadioButton;
		private RadioButton _middleButtonRadioButton;
		private RadioButton _leftButtonRadioButton;
		private GroupBox _selectRadiusGroupBox;
		private ClickRadiusSelector _clickRadiusSelector;
		private RadioButton _showClickSelectorRadioButton;
		private RadioButton _autoClickRadioButton;
		private RadioButton _singleClickRadioButton;
		private RadioButton _doubleClickRadioButton;
		private RadioButton _trippleClickRadioButton;
		private GroupBox _clickGroupBox;
		private Label label1;
		private TabControl _tabControl;
		private TabPage _generalTab;
		private GroupBox groupBox2;
		private RadioButton _openScreenMouseManuallyRadioButton;
		private TabPage _screenMouseTab;
		private TabPage _autoClickTab;
		private TabPage _advancedTab;
		private GroupBox groupBox1;
		private Label label6;
		private Label label4;
		private NumericUpDown _expandingRingRadiusNumeric;
		private Label label5;
		private Label label3;
		private NumericUpDown _clickIntervalNumeric;
		private CheckBox _startProgramWithWindowsCheckBox;
		private Label label8;
		private Label label9;
		private NumericUpDown _screenMouseTimeoutNumeric;
		private Label label10;
		private Label label2;
		private GroupBox groupBox3;
		private Sphere10.Framework.Windows.Forms.EnumComboBox _screenMouseLeftComboBox;
		private Label label13;
		private Sphere10.Framework.Windows.Forms.EnumComboBox _screenMouseMiddleComboBox;
		private Label label14;
		private PictureBox _screenMousePictureBox;
		private Sphere10.Framework.Windows.Forms.EnumComboBox _screenMouseRightComboBox;
		private Label label15;
		private Label label17;
		private Label label16;
		private Label label12;
		private Label label11;
		private Label label7;
		private Label label18;
		private NumericUpDown _screenMouseIdleTranslucencyNumeric;
		private CheckBox _showExpandingRingsCheckBox;
		private Label label22;
		private Label label23;
		private NumericUpDown _screenMouseActiveTranslucencyNumeric;
		private GroupBox groupBox4;
		private GroupBox groupBox5;
		private Label label25;
		private Label label24;
		private CheckBox _makeClickSoundCheckBox;
		private CheckBox _keyboardArrowsCanMoveCheckBox;
		private CheckBox _flipLeftRightMouseButtons;
		private ToolTip toolTip1;
		private SourceGrid.ArrayGrid arrayGrid1;
		private Sphere10.Framework.Windows.Forms.EnumComboBox _screenMouseActivationKeyComboBox;
		private Label label19;
		private Label label20;
		private NumericUpDown _mouseStoppedDuration;
	}
}
