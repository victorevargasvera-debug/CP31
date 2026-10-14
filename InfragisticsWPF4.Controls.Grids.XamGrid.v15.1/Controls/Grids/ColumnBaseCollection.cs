using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using Infragistics.Collections;
using Infragistics.Controls.Grids.Primitives;

namespace Infragistics.Controls.Grids
{
	// Token: 0x0200023A RID: 570
	public class ColumnBaseCollection : global::Infragistics.Collections.CollectionBase<global::Infragistics.Controls.Grids.ColumnBase>, global::Infragistics.IProvidePersistenceLookupKeys, global::Infragistics.IProvidePropertyPersistenceSettings
	{
		// Token: 0x060010F6 RID: 4342 RVA: 0x0003EBCC File Offset: 0x0003CDCC
		public ColumnBaseCollection(global::Infragistics.Controls.Grids.ColumnLayout columnLayout)
		{
			this._columnLayout = columnLayout;
			this._internalColumnLayouts = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout>();
			this._columnLayouts = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnLayout>(this._internalColumnLayouts);
			this._internalFixedAdornerColumns = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			this._fixedAdornerColumns = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(this._internalFixedAdornerColumns);
			this._internalVisibleColumns = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			this._visibleColumns = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(this._internalVisibleColumns);
			this._fillerColumn = new global::Infragistics.Controls.Grids.Primitives.FillerColumn();
			this._fillerColumn.ColumnLayout = this._columnLayout;
			this._nonLayoutColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column>();
			this._dataColumns = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(this._nonLayoutColumns);
			this._starColumns = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column>();
			this._startColumnsReadOnly = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(this._starColumns);
			this._allDataColumnsCache = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
			this._allDataColumnsCacheReadOnly = new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(this._allDataColumnsCache);
		}

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x060010F7 RID: 4343 RVA: 0x0003ECB1 File Offset: 0x0003CEB1
		public global::Infragistics.Controls.Grids.ColumnLayout ColumnLayout
		{
			get
			{
				return this._columnLayout;
			}
		}

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x060010F8 RID: 4344 RVA: 0x0003ECB9 File Offset: 0x0003CEB9
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnLayout> ColumnLayouts
		{
			get
			{
				return this._columnLayouts;
			}
		}

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x060010F9 RID: 4345 RVA: 0x0003ECC1 File Offset: 0x0003CEC1
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> FixedAdornerColumns
		{
			get
			{
				return this._fixedAdornerColumns;
			}
		}

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x060010FA RID: 4346 RVA: 0x0003ECC9 File Offset: 0x0003CEC9
		public global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorColumn ExpansionIndicatorColumn
		{
			get
			{
				if (this._expansionIndicatorColumn == null)
				{
					this._expansionIndicatorColumn = new global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorColumn();
					this._expansionIndicatorColumn.ColumnLayout = this._columnLayout;
				}
				return this._expansionIndicatorColumn;
			}
		}

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x060010FB RID: 4347 RVA: 0x0003ECF5 File Offset: 0x0003CEF5
		public global::Infragistics.Controls.Grids.Primitives.RowSelectorColumn RowSelectorColumn
		{
			get
			{
				if (this._rowSelectorColumn == null)
				{
					this._rowSelectorColumn = new global::Infragistics.Controls.Grids.Primitives.RowSelectorColumn();
					this._rowSelectorColumn.ColumnLayout = this._columnLayout;
				}
				return this._rowSelectorColumn;
			}
		}

