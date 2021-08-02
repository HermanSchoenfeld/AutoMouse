using System.ComponentModel;

namespace Sphere10.AutoMouse.Windows {
	partial class NagScreen {
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
			((System.ComponentModel.ISupportInitialize)(this._shoppingCartPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// applicationBanner1
			// 
			this.applicationBanner1.Version = "Version {ProductVersion} (PATENT PENDING)";
			// 
			// NagScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.ClientSize = new System.Drawing.Size(502, 234);
			this.Name = "NagScreen";
			((System.ComponentModel.ISupportInitialize)(this._shoppingCartPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
	}
}
