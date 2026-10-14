using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using ICSharpCode.SharpZipLib.Zip;

namespace NPOI.OpenXml4Net.Util
{
	// Token: 0x0200000B RID: 11
	public class ZipInputStreamZipEntrySource : global::NPOI.OpenXml4Net.Util.ZipEntrySource
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00002A60 File Offset: 0x00000C60
		public ZipInputStreamZipEntrySource(global::ICSharpCode.SharpZipLib.Zip.ZipInputStream inp)
		{
			this.zipEntries = new global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry>();
			bool flag = true;
			while (flag)
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry nextEntry = inp.GetNextEntry();
				if (nextEntry == null)
				{
					flag = false;
				}
				else
				{
					global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry item = new global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry(nextEntry, inp);
					this.zipEntries.Add(item);
				}
			}
			inp.Close();
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00002AAD File Offset: 0x00000CAD
		public global::System.Collections.IEnumerator Entries
		{
			get
			{
				return new global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.EntryEnumerator(this.zipEntries);
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002ABA File Offset: 0x00000CBA
		public global::System.IO.Stream GetInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry)
		{
			return ((global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry)zipEntry).GetInputStream();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002AC7 File Offset: 0x00000CC7
		public void Close()
		{
			this.zipEntries = null;
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600003E RID: 62 RVA: 0x00002AD0 File Offset: 0x00000CD0
		public bool IsClosed
		{
			get
			{
				return this.zipEntries == null;
			}
		}

		// Token: 0x0400000E RID: 14
		private global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry> zipEntries;

		// Token: 0x02000034 RID: 52
		internal class EntryEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000219 RID: 537 RVA: 0x0000A0FD File Offset: 0x000082FD
			internal EntryEnumerator(global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry> zipEntries)
			{
				this.iterator = zipEntries.GetEnumerator();
			}

			// Token: 0x0600021A RID: 538 RVA: 0x0000A111 File Offset: 0x00008311
			public bool MoveNext()
			{
				return this.iterator.MoveNext();
			}

			// Token: 0x17000033 RID: 51
			// (get) Token: 0x0600021B RID: 539 RVA: 0x0000A11E File Offset: 0x0000831E
			public object Current
			{
				get
				{
					return this.iterator.Current;
				}
			}

			// Token: 0x0600021C RID: 540 RVA: 0x00002150 File Offset: 0x00000350
			public void Reset()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x040000FB RID: 251
			private global::System.Collections.Generic.List<global::NPOI.OpenXml4Net.Util.ZipInputStreamZipEntrySource.FakeZipEntry>.Enumerator iterator;
		}

		// Token: 0x02000035 RID: 53
		public class FakeZipEntry : global::ICSharpCode.SharpZipLib.Zip.ZipEntry
		{
			// Token: 0x0600021D RID: 541 RVA: 0x0000A12C File Offset: 0x0000832C
			public FakeZipEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.ZipInputStream inp) : base(entry.Name)
			{
				global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
				long size = entry.Size;
				if (size != -1L)
				{
					if (size >= 2147483647L)
					{
						throw new global::System.IO.IOException("ZIP entry size is too large");
					}
					memoryStream = new global::System.IO.MemoryStream((int)size);
				}
				else
				{
					memoryStream = new global::System.IO.MemoryStream();
				}
				byte[] array = new byte[4096];
				int count;
				while ((count = inp.Read(array, 0, array.Length)) > 0)
				{
					memoryStream.Write(array, 0, count);
				}
				this.data = memoryStream.ToArray();
			}

			// Token: 0x0600021E RID: 542 RVA: 0x0000A1AF File Offset: 0x000083AF
			public global::System.IO.Stream GetInputStream()
			{
				return new global::System.IO.MemoryStream(this.data);
			}

			// Token: 0x040000FC RID: 252
			private byte[] data;
		}
	}
}
