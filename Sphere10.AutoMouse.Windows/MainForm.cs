using System;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using Hydrogen;
using Hydrogen.Application;
using Hydrogen.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;
using Tools;
using Resources = Sphere10.AutoMouse.Properties.Resources;
using AutoMouseWindowsResources = Sphere10.AutoMouse.Windows.Properties.Resources;
using FormResources = Hydrogen.Windows.Forms.Resources;

namespace Sphere10.AutoMouse.Windows
{
	public partial class MainForm : LiteMainForm
	{
		private AutoMouseSettings _settings;
		private readonly WindowsScreenMouse _mouseForm;

		public MainForm() {
			InitializeComponent();
			var scale = this.DeviceDpi / 96.0D;
			_helpIcon.Image = Resources.Help_128x128_32.Resize(new Size(16, 16).ScaleBy(scale));
			_aboutToolStripButton.Image = Resources.Sphere10_286x286_32.Resize(new Size(16, 16).ScaleBy(scale));
			_purchaseToolStripButton.Image = FormResources.Purchase_16x16x32;
			_notifyIcon.Icon = Resources.MouseNoButton;
			_notifyIcon.EnableContextMenuOnLeftClick();
			Icon = Resources.MouseNoButton;
			AutoMouseController = null;
		}

		public IAutoMouseController AutoMouseController { get; set; }

		protected override void OnLoad(EventArgs e)
		{
			base.OnLoad(e);
			if (!Runtime.IsDesignMode)
			{
				AutoMouseController = HydrogenFramework.Instance.ServiceProvider.GetService<IAutoMouseController>();
				AutoMouseController.Stop();
				ToggleOnOff();
				var xxx  = HydrogenFramework.Instance.ServiceProvider.GetService<IProductUsageServices>().ProductUsageInformation.NumberOfUsesByUser;
				var hideOnLoad = HydrogenFramework.Instance.ServiceProvider.GetService<IProductUsageServices>().ProductUsageInformation.NumberOfUsesByUser > 1;
				if (hideOnLoad)
					Hide();
			}
		}

		protected override void OnApplicationExiting(CancelEventArgs cancelEventArgs)
		{
			base.OnApplicationExiting(cancelEventArgs);
			AutoMouseController.Stop();
			AutoMouseController.Dispose();
		}

		public void ToggleOnOff()
		{
			if (AutoMouseController != null)
			{
				if (AutoMouseController.Started)
				{
					AutoMouseController.Stop();
					_toggleToolStripButton.Image =
						_toggleAutoMouseToolStripMenuItem.Image = Resources.Play_16x16x32.ToBitmap();
					_toggleToolStripButton.Text =
						_toggleAutoMouseToolStripMenuItem.Text = "Turn On";
				} else
				{
					AutoMouseController.Start();
					_toggleToolStripButton.Image =
						_toggleAutoMouseToolStripMenuItem.Image = Resources.Shutdown_16x16x32.ToBitmap();
					_toggleToolStripButton.Text =
						_toggleAutoMouseToolStripMenuItem.Text = "Turn Off";
				}
			}
		}

		private void exitToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Exit();
		}

		private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Show();
		}

		private void toggleAutoClickToolStripMenuItem_Click(object sender, EventArgs e)
		{
			ToggleOnOff();
		}

		private void _closeButton_Click(object sender, EventArgs e)
		{
			base.Hide();
		}

		private void _resetToDefaultButton_Click(object sender, EventArgs e)
		{
			if (AskYN("Reset settings to factory default?"))
			{
				AutoMouseController.Settings.RestoreDefaultValues();
				AutoMouseController.Settings.Save();
				_autoMouseSettingsControl.Refresh();
			}
		}

		private void _toggleToolStripButton_Click(object sender, EventArgs e)
		{
			ToggleOnOff();
		}

		private void _helpIcon_Click(object sender, EventArgs e)
		{
			HydrogenFramework.Instance.ServiceProvider.GetService<IHelpServices>().ShowContextHelp(_autoMouseSettingsControl);
		}

		private void _aboutToolStripButton_Click(object sender, EventArgs e)
		{
			base.ShowAboutBox();
		}

		private void _purchaseToolStripButton_Click(object sender, EventArgs e)
		{
			HydrogenFramework.Instance.ServiceProvider.GetRequiredService<IWebsiteLauncher>().LaunchProductPurchaseWebsite();
		}

	}
}
