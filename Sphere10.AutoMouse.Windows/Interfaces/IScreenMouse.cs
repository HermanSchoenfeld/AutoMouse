using System;
using Sphere10.Framework;

namespace Sphere10.AutoMouse.Windows;

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
