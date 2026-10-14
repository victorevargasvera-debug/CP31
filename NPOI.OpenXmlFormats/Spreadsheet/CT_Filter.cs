using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000537 RID: 1335
	public class CT_Filter
	{
		// Token: 0x170015DC RID: 5596
		// (get) Token: 0x06003A86 RID: 14982 RVA: 0x0009103A File Offset: 0x0008F23A
		// (set) Token: 0x06003A87 RID: 14983 RVA: 0x00091042 File Offset: 0x0008F242
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

		// Token: 0x0400256D RID: 9581
		private string valField;
	}
}
