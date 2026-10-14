using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000090 RID: 144
	public class XSSFOddHeader : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IHeader, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x0600076F RID: 1903 RVA: 0x000190C7 File Offset: 0x000172C7
		public XSSFOddHeader(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
		}

		// Token: 0x17000235 RID: 565
		// (get) Token: 0x06000770 RID: 1904 RVA: 0x000190EB File Offset: 0x000172EB
		// (set) Token: 0x06000771 RID: 1905 RVA: 0x000190F8 File Offset: 0x000172F8
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().oddHeader;
			}
			set
			{
				base.GetHeaderFooter().oddHeader = value;
			}
		}
	}
}
