using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x02000542 RID: 1346
	public class ST_UnsignedshortHex
	{
		// Token: 0x17001600 RID: 5632
		// (get) Token: 0x06003AD8 RID: 15064 RVA: 0x00091753 File Offset: 0x0008F953
		// (set) Token: 0x06003AD9 RID: 15065 RVA: 0x0009175B File Offset: 0x0008F95B
		public string StringValue
		{
			get
			{
				return this.stringValueField;
			}
			set
			{
				this.stringValueField = value;
			}
		}

		// Token: 0x06003ADA RID: 15066 RVA: 0x000024E5 File Offset: 0x000006E5
		public byte[] ToBytes()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040025B7 RID: 9655
		private string stringValueField;
	}
}
