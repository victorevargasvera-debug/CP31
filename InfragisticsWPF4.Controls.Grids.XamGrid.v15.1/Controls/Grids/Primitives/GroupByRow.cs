using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x0200027A RID: 634
	public class GroupByRow : global::Infragistics.Controls.Grids.Row
	{
		// Token: 0x06001509 RID: 5385 RVA: 0x0004D5FC File Offset: 0x0004B7FC
		public GroupByRow(int index, global::Infragistics.Controls.Grids.RowsManager manager, global::Infragistics.GroupByDataContext data) : base(index, manager, data.Value)
		{
			this.GroupByData = data;
			base.ItemSource = data.Records;
		}

		// Token: 0x1700068C RID: 1676
		// (get) Token: 0x0600150A RID: 5386 RVA: 0x0004D61F File Offset: 0x0004B81F
		// (set) Token: 0x0600150B RID: 5387 RVA: 0x0004D627 File Offset: 0x0004B827
		public global::Infragistics.GroupByDataContext GroupByData
		{
			get
			{
				return this._groupData;
			}
			protected internal set
			{
				this._groupData = value;
			}
		}

		// Token: 0x1700068D RID: 1677
		// (get) Token: 0x0600150C RID: 5388 RVA: 0x0004D630 File Offset: 0x0004B830
		// (set) Token: 0x0600150D RID: 5389 RVA: 0x0004D642 File Offset: 0x0004B842
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

		// Token: 0x1700068E RID: 1678
		// (get) Token: 0x0600150E RID: 5390 RVA: 0x0004D668 File Offset: 0x0004B868
		public global::Infragistics.Controls.Grids.RowFiltersCollection RowFiltersCollection
		{
			get
			{
				return ((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).RowFiltersCollection;
			}
		}

		// Token: 0x1700068F RID: 1679
		// (get) Token: 0x0600150F RID: 5391 RVA: 0x0004D67A File Offset: 0x0004B87A
		public virtual global::Infragistics.Controls.Grids.RowCollection Rows
		{
			get
			{
				if (this.ChildRowsManager != null)
				{
					return (global::Infragistics.Controls.Grids.RowCollection)this.ChildRowsManager.Rows.ActualCollection;
				}
				return new global::Infragistics.Controls.Grids.RowCollection((global::Infragistics.Controls.Grids.RowsManager)base.Manager, this.ColumnLayout);
			}
		}

		// Token: 0x17000690 RID: 1680
		// (get) Token: 0x06001510 RID: 5392 RVA: 0x0004D6B0 File Offset: 0x0004B8B0
		public override bool HasChildren
		{
			get
			{
				return this._groupData != null && this._groupData.Records.Count > 0;
			}
		}

		// Token: 0x17000691 RID: 1681
		// (get) Token: 0x06001511 RID: 5393 RVA: 0x0004D6CF File Offset: 0x0004B8CF
		protected override global::System.Type RecyclingElementType
		{
			get
			{
				return typeof(global::Infragistics.Controls.Grids.Primitives.GroupByRowCellsPanel);
			}
		}

		// Token: 0x06001512 RID: 5394 RVA: 0x0004D6DB File Offset: 0x0004B8DB
		protected override global::Infragistics.Controls.Grids.Primitives.CellsPanel CreateInstanceOfRecyclingElement()
		{
			return new global::Infragistics.Controls.Grids.Primitives.GroupByRowCellsPanel();
		}

		// Token: 0x17000692 RID: 1682
		// (get) Token: 0x06001513 RID: 5395 RVA: 0x0004D6E2 File Offset: 0x0004B8E2
		public override global::Infragistics.Controls.Grids.RowType RowType
		{
			get
			{
				return global::Infragistics.Controls.Grids.RowType.GroupByRow;
			}
		}

		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x06001514 RID: 5396 RVA: 0x0004D6E8 File Offset: 0x0004B8E8
		// (set) Token: 0x06001515 RID: 5397 RVA: 0x0004D752 File Offset: 0x0004B952
		protected internal override global::Infragistics.Controls.Grids.RowsManagerBase ChildRowsManager
		{
			get
			{
				if (this._childRowsManager == null)
				{
					global::Infragistics.Controls.Grids.RowsManager rowsManager = new global::Infragistics.Controls.Grids.RowsManager(base.Manager.Level, this.ColumnLayout, this);
					global::Infragistics.Controls.Grids.RowsManager rowsManager2 = (global::Infragistics.Controls.Grids.RowsManager)base.Manager;
					rowsManager.CachedRows = rowsManager2.CachedRows;
					rowsManager.DuplicateObjectValidator = rowsManager2.DuplicateObjectValidator;
					rowsManager.RowObjectCache = rowsManager2.RowObjectCache;
					this._childRowsManager = rowsManager;
				}
				return this._childRowsManager;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x06001516 RID: 5398 RVA: 0x0004D759 File Offset: 0x0004B959
		public override global::Infragistics.Controls.Grids.Primitives.CellBaseCollection Cells
		{
			get
			{
				if (this._cells == null)
				{
					this._cells = new global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.GroupByCell>(((global::Infragistics.Controls.Grids.RowsManager)base.Manager).GroupByColumn, base.Columns, this);
				}
				return this._cells;
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x06001517 RID: 5399 RVA: 0x0004D78C File Offset: 0x0004B98C
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

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x0004D7B2 File Offset: 0x0004B9B2
		protected internal override bool CanScrollHorizontally
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000697 RID: 1687
		// (get) Token: 0x06001519 RID: 5401 RVA: 0x0004D7B5 File Offset: 0x0004B9B5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Infragistics.Controls.Grids.Primitives.ChildBandCollection ChildBands
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000698 RID: 1688
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0004D7B8 File Offset: 0x0004B9B8
		public override global::Infragistics.Controls.Grids.RowHeight HeightResolved
		{
			get
			{
				if (base.Height != null)
				{
					return base.Height.Value;
				}
				return this.ColumnLayout.GroupBySettings.GroupByRowHeightResolved;
			}
		}

		// Token: 0x0600151B RID: 5403 RVA: 0x0004D7F4 File Offset: 0x0004B9F4
		protected override void OnItemSourceChanged()
		{
			base.OnItemSourceChanged();
			if (this.ChildRowsManager != null)
			{
				((global::Infragistics.Controls.Grids.RowsManager)this.ChildRowsManager).ItemsSource = base.ItemSource;
			}
		}

		// Token: 0x17000699 RID: 1689
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x0004D81A File Offset: 0x0004BA1A
		protected internal override bool CanBeDeleted
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700069A RID: 1690
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0004D81D File Offset: 0x0004BA1D
		protected internal override bool AllowSelection
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0400065C RID: 1628
		private global::Infragistics.GroupByDataContext _groupData;

		// Token: 0x0400065D RID: 1629
		private global::Infragistics.Controls.Grids.RowsManagerBase _childRowsManager;

		// Token: 0x0400065E RID: 1630
		private global::Infragistics.Controls.Grids.Primitives.SingleCellBaseCollection<global::Infragistics.Controls.Grids.Primitives.GroupByCell> _cells;
	}
}
