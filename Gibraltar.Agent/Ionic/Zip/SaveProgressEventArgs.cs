using System;

namespace Ionic.Zip
{
	// Token: 0x02000453 RID: 1107
	internal class SaveProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x06002FD3 RID: 12243 RVA: 0x000A9BA8 File Offset: 0x000A7DA8
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, global::Ionic.Zip.ZipEntry entry) : base(archiveName, before ? global::Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry : global::Ionic.Zip.ZipProgressEventType.Saving_AfterWriteEntry)
		{
			base.EntriesTotal = entriesTotal;
			base.CurrentEntry = entry;
			this._entriesSaved = entriesSaved;
		}

		// Token: 0x06002FD4 RID: 12244 RVA: 0x000A9BD8 File Offset: 0x000A7DD8
		internal SaveProgressEventArgs()
		{
		}

		// Token: 0x06002FD5 RID: 12245 RVA: 0x000A9BE0 File Offset: 0x000A7DE0
		internal SaveProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x06002FD6 RID: 12246 RVA: 0x000A9BEC File Offset: 0x000A7DEC
		internal static global::Ionic.Zip.SaveProgressEventArgs ByteUpdate(string archiveName, global::Ionic.Zip.ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return new global::Ionic.Zip.SaveProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Saving_EntryBytesRead)
			{
				ArchiveName = archiveName,
				CurrentEntry = entry,
				BytesTransferred = bytesXferred,
				TotalBytesToTransfer = totalBytes
			};
		}

		// Token: 0x06002FD7 RID: 12247 RVA: 0x000A9C24 File Offset: 0x000A7E24
		internal static global::Ionic.Zip.SaveProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.SaveProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Saving_Started);
		}

		// Token: 0x06002FD8 RID: 12248 RVA: 0x000A9C30 File Offset: 0x000A7E30
		internal static global::Ionic.Zip.SaveProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.SaveProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Saving_Completed);
		}

		// Token: 0x17000DB9 RID: 3513
		// (get) Token: 0x06002FD9 RID: 12249 RVA: 0x000A9C3C File Offset: 0x000A7E3C
		public int EntriesSaved
		{
			get
			{
				return this._entriesSaved;
			}
		}

		// Token: 0x04001176 RID: 4470
		private int _entriesSaved;
	}
}
