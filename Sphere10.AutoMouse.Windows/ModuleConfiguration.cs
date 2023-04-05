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

			services.AddControlStateEventProvider<ClickRadiusSelector, ClickRadiusSelector.StateEventProvider>();

			services.AddTransient<FirstTimeSetWindowsStartupTask>();
		
			// Initializers/Finalizers
			services.AddTransient<IncrementUsageByOneInitializer>();
		}
	}
}
