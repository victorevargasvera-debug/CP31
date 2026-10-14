using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000FC RID: 252
	public class ToggleGroupByAreaCommand : global::Infragistics.Controls.Grids.Primitives.GroupByAreaCommandBase
	{
		// Token: 0x0600085A RID: 2138 RVA: 0x000216AD File Offset: 0x0001F8AD
		public override void Execute(global::Infragistics.Controls.Grids.Primitives.GroupByAreaCellControl groupByArea)
		{
			groupByArea.IsExpanded = !groupByArea.IsExpanded;
		}
	}
}
