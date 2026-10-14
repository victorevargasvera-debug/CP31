using System;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E9 RID: 745
	public interface Entry
	{
		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x0600154B RID: 5451
		string Name { get; }

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x0600154C RID: 5452
		bool IsDirectoryEntry { get; }

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x0600154D RID: 5453
		bool IsDocumentEntry { get; }

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x0600154E RID: 5454
		global::NPOI.POIFS.FileSystem.DirectoryEntry Parent { get; }

		// Token: 0x0600154F RID: 5455
		bool Delete();

		// Token: 0x06001550 RID: 5456
		bool RenameTo(string newName);
	}
}
