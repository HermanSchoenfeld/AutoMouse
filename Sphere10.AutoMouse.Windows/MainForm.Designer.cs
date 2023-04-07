using System.ComponentModel;
using System.Windows.Forms;
using Hydrogen.Windows.Forms;

namespace Sphere10.AutoMouse.Windows
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			components = new Container();
			var resources = new ComponentResourceManager(typeof(MainForm));
			_systrayMenu = new ContextMenuStrip(components);
			_toggleAutoMouseToolStripMenuItem = new ToolStripMenuItem();
			_optionsToolStripMenuItem = new ToolStripMenuItem();
			_exitToolStripMenuItem = new ToolStripMenuItem();
			_notifyIcon = new NotifyIcon(components);
			_closeButton = new Button();
			_toolStrip = new ToolStrip();
			_toggleToolStripButton = new ToolStripButton();
			_helpIcon = new ToolStripButton();
			_purchaseToolStripButton = new ToolStripButton();
			_aboutToolStripButton = new ToolStripButton();
			_resetToDefaultButton = new Button();
			_autoMouseSettingsControl = new AutoMouseSettingsControl();
			applicationBanner1 = new ApplicationBanner();
			panel1 = new Panel();
			_systrayMenu.SuspendLayout();
			_toolStrip.SuspendLayout();
			panel1.SuspendLayout();
			SuspendLayout();
			// 
			// _systrayMenu
			// 
			_systrayMenu.Items.AddRange(new ToolStripItem[] { _toggleAutoMouseToolStripMenuItem, _optionsToolStripMenuItem, _exitToolStripMenuItem });
			_systrayMenu.Name = "contextMenuStrip1";
			_systrayMenu.Size = new System.Drawing.Size(184, 70);
			// 
			// _toggleAutoMouseToolStripMenuItem
			// 
			_toggleAutoMouseToolStripMenuItem.Name = "_toggleAutoMouseToolStripMenuItem";
			_toggleAutoMouseToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			_toggleAutoMouseToolStripMenuItem.Text = "&Switch AutoClick On";
			_toggleAutoMouseToolStripMenuItem.Click += toggleAutoClickToolStripMenuItem_Click;
			// 
			// _optionsToolStripMenuItem
			// 
			_optionsToolStripMenuItem.Name = "_optionsToolStripMenuItem";
			_optionsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			_optionsToolStripMenuItem.Text = "&Options";
			_optionsToolStripMenuItem.Click += optionsToolStripMenuItem_Click;
			// 
			// _exitToolStripMenuItem
			// 
			_exitToolStripMenuItem.Name = "_exitToolStripMenuItem";
			_exitToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
			_exitToolStripMenuItem.Text = "E&xit";
			_exitToolStripMenuItem.Click += exitToolStripMenuItem_Click;
			// 
			// _notifyIcon
			// 
			_notifyIcon.ContextMenuStrip = _systrayMenu;
			_notifyIcon.Text = "Auto Mouse";
			_notifyIcon.Visible = true;
			// 
			// _closeButton
			// 
			_closeButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			_closeButton.Location = new System.Drawing.Point(420, 10);
			_closeButton.Margin = new Padding(4, 3, 4, 3);
			_closeButton.Name = "_closeButton";
			_closeButton.Size = new System.Drawing.Size(140, 27);
			_closeButton.TabIndex = 2;
			_closeButton.Text = "&Close";
			_closeButton.UseVisualStyleBackColor = true;
			_closeButton.Click += _closeButton_Click;
			// 
			// _toolStrip
			// 
			_toolStrip.Items.AddRange(new ToolStripItem[] { _toggleToolStripButton, _helpIcon, _purchaseToolStripButton, _aboutToolStripButton });
			_toolStrip.Location = new System.Drawing.Point(0, 111);
			_toolStrip.Name = "_toolStrip";
			_toolStrip.Size = new System.Drawing.Size(568, 25);
			_toolStrip.TabIndex = 20;
			_toolStrip.Text = "toolStrip1";
			// 
			// _toggleToolStripButton
			// 
			_toggleToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			_toggleToolStripButton.Name = "_toggleToolStripButton";
			_toggleToolStripButton.Size = new System.Drawing.Size(122, 22);
			_toggleToolStripButton.Text = "Turn Auto Mouse On";
			_toggleToolStripButton.Click += _toggleToolStripButton_Click;
			// 
			// _helpIcon
			// 
			_helpIcon.Alignment = ToolStripItemAlignment.Right;
			_helpIcon.DisplayStyle = ToolStripItemDisplayStyle.Image;
			_helpIcon.ImageTransparentColor = System.Drawing.Color.Magenta;
			_helpIcon.Name = "_helpIcon";
			_helpIcon.Size = new System.Drawing.Size(23, 22);
			_helpIcon.Text = "Context Help";
			_helpIcon.Click += _helpIcon_Click;
			// 
			// _purchaseToolStripButton
			// 
			_purchaseToolStripButton.Image = (System.Drawing.Image)resources.GetObject("_purchaseToolStripButton.Image");
			_purchaseToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			_purchaseToolStripButton.Name = "_purchaseToolStripButton";
			_purchaseToolStripButton.Size = new System.Drawing.Size(75, 22);
			_purchaseToolStripButton.Text = "Purchase";
			_purchaseToolStripButton.Click += _purchaseToolStripButton_Click;
			// 
			// _aboutToolStripButton
			// 
			_aboutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
			_aboutToolStripButton.Name = "_aboutToolStripButton";
			_aboutToolStripButton.Size = new System.Drawing.Size(44, 22);
			_aboutToolStripButton.Text = "About";
			_aboutToolStripButton.Click += _aboutToolStripButton_Click;
			// 
			// _resetToDefaultButton
			// 
			_resetToDefaultButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			_resetToDefaultButton.Location = new System.Drawing.Point(14, 10);
			_resetToDefaultButton.Margin = new Padding(4, 3, 4, 3);
			_resetToDefaultButton.Name = "_resetToDefaultButton";
			_resetToDefaultButton.Size = new System.Drawing.Size(140, 27);
			_resetToDefaultButton.TabIndex = 21;
			_resetToDefaultButton.Text = "&Reset To Default";
			_resetToDefaultButton.UseVisualStyleBackColor = true;
			_resetToDefaultButton.Click += _resetToDefaultButton_Click;
			// 
			// _autoMouseSettingsControl
			// 
			_autoMouseSettingsControl.Dock = DockStyle.Fill;
			_autoMouseSettingsControl.Location = new System.Drawing.Point(0, 136);
			_autoMouseSettingsControl.Margin = new Padding(4, 3, 4, 3);
			_autoMouseSettingsControl.Name = "_autoMouseSettingsControl";
			_autoMouseSettingsControl.Padding = new Padding(5);
			_autoMouseSettingsControl.Size = new System.Drawing.Size(568, 433);
			_autoMouseSettingsControl.TabIndex = 1;
			// 
			// applicationBanner1
			// 
			applicationBanner1.CompanyName = "{CompanyName}";
			applicationBanner1.Dock = DockStyle.Top;
			applicationBanner1.FromColor = System.Drawing.Color.RoyalBlue;
			applicationBanner1.Location = new System.Drawing.Point(0, 0);
			applicationBanner1.Margin = new Padding(5, 3, 5, 3);
			applicationBanner1.MaximumSize = new System.Drawing.Size(9999, 111);
			applicationBanner1.Name = "applicationBanner1";
			applicationBanner1.Size = new System.Drawing.Size(568, 111);
			applicationBanner1.TabIndex = 22;
			applicationBanner1.Title = "{ProductName}";
			applicationBanner1.ToColor = System.Drawing.Color.LightBlue;
			applicationBanner1.Version = "Version {ProductVersion}";
			// 
			// panel1
			// 
			panel1.Controls.Add(_closeButton);
			panel1.Controls.Add(_resetToDefaultButton);
			panel1.Dock = DockStyle.Bottom;
			panel1.Location = new System.Drawing.Point(0, 569);
			panel1.Margin = new Padding(4, 3, 4, 3);
			panel1.Name = "panel1";
			panel1.Padding = new Padding(0, 0, 5, 0);
			panel1.Size = new System.Drawing.Size(568, 51);
			panel1.TabIndex = 23;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new System.Drawing.Size(568, 620);
			CloseAction = FormCloseAction.Hide | FormCloseAction.Minimize;
			ControlBox = false;
			Controls.Add(_autoMouseSettingsControl);
			Controls.Add(_toolStrip);
			Controls.Add(panel1);
			Controls.Add(applicationBanner1);
			FormBorderStyle = FormBorderStyle.Fixed3D;
			Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			Margin = new Padding(4, 3, 4, 3);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "MainForm";
			ShowInTaskbar = false;
			StartPosition = FormStartPosition.CenterScreen;
			_systrayMenu.ResumeLayout(false);
			_toolStrip.ResumeLayout(false);
			_toolStrip.PerformLayout();
			panel1.ResumeLayout(false);
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ContextMenuStrip _systrayMenu;
		private ToolStripMenuItem _toggleAutoMouseToolStripMenuItem;
		private ToolStripMenuItem _optionsToolStripMenuItem;
		private ToolStripMenuItem _exitToolStripMenuItem;
		private NotifyIcon _notifyIcon;
		private AutoMouseSettingsControl _autoMouseSettingsControl;
		private Button _closeButton;
		private ToolStrip _toolStrip;
		private ToolStripButton _toggleToolStripButton;
		private ToolStripButton _helpIcon;
		private ToolStripButton _purchaseToolStripButton;
		private ToolStripButton _aboutToolStripButton;
		private Button _resetToDefaultButton;
		private ApplicationBanner applicationBanner1;
		private Panel panel1;
	}
}