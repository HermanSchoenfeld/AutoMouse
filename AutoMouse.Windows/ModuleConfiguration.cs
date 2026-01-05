// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows;
using Sphere10.Framework.Windows.Forms;
using Microsoft.Extensions.DependencyInjection;

namespace AutoMouse.Windows {
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
			//services.AddInitializer<IncrementUsageByOneInitializer>();  // done in Sphere10.Framework.Application

		}

	}
}