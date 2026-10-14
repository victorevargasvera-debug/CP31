using System;
using System.Collections.Generic;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003E RID: 62
	public class XWPFLatentStyles
	{
		// Token: 0x0600022F RID: 559 RVA: 0x00002FA4 File Offset: 0x000011A4
		protected XWPFLatentStyles()
		{
		}

		// Token: 0x06000230 RID: 560 RVA: 0x00008328 File Offset: 0x00006528
		public XWPFLatentStyles(global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles latentStyles) : this(latentStyles, null)
		{
		}

		// Token: 0x06000231 RID: 561 RVA: 0x00008332 File Offset: 0x00006532
		public XWPFLatentStyles(global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles latentStyles, global::NPOI.XWPF.UserModel.XWPFStyles styles)
		{
			this.latentStyles = latentStyles;
			this.styles = styles;
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x06000232 RID: 562 RVA: 0x00008348 File Offset: 0x00006548
		public int NumberOfStyles
		{
			get
			{
				return this.latentStyles.SizeOfLsdExceptionArray();
			}
		}

		// Token: 0x06000233 RID: 563 RVA: 0x00008358 File Offset: 0x00006558
		public bool IsLatentStyle(string latentStyleID)
		{
			using (global::System.Collections.Generic.List<global::NPOI.OpenXmlFormats.Wordprocessing.CT_LsdException>.Enumerator enumerator = this.latentStyles.lsdException.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					if (enumerator.Current.name.Equals(latentStyleID))
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040001DC RID: 476
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_LatentStyles latentStyles;

		// Token: 0x040001DD RID: 477
		protected global::NPOI.XWPF.UserModel.XWPFStyles styles;
	}
}
