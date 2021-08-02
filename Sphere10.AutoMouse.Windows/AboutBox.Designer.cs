using System.ComponentModel;

namespace Sphere10.AutoMouse.Windows {
	partial class AboutBox {
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
            this.SuspendLayout();
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(352, 245);
            // 
            // applicationBanner1
            // 
            this.applicationBanner1.Version = "Version {ProductVersion} (PATENT PENDING)";
            // 
            // _label3
            // 
            this._label3.Size = new System.Drawing.Size(253, 13);
            this._label3.Text = "Version {ProductLongVersion} (PATENT PENDING)";
            // 
            // _productExpirationDetailsControl
            // 
            this._productExpirationDetailsControl.Size = new System.Drawing.Size(452, 32);
            // 
            // _enterNewProductKey
            // 
            this._enterNewProductKey.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._enterNewProductKey.Location = new System.Drawing.Point(12, 245);
            // 
            // AboutBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(479, 280);
            this.Name = "AboutBox";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
	}
}
