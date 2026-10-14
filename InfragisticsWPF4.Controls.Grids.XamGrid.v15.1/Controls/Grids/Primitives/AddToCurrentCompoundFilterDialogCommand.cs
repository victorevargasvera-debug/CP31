using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000078 RID: 120
	public class AddToCurrentCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogCommandBase
	{
		// Token: 0x06000434 RID: 1076 RVA: 0x0001340C File Offset: 0x0001160C
		public override bool CanExecute(object parameter)
		{
			return true;
		}

		// Token: 0x06000435 RID: 1077 RVA: 0x00013410 File Offset: 0x00011610
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.AddNewFilterCondition();
			}
			base.Execute(parameter);
		}
	}
}
