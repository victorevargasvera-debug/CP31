using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000126 RID: 294
	public class SelectColumnCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x060009B7 RID: 2487 RVA: 0x00025D2A File Offset: 0x00023F2A
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.Column col)
		{
			col.ColumnLayout.Grid.SelectColumn(col, global::Infragistics.Controls.Grids.InvokeAction.Click);
		}

		// Token: 0x060009B8 RID: 2488 RVA: 0x00025D40 File Offset: 0x00023F40
		public override bool CanExecute(object parameter)
		{
			bool flag = base.CanExecute(parameter);
			global::Infragistics.Controls.Grids.Column column = parameter as global::Infragistics.Controls.Grids.Column;
			if (column != null)
			{
				flag &= (column.ColumnLayout.Grid.SelectionSettings.ColumnSelection != global::Infragistics.Controls.Grids.SelectionType.None);
				column.ColumnLayout.Grid.Panel.InvalidateMeasure();
			}
			return flag;
		}
	}
}
