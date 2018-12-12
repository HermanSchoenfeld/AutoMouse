using System;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using Microsoft.Win32;
using Sphere10.Common;
using Sphere10.Windows;
using Sphere10.Application.WinForms;
using Sphere10.Application;

namespace Sphere10.AutoMouse.Windows {

	static class Program {

		/// <summar>y
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main(params string[] args) {
			using (new SingleApplicationInstanceScope()) {
				AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);
				System.Windows.Forms.Application.EnableVisualStyles();
				System.Windows.Forms.Application.SetCompatibleTextRenderingDefault(false);

				var form = new MainForm(!args.Any(p => p.ToUpperInvariant() == "/FULL"));
				WinFormsApplicationFrameworkManager.Instance.RegisterDefaultProviders(form);
				AssemblyRegistrationManager.RegisterIocComponents();
				RegisterIocComponents();
				WinFormsApplicationFrameworkManager.Instance.Start();
				System.Windows.Forms.Application.Run(form);
			}
		}


		static void RegisterIocComponents() {
			// Components
            ApplicationFrameworkManager.RegisterComponent<IActiveApplicationMonitor, NoOpActiveApplicationMonitor>();
			ApplicationFrameworkManager.RegisterComponent<IMouseHook, WindowsMouseHook>();
			ApplicationFrameworkManager.RegisterComponent<IKeyboardHook, WindowsKeyboardHook>();
			ApplicationFrameworkManager.RegisterComponent<IScreenMouse, WindowsScreenMouse>();
			ApplicationFrameworkManager.RegisterComponent<IAutoMouseController, WindowsAutoMouseController>();
			ApplicationFrameworkManager.RegisterComponent<IExpandingCircleRenderer, WindowsExpandingCircleRenderer>();
			ApplicationFrameworkManager.RegisterComponent<IControlStateChangeManager, ClickRadiusSelector.StateChangeManager>(typeof(ClickRadiusSelector).FullName);
			ApplicationFrameworkManager.RegisterComponent<IAboutBox, AboutBox>();
			ApplicationFrameworkManager.RegisterComponent<INagDialog, NagScreen>();
            ApplicationFrameworkManager.RegisterComponent<IHelpServices, CHMHelpProvider>();
			// Component Settings
			// ...
			
			// Initialization Tasks
			// ...

			// Start Tasks
			// ...
			
			// End Tasks
			// ...

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
