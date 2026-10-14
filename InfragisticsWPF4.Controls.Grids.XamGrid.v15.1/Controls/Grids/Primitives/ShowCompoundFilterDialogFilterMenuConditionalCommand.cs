using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000144 RID: 324
	public class ShowCompoundFilterDialogFilterMenuConditionalCommand : global::Infragistics.Controls.Grids.CellBaseCommandBase
	{
		// Token: 0x06000A8C RID: 2700 RVA: 0x00028433 File Offset: 0x00026633
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000A8D RID: 2701 RVA: 0x00028438 File Offset: 0x00026638
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

		// Token: 0x06000A8E RID: 2702 RVA: 0x00028470 File Offset: 0x00026670
		protected override void ExecuteCommand(global::Infragistics.Controls.Grids.CellBase cell)
		{
			if (base.CommandSource != null && cell != null)
			{
				global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogFilterMenuCommandSource compoundFilteringDialogFilterMenuCommandSource = (global::Infragistics.Controls.Grids.Primitives.CompoundFilteringDialogFilterMenuCommandSource)base.CommandSource;
				if (compoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter == null)
				{
					return;
				}
				if (compoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter.Count == 0)
				{
					return;
				}
				if (!compoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter[0].RequiresFilteringInput)
				{
					return;
				}
				global::Infragistics.Controls.Grids.XamGrid grid = cell.Row.ColumnLayout.Grid;
				grid.Panel.CompoundFilterDialogControl.Cell = cell;
				grid.Panel.CompoundFilterDialogControl.Show(compoundFilteringDialogFilterMenuCommandSource.ConditionalCommandParameter);
				base.CommandSource.Handled = false;
			}
		}
	}
}
