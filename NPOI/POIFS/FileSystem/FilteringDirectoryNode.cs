using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.EventFileSystem;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002D3 RID: 723
	public class FilteringDirectoryNode : global::NPOI.POIFS.FileSystem.DirectoryEntry, global::NPOI.POIFS.FileSystem.Entry, global::System.Collections.Generic.IEnumerable<global::NPOI.POIFS.FileSystem.Entry>, global::System.Collections.IEnumerable
	{
		// Token: 0x060013E5 RID: 5093 RVA: 0x0003BF40 File Offset: 0x0003A140
		public FilteringDirectoryNode(global::NPOI.POIFS.FileSystem.DirectoryEntry directory, global::System.Collections.Generic.ICollection<string> excludes)
		{
			this.directory = directory;
			this.excludes = new global::System.Collections.Generic.List<string>();
			this.childExcludes = new global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>>();
			foreach (string text in excludes)
			{
				int num = text.IndexOf('/');
				if (num == -1)
				{
					this.excludes.Add(text);
				}
				else
				{
					string key = text.Substring(0, num);
					string item = text.Substring(num + 1);
					if (!this.childExcludes.ContainsKey(key))
					{
						this.childExcludes.Add(key, new global::System.Collections.Generic.List<string>());
					}
					this.childExcludes[key].Add(item);
				}
			}
		}

		// Token: 0x170003C7 RID: 967
		// (get) Token: 0x060013E6 RID: 5094 RVA: 0x0003C008 File Offset: 0x0003A208
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> Entries
		{
			get
			{
				return this.GetEntries();
			}
		}

		// Token: 0x170003C8 RID: 968
		// (get) Token: 0x060013E7 RID: 5095 RVA: 0x0003C010 File Offset: 0x0003A210
		public global::System.Collections.Generic.List<string> EntryNames
		{
			get
			{
				global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
				foreach (string item in this.directory.EntryNames)
				{
					if (!this.excludes.Contains(item))
					{
						list.Add(item);
					}
				}
				return list;
			}
		}

		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x060013E8 RID: 5096 RVA: 0x0003C080 File Offset: 0x0003A280
		public bool IsEmpty
		{
			get
			{
				return this.EntryCount == 0;
			}
		}

		// Token: 0x060013E9 RID: 5097 RVA: 0x0003C08B File Offset: 0x0003A28B
		public bool HasEntry(string name)
		{
			return !this.excludes.Contains(name) && this.directory.HasEntry(name);
		}

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x060013EA RID: 5098 RVA: 0x0003C0AC File Offset: 0x0003A2AC
		public int EntryCount
		{
			get
			{
				int num = this.directory.EntryCount;
				foreach (string name in this.excludes)
				{
					if (this.directory.HasEntry(name))
					{
						num--;
					}
				}
				return num;
			}
		}

		// Token: 0x060013EB RID: 5099 RVA: 0x0003C118 File Offset: 0x0003A318
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> GetEntries()
		{
			return new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode.FilteringIterator(this);
		}

		// Token: 0x060013EC RID: 5100 RVA: 0x0003C120 File Offset: 0x0003A320
		public global::NPOI.POIFS.FileSystem.Entry GetEntry(string name)
		{
			if (this.excludes.Contains(name))
			{
				throw new global::System.IO.FileNotFoundException(name);
			}
			global::NPOI.POIFS.FileSystem.Entry entry = this.directory.GetEntry(name);
			return this.WrapEntry(entry);
		}

		// Token: 0x060013ED RID: 5101 RVA: 0x0003C158 File Offset: 0x0003A358
		private global::NPOI.POIFS.FileSystem.Entry WrapEntry(global::NPOI.POIFS.FileSystem.Entry entry)
		{
			string name = entry.Name;
			if (this.childExcludes.ContainsKey(name) && entry is global::NPOI.POIFS.FileSystem.DirectoryEntry)
			{
				return new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode((global::NPOI.POIFS.FileSystem.DirectoryEntry)entry, this.childExcludes[name]);
			}
			return entry;
		}

		// Token: 0x060013EE RID: 5102 RVA: 0x0003C19B File Offset: 0x0003A39B
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, global::System.IO.Stream stream)
		{
			return this.directory.CreateDocument(name, stream);
		}

		// Token: 0x060013EF RID: 5103 RVA: 0x0003C1AA File Offset: 0x0003A3AA
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
		{
			return this.directory.CreateDocument(name, size, writer);
		}

		// Token: 0x060013F0 RID: 5104 RVA: 0x0003C1BA File Offset: 0x0003A3BA
		public global::NPOI.POIFS.FileSystem.DirectoryEntry CreateDirectory(string name)
		{
			return this.directory.CreateDirectory(name);
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x060013F1 RID: 5105 RVA: 0x0003C1C8 File Offset: 0x0003A3C8
		// (set) Token: 0x060013F2 RID: 5106 RVA: 0x0003C1D5 File Offset: 0x0003A3D5
		public global::NPOI.Util.ClassID StorageClsid
		{
			get
			{
				return this.directory.StorageClsid;
			}
			set
			{
				this.directory.StorageClsid = value;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x060013F3 RID: 5107 RVA: 0x0003C1E3 File Offset: 0x0003A3E3
		public string Name
		{
			get
			{
				return this.directory.Name;
			}
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x060013F4 RID: 5108 RVA: 0x00008875 File Offset: 0x00006A75
		public bool IsDirectoryEntry
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x060013F5 RID: 5109 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool IsDocumentEntry
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x060013F6 RID: 5110 RVA: 0x0003C1F0 File Offset: 0x0003A3F0
		public global::NPOI.POIFS.FileSystem.DirectoryEntry Parent
		{
			get
			{
				return this.directory.Parent;
			}
		}

		// Token: 0x060013F7 RID: 5111 RVA: 0x0003C1FD File Offset: 0x0003A3FD
		public bool Delete()
		{
			return this.directory.Delete();
		}

		// Token: 0x060013F8 RID: 5112 RVA: 0x0003C20A File Offset: 0x0003A40A
		public bool RenameTo(string newName)
		{
			return this.directory.RenameTo(newName);
		}

		// Token: 0x060013F9 RID: 5113 RVA: 0x0003C118 File Offset: 0x0003A318
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> GetEnumerator()
		{
			return new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode.FilteringIterator(this);
		}

		// Token: 0x060013FA RID: 5114 RVA: 0x0003C118 File Offset: 0x0003A318
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::NPOI.POIFS.FileSystem.FilteringDirectoryNode.FilteringIterator(this);
		}

		// Token: 0x0400084C RID: 2124
		private global::System.Collections.Generic.List<string> excludes;

		// Token: 0x0400084D RID: 2125
		private global::System.Collections.Generic.Dictionary<string, global::System.Collections.Generic.List<string>> childExcludes;

		// Token: 0x0400084E RID: 2126
		private global::NPOI.POIFS.FileSystem.DirectoryEntry directory;

		// Token: 0x020005AB RID: 1451
		private class FilteringIterator : global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600348B RID: 13451 RVA: 0x000A358E File Offset: 0x000A178E
			public FilteringIterator(global::NPOI.POIFS.FileSystem.FilteringDirectoryNode filtering)
			{
				this.filtering = filtering;
				this.directory = filtering.directory;
				this.parent = this.directory.Entries;
			}

			// Token: 0x0600348C RID: 13452 RVA: 0x000A35BA File Offset: 0x000A17BA
			public void Remove()
			{
				throw new global::System.InvalidOperationException("Remove not supported");
			}

			// Token: 0x17000DB7 RID: 3511
			// (get) Token: 0x0600348D RID: 13453 RVA: 0x000A35C6 File Offset: 0x000A17C6
			public global::NPOI.POIFS.FileSystem.Entry Current
			{
				get
				{
					return this.next;
				}
			}

			// Token: 0x0600348E RID: 13454 RVA: 0x00019A7F File Offset: 0x00017C7F
			public void Dispose()
			{
			}

			// Token: 0x17000DB8 RID: 3512
			// (get) Token: 0x0600348F RID: 13455 RVA: 0x000A35C6 File Offset: 0x000A17C6
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.next;
				}
			}

			// Token: 0x06003490 RID: 13456 RVA: 0x000A35D0 File Offset: 0x000A17D0
			public bool MoveNext()
			{
				this.next = null;
				while (this.parent.MoveNext())
				{
					global::NPOI.POIFS.FileSystem.Entry entry = this.parent.Current;
					if (!this.filtering.excludes.Contains(entry.Name))
					{
						this.next = this.filtering.WrapEntry(entry);
						break;
					}
				}
				return this.next != null;
			}

			// Token: 0x06003491 RID: 13457 RVA: 0x00008C75 File Offset: 0x00006E75
			public void Reset()
			{
				throw new global::System.NotImplementedException();
			}

			// Token: 0x04001924 RID: 6436
			private global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> parent;

			// Token: 0x04001925 RID: 6437
			private global::NPOI.POIFS.FileSystem.Entry next;

			// Token: 0x04001926 RID: 6438
			private global::NPOI.POIFS.FileSystem.DirectoryEntry directory;

			// Token: 0x04001927 RID: 6439
			private global::NPOI.POIFS.FileSystem.FilteringDirectoryNode filtering;
		}
	}
}
