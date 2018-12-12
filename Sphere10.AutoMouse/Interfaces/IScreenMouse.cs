using System;
using System.Drawing;
using System.Timers;
using Sphere10.AutoMouse.Properties;
using Sphere10.Application;
using Sphere10.Common;

namespace Sphere10.AutoMouse {

	public interface IScreenMouse {

		event EventHandler<ScreenMouseStateChangedEvent> StateChanged;

		int Width { get; set; }

		int Height { get; set; }


		AutoMouseSettings Settings { get; }

		MouseButton PressedButton { get; set; }

		ScreenMouseState State { get; set; }

		DateTime LastActivityTime { get; set; }

		double ImageOpacity { get; set; }

		bool KeepAlive { get; set; }

		void FadeIn();

		void FadeOut();

		void FadeToFullOpacity();

		void MoveTo(int screenX, int screenY);

	}
}
