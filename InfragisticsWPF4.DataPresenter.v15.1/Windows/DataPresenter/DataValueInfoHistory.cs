using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000A2 RID: 162
	internal class DataValueInfoHistory : global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x060007FB RID: 2043 RVA: 0x000224DC File Offset: 0x000206DC
		private DataValueInfoHistory(int capacity)
		{
			this._list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo>(capacity);
			this._capacity = capacity;
		}

		// Token: 0x17000205 RID: 517
		// (get) Token: 0x060007FC RID: 2044 RVA: 0x000224FE File Offset: 0x000206FE
		internal int Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x060007FD RID: 2045 RVA: 0x00022506 File Offset: 0x00020706
		internal int Head
		{
			get
			{
				if (this._totalItemsAdded <= this.Capacity)
				{
					return 0;
				}
				if (this._tail == this.Capacity - 1)
				{
					return 0;
				}
				return this._tail + 1;
			}
		}

		// Token: 0x17000207 RID: 519
		// (get) Token: 0x060007FE RID: 2046 RVA: 0x00022532 File Offset: 0x00020732
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfoHistory> HistoryCache
		{
			get
			{
				if (global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache == null)
				{
					global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfoHistory>(100);
				}
				return global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache;
			}
		}

		// Token: 0x060007FF RID: 2047 RVA: 0x0002254C File Offset: 0x0002074C
		internal static global::Infragistics.Windows.DataPresenter.DataValueInfoHistory Create(int capacity)
		{
			int num = global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.HistoryCache.Count - 1;
			global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistory;
			if (num >= 0)
			{
				dataValueInfoHistory = global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache[num];
				global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache.RemoveAt(num);
				dataValueInfoHistory._capacity = capacity;
			}
			else
			{
				dataValueInfoHistory = new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory(capacity);
			}
			return dataValueInfoHistory;
		}

		// Token: 0x06000800 RID: 2048 RVA: 0x00022594 File Offset: 0x00020794
		internal static global::Infragistics.Windows.DataPresenter.DataValueInfoHistory GetResizedInstance(global::Infragistics.Windows.DataPresenter.DataValueInfoHistory oldDataValueInfoHistory, int newCapacity)
		{
			if (oldDataValueInfoHistory == null)
			{
				throw new global::System.ArgumentNullException("oldDataValueInfoHistory");
			}
			if (newCapacity < 1)
			{
				throw new global::System.ArgumentOutOfRangeException("newCapacity");
			}
			if (newCapacity == oldDataValueInfoHistory.Capacity)
			{
				return oldDataValueInfoHistory;
			}
			global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistory = new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory(newCapacity);
			int num = 0;
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList(newCapacity);
			foreach (global::Infragistics.Windows.DataPresenter.DataValueInfo value in ((global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataValueInfo>)oldDataValueInfoHistory))
			{
				arrayList.Add(value);
				num++;
				if (num >= newCapacity)
				{
					break;
				}
			}
			arrayList.TrimToSize();
			for (int i = arrayList.Count - 1; i > -1; i--)
			{
				global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo = arrayList[i] as global::Infragistics.Windows.DataPresenter.DataValueInfo;
				dataValueInfoHistory.AddEntry(dataValueInfo.Value, dataValueInfo.TimeStamp, dataValueInfo.Tag);
			}
			return dataValueInfoHistory;
		}

		// Token: 0x06000801 RID: 2049 RVA: 0x0002266C File Offset: 0x0002086C
		internal static void Release(global::Infragistics.Windows.DataPresenter.DataValueInfoHistory history)
		{
			if (history == null || global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.HistoryCache.Count > 300)
			{
				return;
			}
			int count = history._list.Count;
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.DataPresenter.DataValueInfo.Release(history._list[i]);
			}
			history._list.Clear();
			history._tail = -1;
			history._totalItemsAdded = 0;
			global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache.Add(history);
		}

		// Token: 0x06000802 RID: 2050 RVA: 0x000226DC File Offset: 0x000208DC
		internal void AddEntry(object value, global::System.DateTime timeStamp, object tag)
		{
			if (this._totalItemsAdded + 1 <= this.Capacity)
			{
				if (!this.GetIsValueChanged(value, this._tail))
				{
					return;
				}
				this._list.Add(global::Infragistics.Windows.DataPresenter.DataValueInfo.Create(value, timeStamp, tag));
				this._tail = this.GetBumpedTailValue();
			}
			else
			{
				global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo = this._list[this._tail];
				int bumpedTailValue = this.GetBumpedTailValue();
				global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo2 = this._list[bumpedTailValue];
				if (dataValueInfo2 != null)
				{
					if ((dataValueInfo.Value != null || value == null) && (dataValueInfo.Value == null || dataValueInfo.Value.Equals(value)))
					{
						return;
					}
					dataValueInfo2.SetValue(value);
					dataValueInfo2.SetTimeStamp(timeStamp);
					dataValueInfo2.Tag = tag;
					this._tail = bumpedTailValue;
				}
				else
				{
					this._list[bumpedTailValue] = global::Infragistics.Windows.DataPresenter.DataValueInfo.Create(value, timeStamp, tag);
					this._tail = bumpedTailValue;
				}
			}
			this._totalItemsAdded++;
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
			this.RaisePropertyChanged("Count");
			this.RaisePropertyChanged("Item[]");
		}

		// Token: 0x06000803 RID: 2051 RVA: 0x000227F0 File Offset: 0x000209F0
		internal void ClearCacheEntries(bool keepNewestEntry)
		{
			int count = this._list.Count;
			if (!keepNewestEntry)
			{
				for (int i = 0; i < count; i++)
				{
					global::Infragistics.Windows.DataPresenter.DataValueInfo.Release(this._list[i]);
				}
				this._list.Clear();
				this._tail = -1;
				this._totalItemsAdded = 0;
			}
			else if (this._totalItemsAdded > 1)
			{
				global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo = ((global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>)this)[0];
				if (dataValueInfo != null)
				{
					for (int j = 0; j < count; j++)
					{
						global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo2 = this._list[j];
						if (dataValueInfo2 != dataValueInfo)
						{
							global::Infragistics.Windows.DataPresenter.DataValueInfo.Release(dataValueInfo2);
						}
					}
					this._list.Clear();
					this._list.Add(dataValueInfo);
					this._tail = 0;
					this._totalItemsAdded = 1;
				}
			}
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
			this.RaisePropertyChanged("Count");
			this.RaisePropertyChanged("Item[]");
		}

		// Token: 0x06000804 RID: 2052 RVA: 0x000228D3 File Offset: 0x00020AD3
		private int GetBumpedTailValue()
		{
			if (this._tail + 1 >= this.Capacity)
			{
				return 0;
			}
			return this._tail + 1;
		}

		// Token: 0x06000805 RID: 2053 RVA: 0x000228F0 File Offset: 0x00020AF0
		private bool GetIsValueChanged(object newValue, int oldValueIndex)
		{
			if (oldValueIndex < 0)
			{
				return true;
			}
			global::Infragistics.Windows.DataPresenter.DataValueInfo dataValueInfo = this._list[oldValueIndex];
			if (dataValueInfo == null)
			{
				return true;
			}
			if (dataValueInfo.Value == null)
			{
				return newValue != null;
			}
			return !dataValueInfo.Value.Equals(newValue);
		}

		// Token: 0x06000806 RID: 2054 RVA: 0x00022934 File Offset: 0x00020B34
		private int GetLogicalIndexFromPhysicalIndex(int physicalIndex)
		{
			if (physicalIndex < 0 || physicalIndex > this._totalItemsAdded - 1)
			{
				return -1;
			}
			int i = 0;
			int num = this._tail;
			while (i <= this.Capacity)
			{
				if (num == physicalIndex)
				{
					return i;
				}
				i++;
				num--;
				if (num < 0)
				{
					num = this.Capacity - 1;
				}
			}
			return -1;
		}

		// Token: 0x06000807 RID: 2055 RVA: 0x00022984 File Offset: 0x00020B84
		private int GetPhysicalIndexFromLogicalIndex(int logicalIndex)
		{
			if (logicalIndex < 0 || logicalIndex > this._totalItemsAdded - 1)
			{
				return -1;
			}
			int i = 0;
			int num = this._tail;
			while (i <= this.Capacity)
			{
				if (i == logicalIndex)
				{
					return num;
				}
				i++;
				num--;
				if (num < 0)
				{
					num = this.Capacity - 1;
				}
			}
			return -1;
		}

		// Token: 0x06000808 RID: 2056 RVA: 0x000229D2 File Offset: 0x00020BD2
		private void RaisePropertyChanged(string propertyName)
		{
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x06000809 RID: 2057 RVA: 0x000229F0 File Offset: 0x00020BF0
		// (remove) Token: 0x0600080A RID: 2058 RVA: 0x00022A28 File Offset: 0x00020C28
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x0600080B RID: 2059 RVA: 0x00022A5D File Offset: 0x00020C5D
		int global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.IndexOf(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			return ((global::System.Collections.IList)this).IndexOf(item);
		}

		// Token: 0x0600080C RID: 2060 RVA: 0x00022A66 File Offset: 0x00020C66
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Insert(int index, global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600080D RID: 2061 RVA: 0x00022A6D File Offset: 0x00020C6D
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000208 RID: 520
		global::Infragistics.Windows.DataPresenter.DataValueInfo global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.this[int index]
		{
			get
			{
				return ((global::System.Collections.IList)this)[index] as global::Infragistics.Windows.DataPresenter.DataValueInfo;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000810 RID: 2064 RVA: 0x00022A89 File Offset: 0x00020C89
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Add(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000811 RID: 2065 RVA: 0x00022A90 File Offset: 0x00020C90
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000812 RID: 2066 RVA: 0x00022A97 File Offset: 0x00020C97
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Contains(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			return ((global::System.Collections.IList)this).Contains(item);
		}

		// Token: 0x06000813 RID: 2067 RVA: 0x00022AA0 File Offset: 0x00020CA0
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.CopyTo(global::Infragistics.Windows.DataPresenter.DataValueInfo[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000209 RID: 521
		// (get) Token: 0x06000814 RID: 2068 RVA: 0x00022AA7 File Offset: 0x00020CA7
		int global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Count
		{
			get
			{
				return ((global::System.Collections.ICollection)this).Count;
			}
		}

		// Token: 0x1700020A RID: 522
		// (get) Token: 0x06000815 RID: 2069 RVA: 0x00022AAF File Offset: 0x00020CAF
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000816 RID: 2070 RVA: 0x00022AB2 File Offset: 0x00020CB2
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Remove(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000817 RID: 2071 RVA: 0x00022AB9 File Offset: 0x00020CB9
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataValueInfo> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataValueInfo>.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.DataValueInfoEnumerator(this);
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00022AC1 File Offset: 0x00020CC1
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.DataValueInfoEnumerator(this);
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00022AC9 File Offset: 0x00020CC9
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00022AD0 File Offset: 0x00020CD0
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00022AD7 File Offset: 0x00020CD7
		bool global::System.Collections.IList.Contains(object value)
		{
			return this._list.Contains((global::Infragistics.Windows.DataPresenter.DataValueInfo)value);
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00022AEC File Offset: 0x00020CEC
		int global::System.Collections.IList.IndexOf(object value)
		{
			int num = this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.DataValueInfo);
			if (num == -1)
			{
				return -1;
			}
			return this.GetLogicalIndexFromPhysicalIndex(num);
		}

		// Token: 0x0600081D RID: 2077 RVA: 0x00022B18 File Offset: 0x00020D18
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700020B RID: 523
		// (get) Token: 0x0600081E RID: 2078 RVA: 0x00022B1F File Offset: 0x00020D1F
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700020C RID: 524
		// (get) Token: 0x0600081F RID: 2079 RVA: 0x00022B22 File Offset: 0x00020D22
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000820 RID: 2080 RVA: 0x00022B25 File Offset: 0x00020D25
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000821 RID: 2081 RVA: 0x00022B2C File Offset: 0x00020D2C
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700020D RID: 525
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				int physicalIndexFromLogicalIndex = this.GetPhysicalIndexFromLogicalIndex(index);
				if (physicalIndexFromLogicalIndex == -1)
				{
					return null;
				}
				return this._list[physicalIndexFromLogicalIndex];
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06000824 RID: 2084 RVA: 0x00022B62 File Offset: 0x00020D62
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000825 RID: 2085 RVA: 0x00022B69 File Offset: 0x00020D69
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return global::System.Math.Min(this.Capacity, this._totalItemsAdded);
			}
		}

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000826 RID: 2086 RVA: 0x00022B7C File Offset: 0x00020D7C
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).IsSynchronized;
			}
		}

		// Token: 0x17000210 RID: 528
		// (get) Token: 0x06000827 RID: 2087 RVA: 0x00022B89 File Offset: 0x00020D89
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).SyncRoot;
			}
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x06000828 RID: 2088 RVA: 0x00022B98 File Offset: 0x00020D98
		// (remove) Token: 0x06000829 RID: 2089 RVA: 0x00022BD0 File Offset: 0x00020DD0
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x0400034F RID: 847
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo> _list;

		// Token: 0x04000350 RID: 848
		private int _totalItemsAdded;

		// Token: 0x04000351 RID: 849
		private int _tail = -1;

		// Token: 0x04000352 RID: 850
		private int _capacity;

		// Token: 0x04000353 RID: 851
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfoHistory> _HistoryCache;

		// Token: 0x020000A3 RID: 163
		private class DataValueInfoEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600082A RID: 2090 RVA: 0x00022C05 File Offset: 0x00020E05
			internal DataValueInfoEnumerator(global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistory)
			{
				this._dataValueInfoHistory = dataValueInfoHistory;
			}

			// Token: 0x0600082B RID: 2091 RVA: 0x00022C1B File Offset: 0x00020E1B
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x0600082C RID: 2092 RVA: 0x00022C24 File Offset: 0x00020E24
			public bool MoveNext()
			{
				int num = global::System.Math.Min(this._dataValueInfoHistory.Capacity, this._dataValueInfoHistory._totalItemsAdded);
				if (this._totalMoveNextsSoFar < num)
				{
					if (this._currentIndex == -1)
					{
						this._currentIndex = 0;
					}
					else
					{
						this._currentIndex++;
					}
					if (this._currentIndex < num)
					{
						this._currentDataValueInfo = (((global::System.Collections.IList)this._dataValueInfoHistory)[this._currentIndex] as global::Infragistics.Windows.DataPresenter.DataValueInfo);
						return true;
					}
				}
				this._currentIndex = num;
				this._currentDataValueInfo = null;
				return false;
			}

			// Token: 0x0600082D RID: 2093 RVA: 0x00022CAC File Offset: 0x00020EAC
			public void Reset()
			{
				this._currentDataValueInfo = null;
				this._currentIndex = -1;
				this._totalMoveNextsSoFar = 0;
			}

			// Token: 0x17000211 RID: 529
			// (get) Token: 0x0600082E RID: 2094 RVA: 0x00022CC3 File Offset: 0x00020EC3
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x17000212 RID: 530
			// (get) Token: 0x0600082F RID: 2095 RVA: 0x00022CCB File Offset: 0x00020ECB
			public global::Infragistics.Windows.DataPresenter.DataValueInfo Current
			{
				get
				{
					if (this._currentDataValueInfo != null)
					{
						return this._currentDataValueInfo;
					}
					if (this._currentIndex == -1)
					{
						throw new global::System.InvalidOperationException("Enumerator has not been started");
					}
					throw new global::System.InvalidOperationException("Enumerator has finished");
				}
			}

			// Token: 0x04000356 RID: 854
			private global::Infragistics.Windows.DataPresenter.DataValueInfoHistory _dataValueInfoHistory;

			// Token: 0x04000357 RID: 855
			private global::Infragistics.Windows.DataPresenter.DataValueInfo _currentDataValueInfo;

			// Token: 0x04000358 RID: 856
			private int _currentIndex = -1;

			// Token: 0x04000359 RID: 857
			private int _totalMoveNextsSoFar;
		}
	}
}
