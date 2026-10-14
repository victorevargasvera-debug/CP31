using System;

namespace Ionic.Zip
{
	// Token: 0x02000036 RID: 54
	public class ReadProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x0600029F RID: 671 RVA: 0x00011646 File Offset: 0x0000F846
		internal ReadProgressEventArgs()
		{
		}

		// Token: 0x060002A0 RID: 672 RVA: 0x0001164E File Offset: 0x0000F84E
		private ReadProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x060002A1 RID: 673 RVA: 0x00011658 File Offset: 0x0000F858
		internal static global::Ionic.Zip.ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_BeforeReadEntry)
			{
				EntriesTotal = entriesTotal
			};
		}

		// Token: 0x060002A2 RID: 674 RVA: 0x00011668 File Offset: 0x0000F868
		internal static global::Ionic.Zip.ReadProgressEventArgs After(string archiveName, global::Ionic.Zip.ZipEntry entry, int entriesTotal)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_AfterReadEntry)
			{
				EntriesTotal = entriesTotal,
				CurrentEntry = entry
			};
		}

		// Token: 0x060002A3 RID: 675 RVA: 0x0001167F File Offset: 0x0000F87F
		internal static global::Ionic.Zip.ReadProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_Started);
		}

		// Token: 0x060002A4 RID: 676 RVA: 0x00011688 File Offset: 0x0000F888
		internal static global::Ionic.Zip.ReadProgressEventArgs ByteUpdate(string archiveName, global::Ionic.Zip.ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_ArchiveBytesRead)
			{
				CurrentEntry = entry,
				BytesTransferred = bytesXferred,
				TotalBytesToTransfer = totalBytes
			};
		}

		// Token: 0x060002A5 RID: 677 RVA: 0x000116A6 File Offset: 0x0000F8A6
		internal static global::Ionic.Zip.ReadProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_Completed);
		}
	}
}
