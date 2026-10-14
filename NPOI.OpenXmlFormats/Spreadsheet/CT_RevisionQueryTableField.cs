using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200056A RID: 1386
	public class CT_RevisionQueryTableField
	{
		// Token: 0x170016B0 RID: 5808
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x000937F3 File Offset: 0x000919F3
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x000937FB File Offset: 0x000919FB
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

		// Token: 0x170016B1 RID: 5809
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x00093804 File Offset: 0x00091A04
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x0009380C File Offset: 0x00091A0C
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

		// Token: 0x170016B2 RID: 5810
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x00093815 File Offset: 0x00091A15
		// (set) Token: 0x06003C8B RID: 15499 RVA: 0x0009381D File Offset: 0x00091A1D
		public uint fieldId
		{
			get
			{
				return this.fieldIdField;
			}
			set
			{
				this.fieldIdField = value;
			}
		}

		// Token: 0x040026B8 RID: 9912
		private uint sheetIdField;

		// Token: 0x040026B9 RID: 9913
		private string refField;

		// Token: 0x040026BA RID: 9914
		private uint fieldIdField;
	}
}
