using System;
using System.IO;
using System.Threading;

namespace NPOI.Util
{
	// Token: 0x02000292 RID: 658
	public class TempFile
	{
		// Token: 0x06001212 RID: 4626 RVA: 0x00036238 File Offset: 0x00034438
		public static global::System.IO.FileInfo CreateTempFile(string prefix, string suffix)
		{
			if (global::NPOI.Util.TempFile.dir == null)
			{
				global::NPOI.Util.TempFile.dir = global::System.IO.Directory.CreateDirectory(global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), "poifiles")).FullName;
			}
			string text = global::System.IO.Path.Combine(global::NPOI.Util.TempFile.dir, prefix + global::System.Guid.NewGuid().ToString() + suffix);
			while (global::System.IO.File.Exists(text))
			{
				text = global::System.IO.Path.Combine(global::NPOI.Util.TempFile.dir, prefix + global::System.Guid.NewGuid().ToString() + suffix);
				global::System.Threading.Thread.Sleep(1);
			}
			new global::System.IO.FileStream(text, global::System.IO.FileMode.CreateNew, global::System.IO.FileAccess.ReadWrite).Close();
			return new global::System.IO.FileInfo(text);
		}

		// Token: 0x06001213 RID: 4627 RVA: 0x000362D8 File Offset: 0x000344D8
		public static string GetTempFilePath(string prefix, string suffix)
		{
			if (global::NPOI.Util.TempFile.dir == null)
			{
				global::NPOI.Util.TempFile.dir = global::System.IO.Directory.CreateDirectory(global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), "poifiles")).FullName;
			}
			global::System.Random random = new global::System.Random(global::System.DateTime.Now.Millisecond);
			global::System.Threading.Thread.Sleep(10);
			return global::System.IO.Path.Combine(global::NPOI.Util.TempFile.dir, prefix + random.Next().ToString() + suffix);
		}

		// Token: 0x0400077A RID: 1914
		private static string dir;
	}
}
