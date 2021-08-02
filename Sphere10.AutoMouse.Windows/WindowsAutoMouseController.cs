using System.Drawing;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;

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
