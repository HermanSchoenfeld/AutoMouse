using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sphere10.AutoMouse {

	public class ScreenMouseStateChangedEvent : EventArgs {
		public ScreenMouseState PreviousState { get; set; }
		public ScreenMouseState CurrentState { get; set; }
	}
}
