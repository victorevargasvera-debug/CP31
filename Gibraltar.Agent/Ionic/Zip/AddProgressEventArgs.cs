using System;

namespace Ionic.Zip
{
	// Token: 0x02000452 RID: 1106
	internal class AddProgressEventArgs : global::Ionic.Zip.ZipProgressEventArgs
	{
		// Token: 0x06002FCE RID: 12238 RVA: 0x000A9B64 File Offset: 0x000A7D64
		internal AddProgressEventArgs()
		{
		}

		// Token: 0x06002FCF RID: 12239 RVA: 0x000A9B6C File Offset: 0x000A7D6C
		private AddProgressEventArgs(string archiveName, global::Ionic.Zip.ZipProgressEventType flavor) : base(archiveName, flavor)
		{
		}

		// Token: 0x06002FD0 RID: 12240 RVA: 0x000A9B78 File Offset: 0x000A7D78
		internal static global::Ionic.Zip.AddProgressEventArgs AfterEntry(string archiveName, global::Ionic.Zip.ZipEntry entry, int entriesTotal)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_AfterAddEntry)
			{
				EntriesTotal = entriesTotal,
				CurrentEntry = entry
			};
		}

		// Token: 0x06002FD1 RID: 12241 RVA: 0x000A9B90 File Offset: 0x000A7D90
		internal static global::Ionic.Zip.AddProgressEventArgs Started(string archiveName)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_Started);
		}

		// Token: 0x06002FD2 RID: 12242 RVA: 0x000A9B9C File Offset: 0x000A7D9C
		internal static global::Ionic.Zip.AddProgressEventArgs Completed(string archiveName)
		{
			return new global::Ionic.Zip.AddProgressEventArgs(archiveName, global::Ionic.Zip.ZipProgressEventType.Adding_Completed);
		}
	}
}
