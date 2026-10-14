using System;
using System.IO;
using System.IO.Compression;

namespace NLog.Targets
{
	// Token: 0x0200005B RID: 91
	internal class ZipArchiveFileCompressor : global::NLog.Targets.IFileCompressor
	{
		// Token: 0x060007AE RID: 1966 RVA: 0x0001370C File Offset: 0x0001190C
		public void CompressFile(string fileName, string archiveFileName)
		{
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(archiveFileName, global::System.IO.FileMode.Create))
			{
				using (global::System.IO.Compression.ZipArchive zipArchive = new global::System.IO.Compression.ZipArchive(fileStream, global::System.IO.Compression.ZipArchiveMode.Create))
				{
					using (global::System.IO.FileStream fileStream2 = new global::System.IO.FileStream(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite))
					{
						using (global::System.IO.Stream stream = zipArchive.CreateEntry(global::System.IO.Path.GetFileName(fileName)).Open())
						{
							fileStream2.CopyTo(stream);
						}
					}
				}
			}
		}
	}
}
