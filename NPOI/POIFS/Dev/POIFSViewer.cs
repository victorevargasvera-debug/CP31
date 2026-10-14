using System;
using System.IO;
using System.Text;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.Dev
{
	// Token: 0x0200029E RID: 670
	public class POIFSViewer
	{
		// Token: 0x0600125A RID: 4698 RVA: 0x000370CC File Offset: 0x000352CC
		public static void ViewFile(string filename, bool printName)
		{
			if (printName)
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(".");
				for (int i = 0; i < filename.Length; i++)
				{
					stringBuilder.Append("-");
				}
				stringBuilder.Append(".");
				global::System.Console.WriteLine(stringBuilder);
				global::System.Console.WriteLine("|" + filename + "|");
				global::System.Console.WriteLine(stringBuilder);
			}
			try
			{
				using (global::System.IO.Stream stream = global::System.IO.File.OpenRead(filename))
				{
					foreach (object value in global::NPOI.POIFS.Dev.POIFSViewEngine.InspectViewable(new global::NPOI.POIFS.FileSystem.NPOIFSFileSystem(stream), true, 0, "  "))
					{
						global::System.Console.Write(value);
					}
				}
			}
			catch (global::System.IO.IOException ex)
			{
				global::System.Console.WriteLine(ex.Message);
			}
		}
	}
}
