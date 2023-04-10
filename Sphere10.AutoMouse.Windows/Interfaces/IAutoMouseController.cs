
using System;
using Hydrogen;

namespace Sphere10.AutoMouse.Windows {

	public interface IAutoMouseController : IDisposable {

		AutoMouseSettings Settings { get; }

		int CursorCurrentPositionX { get; }

		int CursorCurrentPositionY { get; }

		void Start();

		void Stop();

		bool Started { get; }

		void SimulateMouse(MouseButton button, MouseClickType clickType, int centerX, int centerY);

		void ProcessKeyDown_AutoActivateScreenMouse(KeyEvent e);

		void ProcessKeyUp_AutoActivateScreenMouse(KeyEvent e);

		void ProcessMotion_AutoActivateScreenMouse(MouseMoveEvent e);

		void ProcessMotionStop_AutoActivateScreenMouse(MouseMoveEvent e);

		void MouseFormStateChanged_AutoActivateScreenMouse(ScreenMouseStateChangedEvent e);



		void ProcessKeyDown_AutoClickOnMouseStop(KeyEvent e);

		void ProcessKeyUp_AutoClickOnMouseStop(KeyEvent key);

		void ProcessMotion_AutoClickOnMouseStop(MouseMoveEvent e);

		void ProcessMotionStop_AutoClickOnMouseStop(MouseMoveEvent e);

		void MouseFormStateChanged_AutoClickOnMouseStop(ScreenMouseStateChangedEvent e);



		void ProcessKeyDown_ManuallyActivateScreenMouse(KeyEvent e);

		void ProcessKeyUp_ManuallyActivateScreenMouse(KeyEvent e);

		void ProcessMotion_ManuallyActivateScreenMouse(MouseMoveEvent e);

		void ProcessMotionStop_ManuallyActivateScreenMouse(MouseMoveEvent e);

		void MouseFormStateChanged_ManuallyActivateScreenMouse(ScreenMouseStateChangedEvent e);


	}
}
