using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows.Forms;
using System;
using System.Windows.Forms;

namespace Sphere10.AutoMouse.Windows {

	static class Program {

		/// <summar>y
		/// The main entry point for the application.
		/// </summary>`
		[STAThread]
		static void Main(params string[] args) {
			using (new SingleApplicationInstanceScope()) {
				AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
				Application.EnableVisualStyles();
				Application.SetCompatibleTextRenderingDefault(false);
				
				Sphere10Framework.Instance.StartWinFormsApplication<MainForm>();
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
