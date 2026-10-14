using System;
using System.Collections;
using System.IO;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.Dev
{
	// Token: 0x0200029B RID: 667
	public class POIFSLister
	{
		// Token: 0x0600124F RID: 4687 RVA: 0x00036E10 File Offset: 0x00035010
		public static void ViewFile(string filename)
		{
			using (global::System.IO.Stream stream = new global::System.IO.FileStream(filename, global::System.IO.FileMode.Open))
			{
				global::NPOI.POIFS.Dev.POIFSLister.DisplayDirectory(new global::NPOI.POIFS.FileSystem.POIFSFileSystem(stream).Root, "");
			}
		}

		// Token: 0x06001250 RID: 4688 RVA: 0x00036E58 File Offset: 0x00035058
		public static void DisplayDirectory(global::NPOI.POIFS.FileSystem.DirectoryNode dir, string indent)
		{
			global::System.Console.WriteLine(indent + dir.Name + " -");
			string text = indent + "  ";
			global::System.Collections.IEnumerator entries = dir.Entries;
			while (entries.MoveNext())
			{
				object obj = entries.Current;
				if (obj is global::NPOI.POIFS.FileSystem.DirectoryNode)
				{
					global::NPOI.POIFS.Dev.POIFSLister.DisplayDirectory((global::NPOI.POIFS.FileSystem.DirectoryNode)obj, text);
				}
				else
				{
					string text2 = ((global::NPOI.POIFS.FileSystem.DocumentNode)obj).Name;
					if (text2[0] < '\n')
					{
						string str = "(0x0" + ((int)text2[0]).ToString() + ")" + text2.Substring(1);
						text2 = text2.Substring(1) + " <" + str + ">";
					}
					global::System.Console.WriteLine(text + text2);
				}
			}
		}
	}
}
