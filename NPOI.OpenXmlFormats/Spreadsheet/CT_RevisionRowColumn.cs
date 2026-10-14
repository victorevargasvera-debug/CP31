using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200056B RID: 1387
	public class CT_RevisionRowColumn
	{
		// Token: 0x06003C8D RID: 15501 RVA: 0x00093826 File Offset: 0x00091A26
		public CT_RevisionRowColumn()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.uaField = false;
			this.raField = false;
			this.eolField = false;
			this.edgeField = false;
		}

		// Token: 0x170016B3 RID: 5811
		// (get) Token: 0x06003C8E RID: 15502 RVA: 0x00093855 File Offset: 0x00091A55
		// (set) Token: 0x06003C8F RID: 15503 RVA: 0x0009385D File Offset: 0x00091A5D
		public global::System.Collections.Generic.List<object> Items
		{
			get
			{
				return this.itemsField;
			}
			set
			{
				this.itemsField = value;
			}
		}

		// Token: 0x170016B4 RID: 5812
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x00093866 File Offset: 0x00091A66
		// (set) Token: 0x06003C91 RID: 15505 RVA: 0x0009386E File Offset: 0x00091A6E
		public uint rId
		{
			get
			{
				return this.rIdField;
			}
			set
			{
				this.rIdField = value;
			}
		}

		// Token: 0x170016B5 RID: 5813
		// (get) Token: 0x06003C92 RID: 15506 RVA: 0x00093877 File Offset: 0x00091A77
		// (set) Token: 0x06003C93 RID: 15507 RVA: 0x0009387F File Offset: 0x00091A7F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ua
		{
			get
			{
				return this.uaField;
			}
			set
			{
				this.uaField = value;
			}
		}

		// Token: 0x170016B6 RID: 5814
		// (get) Token: 0x06003C94 RID: 15508 RVA: 0x00093888 File Offset: 0x00091A88
		// (set) Token: 0x06003C95 RID: 15509 RVA: 0x00093890 File Offset: 0x00091A90
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ra
		{
			get
			{
				return this.raField;
			}
			set
			{
				this.raField = value;
			}
		}

		// Token: 0x170016B7 RID: 5815
		// (get) Token: 0x06003C96 RID: 15510 RVA: 0x00093899 File Offset: 0x00091A99
		// (set) Token: 0x06003C97 RID: 15511 RVA: 0x000938A1 File Offset: 0x00091AA1
		public uint sId
		{
			get
			{
				return this.sIdField;
			}
			set
			{
				this.sIdField = value;
			}
		}

		// Token: 0x170016B8 RID: 5816
		// (get) Token: 0x06003C98 RID: 15512 RVA: 0x000938AA File Offset: 0x00091AAA
		// (set) Token: 0x06003C99 RID: 15513 RVA: 0x000938B2 File Offset: 0x00091AB2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool eol
		{
			get
			{
				return this.eolField;
			}
			set
			{
				this.eolField = value;
			}
		}

		// Token: 0x170016B9 RID: 5817
		// (get) Token: 0x06003C9A RID: 15514 RVA: 0x000938BB File Offset: 0x00091ABB
		// (set) Token: 0x06003C9B RID: 15515 RVA: 0x000938C3 File Offset: 0x00091AC3
		public string @ref
		{
			get
			{
				return this.refField;
			}
			set
			{
				this.refField = value;
			}
		}

		// Token: 0x170016BA RID: 5818
		// (get) Token: 0x06003C9C RID: 15516 RVA: 0x000938CC File Offset: 0x00091ACC
		// (set) Token: 0x06003C9D RID: 15517 RVA: 0x000938D4 File Offset: 0x00091AD4
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_rwColActionType action
		{
			get
			{
				return this.actionField;
			}
			set
			{
				this.actionField = value;
			}
		}

		// Token: 0x170016BB RID: 5819
		// (get) Token: 0x06003C9E RID: 15518 RVA: 0x000938DD File Offset: 0x00091ADD
		// (set) Token: 0x06003C9F RID: 15519 RVA: 0x000938E5 File Offset: 0x00091AE5
		[global::System.ComponentModel.DefaultValue(false)]
		public bool edge
		{
			get
			{
				return this.edgeField;
			}
			set
			{
				this.edgeField = value;
			}
		}

		// Token: 0x040026BB RID: 9915
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x040026BC RID: 9916
		private uint rIdField;

		// Token: 0x040026BD RID: 9917
		private bool uaField;

		// Token: 0x040026BE RID: 9918
		private bool raField;

		// Token: 0x040026BF RID: 9919
		private uint sIdField;

		// Token: 0x040026C0 RID: 9920
		private bool eolField;

		// Token: 0x040026C1 RID: 9921
		private string refField;

		// Token: 0x040026C2 RID: 9922
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_rwColActionType actionField;

		// Token: 0x040026C3 RID: 9923
		private bool edgeField;
	}
}
