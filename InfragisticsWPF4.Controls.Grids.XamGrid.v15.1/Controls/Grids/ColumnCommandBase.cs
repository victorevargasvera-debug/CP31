using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000018 RID: 24
	public abstract class ColumnCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06000116 RID: 278 RVA: 0x000083C9 File Offset: 0x000065C9
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000117 RID: 279 RVA: 0x000083CC File Offset: 0x000065CC
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Column column = parameter as global::Infragistics.Controls.Grids.Column;
			if (column != null)
			{
				this.ExecuteCommand(column);
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}

		// Token: 0x06000118 RID: 280
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.Column col);
	}
}
