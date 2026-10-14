using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027F RID: 639
	public class PagerCellsPanel : global::Infragistics.Controls.Grids.Primitives.CellsPanel
	{
		// Token: 0x06001538 RID: 5432 RVA: 0x0004DB40 File Offset: 0x0004BD40
		protected override global::System.Windows.Size RenderCells(double availableWidth)
		{
			this._hasInfinityWidth = double.IsInfinity(availableWidth);
			double height = 0.0;
			base.Row.Manager.CachedIndentation = base.Row.Manager.ResolveIndentation(base.Row);
			double num = base.Row.Manager.CachedIndentation;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>();
			num += this.RenderCell(((global::Infragistics.Controls.Grids.Primitives.PagerRow)base.Row).Column, starColumns, ref height, false, base.VisibleCells, double.IsPositiveInfinity(availableWidth));
			base.SetupStarCells(availableWidth, num, ref height, starColumns);
			return new global::System.Windows.Size(num, height);
		}

		// Token: 0x06001539 RID: 5433 RVA: 0x0004DBDC File Offset: 0x0004BDDC
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

		// Token: 0x04000662 RID: 1634
		private bool _hasInfinityWidth;
	}
}
