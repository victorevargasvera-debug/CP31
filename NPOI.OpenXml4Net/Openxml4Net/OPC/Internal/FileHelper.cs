using System;
using System.IO;

namespace NPOI.OpenXml4Net.OPC.Internal
{
	// Token: 0x02000022 RID: 34
	public class FileHelper
	{
		// Token: 0x0600017E RID: 382 RVA: 0x00007D0E File Offset: 0x00005F0E
		public static string GetDirectory(string filepath)
		{
			return global::System.IO.Path.GetDirectoryName(filepath).Replace("\\", "/");
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007D25 File Offset: 0x00005F25
		public static void CopyFile(string inpath, string outpath)
		{
			global::System.IO.File.Copy(inpath, outpath, true);
		}

		// Token: 0x06000180 RID: 384 RVA: 0x00007D2F File Offset: 0x00005F2F
		public static void CopyFile(global::System.IO.FileInfo inpath, global::System.IO.FileInfo outpath)
		{
			global::System.IO.File.Copy(inpath.FullName, outpath.FullName, true);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00007D44 File Offset: 0x00005F44
		public static string GetFilename(string filepath)
		{
			int length = filepath.Length;
			int num = length;
			while (--num >= 0)
			{
				if (filepath[num] == '\\')
				{
					return filepath.Substring(num + 1, length);
				}
			}
			return "";
		}
	}
}
