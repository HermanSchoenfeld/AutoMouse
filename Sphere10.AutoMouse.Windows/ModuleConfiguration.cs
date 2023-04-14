using System;
using Hydrogen;
using Hydrogen.Application;
using Hydrogen.Windows;
using Hydrogen.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace Sphere10.AutoMouse.Windows {
	public class ModuleConfiguration : ModuleConfigurationBase {
		public override void RegisterComponents(IServiceCollection services) {
			services.AddTransient<ISoundMaker, DefaultSoundMaker>();
			services.AddTransient<IActiveApplicationMonitor, NoOpActiveApplicationMonitor>();
			services.AddTransient<IMouseHook, WindowsMouseHook>();
			services.AddTransient<IKeyboardHook, WindowsKeyboardHook>();
			services.AddTransient<IScreenMouse, WindowsScreenMouse>();
			services.AddTransient<IAutoMouseController, WindowsAutoMouseController>();
			services.AddTransient<IExpandingCircleRenderer, WindowsExpandingCircleRenderer>();
			services.AddTransient<IHelpServices, CHMHelpProvider>();
			services.AddTransient<IAutoRunServices, StartupFolderAutoRunServicesProvider>();
			
			// State changed providers
			services.AddControlStateEventProvider<ClickRadiusSelector, ClickRadiusSelector.StateEventProvider>();
		
			// Initializers/Finalizers
			services.AddInitializer<FirstTimeSetWindowsStartupTask>();
			//services.AddInitializer<IncrementUsageByOneInitializer>();  // done in Hydrogen.Application

		}

		public override void OnInitialize(IServiceProvider serviceProvider) {
			base.OnInitialize(serviceProvider);
			// Need to explicitly register the Hydrogen.CryptoEx so that cryptography providers are plugged into Hashers and Signers
			Hydrogen.CryptoEx.ExplicitModuleConfiguration.Initialize();
		}

		public override void OnFinalize(IServiceProvider serviceProvider) {
			base.OnFinalize(serviceProvider);
			Hydrogen.CryptoEx.ExplicitModuleConfiguration.Finalize();
		}

	}
}