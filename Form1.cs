using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YggScripting_partial_standalone
{
	public partial class Form1 : Form
	{
		int TotalCOBJ = 0;
		int ProcessedCOBJ = 0;
		int TotalArmo = 0;
		int ProcessedArmo = 0;
		int TotalWeap = 0;
		int ProcessedWeap = 0;
		int TotalLVLI = 0;
		int ProcessedLVLI = 0;
		int TotalAmmo = 0;
		int ProcessedAmmo = 0;
		public Form1()
		{
			InitializeComponent();
			this.CobjCount.Text = $"Crafting Recipes: {ProcessedCOBJ}/{TotalCOBJ}";
			this.ArmoCount.Text = $"Armors: {ProcessedArmo}/{TotalArmo}";
			this.WeapCount.Text = $"Weapons: {ProcessedWeap}/{TotalWeap}";
			this.LVLICount.Text = $"Leveled Lists: {ProcessedLVLI}/{TotalLVLI}";
			this.AmmoCount.Text = $"Ammunition: {ProcessedAmmo}/{TotalAmmo}";
		}

		private void ModeSelect_SelectedIndexChanged(object sender, EventArgs e)
		{
			PartProcess.Items.Clear();
			if (ModeSelect.SelectedItem.Equals("Creation"))
			{
				PartProcess.Items.Add("Armor");
				PartProcess.Items.Add("Weapon");
				PartProcess.Items.Add("Ammo");
				SaveMain.Text = "Save Creation";
				LoadMain.Text = "Load Creation";
			}
			else
			{
				PartProcess.Items.Add("Armor");
				PartProcess.Items.Add("Weapon");
				PartProcess.Items.Add("Ammo");
				PartProcess.Items.Add("Keywords");
				PartProcess.Items.Add("Leveled Lists");
				PartProcess.Items.Add("Crafting Recipes");

				SaveMain.Text = "Save Settings";
				LoadMain.Text = "Load Settings";
			}
		}

		private void FinalizeButton_Click(object sender, EventArgs e)
		{
			//run ssepas that generates plugin
		}

		private void GenerateFromJsonButton_Click(object sender, EventArgs e)
		{
			//run ssepas that generates json files
		}

		private void SaveMain_Click(object sender, EventArgs e)
		{
			//save to ini
		}

		private void EnabledPart_CheckedChanged(object sender, EventArgs e)
		{
			//should I keep this?
			//enabled (process this grup)
			//disabled (dont process this grup)
		}

		private void LoadMain_Click(object sender, EventArgs e)
		{
			//load from ini
		}

		private void TrustIssues_Click(object sender, EventArgs e)
		{
			new Form2().ShowDialog();
			
		}
	}
	public class MySR : ToolStripSystemRenderer
	{
		public MySR() { }

		protected override void OnRenderToolStripBorder(ToolStripRenderEventArgs e)
		{
			//base.OnRenderToolStripBorder(e);
		}
	}
}

