using System;

namespace NPOI.SS.UserModel
{
	// Token: 0x02000049 RID: 73
	public class BorderStyleEnum
	{
		// Token: 0x06000299 RID: 665 RVA: 0x0000ADA6 File Offset: 0x00008FA6
		public static global::NPOI.SS.UserModel.BorderStyle[] Values()
		{
			return global::NPOI.SS.UserModel.BorderStyleEnum._table;
		}

		// Token: 0x0600029A RID: 666 RVA: 0x0000ADB0 File Offset: 0x00008FB0
		static BorderStyleEnum()
		{
			foreach (object obj in global::System.Enum.GetValues(typeof(global::NPOI.SS.UserModel.BorderStyle)))
			{
				global::NPOI.SS.UserModel.BorderStyle borderStyle = (global::NPOI.SS.UserModel.BorderStyle)obj;
				global::NPOI.SS.UserModel.BorderStyleEnum._table[(int)borderStyle] = borderStyle;
			}
		}

		// Token: 0x0600029B RID: 667 RVA: 0x0000AE20 File Offset: 0x00009020
		public static global::NPOI.SS.UserModel.BorderStyle ValueOf(short code)
		{
			return global::NPOI.SS.UserModel.BorderStyleEnum._table[(int)code];
		}

		// Token: 0x0400015D RID: 349
		private static global::NPOI.SS.UserModel.BorderStyle[] _table = new global::NPOI.SS.UserModel.BorderStyle[14];
	}
}
