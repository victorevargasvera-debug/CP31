using System;
using System.ComponentModel;
using System.Drawing;
using SourceGrid.Cells;

namespace SourceGrid
{
	// Token: 0x0200038E RID: 910
	internal struct CellContext
	{
		// Token: 0x06002AD7 RID: 10967 RVA: 0x00090320 File Offset: 0x0008E520
		public CellContext(global::SourceGrid.GridVirtual pGridVirtual, global::SourceGrid.Position pPosition, global::SourceGrid.Cells.ICellVirtual pCell)
		{
			this.Position = pPosition;
			this.Cell = pCell;
			this.Grid = pGridVirtual;
		}

		// Token: 0x06002AD8 RID: 10968 RVA: 0x00090338 File Offset: 0x0008E538
		public CellContext(global::SourceGrid.GridVirtual pGridVirtual, global::SourceGrid.Position pPosition)
		{
			this.Position = pPosition;
			this.Grid = pGridVirtual;
			this.Cell = this.Grid.GetCell(this.Position);
		}

		// Token: 0x06002AD9 RID: 10969 RVA: 0x00090360 File Offset: 0x0008E560
		public global::System.Drawing.Size Measure(global::System.Drawing.Size maxLayoutArea)
		{
			if (this.Cell == null)
			{
				return global::System.Drawing.Size.Empty;
			}
			if (this.Grid == null)
			{
				throw new global::SourceGrid.SourceGridException("Grid is null");
			}
			global::System.Drawing.Size result = this.Cell.View.Measure(this, maxLayoutArea);
			global::SourceGrid.Range range = this.Grid.PositionToCellRange(this.Position);
			result.Width = (int)global::System.Math.Ceiling((double)((float)result.Width / (float)range.ColumnsCount));
			result.Height = (int)global::System.Math.Ceiling((double)((float)result.Height / (float)range.RowsCount));
			return result;
		}

		// Token: 0x06002ADA RID: 10970 RVA: 0x00090404 File Offset: 0x0008E604
		public void StartEdit()
		{
			if (this.Cell == null)
			{
				throw new global::SourceGrid.SourceGridException("No cell at position " + this.Position.ToString());
			}
			if (this.Grid == null)
			{
				throw new global::SourceGrid.SourceGridException("Grid is null");
			}
			if (this.Cell.Editor != null && !this.IsEditing() && this.Cell.Editor.EnableEdit && this.Grid.Selection.Focus(this.Position, true))
			{
				global::System.ComponentModel.CancelEventArgs cancelEventArgs = new global::System.ComponentModel.CancelEventArgs();
				this.Grid.Controller.OnEditStarting(this, cancelEventArgs);
				if (!cancelEventArgs.Cancel)
				{
					this.Cell.Editor.InternalStartEdit(this);
					this.Grid.Controller.OnEditStarted(this, global::System.EventArgs.Empty);
				}
			}
		}

		// Token: 0x06002ADB RID: 10971 RVA: 0x000904FC File Offset: 0x0008E6FC
		public bool EndEdit(bool cancel)
		{
			if (this.Cell == null)
			{
				return true;
			}
			if (this.Grid == null)
			{
				return true;
			}
			if (this.Cell.Editor != null && this.Cell.Editor.IsEditing)
			{
				global::SourceGrid.CellContext editCellContext = this.Cell.Editor.EditCellContext;
				bool flag = this.Cell.Editor.InternalEndEdit(cancel);
				if (flag)
				{
					this.Grid.Controller.OnEditEnded(editCellContext, global::System.EventArgs.Empty);
				}
				return flag;
			}
			return true;
		}

		// Token: 0x06002ADC RID: 10972 RVA: 0x00090590 File Offset: 0x0008E790
		public bool IsEditing()
		{
			return this.Cell != null && this.Grid != null && this.Cell.Editor != null && this.Cell.Editor.IsEditing && this.Cell.Editor.EditCellContext == this;
		}

		// Token: 0x06002ADD RID: 10973 RVA: 0x00090600 File Offset: 0x0008E800
		public bool CanBeDrawn()
		{
			return this.Cell != null && (this.Cell.Editor == null || this.Cell.Editor.EnableCellDrawOnEdit || !this.IsEditing());
		}

