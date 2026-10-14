using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000FE RID: 254
	public class CollapseGroupByAreaCommand : global::Infragistics.Controls.Grids.Primitives.GroupByAreaCommandBase
	{
		// Token: 0x0600085E RID: 2142 RVA: 0x000216D7 File Offset: 0x0001F8D7
		public override void Execute(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByArea)
		{
			groupByArea.IsExpanded = false;
		}
	}
}
