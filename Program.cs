using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YggScripting_partial_standalone
{
	static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		public static long processedCOBJ;
		public static long TotalCOBJ;
		[STAThread]
		static void Main()
		{
			processedCOBJ = 0;
			TotalCOBJ = 0;
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}
