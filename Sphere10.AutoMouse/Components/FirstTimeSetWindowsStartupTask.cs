using System.Reflection;
using Hydrogen.Application;


namespace Sphere10.AutoMouse {
	public class FirstTimeSetWindowsStartupTask : ApplicationInitializerBase {

		public FirstTimeSetWindowsStartupTask(IProductInformationProvider productInformationProvider, IProductUsageServices productUsageServices, IAutoRunServices autoRunServices) {
			ProductInformationProvider = productInformationProvider;
			ProductUsageServices = productUsageServices;
			AutoRunServices = autoRunServices;
		}

		public IProductInformationProvider ProductInformationProvider { get; }
		public IProductUsageServices ProductUsageServices { get; private set; }
		public IAutoRunServices AutoRunServices { get; private set; }

		public override void Initialize() {
			if (ProductUsageServices.ProductUsageInformation.NumberOfUsesByUser == 1) {
				// Set the app to autorun, when user first loads this application
				if (AutoRunServices.DoesAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location)) {
					AutoRunServices.RemoveAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location);
				}
				AutoRunServices.SetAutoRun(AutoRunType.CurrentUser, ProductInformationProvider.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location);
			}
		}
	}

}
