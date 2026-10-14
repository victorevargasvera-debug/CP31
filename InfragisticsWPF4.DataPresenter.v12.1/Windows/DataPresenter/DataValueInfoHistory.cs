using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200009C RID: 156
	internal class DataValueInfoHistory : global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06000772 RID: 1906 RVA: 0x0001F4F8 File Offset: 0x0001D6F8
		private DataValueInfoHistory(int capacity)
		{
			this._list = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo>(capacity);
			this._capacity = capacity;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000773 RID: 1907 RVA: 0x0001F51A File Offset: 0x0001D71A
		internal int Capacity
		{
			get
			{
				return this._capacity;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000774 RID: 1908 RVA: 0x0001F522 File Offset: 0x0001D722
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

		// Token: 0x06000775 RID: 1909 RVA: 0x0001F550 File Offset: 0x0001D750
		internal static global::Infragistics.Windows.DataPresenter.DataValueInfoHistory Create(int capacity)
		{
			int num = global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache.Count - 1;
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

		// Token: 0x06000776 RID: 1910 RVA: 0x0001F598 File Offset: 0x0001D798
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

		// Token: 0x06000777 RID: 1911 RVA: 0x0001F670 File Offset: 0x0001D870
		internal static void Release(global::Infragistics.Windows.DataPresenter.DataValueInfoHistory history)
		{
			if (history == null || global::Infragistics.Windows.DataPresenter.DataValueInfoHistory._HistoryCache.Count > 300)
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

		// Token: 0x06000778 RID: 1912 RVA: 0x0001F6E0 File Offset: 0x0001D8E0
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
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0001F7E0 File Offset: 0x0001D9E0
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
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0001F8AD File Offset: 0x0001DAAD
		private int GetBumpedTailValue()
		{
			if (this._tail + 1 >= this.Capacity)
			{
				return 0;
			}
			return this._tail + 1;
		}

		// Token: 0x0600077B RID: 1915 RVA: 0x0001F8CC File Offset: 0x0001DACC
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

		// Token: 0x0600077C RID: 1916 RVA: 0x0001F910 File Offset: 0x0001DB10
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

		// Token: 0x0600077D RID: 1917 RVA: 0x0001F960 File Offset: 0x0001DB60
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

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600077E RID: 1918 RVA: 0x0001F9B0 File Offset: 0x0001DBB0
		// (remove) Token: 0x0600077F RID: 1919 RVA: 0x0001F9E8 File Offset: 0x0001DBE8
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x06000780 RID: 1920 RVA: 0x0001FA1D File Offset: 0x0001DC1D
		int global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.IndexOf(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			return ((global::System.Collections.IList)this).IndexOf(item);
		}

		// Token: 0x06000781 RID: 1921 RVA: 0x0001FA26 File Offset: 0x0001DC26
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Insert(int index, global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000782 RID: 1922 RVA: 0x0001FA2D File Offset: 0x0001DC2D
		void global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.DataValueInfo>.RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E2 RID: 482
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

		// Token: 0x06000785 RID: 1925 RVA: 0x0001FA49 File Offset: 0x0001DC49
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Add(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000786 RID: 1926 RVA: 0x0001FA50 File Offset: 0x0001DC50
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000787 RID: 1927 RVA: 0x0001FA57 File Offset: 0x0001DC57
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Contains(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			return ((global::System.Collections.IList)this).Contains(item);
		}

		// Token: 0x06000788 RID: 1928 RVA: 0x0001FA60 File Offset: 0x0001DC60
		void global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.CopyTo(global::Infragistics.Windows.DataPresenter.DataValueInfo[] array, int arrayIndex)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000789 RID: 1929 RVA: 0x0001FA67 File Offset: 0x0001DC67
		int global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Count
		{
			get
			{
				return ((global::System.Collections.ICollection)this).Count;
			}
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x0600078A RID: 1930 RVA: 0x0001FA6F File Offset: 0x0001DC6F
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x0600078B RID: 1931 RVA: 0x0001FA72 File Offset: 0x0001DC72
		bool global::System.Collections.Generic.ICollection<global::Infragistics.Windows.DataPresenter.DataValueInfo>.Remove(global::Infragistics.Windows.DataPresenter.DataValueInfo item)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600078C RID: 1932 RVA: 0x0001FA79 File Offset: 0x0001DC79
		global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataValueInfo> global::System.Collections.Generic.IEnumerable<global::Infragistics.Windows.DataPresenter.DataValueInfo>.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.DataValueInfoEnumerator(this);
		}

		// Token: 0x0600078D RID: 1933 RVA: 0x0001FA81 File Offset: 0x0001DC81
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return new global::Infragistics.Windows.DataPresenter.DataValueInfoHistory.DataValueInfoEnumerator(this);
		}

		// Token: 0x0600078E RID: 1934 RVA: 0x0001FA89 File Offset: 0x0001DC89
		int global::System.Collections.IList.Add(object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600078F RID: 1935 RVA: 0x0001FA90 File Offset: 0x0001DC90
		void global::System.Collections.IList.Clear()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000790 RID: 1936 RVA: 0x0001FA97 File Offset: 0x0001DC97
		bool global::System.Collections.IList.Contains(object value)
		{
			return this._list.Contains((global::Infragistics.Windows.DataPresenter.DataValueInfo)value);
		}

		// Token: 0x06000791 RID: 1937 RVA: 0x0001FAAC File Offset: 0x0001DCAC
		int global::System.Collections.IList.IndexOf(object value)
		{
			int num = this._list.IndexOf(value as global::Infragistics.Windows.DataPresenter.DataValueInfo);
			if (num == -1)
			{
				return -1;
			}
			return this.GetLogicalIndexFromPhysicalIndex(num);
		}

		// Token: 0x06000792 RID: 1938 RVA: 0x0001FAD8 File Offset: 0x0001DCD8
		void global::System.Collections.IList.Insert(int index, object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000793 RID: 1939 RVA: 0x0001FADF File Offset: 0x0001DCDF
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000794 RID: 1940 RVA: 0x0001FAE2 File Offset: 0x0001DCE2
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000795 RID: 1941 RVA: 0x0001FAE5 File Offset: 0x0001DCE5
		void global::System.Collections.IList.Remove(object value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000796 RID: 1942 RVA: 0x0001FAEC File Offset: 0x0001DCEC
		void global::System.Collections.IList.RemoveAt(int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E7 RID: 487
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

		// Token: 0x06000799 RID: 1945 RVA: 0x0001FB22 File Offset: 0x0001DD22
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x170001E8 RID: 488
		// (get) Token: 0x0600079A RID: 1946 RVA: 0x0001FB29 File Offset: 0x0001DD29
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return global::System.Math.Min(this.Capacity, this._totalItemsAdded);
			}
		}

		// Token: 0x170001E9 RID: 489
		// (get) Token: 0x0600079B RID: 1947 RVA: 0x0001FB3C File Offset: 0x0001DD3C
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).IsSynchronized;
			}
		}

		// Token: 0x170001EA RID: 490
		// (get) Token: 0x0600079C RID: 1948 RVA: 0x0001FB49 File Offset: 0x0001DD49
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return ((global::System.Collections.ICollection)this._list).SyncRoot;
			}
		}

		// Token: 0x04000309 RID: 777
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfo> _list;

		// Token: 0x0400030A RID: 778
		private int _totalItemsAdded;

		// Token: 0x0400030B RID: 779
		private int _tail = -1;

		// Token: 0x0400030C RID: 780
		private int _capacity;

		// Token: 0x0400030D RID: 781
		[global::System.ThreadStatic]
		private static global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfoHistory> _HistoryCache = new global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.DataValueInfoHistory>(100);

		// Token: 0x0200009D RID: 157
		private class DataValueInfoEnumerator : global::System.Collections.Generic.IEnumerator<global::Infragistics.Windows.DataPresenter.DataValueInfo>, global::System.IDisposable, global::System.Collections.IEnumerator
		{
			// Token: 0x0600079D RID: 1949 RVA: 0x0001FB56 File Offset: 0x0001DD56
			internal DataValueInfoEnumerator(global::Infragistics.Windows.DataPresenter.DataValueInfoHistory dataValueInfoHistory)
			{
				this._dataValueInfoHistory = dataValueInfoHistory;
			}

			// Token: 0x0600079E RID: 1950 RVA: 0x0001FB6C File Offset: 0x0001DD6C
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x0600079F RID: 1951 RVA: 0x0001FB74 File Offset: 0x0001DD74
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

			// Token: 0x060007A0 RID: 1952 RVA: 0x0001FBFC File Offset: 0x0001DDFC
			public void Reset()
			{
				this._currentDataValueInfo = null;
				this._currentIndex = -1;
				this._totalMoveNextsSoFar = 0;
			}

			// Token: 0x170001EB RID: 491
			// (get) Token: 0x060007A1 RID: 1953 RVA: 0x0001FC13 File Offset: 0x0001DE13
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					return this.Current;
				}
			}

			// Token: 0x170001EC RID: 492
			// (get) Token: 0x060007A2 RID: 1954 RVA: 0x0001FC1B File Offset: 0x0001DE1B
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

			// Token: 0x0400030F RID: 783
			private global::Infragistics.Windows.DataPresenter.DataValueInfoHistory _dataValueInfoHistory;

			// Token: 0x04000310 RID: 784
			private global::Infragistics.Windows.DataPresenter.DataValueInfo _currentDataValueInfo;

			// Token: 0x04000311 RID: 785
			private int _currentIndex = -1;

			// Token: 0x04000312 RID: 786
			private int _totalMoveNextsSoFar;
		}
	}
}
