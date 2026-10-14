using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x0200008F RID: 143
	public class XSSFOddFooter : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IFooter, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x000190C7 File Offset: 0x000172C7
		public XSSFOddFooter(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
		}

		// Token: 0x17000234 RID: 564
		// (get) Token: 0x0600076D RID: 1901 RVA: 0x000190D0 File Offset: 0x000172D0
		// (set) Token: 0x0600076E RID: 1902 RVA: 0x000190DD File Offset: 0x000172DD
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().oddFooter;
			}
			set
			{
				base.GetHeaderFooter().oddFooter = value;
			}
		}
	}
}
