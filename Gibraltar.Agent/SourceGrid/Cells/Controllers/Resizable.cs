using System;
using System.Drawing;
using System.Windows.Forms;
using DevAge.Drawing;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x0200038D RID: 909
	internal class Resizable : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CB9 RID: 3257
		// (get) Token: 0x06002AC8 RID: 10952 RVA: 0x0008FE24 File Offset: 0x0008E024
		public static global::SourceGrid.Cells.Controllers.Resizable ResizeBoth
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.Resizable.t_ResizeBoth == null)
				{
					global::SourceGrid.Cells.Controllers.Resizable.t_ResizeBoth = new global::SourceGrid.Cells.Controllers.Resizable(global::SourceGrid.CellResizeMode.Both);
				}
				return global::SourceGrid.Cells.Controllers.Resizable.t_ResizeBoth;
			}
		}

		// Token: 0x17000CBA RID: 3258
		// (get) Token: 0x06002AC9 RID: 10953 RVA: 0x0008FE40 File Offset: 0x0008E040
		public static global::SourceGrid.Cells.Controllers.Resizable ResizeWidth
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.Resizable.t_ResizeWidth == null)
				{
					global::SourceGrid.Cells.Controllers.Resizable.t_ResizeWidth = new global::SourceGrid.Cells.Controllers.Resizable(global::SourceGrid.CellResizeMode.Width);
				}
				return global::SourceGrid.Cells.Controllers.Resizable.t_ResizeWidth;
			}
		}

		// Token: 0x17000CBB RID: 3259
		// (get) Token: 0x06002ACA RID: 10954 RVA: 0x0008FE5C File Offset: 0x0008E05C
		public static global::SourceGrid.Cells.Controllers.Resizable ResizeHeight
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.Resizable.t_ResizeHeight == null)
				{
					global::SourceGrid.Cells.Controllers.Resizable.t_ResizeHeight = new global::SourceGrid.Cells.Controllers.Resizable(global::SourceGrid.CellResizeMode.Height);
				}
				return global::SourceGrid.Cells.Controllers.Resizable.t_ResizeHeight;
			}
		}

		// Token: 0x06002ACB RID: 10955 RVA: 0x0008FE78 File Offset: 0x0008E078
		public Resizable(global::SourceGrid.CellResizeMode p_Mode)
		{
			this.m_ResizeMode = p_Mode;
		}

		// Token: 0x06002ACC RID: 10956 RVA: 0x0008FEE8 File Offset: 0x0008E0E8
		public override void OnMouseDown(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(sender, e);
			this.m_IsHeightResize = false;
			this.m_IsWidthResize = false;
			global::System.Drawing.Rectangle r = sender.Grid.PositionToRectangle(sender.Position);
			global::System.Drawing.Point p = new global::System.Drawing.Point(e.X, e.Y);
			global::DevAge.Drawing.RectanglePartType pointPartType = this.LogicalBorder.GetPointPartType(r, p, out this.mDistanceFromBorder);
			if ((this.ResizeMode & global::SourceGrid.CellResizeMode.Width) == global::SourceGrid.CellResizeMode.Width && pointPartType == global::DevAge.Drawing.RectanglePartType.RightBorder)
			{
				this.m_IsWidthResize = true;
				return;
			}
			if ((this.ResizeMode & global::SourceGrid.CellResizeMode.Height) == global::SourceGrid.CellResizeMode.Height && pointPartType == global::DevAge.Drawing.RectanglePartType.BottomBorder)
			{
				this.m_IsHeightResize = true;
			}
		}

		// Token: 0x06002ACD RID: 10957 RVA: 0x0008FF90 File Offset: 0x0008E190
		public override void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(sender, e);
			this.m_IsWidthResize = false;
			this.m_IsHeightResize = false;
		}

		// Token: 0x06002ACE RID: 10958 RVA: 0x0008FFA8 File Offset: 0x0008E1A8
		public override void OnMouseMove(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseMove(sender, e);
			global::System.Drawing.Rectangle r = sender.Grid.PositionToRectangle(sender.Position);
			if (r.IsEmpty)
			{
				return;
			}
			global::System.Drawing.Point p = new global::System.Drawing.Point(e.X, e.Y);
			float num;
			global::DevAge.Drawing.RectanglePartType pointPartType = this.LogicalBorder.GetPointPartType(r, p, out num);
			if (sender.Grid.MouseDownPosition == sender.Position)
			{
				if (this.m_IsWidthResize)
				{
					int num2 = p.X - r.Left;
					if (num2 > 0)
					{
						this.SetWidth(sender.Grid, sender.Position, (int)((float)num2 + this.mDistanceFromBorder));
					}
					this.mWidthCursor.ApplyCursor(sender, e);
					this.mHeightCursor.ResetCursor(sender, e);
					return;
				}
				if (this.m_IsHeightResize)
				{
					int num3 = p.Y - r.Top;
					if (num3 > 0)
					{
						this.SetHeight(sender.Grid, sender.Position, (int)((float)num3 + this.mDistanceFromBorder));
					}
					this.mHeightCursor.ApplyCursor(sender, e);
					this.mWidthCursor.ResetCursor(sender, e);
					return;
				}
			}
			else
			{
				if (pointPartType == global::DevAge.Drawing.RectanglePartType.RightBorder && (this.ResizeMode & global::SourceGrid.CellResizeMode.Width) == global::SourceGrid.CellResizeMode.Width)
				{
					this.mWidthCursor.ApplyCursor(sender, e);
					return;
				}
				if (pointPartType == global::DevAge.Drawing.RectanglePartType.BottomBorder && (this.ResizeMode & global::SourceGrid.CellResizeMode.Height) == global::SourceGrid.CellResizeMode.Height)
				{
					this.mHeightCursor.ApplyCursor(sender, e);
					return;
				}
				this.mWidthCursor.ResetCursor(sender, e);
				this.mHeightCursor.ResetCursor(sender, e);
			}
		}

		// Token: 0x06002ACF RID: 10959 RVA: 0x00090148 File Offset: 0x0008E348
		private void SetWidth(global::SourceGrid.GridVirtual grid, global::SourceGrid.Position position, int width)
		{
			global::SourceGrid.Range range = grid.PositionToCellRange(position);
			int width2 = width / range.ColumnsCount;
			for (int i = range.Start.Column; i <= range.End.Column; i++)
			{
				grid.Columns.SetWidth(i, width2);
			}
		}

		// Token: 0x06002AD0 RID: 10960 RVA: 0x000901A4 File Offset: 0x0008E3A4
		private void SetHeight(global::SourceGrid.GridVirtual grid, global::SourceGrid.Position position, int height)
		{
			global::SourceGrid.Range range = grid.PositionToCellRange(position);
			int height2 = height / range.RowsCount;
			for (int i = range.Start.Row; i <= range.End.Row; i++)
			{
				grid.Rows.SetHeight(i, height2);
			}
		}

		// Token: 0x06002AD1 RID: 10961 RVA: 0x00090200 File Offset: 0x0008E400
		public override void OnMouseLeave(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnMouseLeave(sender, e);
			this.mWidthCursor.ResetCursor(sender, e);
			this.mHeightCursor.ResetCursor(sender, e);
			this.m_IsWidthResize = false;
			this.m_IsHeightResize = false;
		}

		// Token: 0x06002AD2 RID: 10962 RVA: 0x00090234 File Offset: 0x0008E434
		public override void OnDoubleClick(global::SourceGrid.CellContext sender, global::System.EventArgs e)
		{
			base.OnDoubleClick(sender, e);
			global::System.Drawing.Point p = sender.Grid.PointToClient(global::System.Windows.Forms.Control.MousePosition);
			global::System.Drawing.Rectangle r = sender.Grid.PositionToRectangle(sender.Position);
			float num;
			global::DevAge.Drawing.RectanglePartType pointPartType = this.LogicalBorder.GetPointPartType(r, p, out num);
			if ((this.ResizeMode & global::SourceGrid.CellResizeMode.Width) == global::SourceGrid.CellResizeMode.Width && pointPartType == global::DevAge.Drawing.RectanglePartType.RightBorder)
			{
				sender.Grid.Columns.AutoSizeColumn(sender.Position.Column);
				return;
			}
			if ((this.ResizeMode & global::SourceGrid.CellResizeMode.Height) == global::SourceGrid.CellResizeMode.Height && pointPartType == global::DevAge.Drawing.RectanglePartType.BottomBorder)
			{
				sender.Grid.Rows.AutoSizeRow(sender.Position.Row);
			}
		}

		// Token: 0x17000CBC RID: 3260
		// (get) Token: 0x06002AD3 RID: 10963 RVA: 0x000902F4 File Offset: 0x0008E4F4
		public global::SourceGrid.CellResizeMode ResizeMode
		{
			get
			{
				return this.m_ResizeMode;
			}
		}

		// Token: 0x17000CBD RID: 3261
		// (get) Token: 0x06002AD4 RID: 10964 RVA: 0x000902FC File Offset: 0x0008E4FC
		public bool IsWidthResizing
		{
			get
			{
				return this.m_IsWidthResize;
			}
		}

		// Token: 0x17000CBE RID: 3262
		// (get) Token: 0x06002AD5 RID: 10965 RVA: 0x00090304 File Offset: 0x0008E504
		public bool IsHeightResizing
		{
			get
			{
				return this.m_IsHeightResize;
			}
		}

		// Token: 0x04000E60 RID: 3680
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.Resizable t_ResizeBoth;

		// Token: 0x04000E61 RID: 3681
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.Resizable t_ResizeWidth;

		// Token: 0x04000E62 RID: 3682
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.Resizable t_ResizeHeight;

		// Token: 0x04000E63 RID: 3683
		public global::DevAge.Drawing.RectangleBorder LogicalBorder = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 4f), new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 4f));

		// Token: 0x04000E64 RID: 3684
		private global::SourceGrid.Cells.Controllers.MouseCursor mWidthCursor = new global::SourceGrid.Cells.Controllers.MouseCursor(global::System.Windows.Forms.Cursors.VSplit, false);

		// Token: 0x04000E65 RID: 3685
		private global::SourceGrid.Cells.Controllers.MouseCursor mHeightCursor = new global::SourceGrid.Cells.Controllers.MouseCursor(global::System.Windows.Forms.Cursors.HSplit, false);

		// Token: 0x04000E66 RID: 3686
		private global::SourceGrid.CellResizeMode m_ResizeMode = global::SourceGrid.CellResizeMode.Both;

		// Token: 0x04000E67 RID: 3687
		private bool m_IsWidthResize;

		// Token: 0x04000E68 RID: 3688
		private bool m_IsHeightResize;

		// Token: 0x04000E69 RID: 3689
		private float mDistanceFromBorder;
	}
}
