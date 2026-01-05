using System.Drawing;

namespace AutoMouse.Windows {

	public interface IExpandingCircleRenderer {
		void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius, int expansionSpeedPixelsPerSecond);
	}
}
