using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000FD RID: 253
	public class ExpandGroupByAreaCommand : global::Infragistics.Controls.Grids.Primitives.GroupByAreaCommandBase
	{
		// Token: 0x0600085C RID: 2140 RVA: 0x000216C6 File Offset: 0x0001F8C6
		public override void Execute(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByArea)
		{
			groupByArea.IsExpanded = true;
		}
	}
}
