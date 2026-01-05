// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System.Drawing;
using Sphere10.Framework.Windows.Forms;

namespace AutoMouse.Windows {
	public class WindowsExpandingCircleRenderer : IExpandingCircleRenderer {
		public void DrawExpandingCircle(int centreX, int centreY, Color color, int thickness, int maxRadius,
		                                int expansionSpeedPixelsPerSecond) {
			ExpandingCircle.ShowExpandingCircle(centreX, centreY, color, thickness, maxRadius, expansionSpeedPixelsPerSecond);
		}



	}
}
