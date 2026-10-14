using System;
using System.Collections;
using NPOI.POIFS.Dev;
using NPOI.POIFS.Properties;

namespace NPOI.POIFS.FileSystem
{
	// Token: 0x020002E8 RID: 744
	public class DocumentNode : global::NPOI.POIFS.FileSystem.EntryNode, global::NPOI.POIFS.Dev.POIFSViewable, global::NPOI.POIFS.FileSystem.DocumentEntry, global::NPOI.POIFS.FileSystem.Entry
	{
		// Token: 0x06001542 RID: 5442 RVA: 0x0003FED1 File Offset: 0x0003E0D1
		public DocumentNode(global::NPOI.POIFS.Properties.DocumentProperty property, global::NPOI.POIFS.FileSystem.DirectoryNode parent) : base(property, parent)
		{
			this._document = property.Document;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0003FEE7 File Offset: 0x0003E0E7
		public global::NPOI.POIFS.FileSystem.OPOIFSDocument Document
		{
			get
			{
				return this._document;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0003FEEF File Offset: 0x0003E0EF
		public int Size
		{
			get
			{
				return base.Property.Size;
			}
		}

		// Token: 0x17000419 RID: 1049
		// (get) Token: 0x06001545 RID: 5445 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool IsDocumentEntry
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700041A RID: 1050
		// (get) Token: 0x06001546 RID: 5446 RVA: 0x00008875 File Offset: 0x00006A75
		protected override bool IsDeleteOK
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001547 RID: 5447 RVA: 0x0003FD3F File Offset: 0x0003DF3F
		public global::System.Array ViewableArray
		{
			get
			{
				return new object[0];
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x0003FEFC File Offset: 0x0003E0FC
		public global::System.Collections.IEnumerator ViewableIterator
		{
			get
			{
				return ((global::System.Collections.IEnumerable)new global::System.Collections.ArrayList
				{
					base.Property,
					this._document
				}).GetEnumerator();
			}
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001549 RID: 5449 RVA: 0x00006EB4 File Offset: 0x000050B4
		public bool PreferArray
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x0600154A RID: 5450 RVA: 0x0003FD6C File Offset: 0x0003DF6C
		public string ShortDescription
		{
			get
			{
				return base.Name;
			}
		}

		// Token: 0x04000899 RID: 2201
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument _document;
	}
}
