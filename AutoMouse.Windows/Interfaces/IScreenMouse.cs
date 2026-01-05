// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System;
using Sphere10.Framework;

namespace AutoMouse.Windows;

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
