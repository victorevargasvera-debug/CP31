using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000140 RID: 320
	public class ClosePopupConditionalCommand : global::Infragistics.Controls.Grids.Primitives.PopupCommandBase
	{
		// Token: 0x06000A7C RID: 2684 RVA: 0x0002822C File Offset: 0x0002642C
		public override void Execute(object parameter)
		{
			global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl headerDropDownControl = parameter as global::Infragistics.Controls.Grids.Primitives.HeaderDropDownControl;
			if (headerDropDownControl != null)
			{
				global::Infragistics.Controls.Grids.Primitives.XamGridPopupFilterMenuConditionalCommandSource xamGridPopupFilterMenuConditionalCommandSource = (global::Infragistics.Controls.Grids.Primitives.XamGridPopupFilterMenuConditionalCommandSource)base.CommandSource;
				if (xamGridPopupFilterMenuConditionalCommandSource.ConditionalCommandParameter != null && xamGridPopupFilterMenuConditionalCommandSource.ConditionalCommandParameter.Count > 0)
				{
					headerDropDownControl.IsOpen = false;
					base.CommandSource.Handled = true;
				}
			}
			base.Execute(parameter);
		}
	}
}
