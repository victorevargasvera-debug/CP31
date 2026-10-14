using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200007B RID: 123
	public class CreateAndGroupCompoundFilterDialogCommand : global::Infragistics.Controls.Grids.Primitives.CreateLogicalOperatorCompoundFilterDialogCommand
	{
		// Token: 0x0600043C RID: 1084 RVA: 0x0001354C File Offset: 0x0001174C
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl compoundFilterDialogControl = parameter as global::Infragistics.Controls.Grids.Primitives.CompoundFilterDialogControl;
			if (compoundFilterDialogControl != null)
			{
				compoundFilterDialogControl.CreateAndGroup();
			}
			base.Execute(parameter);
		}
	}
}
