using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x02000032 RID: 50
	public class XWPFDefaultParagraphStyle
	{
		// Token: 0x0600015E RID: 350 RVA: 0x00005789 File Offset: 0x00003989
		public XWPFDefaultParagraphStyle(global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ppr)
		{
			this.ppr = ppr;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005798 File Offset: 0x00003998
		protected internal global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr GetPPr()
		{
			return this.ppr;
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000160 RID: 352 RVA: 0x000057A0 File Offset: 0x000039A0
		public int SpacingAfter
		{
			get
			{
				if (this.ppr.IsSetSpacing())
				{
					return (int)this.ppr.spacing.after.Value;
				}
				return -1;
			}
		}

		// Token: 0x040001B2 RID: 434
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_PPr ppr;
	}
}
