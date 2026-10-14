using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x02000271 RID: 625
	public abstract class RowsManagerBase : global::System.IDisposable, global::System.IComparable<global::Infragistics.Controls.Grids.RowsManagerBase>
	{
		// Token: 0x0600148F RID: 5263 RVA: 0x0004C414 File Offset: 0x0004A614
		protected RowsManagerBase(global::Infragistics.Controls.Grids.ColumnLayout columnLayout)
		{
			this.ColumnLayout = columnLayout;
			this._visibleChildManagers = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowsManagerBase>();
			this._readOnlyVisibleChildManagers = new global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.RowsManagerBase>(this._visibleChildManagers);
			this.OverrideHorizontalMax = -1.0;
			this._starColumnWidths = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, double>();
		}

		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x0004C46F File Offset: 0x0004A66F
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x0004C477 File Offset: 0x0004A677
		public virtual global::Infragistics.Controls.Grids.RowBase ParentRow { get; protected set; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x0004C480 File Offset: 0x0004A680
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x0004C488 File Offset: 0x0004A688
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this._columnLayout;
			}
			protected internal set
			{
				if (value != this.ColumnLayout)
				{
					this._isDisposed = false;
					this.OnColumnLayoutAssigned(value);
				}
			}
		}

		// Token: 0x17000661 RID: 1633
		// (get) Token: 0x06001494 RID: 5268 RVA: 0x0004C4A1 File Offset: 0x0004A6A1
		// (set) Token: 0x06001495 RID: 5269 RVA: 0x0004C4A9 File Offset: 0x0004A6A9
		public virtual int Level { get; protected set; }

		// Token: 0x17000662 RID: 1634
		// (get) Token: 0x06001496 RID: 5270
		public abstract global::Infragistics.Controls.Grids.Primitives.RowBaseCollection Rows { get; }

		// Token: 0x17000663 RID: 1635
		// (get) Token: 0x06001497 RID: 5271
		protected internal abstract int FullRowCount { get; }

		// Token: 0x17000664 RID: 1636
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x0004C4B2 File Offset: 0x0004A6B2
		protected internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.RowsManagerBase> VisibleChildManagers
		{
			get
			{
				return this._readOnlyVisibleChildManagers;
			}
		}

		// Token: 0x17000665 RID: 1637
		// (get) Token: 0x06001499 RID: 5273 RVA: 0x0004C4BA File Offset: 0x0004A6BA
		// (set) Token: 0x0600149A RID: 5274 RVA: 0x0004C4C2 File Offset: 0x0004A6C2
		internal int VisibleCellCount { get; set; }

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x0600149B RID: 5275 RVA: 0x0004C4CB File Offset: 0x0004A6CB
		// (set) Token: 0x0600149C RID: 5276 RVA: 0x0004C4D3 File Offset: 0x0004A6D3
		internal int ScrollableCellCount { get; set; }

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x0004C4DC File Offset: 0x0004A6DC
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x0004C4E4 File Offset: 0x0004A6E4
		internal bool InvalidateOverrideHorizontalMax { get; set; }

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x0004C4ED File Offset: 0x0004A6ED
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x0004C4F5 File Offset: 0x0004A6F5
		internal double OverrideHorizontalMax { get; set; }

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x060014A1 RID: 5281 RVA: 0x0004C4FE File Offset: 0x0004A6FE
		// (set) Token: 0x060014A2 RID: 5282 RVA: 0x0004C506 File Offset: 0x0004A706
		internal double OverflowAdjustment { get; set; }

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x060014A3 RID: 5283 RVA: 0x0004C50F File Offset: 0x0004A70F
		// (set) Token: 0x060014A4 RID: 5284 RVA: 0x0004C517 File Offset: 0x0004A717
		internal bool IsFirstRowRenderingInThisLayoutCycle { get; set; }

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x060014A5 RID: 5285 RVA: 0x0004C520 File Offset: 0x0004A720
		// (set) Token: 0x060014A6 RID: 5286 RVA: 0x0004C528 File Offset: 0x0004A728
		internal int IndexOfFirstColumnRendered { get; set; }

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0004C531 File Offset: 0x0004A731
		// (set) Token: 0x060014A8 RID: 5288 RVA: 0x0004C539 File Offset: 0x0004A739
		internal int TotalColumnsRendered { get; set; }

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0004C542 File Offset: 0x0004A742
		// (set) Token: 0x060014AA RID: 5290 RVA: 0x0004C54A File Offset: 0x0004A74A
		internal double RowWidth { get; set; }

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x0004C553 File Offset: 0x0004A753
		// (set) Token: 0x060014AC RID: 5292 RVA: 0x0004C55B File Offset: 0x0004A75B
		internal double CachedIndentation { get; set; }

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x060014AD RID: 5293 RVA: 0x0004C564 File Offset: 0x0004A764
		// (set) Token: 0x060014AE RID: 5294 RVA: 0x0004C56C File Offset: 0x0004A76C
		internal double CurrentVisibleWidth { get; set; }

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x060014AF RID: 5295 RVA: 0x0004C575 File Offset: 0x0004A775
		internal global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, double> StarColumnWidths
		{
			get
			{
				return this._starColumnWidths;
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x060014B0 RID: 5296 RVA: 0x0004C57D File Offset: 0x0004A77D
		internal global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>> RenderedMergedCells
		{
			get
			{
				return this._renderedMergedCells;
			}
		}

		// Token: 0x060014B1 RID: 5297 RVA: 0x0004C585 File Offset: 0x0004A785
		public virtual void InvalidateRows()
		{
		}

		// Token: 0x060014B2 RID: 5298 RVA: 0x0004C587 File Offset: 0x0004A787
		public virtual void RefreshSummaries()
		{
		}

		// Token: 0x060014B3 RID: 5299
		protected internal abstract global::Infragistics.Controls.Grids.RowBase ResolveRowForIndex(int index);

		// Token: 0x060014B4 RID: 5300
		protected internal abstract int ResolveIndexForRow(global::Infragistics.Controls.Grids.RowBase row);

		// Token: 0x060014B5 RID: 5301 RVA: 0x0004C58C File Offset: 0x0004A78C
		protected internal virtual double ResolveIndentation(global::Infragistics.Controls.Grids.RowBase row)
		{
			double num = 0.0;
			if (this.ParentRow != null)
			{
				num += this.ColumnLayout.IndentationResolved + this.ParentRow.Manager.ResolveIndentation(this.ParentRow);
			}
			return num;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x0004C5D1 File Offset: 0x0004A7D1
		protected internal void RegisterChildRowsManager(global::Infragistics.Controls.Grids.RowsManagerBase manager)
		{
			if (!this.VisibleChildManagers.Contains(manager))
			{
				this._visibleChildManagers.Add(manager);
				this._visibleChildManagers.Sort();
				manager.OnRegisteredAsVisibleChildManager();
			}
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x0004C5FE File Offset: 0x0004A7FE
		protected internal void UnregisterChildRowsManager(global::Infragistics.Controls.Grids.RowsManagerBase manager)
		{
			if (this.VisibleChildManagers.Contains(manager))
			{
				this._visibleChildManagers.Remove(manager);
				manager.OnUnregisteredAsVisibleChildManager();
			}
		}

		// Token: 0x060014B8 RID: 5304 RVA: 0x0004C624 File Offset: 0x0004A824
		protected internal void UnregisterAllChildRowsManager()
		{
			for (int i = this.VisibleChildManagers.Count - 1; i >= 0; i--)
			{
				this.UnregisterChildRowsManager(this.VisibleChildManagers[i]);
			}
		}

		// Token: 0x060014B9 RID: 5305 RVA: 0x0004C65B File Offset: 0x0004A85B
		protected virtual void OnRegisteredAsVisibleChildManager()
		{
		}

		// Token: 0x060014BA RID: 5306 RVA: 0x0004C65D File Offset: 0x0004A85D
		protected virtual void OnUnregisteredAsVisibleChildManager()
		{
		}

		// Token: 0x060014BB RID: 5307 RVA: 0x0004C65F File Offset: 0x0004A85F
		protected virtual void OnColumnLayoutAssigned(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
			if (this._columnLayout != null)
			{
				this._columnLayout.UnregisterRowsManager(this);
			}
			this._columnLayout = layout;
			if (this._columnLayout != null)
			{
				this._columnLayout.RegisterRowsManager(this);
			}
		}

		// Token: 0x060014BC RID: 5308 RVA: 0x0004C690 File Offset: 0x0004A890
		protected virtual void OnColumnLayoutPropertyChanged(global::Infragistics.Controls.Grids.ColumnLayout layout, string propertyName)
		{
			if (propertyName == "InvalidateData")
			{
				this.InvalidateData();
			}
		}

		// Token: 0x060014BD RID: 5309 RVA: 0x0004C6A5 File Offset: 0x0004A8A5
		protected virtual void OnChildColumnLayoutRemoved(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
		}

		// Token: 0x060014BE RID: 5310 RVA: 0x0004C6A7 File Offset: 0x0004A8A7
		protected virtual void OnChildColumnLayoutAdded(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
		}

		// Token: 0x060014BF RID: 5311 RVA: 0x0004C6A9 File Offset: 0x0004A8A9
		protected virtual void OnChildColumnLayoutVisibilityChanged(global::Infragistics.Controls.Grids.ColumnLayout layout)
		{
		}

		// Token: 0x060014C0 RID: 5312 RVA: 0x0004C6AB File Offset: 0x0004A8AB
		protected virtual void InvalidateData()
		{
		}

		// Token: 0x060014C1 RID: 5313 RVA: 0x0004C6AD File Offset: 0x0004A8AD
		protected internal virtual void UnregisterRowsManager(bool removeColumnLayout, bool clearChildRowsManager, bool clearSelection)
		{
			if (this._columnLayout != null && removeColumnLayout)
			{
				this._columnLayout = null;
				this._isDisposed = true;
			}
		}

		// Token: 0x060014C2 RID: 5314 RVA: 0x0004C6C8 File Offset: 0x0004A8C8
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetRowScopedConditions()
		{
			return null;
		}

		// Token: 0x060014C3 RID: 5315 RVA: 0x0004C6CB File Offset: 0x0004A8CB
		public virtual global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.IConditionalFormattingRuleProxy> GetCellScopedConditions(string columnKey)
		{
			return null;
		}

		// Token: 0x060014C4 RID: 5316 RVA: 0x0004C6CE File Offset: 0x0004A8CE
		protected void SortVisibleChildManagers()
		{
			this._visibleChildManagers.Sort();
		}

		// Token: 0x060014C5 RID: 5317 RVA: 0x0004C6DB File Offset: 0x0004A8DB
		protected virtual void OnColumnLayoutReset()
		{
		}

		// Token: 0x060014C6 RID: 5318 RVA: 0x0004C6DD File Offset: 0x0004A8DD
		internal void OnColumnLayoutPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (!this._isDisposed)
			{
				this.OnColumnLayoutPropertyChanged((global::Infragistics.Controls.Grids.ColumnLayout)sender, e.PropertyName);
			}
		}

		// Token: 0x060014C7 RID: 5319 RVA: 0x0004C6FC File Offset: 0x0004A8FC
		internal void ColumnLayout_ChildColumnLayoutStateChanged(object sender, global::Infragistics.Controls.Grids.ChildColumnLayoutStateChangedEventArgs e)
		{
			if (this._isDisposed)
			{
				return;
			}
			switch (e.State)
			{
			case global::Infragistics.Controls.Grids.ChildColumnLayoutState.Added:
				this.OnChildColumnLayoutAdded(e.ChildColumnLayout);
				return;
			case global::Infragistics.Controls.Grids.ChildColumnLayoutState.Removed:
				this.OnChildColumnLayoutRemoved(e.ChildColumnLayout);
				return;
			case global::Infragistics.Controls.Grids.ChildColumnLayoutState.VisibilityChanged:
				this.OnChildColumnLayoutVisibilityChanged(e.ChildColumnLayout);
				return;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060014C8 RID: 5320 RVA: 0x0004C75C File Offset: 0x0004A95C
		internal void ColumnLayout_StateChanged(object sender, global::Infragistics.Controls.Grids.ColumnLayoutStateChangedEventArgs e)
		{
			if (this._isDisposed)
			{
				return;
			}
			switch (e.State)
			{
			case global::Infragistics.Controls.Grids.ColumnLayoutState.Reset:
				this.OnColumnLayoutReset();
				return;
			case global::Infragistics.Controls.Grids.ColumnLayoutState.Disposing:
				this.UnregisterRowsManager(true, true, true);
				return;
			default:
				throw new global::System.ArgumentOutOfRangeException();
			}
		}

		// Token: 0x060014C9 RID: 5321 RVA: 0x0004C79F File Offset: 0x0004A99F
		protected virtual void Dispose(bool disposing)
		{
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x0004C7A1 File Offset: 0x0004A9A1
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x060014CB RID: 5323
		protected abstract int CompareTo(global::Infragistics.Controls.Grids.RowsManagerBase other);

		// Token: 0x060014CC RID: 5324 RVA: 0x0004C7B0 File Offset: 0x0004A9B0
		int global::System.IComparable<global::Infragistics.Controls.Grids.RowsManagerBase>.CompareTo(global::Infragistics.Controls.Grids.RowsManagerBase other)
		{
			return this.CompareTo(other);
		}

		// Token: 0x04000642 RID: 1602
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.RowsManagerBase> _visibleChildManagers;

		// Token: 0x04000643 RID: 1603
		private global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.RowsManagerBase> _readOnlyVisibleChildManagers;

		// Token: 0x04000644 RID: 1604
		private global::Infragistics.Controls.Grids.ColumnLayout _columnLayout;

		// Token: 0x04000645 RID: 1605
		private bool _isDisposed;

		// Token: 0x04000646 RID: 1606
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, double> _starColumnWidths;

		// Token: 0x04000647 RID: 1607
		private global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>> _renderedMergedCells = new global::System.Collections.Generic.Dictionary<global::Infragistics.Controls.Grids.Column, global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Primitives.RenderMergeInfo>>();
	}
}
