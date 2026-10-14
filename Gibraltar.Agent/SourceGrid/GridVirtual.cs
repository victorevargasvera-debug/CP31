using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DevAge.Drawing;
using DevAge.Windows.Forms;
using SourceGrid.Cells;
using SourceGrid.Cells.Controllers;
using SourceGrid.Decorators;
using SourceGrid.Selection;

namespace SourceGrid
{
	// Token: 0x02000338 RID: 824
	[global::System.ComponentModel.ToolboxItem(false)]
	internal abstract class GridVirtual : global::SourceGrid.CustomScrollControl
	{
		// Token: 0x0600270A RID: 9994 RVA: 0x000874B4 File Offset: 0x000856B4
		public GridVirtual()
		{
			base.SetStyle(global::System.Windows.Forms.ControlStyles.Selectable, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.OptimizedDoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.DoubleBuffer, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.SupportsTransparentBackColor, true);
			base.SetStyle(global::System.Windows.Forms.ControlStyles.ContainerControl, true);
			base.TabStop = true;
			this.m_Rows = this.CreateRowsObject();
			this.m_Columns = this.CreateColumnsObject();
			this.SelectionMode = global::SourceGrid.GridSelectionMode.Cell;
			this.Controller.AddController(global::SourceGrid.Cells.Controllers.StandardBehavior.Default);
			this.Controller.AddController(global::SourceGrid.Cells.Controllers.MouseSelection.Default);
			this.Controller.AddController(global::SourceGrid.Cells.Controllers.CellEventDispatcher.Default);
			this.m_LinkedControls = new global::SourceGrid.LinkedControlsList(this);
			this.toolTip = new global::System.Windows.Forms.ToolTip();
			this.ToolTipText = "";
		}

		// Token: 0x0600270B RID: 9995
		protected abstract global::SourceGrid.RowsBase CreateRowsObject();

		// Token: 0x0600270C RID: 9996
		protected abstract global::SourceGrid.ColumnsBase CreateColumnsObject();

		// Token: 0x0600270D RID: 9997 RVA: 0x000875F4 File Offset: 0x000857F4
		protected override void Dispose(bool disposing)
		{
			base.Dispose(disposing);
		}

		// Token: 0x17000BFE RID: 3070
		// (get) Token: 0x0600270E RID: 9998 RVA: 0x00087600 File Offset: 0x00085800
		// (set) Token: 0x0600270F RID: 9999 RVA: 0x00087608 File Offset: 0x00085808
		[global::System.ComponentModel.DefaultValue(20)]
		public int DefaultHeight
		{
			get
			{
				return this.mDefaultHeight;
			}
			set
			{
				this.mDefaultHeight = value;
			}
		}

		// Token: 0x17000BFF RID: 3071
		// (get) Token: 0x06002710 RID: 10000 RVA: 0x00087614 File Offset: 0x00085814
		// (set) Token: 0x06002711 RID: 10001 RVA: 0x0008761C File Offset: 0x0008581C
		[global::System.ComponentModel.DefaultValue(50)]
		public int DefaultWidth
		{
			get
			{
				return this.mDefaultWidth;
			}
			set
			{
				this.mDefaultWidth = value;
			}
		}

		// Token: 0x17000C00 RID: 3072
		// (get) Token: 0x06002712 RID: 10002 RVA: 0x00087628 File Offset: 0x00085828
		// (set) Token: 0x06002713 RID: 10003 RVA: 0x00087630 File Offset: 0x00085830
		[global::System.ComponentModel.DefaultValue(0)]
		public int MinimumHeight
		{
			get
			{
				return this.mMinimumHeight;
			}
			set
			{
				this.mMinimumHeight = value;
			}
		}

		// Token: 0x17000C01 RID: 3073
		// (get) Token: 0x06002714 RID: 10004 RVA: 0x0008763C File Offset: 0x0008583C
		// (set) Token: 0x06002715 RID: 10005 RVA: 0x00087644 File Offset: 0x00085844
		[global::System.ComponentModel.DefaultValue(0)]
		public int MinimumWidth
		{
			get
			{
				return this.mMinimumWidth;
			}
			set
			{
				this.mMinimumWidth = value;
			}
		}

		// Token: 0x06002716 RID: 10006 RVA: 0x00087650 File Offset: 0x00085850
		public virtual void AutoSizeCells(global::SourceGrid.Range p_RangeToAutoSize)
		{
			base.SuspendLayout();
			if (!p_RangeToAutoSize.IsEmpty())
			{
				this.Rows.SuspendLayout();
				this.Columns.SuspendLayout();
				try
				{
					for (int i = p_RangeToAutoSize.End.Column; i >= p_RangeToAutoSize.Start.Column; i--)
					{
						this.Columns.AutoSizeColumn(i, false, p_RangeToAutoSize.Start.Row, p_RangeToAutoSize.End.Row);
					}
					for (int j = p_RangeToAutoSize.End.Row; j >= p_RangeToAutoSize.Start.Row; j--)
					{
						this.Rows.AutoSizeRow(j, false, p_RangeToAutoSize.Start.Column, p_RangeToAutoSize.End.Column);
					}
				}
				finally
				{
					this.Rows.ResumeLayout();
					this.Columns.ResumeLayout();
				}
				if (this.AutoStretchColumnsToFitWidth)
				{
					this.Columns.StretchToFit();
				}
				if (this.AutoStretchRowsToFitHeight)
				{
					this.Rows.StretchToFit();
				}
			}
			base.ResumeLayout(false);
		}

		// Token: 0x06002717 RID: 10007 RVA: 0x0008779C File Offset: 0x0008599C
		public virtual void AutoSizeCells()
		{
			this.AutoSizeCells(this.CompleteRange);
		}

		// Token: 0x17000C02 RID: 3074
		// (get) Token: 0x06002718 RID: 10008 RVA: 0x000877AC File Offset: 0x000859AC
		// (set) Token: 0x06002719 RID: 10009 RVA: 0x000877B4 File Offset: 0x000859B4
		[global::System.ComponentModel.DefaultValue(false)]
		public bool AutoStretchColumnsToFitWidth
		{
			get
			{
				return this.m_bAutoStretchColumnsToFitWidth;
			}
			set
			{
				this.m_bAutoStretchColumnsToFitWidth = value;
			}
		}

		// Token: 0x17000C03 RID: 3075
		// (get) Token: 0x0600271A RID: 10010 RVA: 0x000877C0 File Offset: 0x000859C0
		// (set) Token: 0x0600271B RID: 10011 RVA: 0x000877C8 File Offset: 0x000859C8
		[global::System.ComponentModel.DefaultValue(false)]
		public bool AutoStretchRowsToFitHeight
		{
			get
			{
				return this.m_bAutoStretchRowsToFitHeight;
			}
			set
			{
				this.m_bAutoStretchRowsToFitHeight = value;
			}
		}

		// Token: 0x0600271C RID: 10012 RVA: 0x000877D4 File Offset: 0x000859D4
		public virtual void CheckPositions()
		{
			global::SourceGrid.Range completeRange = this.CompleteRange;
			if (!this.m_MouseCellPosition.IsEmpty() && !this.CompleteRange.Contains(this.m_MouseCellPosition))
			{
				this.m_MouseCellPosition = global::SourceGrid.Position.Empty;
			}
			if (!this.m_MouseDownPosition.IsEmpty() && !this.CompleteRange.Contains(this.m_MouseDownPosition))
			{
				this.m_MouseDownPosition = global::SourceGrid.Position.Empty;
			}
			if (!this.mDragCellPosition.IsEmpty() && !this.CompleteRange.Contains(this.mDragCellPosition))
			{
				this.mDragCellPosition = global::SourceGrid.Position.Empty;
			}
		}

		// Token: 0x0600271D RID: 10013 RVA: 0x00087888 File Offset: 0x00085A88
		public global::System.Drawing.Rectangle PositionToRectangle(global::SourceGrid.Position position)
		{
			return this.RangeToRectangle(this.PositionToCellRange(position));
		}

		// Token: 0x0600271E RID: 10014 RVA: 0x00087898 File Offset: 0x00085A98
		public virtual global::SourceGrid.Position PositionAtPoint(global::System.Drawing.Point point)
		{
			int? num = this.Rows.RowAtPoint(point.Y);
			if (num == null)
			{
				return global::SourceGrid.Position.Empty;
			}
			int? num2 = this.Columns.ColumnAtPoint(point.X);
			if (num2 == null)
			{
				return global::SourceGrid.Position.Empty;
			}
			global::SourceGrid.Position p_Position = new global::SourceGrid.Position(num.Value, num2.Value);
			return this.PositionToStartPosition(p_Position);
		}

