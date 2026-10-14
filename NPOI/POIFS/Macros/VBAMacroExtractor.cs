using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace NPOI.POIFS.Macros
{
	// Token: 0x020002CF RID: 719
	public class VBAMacroExtractor
	{
		// Token: 0x060013C6 RID: 5062 RVA: 0x0003B28C File Offset: 0x0003948C
		public static void main(string[] args)
		{
			if (args.Length == 0)
			{
				global::System.Console.WriteLine("Use:");
				global::System.Console.WriteLine("   VBAMacroExtractor <office.doc> [output]");
				global::System.Console.WriteLine("");
				global::System.Console.WriteLine("If an output directory is given, macros are written there");
				global::System.Console.WriteLine("Otherwise they are output to the screen");
			}
			global::System.IO.FileInfo input = new global::System.IO.FileInfo(args[0]);
			global::System.IO.DirectoryInfo outputDir = null;
			if (args.Length > 1)
			{
				outputDir = new global::System.IO.DirectoryInfo(args[1]);
			}
			new global::NPOI.POIFS.Macros.VBAMacroExtractor().Extract(input, outputDir);
		}

		// Token: 0x060013C7 RID: 5063 RVA: 0x0003B2F8 File Offset: 0x000394F8
		public void Extract(global::System.IO.FileInfo input, global::System.IO.DirectoryInfo outputDir, string extension)
		{
			if (!input.Exists)
			{
				throw new global::System.IO.FileNotFoundException(input.ToString());
			}
			if (outputDir != null)
			{
				if (!outputDir.Exists)
				{
					outputDir.Create();
				}
				global::System.Console.WriteLine(outputDir);
			}
			else
			{
				global::System.Console.WriteLine("STDOUT");
			}
			global::NPOI.POIFS.Macros.VBAMacroReader vbamacroReader = new global::NPOI.POIFS.Macros.VBAMacroReader(input);
			global::System.Collections.Generic.Dictionary<string, string> dictionary = vbamacroReader.ReadMacros();
			vbamacroReader.Close();
			string value = "---------------------------------------";
			foreach (global::System.Collections.Generic.KeyValuePair<string, string> keyValuePair in dictionary)
			{
				string key = keyValuePair.Key;
				string value2 = keyValuePair.Value;
				if (outputDir == null)
				{
					global::System.Console.WriteLine(value);
					global::System.Console.WriteLine(key);
					global::System.Console.WriteLine("");
					global::System.Console.WriteLine(value2);
				}
				else
				{
					global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(global::System.IO.Path.Combine(outputDir.FullName, key + extension));
					global::System.IO.FileStream fileStream = fileInfo.Create();
					global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(fileStream, global::System.Text.Encoding.UTF8);
					streamWriter.Write(value2);
					streamWriter.Close();
					fileStream.Close();
					string str = "Extracted ";
					global::System.IO.FileInfo fileInfo2 = fileInfo;
					global::System.Console.WriteLine(str + ((fileInfo2 != null) ? fileInfo2.ToString() : null));
				}
			}
		}

		// Token: 0x060013C8 RID: 5064 RVA: 0x0003B428 File Offset: 0x00039628
		public void Extract(global::System.IO.FileInfo input, global::System.IO.DirectoryInfo outputDir)
		{
			this.Extract(input, outputDir, ".vba");
		}
	}
}
