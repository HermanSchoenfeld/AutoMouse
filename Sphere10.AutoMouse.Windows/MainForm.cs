using Sphere10.Framework.Application;
using Sphere10.Framework.Windows.Forms;
using System;
using System.ComponentModel;
using System.Drawing; 

namespace Sphere10.AutoMouse.Windows {
	public partial class MainForm : LiteMainForm {
		private AutoMouseSettings _settings;
		private readonly WindowsScreenMouse _mouseForm;
		private bool _hideOnLoad;

		public MainForm() : this(true) {
		}

		public MainForm(bool hideOnLoad) {
			InitializeComponent();
			_helpIcon.Image = Sphere10.Framework.Windows.Forms.Properties.Resources.Help_16x16x32;
			_aboutToolStripButton.Image = Sphere10.Framework.Windows.Forms.Properties.Resources.Sphere10_16x16x32;
			_purchaseToolStripButton.Image = Sphere10.Framework.Windows.Forms.Properties.Resources.Purchase_16x16x32;
			_notifyIcon.Icon = AutoMouse.Properties.Resources.MouseNoButton;
			Icon = AutoMouse.Properties.Resources.MouseNoButton;
			AutoMouseController = null;
			_hideOnLoad = hideOnLoad;
		}

		public IAutoMouseController AutoMouseController { get; set; }

		protected override void OnLoad(EventArgs e) {
			base.OnLoad(e);
			if (!Tools.Runtime.IsDesignMode) {
				AutoMouseController = ComponentRegistry.Instance.Resolve<IAutoMouseController>();
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
						_toggleAutoMouseToolStripMenuItem.Image = Resource.Play_16x16x32.ToBitmap();
					_toggleToolStripButton.Text =
						_toggleAutoMouseToolStripMenuItem.Text = "Turn On";
				} else {
					AutoMouseController.Start();
					_toggleToolStripButton.Image =
						_toggleAutoMouseToolStripMenuItem.Image = Resource.Shutdown_16x16x32.ToBitmap();
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
				AutoMouseController.Settings.RestoreDefaultValues();
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
