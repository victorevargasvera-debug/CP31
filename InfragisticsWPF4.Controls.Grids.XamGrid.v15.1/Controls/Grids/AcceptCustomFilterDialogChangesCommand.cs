using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000DB RID: 219
	public class AcceptCustomFilterDialogChangesCommand : global::Infragistics.CommandBase
	{
		// Token: 0x0600072B RID: 1835 RVA: 0x0001E34D File Offset: 0x0001C54D
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x0001E350 File Offset: 0x0001C550
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl columnFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.ColumnFilterDialogControl;
			if (columnFilterDialogControl != null)
			{
				columnFilterDialogControl.AcceptChanges();
			}
			base.Execute(parameter);
		}
	}
}
