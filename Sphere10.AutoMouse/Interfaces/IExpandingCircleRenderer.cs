using System.Drawing;

namespace Sphere10.AutoMouse {

	public interface IExpandingCircleRenderer {
		void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius, int expansionSpeedPixelsPerSecond);
	}
}
