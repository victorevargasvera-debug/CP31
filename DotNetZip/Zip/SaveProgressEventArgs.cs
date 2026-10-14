using System;

namespace Ionic.Zip
{
	// Token: 0x02000038 RID: 56
	public class SaveProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x060002AB RID: 683 RVA: 0x000116D8 File Offset: 0x0000F8D8
		internal SaveProgressEventArgs(string archiveName, bool before, int entriesTotal, int entriesSaved, global::Ionic.Zip.ZipEntry entry) : base(archiveName, before ? global::Ionic.Zip.ZipProgressEventType.Saving_BeforeWriteEntry : global::Ionic.Zip.ZipProgressEventType.Saving_AfterWriteEntry)
		{
			base.EntriesTotal = entriesTotal;
			base.CurrentEntry = entry;
			this._entriesSaved = entriesSaved;
		}

		// Token: 0x060002AC RID: 684 RVA: 0x00011646 File Offset: 0x0000F846
		internal SaveProgressEventArgs()
		{
		}

		// Token: 0x060002AD RID: 685 RVA: 0x0001164E File Offset: 0x0000F84E
		internal SaveProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x060002AE RID: 686 RVA: 0x00011701 File Offset: 0x0000F901
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

		// Token: 0x060002AF RID: 687 RVA: 0x00011727 File Offset: 0x0000F927
		internal static global::Ionic.Zip.SaveProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.SaveProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Saving_Started);
		}

		// Token: 0x060002B0 RID: 688 RVA: 0x00011730 File Offset: 0x0000F930
		internal static global::Ionic.Zip.SaveProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.SaveProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Saving_Completed);
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060002B1 RID: 689 RVA: 0x0001173A File Offset: 0x0000F93A
		public int EntriesSaved
		{
			get
			{
				return this._entriesSaved;
			}
		}

		// Token: 0x040001F1 RID: 497
		private int _entriesSaved;
	}
}
