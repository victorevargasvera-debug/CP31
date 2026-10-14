using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000142 RID: 322
	public class ShowCustomFilterDialogFilterMenuConditionalCommand : global::Infragistics.Controls.Grids.CellBaseCommandBase
	{
		// Token: 0x06000A83 RID: 2691 RVA: 0x000282F7 File Offset: 0x000264F7
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000A84 RID: 2692 RVA: 0x000282FC File Offset: 0x000264FC
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = parameter as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
			if (headerDropDownControl != null)
			{
				this.ExecuteCommand(headerDropDownControl.Cell);
				base.CommandSource.Handled = false;
				return;
			}
			base.Execute(parameter);
		}

		// Token: 0x06000A85 RID: 2693 RVA: 0x00028334 File Offset: 0x00026534
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.CellBase cell)
		{
			global::Infragistics.Controls.Grids.Primitives.CustomFilteringDialogFilterMenuCommandSource customFilteringDialogFilterMenuCommandSource = (global::Infragistics.Controls.Grids.Primitives.CustomFilteringDialogFilterMenuCommandSource)base.CommandSource;
			if (customFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter == null)
			{
				return;
			}
			if (customFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter.Count == 0)
			{
				return;
			}
			if (!customFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter[0].RequiresFilteringInput)
			{
				return;
			}
			global::Infragistics.Controls.Grids.XamGrid grid = cell.Row.ColumnLayout.Grid;
			grid.Panel.CustomFilterDialogControl.Cell = cell;
			grid.Panel.CustomFilterDialogControl.Show(customFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter);
			base.CommandSource.Handled = false;
		}
	}
}
