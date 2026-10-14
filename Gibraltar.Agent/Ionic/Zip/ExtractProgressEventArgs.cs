using System;

namespace Ionic.Zip
{
	// Token: 0x02000454 RID: 1108
	internal class ExtractProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x06002FDA RID: 12250 RVA: 0x000A9C44 File Offset: 0x000A7E44
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, global::Ionic.Zip.ZipEntry entry, string extractLocation) : base(archiveName, before ? global::Ionic.Zip.ZipProgressEventType.Extracting_BeforeExtractEntry : global::Ionic.Zip.ZipProgressEventType.Extracting_AfterExtractEntry)
		{
			base.EntriesTotal = entriesTotal;
			base.CurrentEntry = entry;
			this._entriesExtracted = entriesExtracted;
			this._target = extractLocation;
		}

		// Token: 0x06002FDB RID: 12251 RVA: 0x000A9C7C File Offset: 0x000A7E7C
		internal ExtractProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x06002FDC RID: 12252 RVA: 0x000A9C88 File Offset: 0x000A7E88
		internal ExtractProgressEventArgs()
		{
		}

		// Token: 0x06002FDD RID: 12253 RVA: 0x000A9C90 File Offset: 0x000A7E90
		internal static global::Ionic.Zip.ExtractProgressEventArgs BeforeExtractEntry(string archiveName, global::Ionic.Zip.ZipEntry entry, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs
			{
				ArchiveName = archiveName,
				EventType = global::Ionic.Zip.ZipProgressEventType.Extracting_BeforeExtractEntry,
				CurrentEntry = entry,
				_target = extractLocation
			};
		}

		// Token: 0x06002FDE RID: 12254 RVA: 0x000A9CC4 File Offset: 0x000A7EC4
		internal static global::Ionic.Zip.ExtractProgressEventArgs ExtractExisting(string archiveName, global::Ionic.Zip.ZipEntry entry, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs
			{
				ArchiveName = archiveName,
				EventType = global::Ionic.Zip.ZipProgressEventType.Extracting_ExtractEntryWouldOverwrite,
				CurrentEntry = entry,
				_target = extractLocation
			};
		}

		// Token: 0x06002FDF RID: 12255 RVA: 0x000A9CF8 File Offset: 0x000A7EF8
		internal static global::Ionic.Zip.ExtractProgressEventArgs AfterExtractEntry(string archiveName, global::Ionic.Zip.ZipEntry entry, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs
			{
				ArchiveName = archiveName,
				EventType = global::Ionic.Zip.ZipProgressEventType.Extracting_AfterExtractEntry,
				CurrentEntry = entry,
				_target = extractLocation
			};
		}

		// Token: 0x06002FE0 RID: 12256 RVA: 0x000A9D2C File Offset: 0x000A7F2C
		internal static global::Ionic.Zip.ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Extracting_BeforeExtractAll)
			{
				_target = extractLocation
			};
		}

		// Token: 0x06002FE1 RID: 12257 RVA: 0x000A9D40 File Offset: 0x000A7F40
		internal static global::Ionic.Zip.ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Extracting_AfterExtractAll)
			{
				_target = extractLocation
			};
		}

		// Token: 0x06002FE2 RID: 12258 RVA: 0x000A9D54 File Offset: 0x000A7F54
		internal static global::Ionic.Zip.ExtractProgressEventArgs ByteUpdate(string archiveName, global::Ionic.Zip.ZipEntry entry, long bytesWritten, long totalBytes)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Extracting_EntryBytesWritten)
			{
				ArchiveName = archiveName,
				CurrentEntry = entry,
				BytesTransferred = bytesWritten,
				TotalBytesToTransfer = totalBytes
			};
		}

		// Token: 0x17000DBA RID: 3514
		// (get) Token: 0x06002FE3 RID: 12259 RVA: 0x000A9D8C File Offset: 0x000A7F8C
		public int EntriesExtracted
		{
			get
			{
				return this._entriesExtracted;
			}
		}

		// Token: 0x17000DBB RID: 3515
		// (get) Token: 0x06002FE4 RID: 12260 RVA: 0x000A9D94 File Offset: 0x000A7F94
		public string ExtractLocation
		{
			get
			{
				return this._target;
			}
		}

		// Token: 0x04001177 RID: 4471
		private int _entriesExtracted;

		// Token: 0x04001178 RID: 4472
		private string _target;
	}
}
