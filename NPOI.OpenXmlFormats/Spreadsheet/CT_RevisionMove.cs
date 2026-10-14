using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000567 RID: 1383
	public class CT_RevisionMove
	{
		// Token: 0x06003C5C RID: 15452 RVA: 0x0009364C File Offset: 0x0009184C
		public CT_RevisionMove()
		{
			this.itemsField = new global::System.Collections.Generic.List<object>();
			this.uaField = false;
			this.raField = false;
			this.sourceSheetIdField = 0U;
		}

		// Token: 0x1700169C RID: 5788
		// (get) Token: 0x06003C5D RID: 15453 RVA: 0x00093674 File Offset: 0x00091874
		// (set) Token: 0x06003C5E RID: 15454 RVA: 0x0009367C File Offset: 0x0009187C
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

		// Token: 0x1700169D RID: 5789
		// (get) Token: 0x06003C5F RID: 15455 RVA: 0x00093685 File Offset: 0x00091885
		// (set) Token: 0x06003C60 RID: 15456 RVA: 0x0009368D File Offset: 0x0009188D
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

		// Token: 0x1700169E RID: 5790
		// (get) Token: 0x06003C61 RID: 15457 RVA: 0x00093696 File Offset: 0x00091896
		// (set) Token: 0x06003C62 RID: 15458 RVA: 0x0009369E File Offset: 0x0009189E
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

		// Token: 0x1700169F RID: 5791
		// (get) Token: 0x06003C63 RID: 15459 RVA: 0x000936A7 File Offset: 0x000918A7
		// (set) Token: 0x06003C64 RID: 15460 RVA: 0x000936AF File Offset: 0x000918AF
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

		// Token: 0x170016A0 RID: 5792
		// (get) Token: 0x06003C65 RID: 15461 RVA: 0x000936B8 File Offset: 0x000918B8
		// (set) Token: 0x06003C66 RID: 15462 RVA: 0x000936C0 File Offset: 0x000918C0
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

		// Token: 0x170016A1 RID: 5793
		// (get) Token: 0x06003C67 RID: 15463 RVA: 0x000936C9 File Offset: 0x000918C9
		// (set) Token: 0x06003C68 RID: 15464 RVA: 0x000936D1 File Offset: 0x000918D1
		public string source
		{
			get
			{
				return this.sourceField;
			}
			set
			{
				this.sourceField = value;
			}
		}

		// Token: 0x170016A2 RID: 5794
		// (get) Token: 0x06003C69 RID: 15465 RVA: 0x000936DA File Offset: 0x000918DA
		// (set) Token: 0x06003C6A RID: 15466 RVA: 0x000936E2 File Offset: 0x000918E2
		public string destination
		{
			get
			{
				return this.destinationField;
			}
			set
			{
				this.destinationField = value;
			}
		}

		// Token: 0x170016A3 RID: 5795
		// (get) Token: 0x06003C6B RID: 15467 RVA: 0x000936EB File Offset: 0x000918EB
		// (set) Token: 0x06003C6C RID: 15468 RVA: 0x000936F3 File Offset: 0x000918F3
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint sourceSheetId
		{
			get
			{
				return this.sourceSheetIdField;
			}
			set
			{
				this.sourceSheetIdField = value;
			}
		}

		// Token: 0x0400269E RID: 9886
		private global::System.Collections.Generic.List<object> itemsField;

		// Token: 0x0400269F RID: 9887
		private uint rIdField;

		// Token: 0x040026A0 RID: 9888
		private bool uaField;

		// Token: 0x040026A1 RID: 9889
		private bool raField;

		// Token: 0x040026A2 RID: 9890
		private uint sheetIdField;

		// Token: 0x040026A3 RID: 9891
		private string sourceField;

		// Token: 0x040026A4 RID: 9892
		private string destinationField;

		// Token: 0x040026A5 RID: 9893
		private uint sourceSheetIdField;
	}
}
