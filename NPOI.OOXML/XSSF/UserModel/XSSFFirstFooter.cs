using System;
using NPOI.OpenXmlFormats.Spreadsheet;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel.Extensions;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000084 RID: 132
	public class XSSFFirstFooter : global::NPOI.XSSF.UserModel.Extensions.XSSFHeaderFooter, global::NPOI.SS.UserModel.IFooter, global::NPOI.SS.UserModel.IHeaderFooter
	{
		// Token: 0x060006C8 RID: 1736 RVA: 0x000175FB File Offset: 0x000157FB
		public XSSFFirstFooter(global::NPOI.OpenXmlFormats.Spreadsheet.CT_HeaderFooter headerFooter) : base(headerFooter)
		{
			headerFooter.differentFirst = true;
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x060006C9 RID: 1737 RVA: 0x0001760B File Offset: 0x0001580B
		// (set) Token: 0x060006CA RID: 1738 RVA: 0x00017618 File Offset: 0x00015818
		public override string Text
		{
			get
			{
				return base.GetHeaderFooter().firstFooter;
			}
			set
			{
				if (value == null)
				{
					base.GetHeaderFooter().firstFooter = null;
					return;
				}
				base.GetHeaderFooter().firstFooter = value;
			}
		}
	}
}
