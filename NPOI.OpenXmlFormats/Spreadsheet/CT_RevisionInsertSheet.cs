using System;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000566 RID: 1382
	public class CT_RevisionInsertSheet
	{
		// Token: 0x06003C4F RID: 15439 RVA: 0x000935D0 File Offset: 0x000917D0
		public CT_RevisionInsertSheet()
		{
			this.uaField = false;
			this.raField = false;
		}

		// Token: 0x17001696 RID: 5782
		// (get) Token: 0x06003C50 RID: 15440 RVA: 0x000935E6 File Offset: 0x000917E6
		// (set) Token: 0x06003C51 RID: 15441 RVA: 0x000935EE File Offset: 0x000917EE
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

		// Token: 0x17001697 RID: 5783
		// (get) Token: 0x06003C52 RID: 15442 RVA: 0x000935F7 File Offset: 0x000917F7
		// (set) Token: 0x06003C53 RID: 15443 RVA: 0x000935FF File Offset: 0x000917FF
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

		// Token: 0x17001698 RID: 5784
		// (get) Token: 0x06003C54 RID: 15444 RVA: 0x00093608 File Offset: 0x00091808
		// (set) Token: 0x06003C55 RID: 15445 RVA: 0x00093610 File Offset: 0x00091810
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

		// Token: 0x17001699 RID: 5785
		// (get) Token: 0x06003C56 RID: 15446 RVA: 0x00093619 File Offset: 0x00091819
		// (set) Token: 0x06003C57 RID: 15447 RVA: 0x00093621 File Offset: 0x00091821
		public uint sheetId
		{
			get
			{
				return this.sheetIdField;
			}
			set
			{
				this.sheetIdField = value;
			}
		}

		// Token: 0x1700169A RID: 5786
		// (get) Token: 0x06003C58 RID: 15448 RVA: 0x0009362A File Offset: 0x0009182A
		// (set) Token: 0x06003C59 RID: 15449 RVA: 0x00093632 File Offset: 0x00091832
		public string name
		{
			get
			{
				return this.nameField;
			}
			set
			{
				this.nameField = value;
			}
		}

		// Token: 0x1700169B RID: 5787
		// (get) Token: 0x06003C5A RID: 15450 RVA: 0x0009363B File Offset: 0x0009183B
		// (set) Token: 0x06003C5B RID: 15451 RVA: 0x00093643 File Offset: 0x00091843
		public uint sheetPosition
		{
			get
			{
				return this.sheetPositionField;
			}
			set
			{
				this.sheetPositionField = value;
			}
		}

		// Token: 0x04002698 RID: 9880
		private uint rIdField;

		// Token: 0x04002699 RID: 9881
		private bool uaField;

		// Token: 0x0400269A RID: 9882
		private bool raField;

		// Token: 0x0400269B RID: 9883
		private uint sheetIdField;

		// Token: 0x0400269C RID: 9884
		private string nameField;

		// Token: 0x0400269D RID: 9885
		private uint sheetPositionField;
	}
}