		// Token: 0x06002ADE RID: 10974 RVA: 0x00090640 File Offset: 0x0008E840
		public void Invalidate()
		{
			if (this.Cell == null)
			{
				return;
			}
			if (this.Grid == null)
			{
				return;
			}
			this.Grid.InvalidateCell(this.Position);
		}

		// Token: 0x17000CBF RID: 3263
		// (get) Token: 0x06002ADF RID: 10975 RVA: 0x0009066C File Offset: 0x0008E86C
		public string DisplayText
		{
			get
			{
				if (this.Cell == null)
				{
					return null;
				}
				string result;
				try
				{
					object value = this.Cell.Model.ValueModel.GetValue(this);
					if (this.Cell.Editor == null)
					{
						if (value == null)
						{
							result = string.Empty;
						}
						else
						{
							result = value.ToString();
						}
					}
					else
					{
						result = this.Cell.Editor.ValueToDisplayString(value);
					}
				}
				catch (global::System.Exception ex)
				{
					result = "Error:" + ex.Message;
				}
				return result;
			}
		}

		// Token: 0x17000CC0 RID: 3264
		// (get) Token: 0x06002AE0 RID: 10976 RVA: 0x00090710 File Offset: 0x0008E910
		// (set) Token: 0x06002AE1 RID: 10977 RVA: 0x00090730 File Offset: 0x0008E930
		public object Value
		{
			get
			{
				return this.Cell.Model.ValueModel.GetValue(this);
			}
			set
			{
				this.Cell.Model.ValueModel.SetValue(this, value);
			}
		}

		// Token: 0x17000CC1 RID: 3265
		// (get) Token: 0x06002AE2 RID: 10978 RVA: 0x00090750 File Offset: 0x0008E950
		public global::SourceGrid.Range CellRange
		{
			get
			{
				return this.Grid.PositionToCellRange(this.Position);
			}
		}

		// Token: 0x06002AE3 RID: 10979 RVA: 0x00090764 File Offset: 0x0008E964
		public bool IsEmpty()
		{
			return this.Equals(global::SourceGrid.CellContext.Empty);
		}

		// Token: 0x06002AE4 RID: 10980 RVA: 0x00090774 File Offset: 0x0008E974
		public override int GetHashCode()
		{
			return this.Position.GetHashCode();
		}

		// Token: 0x06002AE5 RID: 10981 RVA: 0x00090788 File Offset: 0x0008E988
		public bool Equals(global::SourceGrid.CellContext other)
		{
			return this.Position == other.Position && this.Cell == other.Cell && this.Grid == other.Grid;
		}

		// Token: 0x06002AE6 RID: 10982 RVA: 0x000907C4 File Offset: 0x0008E9C4
		public override bool Equals(object obj)
		{
			return this.Equals((global::SourceGrid.CellContext)obj);
		}

		// Token: 0x06002AE7 RID: 10983 RVA: 0x000907D4 File Offset: 0x0008E9D4
		public static bool operator ==(global::SourceGrid.CellContext Left, global::SourceGrid.CellContext Right)
		{
			return Left.Equals(Right);
		}

		// Token: 0x06002AE8 RID: 10984 RVA: 0x000907E0 File Offset: 0x0008E9E0
		public static bool operator !=(global::SourceGrid.CellContext Left, global::SourceGrid.CellContext Right)
		{
			return !Left.Equals(Right);
		}

		// Token: 0x06002AE9 RID: 10985 RVA: 0x000907F0 File Offset: 0x0008E9F0
		public override string ToString()
		{
			return this.Position.ToString();
		}

		// Token: 0x04000E6A RID: 3690
		public static readonly global::SourceGrid.CellContext Empty = new global::SourceGrid.CellContext(null, global::SourceGrid.Position.Empty, null);

		// Token: 0x04000E6B RID: 3691
		public global::SourceGrid.Position Position;

		// Token: 0x04000E6C RID: 3692
		public global::SourceGrid.Cells.ICellVirtual Cell;

		// Token: 0x04000E6D RID: 3693
		public global::SourceGrid.GridVirtual Grid;
	}
}
