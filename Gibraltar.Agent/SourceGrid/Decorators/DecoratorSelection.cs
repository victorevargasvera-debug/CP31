using System;
using System.Drawing;
using SourceGrid.Selection;

namespace SourceGrid.Decorators
{
	// Token: 0x020003A3 RID: 931
	internal class DecoratorSelection : global::SourceGrid.Decorators.DecoratorBase
	{
		// Token: 0x06002B4C RID: 11084 RVA: 0x00091CA0 File Offset: 0x0008FEA0
		public DecoratorSelection(global::SourceGrid.Selection.SelectionBase selection)
		{
			this.mSelection = selection;
		}

		// Token: 0x06002B4D RID: 11085 RVA: 0x00091CB0 File Offset: 0x0008FEB0
		public override bool IntersectWith(global::SourceGrid.Range range)
		{
			return this.mSelection.IntersectsWith(range);
		}

		// Token: 0x06002B4E RID: 11086 RVA: 0x00091CC0 File Offset: 0x0008FEC0
		public override void Draw(global::SourceGrid.RangePaintEventArgs e)
		{
			global::SourceGrid.RangeRegion selectionRegion = this.mSelection.GetSelectionRegion();
			if (selectionRegion.IsEmpty())
			{
				return;
			}
			global::System.Drawing.Brush brush = e.GraphicsCache.BrushsCache.GetBrush(this.mSelection.BackColor);
			global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(e.Grid, this.mSelection.ActivePosition);
			global::System.Drawing.Rectangle rect = e.Grid.PositionToRectangle(this.mSelection.ActivePosition);
			foreach (global::SourceGrid.Range range in selectionRegion)
			{
				global::System.Drawing.Rectangle rectangle = e.Grid.RangeToRectangle(range);
				if (!(rectangle == global::System.Drawing.Rectangle.Empty))
				{
					global::System.Drawing.Region region = new global::System.Drawing.Region(rectangle);
					if (rectangle.IntersectsWith(rect))
					{
						region.Exclude(rect);
					}
					e.GraphicsCache.Graphics.FillRegion(brush, region);
					if ((range.Contains(this.mSelection.ActivePosition) || selectionRegion.Count == 1) && !cellContext.IsEditing())
					{
						this.mSelection.Border.Draw(e.GraphicsCache, rectangle);
					}
				}
			}
			global::System.Drawing.Brush brush2 = e.GraphicsCache.BrushsCache.GetBrush(this.mSelection.FocusBackColor);
			e.GraphicsCache.Graphics.FillRectangle(brush2, rect);
		}

		// Token: 0x04000E90 RID: 3728
		private global::SourceGrid.Selection.SelectionBase mSelection;
	}
}
