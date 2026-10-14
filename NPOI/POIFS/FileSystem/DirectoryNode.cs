using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using NPOI.POIFS.Dev;
using NPOI.POIFS.EventFileSystem;
using NPOI.POIFS.Properties;
using NPOI.Util;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E5 RID: 741
	[global::System.Serializable]
	public class DirectoryNode : global::NPOI.POIFS.FileSystem.EntryNode, global::NPOI.POIFS.FileSystem.DirectoryEntry, global::NPOI.POIFS.FileSystem.Entry, global::System.Collections.Generic.IEnumerable<global::NPOI.POIFS.FileSystem.Entry>, global::System.Collections.IEnumerable, global::NPOI.POIFS.Dev.POIFSViewable
	{
		// Token: 0x0600150E RID: 5390 RVA: 0x0003F7F0 File Offset: 0x0003D9F0
		internal DirectoryNode(global::NPOI.POIFS.Properties.DirectoryProperty property, global::NPOI.POIFS.FileSystem.OPOIFSFileSystem fileSystem, global::NPOI.POIFS.FileSystem.DirectoryNode parent) : this(property, parent, fileSystem, null)
		{
		}

		// Token: 0x0600150F RID: 5391 RVA: 0x0003F7FC File Offset: 0x0003D9FC
		internal DirectoryNode(global::NPOI.POIFS.Properties.DirectoryProperty property, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem nFileSystem, global::NPOI.POIFS.FileSystem.DirectoryNode parent) : this(property, parent, null, nFileSystem)
		{
		}

		// Token: 0x06001510 RID: 5392 RVA: 0x0003F808 File Offset: 0x0003DA08
		private DirectoryNode(global::NPOI.POIFS.Properties.DirectoryProperty property, global::NPOI.POIFS.FileSystem.DirectoryNode parent, global::NPOI.POIFS.FileSystem.OPOIFSFileSystem oFileSystem, global::NPOI.POIFS.FileSystem.NPOIFSFileSystem nFileSystem) : base(property, parent)
		{
			this._oFilesSystem = oFileSystem;
			this._nFilesSystem = nFileSystem;
			if (parent == null)
			{
				this._path = new global::NPOI.POIFS.FileSystem.POIFSDocumentPath();
			}
			else
			{
				this._path = new global::NPOI.POIFS.FileSystem.POIFSDocumentPath(parent._path, new string[]
				{
					property.Name
				});
			}
			this._byname = new global::System.Collections.Generic.Dictionary<string, global::NPOI.POIFS.FileSystem.Entry>();
			this._entries = new global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.Entry>();
			global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.Properties.Property> children = property.Children;
			while (children.MoveNext())
			{
				global::NPOI.POIFS.Properties.Property property2 = children.Current;
				global::NPOI.POIFS.FileSystem.Entry entry;
				if (property2.IsDirectory)
				{
					global::NPOI.POIFS.Properties.DirectoryProperty property3 = (global::NPOI.POIFS.Properties.DirectoryProperty)property2;
					if (this._oFilesSystem != null)
					{
						entry = new global::NPOI.POIFS.FileSystem.DirectoryNode(property3, this._oFilesSystem, this);
					}
					else
					{
						entry = new global::NPOI.POIFS.FileSystem.DirectoryNode(property3, this._nFilesSystem, this);
					}
				}
				else
				{
					entry = new global::NPOI.POIFS.FileSystem.DocumentNode((global::NPOI.POIFS.Properties.DocumentProperty)property2, this);
				}
				this._entries.Add(entry);
				this._byname.Add(entry.Name, entry);
			}
		}

		// Token: 0x06001511 RID: 5393 RVA: 0x0003F8EE File Offset: 0x0003DAEE
		public global::NPOI.POIFS.FileSystem.DocumentInputStream CreatePOIFSDocumentReader(string documentName)
		{
			global::NPOI.POIFS.FileSystem.Entry entry = this.GetEntry(documentName);
			if (!entry.IsDocumentEntry)
			{
				throw new global::System.IO.IOException("Entry '" + documentName + "' Is not a DocumentEntry");
			}
			return new global::NPOI.POIFS.FileSystem.DocumentInputStream((global::NPOI.POIFS.FileSystem.DocumentEntry)entry);
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0003F920 File Offset: 0x0003DB20
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(global::NPOI.POIFS.FileSystem.OPOIFSDocument document)
		{
			global::NPOI.POIFS.Properties.DocumentProperty documentProperty = document.DocumentProperty;
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode = new global::NPOI.POIFS.FileSystem.DocumentNode(documentProperty, this);
			((global::NPOI.POIFS.Properties.DirectoryProperty)base.Property).AddChild(documentProperty);
			this._oFilesSystem.AddDocument(document);
			this._entries.Add(documentNode);
			this._byname.Add(documentProperty.Name, documentNode);
			return documentNode;
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x0003F978 File Offset: 0x0003DB78
		public bool ChangeName(string oldName, string newName)
		{
			bool flag = false;
			global::NPOI.POIFS.FileSystem.EntryNode entryNode = (global::NPOI.POIFS.FileSystem.EntryNode)this._byname[oldName];
			if (entryNode != null)
			{
				flag = ((global::NPOI.POIFS.Properties.DirectoryProperty)base.Property).ChangeName(entryNode.Property, newName);
				if (flag)
				{
					this._byname.Remove(oldName);
					this._byname[entryNode.Property.Name] = entryNode;
				}
			}
			return flag;
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x0003F9DC File Offset: 0x0003DBDC
		public bool DeleteEntry(global::NPOI.POIFS.FileSystem.EntryNode entry)
		{
			bool flag = ((global::NPOI.POIFS.Properties.DirectoryProperty)base.Property).DeleteChild(entry.Property);
			if (flag)
			{
				this._entries.Remove(entry);
				this._byname.Remove(entry.Name);
				if (this._oFilesSystem != null)
				{
					this._oFilesSystem.Remove(entry);
				}
				else
				{
					try
					{
						this._nFilesSystem.Remove(entry);
					}
					catch (global::System.IO.IOException)
					{
					}
				}
			}
			return flag;
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001515 RID: 5397 RVA: 0x0003FA5C File Offset: 0x0003DC5C
		public global::NPOI.POIFS.FileSystem.POIFSDocumentPath Path
		{
			get
			{
				return this._path;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0003FA64 File Offset: 0x0003DC64
		public global::NPOI.POIFS.FileSystem.NPOIFSFileSystem FileSystem
		{
			get
			{
				return this._nFilesSystem;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0003FA6C File Offset: 0x0003DC6C
		public global::NPOI.POIFS.FileSystem.OPOIFSFileSystem OFileSystem
		{
			get
			{
				return this._oFilesSystem;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0003FA64 File Offset: 0x0003DC64
		public global::NPOI.POIFS.FileSystem.NPOIFSFileSystem NFileSystem
		{
			get
			{
				return this._nFilesSystem;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0003FA74 File Offset: 0x0003DC74
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> Entries
		{
			get
			{
				return this._entries.GetEnumerator();
			}
		}

		// Token: 0x0600151A RID: 5402 RVA: 0x0003FA86 File Offset: 0x0003DC86
		internal global::NPOI.POIFS.FileSystem.Entry GetEntry(int index)
		{
			return this._entries[index];
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x0003FA94 File Offset: 0x0003DC94
		public global::System.Collections.Generic.List<string> EntryNames
		{
			get
			{
				return new global::System.Collections.Generic.List<string>(this._byname.Keys);
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0003FAA6 File Offset: 0x0003DCA6
		public bool IsEmpty
		{
			get
			{
				return this._entries.Count == 0;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0003FAB6 File Offset: 0x0003DCB6
		public int EntryCount
		{
			get
			{
				return this._entries.Count;
			}
		}

		// Token: 0x0600151E RID: 5406 RVA: 0x0003FAC3 File Offset: 0x0003DCC3
		public bool HasEntry(string name)
		{
			return name != null && this._byname.ContainsKey(name);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0003FAD8 File Offset: 0x0003DCD8
		public global::NPOI.POIFS.FileSystem.Entry GetEntry(string name)
		{
			global::NPOI.POIFS.FileSystem.Entry entry = null;
			if (name != null)
			{
				this._byname.TryGetValue(name, out entry);
			}
			if (entry == null)
			{
				throw new global::System.IO.FileNotFoundException("no such entry: \"" + name + "\"");
			}
			return entry;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x0003FB13 File Offset: 0x0003DD13
		public global::NPOI.POIFS.FileSystem.DocumentInputStream CreateDocumentInputStream(global::NPOI.POIFS.FileSystem.Entry document)
		{
			if (!document.IsDocumentEntry)
			{
				throw new global::System.IO.IOException("Entry '" + document.Name + "' is not a DocumentEntry");
			}
			return new global::NPOI.POIFS.FileSystem.DocumentInputStream((global::NPOI.POIFS.FileSystem.DocumentEntry)document);
		}

		// Token: 0x06001521 RID: 5409 RVA: 0x0003FB43 File Offset: 0x0003DD43
		public global::NPOI.POIFS.FileSystem.DocumentInputStream CreateDocumentInputStream(string documentName)
		{
			return this.CreateDocumentInputStream(this.GetEntry(documentName));
		}

		// Token: 0x06001522 RID: 5410 RVA: 0x0003FB54 File Offset: 0x0003DD54
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(global::NPOI.POIFS.FileSystem.NPOIFSDocument document)
		{
			global::NPOI.POIFS.FileSystem.DocumentEntry result;
			try
			{
				global::NPOI.POIFS.Properties.DocumentProperty documentProperty = document.DocumentProperty;
				global::NPOI.POIFS.FileSystem.DocumentNode documentNode = new global::NPOI.POIFS.FileSystem.DocumentNode(documentProperty, this);
				((global::NPOI.POIFS.Properties.DirectoryProperty)base.Property).AddChild(documentProperty);
				this._nFilesSystem.AddDocument(document);
				this._entries.Add(documentNode);
				this._byname[documentProperty.Name] = documentNode;
				result = documentNode;
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x06001523 RID: 5411 RVA: 0x0003FBC4 File Offset: 0x0003DDC4
		public global::NPOI.POIFS.FileSystem.DirectoryEntry CreateDirectory(string name)
		{
			global::NPOI.POIFS.Properties.DirectoryProperty directoryProperty = new global::NPOI.POIFS.Properties.DirectoryProperty(name);
			global::NPOI.POIFS.FileSystem.DirectoryNode directoryNode;
			if (this._oFilesSystem != null)
			{
				directoryNode = new global::NPOI.POIFS.FileSystem.DirectoryNode(directoryProperty, this._oFilesSystem, this);
				this._oFilesSystem.AddDirectory(directoryProperty);
			}
			else
			{
				directoryNode = new global::NPOI.POIFS.FileSystem.DirectoryNode(directoryProperty, this._nFilesSystem, this);
				this._nFilesSystem.AddDirectory(directoryProperty);
			}
			((global::NPOI.POIFS.Properties.DirectoryProperty)base.Property).AddChild(directoryProperty);
			this._entries.Add(directoryNode);
			this._byname[name] = directoryNode;
			return directoryNode;
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0003FC44 File Offset: 0x0003DE44
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateOrUpdateDocument(string name, global::System.IO.Stream stream)
		{
			if (!this.HasEntry(name))
			{
				return this.CreateDocument(name, stream);
			}
			global::NPOI.POIFS.FileSystem.DocumentNode documentNode = (global::NPOI.POIFS.FileSystem.DocumentNode)this.GetEntry(name);
			if (this._nFilesSystem != null)
			{
				new global::NPOI.POIFS.FileSystem.NPOIFSDocument(documentNode).ReplaceContents(stream);
				return documentNode;
			}
			this.DeleteEntry(documentNode);
			return this.CreateDocument(name, stream);
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001526 RID: 5414 RVA: 0x0003FCA4 File Offset: 0x0003DEA4
		// (set) Token: 0x06001525 RID: 5413 RVA: 0x0003FC96 File Offset: 0x0003DE96
		public global::NPOI.Util.ClassID StorageClsid
		{
			get
			{
				return base.Property.StorageClsid;
			}
			set
			{
				base.Property.StorageClsid = value;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001527 RID: 5415 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsDirectoryEntry
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001528 RID: 5416 RVA: 0x0003FCB1 File Offset: 0x0003DEB1
		protected override bool IsDeleteOK
		{
			get
			{
				return this.IsEmpty;
			}
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0003FCBC File Offset: 0x0003DEBC
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, global::System.IO.Stream stream)
		{
			global::NPOI.POIFS.FileSystem.DocumentEntry result;
			try
			{
				if (this._nFilesSystem != null)
				{
					result = this.CreateDocument(new global::NPOI.POIFS.FileSystem.NPOIFSDocument(name, this._nFilesSystem, stream));
				}
				else
				{
					result = this.CreateDocument(new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, stream));
				}
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			return result;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0003FD0C File Offset: 0x0003DF0C
		public global::NPOI.POIFS.FileSystem.DocumentEntry CreateDocument(string name, int size, global::NPOI.POIFS.EventFileSystem.POIFSWriterListener writer)
		{
			if (this._nFilesSystem != null)
			{
				return this.CreateDocument(new global::NPOI.POIFS.FileSystem.NPOIFSDocument(name, size, this._nFilesSystem, writer));
			}
			return this.CreateDocument(new global::NPOI.POIFS.FileSystem.OPOIFSDocument(name, size, this._path, writer));
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x0600152B RID: 5419 RVA: 0x0003FD3F File Offset: 0x0003DF3F
		public global::System.Array ViewableArray
		{
			get
			{
				return new object[0];
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600152C RID: 5420 RVA: 0x0003FD47 File Offset: 0x0003DF47
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
				arrayList.Add(base.Property);
				arrayList.AddRange(this._entries);
				return arrayList.GetEnumerator();
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600152D RID: 5421 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool PreferArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x0600152E RID: 5422 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		public string ShortDescription
		{
			get
			{
				return base.Name;
			}
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x0003FA74 File Offset: 0x0003DC74
		public global::System.Collections.Generic.IEnumerator<global::NPOI.POIFS.FileSystem.Entry> GetEnumerator()
		{
			return this._entries.GetEnumerator();
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x0003FA74 File Offset: 0x0003DC74
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._entries.GetEnumerator();
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001531 RID: 5425 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool CanRead
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001532 RID: 5426 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool CanSeek
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000411 RID: 1041
		// (get) Token: 0x06001533 RID: 5427 RVA: 0x00008C75 File Offset: 0x00006E75
		public bool CanWrite
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00008C75 File Offset: 0x00006E75
		public void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000412 RID: 1042
		// (get) Token: 0x06001535 RID: 5429 RVA: 0x00008C75 File Offset: 0x00006E75
		public long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000413 RID: 1043
		// (get) Token: 0x06001536 RID: 5430 RVA: 0x00008C75 File Offset: 0x00006E75
		// (set) Token: 0x06001537 RID: 5431 RVA: 0x00008C75 File Offset: 0x00006E75
		public long Position
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06001538 RID: 5432 RVA: 0x00008C75 File Offset: 0x00006E75
		public int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x00008C75 File Offset: 0x00006E75
		public long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600153A RID: 5434 RVA: 0x00008C75 File Offset: 0x00006E75
		public void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000891 RID: 2193
		private global::System.Collections.Generic.Dictionary<string, global::NPOI.POIFS.FileSystem.Entry> _byname;

		// Token: 0x04000892 RID: 2194
		private global::System.Collections.Generic.List<global::NPOI.POIFS.FileSystem.Entry> _entries;

		// Token: 0x04000893 RID: 2195
		private global::NPOI.POIFS.FileSystem.OPOIFSFileSystem _oFilesSystem;

		// Token: 0x04000894 RID: 2196
		private global::NPOI.POIFS.FileSystem.NPOIFSFileSystem _nFilesSystem;

		// Token: 0x04000895 RID: 2197
		private global::NPOI.POIFS.FileSystem.POIFSDocumentPath _path;
	}
}
