using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using Sphere10.Framework;
using Sphere10.Framework.Windows.Forms;
using Sphere10.Framework.Windows.Forms.WinForms;

namespace Sphere10.AutoMouse.Windows {

	/// <summary>
	/// Summary description for AutoClickRadiusSelector.
	/// </summary>
	public class ClickRadiusSelector : UserControl {
		private Panel panel;
		private TransparentPanel transparentPanel;
		private int _mouseOverRadius = 50;
		private PictureBox cursorImage;
		private bool _mouseOver;

		public event EventHandler RadiusChanged;
		

		public ClickRadiusSelector() {
			// This call is required by the Windows.Forms Form Designer.
			InitializeComponent();

			// set double buffering on
			SetStyle(ControlStyles.DoubleBuffer, true);
			SetStyle(ControlStyles.UserPaint, true);
			SetStyle(ControlStyles.AllPaintingInWmPaint, true);
			
			// redraw on resize
			SetStyle(ControlStyles.ResizeRedraw, true);
		}

		/// <summary> 
		/// Clean up any resources being used.
		/// </summary>
		protected override void Dispose( bool disposing ) {
			base.Dispose( disposing );
		}

		#region Component Designer generated code
		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			System.Resources.ResourceManager resources = new System.Resources.ResourceManager(typeof(ClickRadiusSelector));
			this.panel = new System.Windows.Forms.Panel();
			this.transparentPanel = new TransparentPanel();
			this.cursorImage = new System.Windows.Forms.PictureBox();
			this.panel.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel
			// 
			this.panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel.Controls.Add(this.transparentPanel);
			this.panel.Controls.Add(this.cursorImage);
			this.panel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel.Location = new System.Drawing.Point(0, 0);
			this.panel.Name = "panel";
			this.panel.Size = new System.Drawing.Size(200, 200);
			this.panel.TabIndex = 3;
			// 
			// transparentPanel
			// 
			this.transparentPanel.BackColor = System.Drawing.Color.Transparent;
			this.transparentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.transparentPanel.Location = new System.Drawing.Point(0, 0);
			this.transparentPanel.Name = "transparentPanel";
			this.transparentPanel.Size = new System.Drawing.Size(198, 198);
			this.transparentPanel.TabIndex = 1;
			this.transparentPanel.Resize += new System.EventHandler(this.transparentPanel_Resize);
			this.transparentPanel.OnBackgroundPaint += new System.Windows.Forms.PaintEventHandler(this.transparentPanel_OnBackgroundPaint);
			this.transparentPanel.MouseEnter += new System.EventHandler(this.transparentPanel_MouseEnter);
			this.transparentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.transparentPanel_MouseMove);
			this.transparentPanel.MouseLeave += new System.EventHandler(this.transparentPanel_MouseLeave);
			this.transparentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.transparentPanel_MouseDown);
			// 
			// cursorImage
			// 
			this.cursorImage.Image = ((System.Drawing.Image)(resources.GetObject("cursorImage.Image")));
			this.cursorImage.Location = new System.Drawing.Point(100, 100);
			this.cursorImage.Name = "cursorImage";
			this.cursorImage.Size = new System.Drawing.Size(14, 20);
			this.cursorImage.TabIndex = 0;
			this.cursorImage.TabStop = false;
			// 
			// ClickRadiusSelector
			// 
			this.BackColor = System.Drawing.SystemColors.Window;
			this.Controls.Add(this.panel);
			this.Name = "ClickRadiusSelector";
			this.Size = new System.Drawing.Size(200, 200);
			this.panel.ResumeLayout(false);
			this.ResumeLayout(false);

		}
		#endregion


		private int _selectedRadius = 100;
	
		[Browsable(true)]
		public int SelectedRadius {
			get {
				return _selectedRadius;
			}
			set {
				_selectedRadius = value;
				if (!DesignMode) {
					Invalidate(true);
				}
			}
		}

	
		private int MouseOverRadius {
			get {
				return _mouseOverRadius;
			}
			set {
				_mouseOverRadius = value;
			}
		}

		private void transparentPanel_MouseDown(object sender, MouseEventArgs e) {
			SelectedRadius = MouseOverRadius;
			if (RadiusChanged != null) {
				RadiusChanged(this, new EventArgs());
			}
		}

		private void transparentPanel_Resize(object sender, EventArgs e) {
			int mid_x = Size.Width / 2;
			int mid_y = Size.Height / 2;
			cursorImage.Left = mid_x;
			cursorImage.Top = mid_y;
		}

		private void transparentPanel_MouseLeave(object sender, EventArgs e) {
			_mouseOver = false;
			Invalidate(true);
		}

		private void transparentPanel_MouseEnter(object sender, EventArgs e) {
			_mouseOver = true;
			Invalidate(true);
		}

		private void transparentPanel_MouseMove(object sender, MouseEventArgs e) {
			int mid_x = Size.Width / 2;
			int mid_y = Size.Height / 2;
			MouseOverRadius = (int) Math.Sqrt(
				Math.Pow(e.X - mid_x, 2) +
				Math.Pow(e.Y - mid_y, 2));
			Invalidate(true);
		}

		private void transparentPanel_OnBackgroundPaint(object sender, PaintEventArgs e) {
			Pen selectedPen = new Pen(Color.LightGreen, 3);
			Pen mouseOverPen = new Pen(Color.Black, 1);
			try  {
				int mid_x = Size.Width / 2;
				int mid_y = Size.Height / 2;

				e.Graphics.DrawEllipse(
					selectedPen,
					mid_x - SelectedRadius,
					mid_y - SelectedRadius,
					SelectedRadius*2,
					SelectedRadius*2);

				if (_mouseOver) {
					e.Graphics.DrawEllipse(
						mouseOverPen,
						mid_x - MouseOverRadius,
						mid_y - MouseOverRadius,
						MouseOverRadius*2,
						MouseOverRadius*2);
				}
			} finally {
				selectedPen.Dispose();
				mouseOverPen.Dispose();
			}

		}



		public class StateChangeManager : IControlStateChangeManager {

			public void AddStateChangedHandler(Control control, EventHandler eventHandler) {
				if (!(control is ClickRadiusSelector)) {
					throw new SoftwareException("{0} does not deal with type {1}", GetType().Name, control.GetType().Name);
				}
				((ClickRadiusSelector) control).RadiusChanged += eventHandler;
			}


			public void RemoveStateChangedHandler(Control control, EventHandler eventHandler) {
				if (!(control is ClickRadiusSelector)) {
					throw new SoftwareException("{0} does not deal with type {1}", GetType().Name, control.GetType().Name);
				}
				((ClickRadiusSelector) control).RadiusChanged -= eventHandler;

			}

		}
	}
}
