using System;
using System.Drawing;
using DevAge.Drawing;
using SourceGrid.Cells;

namespace SourceGrid.Selection
{
	// Token: 0x02000335 RID: 821
	internal abstract class SelectionBase
	{
		// Token: 0x06002685 RID: 9861 RVA: 0x000856D8 File Offset: 0x000838D8
		public SelectionBase()
		{
		}

		// Token: 0x06002686 RID: 9862 RVA: 0x00085744 File Offset: 0x00083944
		public virtual void BindToGrid(global::SourceGrid.GridVirtual p_grid)
		{
			this.mGrid = p_grid;
		}

		// Token: 0x06002687 RID: 9863 RVA: 0x00085750 File Offset: 0x00083950
		public virtual void UnBindToGrid()
		{
			this.mGrid = null;
		}

		// Token: 0x17000BE9 RID: 3049
		// (get) Token: 0x06002688 RID: 9864 RVA: 0x0008575C File Offset: 0x0008395C
		public global::SourceGrid.GridVirtual Grid
		{
			get
			{
				return this.mGrid;
			}
		}

		// Token: 0x17000BEA RID: 3050
		// (get) Token: 0x06002689 RID: 9865 RVA: 0x00085764 File Offset: 0x00083964
		public global::SourceGrid.Position ActivePosition
		{
			get
			{
				return this.m_ActivePosition;
			}
		}

		// Token: 0x0600268A RID: 9866 RVA: 0x0008576C File Offset: 0x0008396C
		private bool IsActivePositionValid()
		{
			return !this.ActivePosition.IsEmpty() && this.Grid != null && this.Grid.CompleteRange.Contains(this.ActivePosition);
		}

		// Token: 0x0600268B RID: 9867 RVA: 0x000857B8 File Offset: 0x000839B8
		public bool Focus(global::SourceGrid.Position pCellToActivate, bool pResetSelection)
		{
			bool flag = false;
			if (!pCellToActivate.IsEmpty() && pResetSelection)
			{
				flag = true;
			}
			pCellToActivate = this.Grid.PositionToStartPosition(pCellToActivate);
			if (!(pCellToActivate != this.ActivePosition))
			{
				return pCellToActivate.IsEmpty() || this.Grid.ContainsFocus || this.Grid.Focus();
			}
			global::SourceGrid.Cells.ICellVirtual cell = this.Grid.GetCell(pCellToActivate);
			global::SourceGrid.CellContext sender = new global::SourceGrid.CellContext(this.Grid, pCellToActivate, cell);
			global::SourceGrid.ChangeActivePositionEventArgs changeActivePositionEventArgs = new global::SourceGrid.ChangeActivePositionEventArgs(this.ActivePosition, pCellToActivate);
			if (cell != null)
			{
				this.Grid.Controller.OnFocusEntering(sender, changeActivePositionEventArgs);
				if (changeActivePositionEventArgs.Cancel)
				{
					return false;
				}
				if (!this.Grid.Controller.CanReceiveFocus(sender, changeActivePositionEventArgs))
				{
					return false;
				}
			}
			if (cell != null && !this.Grid.Focus())
			{
				return false;
			}
			global::SourceGrid.RangeRegion removedRange = null;
			if (this.IsActivePositionValid())
			{
				removedRange = new global::SourceGrid.RangeRegion(this.ActivePosition);
				global::SourceGrid.Cells.ICellVirtual cell2 = this.Grid.GetCell(this.ActivePosition);
				global::SourceGrid.CellContext sender2 = new global::SourceGrid.CellContext(this.Grid, this.ActivePosition, cell2);
				global::SourceGrid.ChangeActivePositionEventArgs changeActivePositionEventArgs2 = new global::SourceGrid.ChangeActivePositionEventArgs(this.ActivePosition, pCellToActivate);
				this.Grid.Controller.OnFocusLeaving(sender2, changeActivePositionEventArgs2);
				if (changeActivePositionEventArgs2.Cancel)
				{
					return false;
				}
				this.OnCellLostFocus(changeActivePositionEventArgs2);
				if (changeActivePositionEventArgs2.Cancel)
				{
					return false;
				}
			}
			else
			{
				this.m_ActivePosition = global::SourceGrid.Position.Empty;
			}
			if (flag)
			{
				this.ResetSelection(false);
			}
			bool result;
			if (cell != null)
			{
				this.OnCellGotFocus(changeActivePositionEventArgs);
				result = !changeActivePositionEventArgs.Cancel;
			}
			else
			{
				result = true;
			}
			global::SourceGrid.RangeRegion addedRange = new global::SourceGrid.RangeRegion(pCellToActivate);
			this.OnSelectionChanged(new global::SourceGrid.RangeRegionChangedEventArgs(addedRange, removedRange));
			return result;
		}

