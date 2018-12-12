using System;
using System.Drawing;
using System.Timers;
using Sphere10.AutoMouse.Properties;
using Sphere10.Application;
using Sphere10.Common;

namespace Sphere10.AutoMouse {

	public interface ISoundMaker {
		void PlayClickSound(MouseButton button, MouseButtonState buttonState);
	}
}
