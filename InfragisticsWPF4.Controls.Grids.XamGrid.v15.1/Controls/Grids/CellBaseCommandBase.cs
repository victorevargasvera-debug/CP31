using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200006D RID: 109
	public abstract class CellBaseCommandBase : global::Infragistics.CommandBase
	{
		// Token: 0x060003B9 RID: 953 RVA: 0x00010965 File Offset: 0x0000EB65
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x060003BA RID: 954 RVA: 0x00010968 File Offset: 0x0000EB68
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.CellBase cellBase = parameter as global::Infragistics.Controls.Grids.CellBase;
			if (cellBase != null)
			{
				this.ExecuteCommand(cellBase);
				base.CommandSource.Handled = true;
			}
			global::Infragistics.Controls.Grids.Primitives.SelectionControl selectionControl = parameter as global::Infragistics.Controls.Grids.Primitives.SelectionControl;
			if (selectionControl != null)
			{
				this.ExecuteCommand(selectionControl.Cell);
				base.CommandSource.Handled = false;
			}
			base.Execute(parameter);
		}

		// Token: 0x060003BB RID: 955
		protected abstract void ExecuteCommand(global::Infragistics.Controls.Grids.CellBase cell);
	}
}
