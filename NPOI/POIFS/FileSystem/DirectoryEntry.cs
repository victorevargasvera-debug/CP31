using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.EventFileSystem;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E4 RID: 740
	public interface DirectoryEntry : global::NPOI.POIFS.FileSystem.Entry, global::System.Collections.Generic.IEnumerable<global::NPOI.POIFS.FileSystem.Entry>, global::System.Collections.IEnumerable
	{
		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06001503 RID: 5379
		global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> Entries { get; }

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06001504 RID: 5380
		global::System.Collections.Generic.List<string> EntryNames { get; }

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001505 RID: 5381
		bool IsEmpty { get; }

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001506 RID: 5382
		int EntryCount { get; }

		// Token: 0x06001507 RID: 5383
		global::NPOI.POIFS.FileSystem.Entry GetEntry(string name);

		// Token: 0x06001508 RID: 5384
		global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, global::System.IO.Stream stream);

		// Token: 0x06001509 RID: 5385
		global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer);

		// Token: 0x0600150A RID: 5386
		global::NPOI.POIFS.FileSystem.DirectoryEntry CreateDirectory(string name);

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600150B RID: 5387
		// (set) Token: 0x0600150C RID: 5388
		global::NPOI.Util.ClassID StorageClsid { get; set; }

		// Token: 0x0600150D RID: 5389
		bool HasEntry(string name);
	}
}
