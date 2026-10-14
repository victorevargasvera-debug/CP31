using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000DB RID: 219
	public abstract class StringValue : global::NPOI.XSSF.Streaming.Values.Value
	{
		// Token: 0x06000DE9 RID: 3561 RVA: 0x00006FBA File Offset: 0x000051BA
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.String;
		}

		// Token: 0x06000DEA RID: 3562
		public abstract bool IsRichText();
	}
}
