using System;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000014 RID: 20
	public abstract class ColumnChooserCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x06000107 RID: 263 RVA: 0x000082AD File Offset: 0x000064AD
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000082B0 File Offset: 0x000064B0
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = parameter as global::Infragistics.Controls.Grids.ColumnLayout;
			if (columnLayout != null && columnLayout.Grid != null)
			{
				this.ExecuteCommand(columnLayout);
			}
			else
			{
				global::Infragistics.Controls.Grids.Column column = parameter as global::Infragistics.Controls.Grids.Column;
				if (column != null && column.ColumnLayout != null && column.ColumnLayout.Grid != null)
				{
					if (column.ParentColumn != null)
					{
						this.ExecuteCommand(column.ParentColumn);
					}
					else
					{
						this.ExecuteCommand(column.ColumnLayout);
					}
				}
			}
			base.Execute(parameter);
		}

		// Token: 0x06000109 RID: 265
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.ColumnLayout col);

		// Token: 0x0600010A RID: 266
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.Column col);
	}
}