		// Token: 0x17000504 RID: 1284
		public global::Infragistics.Controls.Grids.ColumnBase this[string key]
		{
			get
			{
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Items)
				{
					if (columnBase.Key == key)
					{
						return columnBase;
					}
				}
				return null;
			}
		}

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x060010FD RID: 4349 RVA: 0x0003ED80 File Offset: 0x0003CF80
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> DataColumns
		{
			get
			{
				return this._dataColumns;
			}
		}

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x060010FE RID: 4350 RVA: 0x0003ED88 File Offset: 0x0003CF88
		public global::Infragistics.Controls.Grids.Primitives.FillerColumn FillerColumn
		{
			get
			{
				return this._fillerColumn;
			}
		}

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x060010FF RID: 4351 RVA: 0x0003ED90 File Offset: 0x0003CF90
		public global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn FixedBorderColumnLeft
		{
			get
			{
				if (this._fixedBorderColumnLeft == null)
				{
					this._fixedBorderColumnLeft = new global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn();
				}
				return this._fixedBorderColumnLeft;
			}
		}

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001100 RID: 4352 RVA: 0x0003EDAB File Offset: 0x0003CFAB
		public global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn FixedBorderColumnRight
		{
			get
			{
				if (this._fixedBorderColumnRight == null)
				{
					this._fixedBorderColumnRight = new global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn();
				}
				return this._fixedBorderColumnRight;
			}
		}

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001101 RID: 4353 RVA: 0x0003EDC6 File Offset: 0x0003CFC6
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsLeft
		{
			get
			{
				return this.ColumnLayout.FixedColumnSettings.FixedColumnsLeft;
			}
		}

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001102 RID: 4354 RVA: 0x0003EDD8 File Offset: 0x0003CFD8
		public global::Infragistics.Controls.Grids.GroupByColumnsCollection GroupByColumns
		{
			get
			{
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
				{
					return this.ColumnLayout.Grid.GroupBySettings.GroupByColumns;
				}
				return null;
			}
		}

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001103 RID: 4355 RVA: 0x0003EE06 File Offset: 0x0003D006
		public global::Infragistics.Controls.Grids.SelectedColumnsCollection SelectedColumns
		{
			get
			{
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
				{
					return this.ColumnLayout.Grid.SelectionSettings.SelectedColumns;
				}
				return null;
			}
		}

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001104 RID: 4356 RVA: 0x0003EE34 File Offset: 0x0003D034
		public global::Infragistics.Controls.Grids.FixedColumnsCollection FixedColumnsRight
		{
			get
			{
				return this.ColumnLayout.FixedColumnSettings.FixedColumnsRight;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001105 RID: 4357 RVA: 0x0003EE46 File Offset: 0x0003D046
		public global::Infragistics.Controls.Grids.SortedColumnsCollection SortedColumns
		{
			get
			{
				return this.ColumnLayout.SortingSettings.SortedColumns;
			}
		}

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001106 RID: 4358 RVA: 0x0003EE58 File Offset: 0x0003D058
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> AllColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnBase> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnBase>();
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Items)
				{
					list.Add(columnBase);
					global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
					if (column != null)
					{
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allColumns = column.AllColumns;
						foreach (global::Infragistics.Controls.Grids.Column item in allColumns)
						{
							list.Add(item);
						}
					}
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase>(list);
			}
		}

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001107 RID: 4359 RVA: 0x0003EF08 File Offset: 0x0003D108
		[global::System.ComponentModel.Browsable(false)]
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllVisibleColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.VisibleColumns)
				{
					global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
					if (column != null)
					{
						list.Add(column);
					}
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(list);
			}
		}

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001108 RID: 4360 RVA: 0x0003EF6C File Offset: 0x0003D16C
		protected virtual global::System.Collections.Generic.List<string> PropertiesToIgnore
		{
			get
			{
				if (this._propertiesThatShouldntBePersisted == null)
				{
					this._propertiesThatShouldntBePersisted = new global::System.Collections.Generic.List<string>
					{
						"AllColumns",
						"AllVisibleColumns"
					};
				}
				return this._propertiesThatShouldntBePersisted;
			}
		}

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001109 RID: 4361 RVA: 0x0003EFAA File Offset: 0x0003D1AA
		protected virtual global::System.Collections.Generic.List<string> PriorityProperties
		{
			get
			{
				return null;
			}
		}

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x0600110A RID: 4362 RVA: 0x0003EFB0 File Offset: 0x0003D1B0
		public global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllVisibleChildColumns
		{
			get
			{
				global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> list = new global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column>();
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.VisibleColumns)
				{
					global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
					if (column != null)
					{
						global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = column.AllVisibleChildColumns;
						if (allVisibleChildColumns.Count == 0)
						{
							list.Add(column);
						}
						else
						{
							list.AddRange(allVisibleChildColumns);
						}
					}
				}
				return new global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column>(list);
			}
		}

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x0600110B RID: 4363 RVA: 0x0003F030 File Offset: 0x0003D230
		protected internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> VisibleColumns
		{
			get
			{
				return this._visibleColumns;
			}
		}

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x0600110C RID: 4364 RVA: 0x0003F038 File Offset: 0x0003D238
		protected internal global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> StarColumns
		{
			get
			{
				return this._startColumnsReadOnly;
			}
		}

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x0600110D RID: 4365 RVA: 0x0003F040 File Offset: 0x0003D240
		// (set) Token: 0x0600110E RID: 4366 RVA: 0x0003F048 File Offset: 0x0003D248
		internal global::System.Type DataType { get; set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x0600110F RID: 4367 RVA: 0x0003F051 File Offset: 0x0003D251
		internal global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout> InternalColumnLayouts
		{
			get
			{
				return this._internalColumnLayouts;
			}
		}

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001110 RID: 4368 RVA: 0x0003F059 File Offset: 0x0003D259
		internal global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> AllDataColumnsCache
		{
			get
			{
				if (this._rebuildAllDataColumnsCache)
				{
					this.RebuildAllDataColumnsCache();
					this._rebuildAllDataColumnsCache = false;
				}
				return this._allDataColumnsCacheReadOnly;
			}
		}

		// Token: 0x06001111 RID: 4369 RVA: 0x0003F076 File Offset: 0x0003D276
		protected virtual void RegisterFixedAdornerColumn(global::Infragistics.Controls.Grids.Column column, bool first)
		{
			if (!this._internalFixedAdornerColumns.Contains(column))
			{
				if (first)
				{
					this._internalFixedAdornerColumns.Insert(0, column);
					return;
				}
				this._internalFixedAdornerColumns.Add(column);
			}
		}

		// Token: 0x06001112 RID: 4370 RVA: 0x0003F0A3 File Offset: 0x0003D2A3
		protected virtual void UnregisterFixedAdornerColumn(global::Infragistics.Controls.Grids.Column column)
		{
			this._internalFixedAdornerColumns.Remove(column);
		}

		// Token: 0x06001113 RID: 4371 RVA: 0x0003F0B4 File Offset: 0x0003D2B4
		protected internal virtual void InvalidateColumnsCollections(bool fullInvalidate)
		{
			this._internalVisibleColumns.Clear();
			this._nonLayoutColumns.Clear();
			this._starColumns.Clear();
			bool flag = false;
			bool flag2 = false;
			global::Infragistics.Controls.Grids.XamGrid xamGrid = null;
			if (this.ColumnLayout != null)
			{
				xamGrid = this.ColumnLayout.Grid;
			}
			if (xamGrid != null)
			{
				flag2 = (xamGrid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells);
			}
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Items)
			{
				global::Infragistics.Controls.Grids.Column column = columnBase as global::Infragistics.Controls.Grids.Column;
				if (column != null)
				{
					this._nonLayoutColumns.Add(column);
					bool flag3 = column.IsFixed != global::Infragistics.Controls.Grids.FixedState.NotFixed;
					if ((!flag2 || !column.IsGroupBy) && !flag3 && columnBase.Visibility == global::System.Windows.Visibility.Visible)
					{
						this._internalVisibleColumns.Add(column);
					}
					if (column.WidthResolved.WidthType == global::Infragistics.Controls.Grids.ColumnWidthType.Star)
					{
						flag = true;
						this._starColumns.Add(column);
					}
				}
			}
			if (!flag)
			{
				this._internalVisibleColumns.Add(this._fillerColumn);
			}
			if (fullInvalidate)
			{
				this.InvalidateCollection(this.FixedColumnsLeft);
				this.InvalidateCollection(this.FixedColumnsRight);
				this.InvalidateCollection(this.SortedColumns);
			}
			this._rebuildAllDataColumnsCache = true;
			if (xamGrid != null)
			{
				xamGrid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x06001114 RID: 4372 RVA: 0x0003F214 File Offset: 0x0003D414
		protected virtual global::System.Collections.ObjectModel.Collection<string> GetLookupKeys()
		{
			global::System.Collections.ObjectModel.Collection<string> collection = new global::System.Collections.ObjectModel.Collection<string>();
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in this.Items)
			{
				collection.Add(columnBase.Key);
			}
			return collection;
		}

		// Token: 0x06001115 RID: 4373 RVA: 0x0003F270 File Offset: 0x0003D470
		protected virtual bool CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			if (lookupKeys == null || lookupKeys.Count != this.Items.Count)
			{
				return false;
			}
			bool flag = false;
			global::System.Collections.Generic.Dictionary<string, global::Infragistics.Controls.Grids.ColumnBase> dictionary = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.Controls.Grids.ColumnBase>();
			for (int i = 0; i < lookupKeys.Count; i++)
			{
				string key = lookupKeys[i];
				global::Infragistics.Controls.Grids.ColumnBase columnBase = this[key];
				dictionary.Add(key, columnBase);
				if (this[key] == null)
				{
					return false;
				}
				if (this.IndexOf(columnBase) != i)
				{
					flag = true;
				}
			}
			if (flag)
			{
				foreach (string text in lookupKeys)
				{
					global::Infragistics.Controls.Grids.ColumnBase columnBase2 = base[0];
					global::Infragistics.Controls.Grids.Column column = columnBase2 as global::Infragistics.Controls.Grids.Column;
					if (column != null)
					{
						column.IsMoving = true;
					}
					this.RemoveItemSilently(0);
					if (column != null)
					{
						column.IsMoving = false;
					}
				}
				for (int j = 0; j < lookupKeys.Count; j++)
				{
					global::Infragistics.Controls.Grids.ColumnBase item = dictionary[lookupKeys[j]];
					this.AddItemSilently(j, item);
				}
				this.OnNotifyCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
			return true;
		}

		// Token: 0x06001116 RID: 4374 RVA: 0x0003F390 File Offset: 0x0003D590
		protected virtual void FinishedLoadingPersistence()
		{
		}

		// Token: 0x06001117 RID: 4375 RVA: 0x0003F394 File Offset: 0x0003D594
		private void InvalidateCollection(global::System.Collections.IList list)
		{
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = this.AllColumns;
			int count = list.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				if (!allColumns.Contains((global::Infragistics.Controls.Grids.ColumnBase)list[i]))
				{
					list.RemoveAt(i);
				}
			}
		}

		// Token: 0x06001118 RID: 4376 RVA: 0x0003F3D8 File Offset: 0x0003D5D8
		internal void InvalidateSelection(global::Infragistics.Controls.Grids.ColumnBase colBase)
		{
			global::Infragistics.Controls.Grids.Column column = colBase as global::Infragistics.Controls.Grids.Column;
			if (column != null)
			{
				this.InvalidateSelection(column);
				return;
			}
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = colBase as global::Infragistics.Controls.Grids.ColumnLayout;
			if (columnLayout != null)
			{
				this.InvalidateSelection(columnLayout);
			}
		}

		// Token: 0x06001119 RID: 4377 RVA: 0x0003F408 File Offset: 0x0003D608
		internal void InvalidateSelection(global::Infragistics.Controls.Grids.ColumnLayout colLayout)
		{
			if (colLayout != this.ColumnLayout)
			{
				foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in colLayout.Columns.AllColumns)
				{
					if (columnBase != colLayout)
					{
						this.InvalidateSelection(columnBase);
					}
				}
				if (this.ColumnLayout != null && this.ColumnLayout.Grid != null)
				{
					global::Infragistics.Controls.Grids.SelectedRowsCollection selectedRows = this.ColumnLayout.Grid.SelectionSettings.SelectedRows;
					global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Row> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Row>();
					foreach (global::Infragistics.Controls.Grids.Row row in selectedRows)
					{
						if (row.ColumnLayout == colLayout)
						{
							collection.Add(row);
						}
					}
					foreach (global::Infragistics.Controls.Grids.Row item in collection)
					{
						selectedRows.Remove(item);
					}
				}
			}
		}

		// Token: 0x0600111A RID: 4378 RVA: 0x0003F52C File Offset: 0x0003D72C
		internal void InvalidateSelection(global::Infragistics.Controls.Grids.Column col)
		{
			global::Infragistics.Controls.Grids.GroupByColumnsCollection groupByColumns = this.ColumnLayout.Grid.GroupBySettings.GroupByColumns;
			if (groupByColumns.Contains(col))
			{
				groupByColumns.Remove(col);
			}
			global::Infragistics.Controls.Grids.SelectedColumnsCollection selectedColumns = this.ColumnLayout.Grid.SelectionSettings.SelectedColumns;
			if (selectedColumns.Contains(col))
			{
				selectedColumns.Remove(col);
			}
			global::Infragistics.Controls.Grids.SelectedCellsCollection selectedCells = this.ColumnLayout.Grid.SelectionSettings.SelectedCells;
			global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Cell> collection = new global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Cell>();
			foreach (global::Infragistics.Controls.Grids.Cell cell in selectedCells)
			{
				if (cell.Column == col)
				{
					collection.Add(cell);
				}
			}
			foreach (global::Infragistics.Controls.Grids.Cell item in collection)
			{
				selectedCells.Remove(item);
			}
		}

		// Token: 0x0600111B RID: 4379 RVA: 0x0003F630 File Offset: 0x0003D830
		internal void InvalidateActiveCell(global::Infragistics.Controls.Grids.ColumnBase removedColumnBase)
		{
			global::Infragistics.Controls.Grids.CellBase activeCell = this.ColumnLayout.Grid.ActiveCell;
			if (activeCell != null)
			{
				if (removedColumnBase is global::Infragistics.Controls.Grids.Column)
				{
					if (activeCell.Column.Equals(removedColumnBase))
					{
						this.ColumnLayout.Grid.ActiveCell = null;
						return;
					}
				}
				else
				{
					for (global::Infragistics.Controls.Grids.ColumnBase columnLayout = activeCell.Row.ColumnLayout; columnLayout != null; columnLayout = columnLayout.ColumnLayout)
					{
						if (columnLayout.Equals(removedColumnBase))
						{
							this.ColumnLayout.Grid.ActiveCell = null;
							break;
						}
					}
					global::Infragistics.Controls.Grids.Primitives.ChildBandCell childBandCell = this.ColumnLayout.Grid.ActiveCell as global::Infragistics.Controls.Grids.Primitives.ChildBandCell;
					if (childBandCell != null)
					{
						global::Infragistics.Controls.Grids.ColumnBase columnLayout = activeCell.Row.ColumnLayout;
						if (columnLayout != null)
						{
							global::Infragistics.Controls.Grids.ColumnLayout columnLayout2 = columnLayout.ColumnLayout;
							if (columnLayout2 != null && columnLayout2.ColumnLayoutHeaderVisibilityResolved == global::Infragistics.Controls.Grids.ColumnLayoutHeaderVisibility.SiblingsExist && columnLayout2.Columns.ColumnLayouts.Count < 2)
							{
								this.ColumnLayout.Grid.ActiveCell = null;
							}
						}
					}
				}
			}
		}

		// Token: 0x0600111C RID: 4380 RVA: 0x0003F714 File Offset: 0x0003D914
		private void RebuildAllDataColumnsCache()
		{
			this._allDataColumnsCache.Clear();
			global::Infragistics.Controls.Grids.XamGrid grid = this._columnLayout.Grid;
			if (grid.GroupBySettings.GroupByOperation == global::Infragistics.Controls.Grids.GroupByOperation.MergeCells)
			{
				global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> readOnlyCollection = grid.GroupBySettings.GroupByColumns[this._columnLayout];
				foreach (global::Infragistics.Controls.Grids.Column column in readOnlyCollection)
				{
					if (column.Visibility == global::System.Windows.Visibility.Visible)
					{
						this._allDataColumnsCache.Add(column);
					}
				}
			}
			foreach (global::Infragistics.Controls.Grids.Column column2 in this.FixedColumnsLeft)
			{
				if (column2.Visibility == global::System.Windows.Visibility.Visible)
				{
					if (!(column2 is global::Infragistics.Controls.Grids.GroupColumn))
					{
						this._allDataColumnsCache.Add(column2);
					}
					else
					{
						this._allDataColumnsCache.AddRange(column2.AllVisibleChildColumns);
					}
				}
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<global::Infragistics.Controls.Grids.Column> allVisibleChildColumns = this.AllVisibleChildColumns;
			foreach (global::Infragistics.Controls.Grids.Column column3 in allVisibleChildColumns)
			{
				if (!(column3 is global::Infragistics.Controls.Grids.Primitives.FillerColumn) && column3.SupportsActivationAndSelection && column3.IsFixed == global::Infragistics.Controls.Grids.FixedState.NotFixed && !this._allDataColumnsCache.Contains(column3))
				{
					this._allDataColumnsCache.Add(column3);
				}
			}
			global::Infragistics.Controls.Grids.FixedColumnsCollection fixedColumnsRight = this.FixedColumnsRight;
			int count = fixedColumnsRight.Count;
			for (int i = count - 1; i >= 0; i--)
			{
				if (fixedColumnsRight[i].Visibility == global::System.Windows.Visibility.Visible)
				{
					if (!(fixedColumnsRight[i] is global::Infragistics.Controls.Grids.GroupColumn))
					{
						this._allDataColumnsCache.Add(fixedColumnsRight[i]);
					}
					else
					{
						this._allDataColumnsCache.AddRange(fixedColumnsRight[i].AllVisibleChildColumns);
					}
				}
			}
		}

		// Token: 0x0600111D RID: 4381 RVA: 0x0003F8FC File Offset: 0x0003DAFC
		internal void InternalRegisterFixedAdornerColumn(global::Infragistics.Controls.Grids.Column column, bool first)
		{
			this.RegisterFixedAdornerColumn(column, first);
		}

		// Token: 0x0600111E RID: 4382 RVA: 0x0003F906 File Offset: 0x0003DB06
		internal void InternalUnregisterFixedAdornerColumn(global::Infragistics.Controls.Grids.Column column)
		{
			this.UnregisterFixedAdornerColumn(column);
		}

		// Token: 0x0600111F RID: 4383 RVA: 0x0003F910 File Offset: 0x0003DB10
		protected override void AddItem(int index, global::Infragistics.Controls.Grids.ColumnBase item)
		{
			if (!item.IsMoving)
			{
				this.ColumnLayout.OnColumnAdded(item);
				base.AddItem(index, item);
				return;
			}
			base.AddItem(index, item);
			global::Infragistics.Controls.Grids.ColumnLayout columnLayout = item as global::Infragistics.Controls.Grids.ColumnLayout;
			if (columnLayout != null)
			{
				this.ColumnLayout.OnChildColumnLayoutAdded(columnLayout);
			}
		}

		// Token: 0x06001120 RID: 4384 RVA: 0x0003F958 File Offset: 0x0003DB58
		public override void Insert(int index, global::Infragistics.Controls.Grids.ColumnBase item)
		{
			this.AddItem(index, item);
		}

		// Token: 0x06001121 RID: 4385 RVA: 0x0003F964 File Offset: 0x0003DB64
		protected override bool RemoveItem(int index)
		{
			global::Infragistics.Controls.Grids.ColumnBase columnBase = this.Items[index];
			if (!columnBase.IsMoving)
			{
				this.ColumnLayout.OnColumnRemoved(columnBase);
			}
			if (this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.InvalidateScrollPanel(true);
			}
			return base.RemoveItem(index);
		}

		// Token: 0x06001122 RID: 4386 RVA: 0x0003F9B8 File Offset: 0x0003DBB8
		protected override void ResetItems()
		{
			global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnBase> allColumns = this.AllColumns;
			base.ResetItems();
			foreach (global::Infragistics.Controls.Grids.ColumnBase columnBase in allColumns)
			{
				this.ColumnLayout.OnColumnRemoved(columnBase);
			}
			this.InvalidateSelection(this.ColumnLayout);
			if (this.GroupByColumns != null)
			{
				this.GroupByColumns.Clear();
			}
			this.FixedColumnsLeft.Clear();
			this.FixedColumnsRight.Clear();
			this.SortedColumns.Clear();
			this._internalColumnLayouts.Clear();
			this._nonLayoutColumns.Clear();
			this._internalVisibleColumns.Clear();
			if (this.ColumnLayout.Grid != null)
			{
				this.ColumnLayout.Grid.InvalidateScrollPanel(true);
			}
		}

		// Token: 0x06001123 RID: 4387 RVA: 0x0003FA94 File Offset: 0x0003DC94
		protected override void AddItemSilently(int index, global::Infragistics.Controls.Grids.ColumnBase item)
		{
			base.AddItemSilently(index, item);
			this.InvalidateColumnsCollections(true);
		}

		// Token: 0x06001124 RID: 4388 RVA: 0x0003FAA8 File Offset: 0x0003DCA8
		protected override bool RemoveItemSilently(int index)
		{
			global::Infragistics.Controls.Grids.ColumnBase columnBase = this.Items[index];
			bool result = base.RemoveItemSilently(index);
			bool flag = !columnBase.IsMoving;
			if (flag && this.ColumnLayout != null && this.ColumnLayout.Grid != null)
			{
				this.InvalidateSelection(columnBase);
				this.InvalidateActiveCell(columnBase);
			}
			this.InvalidateColumnsCollections(flag);
			return result;
		}

		// Token: 0x06001125 RID: 4389 RVA: 0x0003FB02 File Offset: 0x0003DD02
		global::System.Collections.ObjectModel.Collection<string> global::Infragistics.IProvidePersistenceLookupKeys.GetLookupKeys()
		{
			return this.GetLookupKeys();
		}

		// Token: 0x06001126 RID: 4390 RVA: 0x0003FB0A File Offset: 0x0003DD0A
		bool global::Infragistics.IProvidePersistenceLookupKeys.CanRehydrate(global::System.Collections.ObjectModel.Collection<string> lookupKeys)
		{
			return this.CanRehydrate(lookupKeys);
		}

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001127 RID: 4391 RVA: 0x0003FB13 File Offset: 0x0003DD13
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PropertiesToIgnore
		{
			get
			{
				return this.PropertiesToIgnore;
			}
		}

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001128 RID: 4392 RVA: 0x0003FB1B File Offset: 0x0003DD1B
		global::System.Collections.Generic.List<string> global::Infragistics.IProvidePropertyPersistenceSettings.PriorityProperties
		{
			get
			{
				return this.PriorityProperties;
			}
		}

		// Token: 0x06001129 RID: 4393 RVA: 0x0003FB23 File Offset: 0x0003DD23
		void global::Infragistics.IProvidePropertyPersistenceSettings.FinishedLoadingPersistence()
		{
			this.FinishedLoadingPersistence();
		}

		// Token: 0x04000550 RID: 1360
		private global::Infragistics.Controls.Grids.ColumnLayout _columnLayout;

		// Token: 0x04000551 RID: 1361
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.ColumnLayout> _columnLayouts;

		// Token: 0x04000552 RID: 1362
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.ColumnLayout> _internalColumnLayouts;

		// Token: 0x04000553 RID: 1363
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> _internalFixedAdornerColumns;

		// Token: 0x04000554 RID: 1364
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> _internalVisibleColumns;

		// Token: 0x04000555 RID: 1365
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> _nonLayoutColumns;

		// Token: 0x04000556 RID: 1366
		private global::System.Collections.ObjectModel.Collection<global::Infragistics.Controls.Grids.Column> _starColumns;

		// Token: 0x04000557 RID: 1367
		private global::System.Collections.Generic.List<global::Infragistics.Controls.Grids.Column> _allDataColumnsCache;

		// Token: 0x04000558 RID: 1368
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _fixedAdornerColumns;

		// Token: 0x04000559 RID: 1369
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _visibleColumns;

		// Token: 0x0400055A RID: 1370
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _dataColumns;

		// Token: 0x0400055B RID: 1371
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _startColumnsReadOnly;

		// Token: 0x0400055C RID: 1372
		private global::Infragistics.Controls.Grids.ReadOnlyKeyedColumnBaseCollection<global::Infragistics.Controls.Grids.Column> _allDataColumnsCacheReadOnly;

		// Token: 0x0400055D RID: 1373
		private global::Infragistics.Controls.Grids.Primitives.ExpansionIndicatorColumn _expansionIndicatorColumn;

		// Token: 0x0400055E RID: 1374
		private global::Infragistics.Controls.Grids.Primitives.RowSelectorColumn _rowSelectorColumn;

		// Token: 0x0400055F RID: 1375
		private global::Infragistics.Controls.Grids.Primitives.FillerColumn _fillerColumn;

		// Token: 0x04000560 RID: 1376
		private global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn _fixedBorderColumnLeft;

		// Token: 0x04000561 RID: 1377
		private global::Infragistics.Controls.Grids.Primitives.FixedBorderColumn _fixedBorderColumnRight;

		// Token: 0x04000562 RID: 1378
		private global::System.Collections.Generic.List<string> _propertiesThatShouldntBePersisted;

		// Token: 0x04000563 RID: 1379
		private bool _rebuildAllDataColumnsCache = true;
	}
}
