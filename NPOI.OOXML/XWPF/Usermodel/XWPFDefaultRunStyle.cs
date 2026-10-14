using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000033 RID: 51
	public class XWPFDefaultRunStyle
	{
		// Token: 0x06000161 RID: 353 RVA: 0x000057D5 File Offset: 0x000039D5
		public XWPFDefaultRunStyle(global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rpr)
		{
			this.rpr = rpr;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x000057E4 File Offset: 0x000039E4
		protected internal global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr GetRPr()
		{
			return this.rpr;
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000163 RID: 355 RVA: 0x000057EC File Offset: 0x000039EC
		public int FontSize
		{
			get
			{
				if (this.rpr.IsSetSz())
				{
					return (int)this.rpr.sz.val / 2;
				}
				return -1;
			}
		}

		// Token: 0x040001B3 RID: 435
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_RPr rpr;
	}
}
