using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200013E RID: 318
	public class ClosePopupCommand : global::Infragistics.Controls.Grids.Primitives.PopupCommandBase
	{
		// Token: 0x06000A75 RID: 2677 RVA: 0x0002817C File Offset: 0x0002637C
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = parameter as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
			if (headerDropDownControl != null)
			{
				headerDropDownControl.IsOpen = false;
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}
	}
}
