using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200007C RID: 124
	public class CreateOrGroupCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CreateLogicalOperatorCompoundFilterDialogCommand
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00013578 File Offset: 0x00011778
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.CreateOrGroup();
			}
			base.Execute(parameter);
		}
	}
}
