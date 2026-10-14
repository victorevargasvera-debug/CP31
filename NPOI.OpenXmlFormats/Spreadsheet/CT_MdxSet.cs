using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005DA RID: 1498
	public class CT_MdxSet
	{
		// Token: 0x060041F4 RID: 16884 RVA: 0x0009F061 File Offset: 0x0009D261
		public CT_MdxSet()
		{
			this.nField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex>();
			this.cField = 0U;
			this.oField = global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxSetOrder.u;
		}

		// Token: 0x170018D6 RID: 6358
		// (get) Token: 0x060041F5 RID: 16885 RVA: 0x0009F082 File Offset: 0x0009D282
		// (set) Token: 0x060041F6 RID: 16886 RVA: 0x0009F08A File Offset: 0x0009D28A
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex> n
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

		// Token: 0x170018D7 RID: 6359
		// (get) Token: 0x060041F7 RID: 16887 RVA: 0x0009F093 File Offset: 0x0009D293
		// (set) Token: 0x060041F8 RID: 16888 RVA: 0x0009F09B File Offset: 0x0009D29B
		public uint ns
		{
			get
			{
				return this.nsField;
			}
			set
			{
				this.nsField = value;
			}
		}

		// Token: 0x170018D8 RID: 6360
		// (get) Token: 0x060041F9 RID: 16889 RVA: 0x0009F0A4 File Offset: 0x0009D2A4
		// (set) Token: 0x060041FA RID: 16890 RVA: 0x0009F0AC File Offset: 0x0009D2AC
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint c
		{
			get
			{
				return this.cField;
			}
			set
			{
				this.cField = value;
			}
		}

		// Token: 0x170018D9 RID: 6361
		// (get) Token: 0x060041FB RID: 16891 RVA: 0x0009F0B5 File Offset: 0x0009D2B5
		// (set) Token: 0x060041FC RID: 16892 RVA: 0x0009F0BD File Offset: 0x0009D2BD
		[global::System.ComponentModel.DefaultValue(global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxSetOrder.u)]
		public global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxSetOrder o
		{
			get
			{
				return this.oField;
			}
			set
			{
				this.oField = value;
			}
		}

		// Token: 0x04002987 RID: 10631
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_MetadataStringIndex> nField;

		// Token: 0x04002988 RID: 10632
		private uint nsField;

		// Token: 0x04002989 RID: 10633
		private uint cField;

		// Token: 0x0400298A RID: 10634
		private global::NPOI.OpenXmlFormats.Spreadsheet.ST_MdxSetOrder oField;
	}
}
