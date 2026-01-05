using System;
using Sphere10.Framework;

namespace AutoMouse.Windows {

	public interface ISoundMaker : IDisposable {
		void PlayClickSound(MouseButton button, MouseButtonState buttonState);
	}
}
