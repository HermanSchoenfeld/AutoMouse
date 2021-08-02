using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows;
using Sphere10.Framework.Windows.Forms;

namespace Sphere10.AutoMouse.Windows {
	public class ModuleConfiguration : ModuleConfigurationBase {
		public override void RegisterComponents(ComponentRegistry registry) {
			registry.RegisterComponent<ISoundMaker, DefaultSoundMaker>();
			registry.RegisterComponent<IActiveApplicationMonitor, NoOpActiveApplicationMonitor>();
			registry.RegisterComponent<IMouseHook, WindowsMouseHook>();
			registry.RegisterComponent<IKeyboardHook, WindowsKeyboardHook>();
			registry.RegisterComponent<IScreenMouse, WindowsScreenMouse>();
			registry.RegisterComponent<IAutoMouseController, WindowsAutoMouseController>();
			registry.RegisterComponent<IExpandingCircleRenderer, WindowsExpandingCircleRenderer>();
			registry.RegisterComponent<IControlStateChangeManager, ClickRadiusSelector.StateChangeManager>(typeof(ClickRadiusSelector).FullName);
			registry.RegisterComponent<IAboutBox, AboutBox>();
			registry.RegisterComponent<INagDialog, NagScreen>();
			registry.RegisterComponent<IHelpServices, CHMHelpProvider>();

			registry.RegisterInitializationTask<FirstTimeSetWindowsStartupTask>();

			base.RegisterComponents(registry);
		}
	}
}
