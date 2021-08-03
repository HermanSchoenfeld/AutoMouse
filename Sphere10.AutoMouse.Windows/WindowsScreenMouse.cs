using System;
using System.Drawing;
using System.Windows.Forms;
using Sphere10.Framework;
using Sphere10.Framework.Application;
using Sphere10.Framework.Windows.Forms;

namespace Sphere10.AutoMouse.Windows {

	public class WindowsScreenMouse : BaseScreenMouse {
		public const int DefaultHeight = 128;
		public const int DefaultWidth = 128;

		public WindowsScreenMouse(IConfigurationServices configurationServices, IUserInterfaceServices userInterfaceServices)
			: base(configurationServices) {
			UserInterfaceServices = userInterfaceServices;
			ScreenForm = new Form();
			ScreenForm.Width = DefaultWidth;
			ScreenForm.Height = DefaultHeight;
			base.UpdateMouseImage();
			State = ScreenMouseState.Inactive;
		}

		public IUserInterfaceServices UserInterfaceServices { get; private set; }

		public override int Width {
			get {
				return ScreenForm.Width;
			}
			set {
				ScreenForm.Width = value;
			}
		}

		public override int Height {
			get {
				return ScreenForm.Height;
			}
			set {
				ScreenForm.Height = value;
			}
		}

		protected Form ScreenForm { get; set; }


		public override void MoveTo(int screenX, int screenY) {
			base.MoveTo(screenX, screenY);
			ExecuteInUIFriendlyContext(
				() => {
					ScreenForm.Location = new Point(screenX - ScreenForm.Width/2, screenY + 8);
					if (State != ScreenMouseState.Inactive) {
						ScreenForm.ShowInactiveTopmost();
					}
				}
			);
		}

		protected override void OnStateChanged(ScreenMouseStateChangedEvent @event) {
			base.OnStateChanged(@event);
			switch(State) {
				case ScreenMouseState.Active:
					LastActivityTime = DateTime.Now;
					if (!ScreenForm.Visible) {
						ExecuteInUIFriendlyContext(ScreenForm.ShowInactiveTopmost);
					}
					break;
				case ScreenMouseState.Inactive:
					if (ScreenForm.Visible) {
						ExecuteInUIFriendlyContext(ScreenForm.Hide);
					}
					break;
			}
		}

		protected override void ExecuteInUIFriendlyContext(Action action) {
			if (!ScreenForm.Disposing && !UserInterfaceServices.ApplicationExiting) {
				ScreenForm.InvokeEx(action);
			}
		}

		protected override void SetBackgroundBitmap(Bitmap bitmap, byte opacity) {
			ScreenForm.SetBitmap(bitmap, opacity);
		}

		protected class Form : PerPixelAlphaForm {

				public Form() {
					AutoScaleDimensions = new SizeF(6F, 13F);
					AutoScaleMode = AutoScaleMode.Font;
					ClientSize = new Size(128, 128);
					FormBorderStyle = FormBorderStyle.None;
					ShowIcon = false;
					ShowInTaskbar = false;
					TopMost = true;
					Enabled = false;
					Visible = false;
				}

				protected override CreateParams CreateParams {
					get {
						CreateParams cp=base.CreateParams;
						cp.ExStyle |= 0x00000020;  //WS_EX_TRANSPARENT
						return cp;
					}
				}

				protected override bool ShowWithoutActivation {
					get {
						return true;
					}
				}

			}
	}
}
