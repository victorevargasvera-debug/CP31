using System;
using System.Collections;
using System.Drawing;
using System.Windows.Forms;
using DevAge.Drawing;
using SourceGrid.Cells.Models;

namespace SourceGrid.Cells.Controllers
{
	// Token: 0x020003B9 RID: 953
	internal class SortableHeader : global::SourceGrid.Cells.Controllers.ControllerBase
	{
		// Token: 0x17000CE6 RID: 3302
		// (get) Token: 0x06002BA2 RID: 11170 RVA: 0x00092628 File Offset: 0x00090828
		public static global::SourceGrid.Cells.Controllers.SortableHeader Default
		{
			get
			{
				if (global::SourceGrid.Cells.Controllers.SortableHeader.t_Default == null)
				{
					global::SourceGrid.Cells.Controllers.SortableHeader.t_Default = new global::SourceGrid.Cells.Controllers.SortableHeader();
				}
				return global::SourceGrid.Cells.Controllers.SortableHeader.t_Default;
			}
		}

		// Token: 0x06002BA3 RID: 11171 RVA: 0x00092644 File Offset: 0x00090844
		public SortableHeader() : this(null, null)
		{
		}

		// Token: 0x06002BA4 RID: 11172 RVA: 0x00092650 File Offset: 0x00090850
		public SortableHeader(global::SourceGrid.IRangeLoader p_RangeToSort, global::SourceGrid.IRangeLoader p_HeaderRange)
		{
			this.m_HeaderRange = p_HeaderRange;
			this.m_RangeToSort = p_RangeToSort;
		}

		// Token: 0x06002BA5 RID: 11173 RVA: 0x00092690 File Offset: 0x00090890
		public override void OnMouseUp(global::SourceGrid.CellContext sender, global::System.Windows.Forms.MouseEventArgs e)
		{
			base.OnMouseUp(sender, e);
			global::System.Drawing.Point p = sender.Grid.PointToClient(global::System.Windows.Forms.Control.MousePosition);
			global::System.Drawing.Rectangle r = sender.Grid.PositionToRectangle(sender.Position);
			float num;
			global::DevAge.Drawing.RectanglePartType pointPartType = this.LogicalBorder.GetPointPartType(r, p, out num);
			if (this.IsSortEnable(sender) && pointPartType == global::DevAge.Drawing.RectanglePartType.ContentArea && e.Button == global::System.Windows.Forms.MouseButtons.Left)
			{
				global::SourceGrid.Cells.Models.ISortableHeader sortableHeader = (global::SourceGrid.Cells.Models.ISortableHeader)sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader));
				global::SourceGrid.Cells.Models.SortStatus sortStatus = sortableHeader.GetSortStatus(sender);
				if (sortStatus.Style == global::DevAge.Drawing.HeaderSortStyle.Ascending)
				{
					this.SortColumn(sender, false, sortStatus.Comparer);
					return;
				}
				this.SortColumn(sender, true, sortStatus.Comparer);
			}
		}

		// Token: 0x17000CE7 RID: 3303
		// (get) Token: 0x06002BA6 RID: 11174 RVA: 0x00092764 File Offset: 0x00090964
		public global::SourceGrid.IRangeLoader RangeToSort
		{
			get
			{
				return this.m_RangeToSort;
			}
		}

		// Token: 0x17000CE8 RID: 3304
		// (get) Token: 0x06002BA7 RID: 11175 RVA: 0x0009276C File Offset: 0x0009096C
		public global::SourceGrid.IRangeLoader RangeHeader
		{
			get
			{
				return this.m_HeaderRange;
			}
		}

		// Token: 0x06002BA8 RID: 11176 RVA: 0x00092774 File Offset: 0x00090974
		public bool IsSortEnable(global::SourceGrid.CellContext sender)
		{
			return sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader)) != null;
		}

		// Token: 0x06002BA9 RID: 11177 RVA: 0x0009279C File Offset: 0x0009099C
		public void SortColumn(global::SourceGrid.CellContext sender, bool p_bAscending, global::System.Collections.IComparer p_Comparer)
		{
			if (this.IsSortEnable(sender) && sender.Position.Row < sender.Grid.Rows.Count && sender.Grid.Columns.Count > 0)
			{
				global::SourceGrid.Range range;
				if (this.m_RangeToSort != null)
				{
					range = this.m_RangeToSort.GetRange(sender.Grid);
				}
				else
				{
					range = new global::SourceGrid.Range(sender.Position.Row + 1, 0, sender.Grid.Rows.Count - 1, sender.Grid.Columns.Count - 1);
				}
				global::SourceGrid.Range range2;
				if (this.m_HeaderRange != null)
				{
					range2 = this.m_HeaderRange.GetRange(sender.Grid);
				}
				else
				{
					range2 = new global::SourceGrid.Range(0, 0, sender.Position.Row, sender.Grid.Columns.Count - 1);
				}
				global::SourceGrid.Cells.Models.ISortableHeader sortableHeader = (global::SourceGrid.Cells.Models.ISortableHeader)sender.Cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader));
				if (sender.Grid.Rows.Count > sender.Position.Row + 1 && sender.Grid.Columns.Count > sender.Grid.FixedColumns)
				{
					sender.Grid.SortRangeRows(range, sender.Position.Column, p_bAscending, p_Comparer);
					if (p_bAscending)
					{
						sortableHeader.SetSortMode(sender, global::DevAge.Drawing.HeaderSortStyle.Ascending);
					}
					else
					{
						sortableHeader.SetSortMode(sender, global::DevAge.Drawing.HeaderSortStyle.Descending);
					}
					for (int i = range2.Start.Row; i <= range2.End.Row; i++)
					{
						for (int j = range2.Start.Column; j <= range2.End.Column; j++)
						{
							global::SourceGrid.Cells.ICellVirtual cell = sender.Grid.GetCell(i, j);
							if (cell != sender.Cell && cell != null && cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader)) != null)
							{
								global::SourceGrid.Cells.Models.ISortableHeader sortableHeader2 = (global::SourceGrid.Cells.Models.ISortableHeader)cell.Model.FindModel(typeof(global::SourceGrid.Cells.Models.ISortableHeader));
								sortableHeader2.SetSortMode(new global::SourceGrid.CellContext(sender.Grid, new global::SourceGrid.Position(i, j), cell), global::DevAge.Drawing.HeaderSortStyle.None);
							}
						}
					}
					sender.Grid.InvalidateRange(range2);
				}
			}
		}

		// Token: 0x04000E9E RID: 3742
		[global::System.ThreadStatic]
		private static global::SourceGrid.Cells.Controllers.SortableHeader t_Default;

		// Token: 0x04000E9F RID: 3743
		public global::DevAge.Drawing.RectangleBorder LogicalBorder = new global::DevAge.Drawing.RectangleBorder(new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 4f), new global::DevAge.Drawing.BorderLine(global::System.Drawing.Color.Black, 4f));

		// Token: 0x04000EA0 RID: 3744
		private global::SourceGrid.IRangeLoader m_RangeToSort;

		// Token: 0x04000EA1 RID: 3745
		private global::SourceGrid.IRangeLoader m_HeaderRange;
	}
}
