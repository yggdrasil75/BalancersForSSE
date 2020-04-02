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
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
			ResizeRedraw = true;
			String sPath = Environment.GetEnvironmentVariable("LocalAppData");
			System.IO.StreamReader PluginsTxt = new System.IO.StreamReader(sPath + "\\Skyrim Special Edition\\plugins.txt");
			string line;
			while ((line = PluginsTxt.ReadLine()) != null)
			{
				//check if .esp/.esm/.esl
				if (line.EndsWith(".esp") || line.EndsWith(".esm") || line.EndsWith(".esl"))
				{
					if (line.StartsWith("*"))
					{
						line = line.Remove(0, 1);
					}
					this.TrustONo.Items.Add(line);
				}
			}
		}
		private void Form2_Resize(object sender, EventHandler e)
		{
			//this.TrustONo.Size = this.ClientSize - 25;
			this.TrustONo.Width = this.ClientSize.Width - 25;
			this.TrustONo.Height = this.ClientSize.Height - 25;
		}

		private void TrustONo_SelectedIndexChanged(object sender, EventArgs e)
		{
			foreach (string item in TrustONo.CheckedItems)
				this.TrustONo.Items.Add(item);
		}
	}
}
