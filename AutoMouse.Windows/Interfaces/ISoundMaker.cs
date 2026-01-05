using System;
using Sphere10.Framework;

namespace Sphere10.AutoMouse.Windows {

	public interface ISoundMaker : IDisposable {
		void PlayClickSound(MouseButton button, MouseButtonState buttonState);
	}
}
