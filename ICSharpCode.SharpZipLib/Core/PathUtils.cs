using System;
using System.IO;
using System.Linq;

namespace ICSharpCode.SharpZipLib.Core
{
	// Token: 0x0200006E RID: 110
	public static class PathUtils
	{
		// Token: 0x0600048A RID: 1162 RVA: 0x00013F1C File Offset: 0x0001211C
		public static string DropPathRoot(string path)
		{
			char[] invalidChars = global::System.IO.Path.GetInvalidPathChars();
			bool cleanRootSep = path.Length >= 3 && path[1] == ':' && path[2] == ':';
			int num = global::System.IO.Path.GetPathRoot(new string(path.Take(258).Select(delegate(char c, int i)
			{
				if (!invalidChars.Contains(c) && !(i == 2 & cleanRootSep))
				{
					return c;
				}
				return '_';
			}).ToArray<char>())).Length;
			while (path.Length > num && (path[num] == '/' || path[num] == '\\'))
			{
				num++;
			}
			return path.Substring(num);
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x00013FC0 File Offset: 0x000121C0
		public static string GetTempFileName(string original = null)
		{
			string tempPath = global::System.IO.Path.GetTempPath();
			string text;
			do
			{
				text = ((original == null) ? global::System.IO.Path.Combine(tempPath, global::System.IO.Path.GetRandomFileName()) : (original + "." + global::System.IO.Path.GetRandomFileName()));
			}
			while (global::System.IO.File.Exists(text));
			return text;
		}
	}
}
