using System;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows.Forms;

namespace Sphere10.AutoMouse.Windows {

	static class Program {

		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		//[STAThread]
		static void Main(params string[] args) {
			using (new SingleApplicationInstanceScope()) {
				AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
				Application.EnableVisualStyles();
				Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
				Application.SetCompatibleTextRenderingDefault(false);
				Sphere10Framework.Instance.StartWinFormsApplication<MainForm>(/*options:Sphere10FrameworkOptions.EnableDrm | Sphere10FrameworkOptions.BackgroundLicenseVerify*/);
			}
		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
			try {
				if (e.ExceptionObject is Exception exception) {
					ExceptionDialog.Show("Unexpected error", exception);
				} else MessageBox.Show("No information available", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch {
			}
		}

	}
}
