using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000279 RID: 633
	public class GroupByAreaRowCellsPanel : global::Infragistics.Controls.Grids.Primitives.CellsPanel
	{
		// Token: 0x06001506 RID: 5382 RVA: 0x0004D518 File Offset: 0x0004B718
		protected override global::System.Windows.Size RenderCells(double availableWidth)
		{
			this._hasInfinityWidth = double.IsInfinity(availableWidth);
			global::Infragistics.Controls.Grids.XamGridRowsManager xamGridRowsManager = (global::Infragistics.Controls.Grids.XamGridRowsManager)base.Row.Manager;
			double height = 0.0;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			double num = this.RenderCell(xamGridRowsManager.GroupByAreaColumn, starColumns, ref height, false, base.VisibleCells, double.IsPositiveInfinity(availableWidth));
			base.SetupStarCells(availableWidth, num, ref height, starColumns);
			return new global::System.Windows.Size(num, height);
		}

		// Token: 0x06001507 RID: 5383 RVA: 0x0004D584 File Offset: 0x0004B784
		protected override global::System.Windows.Size ArrangeOverride(global::System.Windows.Size finalSize)
		{
			base.ArrangeOverride(finalSize);
			if (this._hasInfinityWidth && base.Row != null && base.VisibleCells.Any<global::Infragistics.Controls.Grids.CellBase>())
			{
				global::Infragistics.Controls.Grids.Primitives.CellControlBase control = base.VisibleCells[0].Control;
				control.Arrange(new global::System.Windows.Rect(0.0, 0.0, finalSize.Width, finalSize.Height));
			}
			return finalSize;
		}

		// Token: 0x0400065B RID: 1627
		private bool _hasInfinityWidth;
	}
}
