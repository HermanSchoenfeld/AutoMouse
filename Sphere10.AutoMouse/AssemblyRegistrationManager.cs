using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Sphere10.Application;
using Sphere10.Common;
using System.Threading;

namespace Sphere10.AutoMouse {

	public class AssemblyRegistrationManager {

		public static void RegisterIocComponents() {
			// Components
			ApplicationFrameworkManager.RegisterComponent<ISoundMaker, DefaultSoundMaker>();

			// Component Settings
			ApplicationFrameworkManager.RegisterComponentSettings<AutoMouseSettings>();

			// Initialization Tasks
			ApplicationFrameworkManager.RegisterInitializationTask<FirstTimeSetWindowsStartupTask>();
		}

	}
	
}


