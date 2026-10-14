using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200012E RID: 302
	public abstract class SortingBaseCommand : global::Infragistics.Controls.Grids.ColumnCommandBase
	{
		// Token: 0x06000A09 RID: 2569 RVA: 0x00026CFC File Offset: 0x00024EFC
		public override bool CanExecute(object parameter)
		{
			global::Infragistics.Controls.Grids.Column column = parameter as global::Infragistics.Controls.Grids.Column;
			return column != null && column.IsSortable && column.ColumnLayout.SortingSettings.AllowSortingResolved;
		}

		// Token: 0x06000A0A RID: 2570 RVA: 0x00026D30 File Offset: 0x00024F30
		protected static void ExecuteCommandHelper(global::Infragistics.Controls.Grids.SortDirection sortDirection, global::Infragistics.Controls.Grids.Column col)
		{
			if (col.ColumnLayout.SortingSettings.MultiSortingKeyResolved == global::Infragistics.Controls.Grids.MultiSortingKey.Control)
			{
				global::System.Windows.Input.ModifierKeys currentModifierKeys = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
				bool multipleColumnSort = (currentModifierKeys & global::System.Windows.Input.ModifierKeys.Control) != global::System.Windows.Input.ModifierKeys.None;
				col.SetSortedColumnState(sortDirection, multipleColumnSort);
				return;
			}
			global::System.Windows.Input.ModifierKeys currentModifierKeys2 = global::Infragistics.Controls.PresentationUtilities.GetCurrentModifierKeys();
			bool multipleColumnSort2 = (currentModifierKeys2 & global::System.Windows.Input.ModifierKeys.Shift) != global::System.Windows.Input.ModifierKeys.None;
			col.SetSortedColumnState(sortDirection, multipleColumnSort2);
		}
	}
}
