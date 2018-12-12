namespace Sphere10.AutoMouse.Windows {
	partial class MainForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._systrayMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._toggleAutoMouseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this._closeButton = new System.Windows.Forms.Button();
            this._toolStrip = new System.Windows.Forms.ToolStrip();
            this._toggleToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._helpIcon = new System.Windows.Forms.ToolStripButton();
            this._purchaseToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._aboutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this._resetToDefaultButton = new System.Windows.Forms.Button();
            this._autoMouseSettingsControl = new Sphere10.AutoMouse.Windows.AutoMouseSettingsControl();
            this.applicationBanner1 = new Sphere10.Application.WinForms.ApplicationBanner();
            this.panel1 = new System.Windows.Forms.Panel();
            this._systrayMenu.SuspendLayout();
            this._toolStrip.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _systrayMenu
            // 
            this._systrayMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toggleAutoMouseToolStripMenuItem,
            this._optionsToolStripMenuItem,
            this._exitToolStripMenuItem});
            this._systrayMenu.Name = "contextMenuStrip1";
            this._systrayMenu.Size = new System.Drawing.Size(184, 70);
            // 
            // _toggleAutoMouseToolStripMenuItem
            // 
            this._toggleAutoMouseToolStripMenuItem.Name = "_toggleAutoMouseToolStripMenuItem";
            this._toggleAutoMouseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this._toggleAutoMouseToolStripMenuItem.Text = "&Switch AutoClick On";
            this._toggleAutoMouseToolStripMenuItem.Click += new System.EventHandler(this.toggleAutoClickToolStripMenuItem_Click);
            // 
            // _optionsToolStripMenuItem
            // 
            this._optionsToolStripMenuItem.Name = "_optionsToolStripMenuItem";
            this._optionsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this._optionsToolStripMenuItem.Text = "&Options";
            this._optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // _exitToolStripMenuItem
            // 
            this._exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
            this._exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this._exitToolStripMenuItem.Text = "E&xit";
            this._exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // _notifyIcon
            // 
            this._notifyIcon.ContextMenuStrip = this._systrayMenu;
            this._notifyIcon.Text = "Auto Mouse";
            this._notifyIcon.Visible = true;
            // 
            // _closeButton
            // 
            this._closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._closeButton.Location = new System.Drawing.Point(445, 9);
            this._closeButton.Name = "_closeButton";
            this._closeButton.Size = new System.Drawing.Size(120, 23);
            this._closeButton.TabIndex = 2;
            this._closeButton.Text = "&Close";
            this._closeButton.UseVisualStyleBackColor = true;
            this._closeButton.Click += new System.EventHandler(this._closeButton_Click);
            // 
            // _toolStrip
            // 
            this._toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toggleToolStripButton,
            this._helpIcon,
            this._purchaseToolStripButton,
            this._aboutToolStripButton});
            this._toolStrip.Location = new System.Drawing.Point(0, 96);
            this._toolStrip.Name = "_toolStrip";
            this._toolStrip.Size = new System.Drawing.Size(572, 25);
            this._toolStrip.TabIndex = 20;
            this._toolStrip.Text = "toolStrip1";
            // 
            // _toggleToolStripButton
            // 
            this._toggleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._toggleToolStripButton.Name = "_toggleToolStripButton";
            this._toggleToolStripButton.Size = new System.Drawing.Size(123, 22);
            this._toggleToolStripButton.Text = "Turn Auto Mouse On";
            this._toggleToolStripButton.Click += new System.EventHandler(this._toggleToolStripButton_Click);
            // 
            // _helpIcon
            // 
            this._helpIcon.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this._helpIcon.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._helpIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._helpIcon.Name = "_helpIcon";
            this._helpIcon.Size = new System.Drawing.Size(23, 22);
            this._helpIcon.Text = "Context Help";
            this._helpIcon.Click += new System.EventHandler(this._helpIcon_Click);
            // 
            // _purchaseToolStripButton
            // 
            this._purchaseToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("_purchaseToolStripButton.Image")));
            this._purchaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._purchaseToolStripButton.Name = "_purchaseToolStripButton";
            this._purchaseToolStripButton.Size = new System.Drawing.Size(75, 22);
            this._purchaseToolStripButton.Text = "Purchase";
            this._purchaseToolStripButton.Click += new System.EventHandler(this._purchaseToolStripButton_Click);
            // 
            // _aboutToolStripButton
            // 
            this._aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._aboutToolStripButton.Name = "_aboutToolStripButton";
            this._aboutToolStripButton.Size = new System.Drawing.Size(44, 22);
            this._aboutToolStripButton.Text = "About";
            this._aboutToolStripButton.Click += new System.EventHandler(this._aboutToolStripButton_Click);
            // 
            // _resetToDefaultButton
            // 
            this._resetToDefaultButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._resetToDefaultButton.Location = new System.Drawing.Point(12, 9);
            this._resetToDefaultButton.Name = "_resetToDefaultButton";
            this._resetToDefaultButton.Size = new System.Drawing.Size(120, 23);
            this._resetToDefaultButton.TabIndex = 21;
            this._resetToDefaultButton.Text = "&Reset To Default";
            this._resetToDefaultButton.UseVisualStyleBackColor = true;
            this._resetToDefaultButton.Click += new System.EventHandler(this._resetToDefaultButton_Click);
            // 
            // _autoMouseSettingsControl
            // 
            this._autoMouseSettingsControl.AutoLocateSettings = true;
            this._autoMouseSettingsControl.AutoSaveSettingsOnStateChanged = true;
            this._autoMouseSettingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this._autoMouseSettingsControl.Location = new System.Drawing.Point(0, 121);
            this._autoMouseSettingsControl.Name = "_autoMouseSettingsControl";
            this._autoMouseSettingsControl.Padding = new System.Windows.Forms.Padding(4);
            this._autoMouseSettingsControl.Size = new System.Drawing.Size(572, 460);
            this._autoMouseSettingsControl.TabIndex = 1;
            // 
            // applicationBanner1
            // 
            this.applicationBanner1.AutoDetectChildStateChanges = false;
            this.applicationBanner1.CompanyName = "{CompanyName}";
            this.applicationBanner1.Dock = System.Windows.Forms.DockStyle.Top;
            this.applicationBanner1.FromColor = System.Drawing.Color.RoyalBlue;
            this.applicationBanner1.Location = new System.Drawing.Point(0, 0);
            this.applicationBanner1.Name = "applicationBanner1";
            this.applicationBanner1.Size = new System.Drawing.Size(572, 96);
            this.applicationBanner1.TabIndex = 22;
            this.applicationBanner1.Title = "{ProductName}";
            this.applicationBanner1.ToColor = System.Drawing.Color.LightBlue;
            this.applicationBanner1.Version = "Version {ProductVersion} (PATENT PENDING)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._closeButton);
            this.panel1.Controls.Add(this._resetToDefaultButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 581);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 4, 0);
            this.panel1.Size = new System.Drawing.Size(572, 44);
            this.panel1.TabIndex = 23;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 625);
            this.CloseAction = ((Sphere10.Application.FormCloseAction)((Sphere10.Application.FormCloseAction.Hide | Sphere10.Application.FormCloseAction.Minimize)));
            this.ControlBox = false;
            this.Controls.Add(this._autoMouseSettingsControl);
            this.Controls.Add(this._toolStrip);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.applicationBanner1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this._systrayMenu.ResumeLayout(false);
            this._toolStrip.ResumeLayout(false);
            this._toolStrip.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip _systrayMenu;
		private System.Windows.Forms.ToolStripMenuItem _toggleAutoMouseToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _optionsToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem _exitToolStripMenuItem;
		private System.Windows.Forms.NotifyIcon _notifyIcon;
		private global::Sphere10.AutoMouse.Windows.AutoMouseSettingsControl _autoMouseSettingsControl;
		private System.Windows.Forms.Button _closeButton;
		private System.Windows.Forms.ToolStrip _toolStrip;
		private System.Windows.Forms.ToolStripButton _toggleToolStripButton;
		private System.Windows.Forms.ToolStripButton _helpIcon;
		private System.Windows.Forms.ToolStripButton _purchaseToolStripButton;
		private System.Windows.Forms.ToolStripButton _aboutToolStripButton;
		private System.Windows.Forms.Button _resetToDefaultButton;
		private Sphere10.Application.WinForms.ApplicationBanner applicationBanner1;
		private System.Windows.Forms.Panel panel1;
	}
}