namespace YggScripting_partial_standalone
{
	partial class Form2
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.TrustONo = new System.Windows.Forms.CheckedListBox();
			this.SuspendLayout();
			// 
			// TrustONo
			// 
			this.TrustONo.FormattingEnabled = true;
			this.TrustONo.Location = new System.Drawing.Point(13, 13);
			this.TrustONo.Name = "TrustONo";
			this.TrustONo.Size = new System.Drawing.Size(775, 424);
			this.TrustONo.TabIndex = 0;
			this.TrustONo.SelectedIndexChanged += new System.EventHandler(this.TrustONo_SelectedIndexChanged);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.TrustONo);
			this.Name = "Form2";
			this.Text = "Form2";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.CheckedListBox TrustONo;
	}
}