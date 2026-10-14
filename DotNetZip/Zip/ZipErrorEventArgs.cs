using System;

namespace Ionic.Zip
{
	// Token: 0x0200003A RID: 58
	public class ZipErrorEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x060002BD RID: 701 RVA: 0x00011646 File Offset: 0x0000F846
		private ZipErrorEventArgs()
		{
		}

		// Token: 0x060002BE RID: 702 RVA: 0x00011837 File Offset: 0x0000FA37
		internal static global::Ionic.Zip.ZipErrorEventArgs Saving(string archiveName, global::Ionic.Zip.ZipEntry entry, global::System.Exception exception)
		{
			return new global::Ionic.Zip.ZipErrorEventArgs
			{
				EventType = global::Ionic.Zip.ZipProgressEventType.Error_Saving,
				ArchiveName = archiveName,
				CurrentEntry = entry,
				_exc = exception
			};
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060002BF RID: 703 RVA: 0x0001185B File Offset: 0x0000FA5B
		public global::System.Exception Exception
		{
			get
			{
				return this._exc;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060002C0 RID: 704 RVA: 0x00011863 File Offset: 0x0000FA63
		public string FileName
		{
			get
			{
				return base.CurrentEntry.LocalFileName;
			}
		}

		// Token: 0x040001F4 RID: 500
		private global::System.Exception _exc;
	}
}
