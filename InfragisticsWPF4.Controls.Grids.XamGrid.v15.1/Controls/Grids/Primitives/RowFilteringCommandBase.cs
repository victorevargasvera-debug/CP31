using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000C0 RID: 192
	public abstract class RowFilteringCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0001D9B9 File Offset: 0x0001BBB9
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001D9BC File Offset: 0x0001BBBC
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell = parameter as global::Infragistics.Controls.Grids.Primitives.FilterRowCell;
			if (filterRowCell != null)
			{
				this.ExecuteCommand(filterRowCell);
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}

		// Token: 0x060006BC RID: 1724
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.Primitives.FilterRowCell filterRowCell);
	}
}
