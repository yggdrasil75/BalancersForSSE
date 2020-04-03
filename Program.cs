using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
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
		public static string GetColor(string path)
		{
			Bitmap BM = new Bitmap(path);
			BitmapData srcData = BM.LockBits(new Rectangle(0, 0, BM.Width, BM.Height), ImageLockMode.ReadOnly, PixelFormat.Format32bppArgb);

			int stride = srcData.Stride;

			IntPtr Scan0 = srcData.Scan0;

			long[] totals = new long[] { 0, 0, 0 };

			int width = BM.Width;
			int height = BM.Height;

			unsafe
			{
				byte* p = (byte*)(void*)Scan0;

				for (int y = 0; y < height; y++)
				{
					for (int x = 0; x < width; x++)
					{
						for (int color = 0; color < 3; color++)
						{
							int idx = (y * stride) + x * 4 + color;

							totals[color] += p[idx];
						}
					}
				}
			}

			long avgB = totals[0] / (width * height);
			long avgG = totals[1] / (width * height);
			long avgR = totals[2] / (width * height);
			Color acolor = Color.FromArgb((int)avgR, (int)avgG, (int)avgB);
			Console.WriteLine(acolor.Name); // ffff0000

			var colorLookup = Enum.GetValues(typeof(KnownColor))
				   .Cast<KnownColor>()
				   .Select(Color.FromKnownColor)
				   .ToLookup(c => c.ToArgb());

			// There are some colours with multiple entries...
			foreach (var namedColor in colorLookup[acolor.ToArgb()])
			{
				return namedColor.Name;
			}
			return "black";
		}
	}
}
