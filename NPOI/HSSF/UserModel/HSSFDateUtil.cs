using System;
using NPOI.SS.UserModel;

namespace NPOI.HSSF.UserModel
{
	// Token: 0x0200035F RID: 863
	public class HSSFDateUtil : global::NPOI.SS.UserModel.DateUtil
	{
		// Token: 0x060019C2 RID: 6594 RVA: 0x0004EC08 File Offset: 0x0004CE08
		public new static int AbsoluteDay(global::System.DateTime cal, bool use1904windowing)
		{
			return global::NPOI.SS.UserModel.DateUtil.AbsoluteDay(cal, use1904windowing);
		}
	}
}
