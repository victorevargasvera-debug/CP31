using System;
using SourceGrid.Cells;

namespace SourceGrid.Conditions
{
	// Token: 0x020003EF RID: 1007
	internal interface ICondition
	{
		// Token: 0x06002CC5 RID: 11461
		bool Evaluate(global::SourceGrid.DataGridColumn column, int gridRow, object itemRow);

		// Token: 0x06002CC6 RID: 11462
		global::SourceGrid.Cells.ICellVirtual ApplyCondition(global::SourceGrid.Cells.ICellVirtual cell);
	}
}
