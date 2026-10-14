using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200056F RID: 1391
	public class CT_SharedUser
	{
		// Token: 0x06003CB6 RID: 15542 RVA: 0x000939CC File Offset: 0x00091BCC
		public CT_SharedUser()
		{
			this.extLstField = new global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList();
		}

		// Token: 0x170016C6 RID: 5830
		// (get) Token: 0x06003CB7 RID: 15543 RVA: 0x000939DF File Offset: 0x00091BDF
		// (set) Token: 0x06003CB8 RID: 15544 RVA: 0x000939E7 File Offset: 0x00091BE7
		public global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLst
		{
			get
			{
				return this.extLstField;
			}
			set
			{
				this.extLstField = value;
			}
		}

		// Token: 0x170016C7 RID: 5831
		// (get) Token: 0x06003CB9 RID: 15545 RVA: 0x000939F0 File Offset: 0x00091BF0
		// (set) Token: 0x06003CBA RID: 15546 RVA: 0x000939F8 File Offset: 0x00091BF8
		public string guid
		{
			get
			{
				return this.guidField;
			}
			set
			{
				this.guidField = value;
			}
		}

		// Token: 0x170016C8 RID: 5832
		// (get) Token: 0x06003CBB RID: 15547 RVA: 0x00093A01 File Offset: 0x00091C01
		// (set) Token: 0x06003CBC RID: 15548 RVA: 0x00093A09 File Offset: 0x00091C09
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

		// Token: 0x170016C9 RID: 5833
		// (get) Token: 0x06003CBD RID: 15549 RVA: 0x00093A12 File Offset: 0x00091C12
		// (set) Token: 0x06003CBE RID: 15550 RVA: 0x00093A1A File Offset: 0x00091C1A
		public int id
		{
			get
			{
				return this.idField;
			}
			set
			{
				this.idField = value;
			}
		}

		// Token: 0x170016CA RID: 5834
		// (get) Token: 0x06003CBF RID: 15551 RVA: 0x00093A23 File Offset: 0x00091C23
		// (set) Token: 0x06003CC0 RID: 15552 RVA: 0x00093A2B File Offset: 0x00091C2B
		public global::System.DateTime dateTime
		{
			get
			{
				return this.dateTimeField;
			}
			set
			{
				this.dateTimeField = value;
			}
		}

		// Token: 0x040026D3 RID: 9939
		private global::NPOI.OpenXmlFormats.Spreadsheet.CT_ExtensionList extLstField;

		// Token: 0x040026D4 RID: 9940
		private string guidField;

		// Token: 0x040026D5 RID: 9941
		private string nameField;

		// Token: 0x040026D6 RID: 9942
		private int idField;

		// Token: 0x040026D7 RID: 9943
		private global::System.DateTime dateTimeField;
	}
}
