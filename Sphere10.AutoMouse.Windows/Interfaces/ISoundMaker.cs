using System;
using Hydrogen;

namespace Sphere10.AutoMouse.Windows {

	public interface ISoundMaker : IDisposable {
		void PlayClickSound(MouseButton button, MouseButtonState buttonState);
	}
}