		// Token: 0x0600268C RID: 9868 RVA: 0x00085988 File Offset: 0x00083B88
		public virtual bool FocusFirstCell(bool pResetSelection)
		{
			global::SourceGrid.PositionCollection cellsPositions = this.GetSelectionRegion().GetCellsPositions();
			global::SourceGrid.Position pCellToActivate = this.SearchForValidFocusPosition(cellsPositions);
			if (pCellToActivate.IsEmpty())
			{
				pCellToActivate = this.SearchForValidFocusPosition();
			}
			return !pCellToActivate.IsEmpty() && this.Focus(pCellToActivate, pResetSelection);
		}

		// Token: 0x0600268D RID: 9869 RVA: 0x000859D8 File Offset: 0x00083BD8
		public bool FocusColumn(int column)
		{
			if (this.Grid.Columns.Count > column)
			{
				for (int i = 0; i < this.Grid.Rows.Count; i++)
				{
					global::SourceGrid.Position position = new global::SourceGrid.Position(i, column);
					if (this.Grid.Controller.CanReceiveFocus(new global::SourceGrid.CellContext(this.Grid, position), global::System.EventArgs.Empty))
					{
						return this.Focus(position, true);
					}
				}
				return this.Focus(global::SourceGrid.Position.Empty, true);
			}
			return this.Focus(global::SourceGrid.Position.Empty, true);
		}

		// Token: 0x0600268E RID: 9870 RVA: 0x00085A70 File Offset: 0x00083C70
		public bool FocusRow(int row)
		{
			if (this.Grid.Rows.Count > row)
			{
				for (int i = 0; i < this.Grid.Columns.Count; i++)
				{
					global::SourceGrid.Position position = new global::SourceGrid.Position(row, i);
					if (this.Grid.Controller.CanReceiveFocus(new global::SourceGrid.CellContext(this.Grid, position), global::System.EventArgs.Empty))
					{
						return this.Focus(position, true);
					}
				}
				return this.Focus(global::SourceGrid.Position.Empty, true);
			}
			return this.Focus(global::SourceGrid.Position.Empty, true);
		}

		// Token: 0x0600268F RID: 9871 RVA: 0x00085B08 File Offset: 0x00083D08
		private global::SourceGrid.Position SearchForValidFocusPosition(global::SourceGrid.PositionCollection positions)
		{
			foreach (global::SourceGrid.Position position in positions)
			{
				if (this.CanReceiveFocus(position))
				{
					return position;
				}
			}
			return global::SourceGrid.Position.Empty;
		}

		// Token: 0x06002690 RID: 9872 RVA: 0x00085B70 File Offset: 0x00083D70
		private global::SourceGrid.Position SearchForValidFocusPosition()
		{
			for (int i = this.Grid.FixedRows; i < this.Grid.Rows.Count; i++)
			{
				for (int j = this.Grid.FixedColumns; j < this.Grid.Columns.Count; j++)
				{
					global::SourceGrid.Position position = new global::SourceGrid.Position(i, j);
					if (this.CanReceiveFocus(position))
					{
						return position;
					}
				}
			}
			return global::SourceGrid.Position.Empty;
		}

