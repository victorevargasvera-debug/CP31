using System;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200028C RID: 652
	public class XamGridRowsManager : global::Infragistics.Controls.Grids.RowsManager
	{
		// Token: 0x060015F8 RID: 5624 RVA: 0x00053C2C File Offset: 0x00051E2C
		public XamGridRowsManager(global::Infragistics.Controls.Grids.XamGrid grid) : base(0, new global::Infragistics.Controls.Grids.ColumnLayout(grid)
		{
			Key = "XamWebGrid_Root_XamWebGrid"
		}, null)
		{
			this._grid = grid;
		}

		// Token: 0x170006E4 RID: 1764
		// (get) Token: 0x060015F9 RID: 5625 RVA: 0x00053C5B File Offset: 0x00051E5B
		public global::Infragistics.Controls.Grids.Primitives.GroupByAreaRow GroupByAreaRow
		{
			get
			{
				if (this._groupByAreaRow == null)
				{
					this._groupByAreaRow = new global::Infragistics.Controls.Grids.Primitives.GroupByAreaRow(this);
				}
				return this._groupByAreaRow;
			}
		}

		// Token: 0x170006E5 RID: 1765
		// (get) Token: 0x060015FA RID: 5626 RVA: 0x00053C77 File Offset: 0x00051E77
		internal global::Infragistics.Controls.Grids.Primitives.GroupByColumn GroupByAreaColumn
		{
			get
			{
				if (this._groupByAreaColumn == null)
				{
					this._groupByAreaColumn = new global::Infragistics.Controls.Grids.Primitives.GroupByColumn();
					this._groupByAreaColumn.ColumnLayout = base.ColumnLayout;
				}
				return this._groupByAreaColumn;
			}
		}

		// Token: 0x170006E6 RID: 1766
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00053CA3 File Offset: 0x00051EA3
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00053CAB File Offset: 0x00051EAB
		internal global::Infragistics.Controls.Grids.XamGrid Grid
		{
			get
			{
				return this._grid;
			}
			set
			{
				this._grid = value;
			}
		}

		// Token: 0x170006E7 RID: 1767
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00053CB4 File Offset: 0x00051EB4
		protected override bool FooterSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170006E8 RID: 1768
		// (get) Token: 0x060015FE RID: 5630 RVA: 0x00053CB7 File Offset: 0x00051EB7
		protected override bool HeaderSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060015FF RID: 5631 RVA: 0x00053CBA File Offset: 0x00051EBA
		protected override void RegisterTopRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this._grid != null && this._grid.Panel != null)
			{
				this._grid.Panel.RegisterFixedRow(row, global::Infragistics.Controls.Grids.FixedRowAlignment.Top);
				base.RegisterTopRow(row);
			}
		}

		// Token: 0x06001600 RID: 5632 RVA: 0x00053CEA File Offset: 0x00051EEA
		protected override void RegisterBottomRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this._grid != null && this._grid.Panel != null)
			{
				this._grid.Panel.RegisterFixedRow(row, global::Infragistics.Controls.Grids.FixedRowAlignment.Bottom);
				base.RegisterBottomRow(row);
			}
		}

		// Token: 0x06001601 RID: 5633 RVA: 0x00053D1A File Offset: 0x00051F1A
		protected override void UnregisterTopRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this._grid != null && this._grid.Panel != null)
			{
				this._grid.Panel.UnregisterFixedRow(row);
				base.UnregisterTopRow(row);
			}
		}

		// Token: 0x06001602 RID: 5634 RVA: 0x00053D49 File Offset: 0x00051F49
		protected override void UnregisterBottomRow(global::Infragistics.Controls.Grids.RowBase row)
		{
			if (this._grid != null && this._grid.Panel != null)
			{
				this._grid.Panel.UnregisterFixedRow(row);
				base.UnregisterBottomRow(row);
			}
		}

		// Token: 0x06001603 RID: 5635 RVA: 0x00053D78 File Offset: 0x00051F78
		protected internal override global::Infragistics.Controls.Grids.RowBase ResolveRowForIndex(int index)
		{
			return this.Rows[index];
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00053D88 File Offset: 0x00051F88
		protected override void InvalidateGroupBy(bool reset)
		{
			if (this.Grid != null && this.Grid.IsLoaded)
			{
				base.InvalidateGroupBy(reset);
				if (base.GroupByLevel == -1)
				{
					this.InvalidateHeaderRowVisibility();
					this.InvalidateAddNewRowVisibility(false);
					this.InvalidateFooterRowVisibility();
					this.InvalidateFilterRowVisibility(false);
					this.InvalidateSummaryRowVisibility();
					return;
				}
				this.UnregisterTopRow(base.HeaderRow);
				this.UnregisterTopRow(base.AddNewRowTop);
				this.UnregisterTopRow(base.FilterRowTop);
				this.UnregisterTopRow(base.SummaryRowTop);
				this.UnregisterBottomRow(base.FooterRow);
				this.UnregisterBottomRow(base.AddNewRowBottom);
				this.UnregisterBottomRow(base.FilterRowBottom);
				this.UnregisterBottomRow(base.SummaryRowBottom);
			}
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00053E44 File Offset: 0x00052044
		protected virtual void InvalidateGroupByAreaRowVisibility()
		{
			if (this._grid != null)
			{
				switch (this._grid.GroupBySettings.AllowGroupByArea)
				{
				case global::Infragistics.Controls.Grids.GroupByAreaLocation.Hidden:
					this.UnregisterTopRow(this.GroupByAreaRow);
					this.UnregisterBottomRow(this.GroupByAreaRow);
					break;
				case global::Infragistics.Controls.Grids.GroupByAreaLocation.Top:
					this.UnregisterBottomRow(this.GroupByAreaRow);
					this.RegisterTopRow(this.GroupByAreaRow);
					return;
				case global::Infragistics.Controls.Grids.GroupByAreaLocation.Bottom:
					this.UnregisterTopRow(this.GroupByAreaRow);
					this.RegisterBottomRow(this.GroupByAreaRow);
					return;
				default:
					return;
				}
			}
		}

		// Token: 0x06001606 RID: 5638 RVA: 0x00053EC8 File Offset: 0x000520C8
		protected override void OnColumnLayoutPropertyChanged(global::Infragistics.Controls.Grids.ColumnLayout layout, string propertyName)
		{
			if (propertyName != null && propertyName == "AllowGroupByArea")
			{
				this.InvalidateGroupByAreaRowVisibility();
			}
			base.OnColumnLayoutPropertyChanged(layout, propertyName);
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00053EF8 File Offset: 0x000520F8
		public override void InvalidateTopAndBottomRows()
		{
			if (base.GroupByLevel == -1)
			{
				base.InvalidateTopAndBottomRows();
			}
			else
			{
				this.UnregisterTopRow(base.HeaderRow);
				this.UnregisterTopRow(base.AddNewRowTop);
				this.UnregisterTopRow(base.FilterRowTop);
				this.UnregisterBottomRow(base.FooterRow);
				this.UnregisterBottomRow(base.AddNewRowBottom);
				this.UnregisterBottomRow(base.FilterRowBottom);
				this.InvalidatePagerRowVisibility();
			}
			this.InvalidateGroupByAreaRowVisibility();
		}

		// Token: 0x06001608 RID: 5640 RVA: 0x00053F6A File Offset: 0x0005216A
		protected override void OnCurrentItemChanged(object data)
		{
			if (this.Grid != null)
			{
				this.Grid.ActiveItem = data;
			}
		}

		// Token: 0x06001609 RID: 5641 RVA: 0x00053F80 File Offset: 0x00052180
		protected internal override void ResetAddNewRows(bool generateNewData)
		{
			base.ResetAddNewRows(generateNewData);
			if (generateNewData && (base.AddNewRowTop.IsActive || base.AddNewRowBottom.IsActive))
			{
				this.Grid.IgnoreActiveItemChanging = true;
				this.Grid.ActiveItem = base.AddNewRowTop.Data;
				this.Grid.IgnoreActiveItemChanging = false;
			}
		}

		// Token: 0x0600160A RID: 5642 RVA: 0x00053FDF File Offset: 0x000521DF
		internal void InitData()
		{
			this.InitializeData();
		}

		// Token: 0x0600160B RID: 5643 RVA: 0x00053FE8 File Offset: 0x000521E8
		internal void UpdateCurrentItem(object item)
		{
			global::Infragistics.DataManagerBase dataManager = this.DataManager;
			if (dataManager != null)
			{
				dataManager.UpdateCurrentItem(item);
			}
		}

		// Token: 0x040006A3 RID: 1699
		private global::Infragistics.Controls.Grids.XamGrid _grid;

		// Token: 0x040006A4 RID: 1700
		private global::Infragistics.Controls.Grids.Primitives.GroupByAreaRow _groupByAreaRow;

		// Token: 0x040006A5 RID: 1701
		private global::Infragistics.Controls.Grids.Primitives.GroupByColumn _groupByAreaColumn;
	}
}
