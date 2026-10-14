using System;

namespace Ionic.Zip
{
	// Token: 0x02000451 RID: 1105
	internal class ReadProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x06002FC7 RID: 12231 RVA: 0x000A9AF0 File Offset: 0x000A7CF0
		internal ReadProgressEventArgs()
		{
		}

		// Token: 0x06002FC8 RID: 12232 RVA: 0x000A9AF8 File Offset: 0x000A7CF8
		private ReadProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x06002FC9 RID: 12233 RVA: 0x000A9B04 File Offset: 0x000A7D04
		internal static global::Ionic.Zip.ReadProgressEventArgs Before(string archiveName, int entriesTotal)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_BeforeReadEntry)
			{
				EntriesTotal = entriesTotal
			};
		}

		// Token: 0x06002FCA RID: 12234 RVA: 0x000A9B14 File Offset: 0x000A7D14
		internal static global::Ionic.Zip.ReadProgressEventArgs After(string archiveName, global::Ionic.Zip.ZipEntry entry, int entriesTotal)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_AfterReadEntry)
			{
				EntriesTotal = entriesTotal,
				CurrentEntry = entry
			};
		}

		// Token: 0x06002FCB RID: 12235 RVA: 0x000A9B2C File Offset: 0x000A7D2C
		internal static global::Ionic.Zip.ReadProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_Started);
		}

		// Token: 0x06002FCC RID: 12236 RVA: 0x000A9B38 File Offset: 0x000A7D38
		internal static global::Ionic.Zip.ReadProgressEventArgs ByteUpdate(string archiveName, global::Ionic.Zip.ZipEntry entry, long bytesXferred, long totalBytes)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_ArchiveBytesRead)
			{
				CurrentEntry = entry,
				BytesTransferred = bytesXferred,
				TotalBytesToTransfer = totalBytes
			};
		}

		// Token: 0x06002FCD RID: 12237 RVA: 0x000A9B58 File Offset: 0x000A7D58
		internal static global::Ionic.Zip.ReadProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.ReadProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Reading_Completed);
		}
	}
}
