using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000158 RID: 344
	public class AcceptChangesCommand : global::Infragistics.CommandBase
	{
		// Token: 0x06000B21 RID: 2849 RVA: 0x00029EB1 File Offset: 0x000280B1
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000B22 RID: 2850 RVA: 0x00029EB4 File Offset: 0x000280B4
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.SelectionControl selectionControl = parameter as global::Infragistics.Controls.Grids.Primitives.SelectionControl;
			if (selectionControl != null)
			{
				selectionControl.AcceptChanges();
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}
	}
}
