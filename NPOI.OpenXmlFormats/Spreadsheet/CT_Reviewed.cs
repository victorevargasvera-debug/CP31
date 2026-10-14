using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x0200055C RID: 1372
	public class CT_Reviewed
	{
		// Token: 0x17001634 RID: 5684
		// (get) Token: 0x06003B82 RID: 15234 RVA: 0x00092DCC File Offset: 0x00090FCC
		// (set) Token: 0x06003B83 RID: 15235 RVA: 0x00092DD4 File Offset: 0x00090FD4
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

		// Token: 0x04002633 RID: 9779
		private uint rIdField;
	}
}
