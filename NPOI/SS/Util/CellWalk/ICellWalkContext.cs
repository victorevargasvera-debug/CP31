using System;

namespace NPOI.SS.Util.CellWalk
{
	// Token: 0x02000032 RID: 50
	public interface ICellWalkContext
	{
		// Token: 0x1700005C RID: 92
		// (get) Token: 0x060001E9 RID: 489
		long OrdinalNumber { get; }

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x060001EA RID: 490
		int RowNumber { get; }

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x060001EB RID: 491
		int ColumnNumber { get; }
	}
}
