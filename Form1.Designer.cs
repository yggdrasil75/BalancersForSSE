namespace YggScripting_partial_standalone
{
	partial class Form1
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
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.CobjCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.ArmoCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.WeapCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.AmmoCount = new System.Windows.Forms.ToolStripStatusLabel();
			this.LVLICount = new System.Windows.Forms.ToolStripStatusLabel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.listView1 = new System.Windows.Forms.ListView();
			this.ModeSelect = new System.Windows.Forms.ComboBox();
			this.PartProcess = new System.Windows.Forms.ComboBox();
			this.EnabledPart = new System.Windows.Forms.CheckBox();
			this.GenerateFromJsonButton = new System.Windows.Forms.Button();
			this.SaveMain = new System.Windows.Forms.Button();
			this.LoadMain = new System.Windows.Forms.Button();
			this.TrustIssues = new System.Windows.Forms.Button();
			this.FinalizeButton = new System.Windows.Forms.Button();
			this.statusStrip1.SuspendLayout();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(1101, 25);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CobjCount,
            this.ArmoCount,
            this.WeapCount,
            this.AmmoCount,
            this.LVLICount});
			this.statusStrip1.Location = new System.Drawing.Point(0, 703);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1101, 22);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// CobjCount
			// 
			this.CobjCount.Name = "CobjCount";
			this.CobjCount.Size = new System.Drawing.Size(0, 17);
			// 
			// ArmoCount
			// 
			this.ArmoCount.Name = "ArmoCount";
			this.ArmoCount.Size = new System.Drawing.Size(52, 17);
			this.ArmoCount.Text = "Armors: ";
			// 
			// WeapCount
			// 
			this.WeapCount.Name = "WeapCount";
			this.WeapCount.Size = new System.Drawing.Size(62, 17);
			this.WeapCount.Text = "Weapons: ";
			// 
			// AmmoCount
			// 
			this.AmmoCount.Name = "AmmoCount";
			this.AmmoCount.Size = new System.Drawing.Size(81, 17);
			this.AmmoCount.Text = "Ammunition: ";
			// 
			// LVLICount
			// 
			this.LVLICount.Name = "LVLICount";
			this.LVLICount.Size = new System.Drawing.Size(79, 17);
			this.LVLICount.Text = "Leveled Lists: ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.listView1);
			this.panel1.Location = new System.Drawing.Point(12, 75);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1077, 625);
			this.panel1.TabIndex = 2;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.ControlDark;
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(0, 0);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(1077, 625);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// ModeSelect
			// 
			this.ModeSelect.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
			this.ModeSelect.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
			this.ModeSelect.BackColor = System.Drawing.SystemColors.ControlDark;
			this.ModeSelect.FormattingEnabled = true;
			this.ModeSelect.Items.AddRange(new object[] {
            "Fixed",
            "Dynamic",
            "Single",
            "Select",
            "Creation"});
			this.ModeSelect.Location = new System.Drawing.Point(12, 28);
			this.ModeSelect.Name = "ModeSelect";
			this.ModeSelect.Size = new System.Drawing.Size(121, 21);
			this.ModeSelect.TabIndex = 3;
			this.ModeSelect.Text = "Mode";
			this.ModeSelect.SelectedIndexChanged += new System.EventHandler(this.ModeSelect_SelectedIndexChanged);
			// 
			// PartProcess
			// 
			this.PartProcess.BackColor = System.Drawing.SystemColors.ControlDark;
			this.PartProcess.FormattingEnabled = true;
			this.PartProcess.Items.AddRange(new object[] {
            "Armor",
            "Weapons",
            "Crafting Recipes",
            "Arrows & Bolts",
            "Leveled Lists",
            "Keywords"});
			this.PartProcess.Location = new System.Drawing.Point(139, 28);
			this.PartProcess.Name = "PartProcess";
			this.PartProcess.Size = new System.Drawing.Size(121, 21);
			this.PartProcess.TabIndex = 4;
			// 
			// EnabledPart
			// 
			this.EnabledPart.AutoSize = true;
			this.EnabledPart.Location = new System.Drawing.Point(266, 30);
			this.EnabledPart.Name = "EnabledPart";
			this.EnabledPart.Size = new System.Drawing.Size(59, 17);
			this.EnabledPart.TabIndex = 5;
			this.EnabledPart.Text = "Enable";
			this.EnabledPart.UseVisualStyleBackColor = true;
			this.EnabledPart.CheckedChanged += new System.EventHandler(this.EnabledPart_CheckedChanged);
			// 
			// GenerateFromJsonButton
			// 
			this.GenerateFromJsonButton.AutoSize = true;
			this.GenerateFromJsonButton.Location = new System.Drawing.Point(675, 28);
			this.GenerateFromJsonButton.Name = "GenerateFromJsonButton";
			this.GenerateFromJsonButton.Size = new System.Drawing.Size(143, 23);
			this.GenerateFromJsonButton.TabIndex = 6;
			this.GenerateFromJsonButton.Text = "Generate From Load Order";
			this.GenerateFromJsonButton.UseVisualStyleBackColor = true;
			this.GenerateFromJsonButton.Click += new System.EventHandler(this.GenerateFromJsonButton_Click);
			// 
			// SaveMain
			// 
			this.SaveMain.AutoSize = true;
			this.SaveMain.Location = new System.Drawing.Point(824, 28);
			this.SaveMain.Name = "SaveMain";
			this.SaveMain.Size = new System.Drawing.Size(81, 23);
			this.SaveMain.TabIndex = 7;
			this.SaveMain.Text = "Save settings";
			this.SaveMain.UseVisualStyleBackColor = true;
			this.SaveMain.Click += new System.EventHandler(this.SaveMain_Click);
			// 
			// LoadMain
			// 
			this.LoadMain.AutoSize = true;
			this.LoadMain.Location = new System.Drawing.Point(911, 28);
			this.LoadMain.Name = "LoadMain";
			this.LoadMain.Size = new System.Drawing.Size(82, 23);
			this.LoadMain.TabIndex = 8;
			this.LoadMain.Text = "Load Settings";
			this.LoadMain.UseVisualStyleBackColor = true;
			this.LoadMain.Click += new System.EventHandler(this.LoadMain_Click);
			// 
			// TrustIssues
			// 
			this.TrustIssues.AutoSize = true;
			this.TrustIssues.Location = new System.Drawing.Point(999, 28);
			this.TrustIssues.Name = "TrustIssues";
			this.TrustIssues.Size = new System.Drawing.Size(90, 23);
			this.TrustIssues.TabIndex = 9;
			this.TrustIssues.Text = "Trusted Plugins";
			this.TrustIssues.UseVisualStyleBackColor = true;
			this.TrustIssues.Click += new System.EventHandler(this.TrustIssues_Click);
			// 
			// FinalizeButton
			// 
			this.FinalizeButton.AutoSize = true;
			this.FinalizeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FinalizeButton.Location = new System.Drawing.Point(444, 30);
			this.FinalizeButton.Name = "FinalizeButton";
			this.FinalizeButton.Size = new System.Drawing.Size(75, 30);
			this.FinalizeButton.TabIndex = 10;
			this.FinalizeButton.Text = "Finalize";
			this.FinalizeButton.UseVisualStyleBackColor = true;
			this.FinalizeButton.Click += new System.EventHandler(this.FinalizeButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.AutoSize = true;
			this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.ClientSize = new System.Drawing.Size(1101, 725);
			this.Controls.Add(this.FinalizeButton);
			this.Controls.Add(this.TrustIssues);
			this.Controls.Add(this.LoadMain);
			this.Controls.Add(this.SaveMain);
			this.Controls.Add(this.GenerateFromJsonButton);
			this.Controls.Add(this.EnabledPart);
			this.Controls.Add(this.PartProcess);
			this.Controls.Add(this.ModeSelect);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.toolStrip1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.panel1.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel CobjCount;
		private System.Windows.Forms.ToolStripStatusLabel ArmoCount;
		private System.Windows.Forms.ToolStripStatusLabel WeapCount;
		private System.Windows.Forms.ToolStripStatusLabel AmmoCount;
		private System.Windows.Forms.ToolStripStatusLabel LVLICount;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.ComboBox ModeSelect;
		private System.Windows.Forms.ComboBox PartProcess;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.CheckBox EnabledPart;
		private System.Windows.Forms.Button GenerateFromJsonButton;
		private System.Windows.Forms.Button SaveMain;
		private System.Windows.Forms.Button LoadMain;
		private System.Windows.Forms.Button TrustIssues;
		private System.Windows.Forms.Button FinalizeButton;
	}

}

