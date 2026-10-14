using System;
using System.Drawing;
using SourceGrid.Cells.Views;

namespace SourceGrid.Conditions
{
	// Token: 0x020003F1 RID: 1009
	internal static class ConditionBuilder
	{
		// Token: 0x06002CCB RID: 11467 RVA: 0x00096790 File Offset: 0x00094990
		public static global::SourceGrid.Conditions.ICondition AlternateView(global::SourceGrid.Cells.Views.IView view, global::System.Drawing.Color alternateBackcolor, global::System.Drawing.Color alternateForecolor)
		{
			global::SourceGrid.Cells.Views.IView view2 = (global::SourceGrid.Cells.Views.IView)view.Clone();
			view2.BackColor = alternateBackcolor;
			view2.ForeColor = alternateForecolor;
			global::SourceGrid.Conditions.ConditionView conditionView = new global::SourceGrid.Conditions.ConditionView(view2);
			conditionView.EvaluateFunction = ((global::SourceGrid.DataGridColumn column, int gridRow, object itemRow) => (gridRow & 1) == 1);
			return conditionView;
		}
	}
}
