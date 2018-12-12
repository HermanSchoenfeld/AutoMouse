using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Sphere10.Application;
using Sphere10.Application.WinForms;
using Sphere10.AutoMouse.Windows.Properties;
using Sphere10.Common;
using Sphere10.Windows;
using System.Threading;

namespace Sphere10.AutoMouse.Windows {
	public partial class MainForm : LiteMainForm {
		private AutoMouseSettings _settings;
		private readonly WindowsScreenMouse _mouseForm;
		private bool _hideOnLoad = false;

		public MainForm(bool hideOnLoad = true) {
			InitializeComponent();
			_helpIcon.Image = Sphere10.Application.WinForms.Properties.Resources.Help_16x16x32;
			_aboutToolStripButton.Image = Sphere10.Application.WinForms.Properties.Resources.Sphere10_16x16x32;
			_purchaseToolStripButton.Image = Sphere10.Application.WinForms.Properties.Resources.Purchase_16x16x32;
			_notifyIcon.Icon = AutoMouse.Properties.Resources.MouseNoButton;
			Icon = AutoMouse.Properties.Resources.MouseNoButton;
			AutoMouseController = null;
			_hideOnLoad = hideOnLoad;
		}

		public IAutoMouseController AutoMouseController { get; set; }

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			if (!Tool.IsDesignMode) {
				AutoMouseController = ApplicationFrameworkManager.Resolve<IAutoMouseController>();
				AutoMouseController.Stop();
				ToggleOnOff();
				if (_hideOnLoad) {
					Hide();
				}
			}
		}

		protected override void OnApplicationExiting(CancelEventArgs cancelEventArgs) {
			base.OnApplicationExiting(cancelEventArgs);
            AutoMouseController.Stop();
			AutoMouseController.Dispose();
		}

		public void ToggleOnOff() {
			if (AutoMouseController != null) {
				if (AutoMouseController.Started) {
					AutoMouseController.Stop();
					_toggleToolStripButton.Image =
						_toggleAutoMouseToolStripMenuItem.Image = Resource.Play_16x16x32;
					_toggleToolStripButton.Text =
						_toggleAutoMouseToolStripMenuItem.Text = "Turn On";
				} else {
					AutoMouseController.Start();
					_toggleToolStripButton.Image =
						_toggleAutoMouseToolStripMenuItem.Image = Resource.Shutdown_16x16x32;
					_toggleToolStripButton.Text =
						_toggleAutoMouseToolStripMenuItem.Text = "Turn Off";
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e) {
			ApplicationServices.Exit();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e) {
			Show();
		}

		private void toggleAutoClickToolStripMenuItem_Click(object sender, EventArgs e) {
			ToggleOnOff();
		}

		private void _closeButton_Click(object sender, EventArgs e) {
			base.Hide();
		}

		private void _resetToDefaultButton_Click(object sender, EventArgs e) {
			if (AskYN("Reset settings to factory default?")) {
				AutoMouseController.Settings.ResetToDefault();
				AutoMouseController.Settings.Save();
				_autoMouseSettingsControl.Refresh();
			}
		}

		private void _toggleToolStripButton_Click(object sender, EventArgs e) {
			ToggleOnOff();
		}

		private void _helpIcon_Click(object sender, EventArgs e) {
            ApplicationServices.ShowContextHelp(_autoMouseSettingsControl);
		}

		private void _aboutToolStripButton_Click(object sender, EventArgs e) {
			ApplicationServices.ShowAboutBox();
		}

		private void _purchaseToolStripButton_Click(object sender, EventArgs e) {
			ApplicationServices.LaunchProductPurchaseWebsite();
		}


	}
}
