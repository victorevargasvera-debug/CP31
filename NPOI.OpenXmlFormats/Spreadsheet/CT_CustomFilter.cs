using System;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000532 RID: 1330
	public class CT_CustomFilter
	{
		// Token: 0x06003A6D RID: 14957 RVA: 0x00090F44 File Offset: 0x0008F144
		public CT_CustomFilter()
		{
			this.operatorField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_FilterOperator.equal;
		}

		// Token: 0x170015D1 RID: 5585
		// (get) Token: 0x06003A6E RID: 14958 RVA: 0x00090F53 File Offset: 0x0008F153
		// (set) Token: 0x06003A6F RID: 14959 RVA: 0x00090F5B File Offset: 0x0008F15B
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_FilterOperator.equal)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_FilterOperator @operator
		{
			get
			{
				return this.operatorField;
			}
			set
			{
				this.operatorField = value;
			}
		}

		// Token: 0x170015D2 RID: 5586
		// (get) Token: 0x06003A70 RID: 14960 RVA: 0x00090F64 File Offset: 0x0008F164
		// (set) Token: 0x06003A71 RID: 14961 RVA: 0x00090F6C File Offset: 0x0008F16C
		public string val
		{
			get
			{
				return this.valField;
			}
			set
			{
				this.valField = value;
			}
		}

		// Token: 0x04002537 RID: 9527
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_FilterOperator operatorField;

		// Token: 0x04002538 RID: 9528
		private string valField;
	}
}
