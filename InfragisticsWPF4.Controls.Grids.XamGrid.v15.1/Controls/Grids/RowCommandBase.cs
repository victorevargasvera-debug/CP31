using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000284 RID: 644
	public abstract class RowCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06001555 RID: 5461 RVA: 0x0004DE95 File Offset: 0x0004C095
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x0004DE98 File Offset: 0x0004C098
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Row row = parameter as global::Infragistics.Controls.Grids.Row;
			if (row != null)
			{
				this.ExecuteCommand(row);
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}

		// Token: 0x06001557 RID: 5463
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.Row row);
	}
}
