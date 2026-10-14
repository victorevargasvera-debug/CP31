using System;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000278 RID: 632
	public class GroupByAreaRow : global::Infragistics.Controls.Grids.RowBase
	{
		// Token: 0x060014FF RID: 5375 RVA: 0x0004D46B File Offset: 0x0004B66B
		public GroupByAreaRow(global::Infragistics.Controls.Grids.RowsManagerBase manager) : base(manager)
		{
			base.FixedPositionSortOrder = -1;
			base.MinimumRowHeight = new double?(0.0);
		}

		// Token: 0x17000687 RID: 1671
		// (get) Token: 0x06001500 RID: 5376 RVA: 0x0004D48F File Offset: 0x0004B68F
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.GroupByAreaRow;
			}
		}

		// Token: 0x17000688 RID: 1672
		// (get) Token: 0x06001501 RID: 5377 RVA: 0x0004D492 File Offset: 0x0004B692
		public override global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.GroupByAreaCell>(((global::Infragistics.Controls.Grids.XamGridRowsManager)base.Manager).GroupByAreaColumn, base.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x17000689 RID: 1673
		// (get) Token: 0x06001502 RID: 5378 RVA: 0x0004D4C4 File Offset: 0x0004B6C4
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByAreaRowCellsPanel);
			}
		}

		// Token: 0x06001503 RID: 5379 RVA: 0x0004D4D0 File Offset: 0x0004B6D0
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByAreaRowCellsPanel();
		}

		// Token: 0x1700068A RID: 1674
		// (get) Token: 0x06001504 RID: 5380 RVA: 0x0004D4D8 File Offset: 0x0004B6D8
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.GroupBySettings.GroupByAreaRowHeightResolved;
			}
		}

		// Token: 0x1700068B RID: 1675
		// (get) Token: 0x06001505 RID: 5381 RVA: 0x0004D514 File Offset: 0x0004B714
		protected internal override bool CanScrollHorizontally
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400065A RID: 1626
		private global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.GroupByAreaCell> _cells;
	}
}
