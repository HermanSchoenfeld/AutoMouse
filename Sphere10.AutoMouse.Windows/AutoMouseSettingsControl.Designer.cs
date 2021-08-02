using System.ComponentModel;
using System.Windows.Forms;

namespace Sphere10.AutoMouse.Windows
{
    partial class AutoMouseSettingsControl
    {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutoMouseSettingsControl));
            this._buttonGroupBox = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this._rightButtonRadioButton = new System.Windows.Forms.RadioButton();
            this._middleButtonRadioButton = new System.Windows.Forms.RadioButton();
            this._leftButtonRadioButton = new System.Windows.Forms.RadioButton();
            this._selectRadiusGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this._clickRadiusSelector = new Sphere10.AutoMouse.Windows.ClickRadiusSelector();
            this._showClickSelectorRadioButton = new System.Windows.Forms.RadioButton();
            this._autoClickRadioButton = new System.Windows.Forms.RadioButton();
            this._singleClickRadioButton = new System.Windows.Forms.RadioButton();
            this._doubleClickRadioButton = new System.Windows.Forms.RadioButton();
            this._trippleClickRadioButton = new System.Windows.Forms.RadioButton();
            this._clickGroupBox = new System.Windows.Forms.GroupBox();
            this.label24 = new System.Windows.Forms.Label();
            this._tabControl = new System.Windows.Forms.TabControl();
            this._generalTab = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._flipLeftRightMouseButtons = new System.Windows.Forms.CheckBox();
            this._makeClickSoundCheckBox = new System.Windows.Forms.CheckBox();
            this._keyboardArrowsCanMoveCheckBox = new System.Windows.Forms.CheckBox();
            this._showExpandingRingsCheckBox = new System.Windows.Forms.CheckBox();
            this._startProgramWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this._openScreenMouseManuallyRadioButton = new System.Windows.Forms.RadioButton();
            this._screenMouseTab = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._screenMouseActivationKeyComboBox = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this._screenMouseTimeoutNumeric = new System.Windows.Forms.NumericUpDown();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this._screenMouseLeftComboBox = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this._screenMouseMiddleComboBox = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this._screenMousePictureBox = new System.Windows.Forms.PictureBox();
            this._screenMouseRightComboBox = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this._autoClickTab = new System.Windows.Forms.TabPage();
            this._advancedTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this._screenMouseActiveTranslucencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this._screenMouseIdleTranslucencyNumeric = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this._expandingRingRadiusNumeric = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._clickIntervalNumeric = new System.Windows.Forms.NumericUpDown();
            this._buttonGroupBox.SuspendLayout();
            this._selectRadiusGroupBox.SuspendLayout();
            this._clickGroupBox.SuspendLayout();
            this._tabControl.SuspendLayout();
            this._generalTab.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this._screenMouseTab.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseTimeoutNumeric)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMousePictureBox)).BeginInit();
            this._autoClickTab.SuspendLayout();
            this._advancedTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseActiveTranslucencyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseIdleTranslucencyNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._expandingRingRadiusNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._clickIntervalNumeric)).BeginInit();
            this.SuspendLayout();
            // 
            // _buttonGroupBox
            // 
            this._buttonGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._buttonGroupBox.AutoSize = true;
            this._buttonGroupBox.Controls.Add(this.label25);
            this._buttonGroupBox.Controls.Add(this._rightButtonRadioButton);
            this._buttonGroupBox.Controls.Add(this._middleButtonRadioButton);
            this._buttonGroupBox.Controls.Add(this._leftButtonRadioButton);
            this._buttonGroupBox.Location = new System.Drawing.Point(6, 117);
            this._buttonGroupBox.Name = "_buttonGroupBox";
            this._buttonGroupBox.Size = new System.Drawing.Size(535, 369);
            this._buttonGroupBox.TabIndex = 6;
            this._buttonGroupBox.TabStop = false;
            this._buttonGroupBox.Text = "Auto Click Button";
            // 
            // label25
            // 
            this.label25.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label25.Location = new System.Drawing.Point(110, 24);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(402, 61);
            this.label25.TabIndex = 31;
            this.label25.Text = "When auto clicking is enalbed, this will determine the button that will be simula" +
    "ted.";
            // 
            // _rightButtonRadioButton
            // 
            this._rightButtonRadioButton.AutoSize = true;
            this._rightButtonRadioButton.Location = new System.Drawing.Point(19, 68);
            this._rightButtonRadioButton.Name = "_rightButtonRadioButton";
            this._rightButtonRadioButton.Size = new System.Drawing.Size(50, 17);
            this._rightButtonRadioButton.TabIndex = 7;
            this._rightButtonRadioButton.TabStop = true;
            this._rightButtonRadioButton.Text = "Right";
            this._rightButtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // _middleButtonRadioButton
            // 
            this._middleButtonRadioButton.AutoSize = true;
            this._middleButtonRadioButton.Location = new System.Drawing.Point(19, 45);
            this._middleButtonRadioButton.Name = "_middleButtonRadioButton";
            this._middleButtonRadioButton.Size = new System.Drawing.Size(56, 17);
            this._middleButtonRadioButton.TabIndex = 6;
            this._middleButtonRadioButton.TabStop = true;
            this._middleButtonRadioButton.Text = "Middle";
            this._middleButtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // _leftButtonRadioButton
            // 
            this._leftButtonRadioButton.AutoSize = true;
            this._leftButtonRadioButton.Location = new System.Drawing.Point(19, 22);
            this._leftButtonRadioButton.Name = "_leftButtonRadioButton";
            this._leftButtonRadioButton.Size = new System.Drawing.Size(43, 17);
            this._leftButtonRadioButton.TabIndex = 5;
            this._leftButtonRadioButton.TabStop = true;
            this._leftButtonRadioButton.Text = "Left";
            this._leftButtonRadioButton.UseVisualStyleBackColor = true;
            // 
            // _selectRadiusGroupBox
            // 
            this._selectRadiusGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._selectRadiusGroupBox.Controls.Add(this.label1);
            this._selectRadiusGroupBox.Controls.Add(this._clickRadiusSelector);
            this._selectRadiusGroupBox.Location = new System.Drawing.Point(9, 162);
            this._selectRadiusGroupBox.Name = "_selectRadiusGroupBox";
            this._selectRadiusGroupBox.Size = new System.Drawing.Size(532, 324);
            this._selectRadiusGroupBox.TabIndex = 7;
            this._selectRadiusGroupBox.TabStop = false;
            this._selectRadiusGroupBox.Text = "Discard Zone";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 182);
            this.label1.TabIndex = 9;
            this.label1.Text = "Motion within this zone will be discarded. This means you will need to move the m" +
    "ouse beyond this zone to activate any of the features.";
            // 
            // _clickRadiusSelector
            // 
            this._clickRadiusSelector.BackColor = System.Drawing.SystemColors.Window;
            this._clickRadiusSelector.Location = new System.Drawing.Point(19, 30);
            this._clickRadiusSelector.Name = "_clickRadiusSelector";
            this._clickRadiusSelector.SelectedRadius = 100;
            this._clickRadiusSelector.Size = new System.Drawing.Size(187, 182);
            this._clickRadiusSelector.TabIndex = 8;
            // 
            // _showClickSelectorRadioButton
            // 
            this._showClickSelectorRadioButton.Checked = true;
            this._showClickSelectorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._showClickSelectorRadioButton.Location = new System.Drawing.Point(19, 19);
            this._showClickSelectorRadioButton.Name = "_showClickSelectorRadioButton";
            this._showClickSelectorRadioButton.Size = new System.Drawing.Size(316, 23);
            this._showClickSelectorRadioButton.TabIndex = 9;
            this._showClickSelectorRadioButton.TabStop = true;
            this._showClickSelectorRadioButton.Text = "Let me click the mouse using the keys from my keyboard";
            this._showClickSelectorRadioButton.UseVisualStyleBackColor = true;
            // 
            // _autoClickRadioButton
            // 
            this._autoClickRadioButton.Location = new System.Drawing.Point(19, 93);
            this._autoClickRadioButton.Name = "_autoClickRadioButton";
            this._autoClickRadioButton.Size = new System.Drawing.Size(339, 23);
            this._autoClickRadioButton.TabIndex = 10;
            this._autoClickRadioButton.Text = "Automatically click the mouse when I stop moving the mouse";
            this._autoClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // _singleClickRadioButton
            // 
            this._singleClickRadioButton.AutoSize = true;
            this._singleClickRadioButton.Location = new System.Drawing.Point(19, 22);
            this._singleClickRadioButton.Name = "_singleClickRadioButton";
            this._singleClickRadioButton.Size = new System.Drawing.Size(54, 17);
            this._singleClickRadioButton.TabIndex = 2;
            this._singleClickRadioButton.TabStop = true;
            this._singleClickRadioButton.Text = "Single";
            this._singleClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // _doubleClickRadioButton
            // 
            this._doubleClickRadioButton.AutoSize = true;
            this._doubleClickRadioButton.Location = new System.Drawing.Point(19, 45);
            this._doubleClickRadioButton.Name = "_doubleClickRadioButton";
            this._doubleClickRadioButton.Size = new System.Drawing.Size(59, 17);
            this._doubleClickRadioButton.TabIndex = 3;
            this._doubleClickRadioButton.TabStop = true;
            this._doubleClickRadioButton.Text = "Double";
            this._doubleClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // _trippleClickRadioButton
            // 
            this._trippleClickRadioButton.AutoSize = true;
            this._trippleClickRadioButton.Location = new System.Drawing.Point(19, 68);
            this._trippleClickRadioButton.Name = "_trippleClickRadioButton";
            this._trippleClickRadioButton.Size = new System.Drawing.Size(51, 17);
            this._trippleClickRadioButton.TabIndex = 4;
            this._trippleClickRadioButton.TabStop = true;
            this._trippleClickRadioButton.Text = "Triple";
            this._trippleClickRadioButton.UseVisualStyleBackColor = true;
            // 
            // _clickGroupBox
            // 
            this._clickGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._clickGroupBox.AutoSize = true;
            this._clickGroupBox.Controls.Add(this.label24);
            this._clickGroupBox.Controls.Add(this._trippleClickRadioButton);
            this._clickGroupBox.Controls.Add(this._doubleClickRadioButton);
            this._clickGroupBox.Controls.Add(this._singleClickRadioButton);
            this._clickGroupBox.Location = new System.Drawing.Point(6, 6);
            this._clickGroupBox.Name = "_clickGroupBox";
            this._clickGroupBox.Size = new System.Drawing.Size(535, 104);
            this._clickGroupBox.TabIndex = 5;
            this._clickGroupBox.TabStop = false;
            this._clickGroupBox.Text = "Auto Click Type";
            // 
            // label24
            // 
            this.label24.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label24.Location = new System.Drawing.Point(110, 24);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(402, 61);
            this.label24.TabIndex = 30;
            this.label24.Text = "When auto clicking is enabled, this will determine the type of click that will be" +
    " simulated.";
            // 
            // _tabControl
            // 
            this._tabControl.Controls.Add(this._generalTab);
            this._tabControl.Controls.Add(this._screenMouseTab);
            this._tabControl.Controls.Add(this._autoClickTab);
            this._tabControl.Controls.Add(this._advancedTab);
            this._tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._tabControl.Location = new System.Drawing.Point(0, 0);
            this._tabControl.Margin = new System.Windows.Forms.Padding(0);
            this._tabControl.Name = "_tabControl";
            this._tabControl.SelectedIndex = 0;
            this._tabControl.Size = new System.Drawing.Size(555, 518);
            this._tabControl.TabIndex = 22;
            // 
            // _generalTab
            // 
            this._generalTab.Controls.Add(this.groupBox4);
            this._generalTab.Controls.Add(this.groupBox2);
            this._generalTab.Location = new System.Drawing.Point(4, 22);
            this._generalTab.Name = "_generalTab";
            this._generalTab.Padding = new System.Windows.Forms.Padding(3);
            this._generalTab.Size = new System.Drawing.Size(547, 492);
            this._generalTab.TabIndex = 0;
            this._generalTab.Text = "General";
            this._generalTab.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._flipLeftRightMouseButtons);
            this.groupBox4.Controls.Add(this._makeClickSoundCheckBox);
            this.groupBox4.Controls.Add(this._keyboardArrowsCanMoveCheckBox);
            this.groupBox4.Controls.Add(this._showExpandingRingsCheckBox);
            this.groupBox4.Controls.Add(this._startProgramWithWindowsCheckBox);
            this.groupBox4.Location = new System.Drawing.Point(6, 274);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(535, 212);
            this.groupBox4.TabIndex = 34;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Other Options";
            // 
            // _flipLeftRightMouseButtons
            // 
            this._flipLeftRightMouseButtons.AutoSize = true;
            this._flipLeftRightMouseButtons.Location = new System.Drawing.Point(19, 19);
            this._flipLeftRightMouseButtons.Name = "_flipLeftRightMouseButtons";
            this._flipLeftRightMouseButtons.Size = new System.Drawing.Size(292, 17);
            this._flipLeftRightMouseButtons.TabIndex = 40;
            this._flipLeftRightMouseButtons.Text = "Flip the left and right mouse buttons for left-handed users";
            this._flipLeftRightMouseButtons.UseVisualStyleBackColor = true;
            // 
            // _makeClickSoundCheckBox
            // 
            this._makeClickSoundCheckBox.AutoSize = true;
            this._makeClickSoundCheckBox.Location = new System.Drawing.Point(19, 88);
            this._makeClickSoundCheckBox.Name = "_makeClickSoundCheckBox";
            this._makeClickSoundCheckBox.Size = new System.Drawing.Size(256, 17);
            this._makeClickSoundCheckBox.TabIndex = 39;
            this._makeClickSoundCheckBox.Text = "Make click sound when simulating a mouse click";
            this._makeClickSoundCheckBox.UseVisualStyleBackColor = true;
            // 
            // _keyboardArrowsCanMoveCheckBox
            // 
            this._keyboardArrowsCanMoveCheckBox.AutoSize = true;
            this._keyboardArrowsCanMoveCheckBox.Location = new System.Drawing.Point(19, 65);
            this._keyboardArrowsCanMoveCheckBox.Name = "_keyboardArrowsCanMoveCheckBox";
            this._keyboardArrowsCanMoveCheckBox.Size = new System.Drawing.Size(309, 17);
            this._keyboardArrowsCanMoveCheckBox.TabIndex = 38;
            this._keyboardArrowsCanMoveCheckBox.Text = "Allow keyboard arrows to move screen mouse (when visible)";
            this._keyboardArrowsCanMoveCheckBox.UseVisualStyleBackColor = true;
            // 
            // _showExpandingRingsCheckBox
            // 
            this._showExpandingRingsCheckBox.AutoSize = true;
            this._showExpandingRingsCheckBox.Location = new System.Drawing.Point(19, 42);
            this._showExpandingRingsCheckBox.Name = "_showExpandingRingsCheckBox";
            this._showExpandingRingsCheckBox.Size = new System.Drawing.Size(231, 17);
            this._showExpandingRingsCheckBox.TabIndex = 33;
            this._showExpandingRingsCheckBox.Text = "Show expanding ring when a click is issued";
            this._showExpandingRingsCheckBox.UseVisualStyleBackColor = true;
            // 
            // _startProgramWithWindowsCheckBox
            // 
            this._startProgramWithWindowsCheckBox.AutoSize = true;
            this._startProgramWithWindowsCheckBox.Location = new System.Drawing.Point(19, 111);
            this._startProgramWithWindowsCheckBox.Name = "_startProgramWithWindowsCheckBox";
            this._startProgramWithWindowsCheckBox.Size = new System.Drawing.Size(212, 17);
            this._startProgramWithWindowsCheckBox.TabIndex = 24;
            this._startProgramWithWindowsCheckBox.Text = "Start this program when Windows starts";
            this._startProgramWithWindowsCheckBox.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this._openScreenMouseManuallyRadioButton);
            this.groupBox2.Controls.Add(this._showClickSelectorRadioButton);
            this.groupBox2.Controls.Add(this._autoClickRadioButton);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(535, 262);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Mode";
            // 
            // label21
            // 
            this.label21.Location = new System.Drawing.Point(45, 193);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(390, 45);
            this.label21.TabIndex = 14;
            this.label21.Text = "You will activate the Screen Mouse manually, and then click the mouse using keys " +
    "from your keyboard.";
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(45, 119);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(390, 45);
            this.label20.TabIndex = 13;
            this.label20.Text = "When you stop moving the mouse, a click will automatically be made at the cursors" +
    " current position.";
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(45, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(390, 45);
            this.label19.TabIndex = 12;
            this.label19.Text = "As you move your mouse you will be able to click the mouse by pressing keys from " +
    "your keyboard (via the Screen Mouse).";
            // 
            // _openScreenMouseManuallyRadioButton
            // 
            this._openScreenMouseManuallyRadioButton.Location = new System.Drawing.Point(19, 167);
            this._openScreenMouseManuallyRadioButton.Name = "_openScreenMouseManuallyRadioButton";
            this._openScreenMouseManuallyRadioButton.Size = new System.Drawing.Size(352, 23);
            this._openScreenMouseManuallyRadioButton.TabIndex = 11;
            this._openScreenMouseManuallyRadioButton.Text = "I will activate the Screen Mouse using an activation key";
            this._openScreenMouseManuallyRadioButton.UseVisualStyleBackColor = true;
            // 
            // _screenMouseTab
            // 
            this._screenMouseTab.Controls.Add(this.groupBox5);
            this._screenMouseTab.Controls.Add(this.groupBox3);
            this._screenMouseTab.Location = new System.Drawing.Point(4, 22);
            this._screenMouseTab.Name = "_screenMouseTab";
            this._screenMouseTab.Padding = new System.Windows.Forms.Padding(3);
            this._screenMouseTab.Size = new System.Drawing.Size(547, 492);
            this._screenMouseTab.TabIndex = 1;
            this._screenMouseTab.Text = "Screen Mouse";
            this._screenMouseTab.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this._screenMouseActivationKeyComboBox);
            this.groupBox5.Controls.Add(this.label8);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this._screenMouseTimeoutNumeric);
            this.groupBox5.Location = new System.Drawing.Point(6, 6);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(535, 87);
            this.groupBox5.TabIndex = 32;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Screen Mouse Options";
            // 
            // _screenMouseActivationKeyComboBox
            // 
            this._screenMouseActivationKeyComboBox.FormattingEnabled = true;
            this._screenMouseActivationKeyComboBox.Location = new System.Drawing.Point(164, 23);
            this._screenMouseActivationKeyComboBox.Name = "_screenMouseActivationKeyComboBox";
            this._screenMouseActivationKeyComboBox.Size = new System.Drawing.Size(95, 21);
            this._screenMouseActivationKeyComboBox.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(274, 52);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(249, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "seconds to show screen mouse before fading away";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Key to show Screen Mouse:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(40, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 13);
            this.label9.TabIndex = 30;
            this.label9.Text = "Screen Mouse lifespan:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(274, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(167, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "key to activate the Screen Mouse";
            // 
            // _screenMouseTimeoutNumeric
            // 
            this._screenMouseTimeoutNumeric.Location = new System.Drawing.Point(164, 50);
            this._screenMouseTimeoutNumeric.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this._screenMouseTimeoutNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._screenMouseTimeoutNumeric.Name = "_screenMouseTimeoutNumeric";
            this._screenMouseTimeoutNumeric.Size = new System.Drawing.Size(95, 20);
            this._screenMouseTimeoutNumeric.TabIndex = 29;
            this._screenMouseTimeoutNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this._screenMouseLeftComboBox);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this._screenMouseMiddleComboBox);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this._screenMousePictureBox);
            this.groupBox3.Controls.Add(this._screenMouseRightComboBox);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Location = new System.Drawing.Point(6, 99);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(535, 387);
            this.groupBox3.TabIndex = 22;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Screen Mouse Keys";
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(161, 112);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(353, 129);
            this.label17.TabIndex = 29;
            this.label17.Text = resources.GetString("label17.Text");
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(274, 76);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(171, 13);
            this.label16.TabIndex = 28;
            this.label16.Text = "will click of the mouses right button";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(274, 49);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(181, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "will click of the mouses middle button";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(274, 22);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(165, 13);
            this.label11.TabIndex = 26;
            this.label11.Text = "will click of the mouses left button";
            // 
            // _screenMouseLeftComboBox
            // 
            this._screenMouseLeftComboBox.FormattingEnabled = true;
            this._screenMouseLeftComboBox.Location = new System.Drawing.Point(164, 19);
            this._screenMouseLeftComboBox.Name = "_screenMouseLeftComboBox";
            this._screenMouseLeftComboBox.Size = new System.Drawing.Size(95, 21);
            this._screenMouseLeftComboBox.TabIndex = 11;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(56, 22);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Left Button Key (L):";
            // 
            // _screenMouseMiddleComboBox
            // 
            this._screenMouseMiddleComboBox.FormattingEnabled = true;
            this._screenMouseMiddleComboBox.Location = new System.Drawing.Point(164, 46);
            this._screenMouseMiddleComboBox.Name = "_screenMouseMiddleComboBox";
            this._screenMouseMiddleComboBox.Size = new System.Drawing.Size(95, 21);
            this._screenMouseMiddleComboBox.TabIndex = 16;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(40, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(114, 13);
            this.label14.TabIndex = 14;
            this.label14.Text = "Middle Button Key (M):";
            // 
            // _screenMousePictureBox
            // 
            this._screenMousePictureBox.Location = new System.Drawing.Point(31, 112);
            this._screenMousePictureBox.Name = "_screenMousePictureBox";
            this._screenMousePictureBox.Size = new System.Drawing.Size(123, 129);
            this._screenMousePictureBox.TabIndex = 13;
            this._screenMousePictureBox.TabStop = false;
            // 
            // _screenMouseRightComboBox
            // 
            this._screenMouseRightComboBox.FormattingEnabled = true;
            this._screenMouseRightComboBox.Location = new System.Drawing.Point(164, 73);
            this._screenMouseRightComboBox.Name = "_screenMouseRightComboBox";
            this._screenMouseRightComboBox.Size = new System.Drawing.Size(95, 21);
            this._screenMouseRightComboBox.TabIndex = 17;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(47, 76);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(107, 13);
            this.label15.TabIndex = 15;
            this.label15.Text = "Right Button Key (R):";
            // 
            // _autoClickTab
            // 
            this._autoClickTab.Controls.Add(this._buttonGroupBox);
            this._autoClickTab.Controls.Add(this._clickGroupBox);
            this._autoClickTab.Location = new System.Drawing.Point(4, 22);
            this._autoClickTab.Name = "_autoClickTab";
            this._autoClickTab.Padding = new System.Windows.Forms.Padding(3);
            this._autoClickTab.Size = new System.Drawing.Size(547, 492);
            this._autoClickTab.TabIndex = 2;
            this._autoClickTab.Text = "Auto Click";
            this._autoClickTab.UseVisualStyleBackColor = true;
            // 
            // _advancedTab
            // 
            this._advancedTab.Controls.Add(this.groupBox1);
            this._advancedTab.Controls.Add(this._selectRadiusGroupBox);
            this._advancedTab.Location = new System.Drawing.Point(4, 22);
            this._advancedTab.Name = "_advancedTab";
            this._advancedTab.Padding = new System.Windows.Forms.Padding(3);
            this._advancedTab.Size = new System.Drawing.Size(547, 492);
            this._advancedTab.TabIndex = 3;
            this._advancedTab.Text = "Advanced";
            this._advancedTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this._screenMouseActiveTranslucencyNumeric);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this._screenMouseIdleTranslucencyNumeric);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._expandingRingRadiusNumeric);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._clickIntervalNumeric);
            this.groupBox1.Location = new System.Drawing.Point(9, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(532, 152);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Miscellaneous Settings";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(348, 104);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(15, 13);
            this.label22.TabIndex = 13;
            this.label22.Text = "%";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 104);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(200, 13);
            this.label23.TabIndex = 12;
            this.label23.Text = "Screen Mouse translucency when active";
            // 
            // _screenMouseActiveTranslucencyNumeric
            // 
            this._screenMouseActiveTranslucencyNumeric.Location = new System.Drawing.Point(222, 102);
            this._screenMouseActiveTranslucencyNumeric.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this._screenMouseActiveTranslucencyNumeric.Name = "_screenMouseActiveTranslucencyNumeric";
            this._screenMouseActiveTranslucencyNumeric.Size = new System.Drawing.Size(120, 20);
            this._screenMouseActiveTranslucencyNumeric.TabIndex = 11;
            this._screenMouseActiveTranslucencyNumeric.Value = new decimal(new int[] {
            75,
            0,
            0,
            0});
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(348, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "%";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(19, 78);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(187, 13);
            this.label18.TabIndex = 9;
            this.label18.Text = "Screen Mouse translucency when idle";
            // 
            // _screenMouseIdleTranslucencyNumeric
            // 
            this._screenMouseIdleTranslucencyNumeric.Location = new System.Drawing.Point(222, 76);
            this._screenMouseIdleTranslucencyNumeric.Minimum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this._screenMouseIdleTranslucencyNumeric.Name = "_screenMouseIdleTranslucencyNumeric";
            this._screenMouseIdleTranslucencyNumeric.Size = new System.Drawing.Size(120, 20);
            this._screenMouseIdleTranslucencyNumeric.TabIndex = 8;
            this._screenMouseIdleTranslucencyNumeric.Value = new decimal(new int[] {
            15,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(348, 52);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "pixels";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 52);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Size of expanding rings";
            // 
            // _expandingRingRadiusNumeric
            // 
            this._expandingRingRadiusNumeric.Location = new System.Drawing.Point(222, 50);
            this._expandingRingRadiusNumeric.Name = "_expandingRingRadiusNumeric";
            this._expandingRingRadiusNumeric.Size = new System.Drawing.Size(120, 20);
            this._expandingRingRadiusNumeric.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(348, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "millisecconds";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(197, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Duration between clicks in double clicks";
            // 
            // _clickIntervalNumeric
            // 
            this._clickIntervalNumeric.Location = new System.Drawing.Point(222, 24);
            this._clickIntervalNumeric.Name = "_clickIntervalNumeric";
            this._clickIntervalNumeric.Size = new System.Drawing.Size(120, 20);
            this._clickIntervalNumeric.TabIndex = 0;
            // 
            // AutoMouseSettingsControl
            // 
            this.AutoDetectChildStateChanges = true;
            //this.AutoLocateSettings = true;
            this.AutoSaveSettingsOnStateChanged = true;
            this.Controls.Add(this._tabControl);
            this.Name = "AutoMouseSettingsControl";
            this.Size = new System.Drawing.Size(555, 518);
            this._buttonGroupBox.ResumeLayout(false);
            this._buttonGroupBox.PerformLayout();
            this._selectRadiusGroupBox.ResumeLayout(false);
            this._clickGroupBox.ResumeLayout(false);
            this._clickGroupBox.PerformLayout();
            this._tabControl.ResumeLayout(false);
            this._generalTab.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this._screenMouseTab.ResumeLayout(false);
            this._screenMouseTab.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseTimeoutNumeric)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMousePictureBox)).EndInit();
            this._autoClickTab.ResumeLayout(false);
            this._autoClickTab.PerformLayout();
            this._advancedTab.ResumeLayout(false);
            this._advancedTab.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseActiveTranslucencyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._screenMouseIdleTranslucencyNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._expandingRingRadiusNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._clickIntervalNumeric)).EndInit();
            this.ResumeLayout(false);

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
		private ComboBox _screenMouseLeftComboBox;
		private Label label13;
		private ComboBox _screenMouseMiddleComboBox;
		private Label label14;
		private PictureBox _screenMousePictureBox;
		private ComboBox _screenMouseRightComboBox;
		private Label label15;
		private ComboBox _screenMouseActivationKeyComboBox;
		private Label label17;
		private Label label16;
		private Label label12;
		private Label label11;
		private Label label7;
		private Label label18;
		private NumericUpDown _screenMouseIdleTranslucencyNumeric;
		private Label label21;
		private Label label20;
		private Label label19;
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


	}
}
