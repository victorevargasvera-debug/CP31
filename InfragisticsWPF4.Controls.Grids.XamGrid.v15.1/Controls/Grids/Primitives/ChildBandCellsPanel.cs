using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200026F RID: 623
	public class ChildBandCellsPanel : global::Infragistics.Controls.Grids.Primitives.CellsPanel
	{
		// Token: 0x0600148A RID: 5258 RVA: 0x0004C280 File Offset: 0x0004A480
		protected override global::System.Windows.Size RenderCells(double availableWidth)
		{
			double height = 0.0;
			base.Row.Manager.CachedIndentation = base.Row.Manager.ResolveIndentation(base.Row);
			double num = base.Row.Manager.CachedIndentation;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			num += this.RenderCell(base.Row.ColumnLayout.Columns.ExpansionIndicatorColumn, starColumns, ref height, false, base.VisibleFixedLeftCells, double.IsPositiveInfinity(availableWidth));
			num += this.RenderCell(((global::Infragistics.Controls.Grids.ChildBandRowsManager)base.Row.Manager).Column, starColumns, ref height, false, base.VisibleCells, double.IsPositiveInfinity(availableWidth));
			base.SetupStarCells(availableWidth, num, ref height, starColumns);
			return new global::System.Windows.Size(num, height);
		}
	}
}
