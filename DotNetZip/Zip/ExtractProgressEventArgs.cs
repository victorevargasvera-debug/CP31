using System;

namespace Ionic.Zip
{
	// Token: 0x02000039 RID: 57
	public class ExtractProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x060002B2 RID: 690 RVA: 0x00011742 File Offset: 0x0000F942
		internal ExtractProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesExtracted, global::Ionic.Zip.ZipEntry entry, string extractLocation) : base(archiveName, before ? global::Ionic.Zip.ZipProgressEventType.Extracting_BeforeExtractEntry : global::Ionic.Zip.ZipProgressEventType.Extracting_AfterExtractEntry)
		{
			base.EntriesTotal = entriesTotal;
			base.CurrentEntry = entry;
			this._entriesExtracted = entriesExtracted;
			this._target = extractLocation;
		}

		// Token: 0x060002B3 RID: 691 RVA: 0x0001164E File Offset: 0x0000F84E
		internal ExtractProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x00011646 File Offset: 0x0000F846
		internal ExtractProgressEventArgs()
		{
		}

		// Token: 0x060002B5 RID: 693 RVA: 0x00011773 File Offset: 0x0000F973
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

		// Token: 0x060002B6 RID: 694 RVA: 0x00011797 File Offset: 0x0000F997
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

		// Token: 0x060002B7 RID: 695 RVA: 0x000117BB File Offset: 0x0000F9BB
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

		// Token: 0x060002B8 RID: 696 RVA: 0x000117DF File Offset: 0x0000F9DF
		internal static global::Ionic.Zip.ExtractProgressEventArgs ExtractAllStarted(string archiveName, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Extracting_BeforeExtractAll)
			{
				_target = extractLocation
			};
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000117F0 File Offset: 0x0000F9F0
		internal static global::Ionic.Zip.ExtractProgressEventArgs ExtractAllCompleted(string archiveName, string extractLocation)
		{
			return new global::Ionic.Zip.ExtractProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Extracting_AfterExtractAll)
			{
				_target = extractLocation
			};
		}

		// Token: 0x060002BA RID: 698 RVA: 0x00011801 File Offset: 0x0000FA01
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

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060002BB RID: 699 RVA: 0x00011827 File Offset: 0x0000FA27
		public int EntriesExtracted
		{
			get
			{
				return this._entriesExtracted;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060002BC RID: 700 RVA: 0x0001182F File Offset: 0x0000FA2F
		public string ExtractLocation
		{
			get
			{
				return this._target;
			}
		}

		// Token: 0x040001F2 RID: 498
		private int _entriesExtracted;

		// Token: 0x040001F3 RID: 499
		private string _target;
	}
}
