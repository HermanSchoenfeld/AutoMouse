// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System.Drawing;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;

namespace AutoMouse.Windows {
	public class WindowsAutoMouseController : BaseAutoMouseController {


		public WindowsAutoMouseController(IMouseHook mouseHook, IKeyboardHook keyboardHook, IScreenMouse screenMouse,  IExpandingCircleRenderer expandingCircleRenderer, ISoundMaker soundMaker, IUserInterfaceServices userInterfaceServices)
			: base(mouseHook, keyboardHook, screenMouse,  expandingCircleRenderer, soundMaker, userInterfaceServices) {
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
