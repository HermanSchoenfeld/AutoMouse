using System.ComponentModel;
using System.Windows.Forms;

namespace AutoMouse.Windows {
	partial class ClickTypeSelectorForm {
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing) {
			if (disposing && (components != null)) {
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent() {
			this.components = new System.ComponentModel.Container();
			this._leftDownButton = new System.Windows.Forms.Button();
			this._leftClickButton = new System.Windows.Forms.Button();
			this._rightDownButton = new System.Windows.Forms.Button();
			this._rightClickButton = new System.Windows.Forms.Button();
			this._scrollPressButton = new System.Windows.Forms.Button();
			this._scrollClickButton = new System.Windows.Forms.Button();
			this._rightDoubleClickButton = new System.Windows.Forms.Button();
			this._leftDoubleClickButton = new System.Windows.Forms.Button();
			this._timer = new System.Windows.Forms.Timer(this.components);
			this.SuspendLayout();
			// 
			// _leftDownButton
			// 
			this._leftDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._leftDownButton.Location = new System.Drawing.Point(0, 0);
			this._leftDownButton.Name = "_leftDownButton";
			this._leftDownButton.Size = new System.Drawing.Size(50, 50);
			this._leftDownButton.TabIndex = 0;
			this._leftDownButton.Text = "Left Down";
			this._leftDownButton.UseVisualStyleBackColor = true;
			this._leftDownButton.Click += new System.EventHandler(this._leftDownButton_Click);
			this._leftDownButton.MouseHover += new System.EventHandler(this._leftDownButton_MouseHover);
			this._leftDownButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._leftDownButton_MouseMove);
			// 
			// _leftClickButton
			// 
			this._leftClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._leftClickButton.Location = new System.Drawing.Point(0, 49);
			this._leftClickButton.Name = "_leftClickButton";
			this._leftClickButton.Size = new System.Drawing.Size(50, 50);
			this._leftClickButton.TabIndex = 1;
			this._leftClickButton.Text = "Left Click";
			this._leftClickButton.UseVisualStyleBackColor = true;
			this._leftClickButton.Click += new System.EventHandler(this._leftClickButton_Click);
			this._leftClickButton.MouseHover += new System.EventHandler(this._leftClickButton_MouseHover);
			this._leftClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._leftClickButton_MouseMove);
			// 
			// _rightDownButton
			// 
			this._rightDownButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._rightDownButton.Location = new System.Drawing.Point(100, 0);
			this._rightDownButton.Name = "_rightDownButton";
			this._rightDownButton.Size = new System.Drawing.Size(50, 50);
			this._rightDownButton.TabIndex = 2;
			this._rightDownButton.Text = "Right Down";
			this._rightDownButton.UseVisualStyleBackColor = true;
			this._rightDownButton.Click += new System.EventHandler(this._rightDownButton_Click);
			this._rightDownButton.MouseHover += new System.EventHandler(this._rightDownButton_MouseHover);
			this._rightDownButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._rightDownButton_MouseMove);
			// 
			// _rightClickButton
			// 
			this._rightClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._rightClickButton.Location = new System.Drawing.Point(100, 49);
			this._rightClickButton.Name = "_rightClickButton";
			this._rightClickButton.Size = new System.Drawing.Size(50, 50);
			this._rightClickButton.TabIndex = 3;
			this._rightClickButton.Text = "Right Click";
			this._rightClickButton.UseVisualStyleBackColor = true;
			this._rightClickButton.Click += new System.EventHandler(this._rightClickButton_Click);
			this._rightClickButton.MouseHover += new System.EventHandler(this._rightClickButton_MouseHover);
			this._rightClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._rightClickButton_MouseMove);
			// 
			// _scrollPressButton
			// 
			this._scrollPressButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._scrollPressButton.Location = new System.Drawing.Point(50, 0);
			this._scrollPressButton.Name = "_scrollPressButton";
			this._scrollPressButton.Size = new System.Drawing.Size(50, 50);
			this._scrollPressButton.TabIndex = 4;
			this._scrollPressButton.Text = "Scroll Press";
			this._scrollPressButton.UseVisualStyleBackColor = true;
			this._scrollPressButton.Click += new System.EventHandler(this._scrollPressButton_Click);
			this._scrollPressButton.MouseHover += new System.EventHandler(this._scrollPressButton_MouseHover);
			this._scrollPressButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._scrollPressButton_MouseMove);
			// 
			// _scrollClickButton
			// 
			this._scrollClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._scrollClickButton.Location = new System.Drawing.Point(50, 98);
			this._scrollClickButton.Name = "_scrollClickButton";
			this._scrollClickButton.Size = new System.Drawing.Size(50, 50);
			this._scrollClickButton.TabIndex = 5;
			this._scrollClickButton.Text = "Scroll Click";
			this._scrollClickButton.UseVisualStyleBackColor = true;
			this._scrollClickButton.Click += new System.EventHandler(this._scrollClickButton_Click);
			this._scrollClickButton.MouseHover += new System.EventHandler(this._scrollClickButton_MouseHover);
			this._scrollClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._scrollClickButton_MouseMove);
			// 
			// _rightDoubleClickButton
			// 
			this._rightDoubleClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._rightDoubleClickButton.Location = new System.Drawing.Point(100, 98);
			this._rightDoubleClickButton.Name = "_rightDoubleClickButton";
			this._rightDoubleClickButton.Size = new System.Drawing.Size(50, 50);
			this._rightDoubleClickButton.TabIndex = 6;
			this._rightDoubleClickButton.Text = "Right Double Click";
			this._rightDoubleClickButton.UseVisualStyleBackColor = true;
			this._rightDoubleClickButton.Click += new System.EventHandler(this._rightDoubleClickButton_Click);
			this._rightDoubleClickButton.MouseHover += new System.EventHandler(this._rightDoubleClickButton_MouseHover);
			this._rightDoubleClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._rightDoubleClickButton_MouseMove);
			// 
			// _leftDoubleClickButton
			// 
			this._leftDoubleClickButton.Cursor = System.Windows.Forms.Cursors.Hand;
			this._leftDoubleClickButton.Location = new System.Drawing.Point(0, 98);
			this._leftDoubleClickButton.Name = "_leftDoubleClickButton";
			this._leftDoubleClickButton.Size = new System.Drawing.Size(50, 50);
			this._leftDoubleClickButton.TabIndex = 9;
			this._leftDoubleClickButton.Text = "Left Double Click";
			this._leftDoubleClickButton.UseVisualStyleBackColor = true;
			this._leftDoubleClickButton.Click += new System.EventHandler(this._leftDoubleClickButton_Click);
			this._leftDoubleClickButton.MouseHover += new System.EventHandler(this._leftDoubleClickButton_MouseHover);
			this._leftDoubleClickButton.MouseMove += new System.Windows.Forms.MouseEventHandler(this._leftDoubleClickButton_MouseMove);
			// 
			// _timer
			// 
			this._timer.Tick += new System.EventHandler(this._timer_Tick);
			// 
			// ClickTypeSelectorForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Fuchsia;
			this.ClientSize = new System.Drawing.Size(150, 148);
			this.Controls.Add(this._leftDoubleClickButton);
			this.Controls.Add(this._rightDoubleClickButton);
			this.Controls.Add(this._scrollClickButton);
			this.Controls.Add(this._scrollPressButton);
			this.Controls.Add(this._rightClickButton);
			this.Controls.Add(this._rightDownButton);
			this.Controls.Add(this._leftClickButton);
			this.Controls.Add(this._leftDownButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ClickTypeSelectorForm";
			this.Text = "Form1";
			this.TransparencyKey = System.Drawing.Color.Fuchsia;
			this.ResumeLayout(false);

		}

		#endregion

		private Button _leftDownButton;
		private Button _leftClickButton;
		private Button _rightDownButton;
		private Button _rightClickButton;
		private Button _scrollPressButton;
		private Button _scrollClickButton;
		private Button _rightDoubleClickButton;
		private Button _leftDoubleClickButton;
		private Timer _timer;
	}
}

