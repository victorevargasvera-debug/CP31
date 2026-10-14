using System;
using SourceGrid.Cells;
using SourceGrid.Cells.Views;

namespace SourceGrid.Conditions
{
	// Token: 0x020003F0 RID: 1008
	internal class ConditionView : global::SourceGrid.Conditions.ICondition
	{
		// Token: 0x06002CC7 RID: 11463 RVA: 0x00096730 File Offset: 0x00094930
		public ConditionView(global::SourceGrid.Cells.Views.IView view)
		{
			this.mView = view;
		}

		// Token: 0x17000D14 RID: 3348
		// (get) Token: 0x06002CC8 RID: 11464 RVA: 0x00096740 File Offset: 0x00094940
		public global::SourceGrid.Cells.Views.IView View
		{
			get
			{
				return this.mView;
			}
		}

		// Token: 0x06002CC9 RID: 11465 RVA: 0x00096748 File Offset: 0x00094948
		public bool Evaluate(global::SourceGrid.DataGridColumn column, int gridRow, object itemRow)
		{
			return this.EvaluateFunction != null && this.EvaluateFunction(column, gridRow, itemRow);
		}

		// Token: 0x06002CCA RID: 11466 RVA: 0x00096768 File Offset: 0x00094968
		public global::SourceGrid.Cells.ICellVirtual ApplyCondition(global::SourceGrid.Cells.ICellVirtual cell)
		{
			global::SourceGrid.Cells.ICellVirtual cellVirtual = cell.Copy();
			cellVirtual.View = this.View;
			return cellVirtual;
		}

		// Token: 0x04000F31 RID: 3889
		public global::SourceGrid.Conditions.ConditionView.EvaluateFunctionDelegate EvaluateFunction;

		// Token: 0x04000F32 RID: 3890
		private global::SourceGrid.Cells.Views.IView mView;

		// Token: 0x020004D5 RID: 1237
		// (Invoke) Token: 0x06003466 RID: 13414
		public delegate bool EvaluateFunctionDelegate(global::SourceGrid.DataGridColumn column, int gridRow, object itemRow);
	}
}
