using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace NPOI.OpenXml4Net.Util
{
	// Token: 0x0200000A RID: 10
	public class ZipFileZipEntrySource : global::NPOI.OpenXml4Net.Util.ZipEntrySource
	{
		// Token: 0x06000035 RID: 53 RVA: 0x000029E8 File Offset: 0x00000BE8
		public ZipFileZipEntrySource(global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile)
		{
			this.zipArchive = zipFile;
		}

		// Token: 0x06000036 RID: 54 RVA: 0x000029F7 File Offset: 0x00000BF7
		public void Close()
		{
			if (this.zipArchive != null)
			{
				this.zipArchive.Close();
			}
			this.zipArchive = null;
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000037 RID: 55 RVA: 0x00002A13 File Offset: 0x00000C13
		public bool IsClosed
		{
			get
			{
				return this.zipArchive == null;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000038 RID: 56 RVA: 0x00002A1E File Offset: 0x00000C1E
		public global::System.Collections.IEnumerator Entries
		{
			get
			{
				if (this.zipArchive == null)
				{
					throw new global::System.IO.InvalidDataException("Zip File is closed");
				}
				return this.zipArchive.GetEnumerator();
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x00002A3E File Offset: 0x00000C3E
		public global::System.IO.Stream GetInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (this.zipArchive == null)
			{
				throw new global::System.IO.InvalidDataException("Zip File is closed");
			}
			return this.zipArchive.GetInputStream(entry);
		}

		// Token: 0x0400000D RID: 13
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile zipArchive;
	}
}
