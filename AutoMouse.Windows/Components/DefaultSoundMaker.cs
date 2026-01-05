// Copyright (c) Herman Schoenfeld 2018 - Present. All rights reserved. (https://sphere10.com/products/automouse)
// Author: Herman Schoenfeld <herman@sphere10.com>
//
// Distributed under the GPLv3 software license, see the accompanying file LICENSE 
// or visit https://github.com/HermanSchoenfeld/AutoMouse/blob/master/LICENSE
//
// This notice must not be removed when duplicating this file or its contents, in whole or in part.

using System.Diagnostics;
using System.Media;
using Sphere10.Framework;
using AutoMouse.Windows.Properties;

namespace AutoMouse.Windows {
	public class DefaultSoundMaker : ISoundMaker {

		private const int MaxTimeSingleSoundQueued = 3;
		private static readonly object SyncObject;
		private volatile int _clicksQueued;
		private readonly SoundPlayer _leftClickDownSoundPlayer;
		private readonly SoundPlayer _leftClickUpSoundPlayer;
		private readonly SoundPlayer _rightClickDownSoundPlayer;
		private readonly SoundPlayer _rightClickUpSoundPlayer;

		static DefaultSoundMaker() {
			SyncObject = new object();
		}

		public DefaultSoundMaker() {
			_clicksQueued = 0;
			_leftClickDownSoundPlayer = new SoundPlayer(Resources.LeftClickDown);
			_leftClickUpSoundPlayer = new SoundPlayer(Resources.LeftClickUp);
			_rightClickDownSoundPlayer = new SoundPlayer(Resources.RightClickDown);
			_rightClickUpSoundPlayer = new SoundPlayer(Resources.RightClickUp);
		}

		public async void PlayClickSound(MouseButton button, MouseButtonState buttonState) {
			SoundPlayer player = null;
			string soundName = string.Empty;
			switch (button) {
				case MouseButton.Left:
					switch (buttonState) {
						case MouseButtonState.Down:
							player = _leftClickDownSoundPlayer;
							break;
						case MouseButtonState.Up:
							player = _leftClickUpSoundPlayer;
							break;
					}
					break;
				default:
					switch (buttonState) {
						case MouseButtonState.Down:
							player = _rightClickDownSoundPlayer;
							break;
						case MouseButtonState.Up:
							player = _rightClickUpSoundPlayer;
							break;
					}
					break;
			}
			

			if (player != null) {
				Tools.Lambda.ActionAsAsyncronous(
					() => {
						bool skip = false;
						if (_clicksQueued < MaxTimeSingleSoundQueued) {
							_clicksQueued++;
						} else {
							skip = true;
						}

						if (!skip) {
							player.Play();
							_clicksQueued--;
						} 

					}).Invoke();
			}
		}
		public void Dispose() {
			_leftClickDownSoundPlayer?.Dispose();
			_leftClickUpSoundPlayer?.Dispose();
			_rightClickDownSoundPlayer?.Dispose();
			_rightClickUpSoundPlayer?.Dispose();
		}
	}
}