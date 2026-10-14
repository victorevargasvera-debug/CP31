using System;
using System.Collections;
using System.Collections.Generic;
using NPOI.POIFS.FileSystem;

namespace NPOI.Util
{
	// Token: 0x02000254 RID: 596
	public class POIUtils
	{
		// Token: 0x06000E98 RID: 3736 RVA: 0x0002B698 File Offset: 0x00029898
		public static void CopyNodeRecursively(global::NPOI.POIFS.FileSystem.Entry entry, global::NPOI.POIFS.FileSystem.DirectoryEntry target)
		{
			if (entry.IsDirectoryEntry)
			{
				global::NPOI.POIFS.FileSystem.DirectoryEntry target2 = target.CreateDirectory(entry.Name);
				global::System.Collections.IEnumerator entries = ((global::NPOI.POIFS.FileSystem.DirectoryEntry)entry).Entries;
				while (entries.MoveNext())
				{
					object obj = entries.Current;
					global::NPOI.Util.POIUtils.CopyNodeRecursively((global::NPOI.POIFS.FileSystem.Entry)obj, target2);
				}
				return;
			}
			global::NPOI.POIFS.FileSystem.DocumentEntry documentEntry = (global::NPOI.POIFS.FileSystem.DocumentEntry)entry;
			using (global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = new global::NPOI.POIFS.FileSystem.DocumentInputStream(documentEntry))
			{
				target.CreateDocument(documentEntry.Name, documentInputStream);
			}
		}

		// Token: 0x06000E99 RID: 3737 RVA: 0x0002B71C File Offset: 0x0002991C
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.DirectoryEntry sourceRoot, global::NPOI.POIFS.FileSystem.DirectoryEntry targetRoot, global::System.Collections.Generic.List<string> excepts)
		{
			global::System.Collections.IEnumerator entries = sourceRoot.Entries;
			while (entries.MoveNext())
			{
				object obj = entries.Current;
				global::NPOI.POIFS.FileSystem.Entry entry = (global::NPOI.POIFS.FileSystem.Entry)obj;
				if (!excepts.Contains(entry.Name))
				{
					global::NPOI.Util.POIUtils.CopyNodeRecursively(entry, targetRoot);
				}
			}
		}

		// Token: 0x06000E9A RID: 3738 RVA: 0x0002B75B File Offset: 0x0002995B
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.POIFSFileSystem source, global::NPOI.POIFS.FileSystem.POIFSFileSystem target, global::System.Collections.Generic.List<string> excepts)
		{
			global::NPOI.Util.POIUtils.CopyNodes(source.Root, target.Root, excepts);
		}
	}
}