		// Token: 0x0600271F RID: 10015 RVA: 0x00087910 File Offset: 0x00085B10
		public global::System.Drawing.Size RangeToSize(global::SourceGrid.Range range)
		{
			if (range.IsEmpty())
			{
				return global::System.Drawing.Size.Empty;
			}
			int num = 0;
			for (int i = range.Start.Column; i <= range.End.Column; i++)
			{
				num += this.Columns.GetWidth(i);
			}
			int num2 = 0;
			for (int j = range.Start.Row; j <= range.End.Row; j++)
			{
				num2 += this.Rows.GetHeight(j);
			}
			return new global::System.Drawing.Size(num, num2);
		}

		// Token: 0x06002720 RID: 10016 RVA: 0x000879C0 File Offset: 0x00085BC0
		public global::System.Drawing.Rectangle RangeToRectangle(global::SourceGrid.Range range)
		{
			if (range.IsEmpty())
			{
				return global::System.Drawing.Rectangle.Empty;
			}
			int left = this.Columns.GetLeft(range.Start.Column);
			int top = this.Rows.GetTop(range.Start.Row);
			global::System.Drawing.Size size = this.RangeToSize(range);
			if (size.IsEmpty)
			{
				return global::System.Drawing.Rectangle.Empty;
			}
			return new global::System.Drawing.Rectangle(new global::System.Drawing.Point(left, top), size);
		}

		// Token: 0x06002721 RID: 10017 RVA: 0x00087A44 File Offset: 0x00085C44
		public global::SourceGrid.Range RangeAtArea(global::SourceGrid.CellPositionType areaType)
		{
			if (areaType == global::SourceGrid.CellPositionType.FixedTopLeft)
			{
				if (this.FixedRows > 0 && this.Rows.Count >= this.FixedRows && this.FixedColumns > 0 && this.Columns.Count >= this.FixedColumns)
				{
					return new global::SourceGrid.Range(0, 0, this.FixedRows - 1, this.FixedColumns - 1);
				}
				return global::SourceGrid.Range.Empty;
			}
			else if (areaType == global::SourceGrid.CellPositionType.FixedLeft)
			{
				int num = this.FixedColumns;
				if (num > this.Columns.Count)
				{
					num = this.Columns.Count;
				}
				if (num <= 0)
				{
					return global::SourceGrid.Range.Empty;
				}
				int? firstVisibleScrollableRow = this.Rows.FirstVisibleScrollableRow;
				int? lastVisibleScrollableRow = this.Rows.LastVisibleScrollableRow;
				if (firstVisibleScrollableRow == null || lastVisibleScrollableRow == null)
				{
					return global::SourceGrid.Range.Empty;
				}
				return new global::SourceGrid.Range(firstVisibleScrollableRow.Value, 0, lastVisibleScrollableRow.Value, num - 1);
			}
			else if (areaType == global::SourceGrid.CellPositionType.FixedTop)
			{
				int num2 = this.FixedRows;
				if (num2 > this.Rows.Count)
				{
					num2 = this.Rows.Count;
				}
				if (num2 <= 0)
				{
					return global::SourceGrid.Range.Empty;
				}
				int? firstVisibleScrollableColumn = this.Columns.FirstVisibleScrollableColumn;
				int? lastVisibleScrollableColumn = this.Columns.LastVisibleScrollableColumn;
				if (firstVisibleScrollableColumn == null || lastVisibleScrollableColumn == null)
				{
					return global::SourceGrid.Range.Empty;
				}
				return new global::SourceGrid.Range(0, firstVisibleScrollableColumn.Value, num2 - 1, lastVisibleScrollableColumn.Value);
			}
			else
			{
				if (areaType != global::SourceGrid.CellPositionType.Scrollable)
				{
					throw new global::SourceGrid.SourceGridException("Invalid areaType");
				}
				int? firstVisibleScrollableRow2 = this.Rows.FirstVisibleScrollableRow;
				int? lastVisibleScrollableRow2 = this.Rows.LastVisibleScrollableRow;
				int? firstVisibleScrollableColumn2 = this.Columns.FirstVisibleScrollableColumn;
				int? lastVisibleScrollableColumn2 = this.Columns.LastVisibleScrollableColumn;
				if (firstVisibleScrollableRow2 == null || firstVisibleScrollableColumn2 == null || lastVisibleScrollableRow2 == null || lastVisibleScrollableColumn2 == null)
				{
					return global::SourceGrid.Range.Empty;
				}
				return new global::SourceGrid.Range(firstVisibleScrollableRow2.Value, firstVisibleScrollableColumn2.Value, lastVisibleScrollableRow2.Value, lastVisibleScrollableColumn2.Value);
			}
		}

		// Token: 0x06002722 RID: 10018 RVA: 0x00087C6C File Offset: 0x00085E6C
		private global::System.Collections.Generic.IEnumerable<global::SourceGrid.Range> GetVisibleRegion()
		{
			global::SourceGrid.Range rng = this.RangeAtArea(global::SourceGrid.CellPositionType.FixedTopLeft);
			if (!rng.IsEmpty())
			{
				yield return rng;
			}
			rng = this.RangeAtArea(global::SourceGrid.CellPositionType.FixedTop);
			if (!rng.IsEmpty())
			{
				yield return rng;
			}
			rng = this.RangeAtArea(global::SourceGrid.CellPositionType.FixedLeft);
			if (!rng.IsEmpty())
			{
				yield return rng;
			}
			rng = this.RangeAtArea(global::SourceGrid.CellPositionType.Scrollable);
			if (!rng.IsEmpty())
			{
				yield return rng;
			}
			yield break;
		}

		// Token: 0x06002723 RID: 10019 RVA: 0x00087C90 File Offset: 0x00085E90
		public global::System.Collections.Generic.List<int> GetVisibleRows(bool returnsPartial)
		{
			return this.GetVisibleRows(base.DisplayRectangle, returnsPartial);
		}

		// Token: 0x06002724 RID: 10020 RVA: 0x00087CA0 File Offset: 0x00085EA0
		public global::System.Collections.Generic.List<int> GetVisibleRows(global::System.Drawing.Rectangle displayRectangle, bool returnsPartial)
		{
			return this.Rows.RowsInsideRegion(displayRectangle.Y, displayRectangle.Height, returnsPartial);
		}

		// Token: 0x06002725 RID: 10021 RVA: 0x00087CCC File Offset: 0x00085ECC
		public global::System.Collections.Generic.List<int> GetVisibleColumns(bool returnsPartial)
		{
			return this.GetVisibleColumns(base.DisplayRectangle, returnsPartial);
		}

		// Token: 0x06002726 RID: 10022 RVA: 0x00087CDC File Offset: 0x00085EDC
		public global::System.Collections.Generic.List<int> GetVisibleColumns(global::System.Drawing.Rectangle displayRectangle, bool returnsPartial)
		{
			return this.Columns.ColumnsInsideRegion(displayRectangle.X, displayRectangle.Width, returnsPartial);
		}

