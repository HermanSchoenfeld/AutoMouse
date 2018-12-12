using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using Sphere10.AutoMouse.Properties;
using Sphere10.Common;

namespace Sphere10.AutoMouse {
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

		public void PlayClickSound(MouseButton button, MouseButtonState buttonState) {
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
				Tool.ActionAsAsyncronous(
					() => {
						bool skip = false;
						if (_clicksQueued < MaxTimeSingleSoundQueued) {
							_clicksQueued++;
						}
						else {
							skip = true;
						}

						if (!skip) {
							player.PlaySync();
							_clicksQueued--;
						}
						else {
							int x = 1;
						}

					}).Invoke();
			}
		}
	}
}