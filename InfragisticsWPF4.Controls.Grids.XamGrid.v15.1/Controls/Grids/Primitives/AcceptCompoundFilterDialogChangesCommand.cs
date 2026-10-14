using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000076 RID: 118
	public class AcceptCompoundFilterDialogChangesCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x00013385 File Offset: 0x00011585
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x00013388 File Offset: 0x00011588
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.AcceptChanges();
			}
			base.Execute(parameter);
		}
	}
}
