using System;
using NPOI.OpenXmlFormats.Wordprocessing;

namespace NPOI.XWPF.UserModel
{
	// Token: 0x0200003F RID: 63
	public class XWPFNum
	{
		// Token: 0x06000234 RID: 564 RVA: 0x000083BC File Offset: 0x000065BC
		public XWPFNum()
		{
			this.ctNum = null;
			this.numbering = null;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x000083D2 File Offset: 0x000065D2
		public XWPFNum(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctNum)
		{
			this.ctNum = ctNum;
			this.numbering = null;
		}

		// Token: 0x06000236 RID: 566 RVA: 0x000083E8 File Offset: 0x000065E8
		public XWPFNum(global::NPOI.XWPF.UserModel.XWPFNumbering numbering)
		{
			this.ctNum = null;
			this.numbering = numbering;
		}

		// Token: 0x06000237 RID: 567 RVA: 0x000083FE File Offset: 0x000065FE
		public XWPFNum(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctNum, global::NPOI.XWPF.UserModel.XWPFNumbering numbering)
		{
			this.ctNum = ctNum;
			this.numbering = numbering;
		}

		// Token: 0x06000238 RID: 568 RVA: 0x00008414 File Offset: 0x00006614
		public global::NPOI.XWPF.UserModel.XWPFNumbering GetNumbering()
		{
			return this.numbering;
		}

		// Token: 0x06000239 RID: 569 RVA: 0x0000841C File Offset: 0x0000661C
		public global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num GetCTNum()
		{
			return this.ctNum;
		}

		// Token: 0x0600023A RID: 570 RVA: 0x00008424 File Offset: 0x00006624
		public void SetNumbering(global::NPOI.XWPF.UserModel.XWPFNumbering numbering)
		{
			this.numbering = numbering;
		}

		// Token: 0x0600023B RID: 571 RVA: 0x0000842D File Offset: 0x0000662D
		public void SetCTNum(global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctNum)
		{
			this.ctNum = ctNum;
		}

		// Token: 0x040001DE RID: 478
		private global::NPOI.OpenXmlFormats.Wordprocessing.CT_Num ctNum;

		// Token: 0x040001DF RID: 479
		protected global::NPOI.XWPF.UserModel.XWPFNumbering numbering;
	}
}
