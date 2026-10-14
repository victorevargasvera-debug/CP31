using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000545 RID: 1349
	public class CT_XStringElement
	{
		// Token: 0x17001608 RID: 5640
		// (get) Token: 0x06003AF0 RID: 15088 RVA: 0x00091B50 File Offset: 0x0008FD50
		// (set) Token: 0x06003AF1 RID: 15089 RVA: 0x00091B58 File Offset: 0x0008FD58
		public string v
		{
			get
			{
				return this.vField;
			}
			set
			{
				this.vField = value;
			}
		}

		// Token: 0x040025C1 RID: 9665
		private string vField;
	}
}
