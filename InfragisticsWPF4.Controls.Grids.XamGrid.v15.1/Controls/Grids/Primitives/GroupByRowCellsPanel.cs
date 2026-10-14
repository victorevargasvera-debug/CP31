using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027B RID: 635
	public class GroupByRowCellsPanel : global::Infragistics.Controls.Grids.Primitives.CellsPanel
	{
		// Token: 0x0600151E RID: 5406 RVA: 0x0004D820 File Offset: 0x0004BA20
		protected override global::System.Windows.Size RenderCells(double availableWidth)
		{
			this._hasInfinityWidth = double.IsInfinity(availableWidth);
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Row.Manager;
			double height = 0.0;
			base.Row.Manager.CachedIndentation = base.Row.Manager.ResolveIndentation(base.Row);
			double num = base.Row.Manager.CachedIndentation;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			num += this.RenderCell(base.Row.ColumnLayout.Columns.ExpansionIndicatorColumn, starColumns, ref height, false, base.VisibleFixedLeftCells, double.IsPositiveInfinity(availableWidth));
			num += this.RenderCell(rowsManager.GroupByColumn, starColumns, ref height, false, base.VisibleCells, double.IsPositiveInfinity(availableWidth));
			base.SetupStarCells(availableWidth, num, ref height, starColumns);
			return new global::System.Windows.Size(num, height);
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x0004D8F4 File Offset: 0x0004BAF4
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			if (this._hasInfinityWidth && base.Row != null && base.VisibleCells.Any<global::Infragistics.Controls.Grids.CellBase>())
			{
				double num = 0.0;
				if (base.VisibleFixedLeftCells.Count > 0)
				{
					num = base.VisibleFixedLeftCells[0].Column.ActualWidth;
				}
				base.VisibleCells[0].Control.Arrange(new global::System.Windows.Rect(num, 0.0, finalSize.Width - num, finalSize.Height));
			}
			return finalSize;
		}

		// Token: 0x0400065F RID: 1631
		private bool _hasInfinityWidth;
	}
}
