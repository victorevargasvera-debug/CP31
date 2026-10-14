using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200013D RID: 317
	public class TogglePopupCommand : global::Infragistics.Controls.Grids.Primitives.PopupCommandBase
	{
		// Token: 0x06000A73 RID: 2675 RVA: 0x00028134 File Offset: 0x00026334
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = parameter as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
			bool flag = true;
			if (headerDropDownControl != null && flag)
			{
				headerDropDownControl.IsOpen = !headerDropDownControl.IsOpen;
				base.CommandSource.Handled = true;
			}
			base.Execute(parameter);
		}
	}
}
