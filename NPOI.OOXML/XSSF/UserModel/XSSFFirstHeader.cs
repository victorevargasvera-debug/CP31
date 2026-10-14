using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000085 RID: 133
	public class XSSFFirstHeader : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IHeader, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x060006CB RID: 1739 RVA: 0x000175FB File Offset: 0x000157FB
		public XSSFFirstHeader(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
			headerFooter.differentFirst = true;
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x060006CC RID: 1740 RVA: 0x00017636 File Offset: 0x00015836
		// (set) Token: 0x060006CD RID: 1741 RVA: 0x00017643 File Offset: 0x00015843
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().firstHeader;
			}
			set
			{
				if (value == null)
				{
					base.GetHeaderFooter().firstHeader = null;
					return;
				}
				base.GetHeaderFooter().firstHeader = value;
			}
		}
	}
}
