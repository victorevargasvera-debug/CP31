using System;
using SourceGrid.Cells;

namespace SourceGrid.Conditions
{
	// Token: 0x02000405 RID: 1029
	internal class ConditionCell : global::SourceGrid.Conditions.ICondition
	{
		// Token: 0x06002D59 RID: 11609 RVA: 0x00098B40 File Offset: 0x00096D40
		public ConditionCell(global::SourceGrid.Cells.ICellVirtual cell)
		{
			this.mCell = cell;
		}

		// Token: 0x17000D3B RID: 3387
		// (get) Token: 0x06002D5A RID: 11610 RVA: 0x00098B50 File Offset: 0x00096D50
		public global::SourceGrid.Cells.ICellVirtual Cell
		{
			get
			{
				return this.mCell;
			}
		}

		// Token: 0x06002D5B RID: 11611 RVA: 0x00098B58 File Offset: 0x00096D58
		public bool Evaluate(global::SourceGrid.DataGridColumn column, int gridRow, object itemRow)
		{
			return this.EvaluateFunction != null && this.EvaluateFunction(column, gridRow, itemRow);
		}

		// Token: 0x06002D5C RID: 11612 RVA: 0x00098B78 File Offset: 0x00096D78
		public global::SourceGrid.Cells.ICellVirtual ApplyCondition(global::SourceGrid.Cells.ICellVirtual cell)
		{
			return this.Cell;
		}

		// Token: 0x04000F5D RID: 3933
		public global::SourceGrid.Conditions.ConditionCell.EvaluateFunctionDelegate EvaluateFunction;

		// Token: 0x04000F5E RID: 3934
		private global::SourceGrid.Cells.ICellVirtual mCell;

		// Token: 0x020004D8 RID: 1240
		// (Invoke) Token: 0x06003471 RID: 13425
		public delegate bool EvaluateFunctionDelegate(global::SourceGrid.DataGridColumn column, int gridRow, object itemRow);
	}
}
