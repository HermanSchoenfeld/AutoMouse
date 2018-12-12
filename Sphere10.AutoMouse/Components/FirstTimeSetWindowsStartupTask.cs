using System.Reflection;
using Sphere10.Application;


namespace Sphere10.AutoMouse {
	public class FirstTimeSetWindowsStartupTask : BaseApplicationInitializeTask {

		public FirstTimeSetWindowsStartupTask(IProductInformationServices productInformationServices, IProductUsageServices productUsageServices, IAutoRunServices autoRunServices) {
			ProductInformationServices = productInformationServices;
			ProductUsageServices = productUsageServices;
			AutoRunServices = autoRunServices;
		}

		public IProductInformationServices ProductInformationServices { get; private set; }
		public IProductUsageServices ProductUsageServices { get; private set; }

		public IAutoRunServices AutoRunServices { get; private set; }

		public override void Initialize() {
			if (ProductUsageServices.ProductUsageInformation.NumberOfUsesByUser == 1) {
				// Set the app to autorun, when user first loads this application
				if (AutoRunServices.DoesAutoRun(AutoRunType.CurrentUser, ProductInformationServices.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location)) {
					AutoRunServices.RemoveAutoRun(AutoRunType.CurrentUser, ProductInformationServices.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location);
				}
				AutoRunServices.SetAutoRun(AutoRunType.CurrentUser, ProductInformationServices.ProductInformation.ProductName, Assembly.GetExecutingAssembly().Location);
			}
		}
	}

}
