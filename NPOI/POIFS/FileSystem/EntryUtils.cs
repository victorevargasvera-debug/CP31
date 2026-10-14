using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D2 RID: 722
	public class EntryUtils
	{
		// Token: 0x060013DA RID: 5082 RVA: 0x0003BB64 File Offset: 0x00039D64
		public static void CopyNodeRecursively(global::NPOI.POIFS.FileSystem.Entry entry, global::NPOI.POIFS.FileSystem.DirectoryEntry target)
		{
			if (entry.IsDirectoryEntry)
			{
				global::NPOI.POIFS.FileSystem.DirectoryEntry directoryEntry = (global::NPOI.POIFS.FileSystem.DirectoryEntry)entry;
				global::NPOI.POIFS.FileSystem.DirectoryEntry directoryEntry2 = target.CreateDirectory(entry.Name);
				directoryEntry2.StorageClsid = directoryEntry.StorageClsid;
				global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> entries = directoryEntry.Entries;
				while (entries.MoveNext())
				{
					global::NPOI.POIFS.FileSystem.Entry entry2 = entries.Current;
					global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodeRecursively(entry2, directoryEntry2);
				}
				return;
			}
			global::NPOI.POIFS.FileSystem.DocumentEntry documentEntry = (global::NPOI.POIFS.FileSystem.DocumentEntry)entry;
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = new global::NPOI.POIFS.FileSystem.DocumentInputStream(documentEntry);
			target.CreateDocument(documentEntry.Name, documentInputStream);
			documentInputStream.Close();
		}

		// Token: 0x060013DB RID: 5083 RVA: 0x0003BBE0 File Offset: 0x00039DE0
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.DirectoryEntry sourceRoot, global::NPOI.POIFS.FileSystem.DirectoryEntry targetRoot)
		{
			foreach (global::NPOI.POIFS.FileSystem.Entry entry in sourceRoot)
			{
				global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodeRecursively(entry, targetRoot);
			}
		}

		// Token: 0x060013DC RID: 5084 RVA: 0x0003BC28 File Offset: 0x00039E28
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.FilteringDirectoryNode filteredSource, global::NPOI.POIFS.FileSystem.FilteringDirectoryNode filteredTarget)
		{
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(filteredSource, filteredTarget);
		}

		// Token: 0x060013DD RID: 5085 RVA: 0x0003BC34 File Offset: 0x00039E34
		[global::System.Obsolete]
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.DirectoryEntry sourceRoot, global::NPOI.POIFS.FileSystem.DirectoryEntry targetRoot, global::System.Collections.Generic.List<string> excepts)
		{
			global::System.Collections.IEnumerator entries = sourceRoot.Entries;
			while (entries.MoveNext())
			{
				object obj = entries.Current;
				global::NPOI.POIFS.FileSystem.Entry entry = (global::NPOI.POIFS.FileSystem.Entry)obj;
				if (!excepts.Contains(entry.Name))
				{
					global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodeRecursively(entry, targetRoot);
				}
			}
		}

		// Token: 0x060013DE RID: 5086 RVA: 0x0003BC73 File Offset: 0x00039E73
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem source, global::NPOI.POIFS.FileSystem.OPOIFSFileSystem target)
		{
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(source.Root, target.Root);
		}

		// Token: 0x060013DF RID: 5087 RVA: 0x0003BC86 File Offset: 0x00039E86
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem source, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem target)
		{
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(source.Root, target.Root);
		}

		// Token: 0x060013E0 RID: 5088 RVA: 0x0003BC99 File Offset: 0x00039E99
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.OPOIFSFileSystem source, global::NPOI.POIFS.FileSystem.OPOIFSFileSystem target, global::System.Collections.Generic.List<string> excepts)
		{
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(source.Root, excepts), new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(target.Root, excepts));
		}

		// Token: 0x060013E1 RID: 5089 RVA: 0x0003BCB8 File Offset: 0x00039EB8
		public static void CopyNodes(global::NPOI.POIFS.FileSystem.NPOIFSFileSystem source, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem target, global::System.Collections.Generic.List<string> excepts)
		{
			global::NPOI.POIFS.FileSystem.EntryUtils.CopyNodes(new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(source.Root, excepts), new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode(target.Root, excepts));
		}

		// Token: 0x060013E2 RID: 5090 RVA: 0x0003BCD8 File Offset: 0x00039ED8
		public static bool AreDirectoriesIdentical(global::NPOI.POIFS.FileSystem.DirectoryEntry dirA, global::NPOI.POIFS.FileSystem.DirectoryEntry dirB)
		{
			if (!dirA.Name.Equals(dirB.Name))
			{
				return false;
			}
			if (dirA.EntryCount != dirB.EntryCount)
			{
				return false;
			}
			global::System.Collections.Generic.Dictionary<string, int> dictionary = new global::System.Collections.Generic.Dictionary<string, int>();
			int num = -12345;
			foreach (global::NPOI.POIFS.FileSystem.Entry entry in dirA)
			{
				string name = entry.Name;
				if (entry.IsDirectoryEntry)
				{
					dictionary.Add(name, num);
				}
				else
				{
					dictionary.Add(name, ((global::NPOI.POIFS.FileSystem.DocumentNode)entry).Size);
				}
			}
			foreach (global::NPOI.POIFS.FileSystem.Entry entry2 in dirB)
			{
				string name2 = entry2.Name;
				if (!dictionary.ContainsKey(name2))
				{
					return false;
				}
				int num2;
				if (entry2.IsDirectoryEntry)
				{
					num2 = num;
				}
				else
				{
					num2 = ((global::NPOI.POIFS.FileSystem.DocumentNode)entry2).Size;
				}
				if (num2 != dictionary[name2])
				{
					return false;
				}
				dictionary.Remove(name2);
			}
			if (dictionary.Count != 0)
			{
				return false;
			}
			foreach (global::NPOI.POIFS.FileSystem.Entry entry3 in dirA)
			{
				try
				{
					global::NPOI.POIFS.FileSystem.Entry entry4 = dirB.GetEntry(entry3.Name);
					bool flag;
					if (entry3.IsDirectoryEntry)
					{
						flag = global::NPOI.POIFS.FileSystem.EntryUtils.AreDirectoriesIdentical((global::NPOI.POIFS.FileSystem.DirectoryEntry)entry3, (global::NPOI.POIFS.FileSystem.DirectoryEntry)entry4);
					}
					else
					{
						flag = global::NPOI.POIFS.FileSystem.EntryUtils.AreDocumentsIdentical((global::NPOI.POIFS.FileSystem.DocumentEntry)entry3, (global::NPOI.POIFS.FileSystem.DocumentEntry)entry4);
					}
					if (!flag)
					{
						return false;
					}
				}
				catch (global::System.IO.FileNotFoundException)
				{
					return false;
				}
				catch (global::System.IO.IOException)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x060013E3 RID: 5091 RVA: 0x0003BEB0 File Offset: 0x0003A0B0
		public static bool AreDocumentsIdentical(global::NPOI.POIFS.FileSystem.DocumentEntry docA, global::NPOI.POIFS.FileSystem.DocumentEntry docB)
		{
			if (!docA.Name.Equals(docB.Name))
			{
				return false;
			}
			if (docA.Size != docB.Size)
			{
				return false;
			}
			bool result = true;
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream = null;
			global::NPOI.POIFS.FileSystem.DocumentInputStream documentInputStream2 = null;
			try
			{
				documentInputStream = new global::NPOI.POIFS.FileSystem.DocumentInputStream(docA);
				documentInputStream2 = new global::NPOI.POIFS.FileSystem.DocumentInputStream(docB);
				for (;;)
				{
					int num = documentInputStream.Read();
					int num2 = documentInputStream2.Read();
					if (num != num2)
					{
						break;
					}
					if (num == -1 || num2 == -1)
					{
						goto IL_5A;
					}
				}
				result = false;
				IL_5A:;
			}
			finally
			{
				if (documentInputStream != null)
				{
					documentInputStream.Close();
				}
				if (documentInputStream2 != null)
				{
					documentInputStream2.Close();
				}
			}
			return result;
		}
	}
}
