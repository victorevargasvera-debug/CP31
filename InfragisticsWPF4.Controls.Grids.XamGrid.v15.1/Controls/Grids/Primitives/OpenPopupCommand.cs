using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200013C RID: 316
	public class OpenPopupCommand : global::Infragistics.Controls.Grids.Primitives.PopupCommandBase
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x000280F8 File Offset: 0x000262F8
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = parameter as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
			if (headerDropDownControl != null)
			{
				headerDropDownControl.IsOpen = true;
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}
	}
}
