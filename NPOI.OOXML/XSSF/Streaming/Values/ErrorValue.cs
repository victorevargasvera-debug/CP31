using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D4 RID: 212
	public class ErrorValue : global::NPOI.XSSF.Streaming.Values.Value
	{
		// Token: 0x06000DD9 RID: 3545 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.Error;
		}

		// Token: 0x0400040B RID: 1035
		public byte Value;
	}
}
