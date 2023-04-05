using System;
using System.Windows.Forms;
using Hydrogen;
using Hydrogen.Application;
using Hydrogen.Windows.Forms;

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
				HydrogenFramework.Instance.StartWinFormsApplication<MainForm>(options:HydrogenFrameworkOptions.EnableDrm | HydrogenFrameworkOptions.BackgroundLicenseVerify);
			}
		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
			try {
				MessageBox.Show(
					e.ExceptionObject!= null ? (e.ExceptionObject is Exception ? ((Exception)e.ExceptionObject).ToDisplayString() : e.ToString()) : "(no information available)",
					"Unexpected Error",
					MessageBoxButtons.OK,
					MessageBoxIcon.Error
				);
			} catch {

			}
		}


	}
}
