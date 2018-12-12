using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using Sphere10.Application;
using Sphere10.Application.WinForms;
using Sphere10.AutoMouse.Properties;
using Sphere10.Common;
using Sphere10.Windows;
using System.Threading;

namespace Sphere10.AutoMouse.Windows {
	public class WindowsAutoMouseController : BaseAutoMouseController {


		public WindowsAutoMouseController(IMouseHook mouseHook, IKeyboardHook keyboardHook, IScreenMouse screenMouse,  IExpandingCircleRenderer expandingCircleRenderer, ISoundMaker soundMaker, IConfigurationServices configurationServices, IUserInterfaceServices userInterfaceServices)
			: base(mouseHook, keyboardHook, screenMouse,  expandingCircleRenderer, soundMaker, configurationServices, userInterfaceServices) {
		}

		public override int CursorCurrentPositionX {
			get { return Cursor.Position.X; }
			set { Cursor.Position = new Point(value, Cursor.Position.Y); }
		}

		public override int CursorCurrentPositionY {
			get { return Cursor.Position.Y; }
			set { Cursor.Position = new Point(Cursor.Position.X, value); }
		}
	}
}