		// Token: 0x06002727 RID: 10023 RVA: 0x00087D08 File Offset: 0x00085F08
		protected override int GetScrollRows(int displayHeight)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < this.ActualFixedRows; i++)
			{
				displayHeight -= this.Rows.GetHeight(i);
			}
			for (int j = this.Rows.Count - 1; j >= this.ActualFixedRows; j--)
			{
				num += this.Rows.GetHeight(j);
				if (num > displayHeight)
				{
					return this.Rows.Count - num2;
				}
				num2++;
			}
			return 0;
		}

		// Token: 0x06002728 RID: 10024 RVA: 0x00087D8C File Offset: 0x00085F8C
		protected override int GetScrollColumns(int displayWidth)
		{
			int num = 0;
			int num2 = 0;
			for (int i = 0; i < this.ActualFixedColumns; i++)
			{
				displayWidth -= this.Columns.GetWidth(i);
			}
			for (int j = this.Columns.Count - 1; j >= this.ActualFixedColumns; j--)
			{
				num += this.Columns.GetWidth(j);
				if (num > displayWidth)
				{
					return this.Columns.Count - num2;
				}
				num2++;
			}
			return 0;
		}

		// Token: 0x06002729 RID: 10025 RVA: 0x00087E10 File Offset: 0x00086010
		public bool IsCellVisible(global::SourceGrid.Position position, bool partial)
		{
			global::System.Drawing.Point point;
			return !this.GetScrollPositionToShowCell(position, partial, out point);
		}

		// Token: 0x0600272A RID: 10026 RVA: 0x00087E30 File Offset: 0x00086030
		protected virtual bool GetScrollPositionToShowCell(global::SourceGrid.Position position, bool partial, out global::System.Drawing.Point newScrollPosition)
		{
			global::System.Drawing.Rectangle displayRectangle = base.DisplayRectangle;
			global::System.Collections.Generic.List<int> visibleRows = this.GetVisibleRows(partial);
			global::System.Collections.Generic.List<int> visibleColumns = this.GetVisibleColumns(partial);
			if (visibleRows.Contains(position.Row) && visibleColumns.Contains(position.Column))
			{
				newScrollPosition = this.CustomScrollPosition;
				return false;
			}
			global::SourceGrid.CellPositionType positionType = this.GetPositionType(position);
			bool flag = false;
			if (positionType == global::SourceGrid.CellPositionType.FixedTop || positionType == global::SourceGrid.CellPositionType.FixedTopLeft)
			{
				flag = true;
			}
			bool flag2 = false;
			if (positionType == global::SourceGrid.CellPositionType.FixedLeft || positionType == global::SourceGrid.CellPositionType.FixedTopLeft)
			{
				flag2 = true;
			}
			int num;
			if (visibleColumns.Contains(position.Column))
			{
				num = this.CustomScrollPosition.X;
			}
			else
			{
				if (flag2)
				{
					num = 0;
				}
				else
				{
					num = position.Column - this.FixedColumns;
				}
				int scrollColumns = this.GetScrollColumns(displayRectangle.Width);
				if (num > scrollColumns)
				{
					num = scrollColumns;
				}
			}
			int num2;
			if (visibleRows.Contains(position.Row))
			{
				num2 = this.CustomScrollPosition.Y;
			}
			else
			{
				if (flag)
				{
					num2 = 0;
				}
				else
				{
					num2 = position.Row - this.FixedRows;
				}
				int scrollRows = this.GetScrollRows(displayRectangle.Height);
				if (num2 > scrollRows)
				{
					num2 = scrollRows;
				}
			}
			newScrollPosition = new global::System.Drawing.Point(num, num2);
			return true;
		}

		// Token: 0x0600272B RID: 10027 RVA: 0x00087F90 File Offset: 0x00086190
		public bool ShowCell(global::SourceGrid.Position p_Position, bool ignorePartial)
		{
			global::System.Drawing.Point customScrollPosition;
			if (this.GetScrollPositionToShowCell(p_Position, ignorePartial, out customScrollPosition))
			{
				this.CustomScrollPosition = customScrollPosition;
				if (this.FixedRows > 0 || this.FixedColumns > 0)
				{
					base.Invalidate();
				}
				return false;
			}
			return true;
		}

		// Token: 0x0600272C RID: 10028 RVA: 0x00087FD8 File Offset: 0x000861D8
		public virtual void InvalidateCell(global::SourceGrid.Position position)
		{
			this.InvalidateRange(new global::SourceGrid.Range(position));
		}

		// Token: 0x0600272D RID: 10029 RVA: 0x00087FE8 File Offset: 0x000861E8
		public void InvalidateRange(global::SourceGrid.Range range)
		{
			range = global::SourceGrid.Range.Intersect(range, this.CompleteRange);
			if (!range.IsEmpty())
			{
				global::System.Drawing.Rectangle rc = this.RangeToRectangle(range);
				if (!rc.IsEmpty)
				{
					base.Invalidate(rc, true);
				}
			}
		}

		// Token: 0x0600272E RID: 10030 RVA: 0x00088030 File Offset: 0x00086230
		public void ScrollOnPoint(global::System.Drawing.Point mousePoint)
		{
			global::System.Drawing.Rectangle scrollableArea = this.GetScrollableArea();
			if (mousePoint.X > scrollableArea.Right)
			{
				this.CustomScrollLineRight();
			}
			if (mousePoint.Y > scrollableArea.Bottom)
			{
				this.CustomScrollLineDown();
			}
			if (mousePoint.X < scrollableArea.Left)
			{
				this.CustomScrollLineLeft();
			}
			if (mousePoint.Y < scrollableArea.Top)
			{
				this.CustomScrollLineUp();
			}
		}

		// Token: 0x0600272F RID: 10031 RVA: 0x000880AC File Offset: 0x000862AC
		protected override void InvalidateScrollableArea()
		{
			base.Invalidate(true);
		}

		// Token: 0x06002730 RID: 10032 RVA: 0x000880B8 File Offset: 0x000862B8
		public global::System.Drawing.Rectangle GetScrollableArea()
		{
			global::System.Drawing.Rectangle displayRectangle = base.DisplayRectangle;
			int actualFixedRows = this.ActualFixedRows;
			int actualFixedColumns = this.ActualFixedColumns;
			if (actualFixedRows > 0)
			{
				displayRectangle.Y = this.Rows.GetAbsoluteBottom(actualFixedRows - 1);
			}
			else
			{
				displayRectangle.Y = 0;
			}
			displayRectangle.Height -= displayRectangle.Y;
			if (actualFixedColumns > 0)
			{
				displayRectangle.X = this.Columns.GetAbsoluteRight(actualFixedColumns - 1);
			}
			else
			{
				displayRectangle.X = 0;
			}
			displayRectangle.Width -= displayRectangle.X;
			return displayRectangle;
		}

		// Token: 0x06002731 RID: 10033 RVA: 0x0008815C File Offset: 0x0008635C
		public global::System.Drawing.Rectangle GetFixedTopLeftArea()
		{
			global::System.Drawing.Rectangle scrollableArea = this.GetScrollableArea();
			return new global::System.Drawing.Rectangle(0, 0, scrollableArea.Left, scrollableArea.Top);
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x0008818C File Offset: 0x0008638C
		public global::System.Drawing.Rectangle GetFixedTopArea()
		{
			global::System.Drawing.Rectangle scrollableArea = this.GetScrollableArea();
			return new global::System.Drawing.Rectangle(scrollableArea.Left, 0, scrollableArea.Width, scrollableArea.Top);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000881C0 File Offset: 0x000863C0
		public global::System.Drawing.Rectangle GetFixedLeftArea()
		{
			global::System.Drawing.Rectangle scrollableArea = this.GetScrollableArea();
			return new global::System.Drawing.Rectangle(0, scrollableArea.Top, scrollableArea.Left, scrollableArea.Height);
		}

		// Token: 0x06002734 RID: 10036 RVA: 0x000881F4 File Offset: 0x000863F4
		public global::SourceGrid.Position PositionToStartPosition(global::SourceGrid.Position p_Position)
		{
			return this.PositionToCellRange(p_Position).Start;
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x00088214 File Offset: 0x00086414
		public virtual global::SourceGrid.Range PositionToCellRange(global::SourceGrid.Position pPosition)
		{
			return new global::SourceGrid.Range(pPosition);
		}

		// Token: 0x17000C04 RID: 3076
		// (get) Token: 0x06002736 RID: 10038 RVA: 0x0008821C File Offset: 0x0008641C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::SourceGrid.Position DragCellPosition
		{
			get
			{
				return this.mDragCellPosition;
			}
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x00088224 File Offset: 0x00086424
		public virtual void ChangeDragCell(global::SourceGrid.CellContext cell, global::System.Windows.Forms.DragEventArgs pDragEventArgs)
		{
			if (cell.Position != this.mDragCellPosition)
			{
				if (!this.mDragCellPosition.IsEmpty())
				{
					this.Controller.OnDragLeave(new global::SourceGrid.CellContext(this, this.mDragCellPosition, this.GetCell(this.mDragCellPosition)), pDragEventArgs);
				}
				if (!cell.Position.IsEmpty())
				{
					this.Controller.OnDragEnter(cell, pDragEventArgs);
				}
				this.mDragCellPosition = cell.Position;
			}
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000882AC File Offset: 0x000864AC
		protected virtual global::SourceGrid.Selection.SelectionBase CreateSelectionObject()
		{
			switch (this.SelectionMode)
			{
			case global::SourceGrid.GridSelectionMode.Cell:
				return new global::SourceGrid.Selection.FreeSelection();
			case global::SourceGrid.GridSelectionMode.Row:
				return new global::SourceGrid.Selection.RowSelection();
			case global::SourceGrid.GridSelectionMode.Column:
				return new global::SourceGrid.Selection.ColumnSelection();
			default:
				throw new global::System.ArgumentException("SelectionMode not valid", "SelectionMode");
			}
		}

		// Token: 0x17000C05 RID: 3077
		// (get) Token: 0x06002739 RID: 10041 RVA: 0x00088300 File Offset: 0x00086500
		// (set) Token: 0x0600273A RID: 10042 RVA: 0x00088308 File Offset: 0x00086508
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Selection.SelectionBase Selection
		{
			get
			{
				return this.mSelection;
			}
			protected set
			{
				if (this.mSelection != null)
				{
					this.mSelection.UnBindToGrid();
				}
				this.mSelection = value;
				if (this.mSelection != null)
				{
					this.mSelection.BindToGrid(this);
				}
			}
		}

		// Token: 0x17000C06 RID: 3078
		// (get) Token: 0x0600273B RID: 10043 RVA: 0x00088340 File Offset: 0x00086540
		// (set) Token: 0x0600273C RID: 10044 RVA: 0x00088348 File Offset: 0x00086548
		public global::SourceGrid.GridSelectionMode SelectionMode
		{
			get
			{
				return this.mSelectionMode;
			}
			set
			{
				this.mSelectionMode = value;
				this.Selection = this.CreateSelectionObject();
				base.Invalidate(true);
			}
		}

		// Token: 0x17000C07 RID: 3079
		// (get) Token: 0x0600273D RID: 10045 RVA: 0x00088364 File Offset: 0x00086564
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Position MouseDownPosition
		{
			get
			{
				return this.m_MouseDownPosition;
			}
		}

		// Token: 0x17000C08 RID: 3080
		// (get) Token: 0x0600273E RID: 10046 RVA: 0x0008836C File Offset: 0x0008656C
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Position MouseCellPosition
		{
			get
			{
				return this.m_MouseCellPosition;
			}
		}

		// Token: 0x0600273F RID: 10047 RVA: 0x00088374 File Offset: 0x00086574
		public virtual void ChangeMouseCell(global::SourceGrid.Position p_Cell)
		{
			if (this.m_MouseCellPosition != p_Cell)
			{
				if (!this.m_MouseCellPosition.IsEmpty() && this.m_MouseCellPosition != this.m_MouseDownPosition)
				{
					this.Controller.OnMouseLeave(new global::SourceGrid.CellContext(this, this.m_MouseCellPosition), global::System.EventArgs.Empty);
				}
				this.m_MouseCellPosition = p_Cell;
				if (!this.m_MouseCellPosition.IsEmpty())
				{
					this.Controller.OnMouseEnter(new global::SourceGrid.CellContext(this, this.m_MouseCellPosition), global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x06002740 RID: 10048 RVA: 0x0008840C File Offset: 0x0008660C
		public virtual void ChangeMouseDownCell(global::SourceGrid.Position p_MouseDownCell, global::SourceGrid.Position p_MouseCell)
		{
			this.m_MouseDownPosition = p_MouseDownCell;
			this.ChangeMouseCell(p_MouseCell);
		}

		// Token: 0x06002741 RID: 10049 RVA: 0x0008841C File Offset: 0x0008661C
		protected virtual void OnMouseSelectionFinish(global::SourceGrid.RangeEventArgs e)
		{
			this.m_OldMouseSelectionRange = global::SourceGrid.Range.Empty;
		}

		// Token: 0x17000C09 RID: 3081
		// (get) Token: 0x06002742 RID: 10050 RVA: 0x0008842C File Offset: 0x0008662C
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public virtual global::SourceGrid.Range MouseSelectionRange
		{
			get
			{
				return this.m_MouseSelectionRange;
			}
		}

		// Token: 0x06002743 RID: 10051 RVA: 0x00088434 File Offset: 0x00086634
		protected virtual void OnUndoMouseSelection(global::SourceGrid.RangeEventArgs e)
		{
			this.Selection.SelectRange(e.Range, false);
		}

		// Token: 0x06002744 RID: 10052 RVA: 0x00088448 File Offset: 0x00086648
		protected virtual void OnApplyMouseSelection(global::SourceGrid.RangeEventArgs e)
		{
			this.Selection.SelectRange(e.Range, true);
		}

		// Token: 0x06002745 RID: 10053 RVA: 0x0008845C File Offset: 0x0008665C
		protected virtual void OnMouseSelectionChange(global::System.EventArgs e)
		{
			global::SourceGrid.Range mouseSelectionRange = this.MouseSelectionRange;
			this.OnUndoMouseSelection(new global::SourceGrid.RangeEventArgs(this.m_OldMouseSelectionRange));
			this.OnApplyMouseSelection(new global::SourceGrid.RangeEventArgs(mouseSelectionRange));
			this.m_OldMouseSelectionRange = mouseSelectionRange;
		}

		// Token: 0x06002746 RID: 10054 RVA: 0x00088498 File Offset: 0x00086698
		public void MouseSelectionFinish()
		{
			if (this.m_MouseSelectionRange != global::SourceGrid.Range.Empty)
			{
				this.OnMouseSelectionFinish(new global::SourceGrid.RangeEventArgs(this.m_OldMouseSelectionRange));
			}
			this.m_MouseSelectionRange = global::SourceGrid.Range.Empty;
		}

		// Token: 0x06002747 RID: 10055 RVA: 0x000884CC File Offset: 0x000866CC
		public virtual void ChangeMouseSelectionCorner(global::SourceGrid.Position p_Corner)
		{
			global::SourceGrid.Range range = new global::SourceGrid.Range(this.Selection.ActivePosition, p_Corner);
			bool flag = false;
			if (this.m_MouseSelectionRange != range)
			{
				this.m_MouseSelectionRange = range;
				flag = true;
			}
			if (flag)
			{
				this.OnMouseSelectionChange(global::System.EventArgs.Empty);
			}
		}

		// Token: 0x06002748 RID: 10056 RVA: 0x00088520 File Offset: 0x00086720
		protected override bool ProcessCmdKey(ref global::System.Windows.Forms.Message msg, global::System.Windows.Forms.Keys keyData)
		{
			if ((keyData == global::System.Windows.Forms.Keys.Return || keyData == global::System.Windows.Forms.Keys.Escape || keyData == global::System.Windows.Forms.Keys.Tab || keyData == (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Shift)) && this.OverrideCommonCmdKey)
			{
				global::System.Windows.Forms.KeyEventArgs keyEventArgs = new global::System.Windows.Forms.KeyEventArgs(keyData);
				this.OnKeyDown(keyEventArgs);
				return keyEventArgs.Handled || base.ProcessCmdKey(ref msg, keyData);
			}
			return base.ProcessCmdKey(ref msg, keyData);
		}

		// Token: 0x17000C0A RID: 3082
		// (get) Token: 0x06002749 RID: 10057 RVA: 0x0008858C File Offset: 0x0008678C
		// (set) Token: 0x0600274A RID: 10058 RVA: 0x00088594 File Offset: 0x00086794
		[global::System.ComponentModel.DefaultValue(true)]
		public bool OverrideCommonCmdKey
		{
			get
			{
				return this.m_OverrideCommonCmdKey;
			}
			set
			{
				this.m_OverrideCommonCmdKey = value;
			}
		}

		// Token: 0x17000C0B RID: 3083
		// (get) Token: 0x0600274B RID: 10059 RVA: 0x000885A0 File Offset: 0x000867A0
		// (set) Token: 0x0600274C RID: 10060 RVA: 0x000885A8 File Offset: 0x000867A8
		[global::System.ComponentModel.DefaultValue(global::SourceGrid.GridSpecialKeys.Default)]
		public global::SourceGrid.GridSpecialKeys SpecialKeys
		{
			get
			{
				return this.m_GridSpecialKeys;
			}
			set
			{
				this.m_GridSpecialKeys = value;
			}
		}

		// Token: 0x17000C0C RID: 3084
		// (get) Token: 0x0600274D RID: 10061 RVA: 0x000885B4 File Offset: 0x000867B4
		// (set) Token: 0x0600274E RID: 10062 RVA: 0x000885BC File Offset: 0x000867BC
		[global::System.ComponentModel.DefaultValue(true)]
		public bool AcceptsInputChar
		{
			get
			{
				return this.mAcceptsInputChar;
			}
			set
			{
				this.mAcceptsInputChar = value;
			}
		}

		// Token: 0x0600274F RID: 10063 RVA: 0x000885C8 File Offset: 0x000867C8
		public virtual void ProcessSpecialGridKey(global::System.Windows.Forms.KeyEventArgs e)
		{
			if (e.Handled)
			{
				return;
			}
			bool flag3;
			bool flag2;
			bool flag = flag2 = (flag3 = false);
			if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Arrows) == global::SourceGrid.GridSpecialKeys.Arrows)
			{
				flag2 = true;
			}
			if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.PageDownUp) == global::SourceGrid.GridSpecialKeys.PageDownUp)
			{
				flag3 = true;
			}
			if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Tab) == global::SourceGrid.GridSpecialKeys.Tab)
			{
				flag = true;
			}
			bool flag4 = false;
			if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Escape) == global::SourceGrid.GridSpecialKeys.Escape)
			{
				flag4 = true;
			}
			bool flag5 = false;
			if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Enter) == global::SourceGrid.GridSpecialKeys.Enter)
			{
				flag5 = true;
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Escape && flag4)
			{
				global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this, this.Selection.ActivePosition);
				if (cellContext.Cell != null && cellContext.IsEditing() && cellContext.EndEdit(true))
				{
					e.Handled = true;
				}
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Return && flag5)
			{
				global::SourceGrid.CellContext cellContext2 = new global::SourceGrid.CellContext(this, this.Selection.ActivePosition);
				if (cellContext2.Cell != null && cellContext2.IsEditing())
				{
					cellContext2.EndEdit(false);
					e.Handled = true;
				}
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Tab && flag)
			{
				global::SourceGrid.CellContext cellContext3 = new global::SourceGrid.CellContext(this, this.Selection.ActivePosition);
				if (cellContext3.Cell != null && cellContext3.IsEditing() && !cellContext3.EndEdit(false))
				{
					e.Handled = true;
					return;
				}
			}
			if (e.KeyCode == global::System.Windows.Forms.Keys.Down && flag2)
			{
				this.Selection.MoveActiveCell(1, 0);
				e.Handled = true;
			}
			else if (e.KeyCode == global::System.Windows.Forms.Keys.Up && flag2)
			{
				this.Selection.MoveActiveCell(-1, 0);
				e.Handled = true;
			}
			else if (e.KeyCode == global::System.Windows.Forms.Keys.Right && flag2)
			{
				this.Selection.MoveActiveCell(0, 1);
				e.Handled = true;
			}
			else if (e.KeyCode == global::System.Windows.Forms.Keys.Left && flag2)
			{
				this.Selection.MoveActiveCell(0, -1);
				e.Handled = true;
			}
			else if (e.KeyCode == global::System.Windows.Forms.Keys.Tab && flag)
			{
				if (e.Modifiers == global::System.Windows.Forms.Keys.Shift)
				{
					if (!this.Selection.MoveActiveCell(0, -1, -1, 2147483647))
					{
						base.FindForm().SelectNextControl(this, false, true, true, true);
					}
					e.Handled = true;
				}
				else
				{
					if (!this.Selection.MoveActiveCell(0, 1, 1, -2147483648))
					{
						base.FindForm().SelectNextControl(this, true, true, true, true);
					}
					e.Handled = true;
				}
			}
			else if ((e.KeyCode == global::System.Windows.Forms.Keys.Prior || e.KeyCode == global::System.Windows.Forms.Keys.Next) && flag3)
			{
				global::System.Drawing.Point location = this.PositionToRectangle(this.Selection.ActivePosition).Location;
				location.Offset(1, 1);
				if (e.KeyCode == global::System.Windows.Forms.Keys.Next)
				{
					this.CustomScrollPageDown();
				}
				else if (e.KeyCode == global::System.Windows.Forms.Keys.Prior)
				{
					this.CustomScrollPageUp();
				}
				global::SourceGrid.Position position = this.PositionAtPoint(location);
				if (this.Selection.CanReceiveFocus(position))
				{
					this.Selection.Focus(position, true);
				}
				e.Handled = true;
			}
			bool flag6 = (this.ClipboardMode & global::SourceGrid.ClipboardMode.Paste) == global::SourceGrid.ClipboardMode.Paste;
			bool flag7 = (this.ClipboardMode & global::SourceGrid.ClipboardMode.Copy) == global::SourceGrid.ClipboardMode.Copy;
			bool flag8 = (this.ClipboardMode & global::SourceGrid.ClipboardMode.Cut) == global::SourceGrid.ClipboardMode.Cut;
			bool flag9 = (this.ClipboardMode & global::SourceGrid.ClipboardMode.Delete) == global::SourceGrid.ClipboardMode.Delete;
			global::SourceGrid.RangeRegion selectionRegion = this.Selection.GetSelectionRegion();
			if (e.Control && e.KeyCode == global::System.Windows.Forms.Keys.V && flag6 && !selectionRegion.IsEmpty())
			{
				global::SourceGrid.RangeData rangeData = global::SourceGrid.RangeData.ClipboardGetData();
				if (rangeData != null)
				{
					global::SourceGrid.Range range = rangeData.FindDestinationRange(this, selectionRegion[0].Start);
					rangeData.WriteData(this, range);
					e.Handled = true;
					this.Selection.ResetSelection(true);
					this.Selection.SelectRange(range, true);
					return;
				}
			}
			else
			{
				if (e.Control && e.KeyCode == global::System.Windows.Forms.Keys.C && flag7 && !selectionRegion.IsEmpty())
				{
					global::SourceGrid.Range sourceRange = selectionRegion[0];
					global::SourceGrid.RangeData rangeData2 = new global::SourceGrid.RangeData();
					rangeData2.LoadData(this, sourceRange, sourceRange.Start, global::SourceGrid.CutMode.None);
					global::SourceGrid.RangeData.ClipboardSetData(rangeData2);
					e.Handled = true;
					return;
				}
				if (e.Control && e.KeyCode == global::System.Windows.Forms.Keys.X && flag8 && !selectionRegion.IsEmpty())
				{
					global::SourceGrid.Range sourceRange2 = selectionRegion[0];
					global::SourceGrid.RangeData rangeData3 = new global::SourceGrid.RangeData();
					rangeData3.LoadData(this, sourceRange2, sourceRange2.Start, global::SourceGrid.CutMode.CutImmediately);
					global::SourceGrid.RangeData.ClipboardSetData(rangeData3);
					e.Handled = true;
					return;
				}
				if (e.KeyCode == global::System.Windows.Forms.Keys.Delete && flag9)
				{
					this.ClearValues(selectionRegion);
					e.Handled = true;
				}
			}
		}

		// Token: 0x06002750 RID: 10064 RVA: 0x00088ACC File Offset: 0x00086CCC
		protected override bool IsInputKey(global::System.Windows.Forms.Keys keyData)
		{
			if (this.OverrideCommonCmdKey)
			{
				if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Arrows) == global::SourceGrid.GridSpecialKeys.Arrows)
				{
					switch (keyData)
					{
					case global::System.Windows.Forms.Keys.Left:
					case global::System.Windows.Forms.Keys.Up:
					case global::System.Windows.Forms.Keys.Right:
					case global::System.Windows.Forms.Keys.Down:
						break;
					default:
						switch (keyData)
						{
						case global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift:
						case global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift:
						case global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.RButton | global::System.Windows.Forms.Keys.MButton | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift:
						case global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Space | global::System.Windows.Forms.Keys.Shift:
							break;
						default:
							goto IL_59;
						}
						break;
					}
					return true;
				}
				IL_59:
				if ((this.SpecialKeys & global::SourceGrid.GridSpecialKeys.Tab) == global::SourceGrid.GridSpecialKeys.Tab && (keyData == global::System.Windows.Forms.Keys.Tab || keyData == (global::System.Windows.Forms.Keys.LButton | global::System.Windows.Forms.Keys.Back | global::System.Windows.Forms.Keys.Shift)))
				{
					return true;
				}
			}
			return base.IsInputKey(keyData);
		}

		// Token: 0x06002751 RID: 10065 RVA: 0x00088B64 File Offset: 0x00086D64
		protected override bool IsInputChar(char charCode)
		{
			return this.AcceptsInputChar;
		}

		// Token: 0x06002752 RID: 10066 RVA: 0x00088B6C File Offset: 0x00086D6C
		protected override void OnPaint(global::System.Windows.Forms.PaintEventArgs e)
		{
			base.OnPaint(e);
			using (global::DevAge.Drawing.GraphicsCache graphicsCache = new global::DevAge.Drawing.GraphicsCache(e.Graphics, e.ClipRectangle))
			{
				foreach (global::SourceGrid.Range drawingRange in this.GetVisibleRegion())
				{
					this.OnRangePaint(new global::SourceGrid.RangePaintEventArgs(this, graphicsCache, drawingRange));
				}
			}
		}

		// Token: 0x140000AD RID: 173
		// (add) Token: 0x06002753 RID: 10067 RVA: 0x00088C00 File Offset: 0x00086E00
		// (remove) Token: 0x06002754 RID: 10068 RVA: 0x00088C1C File Offset: 0x00086E1C
		public event global::SourceGrid.RangePaintEventHandler RangePaint;

		// Token: 0x06002755 RID: 10069 RVA: 0x00088C38 File Offset: 0x00086E38
		protected virtual void OnRangePaint(global::SourceGrid.RangePaintEventArgs e)
		{
			global::System.Drawing.Rectangle clip = this.RangeToRectangle(e.DrawingRange);
			global::System.Drawing.Drawing2D.GraphicsState gstate = e.GraphicsCache.Graphics.Save();
			try
			{
				e.GraphicsCache.Graphics.SetClip(clip);
				int num = clip.Top;
				for (int i = e.DrawingRange.Start.Row; i <= e.DrawingRange.End.Row; i++)
				{
					int height = this.Rows.GetHeight(i);
					int num2 = clip.Left;
					for (int j = e.DrawingRange.Start.Column; j <= e.DrawingRange.End.Column; j++)
					{
						int width = this.Columns.GetWidth(j);
						global::SourceGrid.Position position = new global::SourceGrid.Position(i, j);
						global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(position);
						if (cell != null)
						{
							global::System.Drawing.Rectangle rectangle = new global::System.Drawing.Rectangle(num2, num, width, height);
							if (e.GraphicsCache.ClipRectangle.IsEmpty || e.GraphicsCache.ClipRectangle.IntersectsWith(rectangle))
							{
								global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this, position, cell);
								this.PaintCell(e.GraphicsCache, cellContext, rectangle);
							}
						}
						num2 += width;
					}
					num += height;
				}
				foreach (global::SourceGrid.Decorators.DecoratorBase decoratorBase in this.Decorators)
				{
					if (decoratorBase.IntersectWith(e.DrawingRange))
					{
						decoratorBase.Draw(e);
					}
				}
				if (this.RangePaint != null)
				{
					this.RangePaint(this, e);
				}
			}
			finally
			{
				e.GraphicsCache.Graphics.Restore(gstate);
			}
		}

		// Token: 0x06002756 RID: 10070 RVA: 0x00088E6C File Offset: 0x0008706C
		protected virtual void PaintCell(global::DevAge.Drawing.GraphicsCache graphics, global::SourceGrid.CellContext cellContext, global::System.Drawing.RectangleF drawRectangle)
		{
			if (drawRectangle.Width > 0f && drawRectangle.Height > 0f && cellContext.CanBeDrawn())
			{
				cellContext.Cell.View.DrawCell(cellContext, graphics, drawRectangle);
			}
		}

		// Token: 0x06002757 RID: 10071 RVA: 0x00088EC0 File Offset: 0x000870C0
		protected override void OnMouseMove(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseMove(e);
			global::SourceGrid.Position position = this.PositionAtPoint(new global::System.Drawing.Point(e.X, e.Y));
			global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(position);
			if (!this.MouseDownPosition.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell2 = this.GetCell(this.MouseDownPosition);
				if (cell2 != null)
				{
					this.Controller.OnMouseMove(new global::SourceGrid.CellContext(this, this.MouseDownPosition, cell2), e);
					return;
				}
			}
			else
			{
				this.ChangeMouseCell(position);
				if (!position.IsEmpty() && cell != null)
				{
					this.Controller.OnMouseMove(new global::SourceGrid.CellContext(this, position, cell), e);
				}
			}
		}

		// Token: 0x06002758 RID: 10072 RVA: 0x00088F68 File Offset: 0x00087168
		protected override void OnMouseLeave(global::System.EventArgs e)
		{
			base.OnMouseLeave(e);
			this.ChangeMouseCell(global::SourceGrid.Position.Empty);
		}

		// Token: 0x06002759 RID: 10073 RVA: 0x00088F7C File Offset: 0x0008717C
		protected override void OnMouseDown(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDown(e);
			if (!this.Selection.ActivePosition.IsEmpty())
			{
				global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this, this.Selection.ActivePosition);
				if (cellContext.Cell != null && cellContext.IsEditing() && !cellContext.EndEdit(false))
				{
					return;
				}
			}
			global::SourceGrid.Position position = this.PositionAtPoint(new global::System.Drawing.Point(e.X, e.Y));
			if (!position.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(position);
				if (cell != null)
				{
					this.ChangeMouseDownCell(position, position);
					global::SourceGrid.CellContext sender = new global::SourceGrid.CellContext(this, position, cell);
					this.Controller.OnMouseDown(sender, e);
					return;
				}
			}
			else
			{
				this.ChangeMouseDownCell(global::SourceGrid.Position.Empty, global::SourceGrid.Position.Empty);
			}
		}

		// Token: 0x0600275A RID: 10074 RVA: 0x00089048 File Offset: 0x00087248
		protected override void OnMouseUp(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(e);
			if (!this.MouseDownPosition.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.MouseDownPosition);
				if (cell != null)
				{
					this.Controller.OnMouseUp(new global::SourceGrid.CellContext(this, this.MouseDownPosition, cell), e);
				}
				this.ChangeMouseDownCell(global::SourceGrid.Position.Empty, this.PositionAtPoint(new global::System.Drawing.Point(e.X, e.Y)));
			}
		}

		// Token: 0x0600275B RID: 10075 RVA: 0x000890C4 File Offset: 0x000872C4
		protected override void OnMouseClick(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseClick(e);
			global::SourceGrid.Position right = this.PositionAtPoint(base.PointToClient(global::System.Windows.Forms.Control.MousePosition));
			if (!this.MouseDownPosition.IsEmpty() && this.MouseDownPosition == right)
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.MouseDownPosition);
				if (cell != null)
				{
					this.Controller.OnClick(new global::SourceGrid.CellContext(this, this.MouseDownPosition, cell), e);
				}
			}
		}

		// Token: 0x0600275C RID: 10076 RVA: 0x00089140 File Offset: 0x00087340
		protected override void OnMouseDoubleClick(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseDoubleClick(e);
			if (!this.MouseDownPosition.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.MouseDownPosition);
				if (cell != null)
				{
					this.Controller.OnDoubleClick(new global::SourceGrid.CellContext(this, this.MouseDownPosition, cell), e);
				}
			}
		}

		// Token: 0x0600275D RID: 10077 RVA: 0x00089198 File Offset: 0x00087398
		protected override void OnMouseWheel(global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseWheel(e);
			this.CustomScrollWheel(e.Delta);
		}

		// Token: 0x0600275E RID: 10078 RVA: 0x000891B0 File Offset: 0x000873B0
		protected override void OnKeyDown(global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyDown(e);
			if (!this.Selection.ActivePosition.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.Selection.ActivePosition);
				if (cell != null)
				{
					this.Controller.OnKeyDown(new global::SourceGrid.CellContext(this, this.Selection.ActivePosition, cell), e);
				}
			}
			if (!e.Handled)
			{
				this.ProcessSpecialGridKey(e);
			}
		}

		// Token: 0x0600275F RID: 10079 RVA: 0x00089228 File Offset: 0x00087428
		protected override void OnKeyUp(global::System.Windows.Forms.KeyEventArgs e)
		{
			base.OnKeyUp(e);
			if (!this.Selection.ActivePosition.IsEmpty())
			{
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.Selection.ActivePosition);
				if (cell != null)
				{
					this.Controller.OnKeyUp(new global::SourceGrid.CellContext(this, this.Selection.ActivePosition, cell), e);
				}
			}
		}

		// Token: 0x06002760 RID: 10080 RVA: 0x00089290 File Offset: 0x00087490
		protected override void OnKeyPress(global::System.Windows.Forms.KeyPressEventArgs e)
		{
			base.OnKeyPress(e);
			if (!this.Selection.ActivePosition.IsEmpty() && e.KeyChar != '\t' && e.KeyChar != '\r' && e.KeyChar != '\u0003' && e.KeyChar != '\u0016')
			{
				if (e.KeyChar == '\u0018')
				{
					return;
				}
				global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(this.Selection.ActivePosition);
				if (cell != null)
				{
					this.Controller.OnKeyPress(new global::SourceGrid.CellContext(this, this.Selection.ActivePosition, cell), e);
				}
			}
		}

		// Token: 0x06002761 RID: 10081 RVA: 0x00089338 File Offset: 0x00087538
		protected override void OnEnter(global::System.EventArgs e)
		{
			base.OnEnter(e);
			if ((this.Selection.FocusStyle & global::SourceGrid.FocusStyle.FocusFirstCellOnEnter) == global::SourceGrid.FocusStyle.FocusFirstCellOnEnter && this.Selection.ActivePosition.IsEmpty())
			{
				this.Selection.FocusFirstCell(false);
			}
		}

		// Token: 0x06002762 RID: 10082 RVA: 0x00089388 File Offset: 0x00087588
		protected override void OnValidated(global::System.EventArgs e)
		{
			base.OnValidated(e);
			if ((this.Selection.FocusStyle & global::SourceGrid.FocusStyle.RemoveFocusCellOnLeave) == global::SourceGrid.FocusStyle.RemoveFocusCellOnLeave)
			{
				this.Selection.Focus(global::SourceGrid.Position.Empty, false);
			}
			if ((this.Selection.FocusStyle & global::SourceGrid.FocusStyle.RemoveSelectionOnLeave) == global::SourceGrid.FocusStyle.RemoveSelectionOnLeave)
			{
				this.Selection.ResetSelection(true);
			}
		}

		// Token: 0x17000C0D RID: 3085
		// (get) Token: 0x06002763 RID: 10083 RVA: 0x000893E4 File Offset: 0x000875E4
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public global::SourceGrid.LinkedControlsList LinkedControls
		{
			get
			{
				return this.m_LinkedControls;
			}
		}

		// Token: 0x06002764 RID: 10084 RVA: 0x000893EC File Offset: 0x000875EC
		protected override void OnHScrollPositionChanged(global::SourceGrid.ScrollPositionChangedEventArgs e)
		{
			base.OnHScrollPositionChanged(e);
			this.ArrangeLinkedControls();
		}

		// Token: 0x06002765 RID: 10085 RVA: 0x000893FC File Offset: 0x000875FC
		protected override void OnVScrollPositionChanged(global::SourceGrid.ScrollPositionChangedEventArgs e)
		{
			base.OnVScrollPositionChanged(e);
			this.ArrangeLinkedControls();
		}

		// Token: 0x06002766 RID: 10086 RVA: 0x0008940C File Offset: 0x0008760C
		public virtual void ArrangeLinkedControls()
		{
			base.SuspendLayout();
			foreach (global::SourceGrid.LinkedControlValue linkedControlValue in this.m_LinkedControls)
			{
				if (!linkedControlValue.Position.IsEmpty())
				{
					global::System.Windows.Forms.Control control = linkedControlValue.Control;
					global::SourceGrid.Cells.ICellVirtual cell = this.GetCell(linkedControlValue.Position);
					global::System.Drawing.Rectangle rectangle = this.PositionToRectangle(linkedControlValue.Position);
					if (cell != null && linkedControlValue.UseCellBorder)
					{
						rectangle = global::System.Drawing.Rectangle.Round(cell.View.Border.GetContentRectangle(rectangle));
					}
					control.Bounds = rectangle;
				}
			}
			base.ResumeLayout(false);
		}

		// Token: 0x06002767 RID: 10087 RVA: 0x000894D8 File Offset: 0x000876D8
		private void PerformStretch()
		{
			if (this.AutoStretchColumnsToFitWidth || this.AutoStretchRowsToFitHeight)
			{
				if (this.AutoStretchColumnsToFitWidth && this.AutoStretchRowsToFitHeight)
				{
					this.Rows.AutoSize(false);
					this.Columns.AutoSize(false);
					this.Columns.StretchToFit();
					this.Rows.StretchToFit();
					return;
				}
				if (this.AutoStretchColumnsToFitWidth)
				{
					this.Columns.AutoSize(true);
					this.Columns.StretchToFit();
					return;
				}
				if (this.AutoStretchRowsToFitHeight)
				{
					this.Rows.AutoSize(true);
					this.Rows.StretchToFit();
				}
			}
		}

		// Token: 0x06002768 RID: 10088 RVA: 0x0008958C File Offset: 0x0008778C
		protected override void OnResize(global::System.EventArgs e)
		{
			base.OnResize(e);
			base.SuspendLayout();
			this.SetScrollArea();
			this.PerformStretch();
			base.ResumeLayout(true);
		}

		// Token: 0x06002769 RID: 10089 RVA: 0x000895C0 File Offset: 0x000877C0
		public virtual void OnCellsAreaChanged()
		{
			base.SuspendLayout();
			this.SetScrollArea();
			this.CheckPositions();
			this.ArrangeLinkedControls();
			base.ResumeLayout(true);
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000895F0 File Offset: 0x000877F0
		protected void SetScrollArea()
		{
			int verticalPage = global::System.Math.Max(this.Rows.Count / 10, 1);
			int horizontalPage = global::System.Math.Max(this.Columns.Count / 10, 1);
			base.LoadScrollArea(verticalPage, horizontalPage);
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x00089634 File Offset: 0x00087834
		public void SortRangeRows(global::SourceGrid.IRangeLoader p_RangeToSort, int keyColumn, bool p_bAsc, global::System.Collections.IComparer p_CellComparer)
		{
			global::SourceGrid.Range range = p_RangeToSort.GetRange(this);
			this.SortRangeRows(range, keyColumn, p_bAsc, p_CellComparer);
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x00089658 File Offset: 0x00087858
		public void SortRangeRows(global::SourceGrid.Range p_Range, int keyColumn, bool p_bAscending, global::System.Collections.IComparer p_CellComparer)
		{
			global::SourceGrid.SortRangeRowsEventArgs e = new global::SourceGrid.SortRangeRowsEventArgs(p_Range, keyColumn, p_bAscending, p_CellComparer);
			if (this.SortingRangeRows != null)
			{
				this.SortingRangeRows(this, e);
			}
			this.OnSortingRangeRows(e);
			if (this.SortedRangeRows != null)
			{
				this.SortedRangeRows(this, e);
			}
			this.OnSortedRangeRows(e);
		}

		// Token: 0x140000AE RID: 174
		// (add) Token: 0x0600276D RID: 10093 RVA: 0x000896B4 File Offset: 0x000878B4
		// (remove) Token: 0x0600276E RID: 10094 RVA: 0x000896D0 File Offset: 0x000878D0
		[global::System.ComponentModel.Browsable(true)]
		public event global::SourceGrid.SortRangeRowsEventHandler SortingRangeRows;

		// Token: 0x140000AF RID: 175
		// (add) Token: 0x0600276F RID: 10095 RVA: 0x000896EC File Offset: 0x000878EC
		// (remove) Token: 0x06002770 RID: 10096 RVA: 0x00089708 File Offset: 0x00087908
		[global::System.ComponentModel.Browsable(true)]
		public event global::SourceGrid.SortRangeRowsEventHandler SortedRangeRows;

		// Token: 0x06002771 RID: 10097 RVA: 0x00089724 File Offset: 0x00087924
		protected virtual void OnSortingRangeRows(global::SourceGrid.SortRangeRowsEventArgs e)
		{
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x00089728 File Offset: 0x00087928
		protected virtual void OnSortedRangeRows(global::SourceGrid.SortRangeRowsEventArgs e)
		{
		}

		// Token: 0x06002773 RID: 10099
		public abstract global::SourceGrid.Cells.ICellVirtual GetCell(int row, int column);

		// Token: 0x06002774 RID: 10100 RVA: 0x0008972C File Offset: 0x0008792C
		public global::SourceGrid.Cells.ICellVirtual GetCell(global::SourceGrid.Position p_Position)
		{
			if (p_Position.IsEmpty())
			{
				return null;
			}
			return this.GetCell(p_Position.Row, p_Position.Column);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x00089760 File Offset: 0x00087960
		public virtual global::SourceGrid.Cells.ICellVirtual[] GetCellsAtRow(int p_RowIndex)
		{
			global::SourceGrid.Cells.ICellVirtual[] array = new global::SourceGrid.Cells.ICellVirtual[this.Columns.Count];
			for (int i = 0; i < this.Columns.Count; i++)
			{
				array[i] = this.GetCell(p_RowIndex, i);
			}
			return array;
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000897AC File Offset: 0x000879AC
		public virtual global::SourceGrid.Cells.ICellVirtual[] GetCellsAtColumn(int p_ColumnIndex)
		{
			global::SourceGrid.Cells.ICellVirtual[] array = new global::SourceGrid.Cells.ICellVirtual[this.Rows.Count];
			for (int i = 0; i < this.Rows.Count; i++)
			{
				array[i] = this.GetCell(i, p_ColumnIndex);
			}
			return array;
		}

		// Token: 0x17000C0E RID: 3086
		// (get) Token: 0x06002777 RID: 10103 RVA: 0x000897F8 File Offset: 0x000879F8
		// (set) Token: 0x06002778 RID: 10104 RVA: 0x00089800 File Offset: 0x00087A00
		[global::System.ComponentModel.DefaultValue(0)]
		public int FixedRows
		{
			get
			{
				return this.m_FixedRows;
			}
			set
			{
				if (this.m_FixedRows != value)
				{
					this.m_FixedRows = value;
					this.OnCellsAreaChanged();
				}
			}
		}

		// Token: 0x17000C0F RID: 3087
		// (get) Token: 0x06002779 RID: 10105 RVA: 0x0008981C File Offset: 0x00087A1C
		public int ActualFixedRows
		{
			get
			{
				if (this.FixedRows > this.Rows.Count)
				{
					return this.Rows.Count;
				}
				return this.FixedRows;
			}
		}

		// Token: 0x17000C10 RID: 3088
		// (get) Token: 0x0600277A RID: 10106 RVA: 0x00089858 File Offset: 0x00087A58
		// (set) Token: 0x0600277B RID: 10107 RVA: 0x00089860 File Offset: 0x00087A60
		[global::System.ComponentModel.DefaultValue(0)]
		public int FixedColumns
		{
			get
			{
				return this.m_FixedCols;
			}
			set
			{
				if (this.m_FixedCols != value)
				{
					this.m_FixedCols = value;
					this.OnCellsAreaChanged();
				}
			}
		}

		// Token: 0x17000C11 RID: 3089
		// (get) Token: 0x0600277C RID: 10108 RVA: 0x0008987C File Offset: 0x00087A7C
		public int ActualFixedColumns
		{
			get
			{
				if (this.FixedColumns > this.Columns.Count)
				{
					return this.Columns.Count;
				}
				return this.FixedColumns;
			}
		}

		// Token: 0x17000C12 RID: 3090
		// (get) Token: 0x0600277D RID: 10109 RVA: 0x000898B8 File Offset: 0x00087AB8
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.RowsBase Rows
		{
			get
			{
				return this.m_Rows;
			}
		}

		// Token: 0x17000C13 RID: 3091
		// (get) Token: 0x0600277E RID: 10110 RVA: 0x000898C0 File Offset: 0x00087AC0
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.ColumnsBase Columns
		{
			get
			{
				return this.m_Columns;
			}
		}

		// Token: 0x0600277F RID: 10111 RVA: 0x000898C8 File Offset: 0x00087AC8
		public global::SourceGrid.CellPositionType GetPositionType(global::SourceGrid.Position position)
		{
			if (position.IsEmpty())
			{
				return global::SourceGrid.CellPositionType.Empty;
			}
			if (position.Row < this.FixedRows && position.Column < this.FixedColumns)
			{
				return global::SourceGrid.CellPositionType.FixedTopLeft;
			}
			if (position.Row < this.FixedRows)
			{
				return global::SourceGrid.CellPositionType.FixedTop;
			}
			if (position.Column < this.FixedColumns)
			{
				return global::SourceGrid.CellPositionType.FixedLeft;
			}
			return global::SourceGrid.CellPositionType.Scrollable;
		}

		// Token: 0x17000C14 RID: 3092
		// (get) Token: 0x06002780 RID: 10112 RVA: 0x00089938 File Offset: 0x00087B38
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		[global::System.ComponentModel.Browsable(false)]
		public global::SourceGrid.Range CompleteRange
		{
			get
			{
				if (this.Rows.Count > 0 && this.Columns.Count > 0)
				{
					return new global::SourceGrid.Range(0, 0, this.Rows.Count - 1, this.Columns.Count - 1);
				}
				return global::SourceGrid.Range.Empty;
			}
		}

		// Token: 0x140000B0 RID: 176
		// (add) Token: 0x06002781 RID: 10113 RVA: 0x00089994 File Offset: 0x00087B94
		// (remove) Token: 0x06002782 RID: 10114 RVA: 0x000899B0 File Offset: 0x00087BB0
		public event global::SourceGrid.ExceptionEventHandler UserException;

		// Token: 0x06002783 RID: 10115 RVA: 0x000899CC File Offset: 0x00087BCC
		public virtual void OnUserException(global::SourceGrid.ExceptionEventArgs e)
		{
			if (this.UserException != null)
			{
				this.UserException(this, e);
			}
			if (!e.Handled)
			{
				global::DevAge.Windows.Forms.ErrorDialog.Show(this, e.Exception, "Error");
				e.Handled = true;
			}
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x06002784 RID: 10116 RVA: 0x00089A0C File Offset: 0x00087C0C
		// (set) Token: 0x06002785 RID: 10117 RVA: 0x00089A14 File Offset: 0x00087C14
		[global::System.ComponentModel.DefaultValue(false)]
		[global::System.ComponentModel.Category("Appearance")]
		[global::System.ComponentModel.Browsable(true)]
		[global::System.ComponentModel.Description("Change the right-to-left layout.")]
		[global::System.ComponentModel.Localizable(true)]
		public bool Mirrored
		{
			get
			{
				return this.m_Mirrored;
			}
			set
			{
				if (this.m_Mirrored != value)
				{
					this.m_Mirrored = value;
					base.OnRightToLeftChanged(global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x06002786 RID: 10118 RVA: 0x00089A34 File Offset: 0x00087C34
		protected override global::System.Windows.Forms.CreateParams CreateParams
		{
			get
			{
				global::System.Windows.Forms.CreateParams createParams = base.CreateParams;
				if (this.Mirrored)
				{
					createParams.ExStyle |= 4194304;
				}
				return createParams;
			}
		}

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x06002787 RID: 10119 RVA: 0x00089A6C File Offset: 0x00087C6C
		// (set) Token: 0x06002788 RID: 10120 RVA: 0x00089A70 File Offset: 0x00087C70
		[global::System.ComponentModel.Browsable(false)]
		[global::System.ComponentModel.DefaultValue(global::System.Windows.Forms.RightToLeft.No)]
		[global::System.ComponentModel.DesignerSerializationVisibility(global::System.ComponentModel.DesignerSerializationVisibility.Hidden)]
		public override global::System.Windows.Forms.RightToLeft RightToLeft
		{
			get
			{
				return global::System.Windows.Forms.RightToLeft.No;
			}
			set
			{
			}
		}

		// Token: 0x06002789 RID: 10121 RVA: 0x00089A74 File Offset: 0x00087C74
		public virtual void ClearValues(global::SourceGrid.RangeRegion region)
		{
			global::SourceGrid.PositionCollection cellsPositions = region.GetCellsPositions();
			foreach (global::SourceGrid.Position pPosition in cellsPositions)
			{
				global::SourceGrid.CellContext cellContext = new global::SourceGrid.CellContext(this, pPosition);
				if (cellContext.Cell != null && cellContext.Cell.Editor != null)
				{
					cellContext.Cell.Editor.ClearCell(cellContext);
				}
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x0600278A RID: 10122 RVA: 0x00089B00 File Offset: 0x00087D00
		// (set) Token: 0x0600278B RID: 10123 RVA: 0x00089B10 File Offset: 0x00087D10
		public string ToolTipText
		{
			get
			{
				return this.toolTip.GetToolTip(this);
			}
			set
			{
				this.toolTip.SetToolTip(this, value);
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x0600278C RID: 10124 RVA: 0x00089B20 File Offset: 0x00087D20
		public global::System.Windows.Forms.ToolTip ToolTip
		{
			get
			{
				return this.toolTip;
			}
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x0600278D RID: 10125 RVA: 0x00089B28 File Offset: 0x00087D28
		public global::SourceGrid.Decorators.DecoratorList Decorators
		{
			get
			{
				return this.mDecorators;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x00089B30 File Offset: 0x00087D30
		public global::SourceGrid.Cells.Controllers.ControllerContainer Controller
		{
			get
			{
				return this.mController;
			}
		}

		// Token: 0x17000C1C RID: 3100
		// (get) Token: 0x0600278F RID: 10127 RVA: 0x00089B38 File Offset: 0x00087D38
		// (set) Token: 0x06002790 RID: 10128 RVA: 0x00089B40 File Offset: 0x00087D40
		[global::System.ComponentModel.DefaultValue(global::SourceGrid.ClipboardMode.None)]
		public global::SourceGrid.ClipboardMode ClipboardMode
		{
			get
			{
				return this.mClipboardMode;
			}
			set
			{
				this.mClipboardMode = value;
			}
		}

		// Token: 0x04000DB6 RID: 3510
		private const int WS_EX_LAYOUTRTL = 4194304;

		// Token: 0x04000DB7 RID: 3511
		private const int WS_EX_NOINHERITLAYOUT = 1048576;

		// Token: 0x04000DB8 RID: 3512
		private int mDefaultHeight = 20;

		// Token: 0x04000DB9 RID: 3513
		private int mDefaultWidth = 50;

		// Token: 0x04000DBA RID: 3514
		private int mMinimumHeight;

		// Token: 0x04000DBB RID: 3515
		private int mMinimumWidth;

		// Token: 0x04000DBC RID: 3516
		private bool m_bAutoStretchColumnsToFitWidth;

		// Token: 0x04000DBD RID: 3517
		private bool m_bAutoStretchRowsToFitHeight;

		// Token: 0x04000DBE RID: 3518
		private global::SourceGrid.Position mDragCellPosition = global::SourceGrid.Position.Empty;

		// Token: 0x04000DBF RID: 3519
		private global::SourceGrid.Selection.SelectionBase mSelection;

		// Token: 0x04000DC0 RID: 3520
		private global::SourceGrid.GridSelectionMode mSelectionMode;

		// Token: 0x04000DC1 RID: 3521
		protected global::SourceGrid.Position m_MouseDownPosition = global::SourceGrid.Position.Empty;

		// Token: 0x04000DC2 RID: 3522
		protected global::SourceGrid.Position m_MouseCellPosition = global::SourceGrid.Position.Empty;

		// Token: 0x04000DC3 RID: 3523
		private global::SourceGrid.Range m_OldMouseSelectionRange = global::SourceGrid.Range.Empty;

		// Token: 0x04000DC4 RID: 3524
		private global::SourceGrid.Range m_MouseSelectionRange = global::SourceGrid.Range.Empty;

		// Token: 0x04000DC5 RID: 3525
		private bool m_OverrideCommonCmdKey = true;

		// Token: 0x04000DC6 RID: 3526
		private global::SourceGrid.GridSpecialKeys m_GridSpecialKeys = global::SourceGrid.GridSpecialKeys.Default;

		// Token: 0x04000DC7 RID: 3527
		private bool mAcceptsInputChar = true;

		// Token: 0x04000DC9 RID: 3529
		private global::SourceGrid.LinkedControlsList m_LinkedControls;

		// Token: 0x04000DCC RID: 3532
		private int m_FixedRows;

		// Token: 0x04000DCD RID: 3533
		private int m_FixedCols;

		// Token: 0x04000DCE RID: 3534
		private global::SourceGrid.RowsBase m_Rows;

		// Token: 0x04000DCF RID: 3535
		private global::SourceGrid.ColumnsBase m_Columns;

		// Token: 0x04000DD1 RID: 3537
		private bool m_Mirrored;

		// Token: 0x04000DD2 RID: 3538
		private global::System.Windows.Forms.ToolTip toolTip;

		// Token: 0x04000DD3 RID: 3539
		private global::SourceGrid.Decorators.DecoratorList mDecorators = new global::SourceGrid.Decorators.DecoratorList();

		// Token: 0x04000DD4 RID: 3540
		private global::SourceGrid.Cells.Controllers.ControllerContainer mController = new global::SourceGrid.Cells.Controllers.ControllerContainer();

		// Token: 0x04000DD5 RID: 3541
		private global::SourceGrid.ClipboardMode mClipboardMode;
	}
}
