using System;
using NPOI.SS.UserModel;

namespace NPOI.XSSF.Streaming.Values
{
	// Token: 0x020000D2 RID: 210
	public class BooleanValue : global::NPOI.XSSF.Streaming.Values.Value
	{
		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06000DD3 RID: 3539 RVA: 0x00030300 File Offset: 0x0002E500
		// (set) Token: 0x06000DD4 RID: 3540 RVA: 0x00030308 File Offset: 0x0002E508
		public bool Value { get; set; }

		// Token: 0x06000DD5 RID: 3541 RVA: 0x00007725 File Offset: 0x00005925
		public new global::NPOI.SS.UserModel.CellType GetType()
		{
			return global::NPOI.SS.UserModel.CellType.Boolean;
		}
	}
}
