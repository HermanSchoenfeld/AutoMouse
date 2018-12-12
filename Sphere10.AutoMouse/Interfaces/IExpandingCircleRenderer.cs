using System;
using System.Drawing;
using System.Timers;
using Sphere10.AutoMouse.Properties;
using Sphere10.Application;
using Sphere10.Common;

namespace Sphere10.AutoMouse {

	public interface IExpandingCircleRenderer {
		void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius, int expansionSpeedPixelsPerSecond);
	}
}
