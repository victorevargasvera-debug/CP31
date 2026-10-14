using System;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200026E RID: 622
	public class ChildBand : global::Infragistics.Controls.Grids.Primitives.ExpandableRowBase
	{
		// Token: 0x06001471 RID: 5233 RVA: 0x0004C053 File Offset: 0x0004A253
		protected internal ChildBand(global::Infragistics.Controls.Grids.ChildBandRowsManager manager, global::Infragistics.Controls.Grids.ColumnLayout columnLayout, global::Infragistics.Controls.Grids.Row parentRow) : base(manager)
		{
			this._columnLayout = columnLayout;
			this.ParentRow = parentRow;
			base.Data = parentRow.Data;
			this.ChildRowsManager = new global::Infragistics.Controls.Grids.RowsManager(manager.Level, columnLayout, this);
		}

		// Token: 0x1700064C RID: 1612
		// (get) Token: 0x06001472 RID: 5234 RVA: 0x0004C089 File Offset: 0x0004A289
		// (set) Token: 0x06001473 RID: 5235 RVA: 0x0004C091 File Offset: 0x0004A291
		public global::Infragistics.Controls.Grids.Row ParentRow { get; protected set; }

		// Token: 0x1700064D RID: 1613
		// (get) Token: 0x06001474 RID: 5236 RVA: 0x0004C09C File Offset: 0x0004A29C
		public virtual bool ResolveIsVisible
		{
			get
			{
				if (this.ColumnLayout.Visibility == global::System.Windows.Visibility.Collapsed)
				{
					return false;
				}
				if (this.ChildRowsManager.FullRowCount > 0)
				{
					global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility columnLayoutHeaderVisibilityResolved = this.ColumnLayout.ColumnLayoutHeaderVisibilityResolved;
					if (columnLayoutHeaderVisibilityResolved == global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility.Always)
					{
						return true;
					}
					if (columnLayoutHeaderVisibilityResolved == global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility.SiblingsExist)
					{
						return this.ParentRow.ChildRowsManager.Rows.Count > 1;
					}
				}
				return false;
			}
		}

		// Token: 0x1700064E RID: 1614
		// (get) Token: 0x06001475 RID: 5237 RVA: 0x0004C0F6 File Offset: 0x0004A2F6
		public global::Infragistics.Controls.Grids.RowCollection Rows
		{
			get
			{
				return (global::Infragistics.Controls.Grids.RowCollection)this.ChildRowsManager.Rows.ActualCollection;
			}
		}

		// Token: 0x1700064F RID: 1615
		// (get) Token: 0x06001476 RID: 5238 RVA: 0x0004C10D File Offset: 0x0004A30D
		// (set) Token: 0x06001477 RID: 5239 RVA: 0x0004C11F File Offset: 0x0004A31F
		public int CurrentPageIndex
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).CurrentPageIndex;
			}
			set
			{
				if (((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).CurrentPageIndex != value)
				{
					((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).CurrentPageIndex = value;
				}
			}
		}

		// Token: 0x17000650 RID: 1616
		// (get) Token: 0x06001478 RID: 5240 RVA: 0x0004C145 File Offset: 0x0004A345
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).RowFiltersCollection;
			}
		}

		// Token: 0x17000651 RID: 1617
		// (get) Token: 0x06001479 RID: 5241 RVA: 0x0004C157 File Offset: 0x0004A357
		public global::Infragistics.SummaryDefinitionCollection SummaryDefinitionCollection
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).SummaryDefinitionCollection;
			}
		}

		// Token: 0x17000652 RID: 1618
		// (get) Token: 0x0600147A RID: 5242 RVA: 0x0004C169 File Offset: 0x0004A369
		public global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.SummaryResult> SummaryResultCollection
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).SummaryResultCollection;
			}
		}

		// Token: 0x17000653 RID: 1619
		// (get) Token: 0x0600147B RID: 5243 RVA: 0x0004C17B File Offset: 0x0004A37B
		protected internal global::Infragistics.Controls.Grids.ColumnBase FillerColumn
		{
			get
			{
				if (this._fillerColumn == null)
				{
					this._fillerColumn = new global::Infragistics.Controls.Grids.Primitives.FillerColumn();
				}
				return this._fillerColumn;
			}
		}

		// Token: 0x17000654 RID: 1620
		// (get) Token: 0x0600147C RID: 5244 RVA: 0x0004C196 File Offset: 0x0004A396
		public override bool HasChildren
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000655 RID: 1621
		// (get) Token: 0x0600147D RID: 5245 RVA: 0x0004C199 File Offset: 0x0004A399
		public override global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this._columnLayout;
			}
		}

		// Token: 0x17000656 RID: 1622
		// (get) Token: 0x0600147E RID: 5246 RVA: 0x0004C1A1 File Offset: 0x0004A3A1
		// (set) Token: 0x0600147F RID: 5247 RVA: 0x0004C1A9 File Offset: 0x0004A3A9
		protected internal override global::Infragistics.Controls.Grids.RowsManagerBase ChildRowsManager { get; set; }

		// Token: 0x17000657 RID: 1623
		// (get) Token: 0x06001480 RID: 5248 RVA: 0x0004C1B2 File Offset: 0x0004A3B2
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return global::Infragistics.Controls.Grids.Primitives.ChildBand._recyclingElementType;
			}
		}

		// Token: 0x17000658 RID: 1624
		// (get) Token: 0x06001481 RID: 5249 RVA: 0x0004C1BC File Offset: 0x0004A3BC
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

		// Token: 0x17000659 RID: 1625
		// (get) Token: 0x06001482 RID: 5250 RVA: 0x0004C1E2 File Offset: 0x0004A3E2
		public override global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.ChildBandCell>(((global::Infragistics.Controls.Grids.ChildBandRowsManager)base.Manager).Column, base.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x1700065A RID: 1626
		// (get) Token: 0x06001483 RID: 5251 RVA: 0x0004C214 File Offset: 0x0004A414
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.ColumnLayoutHeaderRow;
			}
		}

		// Token: 0x1700065B RID: 1627
		// (get) Token: 0x06001484 RID: 5252 RVA: 0x0004C217 File Offset: 0x0004A417
		protected internal override bool CanScrollHorizontally
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700065C RID: 1628
		// (get) Token: 0x06001485 RID: 5253 RVA: 0x0004C21C File Offset: 0x0004A41C
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.ChildBandHeaderHeightResolved;
			}
		}

		// Token: 0x1700065D RID: 1629
		// (get) Token: 0x06001486 RID: 5254 RVA: 0x0004C253 File Offset: 0x0004A453
		protected internal override global::Infragistics.Controls.Grids.RowHoverType ResolveRowHover
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowHoverType.Cell;
			}
		}

		// Token: 0x06001487 RID: 5255 RVA: 0x0004C256 File Offset: 0x0004A456
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.ChildBandCellsPanel();
		}

		// Token: 0x06001488 RID: 5256 RVA: 0x0004C25D File Offset: 0x0004A45D
		internal void Unregister()
		{
			this._columnLayout = null;
			this.ParentRow = null;
		}

		// Token: 0x0400063C RID: 1596
		private static global::System.Type _recyclingElementType = typeof(global::Infragistics.Controls.Grids.Primitives.ChildBandCellsPanel);

		// Token: 0x0400063D RID: 1597
		private global::Infragistics.Controls.Grids.ColumnLayout _columnLayout;

		// Token: 0x0400063E RID: 1598
		private global::Infragistics.Controls.Grids.Primitives.FillerColumn _fillerColumn;

		// Token: 0x0400063F RID: 1599
		private global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.ChildBandCell> _cells;
	}
}
