using System.Diagnostics;
using System.Media;
using Sphere10.Framework;
using Sphere10.AutoMouse.Windows.Properties;

namespace Sphere10.AutoMouse.Windows {
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