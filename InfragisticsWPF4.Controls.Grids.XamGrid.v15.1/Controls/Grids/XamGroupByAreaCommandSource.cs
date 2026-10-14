using System;
using System.Windows.Input;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x020000FA RID: 250
	public class XamGroupByAreaCommandSource : global::Infragistics.Controls.CommandSource
	{
		// Token: 0x17000294 RID: 660
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x00021632 File Offset: 0x0001F832
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0002163A File Offset: 0x0001F83A
		public global::Infragistics.Controls.Grids.XamGroupByAreaCommand CommandType { get; set; }

		// Token: 0x06000854 RID: 2132 RVA: 0x00021644 File Offset: 0x0001F844
		protected override global::System.Windows.Input.ICommand ResolveCommand()
		{
			global::System.Windows.Input.ICommand result = null;
			switch (this.CommandType)
			{
			case global::Infragistics.Controls.Grids.XamGroupByAreaCommand.ToggleExpansion:
				result = new global::Infragistics.Controls.Grids.Primitives.ToggleGroupByAreaCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGroupByAreaCommand.Expand:
				result = new global::Infragistics.Controls.Grids.Primitives.ExpandGroupByAreaCommand();
				break;
			case global::Infragistics.Controls.Grids.XamGroupByAreaCommand.Collapse:
				result = new global::Infragistics.Controls.Grids.Primitives.CollapseGroupByAreaCommand();
				break;
			}
			return result;
		}
	}
}
