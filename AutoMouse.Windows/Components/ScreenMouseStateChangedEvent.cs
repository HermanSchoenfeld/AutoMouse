using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AutoMouse.Windows {

	public class ScreenMouseStateChangedEvent : EventArgs {
		public ScreenMouseState PreviousState { get; set; }
		public ScreenMouseState CurrentState { get; set; }
	}
}