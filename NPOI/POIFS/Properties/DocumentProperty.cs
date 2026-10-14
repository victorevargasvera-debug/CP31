using System;
using NPOI.POIFS.FileSystem;

namespace NPOI.POIFS.Properties
{
	// Token: 0x020002BB RID: 699
	public class DocumentProperty : global::NPOI.POIFS.Properties.Property
	{
		// Token: 0x06001345 RID: 4933 RVA: 0x00039FC8 File Offset: 0x000381C8
		public DocumentProperty(string name, int size)
		{
			this._document = null;
			base.Name = name;
			this.Size = size;
			base.NodeColor = 1;
			base.PropertyType = 2;
		}

		// Token: 0x06001346 RID: 4934 RVA: 0x00039FF3 File Offset: 0x000381F3
		public DocumentProperty(int index, byte[] array, int offset) : base(index, array, offset)
		{
			this._document = null;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001348 RID: 4936 RVA: 0x0003A00E File Offset: 0x0003820E
		// (set) Token: 0x06001347 RID: 4935 RVA: 0x0003A005 File Offset: 0x00038205
		public global::NPOI.POIFS.FileSystem.OPOIFSDocument Document
		{
			get
			{
				return this._document;
			}
			set
			{
				this._document = value;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001349 RID: 4937 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool IsDirectory
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600134A RID: 4938 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void PreWrite()
		{
		}

		// Token: 0x0600134B RID: 4939 RVA: 0x0003A016 File Offset: 0x00038216
		public void UpdateSize(int size)
		{
			this.Size = size;
		}

		// Token: 0x040007F4 RID: 2036
		private global::NPOI.POIFS.FileSystem.OPOIFSDocument _document;
	}
}
