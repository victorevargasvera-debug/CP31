using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000563 RID: 1379
	public class CT_RevisionCustomView
	{
		// Token: 0x1700166A RID: 5738
		// (get) Token: 0x06003BF4 RID: 15348 RVA: 0x0009325E File Offset: 0x0009145E
		// (set) Token: 0x06003BF5 RID: 15349 RVA: 0x00093266 File Offset: 0x00091466
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

		// Token: 0x1700166B RID: 5739
		// (get) Token: 0x06003BF6 RID: 15350 RVA: 0x0009326F File Offset: 0x0009146F
		// (set) Token: 0x06003BF7 RID: 15351 RVA: 0x00093277 File Offset: 0x00091477
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction action
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

		// Token: 0x0400266C RID: 9836
		private string guidField;

		// Token: 0x0400266D RID: 9837
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_RevisionAction actionField;
	}
}
