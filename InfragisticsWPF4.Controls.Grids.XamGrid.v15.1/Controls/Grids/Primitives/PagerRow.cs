using System;
using System.Collections.ObjectModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x02000280 RID: 640
	public class PagerRow : global::Infragistics.Controls.Grids.RowBase
	{
		// Token: 0x0600153B RID: 5435 RVA: 0x0004DC54 File Offset: 0x0004BE54
		protected internal PagerRow(global::Infragistics.Controls.Grids.RowsManager manager) : base(manager)
		{
			base.FixedPositionSortOrder = 0;
		}

		// Token: 0x170006AD RID: 1709
		// (get) Token: 0x0600153C RID: 5436 RVA: 0x0004DC64 File Offset: 0x0004BE64
		protected internal override global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHoverType.Cell;
			}
		}

		// Token: 0x170006AE RID: 1710
		// (get) Token: 0x0600153D RID: 5437 RVA: 0x0004DC67 File Offset: 0x0004BE67
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.PagerRow._recyclingElementType;
			}
		}

		// Token: 0x170006AF RID: 1711
		// (get) Token: 0x0600153E RID: 5438 RVA: 0x0004DC6E File Offset: 0x0004BE6E
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.PagerRow;
			}
		}

		// Token: 0x170006B0 RID: 1712
		// (get) Token: 0x0600153F RID: 5439 RVA: 0x0004DC71 File Offset: 0x0004BE71
		internal global::Infragistics.Controls.Grids.Primitives.PagerColumn Column
		{
			get
			{
				if (this._column == null)
				{
					this._column = new global::Infragistics.Controls.Grids.Primitives.PagerColumn();
				}
				return this._column;
			}
		}

		// Token: 0x170006B1 RID: 1713
		// (get) Token: 0x06001540 RID: 5440 RVA: 0x0004DC8C File Offset: 0x0004BE8C
		public override global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.PagerCell>(this.Column, base.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x170006B2 RID: 1714
		// (get) Token: 0x06001541 RID: 5441 RVA: 0x0004DCB4 File Offset: 0x0004BEB4
		protected internal override global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase> VisibleCells
		{
			get
			{
				return new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.CellBase>
				{
					this.Cells[0]
				};
			}
		}

		// Token: 0x06001542 RID: 5442 RVA: 0x0004DCDA File Offset: 0x0004BEDA
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.PagerCellsPanel();
		}

		// Token: 0x170006B3 RID: 1715
		// (get) Token: 0x06001543 RID: 5443 RVA: 0x0004DCE4 File Offset: 0x0004BEE4
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.PagerSettings.PagerRowHeightResolved;
			}
		}

		// Token: 0x170006B4 RID: 1716
		// (get) Token: 0x06001544 RID: 5444 RVA: 0x0004DD20 File Offset: 0x0004BF20
		protected internal override bool CanScrollHorizontally
		{
			get
			{
				return false;
			}
		}

		// Token: 0x04000663 RID: 1635
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.PagerCellControl);

		// Token: 0x04000664 RID: 1636
		private global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.PagerCell> _cells;

		// Token: 0x04000665 RID: 1637
		private global::Infragistics.Controls.Grids.Primitives.PagerColumn _column;
	}
}
