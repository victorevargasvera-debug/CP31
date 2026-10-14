using System;

namespace Ionic.Zip
{
	// Token: 0x02000037 RID: 55
	public class AddProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x060002A6 RID: 678 RVA: 0x00011646 File Offset: 0x0000F846
		internal AddProgressEventArgs()
		{
		}

		// Token: 0x060002A7 RID: 679 RVA: 0x0001164E File Offset: 0x0000F84E
		private AddProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x060002A8 RID: 680 RVA: 0x000116AF File Offset: 0x0000F8AF
		internal static global::Ionic.Zip.AddProgressEventArgs AfterEntry(string archiveName, global::Ionic.Zip.ZipEntry entry, int entriesTotal)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_AfterAddEntry)
			{
				EntriesTotal = entriesTotal,
				CurrentEntry = entry
			};
		}

		// Token: 0x060002A9 RID: 681 RVA: 0x000116C6 File Offset: 0x0000F8C6
		internal static global::Ionic.Zip.AddProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_Started);
		}

		// Token: 0x060002AA RID: 682 RVA: 0x000116CF File Offset: 0x0000F8CF
		internal static global::Ionic.Zip.AddProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_Completed);
		}
	}
}
