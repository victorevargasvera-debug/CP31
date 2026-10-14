using System;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000275 RID: 629
	public class ColumnLayoutTemplateRowCellsPanel : global::Infragistics.Controls.Grids.Primitives.CellsPanel
	{
		// Token: 0x060014E7 RID: 5351 RVA: 0x0004CECC File Offset: 0x0004B0CC
		protected override global::System.Windows.Size RenderCells(double availableWidth)
		{
			global::Infragistics.Controls.Grids.RowsManager rowsManager = (global::Infragistics.Controls.Grids.RowsManager)base.Row.Manager;
			double num = 0.0;
			base.Row.Manager.CachedIndentation = base.Row.Manager.ResolveIndentation(base.Row);
			double num2 = base.Row.Manager.CachedIndentation;
			availableWidth = global::System.Math.Max(availableWidth - num2, 0.0);
			double height = double.PositiveInfinity;
			global::Infragistics.Controls.Grids.RowHeight heightResolved = base.Row.HeightResolved;
			if (heightResolved.HeightType == global::Infragistics.Controls.Grids.RowHeightType.Numeric)
			{
				height = heightResolved.Value;
			}
			global::Infragistics.Controls.Grids.CellBase cellBase = base.Row.ResolveCell(rowsManager.ColumnLayoutTemplateColumn);
			if (cellBase != null)
			{
				base.VisibleCells.Add(cellBase);
				if (cellBase.Control == null)
				{
					global::Infragistics.RecyclingManager.Manager.AttachElement(cellBase, this);
					cellBase.Control.EnsureContent();
					cellBase.MeasuringSize = global::System.Windows.Size.Empty;
					cellBase.Control.Measure(new global::System.Windows.Size(availableWidth, height));
					cellBase.EnsureCurrentState();
				}
				else
				{
					cellBase.ApplyStyle();
					cellBase.Control.EnsureContent();
					if (cellBase.MeasuringSize.IsEmpty)
					{
						cellBase.Control.Measure(new global::System.Windows.Size(availableWidth, height));
					}
					else
					{
						cellBase.Control.Measure(cellBase.MeasuringSize);
					}
					cellBase.EnsureCurrentState();
				}
				num2 = cellBase.Control.DesiredSize.Width;
				if (!double.IsPositiveInfinity(availableWidth))
				{
					num2 = availableWidth;
				}
				rowsManager.ColumnLayoutTemplateColumn.ActualWidth = num2;
				num = global::System.Math.Max(num, cellBase.Control.DesiredSize.Height);
			}
			return new global::System.Windows.Size(rowsManager.ColumnLayoutTemplateColumn.ActualWidth, num);
		}
	}
}
