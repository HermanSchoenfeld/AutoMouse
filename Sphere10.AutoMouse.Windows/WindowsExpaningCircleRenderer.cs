using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Sphere10.Application;
using Sphere10.Application.WinForms;
using Sphere10.AutoMouse.Properties;
using Sphere10.Common;
using Sphere10.Windows;
using System.Threading;

namespace Sphere10.AutoMouse.Windows {
	public class WindowsExpandingCircleRenderer : IExpandingCircleRenderer {


		public WindowsExpandingCircleRenderer() {
		}

		public void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius,
		                                int expansionSpeedPixelsPerSecond) {
			ExpandingCircle.ShowExpandingCircle(centreX, centreY, color, thickness, maxRadius, expansionSpeedPixelsPerSecond);
		}



	}
}
