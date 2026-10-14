using System;
using System.Windows.Input;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000139 RID: 313
	public class XamGridPopupCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x1700030D RID: 781
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x00028093 File Offset: 0x00026293
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0002809B File Offset: 0x0002629B
		public global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand CommandType { get; set; }

		// Token: 0x06000A6D RID: 2669 RVA: 0x000280A4 File Offset: 0x000262A4
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand.TogglePopup:
				result = new global::Infragistics.Controls.Grids.Primitives.TogglePopupCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand.OpenPopup:
				result = new global::Infragistics.Controls.Grids.Primitives.OpenPopupCommand();
				break;
			case global::Infragistics.Controls.Grids.Primitives.XamGridPopupCommand.ClosePopup:
				result = new global::Infragistics.Controls.Grids.Primitives.ClosePopupCommand();
				break;
			}
			return result;
		}
	}
}
