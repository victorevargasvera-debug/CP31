using System;

namespace Ionic.Zip
{
	// Token: 0x02000455 RID: 1109
	internal class ZipErrorEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x06002FE5 RID: 12261 RVA: 0x000A9D9C File Offset: 0x000A7F9C
		private ZipErrorEventArgs()
		{
		}

		// Token: 0x06002FE6 RID: 12262 RVA: 0x000A9DA4 File Offset: 0x000A7FA4
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

		// Token: 0x17000DBC RID: 3516
		// (get) Token: 0x06002FE7 RID: 12263 RVA: 0x000A9DD8 File Offset: 0x000A7FD8
		public global::System.Exception Exception
		{
			get
			{
				return this._exc;
			}
		}

		// Token: 0x17000DBD RID: 3517
		// (get) Token: 0x06002FE8 RID: 12264 RVA: 0x000A9DE0 File Offset: 0x000A7FE0
		public string FileName
		{
			get
			{
				return base.CurrentEntry.LocalFileName;
			}
		}

		// Token: 0x04001179 RID: 4473
		private global::System.Exception _exc;
	}
}
