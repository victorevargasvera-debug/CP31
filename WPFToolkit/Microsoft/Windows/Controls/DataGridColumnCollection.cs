using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Windows;
using System.Windows.Threading;
using MS.Internal;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000075 RID: 117
	internal class DataGridColumnCollection : global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Windows.Controls.DataGridColumn>
	{
		// Token: 0x0600081F RID: 2079 RVA: 0x0002438C File Offset: 0x0002258C
		internal DataGridColumnCollection(global::Microsoft.Windows.Controls.DataGrid dataGridOwner)
		{
			this.DisplayIndexMap = new global::System.Collections.Generic.List<int>(5);
			this._dataGridOwner = dataGridOwner;
			this.RealizedColumnsBlockListForNonVirtualizedRows = null;
			this.RealizedColumnsDisplayIndexBlockListForNonVirtualizedRows = null;
			this.RebuildRealizedColumnsBlockListForNonVirtualizedRows = true;
			this.RealizedColumnsBlockListForVirtualizedRows = null;
			this.RealizedColumnsDisplayIndexBlockListForVirtualizedRows = null;
			this.RebuildRealizedColumnsBlockListForVirtualizedRows = true;
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x000243E8 File Offset: 0x000225E8
		protected override void InsertItem(int index, global::Microsoft.Windows.Controls.DataGridColumn item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_NullColumn));
			}
			if (item.DataGridOwner != null)
			{
				throw new global::System.ArgumentException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_InvalidColumnReuse, new object[]
				{
					item.Header
				}), "item");
			}
			if (this.DisplayIndexMapInitialized)
			{
				this.ValidateDisplayIndex(item, item.DisplayIndex, true);
			}
			base.InsertItem(index, item);
			item.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenProperty);
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00024464 File Offset: 0x00022664
		protected override void SetItem(int index, global::Microsoft.Windows.Controls.DataGridColumn item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_NullColumn));
			}
			if (index >= base.Count || index < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("index", global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_ColumnIndexOutOfRange, new object[]
				{
					item.Header
				}));
			}
			if (item.DataGridOwner != null && base[index] != item)
			{
				throw new global::System.ArgumentException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_InvalidColumnReuse, new object[]
				{
					item.Header
				}), "item");
			}
			if (this.DisplayIndexMapInitialized)
			{
				this.ValidateDisplayIndex(item, item.DisplayIndex);
			}
			base.SetItem(index, item);
			item.CoerceValue(global::Microsoft.Windows.Controls.DataGridColumn.IsFrozenProperty);
		}

		// Token: 0x06000822 RID: 2082 RVA: 0x0002451C File Offset: 0x0002271C
		protected override void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (this.DisplayIndexMapInitialized)
				{
					this.UpdateDisplayIndexForNewColumns(e.NewItems, e.NewStartingIndex);
				}
				this.InvalidateHasVisibleStarColumns();
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (this.DisplayIndexMapInitialized)
				{
					this.UpdateDisplayIndexForRemovedColumns(e.OldItems, e.OldStartingIndex);
				}
				this.ClearDisplayIndex(e.OldItems, e.NewItems);
				this.InvalidateHasVisibleStarColumns();
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				if (this.DisplayIndexMapInitialized)
				{
					this.UpdateDisplayIndexForReplacedColumn(e.OldItems, e.NewItems);
				}
				this.ClearDisplayIndex(e.OldItems, e.NewItems);
				this.InvalidateHasVisibleStarColumns();
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
				if (this.DisplayIndexMapInitialized)
				{
					this.UpdateDisplayIndexForMovedColumn(e.OldStartingIndex, e.NewStartingIndex);
				}
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				if (this.DisplayIndexMapInitialized)
				{
					this.DisplayIndexMap.Clear();
					this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, -1, null, -1);
				}
				this.HasVisibleStarColumns = false;
				break;
			}
			base.OnCollectionChanged(e);
		}

		// Token: 0x06000823 RID: 2083 RVA: 0x0002462E File Offset: 0x0002282E
		protected override void ClearItems()
		{
			this.ClearDisplayIndex(this, null);
			this.DataGridOwner.UpdateDataGridReference(this, true);
			base.ClearItems();
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x0002464C File Offset: 0x0002284C
		internal void NotifyPropertyChanged(global::System.Windows.DependencyObject d, string propertyName, global::System.Windows.DependencyPropertyChangedEventArgs e, global::Microsoft.Windows.Controls.NotificationTarget target)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumnCollection(target))
			{
				if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty)
				{
					this.OnColumnDisplayIndexChanged((global::Microsoft.Windows.Controls.DataGridColumn)d, (int)e.OldValue, (int)e.NewValue);
					if (((global::Microsoft.Windows.Controls.DataGridColumn)d).IsVisible)
					{
						this.InvalidateColumnRealization(true);
					}
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.WidthProperty)
				{
					if (((global::Microsoft.Windows.Controls.DataGridColumn)d).IsVisible)
					{
						this.InvalidateColumnRealization(false);
					}
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.FrozenColumnCountProperty)
				{
					this.InvalidateColumnRealization(false);
					this.OnDataGridFrozenColumnCountChanged((int)e.OldValue, (int)e.NewValue);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGridColumn.VisibilityProperty)
				{
					this.InvalidateHasVisibleStarColumns();
					this.InvalidateColumnWidthsComputation();
					this.InvalidateColumnRealization(true);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.EnableColumnVirtualizationProperty)
				{
					this.InvalidateColumnRealization(true);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.CellsPanelHorizontalOffsetProperty)
				{
					this.OnCellsPanelHorizontalOffsetChanged(e);
				}
				else if (e.Property == global::Microsoft.Windows.Controls.DataGrid.HorizontalScrollOffsetProperty || string.Compare(propertyName, "ViewportWidth", global::System.StringComparison.Ordinal) == 0)
				{
					this.InvalidateColumnRealization(false);
				}
			}
			if (global::Microsoft.Windows.Controls.DataGridHelper.ShouldNotifyColumns(target))
			{
				int count = base.Count;
				for (int i = 0; i < count; i++)
				{
					base[i].NotifyPropertyChanged(d, e, global::Microsoft.Windows.Controls.NotificationTarget.Columns);
				}
			}
		}

		// Token: 0x06000825 RID: 2085 RVA: 0x000247B1 File Offset: 0x000229B1
		internal global::Microsoft.Windows.Controls.DataGridColumn ColumnFromDisplayIndex(int displayIndex)
		{
			return base[this.DisplayIndexMap[displayIndex]];
		}

		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x000247C5 File Offset: 0x000229C5
		// (set) Token: 0x06000827 RID: 2087 RVA: 0x000247DB File Offset: 0x000229DB
		internal global::System.Collections.Generic.List<int> DisplayIndexMap
		{
			get
			{
				if (!this.DisplayIndexMapInitialized)
				{
					this.InitializeDisplayIndexMap();
				}
				return this._displayIndexMap;
			}
			private set
			{
				this._displayIndexMap = value;
			}
		}

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000828 RID: 2088 RVA: 0x000247E4 File Offset: 0x000229E4
		// (set) Token: 0x06000829 RID: 2089 RVA: 0x000247EC File Offset: 0x000229EC
		private bool IsUpdatingDisplayIndex
		{
			get
			{
				return this._isUpdatingDisplayIndex;
			}
			set
			{
				this._isUpdatingDisplayIndex = value;
			}
		}

		// Token: 0x0600082A RID: 2090 RVA: 0x000247F5 File Offset: 0x000229F5
		private int CoerceDefaultDisplayIndex(global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			return this.CoerceDefaultDisplayIndex(column, base.IndexOf(column));
		}

		// Token: 0x0600082B RID: 2091 RVA: 0x00024808 File Offset: 0x00022A08
		private int CoerceDefaultDisplayIndex(global::Microsoft.Windows.Controls.DataGridColumn column, int newDisplayIndex)
		{
			if (global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(column, global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty))
			{
				bool isUpdatingDisplayIndex = this.IsUpdatingDisplayIndex;
				try
				{
					this.IsUpdatingDisplayIndex = true;
					column.DisplayIndex = newDisplayIndex;
				}
				finally
				{
					this.IsUpdatingDisplayIndex = isUpdatingDisplayIndex;
				}
				return newDisplayIndex;
			}
			return column.DisplayIndex;
		}

		// Token: 0x0600082C RID: 2092 RVA: 0x0002485C File Offset: 0x00022A5C
		private void OnColumnDisplayIndexChanged(global::Microsoft.Windows.Controls.DataGridColumn column, int oldDisplayIndex, int newDisplayIndex)
		{
			int num = oldDisplayIndex;
			if (!this._displayIndexMapInitialized)
			{
				this.InitializeDisplayIndexMap(column, oldDisplayIndex, out oldDisplayIndex);
			}
			if (this._isClearingDisplayIndex)
			{
				return;
			}
			newDisplayIndex = this.CoerceDefaultDisplayIndex(column);
			if (newDisplayIndex == oldDisplayIndex)
			{
				return;
			}
			if (num != -1)
			{
				this.DataGridOwner.OnColumnDisplayIndexChanged(new global::Microsoft.Windows.Controls.DataGridColumnEventArgs(column));
			}
			this.UpdateDisplayIndexForChangedColumn(oldDisplayIndex, newDisplayIndex);
		}

		// Token: 0x0600082D RID: 2093 RVA: 0x000248B4 File Offset: 0x00022AB4
		private void UpdateDisplayIndexForChangedColumn(int oldDisplayIndex, int newDisplayIndex)
		{
			if (this.IsUpdatingDisplayIndex)
			{
				return;
			}
			try
			{
				this.IsUpdatingDisplayIndex = true;
				int item = this.DisplayIndexMap[oldDisplayIndex];
				this.DisplayIndexMap.RemoveAt(oldDisplayIndex);
				this.DisplayIndexMap.Insert(newDisplayIndex, item);
				if (newDisplayIndex < oldDisplayIndex)
				{
					for (int i = newDisplayIndex + 1; i <= oldDisplayIndex; i++)
					{
						this.ColumnFromDisplayIndex(i).DisplayIndex++;
					}
				}
				else
				{
					for (int j = oldDisplayIndex; j < newDisplayIndex; j++)
					{
						this.ColumnFromDisplayIndex(j).DisplayIndex--;
					}
				}
				this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, oldDisplayIndex, null, newDisplayIndex);
			}
			finally
			{
				this.IsUpdatingDisplayIndex = false;
			}
		}

		// Token: 0x0600082E RID: 2094 RVA: 0x00024968 File Offset: 0x00022B68
		private void UpdateDisplayIndexForMovedColumn(int oldColumnIndex, int newColumnIndex)
		{
			int newDisplayIndex = this.RemoveFromDisplayIndexMap(oldColumnIndex);
			this.InsertInDisplayIndexMap(newDisplayIndex, newColumnIndex);
			this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Move, oldColumnIndex, null, newColumnIndex);
		}

		// Token: 0x0600082F RID: 2095 RVA: 0x00024994 File Offset: 0x00022B94
		private void UpdateDisplayIndexForNewColumns(global::System.Collections.IList newColumns, int startingIndex)
		{
			try
			{
				this.IsUpdatingDisplayIndex = true;
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)newColumns[0];
				int num = this.CoerceDefaultDisplayIndex(dataGridColumn, startingIndex);
				this.InsertInDisplayIndexMap(num, startingIndex);
				for (int i = 0; i < this.DisplayIndexMap.Count; i++)
				{
					if (i > num)
					{
						dataGridColumn = this.ColumnFromDisplayIndex(i);
						dataGridColumn.DisplayIndex++;
					}
				}
				this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, -1, null, num);
			}
			finally
			{
				this.IsUpdatingDisplayIndex = false;
			}
		}

		// Token: 0x06000830 RID: 2096 RVA: 0x00024A24 File Offset: 0x00022C24
		internal void InitializeDisplayIndexMap()
		{
			int num = -1;
			this.InitializeDisplayIndexMap(null, -1, out num);
		}

		// Token: 0x06000831 RID: 2097 RVA: 0x00024A40 File Offset: 0x00022C40
		private void InitializeDisplayIndexMap(global::Microsoft.Windows.Controls.DataGridColumn changingColumn, int oldDisplayIndex, out int resultDisplayIndex)
		{
			resultDisplayIndex = oldDisplayIndex;
			if (this._displayIndexMapInitialized)
			{
				return;
			}
			this._displayIndexMapInitialized = true;
			int count = base.Count;
			global::System.Collections.Generic.Dictionary<int, int> dictionary = new global::System.Collections.Generic.Dictionary<int, int>();
			if (changingColumn != null && oldDisplayIndex >= count)
			{
				throw new global::System.ArgumentOutOfRangeException("displayIndex", oldDisplayIndex, global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_ColumnDisplayIndexOutOfRange, new object[]
				{
					changingColumn.Header
				}));
			}
			for (int i = 0; i < count; i++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = base[i];
				int num = dataGridColumn.DisplayIndex;
				this.ValidateDisplayIndex(dataGridColumn, num);
				if (dataGridColumn == changingColumn)
				{
					num = oldDisplayIndex;
				}
				if (num >= 0)
				{
					if (dictionary.ContainsKey(num))
					{
						throw new global::System.ArgumentException(global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_DuplicateDisplayIndex));
					}
					dictionary.Add(num, i);
				}
			}
			int num2 = 0;
			for (int j = 0; j < count; j++)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn2 = base[j];
				int displayIndex = dataGridColumn2.DisplayIndex;
				bool flag = global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(dataGridColumn2, global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty);
				if (dataGridColumn2 == changingColumn && oldDisplayIndex == -1)
				{
					flag = true;
				}
				if (flag)
				{
					while (dictionary.ContainsKey(num2))
					{
						num2++;
					}
					this.CoerceDefaultDisplayIndex(dataGridColumn2, num2);
					dictionary.Add(num2, j);
					if (dataGridColumn2 == changingColumn)
					{
						resultDisplayIndex = num2;
					}
					num2++;
				}
			}
			for (int k = 0; k < count; k++)
			{
				this.DisplayIndexMap.Add(dictionary[k]);
			}
		}

		// Token: 0x06000832 RID: 2098 RVA: 0x00024B94 File Offset: 0x00022D94
		private void UpdateDisplayIndexForRemovedColumns(global::System.Collections.IList oldColumns, int startingIndex)
		{
			try
			{
				this.IsUpdatingDisplayIndex = true;
				int num = this.RemoveFromDisplayIndexMap(startingIndex);
				for (int i = 0; i < this.DisplayIndexMap.Count; i++)
				{
					if (i >= num)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
						dataGridColumn.DisplayIndex--;
					}
				}
				this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, num, (global::Microsoft.Windows.Controls.DataGridColumn)oldColumns[0], -1);
			}
			finally
			{
				this.IsUpdatingDisplayIndex = false;
			}
		}

		// Token: 0x06000833 RID: 2099 RVA: 0x00024C14 File Offset: 0x00022E14
		private void UpdateDisplayIndexForReplacedColumn(global::System.Collections.IList oldColumns, global::System.Collections.IList newColumns)
		{
			if (oldColumns != null && oldColumns.Count > 0 && newColumns != null && newColumns.Count > 0)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)oldColumns[0];
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn2 = (global::Microsoft.Windows.Controls.DataGridColumn)newColumns[0];
				if (dataGridColumn != null && dataGridColumn2 != null)
				{
					int num = this.CoerceDefaultDisplayIndex(dataGridColumn2);
					if (dataGridColumn.DisplayIndex != num)
					{
						this.UpdateDisplayIndexForChangedColumn(dataGridColumn.DisplayIndex, num);
					}
					this.DataGridOwner.UpdateColumnsOnVirtualizedCellInfoCollections(global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace, num, dataGridColumn, num);
				}
			}
		}

		// Token: 0x06000834 RID: 2100 RVA: 0x00024C88 File Offset: 0x00022E88
		private void ClearDisplayIndex(global::System.Collections.IList oldColumns, global::System.Collections.IList newColumns)
		{
			if (oldColumns != null)
			{
				try
				{
					this._isClearingDisplayIndex = true;
					int count = oldColumns.Count;
					for (int i = 0; i < count; i++)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = (global::Microsoft.Windows.Controls.DataGridColumn)oldColumns[i];
						if (newColumns == null || !newColumns.Contains(dataGridColumn))
						{
							dataGridColumn.ClearValue(global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty);
						}
					}
				}
				finally
				{
					this._isClearingDisplayIndex = false;
				}
			}
		}

		// Token: 0x06000835 RID: 2101 RVA: 0x00024CF0 File Offset: 0x00022EF0
		private bool IsDisplayIndexValid(global::Microsoft.Windows.Controls.DataGridColumn column, int displayIndex, bool isAdding)
		{
			if (displayIndex == -1 && global::Microsoft.Windows.Controls.DataGridHelper.IsDefaultValue(column, global::Microsoft.Windows.Controls.DataGridColumn.DisplayIndexProperty))
			{
				return true;
			}
			if (displayIndex < 0)
			{
				return false;
			}
			if (!isAdding)
			{
				return displayIndex < base.Count;
			}
			return displayIndex <= base.Count;
		}

		// Token: 0x06000836 RID: 2102 RVA: 0x00024D24 File Offset: 0x00022F24
		private void InsertInDisplayIndexMap(int newDisplayIndex, int columnIndex)
		{
			this.DisplayIndexMap.Insert(newDisplayIndex, columnIndex);
			for (int i = 0; i < this.DisplayIndexMap.Count; i++)
			{
				if (this.DisplayIndexMap[i] >= columnIndex && i != newDisplayIndex)
				{
					global::System.Collections.Generic.List<int> displayIndexMap;
					int index;
					(displayIndexMap = this.DisplayIndexMap)[index = i] = displayIndexMap[index] + 1;
				}
			}
		}

		// Token: 0x06000837 RID: 2103 RVA: 0x00024D80 File Offset: 0x00022F80
		private int RemoveFromDisplayIndexMap(int columnIndex)
		{
			int num = this.DisplayIndexMap.IndexOf(columnIndex);
			this.DisplayIndexMap.RemoveAt(num);
			for (int i = 0; i < this.DisplayIndexMap.Count; i++)
			{
				if (this.DisplayIndexMap[i] >= columnIndex)
				{
					global::System.Collections.Generic.List<int> displayIndexMap;
					int index;
					(displayIndexMap = this.DisplayIndexMap)[index = i] = displayIndexMap[index] - 1;
				}
			}
			return num;
		}

		// Token: 0x06000838 RID: 2104 RVA: 0x00024DE5 File Offset: 0x00022FE5
		internal void ValidateDisplayIndex(global::Microsoft.Windows.Controls.DataGridColumn column, int displayIndex)
		{
			this.ValidateDisplayIndex(column, displayIndex, false);
		}

		// Token: 0x06000839 RID: 2105 RVA: 0x00024DF0 File Offset: 0x00022FF0
		internal void ValidateDisplayIndex(global::Microsoft.Windows.Controls.DataGridColumn column, int displayIndex, bool isAdding)
		{
			if (!this.IsDisplayIndexValid(column, displayIndex, isAdding))
			{
				throw new global::System.ArgumentOutOfRangeException("displayIndex", displayIndex, global::Microsoft.Windows.Controls.SR.Get(global::Microsoft.Windows.Controls.SRID.DataGrid_ColumnDisplayIndexOutOfRange, new object[]
				{
					column.Header
				}));
			}
		}

		// Token: 0x0600083A RID: 2106 RVA: 0x00024E34 File Offset: 0x00023034
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void Debug_VerifyDisplayIndexMap()
		{
			for (int i = 0; i < this.DisplayIndexMap.Count; i++)
			{
			}
		}

		// Token: 0x0600083B RID: 2107 RVA: 0x00024E58 File Offset: 0x00023058
		private void OnDataGridFrozenColumnCountChanged(int oldFrozenCount, int newFrozenCount)
		{
			if (newFrozenCount > oldFrozenCount)
			{
				int num = global::System.Math.Min(newFrozenCount, base.Count);
				for (int i = oldFrozenCount; i < num; i++)
				{
					this.ColumnFromDisplayIndex(i).IsFrozen = true;
				}
				return;
			}
			int num2 = global::System.Math.Min(oldFrozenCount, base.Count);
			for (int j = newFrozenCount; j < num2; j++)
			{
				this.ColumnFromDisplayIndex(j).IsFrozen = false;
			}
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x0600083C RID: 2108 RVA: 0x00024EB6 File Offset: 0x000230B6
		private global::Microsoft.Windows.Controls.DataGrid DataGridOwner
		{
			get
			{
				return this._dataGridOwner;
			}
		}

		// Token: 0x170001F8 RID: 504
		// (get) Token: 0x0600083D RID: 2109 RVA: 0x00024EBE File Offset: 0x000230BE
		internal bool DisplayIndexMapInitialized
		{
			get
			{
				return this._displayIndexMapInitialized;
			}
		}

		// Token: 0x0600083E RID: 2110 RVA: 0x00024EC8 File Offset: 0x000230C8
		private bool HasVisibleStarColumnsInternal(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, out double perStarWidth)
		{
			bool result = false;
			perStarWidth = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn != ignoredColumn && dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (width.IsStar)
					{
						result = true;
						if (!global::MS.Internal.DoubleUtil.AreClose(width.Value, 0.0) && !global::MS.Internal.DoubleUtil.AreClose(width.DesiredValue, 0.0))
						{
							perStarWidth = width.DesiredValue / width.Value;
							break;
						}
					}
				}
			}
			return result;
		}

		// Token: 0x0600083F RID: 2111 RVA: 0x00024F78 File Offset: 0x00023178
		private bool HasVisibleStarColumnsInternal(out double perStarWidth)
		{
			return this.HasVisibleStarColumnsInternal(null, out perStarWidth);
		}

		// Token: 0x06000840 RID: 2112 RVA: 0x00024F84 File Offset: 0x00023184
		private bool HasVisibleStarColumnsInternal(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn)
		{
			double num;
			return this.HasVisibleStarColumnsInternal(ignoredColumn, out num);
		}

		// Token: 0x170001F9 RID: 505
		// (get) Token: 0x06000841 RID: 2113 RVA: 0x00024F9A File Offset: 0x0002319A
		// (set) Token: 0x06000842 RID: 2114 RVA: 0x00024FA2 File Offset: 0x000231A2
		internal bool HasVisibleStarColumns { get; private set; }

		// Token: 0x06000843 RID: 2115 RVA: 0x00024FAB File Offset: 0x000231AB
		internal void InvalidateHasVisibleStarColumns()
		{
			this.HasVisibleStarColumns = this.HasVisibleStarColumnsInternal(null);
		}

		// Token: 0x06000844 RID: 2116 RVA: 0x00024FBC File Offset: 0x000231BC
		private void RecomputeStarColumnWidths()
		{
			double viewportWidthForColumns = this.DataGridOwner.GetViewportWidthForColumns();
			double num = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (dataGridColumn.IsVisible && !width.IsStar)
				{
					num += width.DisplayValue;
				}
			}
			if (global::MS.Internal.DoubleUtil.IsNaN(num))
			{
				return;
			}
			this.ComputeStarColumnWidths(viewportWidthForColumns - num);
		}

		// Token: 0x06000845 RID: 2117 RVA: 0x00025050 File Offset: 0x00023250
		private double ComputeStarColumnWidths(double availableStarSpace)
		{
			global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.DataGridColumn> list = new global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.DataGridColumn>();
			global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.DataGridColumn> list2 = new global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.DataGridColumn>();
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			double num4 = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (dataGridColumn.IsVisible && width.IsStar)
				{
					list.Add(dataGridColumn);
					num += width.Value;
					num2 += dataGridColumn.MinWidth;
					num3 += dataGridColumn.MaxWidth;
				}
			}
			if (global::MS.Internal.DoubleUtil.LessThan(availableStarSpace, num2))
			{
				availableStarSpace = num2;
			}
			if (global::MS.Internal.DoubleUtil.GreaterThan(availableStarSpace, num3))
			{
				availableStarSpace = num3;
			}
			while (list.Count > 0)
			{
				double num5 = availableStarSpace / num;
				int i = 0;
				int num6 = list.Count;
				while (i < num6)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn2 = list[i];
					global::Microsoft.Windows.Controls.DataGridLength width2 = dataGridColumn2.Width;
					double minWidth = dataGridColumn2.MinWidth;
					double value = availableStarSpace * width2.Value / num;
					if (global::MS.Internal.DoubleUtil.GreaterThan(minWidth, value))
					{
						availableStarSpace = global::System.Math.Max(0.0, availableStarSpace - minWidth);
						num -= width2.Value;
						list.RemoveAt(i);
						i--;
						num6--;
						list2.Add(dataGridColumn2);
					}
					i++;
				}
				bool flag = false;
				int j = 0;
				int count = list.Count;
				while (j < count)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn3 = list[j];
					global::Microsoft.Windows.Controls.DataGridLength width3 = dataGridColumn3.Width;
					double maxWidth = dataGridColumn3.MaxWidth;
					double value2 = availableStarSpace * width3.Value / num;
					if (global::MS.Internal.DoubleUtil.LessThan(maxWidth, value2))
					{
						flag = true;
						list.RemoveAt(j);
						availableStarSpace -= maxWidth;
						num4 += maxWidth;
						num -= width3.Value;
						dataGridColumn3.UpdateWidthForStarColumn(maxWidth, num5 * width3.Value, width3.Value);
						break;
					}
					j++;
				}
				if (flag)
				{
					int k = 0;
					int count2 = list2.Count;
					while (k < count2)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn4 = list2[k];
						list.Add(dataGridColumn4);
						availableStarSpace += dataGridColumn4.MinWidth;
						num += dataGridColumn4.Width.Value;
						k++;
					}
					list2.Clear();
				}
				else
				{
					int l = 0;
					int count3 = list2.Count;
					while (l < count3)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn5 = list2[l];
						global::Microsoft.Windows.Controls.DataGridLength width4 = dataGridColumn5.Width;
						double minWidth2 = dataGridColumn5.MinWidth;
						dataGridColumn5.UpdateWidthForStarColumn(minWidth2, width4.Value * num5, width4.Value);
						num4 += minWidth2;
						l++;
					}
					list2.Clear();
					int m = 0;
					int count4 = list.Count;
					while (m < count4)
					{
						global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn6 = list[m];
						global::Microsoft.Windows.Controls.DataGridLength width5 = dataGridColumn6.Width;
						double num7 = availableStarSpace * width5.Value / num;
						dataGridColumn6.UpdateWidthForStarColumn(num7, width5.Value * num5, width5.Value);
						num4 += num7;
						m++;
					}
					list.Clear();
				}
			}
			return num4;
		}

		// Token: 0x06000846 RID: 2118 RVA: 0x00025370 File Offset: 0x00023570
		private void OnCellsPanelHorizontalOffsetChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			this.InvalidateColumnRealization(false);
			double viewportWidthForColumns = this.DataGridOwner.GetViewportWidthForColumns();
			this.RedistributeColumnWidthsOnAvailableSpaceChange((double)e.OldValue - (double)e.NewValue, viewportWidthForColumns);
		}

		// Token: 0x06000847 RID: 2119 RVA: 0x000253B0 File Offset: 0x000235B0
		internal void InvalidateAverageColumnWidth()
		{
			this._averageColumnWidth = null;
		}

		// Token: 0x170001FA RID: 506
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x000253BE File Offset: 0x000235BE
		internal double AverageColumnWidth
		{
			get
			{
				if (this._averageColumnWidth == null)
				{
					this._averageColumnWidth = new double?(this.ComputeAverageColumnWidth());
				}
				return this._averageColumnWidth.Value;
			}
		}

		// Token: 0x06000849 RID: 2121 RVA: 0x000253EC File Offset: 0x000235EC
		private double ComputeAverageColumnWidth()
		{
			double num = 0.0;
			int num2 = 0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (dataGridColumn.IsVisible && !global::MS.Internal.DoubleUtil.IsNaN(width.DisplayValue))
				{
					num += width.DisplayValue;
					num2++;
				}
			}
			if (num2 != 0)
			{
				return num / (double)num2;
			}
			return 0.0;
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x0600084A RID: 2122 RVA: 0x0002547C File Offset: 0x0002367C
		internal bool ColumnWidthsComputationPending
		{
			get
			{
				return this._columnWidthsComputationPending;
			}
		}

		// Token: 0x0600084B RID: 2123 RVA: 0x00025484 File Offset: 0x00023684
		internal void InvalidateColumnWidthsComputation()
		{
			if (this._columnWidthsComputationPending)
			{
				return;
			}
			this.DataGridOwner.Dispatcher.BeginInvoke(new global::System.Windows.Threading.DispatcherOperationCallback(this.ComputeColumnWidths), global::System.Windows.Threading.DispatcherPriority.Render, new object[]
			{
				this
			});
			this._columnWidthsComputationPending = true;
		}

		// Token: 0x0600084C RID: 2124 RVA: 0x000254CC File Offset: 0x000236CC
		private object ComputeColumnWidths(object arg)
		{
			this.ComputeColumnWidths();
			this.DataGridOwner.NotifyPropertyChanged(this.DataGridOwner, "DelayedColumnWidthComputation", default(global::System.Windows.DependencyPropertyChangedEventArgs), global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
			return null;
		}

		// Token: 0x0600084D RID: 2125 RVA: 0x00025504 File Offset: 0x00023704
		private void ComputeColumnWidths()
		{
			if (this.HasVisibleStarColumns)
			{
				this.InitializeColumnDisplayValues();
				this.DistributeSpaceAmongColumns(this.DataGridOwner.GetViewportWidthForColumns());
			}
			else
			{
				this.ExpandAllColumnWidthsToDesiredValue();
			}
			if (this.RefreshAutoWidthColumns)
			{
				foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
				{
					if (dataGridColumn.Width.IsAuto)
					{
						dataGridColumn.Width = global::Microsoft.Windows.Controls.DataGridLength.Auto;
					}
				}
				this.RefreshAutoWidthColumns = false;
			}
			this._columnWidthsComputationPending = false;
		}

		// Token: 0x0600084E RID: 2126 RVA: 0x000255A0 File Offset: 0x000237A0
		private void InitializeColumnDisplayValues()
		{
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (!width.IsStar)
					{
						double minWidth = dataGridColumn.MinWidth;
						double num = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(global::MS.Internal.DoubleUtil.IsNaN(width.DesiredValue) ? minWidth : width.DesiredValue, minWidth, dataGridColumn.MaxWidth);
						if (!global::MS.Internal.DoubleUtil.AreClose(width.DisplayValue, num))
						{
							dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, num));
						}
					}
				}
			}
		}

		// Token: 0x0600084F RID: 2127 RVA: 0x00025660 File Offset: 0x00023860
		internal void RedistributeColumnWidthsOnMinWidthChangeOfColumn(global::Microsoft.Windows.Controls.DataGridColumn changedColumn, double oldMinWidth)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = changedColumn.Width;
			double minWidth = changedColumn.MinWidth;
			if (global::MS.Internal.DoubleUtil.GreaterThan(minWidth, width.DisplayValue))
			{
				if (this.HasVisibleStarColumns)
				{
					this.TakeAwayWidthFromColumns(changedColumn, minWidth - width.DisplayValue, false);
				}
				changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, minWidth));
				return;
			}
			if (global::MS.Internal.DoubleUtil.LessThan(minWidth, oldMinWidth))
			{
				if (width.IsStar)
				{
					if (global::MS.Internal.DoubleUtil.AreClose(width.DisplayValue, oldMinWidth))
					{
						this.GiveAwayWidthToColumns(changedColumn, oldMinWidth - minWidth, true);
						return;
					}
				}
				else if (global::MS.Internal.DoubleUtil.GreaterThan(oldMinWidth, width.DesiredValue))
				{
					double num = global::System.Math.Max(width.DesiredValue, minWidth);
					if (this.HasVisibleStarColumns)
					{
						this.GiveAwayWidthToColumns(changedColumn, oldMinWidth - num);
					}
					changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, num));
				}
			}
		}

		// Token: 0x06000850 RID: 2128 RVA: 0x00025748 File Offset: 0x00023948
		internal void RedistributeColumnWidthsOnMaxWidthChangeOfColumn(global::Microsoft.Windows.Controls.DataGridColumn changedColumn, double oldMaxWidth)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = changedColumn.Width;
			double maxWidth = changedColumn.MaxWidth;
			if (global::MS.Internal.DoubleUtil.LessThan(maxWidth, width.DisplayValue))
			{
				if (this.HasVisibleStarColumns)
				{
					this.GiveAwayWidthToColumns(changedColumn, width.DisplayValue - maxWidth);
				}
				changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, maxWidth));
				return;
			}
			if (global::MS.Internal.DoubleUtil.GreaterThan(maxWidth, oldMaxWidth))
			{
				if (width.IsStar)
				{
					this.RecomputeStarColumnWidths();
					return;
				}
				if (global::MS.Internal.DoubleUtil.LessThan(oldMaxWidth, width.DesiredValue))
				{
					double num = global::System.Math.Min(width.DesiredValue, maxWidth);
					if (this.HasVisibleStarColumns)
					{
						double num2 = this.TakeAwayWidthFromUnusedSpace(false, num - oldMaxWidth);
						num2 = this.TakeAwayWidthFromStarColumns(changedColumn, num2);
						num -= num2;
					}
					changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, num));
				}
			}
		}

		// Token: 0x06000851 RID: 2129 RVA: 0x00025824 File Offset: 0x00023A24
		internal void RedistributeColumnWidthsOnWidthChangeOfColumn(global::Microsoft.Windows.Controls.DataGridColumn changedColumn, global::Microsoft.Windows.Controls.DataGridLength oldWidth)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = changedColumn.Width;
			bool hasVisibleStarColumns = this.HasVisibleStarColumns;
			if (oldWidth.IsStar && !width.IsStar && !hasVisibleStarColumns)
			{
				this.ExpandAllColumnWidthsToDesiredValue();
				return;
			}
			if (width.IsStar && !oldWidth.IsStar)
			{
				if (!this.HasVisibleStarColumnsInternal(changedColumn))
				{
					this.ComputeColumnWidths();
					return;
				}
				double minWidth = changedColumn.MinWidth;
				double num = this.GiveAwayWidthToNonStarColumns(null, oldWidth.DisplayValue - minWidth);
				changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, minWidth + num));
				this.RecomputeStarColumnWidths();
				return;
			}
			else
			{
				if (width.IsStar && oldWidth.IsStar)
				{
					this.RecomputeStarColumnWidths();
					return;
				}
				if (hasVisibleStarColumns)
				{
					this.RedistributeColumnWidthsOnNonStarWidthChange(changedColumn, oldWidth);
				}
				return;
			}
		}

		// Token: 0x06000852 RID: 2130 RVA: 0x000258E4 File Offset: 0x00023AE4
		internal void RedistributeColumnWidthsOnAvailableSpaceChange(double availableSpaceChange, double newTotalAvailableSpace)
		{
			if (!this.ColumnWidthsComputationPending && this.HasVisibleStarColumns)
			{
				if (global::MS.Internal.DoubleUtil.GreaterThan(availableSpaceChange, 0.0))
				{
					this.GiveAwayWidthToColumns(null, availableSpaceChange);
					return;
				}
				if (global::MS.Internal.DoubleUtil.LessThan(availableSpaceChange, 0.0))
				{
					this.TakeAwayWidthFromColumns(null, global::System.Math.Abs(availableSpaceChange), false, newTotalAvailableSpace);
				}
			}
		}

		// Token: 0x06000853 RID: 2131 RVA: 0x00025940 File Offset: 0x00023B40
		private void ExpandAllColumnWidthsToDesiredValue()
		{
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					double maxWidth = dataGridColumn.MaxWidth;
					if (global::MS.Internal.DoubleUtil.GreaterThan(width.DesiredValue, width.DisplayValue) && !global::MS.Internal.DoubleUtil.AreClose(width.DisplayValue, maxWidth))
					{
						dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, global::System.Math.Min(width.DesiredValue, maxWidth)));
					}
				}
			}
		}

		// Token: 0x06000854 RID: 2132 RVA: 0x000259E8 File Offset: 0x00023BE8
		private void RedistributeColumnWidthsOnNonStarWidthChange(global::Microsoft.Windows.Controls.DataGridColumn changedColumn, global::Microsoft.Windows.Controls.DataGridLength oldWidth)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = changedColumn.Width;
			if (global::MS.Internal.DoubleUtil.GreaterThan(width.DesiredValue, oldWidth.DisplayValue))
			{
				double num = this.TakeAwayWidthFromColumns(changedColumn, width.DesiredValue - oldWidth.DisplayValue, changedColumn != null);
				if (global::MS.Internal.DoubleUtil.GreaterThan(num, 0.0))
				{
					changedColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, global::System.Math.Max(width.DisplayValue - num, changedColumn.MinWidth)));
					return;
				}
			}
			else if (global::MS.Internal.DoubleUtil.LessThan(width.DesiredValue, oldWidth.DisplayValue))
			{
				double num2 = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(width.DesiredValue, changedColumn.MinWidth, changedColumn.MaxWidth);
				this.GiveAwayWidthToColumns(changedColumn, oldWidth.DisplayValue - num2);
			}
		}

		// Token: 0x06000855 RID: 2133 RVA: 0x00025AB4 File Offset: 0x00023CB4
		private void DistributeSpaceAmongColumns(double availableSpace)
		{
			double num = 0.0;
			double num2 = 0.0;
			double num3 = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn.IsVisible)
				{
					num += dataGridColumn.MinWidth;
					num2 += dataGridColumn.MaxWidth;
					if (dataGridColumn.Width.IsStar)
					{
						num3 += dataGridColumn.MinWidth;
					}
				}
			}
			if (global::MS.Internal.DoubleUtil.LessThan(availableSpace, num))
			{
				availableSpace = num;
			}
			if (global::MS.Internal.DoubleUtil.GreaterThan(availableSpace, num2))
			{
				availableSpace = num2;
			}
			double num4 = this.DistributeSpaceAmongNonStarColumns(availableSpace - num3);
			this.ComputeStarColumnWidths(num3 + num4);
		}

		// Token: 0x06000856 RID: 2134 RVA: 0x00025B7C File Offset: 0x00023D7C
		private double DistributeSpaceAmongNonStarColumns(double availableSpace)
		{
			double num = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (dataGridColumn.IsVisible && !width.IsStar)
				{
					num += width.DisplayValue;
				}
			}
			if (global::MS.Internal.DoubleUtil.LessThan(availableSpace, num))
			{
				double takeAwayWidth = num - availableSpace;
				this.TakeAwayWidthFromNonStarColumns(null, takeAwayWidth);
			}
			return global::System.Math.Max(availableSpace - num, 0.0);
		}

		// Token: 0x06000857 RID: 2135 RVA: 0x00025C18 File Offset: 0x00023E18
		internal void OnColumnResizeStarted()
		{
			this._originalWidthsForResize = new global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Controls.DataGridLength>();
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				this._originalWidthsForResize[dataGridColumn] = dataGridColumn.Width;
			}
		}

		// Token: 0x06000858 RID: 2136 RVA: 0x00025C78 File Offset: 0x00023E78
		internal void OnColumnResizeCompleted(bool cancel)
		{
			if (cancel && this._originalWidthsForResize != null)
			{
				foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
				{
					if (this._originalWidthsForResize.ContainsKey(dataGridColumn))
					{
						dataGridColumn.Width = this._originalWidthsForResize[dataGridColumn];
					}
				}
			}
			this._originalWidthsForResize = null;
		}

		// Token: 0x06000859 RID: 2137 RVA: 0x00025CEC File Offset: 0x00023EEC
		internal void RecomputeColumnWidthsOnColumnResize(global::Microsoft.Windows.Controls.DataGridColumn resizingColumn, double horizontalChange, bool retainAuto)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = resizingColumn.Width;
			double value = width.DisplayValue + horizontalChange;
			if (global::MS.Internal.DoubleUtil.LessThan(value, resizingColumn.MinWidth))
			{
				horizontalChange = resizingColumn.MinWidth - width.DisplayValue;
			}
			else if (global::MS.Internal.DoubleUtil.GreaterThan(value, resizingColumn.MaxWidth))
			{
				horizontalChange = resizingColumn.MaxWidth - width.DisplayValue;
			}
			int displayIndex = resizingColumn.DisplayIndex;
			if (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
			{
				this.RecomputeColumnWidthsOnColumnPositiveResize(horizontalChange, displayIndex, retainAuto);
				return;
			}
			if (global::MS.Internal.DoubleUtil.LessThan(horizontalChange, 0.0))
			{
				this.RecomputeColumnWidthsOnColumnNegativeResize(-horizontalChange, displayIndex, retainAuto);
			}
		}

		// Token: 0x0600085A RID: 2138 RVA: 0x00025D88 File Offset: 0x00023F88
		private void RecomputeColumnWidthsOnColumnPositiveResize(double horizontalChange, int resizingColumnIndex, bool retainAuto)
		{
			double perStarWidth = 0.0;
			if (this.HasVisibleStarColumnsInternal(out perStarWidth))
			{
				horizontalChange = this.TakeAwayUnusedSpaceOnColumnPositiveResize(horizontalChange, resizingColumnIndex, retainAuto);
				horizontalChange = this.RecomputeNonStarColumnWidthsOnColumnPositiveResize(horizontalChange, resizingColumnIndex, retainAuto, true);
				horizontalChange = this.RecomputeStarColumnWidthsOnColumnPositiveResize(horizontalChange, resizingColumnIndex, perStarWidth, retainAuto);
				horizontalChange = this.RecomputeNonStarColumnWidthsOnColumnPositiveResize(horizontalChange, resizingColumnIndex, retainAuto, false);
				return;
			}
			global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(resizingColumnIndex);
			global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(column, horizontalChange, retainAuto);
		}

		// Token: 0x0600085B RID: 2139 RVA: 0x00025DEC File Offset: 0x00023FEC
		private double RecomputeStarColumnWidthsOnColumnPositiveResize(double horizontalChange, int resizingColumnIndex, double perStarWidth, bool retainAuto)
		{
			while (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
			{
				double positiveInfinity = double.PositiveInfinity;
				double starFactorsForPositiveResize = this.GetStarFactorsForPositiveResize(resizingColumnIndex + 1, out positiveInfinity);
				if (!global::MS.Internal.DoubleUtil.GreaterThan(starFactorsForPositiveResize, 0.0))
				{
					break;
				}
				horizontalChange = this.ReallocateStarValuesForPositiveResize(resizingColumnIndex, horizontalChange, positiveInfinity, starFactorsForPositiveResize, perStarWidth, retainAuto);
				if (global::MS.Internal.DoubleUtil.AreClose(horizontalChange, 0.0))
				{
					break;
				}
			}
			return horizontalChange;
		}

		// Token: 0x0600085C RID: 2140 RVA: 0x00025E54 File Offset: 0x00024054
		private static bool CanColumnParticipateInResize(global::Microsoft.Windows.Controls.DataGridColumn column)
		{
			return column.IsVisible && column.CanUserResize;
		}

		// Token: 0x0600085D RID: 2141 RVA: 0x00025E68 File Offset: 0x00024068
		private double GetStarFactorsForPositiveResize(int startIndex, out double minPerStarExcessRatio)
		{
			minPerStarExcessRatio = double.PositiveInfinity;
			double num = 0.0;
			int i = startIndex;
			int count = base.Count;
			while (i < count)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
				if (global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn))
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (width.IsStar && !global::MS.Internal.DoubleUtil.AreClose(width.Value, 0.0) && global::MS.Internal.DoubleUtil.GreaterThan(width.DisplayValue, dataGridColumn.MinWidth))
					{
						num += width.Value;
						double num2 = (width.DisplayValue - dataGridColumn.MinWidth) / width.Value;
						if (global::MS.Internal.DoubleUtil.LessThan(num2, minPerStarExcessRatio))
						{
							minPerStarExcessRatio = num2;
						}
					}
				}
				i++;
			}
			return num;
		}

		// Token: 0x0600085E RID: 2142 RVA: 0x00025F24 File Offset: 0x00024124
		private double ReallocateStarValuesForPositiveResize(int startIndex, double horizontalChange, double perStarExcessRatio, double totalStarFactors, double perStarWidth, bool retainAuto)
		{
			double num;
			double num2;
			if (global::MS.Internal.DoubleUtil.LessThan(horizontalChange, perStarExcessRatio * totalStarFactors))
			{
				num = horizontalChange / totalStarFactors;
				num2 = horizontalChange;
				horizontalChange = 0.0;
			}
			else
			{
				num = perStarExcessRatio;
				num2 = num * totalStarFactors;
				horizontalChange -= num2;
			}
			int i = startIndex;
			int count = base.Count;
			while (i < count)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (i == startIndex)
				{
					global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(dataGridColumn, num2, retainAuto);
				}
				else if (dataGridColumn.Width.IsStar && global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn) && global::MS.Internal.DoubleUtil.GreaterThan(width.DisplayValue, dataGridColumn.MinWidth))
				{
					double num3 = width.DisplayValue - width.Value * num;
					dataGridColumn.UpdateWidthForStarColumn(global::System.Math.Max(num3, dataGridColumn.MinWidth), num3, num3 / perStarWidth);
				}
				i++;
			}
			return horizontalChange;
		}

		// Token: 0x0600085F RID: 2143 RVA: 0x0002600C File Offset: 0x0002420C
		private double RecomputeNonStarColumnWidthsOnColumnPositiveResize(double horizontalChange, int resizingColumnIndex, bool retainAuto, bool onlyShrinkToDesiredWidth)
		{
			if (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
			{
				double num = 0.0;
				bool flag = true;
				int num2 = base.Count - 1;
				while (flag && num2 > resizingColumnIndex)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(num2);
					if (global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn))
					{
						global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
						double minWidth = dataGridColumn.MinWidth;
						double num3 = onlyShrinkToDesiredWidth ? (width.DisplayValue - global::System.Math.Max(width.DesiredValue, dataGridColumn.MinWidth)) : (width.DisplayValue - dataGridColumn.MinWidth);
						if (!width.IsStar && global::MS.Internal.DoubleUtil.GreaterThan(num3, 0.0))
						{
							if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(num + num3, horizontalChange))
							{
								num3 = horizontalChange - num;
								flag = false;
							}
							dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, width.DisplayValue - num3));
							num += num3;
						}
					}
					num2--;
				}
				if (global::MS.Internal.DoubleUtil.GreaterThan(num, 0.0))
				{
					global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(resizingColumnIndex);
					global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(column, num, retainAuto);
					horizontalChange -= num;
				}
			}
			return horizontalChange;
		}

		// Token: 0x06000860 RID: 2144 RVA: 0x00026130 File Offset: 0x00024330
		private void RecomputeColumnWidthsOnColumnNegativeResize(double horizontalChange, int resizingColumnIndex, bool retainAuto)
		{
			double perStarWidth = 0.0;
			if (this.HasVisibleStarColumnsInternal(out perStarWidth))
			{
				horizontalChange = this.RecomputeNonStarColumnWidthsOnColumnNegativeResize(horizontalChange, resizingColumnIndex, retainAuto, false);
				horizontalChange = this.RecomputeStarColumnWidthsOnColumnNegativeResize(horizontalChange, resizingColumnIndex, perStarWidth, retainAuto);
				horizontalChange = this.RecomputeNonStarColumnWidthsOnColumnNegativeResize(horizontalChange, resizingColumnIndex, retainAuto, true);
				if (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(resizingColumnIndex);
					if (!dataGridColumn.Width.IsStar)
					{
						global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(dataGridColumn, -horizontalChange, retainAuto);
						return;
					}
				}
			}
			else
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(resizingColumnIndex);
				global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(column, -horizontalChange, retainAuto);
			}
		}

		// Token: 0x06000861 RID: 2145 RVA: 0x000261BC File Offset: 0x000243BC
		private double RecomputeNonStarColumnWidthsOnColumnNegativeResize(double horizontalChange, int resizingColumnIndex, bool retainAuto, bool expandBeyondDesiredWidth)
		{
			if (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
			{
				double num = 0.0;
				bool flag = true;
				int num2 = resizingColumnIndex + 1;
				int count = base.Count;
				while (flag && num2 < count)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(num2);
					if (global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn))
					{
						global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
						double num3 = expandBeyondDesiredWidth ? dataGridColumn.MaxWidth : global::System.Math.Min(width.DesiredValue, dataGridColumn.MaxWidth);
						if (!width.IsStar && global::MS.Internal.DoubleUtil.LessThan(width.DisplayValue, num3))
						{
							double num4 = num3 - width.DisplayValue;
							if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(num + num4, horizontalChange))
							{
								num4 = horizontalChange - num;
								flag = false;
							}
							dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, width.DisplayValue + num4));
							num += num4;
						}
					}
					num2++;
				}
				if (global::MS.Internal.DoubleUtil.GreaterThan(num, 0.0))
				{
					global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(resizingColumnIndex);
					global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(column, -num, retainAuto);
					horizontalChange -= num;
				}
			}
			return horizontalChange;
		}

		// Token: 0x06000862 RID: 2146 RVA: 0x000262DC File Offset: 0x000244DC
		private double RecomputeStarColumnWidthsOnColumnNegativeResize(double horizontalChange, int resizingColumnIndex, double perStarWidth, bool retainAuto)
		{
			while (global::MS.Internal.DoubleUtil.GreaterThan(horizontalChange, 0.0))
			{
				double positiveInfinity = double.PositiveInfinity;
				double starFactorsForNegativeResize = this.GetStarFactorsForNegativeResize(resizingColumnIndex + 1, out positiveInfinity);
				if (!global::MS.Internal.DoubleUtil.GreaterThan(starFactorsForNegativeResize, 0.0))
				{
					break;
				}
				horizontalChange = this.ReallocateStarValuesForNegativeResize(resizingColumnIndex, horizontalChange, positiveInfinity, starFactorsForNegativeResize, perStarWidth, retainAuto);
				if (global::MS.Internal.DoubleUtil.AreClose(horizontalChange, 0.0))
				{
					break;
				}
			}
			return horizontalChange;
		}

		// Token: 0x06000863 RID: 2147 RVA: 0x00026344 File Offset: 0x00024544
		private double GetStarFactorsForNegativeResize(int startIndex, out double minPerStarLagRatio)
		{
			minPerStarLagRatio = double.PositiveInfinity;
			double num = 0.0;
			int i = startIndex;
			int count = base.Count;
			while (i < count)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
				if (global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn))
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (width.IsStar && !global::MS.Internal.DoubleUtil.AreClose(width.Value, 0.0) && global::MS.Internal.DoubleUtil.LessThan(width.DisplayValue, dataGridColumn.MaxWidth))
					{
						num += width.Value;
						double num2 = (dataGridColumn.MaxWidth - width.DisplayValue) / width.Value;
						if (global::MS.Internal.DoubleUtil.LessThan(num2, minPerStarLagRatio))
						{
							minPerStarLagRatio = num2;
						}
					}
				}
				i++;
			}
			return num;
		}

		// Token: 0x06000864 RID: 2148 RVA: 0x00026400 File Offset: 0x00024600
		private double ReallocateStarValuesForNegativeResize(int startIndex, double horizontalChange, double perStarLagRatio, double totalStarFactors, double perStarWidth, bool retainAuto)
		{
			double num;
			double num2;
			if (global::MS.Internal.DoubleUtil.LessThan(horizontalChange, perStarLagRatio * totalStarFactors))
			{
				num = horizontalChange / totalStarFactors;
				num2 = horizontalChange;
				horizontalChange = 0.0;
			}
			else
			{
				num = perStarLagRatio;
				num2 = num * totalStarFactors;
				horizontalChange -= num2;
			}
			int i = startIndex;
			int count = base.Count;
			while (i < count)
			{
				global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
				global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
				if (i == startIndex)
				{
					global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(dataGridColumn, -num2, retainAuto);
				}
				else if (dataGridColumn.Width.IsStar && global::Microsoft.Windows.Controls.DataGridColumnCollection.CanColumnParticipateInResize(dataGridColumn) && global::MS.Internal.DoubleUtil.LessThan(width.DisplayValue, dataGridColumn.MaxWidth))
				{
					double num3 = width.DisplayValue + width.Value * num;
					dataGridColumn.UpdateWidthForStarColumn(global::System.Math.Min(num3, dataGridColumn.MaxWidth), num3, num3 / perStarWidth);
				}
				i++;
			}
			return horizontalChange;
		}

		// Token: 0x06000865 RID: 2149 RVA: 0x000264EC File Offset: 0x000246EC
		private static void SetResizedColumnWidth(global::Microsoft.Windows.Controls.DataGridColumn column, double widthDelta, bool retainAuto)
		{
			global::Microsoft.Windows.Controls.DataGridLength width = column.Width;
			double num = global::Microsoft.Windows.Controls.DataGridHelper.CoerceToMinMax(width.DisplayValue + widthDelta, column.MinWidth, column.MaxWidth);
			if (width.IsStar)
			{
				double num2 = width.DesiredValue / width.Value;
				column.UpdateWidthForStarColumn(num, num, num / num2);
				return;
			}
			if (!width.IsAbsolute && retainAuto)
			{
				column.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, num));
				return;
			}
			column.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(num, global::Microsoft.Windows.Controls.DataGridLengthUnitType.Pixel, num, num));
		}

		// Token: 0x06000866 RID: 2150 RVA: 0x0002657D File Offset: 0x0002477D
		private double GiveAwayWidthToColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double giveAwayWidth)
		{
			return this.GiveAwayWidthToColumns(ignoredColumn, giveAwayWidth, false);
		}

		// Token: 0x06000867 RID: 2151 RVA: 0x00026588 File Offset: 0x00024788
		private double GiveAwayWidthToColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double giveAwayWidth, bool recomputeStars)
		{
			double num = giveAwayWidth;
			giveAwayWidth = this.GiveAwayWidthToScrollViewerExcess(giveAwayWidth, ignoredColumn != null);
			giveAwayWidth = this.GiveAwayWidthToNonStarColumns(ignoredColumn, giveAwayWidth);
			if (global::MS.Internal.DoubleUtil.GreaterThan(giveAwayWidth, 0.0) || recomputeStars)
			{
				double num2 = 0.0;
				double num3 = 0.0;
				bool flag = false;
				foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (width.IsStar && dataGridColumn.IsVisible)
					{
						if (dataGridColumn == ignoredColumn)
						{
							flag = true;
						}
						num2 += width.DisplayValue;
						num3 += dataGridColumn.MaxWidth;
					}
				}
				double num4 = num2;
				if (!flag)
				{
					num4 += giveAwayWidth;
				}
				else if (!global::MS.Internal.DoubleUtil.AreClose(num, giveAwayWidth))
				{
					num4 -= num - giveAwayWidth;
				}
				double num5 = this.ComputeStarColumnWidths(global::System.Math.Min(num4, num3));
				giveAwayWidth = global::System.Math.Max(num5 - num4, 0.0);
			}
			return giveAwayWidth;
		}

		// Token: 0x06000868 RID: 2152 RVA: 0x00026694 File Offset: 0x00024894
		private double GiveAwayWidthToNonStarColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double giveAwayWidth)
		{
			while (global::MS.Internal.DoubleUtil.GreaterThan(giveAwayWidth, 0.0))
			{
				int num = 0;
				double num2 = this.FindMinimumLaggingWidthOfNonStarColumns(ignoredColumn, out num);
				if (num == 0)
				{
					break;
				}
				double num3 = num2 * (double)num;
				if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(num3, giveAwayWidth))
				{
					num2 = giveAwayWidth / (double)num;
					giveAwayWidth = 0.0;
				}
				else
				{
					giveAwayWidth -= num3;
				}
				this.GiveAwayWidthToEveryNonStarColumn(ignoredColumn, num2);
			}
			return giveAwayWidth;
		}

		// Token: 0x06000869 RID: 2153 RVA: 0x000266F4 File Offset: 0x000248F4
		private double FindMinimumLaggingWidthOfNonStarColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, out int countOfParticipatingColumns)
		{
			double num = double.PositiveInfinity;
			countOfParticipatingColumns = 0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (ignoredColumn != dataGridColumn && dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (!width.IsStar)
					{
						double maxWidth = dataGridColumn.MaxWidth;
						if (global::MS.Internal.DoubleUtil.LessThan(width.DisplayValue, width.DesiredValue) && !global::MS.Internal.DoubleUtil.AreClose(width.DisplayValue, maxWidth))
						{
							countOfParticipatingColumns++;
							double num2 = global::System.Math.Min(width.DesiredValue, maxWidth) - width.DisplayValue;
							if (global::MS.Internal.DoubleUtil.LessThan(num2, num))
							{
								num = num2;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x0600086A RID: 2154 RVA: 0x000267BC File Offset: 0x000249BC
		private void GiveAwayWidthToEveryNonStarColumn(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double perColumnGiveAwayWidth)
		{
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (ignoredColumn != dataGridColumn && dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (!width.IsStar && global::MS.Internal.DoubleUtil.LessThan(width.DisplayValue, global::System.Math.Min(width.DesiredValue, dataGridColumn.MaxWidth)))
					{
						dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, width.DisplayValue + perColumnGiveAwayWidth));
					}
				}
			}
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x00026864 File Offset: 0x00024A64
		private double GiveAwayWidthToScrollViewerExcess(double giveAwayWidth, bool includedInColumnsWidth)
		{
			double viewportWidthForColumns = this.DataGridOwner.GetViewportWidthForColumns();
			double num = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn.IsVisible)
				{
					num += dataGridColumn.Width.DisplayValue;
				}
			}
			if (includedInColumnsWidth)
			{
				if (global::MS.Internal.DoubleUtil.GreaterThan(num, viewportWidthForColumns))
				{
					double val = num - viewportWidthForColumns;
					giveAwayWidth -= global::System.Math.Min(val, giveAwayWidth);
				}
			}
			else
			{
				giveAwayWidth = global::System.Math.Min(giveAwayWidth, global::System.Math.Max(0.0, viewportWidthForColumns - num));
			}
			return giveAwayWidth;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x00026914 File Offset: 0x00024B14
		private double TakeAwayUnusedSpaceOnColumnPositiveResize(double horizontalChange, int resizingColumnIndex, bool retainAuto)
		{
			double num = this.TakeAwayWidthFromUnusedSpace(false, horizontalChange);
			if (global::MS.Internal.DoubleUtil.LessThan(num, horizontalChange))
			{
				global::Microsoft.Windows.Controls.DataGridColumn column = this.ColumnFromDisplayIndex(resizingColumnIndex);
				global::Microsoft.Windows.Controls.DataGridColumnCollection.SetResizedColumnWidth(column, horizontalChange - num, retainAuto);
			}
			return num;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x00026948 File Offset: 0x00024B48
		private double TakeAwayWidthFromUnusedSpace(bool spaceAlreadyUtilized, double takeAwayWidth, double totalAvailableWidth)
		{
			double num = 0.0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (dataGridColumn.IsVisible)
				{
					num += dataGridColumn.Width.DisplayValue;
				}
			}
			if (!spaceAlreadyUtilized)
			{
				double num2 = totalAvailableWidth - num;
				if (global::MS.Internal.DoubleUtil.GreaterThan(num2, 0.0))
				{
					takeAwayWidth = global::System.Math.Max(0.0, takeAwayWidth - num2);
				}
				return takeAwayWidth;
			}
			if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(totalAvailableWidth, num))
			{
				return 0.0;
			}
			return global::System.Math.Min(num - totalAvailableWidth, takeAwayWidth);
		}

		// Token: 0x0600086E RID: 2158 RVA: 0x000269F8 File Offset: 0x00024BF8
		private double TakeAwayWidthFromUnusedSpace(bool spaceAlreadyUtilized, double takeAwayWidth)
		{
			double viewportWidthForColumns = this.DataGridOwner.GetViewportWidthForColumns();
			if (global::MS.Internal.DoubleUtil.GreaterThan(viewportWidthForColumns, 0.0))
			{
				return this.TakeAwayWidthFromUnusedSpace(spaceAlreadyUtilized, takeAwayWidth, viewportWidthForColumns);
			}
			return takeAwayWidth;
		}

		// Token: 0x0600086F RID: 2159 RVA: 0x00026A30 File Offset: 0x00024C30
		private double TakeAwayWidthFromColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double takeAwayWidth, bool widthAlreadyUtilized)
		{
			double viewportWidthForColumns = this.DataGridOwner.GetViewportWidthForColumns();
			return this.TakeAwayWidthFromColumns(ignoredColumn, takeAwayWidth, widthAlreadyUtilized, viewportWidthForColumns);
		}

		// Token: 0x06000870 RID: 2160 RVA: 0x00026A53 File Offset: 0x00024C53
		private double TakeAwayWidthFromColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double takeAwayWidth, bool widthAlreadyUtilized, double totalAvailableWidth)
		{
			takeAwayWidth = this.TakeAwayWidthFromUnusedSpace(widthAlreadyUtilized, takeAwayWidth, totalAvailableWidth);
			takeAwayWidth = this.TakeAwayWidthFromStarColumns(ignoredColumn, takeAwayWidth);
			takeAwayWidth = this.TakeAwayWidthFromNonStarColumns(ignoredColumn, takeAwayWidth);
			return takeAwayWidth;
		}

		// Token: 0x06000871 RID: 2161 RVA: 0x00026A78 File Offset: 0x00024C78
		private double TakeAwayWidthFromStarColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double takeAwayWidth)
		{
			if (global::MS.Internal.DoubleUtil.GreaterThan(takeAwayWidth, 0.0))
			{
				double num = 0.0;
				double num2 = 0.0;
				foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (width.IsStar && dataGridColumn.IsVisible)
					{
						if (dataGridColumn == ignoredColumn)
						{
							num += takeAwayWidth;
						}
						num += width.DisplayValue;
						num2 += dataGridColumn.MinWidth;
					}
				}
				double num3 = num - takeAwayWidth;
				double num4 = this.ComputeStarColumnWidths(global::System.Math.Max(num3, num2));
				takeAwayWidth = global::System.Math.Max(num4 - num3, 0.0);
			}
			return takeAwayWidth;
		}

		// Token: 0x06000872 RID: 2162 RVA: 0x00026B44 File Offset: 0x00024D44
		private double TakeAwayWidthFromNonStarColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double takeAwayWidth)
		{
			while (global::MS.Internal.DoubleUtil.GreaterThan(takeAwayWidth, 0.0))
			{
				int num = 0;
				double num2 = this.FindMinimumExcessWidthOfNonStarColumns(ignoredColumn, out num);
				if (num == 0)
				{
					break;
				}
				double num3 = num2 * (double)num;
				if (global::MS.Internal.DoubleUtil.GreaterThanOrClose(num3, takeAwayWidth))
				{
					num2 = takeAwayWidth / (double)num;
					takeAwayWidth = 0.0;
				}
				else
				{
					takeAwayWidth -= num3;
				}
				this.TakeAwayWidthFromEveryNonStarColumn(ignoredColumn, num2);
			}
			return takeAwayWidth;
		}

		// Token: 0x06000873 RID: 2163 RVA: 0x00026BA4 File Offset: 0x00024DA4
		private double FindMinimumExcessWidthOfNonStarColumns(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, out int countOfParticipatingColumns)
		{
			double num = double.PositiveInfinity;
			countOfParticipatingColumns = 0;
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (ignoredColumn != dataGridColumn && dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (!width.IsStar)
					{
						double minWidth = dataGridColumn.MinWidth;
						if (global::MS.Internal.DoubleUtil.GreaterThan(width.DisplayValue, minWidth))
						{
							countOfParticipatingColumns++;
							double num2 = width.DisplayValue - minWidth;
							if (global::MS.Internal.DoubleUtil.LessThan(num2, num))
							{
								num = num2;
							}
						}
					}
				}
			}
			return num;
		}

		// Token: 0x06000874 RID: 2164 RVA: 0x00026C48 File Offset: 0x00024E48
		private void TakeAwayWidthFromEveryNonStarColumn(global::Microsoft.Windows.Controls.DataGridColumn ignoredColumn, double perColumnTakeAwayWidth)
		{
			foreach (global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn in this)
			{
				if (ignoredColumn != dataGridColumn && dataGridColumn.IsVisible)
				{
					global::Microsoft.Windows.Controls.DataGridLength width = dataGridColumn.Width;
					if (!width.IsStar && global::MS.Internal.DoubleUtil.GreaterThan(width.DisplayValue, dataGridColumn.MinWidth))
					{
						dataGridColumn.SetWidthInternal(new global::Microsoft.Windows.Controls.DataGridLength(width.Value, width.UnitType, width.DesiredValue, width.DisplayValue - perColumnTakeAwayWidth));
					}
				}
			}
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000875 RID: 2165 RVA: 0x00026CE4 File Offset: 0x00024EE4
		// (set) Token: 0x06000876 RID: 2166 RVA: 0x00026CEC File Offset: 0x00024EEC
		internal bool RebuildRealizedColumnsBlockListForNonVirtualizedRows { get; set; }

		// Token: 0x170001FD RID: 509
		// (get) Token: 0x06000877 RID: 2167 RVA: 0x00026CF5 File Offset: 0x00024EF5
		// (set) Token: 0x06000878 RID: 2168 RVA: 0x00026D00 File Offset: 0x00024F00
		internal global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsBlockListForNonVirtualizedRows
		{
			get
			{
				return this._realizedColumnsBlockListForNonVirtualizedRows;
			}
			set
			{
				this._realizedColumnsBlockListForNonVirtualizedRows = value;
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				dataGridOwner.NotifyPropertyChanged(dataGridOwner, "RealizedColumnsBlockListForNonVirtualizedRows", default(global::System.Windows.DependencyPropertyChangedEventArgs), global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
			}
		}

		// Token: 0x170001FE RID: 510
		// (get) Token: 0x06000879 RID: 2169 RVA: 0x00026D32 File Offset: 0x00024F32
		// (set) Token: 0x0600087A RID: 2170 RVA: 0x00026D3A File Offset: 0x00024F3A
		internal global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsDisplayIndexBlockListForNonVirtualizedRows { get; set; }

		// Token: 0x170001FF RID: 511
		// (get) Token: 0x0600087B RID: 2171 RVA: 0x00026D43 File Offset: 0x00024F43
		// (set) Token: 0x0600087C RID: 2172 RVA: 0x00026D4B File Offset: 0x00024F4B
		internal bool RebuildRealizedColumnsBlockListForVirtualizedRows { get; set; }

		// Token: 0x17000200 RID: 512
		// (get) Token: 0x0600087D RID: 2173 RVA: 0x00026D54 File Offset: 0x00024F54
		// (set) Token: 0x0600087E RID: 2174 RVA: 0x00026D5C File Offset: 0x00024F5C
		internal global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsBlockListForVirtualizedRows
		{
			get
			{
				return this._realizedColumnsBlockListForVirtualizedRows;
			}
			set
			{
				this._realizedColumnsBlockListForVirtualizedRows = value;
				global::Microsoft.Windows.Controls.DataGrid dataGridOwner = this.DataGridOwner;
				dataGridOwner.NotifyPropertyChanged(dataGridOwner, "RealizedColumnsBlockListForVirtualizedRows", default(global::System.Windows.DependencyPropertyChangedEventArgs), global::Microsoft.Windows.Controls.NotificationTarget.CellsPresenter | global::Microsoft.Windows.Controls.NotificationTarget.ColumnHeadersPresenter);
			}
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x0600087F RID: 2175 RVA: 0x00026D8E File Offset: 0x00024F8E
		// (set) Token: 0x06000880 RID: 2176 RVA: 0x00026D96 File Offset: 0x00024F96
		internal global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> RealizedColumnsDisplayIndexBlockListForVirtualizedRows { get; set; }

		// Token: 0x06000881 RID: 2177 RVA: 0x00026D9F File Offset: 0x00024F9F
		internal void InvalidateColumnRealization(bool invalidateForNonVirtualizedRows)
		{
			this.RebuildRealizedColumnsBlockListForVirtualizedRows = true;
			if (invalidateForNonVirtualizedRows)
			{
				this.RebuildRealizedColumnsBlockListForNonVirtualizedRows = true;
			}
		}

		// Token: 0x17000202 RID: 514
		// (get) Token: 0x06000882 RID: 2178 RVA: 0x00026DB4 File Offset: 0x00024FB4
		internal int FirstVisibleDisplayIndex
		{
			get
			{
				int i = 0;
				int count = base.Count;
				while (i < count)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
					if (dataGridColumn.IsVisible)
					{
						return i;
					}
					i++;
				}
				return -1;
			}
		}

		// Token: 0x17000203 RID: 515
		// (get) Token: 0x06000883 RID: 2179 RVA: 0x00026DE8 File Offset: 0x00024FE8
		internal int LastVisibleDisplayIndex
		{
			get
			{
				for (int i = base.Count - 1; i >= 0; i--)
				{
					global::Microsoft.Windows.Controls.DataGridColumn dataGridColumn = this.ColumnFromDisplayIndex(i);
					if (dataGridColumn.IsVisible)
					{
						return i;
					}
				}
				return -1;
			}
		}

		// Token: 0x17000204 RID: 516
		// (get) Token: 0x06000884 RID: 2180 RVA: 0x00026E1B File Offset: 0x0002501B
		// (set) Token: 0x06000885 RID: 2181 RVA: 0x00026E23 File Offset: 0x00025023
		internal bool RefreshAutoWidthColumns { get; set; }

		// Token: 0x04000291 RID: 657
		private global::Microsoft.Windows.Controls.DataGrid _dataGridOwner;

		// Token: 0x04000292 RID: 658
		private bool _isUpdatingDisplayIndex;

		// Token: 0x04000293 RID: 659
		private global::System.Collections.Generic.List<int> _displayIndexMap;

		// Token: 0x04000294 RID: 660
		private bool _displayIndexMapInitialized;

		// Token: 0x04000295 RID: 661
		private bool _isClearingDisplayIndex;

		// Token: 0x04000296 RID: 662
		private bool _columnWidthsComputationPending;

		// Token: 0x04000297 RID: 663
		private global::System.Collections.Generic.Dictionary<global::Microsoft.Windows.Controls.DataGridColumn, global::Microsoft.Windows.Controls.DataGridLength> _originalWidthsForResize;

		// Token: 0x04000298 RID: 664
		private double? _averageColumnWidth = null;

		// Token: 0x04000299 RID: 665
		private global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> _realizedColumnsBlockListForNonVirtualizedRows;

		// Token: 0x0400029A RID: 666
		private global::System.Collections.Generic.List<global::Microsoft.Windows.Controls.RealizedColumnsBlock> _realizedColumnsBlockListForVirtualizedRows;
	}
}
