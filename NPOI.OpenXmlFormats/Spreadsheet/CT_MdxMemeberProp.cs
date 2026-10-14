using System;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005D9 RID: 1497
	public class CT_MdxMemeberProp
	{
		// Token: 0x170018D4 RID: 6356
		// (get) Token: 0x060041EF RID: 16879 RVA: 0x0009F03F File Offset: 0x0009D23F
		// (set) Token: 0x060041F0 RID: 16880 RVA: 0x0009F047 File Offset: 0x0009D247
		public uint n
		{
			get
			{
				return this.nField;
			}
			set
			{
				this.nField = value;
			}
		}

		// Token: 0x170018D5 RID: 6357
		// (get) Token: 0x060041F1 RID: 16881 RVA: 0x0009F050 File Offset: 0x0009D250
		// (set) Token: 0x060041F2 RID: 16882 RVA: 0x0009F058 File Offset: 0x0009D258
		public uint np
		{
			get
			{
				return this.npField;
			}
			set
			{
				this.npField = value;
			}
		}

		// Token: 0x04002985 RID: 10629
		private uint nField;

		// Token: 0x04002986 RID: 10630
		private uint npField;
	}
}
