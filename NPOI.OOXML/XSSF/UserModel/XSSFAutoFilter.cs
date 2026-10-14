using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.UserModel
{
	// Token: 0x02000067 RID: 103
	public class XSSFAutoFilter : global::NPOI.SS.UserModel.IAutoFilter
	{
		// Token: 0x06000444 RID: 1092 RVA: 0x00010D41 File Offset: 0x0000EF41
		public XSSFAutoFilter(global::NPOI.XSSF.UserModel.XSSFSheet sheet)
		{
			this._sheet = sheet;
		}

		// Token: 0x04000294 RID: 660
		private global::NPOI.XSSF.UserModel.XSSFSheet _sheet;
	}
}
