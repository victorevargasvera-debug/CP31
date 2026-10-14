using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000082 RID: 130
	public class XSSFEvenHeader : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IHeader, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x060006C0 RID: 1728 RVA: 0x00017586 File Offset: 0x00015786
		public XSSFEvenHeader(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
			headerFooter.differentOddEven = true;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x060006C1 RID: 1729 RVA: 0x000175B1 File Offset: 0x000157B1
		// (set) Token: 0x060006C2 RID: 1730 RVA: 0x000175BE File Offset: 0x000157BE
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().evenHeader;
			}
			set
			{
				base.GetHeaderFooter().evenHeader = value;
			}
		}
	}
}