		// Token: 0x17000BEB RID: 3051
		// (get) Token: 0x06002691 RID: 9873 RVA: 0x00085BF0 File Offset: 0x00083DF0
		// (set) Token: 0x06002692 RID: 9874 RVA: 0x00085BF8 File Offset: 0x00083DF8
		public global::System.Drawing.Color FocusBackColor
		{
			get
			{
				return this.m_FocusBackColor;
			}
			set
			{
				this.m_FocusBackColor = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000BEC RID: 3052
		// (get) Token: 0x06002693 RID: 9875 RVA: 0x00085C08 File Offset: 0x00083E08
		// (set) Token: 0x06002694 RID: 9876 RVA: 0x00085C10 File Offset: 0x00083E10
		public global::SourceGrid.FocusStyle FocusStyle
		{
			get
			{
				return this.m_FocusStyle;
			}
			set
			{
				this.m_FocusStyle = value;
			}
		}

		// Token: 0x06002695 RID: 9877 RVA: 0x00085C1C File Offset: 0x00083E1C
		public bool CanReceiveFocus(global::SourceGrid.Position position)
		{
			if (!this.Grid.CompleteRange.Contains(position))
			{
				return false;
			}
			global::SourceGrid.Cells.ICellVirtual cell = this.Grid.GetCell(position);
			if (cell != null)
			{
				global::SourceGrid.CellContext sender = new global::SourceGrid.CellContext(this.Grid, position, cell);
				return this.Grid.Controller.CanReceiveFocus(sender, global::System.EventArgs.Empty);
			}
			return false;
		}

		// Token: 0x140000A4 RID: 164
		// (add) Token: 0x06002696 RID: 9878 RVA: 0x00085C8C File Offset: 0x00083E8C
		// (remove) Token: 0x06002697 RID: 9879 RVA: 0x00085CA8 File Offset: 0x00083EA8
		public event global::SourceGrid.ChangeActivePositionEventHandler CellGotFocus;

		// Token: 0x140000A5 RID: 165
		// (add) Token: 0x06002698 RID: 9880 RVA: 0x00085CC4 File Offset: 0x00083EC4
		// (remove) Token: 0x06002699 RID: 9881 RVA: 0x00085CE0 File Offset: 0x00083EE0
		public event global::SourceGrid.ChangeActivePositionEventHandler CellLostFocus;

		// Token: 0x140000A6 RID: 166
		// (add) Token: 0x0600269A RID: 9882 RVA: 0x00085CFC File Offset: 0x00083EFC
		// (remove) Token: 0x0600269B RID: 9883 RVA: 0x00085D18 File Offset: 0x00083F18
		public event global::SourceGrid.RowCancelEventHandler FocusRowLeaving;

		// Token: 0x140000A7 RID: 167
		// (add) Token: 0x0600269C RID: 9884 RVA: 0x00085D34 File Offset: 0x00083F34
		// (remove) Token: 0x0600269D RID: 9885 RVA: 0x00085D50 File Offset: 0x00083F50
		public event global::SourceGrid.RowEventHandler FocusRowEntered;

		// Token: 0x140000A8 RID: 168
		// (add) Token: 0x0600269E RID: 9886 RVA: 0x00085D6C File Offset: 0x00083F6C
		// (remove) Token: 0x0600269F RID: 9887 RVA: 0x00085D88 File Offset: 0x00083F88
		public event global::SourceGrid.ColumnCancelEventHandler FocusColumnLeaving;

		// Token: 0x140000A9 RID: 169
		// (add) Token: 0x060026A0 RID: 9888 RVA: 0x00085DA4 File Offset: 0x00083FA4
		// (remove) Token: 0x060026A1 RID: 9889 RVA: 0x00085DC0 File Offset: 0x00083FC0
		public event global::SourceGrid.ColumnEventHandler FocusColumnEntered;

		// Token: 0x060026A2 RID: 9890 RVA: 0x00085DDC File Offset: 0x00083FDC
		protected virtual void OnFocusRowLeaving(global::SourceGrid.RowCancelEventArgs e)
		{
			if (this.FocusRowLeaving != null)
			{
				this.FocusRowLeaving(this, e);
			}
		}

		// Token: 0x060026A3 RID: 9891 RVA: 0x00085DF8 File Offset: 0x00083FF8
		protected virtual void OnFocusRowEntered(global::SourceGrid.RowEventArgs e)
		{
			if (this.FocusRowEntered != null)
			{
				this.FocusRowEntered(this, e);
			}
		}

		// Token: 0x060026A4 RID: 9892 RVA: 0x00085E14 File Offset: 0x00084014
		protected virtual void OnFocusColumnLeaving(global::SourceGrid.ColumnCancelEventArgs e)
		{
			if (this.FocusColumnLeaving != null)
			{
				this.FocusColumnLeaving(this, e);
			}
		}

		// Token: 0x060026A5 RID: 9893 RVA: 0x00085E30 File Offset: 0x00084030
		protected virtual void OnFocusColumnEntered(global::SourceGrid.ColumnEventArgs e)
		{
			if (this.FocusColumnEntered != null)
			{
				this.FocusColumnEntered(this, e);
			}
		}

		// Token: 0x060026A6 RID: 9894 RVA: 0x00085E4C File Offset: 0x0008404C
		protected virtual void OnCellGotFocus(global::SourceGrid.ChangeActivePositionEventArgs e)
		{
			if (!this.Grid.CompleteRange.Contains(e.NewFocusPosition))
			{
				e.Cancel = true;
			}
			if (e.Cancel)
			{
				return;
			}
			if (this.CellGotFocus != null)
			{
				this.CellGotFocus(this, e);
			}
			if (e.Cancel)
			{
				return;
			}
			this.m_ActivePosition = e.NewFocusPosition;
			this.SelectCell(this.m_ActivePosition, true);
			this.Invalidate();
			this.Grid.Controller.OnFocusEntered(new global::SourceGrid.CellContext(this.Grid, e.NewFocusPosition), global::System.EventArgs.Empty);
			if (e.NewFocusPosition.Row != e.OldFocusPosition.Row)
			{
				this.OnFocusRowEntered(new global::SourceGrid.RowEventArgs(this.ActivePosition.Row));
			}
			if (e.NewFocusPosition.Column != e.OldFocusPosition.Column)
			{
				this.OnFocusColumnEntered(new global::SourceGrid.ColumnEventArgs(this.ActivePosition.Column));
			}
		}

		// Token: 0x060026A7 RID: 9895 RVA: 0x00085F70 File Offset: 0x00084170
		protected virtual void OnCellLostFocus(global::SourceGrid.ChangeActivePositionEventArgs e)
		{
			if (e.Cancel)
			{
				return;
			}
			if (this.CellLostFocus != null)
			{
				this.CellLostFocus(this, e);
			}
			if (e.Cancel)
			{
				return;
			}
			int row = this.ActivePosition.Row;
			if (!this.ActivePosition.IsEmpty() && row != e.NewFocusPosition.Row)
			{
				global::SourceGrid.RowCancelEventArgs rowCancelEventArgs = new global::SourceGrid.RowCancelEventArgs(row);
				this.OnFocusRowLeaving(rowCancelEventArgs);
				if (rowCancelEventArgs.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
			int column = this.ActivePosition.Column;
			if (!this.ActivePosition.IsEmpty() && column != e.NewFocusPosition.Column)
			{
				global::SourceGrid.ColumnCancelEventArgs columnCancelEventArgs = new global::SourceGrid.ColumnCancelEventArgs(column);
				this.OnFocusColumnLeaving(columnCancelEventArgs);
				if (columnCancelEventArgs.Cancel)
				{
					e.Cancel = true;
					return;
				}
			}
			this.m_ActivePosition = global::SourceGrid.Position.Empty;
			this.Grid.Controller.OnFocusLeft(new global::SourceGrid.CellContext(this.Grid, e.OldFocusPosition), global::System.EventArgs.Empty);
		}

		// Token: 0x060026A8 RID: 9896 RVA: 0x0008609C File Offset: 0x0008429C
		public bool MoveActiveCell(int rowShift, int colShift)
		{
			return this.MoveActiveCell(this.ActivePosition, rowShift, colShift);
		}

		// Token: 0x060026A9 RID: 9897 RVA: 0x000860AC File Offset: 0x000842AC
		public bool MoveActiveCell(global::SourceGrid.Position start, int rowShift, int colShift)
		{
			global::SourceGrid.Position empty = global::SourceGrid.Position.Empty;
			if (start.IsEmpty())
			{
				empty = new global::SourceGrid.Position(0, 0);
				if (this.CanReceiveFocus(empty))
				{
					return this.Focus(empty, true);
				}
				start = empty;
				empty = global::SourceGrid.Position.Empty;
			}
			int num = start.Row;
			int num2 = start.Column;
			num += rowShift;
			num2 += colShift;
			while (empty.IsEmpty() && num < this.Grid.Rows.Count && num2 < this.Grid.Columns.Count && num >= 0 && num2 >= 0)
			{
				empty = new global::SourceGrid.Position(num, num2);
				if (this.Grid.PositionToStartPosition(empty) == start)
				{
					empty = global::SourceGrid.Position.Empty;
				}
				else if (!this.CanReceiveFocus(empty))
				{
					empty = global::SourceGrid.Position.Empty;
				}
				num += rowShift;
				num2 += colShift;
			}
			return !empty.IsEmpty() && this.Focus(empty, true);
		}

		// Token: 0x060026AA RID: 9898 RVA: 0x000861B4 File Offset: 0x000843B4
		public bool MoveActiveCell(int rowShift1, int colShift1, int rowShift2, int colShift2)
		{
			return this.MoveActiveCell(this.ActivePosition, rowShift1, colShift1, rowShift2, colShift2);
		}

		// Token: 0x060026AB RID: 9899 RVA: 0x000861D8 File Offset: 0x000843D8
		public bool MoveActiveCell(global::SourceGrid.Position start, int rowShift1, int colShift1, int rowShift2, int colShift2)
		{
			bool flag = this.MoveActiveCell(start, rowShift1, colShift1);
			if (flag)
			{
				return true;
			}
			global::SourceGrid.Position empty = global::SourceGrid.Position.Empty;
			if (start.IsEmpty())
			{
				empty = new global::SourceGrid.Position(0, 0);
				if (this.CanReceiveFocus(empty))
				{
					return this.Focus(empty, true);
				}
				start = empty;
			}
			int row;
			if (rowShift2 == -2147483648)
			{
				row = 0;
			}
			else if (rowShift2 == 2147483647)
			{
				row = this.Grid.Rows.Count - 1;
			}
			else
			{
				row = start.Row + rowShift2;
			}
			int col;
			if (colShift2 == -2147483648)
			{
				col = 0;
			}
			else if (colShift2 == 2147483647)
			{
				col = this.Grid.Columns.Count - 1;
			}
			else
			{
				col = start.Column + colShift2;
			}
			empty = new global::SourceGrid.Position(row, col);
			if (empty == start || !this.Grid.CompleteRange.Contains(empty))
			{
				return false;
			}
			if (this.CanReceiveFocus(empty))
			{
				return this.Focus(empty, true);
			}
			start = empty;
			return this.MoveActiveCell(start, rowShift1, colShift1, rowShift2, colShift2);
		}

		// Token: 0x060026AC RID: 9900 RVA: 0x00086308 File Offset: 0x00084508
		public virtual void Invalidate()
		{
			foreach (global::SourceGrid.Range range in this.GetSelectionRegion())
			{
				this.Grid.InvalidateRange(range);
			}
		}

		// Token: 0x17000BED RID: 3053
		// (get) Token: 0x060026AD RID: 9901 RVA: 0x00086364 File Offset: 0x00084564
		// (set) Token: 0x060026AE RID: 9902 RVA: 0x0008636C File Offset: 0x0008456C
		public bool EnableMultiSelection
		{
			get
			{
				return this.mEnableMultiSelection;
			}
			set
			{
				this.mEnableMultiSelection = value;
			}
		}

		// Token: 0x17000BEE RID: 3054
		// (get) Token: 0x060026AF RID: 9903 RVA: 0x00086378 File Offset: 0x00084578
		// (set) Token: 0x060026B0 RID: 9904 RVA: 0x00086380 File Offset: 0x00084580
		public global::System.Drawing.Color BackColor
		{
			get
			{
				return this.mBackColor;
			}
			set
			{
				this.mBackColor = value;
				this.Invalidate();
			}
		}

		// Token: 0x17000BEF RID: 3055
		// (get) Token: 0x060026B1 RID: 9905 RVA: 0x00086390 File Offset: 0x00084590
		// (set) Token: 0x060026B2 RID: 9906 RVA: 0x00086398 File Offset: 0x00084598
		public global::DevAge.Drawing.RectangleBorder Border
		{
			get
			{
				return this.mBorder;
			}
			set
			{
				this.mBorder = value;
				this.Invalidate();
			}
		}

		// Token: 0x060026B3 RID: 9907
		public abstract bool IsSelectedColumn(int column);

		// Token: 0x060026B4 RID: 9908
		public abstract void SelectColumn(int column, bool select);

		// Token: 0x060026B5 RID: 9909
		public abstract bool IsSelectedRow(int row);

		// Token: 0x060026B6 RID: 9910
		public abstract void SelectRow(int row, bool select);

		// Token: 0x060026B7 RID: 9911
		public abstract bool IsSelectedCell(global::SourceGrid.Position position);

		// Token: 0x060026B8 RID: 9912
		public abstract void SelectCell(global::SourceGrid.Position position, bool select);

		// Token: 0x060026B9 RID: 9913
		public abstract bool IsSelectedRange(global::SourceGrid.Range range);

		// Token: 0x060026BA RID: 9914
		public abstract void SelectRange(global::SourceGrid.Range range, bool select);

		// Token: 0x060026BB RID: 9915
		protected abstract void OnResetSelection();

		// Token: 0x060026BC RID: 9916 RVA: 0x000863A8 File Offset: 0x000845A8
		public void ResetSelection(bool mantainFocus)
		{
			if (!mantainFocus && !this.ActivePosition.IsEmpty())
			{
				this.Focus(global::SourceGrid.Position.Empty, false);
			}
			this.OnResetSelection();
			if (mantainFocus && !this.ActivePosition.IsEmpty())
			{
				this.SelectCell(this.ActivePosition, true);
			}
		}

		// Token: 0x060026BD RID: 9917
		public abstract bool IsEmpty();

		// Token: 0x060026BE RID: 9918
		public abstract global::SourceGrid.RangeRegion GetSelectionRegion();

		// Token: 0x060026BF RID: 9919
		public abstract bool IntersectsWith(global::SourceGrid.Range rng);

		// Token: 0x060026C0 RID: 9920 RVA: 0x0008640C File Offset: 0x0008460C
		protected global::SourceGrid.Range ValidateRange(global::SourceGrid.Range rng)
		{
			return this.Grid.CompleteRange.Intersect(rng);
		}

		// Token: 0x140000AA RID: 170
		// (add) Token: 0x060026C1 RID: 9921 RVA: 0x00086434 File Offset: 0x00084634
		// (remove) Token: 0x060026C2 RID: 9922 RVA: 0x00086450 File Offset: 0x00084650
		public event global::SourceGrid.RangeRegionChangedEventHandler SelectionChanged;

		// Token: 0x060026C3 RID: 9923 RVA: 0x0008646C File Offset: 0x0008466C
		protected virtual void OnSelectionChanged(global::SourceGrid.RangeRegionChangedEventArgs e)
		{
			if (this.SelectionChanged != null)
			{
				this.SelectionChanged(this, e);
			}
			if (e.AddedRange != null)
			{
				foreach (global::SourceGrid.Range range in e.AddedRange)
				{
					this.Grid.InvalidateRange(range);
				}
			}
			if (e.RemovedRange != null)
			{
				foreach (global::SourceGrid.Range range2 in e.RemovedRange)
				{
					this.Grid.InvalidateRange(range2);
				}
			}
		}

		// Token: 0x04000D9B RID: 3483
		private global::SourceGrid.GridVirtual mGrid;

		// Token: 0x04000D9C RID: 3484
		private global::SourceGrid.Position m_ActivePosition = global::SourceGrid.Position.Empty;

		// Token: 0x04000D9D RID: 3485
		private global::System.Drawing.Color m_FocusBackColor = global::System.Drawing.Color.Transparent;

		// Token: 0x04000D9E RID: 3486
		private global::SourceGrid.FocusStyle m_FocusStyle = global::SourceGrid.FocusStyle.Default;

		// Token: 0x04000DA5 RID: 3493
		private bool mEnableMultiSelection = true;

		// Token: 0x04000DA6 RID: 3494
		private global::System.Drawing.Color mBackColor = global::System.Drawing.Color.FromArgb(75, global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.Highlight));

		// Token: 0x04000DA7 RID: 3495
		private global::DevAge.Drawing.RectangleBorder mBorder = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 2f));
	}
}
