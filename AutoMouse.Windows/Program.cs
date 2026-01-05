// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows.Forms;

namespace AutoMouse.Windows {

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
				Sphere10Framework.Instance.StartWinFormsApplication<MainForm>(/*options:Sphere10FrameworkOptions.EnableDrm | Sphere10FrameworkOptions.BackgroundLicenseVerify*/);
			}
		}

		static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e) {
			try {
				if (e.ExceptionObject is Exception exception) {
					ExceptionDialog.Show("Unexpected error", exception);
				} else MessageBox.Show("No information available", "Unexpected Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			} catch {
			}
		}

	}
}
