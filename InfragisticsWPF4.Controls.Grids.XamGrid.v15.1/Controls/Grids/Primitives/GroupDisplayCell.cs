using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200021B RID: 539
	public class GroupDisplayCell : global::Infragistics.Controls.Grids.Cell
	{
		// Token: 0x06000F4C RID: 3916 RVA: 0x0003A683 File Offset: 0x00038883
		protected internal GroupDisplayCell(global::Infragistics.Controls.Grids.RowBase row, global::Infragistics.Controls.Grids.Column column) : base(row, column)
		{
		}

		// Token: 0x06000F4D RID: 3917 RVA: 0x0003A68D File Offset: 0x0003888D
		protected override global::Infragistics.Controls.Grids.Primitives.CellControlBase CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupDisplayCellControl();
		}

		// Token: 0x06000F4E RID: 3918 RVA: 0x0003A694 File Offset: 0x00038894
		protected internal override void OnCellDoubleClick()
		{
			this.ToggleOperator();
			base.OnCellDoubleClick();
		}

		// Token: 0x06000F4F RID: 3919 RVA: 0x0003A6A4 File Offset: 0x000388A4
		internal void ToggleOperator()
		{
			int num = 0;
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> dataColumns = base.Column.ColumnLayout.Columns.DataColumns;
			for (int i = 0; i < dataColumns.Count; i++)
			{
				if (dataColumns[i] is global::Infragistics.Controls.Grids.GroupDisplayColumn)
				{
					num++;
				}
			}
			int num2 = dataColumns.IndexOf(base.Column);
			for (global::Infragistics.Controls.Grids.XamGridConditionInfoGroup xamGridConditionInfoGroup = ((global::Infragistics.Controls.Grids.XamGridConditionInfo)base.Row.Data).Group; xamGridConditionInfoGroup != null; xamGridConditionInfoGroup = xamGridConditionInfoGroup.ParentGroup)
			{
				if (xamGridConditionInfoGroup.Level == num2)
				{
					if (xamGridConditionInfoGroup.Operator == global::Infragistics.LogicalOperator.Or)
					{
						xamGridConditionInfoGroup.Operator = global::Infragistics.LogicalOperator.And;
					}
					else
					{
						xamGridConditionInfoGroup.Operator = global::Infragistics.LogicalOperator.Or;
					}
					base.Row.ColumnLayout.Grid.InvalidateScrollPanel(false);
					return;
				}
			}
		}
	}
}
