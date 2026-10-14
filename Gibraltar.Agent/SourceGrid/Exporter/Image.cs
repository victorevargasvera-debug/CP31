using System;
using System.Drawing;
using DevAge.Drawing;
using SourceGrid.Cells;

namespace SourceGrid.Exporter
{
	// Token: 0x0200038F RID: 911
	internal class Image
	{
		// Token: 0x06002AEB RID: 10987 RVA: 0x0009080C File Offset: 0x0008EA0C
		public virtual global::System.Drawing.Bitmap Export(global::SourceGrid.GridVirtual grid, global::SourceGrid.Range rangeToExport)
		{
			global::System.Drawing.Bitmap bitmap = null;
			try
			{
				global::System.Drawing.Size size = grid.RangeToSize(rangeToExport);
				bitmap = new global::System.Drawing.Bitmap(size.Width, size.Height);
				using (global::System.Drawing.Graphics graphics = global::System.Drawing.Graphics.FromImage(bitmap))
				{
					this.Export(grid, graphics, rangeToExport, new global::System.Drawing.Point(0, 0));
				}
			}
			catch (global::System.Exception)
			{
				if (bitmap != null)
				{
					bitmap.Dispose();
					bitmap = null;
				}
				throw;
			}
			return bitmap;
		}

		// Token: 0x06002AEC RID: 10988 RVA: 0x00090894 File Offset: 0x0008EA94
		public virtual void Export(global::SourceGrid.GridVirtual grid, global::System.Drawing.Graphics graphics, global::SourceGrid.Range rangeToExport, global::System.Drawing.Point destinationLocation)
		{
			if (rangeToExport.IsEmpty())
			{
				return;
			}
			global::System.Drawing.Point location = destinationLocation;
			using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(graphics))
			{
				for (int i = rangeToExport.Start.Row; i <= rangeToExport.End.Row; i++)
				{
					int height = grid.Rows.GetHeight(i);
					for (int j = rangeToExport.Start.Column; j <= rangeToExport.End.Column; j++)
					{
						global::SourceGrid.Position position = new global::SourceGrid.Position(i, j);
						global::System.Drawing.Size size = new global::System.Drawing.Size(grid.Columns.GetWidth(j), height);
						global::SourceGrid.Range range = grid.PositionToCellRange(position);
						global::System.Drawing.Rectangle empty;
						if (range.ColumnsCount > 1 || range.RowsCount > 1)
						{
							if (range.Start == position)
							{
								global::System.Drawing.Size size2 = grid.RangeToSize(range);
								empty = new global::System.Drawing.Rectangle(location, size2);
							}
							else
							{
								empty = global::System.Drawing.Rectangle.Empty;
							}
						}
						else
						{
							empty = new global::System.Drawing.Rectangle(location, size);
						}
						if (!empty.IsEmpty)
						{
							global::SourceGrid.Cells.ICellVirtual cell = grid.GetCell(position);
							global::SourceGrid.CellContext context = new global::SourceGrid.CellContext(grid, position, cell);
							this.ExportCell(context, graphicsCache, empty);
						}
						location = new global::System.Drawing.Point(location.X + size.Width, location.Y);
					}
					location = new global::System.Drawing.Point(destinationLocation.X, location.Y + height);
				}
			}
		}

		// Token: 0x06002AED RID: 10989 RVA: 0x00090A40 File Offset: 0x0008EC40
		protected virtual void ExportCell(global::SourceGrid.CellContext context, global::DevAge.Drawing.GraphicsCache graphics, global::System.Drawing.Rectangle rectangle)
		{
			if (context.Cell != null)
			{
				context.Cell.View.DrawCell(context, graphics, rectangle);
			}
		}
	}
}
