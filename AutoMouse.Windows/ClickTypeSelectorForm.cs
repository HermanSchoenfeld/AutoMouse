using System;
using System.ComponentModel;
using System.Windows.Forms;
using Sphere10.Framework;

namespace AutoMouse.Windows {
	public partial class ClickTypeSelectorForm : Form {
		private readonly TimeSpan FormTimerPollPeriod = TimeSpan.FromMilliseconds(5);
		private const double FormOpacityFadeRatePerSecond = 2;
		private const double FormStartOpacity = 0.5;
		private readonly TimeSpan TimeoutPeriod = TimeSpan.FromSeconds(2);


	

		public ClickTypeSelectorForm(IKeyboardHook hook) {
			InitializeComponent();
			Opacity = 0;
			LastActivityTime = DateTime.Now;
			LastFormPoll = DateTime.Now;
			_timer.Interval = (int)FormTimerPollPeriod.TotalMilliseconds;
			_timer.Start();
			TopMost = true;
			State = SelectorState.Selecting;
			KeyHook = hook;
			KeyHandler = KeyHook_KeyDown;
			KeyHook.KeyDown += KeyHandler;
		}

		protected override void OnClosing(CancelEventArgs e) {
			base.OnClosing(e);
			KeyHook.KeyDown -= KeyHandler;
		}

		void KeyHook_KeyDown(object sender, KeyEvent e) {
			if (e.Key == Key.D1) {
			    SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
			}
		}

		private EventHandler<KeyEvent> KeyHandler { get; set; }
		private IKeyboardHook KeyHook { get; set; }
		private DateTime LastFormPoll { get; set; }
		private DateTime LastActivityTime { get; set; }

		private SelectorState State { get; set; }

		public MouseButton SelectedButton { get; set; }

		public MouseClickType SelectedClickType { get; set; }
	

		private void SelectMouseEvent(MouseButton mouseButton, MouseClickType clickType) {
			SelectedButton = mouseButton;
			SelectedClickType = clickType;
			this.InvokeEx(() => {
				Opacity = 0;
				DialogResult = DialogResult.OK;
			});
		}

		private void ShowNonClickWarning() {
			MessageBox.Show("You don't need to click. Just rest the mouse over the button you want");
		}



		// Makes the window 'transparent' to events
		protected override CreateParams CreateParams {
			get {
				CreateParams cp=base.CreateParams;
				cp.ExStyle |= 0x00000020; //WS_EX_TRANSPARENT
				return cp;
			}
		}

		protected override bool ShowWithoutActivation {
			get {
				return true;
			}
		}
		
		private void _timer_Tick(object sender, EventArgs e) {
			DateTime now = DateTime.Now;
			if (State == SelectorState.Selecting && now.Subtract(LastActivityTime) > TimeoutPeriod) {
				State = SelectorState.Timeout;
			}

			if (State  == SelectorState.Timeout) {
				Opacity = Opacity - FormOpacityFadeRatePerSecond * (now.Subtract(LastFormPoll).TotalSeconds);
			} else if (State == SelectorState.Selecting && Opacity < FormStartOpacity) {
				Opacity = Opacity + FormOpacityFadeRatePerSecond * (now.Subtract(LastFormPoll).TotalSeconds);
			}
			if (Opacity <= 0 && State == SelectorState.Timeout) {
				Close();
			}
			LastFormPoll = now;
		}

		private void _leftDownButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _leftDownButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void RegisterFormActivity() {
			LastActivityTime = DateTime.Now;
			Opacity = 1;
		}

		private void _leftDownButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}


		private void _leftClickButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _leftClickButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _leftClickButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _leftDoubleClickButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _leftDoubleClickButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _leftDoubleClickButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _scrollPressButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _scrollPressButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _scrollPressButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _rightDownButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _rightDownButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _rightDownButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _rightClickButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _rightClickButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _rightClickButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _rightDoubleClickButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _rightDoubleClickButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _rightDoubleClickButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private void _scrollClickButton_Click(object sender, EventArgs e) {
			ShowNonClickWarning();
		}

		private void _scrollClickButton_MouseMove(object sender, EventArgs e) {
			RegisterFormActivity();
		}

		private void _scrollClickButton_MouseHover(object sender, EventArgs e) {
			SelectMouseEvent(MouseButton.Left, MouseClickType.Single);
		}

		private enum SelectorState {
			Selecting,
			Timeout
		}
	}
}
