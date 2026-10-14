using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055A RID: 1370
	public class CT_SheetId
	{
		// Token: 0x17001630 RID: 5680
		// (get) Token: 0x06003B78 RID: 15224 RVA: 0x00092D75 File Offset: 0x00090F75
		// (set) Token: 0x06003B79 RID: 15225 RVA: 0x00092D7D File Offset: 0x00090F7D
		public uint val
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

		// Token: 0x0400262F RID: 9775
		private uint valField;
	}
}
