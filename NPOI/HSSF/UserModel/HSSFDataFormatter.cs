using System;
using System.Globalization;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200035C RID: 860
	public class HSSFDataFormatter : global::NPOI.SS.UserModel.DataFormatter
	{
		// Token: 0x060019A0 RID: 6560 RVA: 0x0004E9FE File Offset: 0x0004CBFE
		public HSSFDataFormatter(global::System.Globalization.CultureInfo locale) : base(locale)
		{
		}

		// Token: 0x060019A1 RID: 6561 RVA: 0x0004EA07 File Offset: 0x0004CC07
		public HSSFDataFormatter() : this(global::System.Globalization.CultureInfo.CurrentCulture)
		{
		}
	}
}
