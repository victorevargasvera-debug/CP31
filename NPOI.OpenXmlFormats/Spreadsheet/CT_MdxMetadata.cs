using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace NPOI.OpenXmlFormats.Spreadsheet
{
	// Token: 0x020005E0 RID: 1504
	public class CT_MdxMetadata
	{
		// Token: 0x06004224 RID: 16932 RVA: 0x0009F23D File Offset: 0x0009D43D
		public CT_MdxMetadata()
		{
			this.mdxField = new global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Mdx>();
			this.countField = 0U;
		}

		// Token: 0x170018EC RID: 6380
		// (get) Token: 0x06004225 RID: 16933 RVA: 0x0009F257 File Offset: 0x0009D457
		// (set) Token: 0x06004226 RID: 16934 RVA: 0x0009F25F File Offset: 0x0009D45F
		public global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Mdx> mdx
		{
			get
			{
				return this.mdxField;
			}
			set
			{
				this.mdxField = value;
			}
		}

		// Token: 0x170018ED RID: 6381
		// (get) Token: 0x06004227 RID: 16935 RVA: 0x0009F268 File Offset: 0x0009D468
		// (set) Token: 0x06004228 RID: 16936 RVA: 0x0009F270 File Offset: 0x0009D470
		[global::System.ComponentModel.DefaultValue(typeof(uint), "0")]
		public uint count
		{
			get
			{
				return this.countField;
			}
			set
			{
				this.countField = value;
			}
		}

		// Token: 0x040029AD RID: 10669
		private global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Spreadsheet.CT_Mdx> mdxField;

		// Token: 0x040029AE RID: 10670
		private uint countField;
	}
}
