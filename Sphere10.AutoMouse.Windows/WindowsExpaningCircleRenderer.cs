using System.Drawing;
using Sphere10.Framework.Windows.Forms;

namespace Sphere10.AutoMouse.Windows {
	public class WindowsExpandingCircleRenderer : IExpandingCircleRenderer {
		public void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius,
		                                int expansionSpeedPixelsPerSecond) {
			ExpandingCircle.ShowExpandingCircle(centreX, centreY, color, thickness, maxRadius, expansionSpeedPixelsPerSecond);
		}



	}
}
