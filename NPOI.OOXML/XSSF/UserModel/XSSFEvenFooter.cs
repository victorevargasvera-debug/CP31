using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000081 RID: 129
	public class XSSFEvenFooter : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IFooter, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x060006BD RID: 1725 RVA: 0x00017586 File Offset: 0x00015786
		public XSSFEvenFooter(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
			headerFooter.differentOddEven = true;
		}

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x060006BE RID: 1726 RVA: 0x00017596 File Offset: 0x00015796
		// (set) Token: 0x060006BF RID: 1727 RVA: 0x000175A3 File Offset: 0x000157A3
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().evenFooter;
			}
			set
			{
				base.GetHeaderFooter().evenFooter = value;
			}
		}
	}
}
