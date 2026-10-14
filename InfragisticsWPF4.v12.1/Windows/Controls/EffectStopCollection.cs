using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics.Windows.Controls
{
	// Token: 0x0200022D RID: 557
	public abstract class EffectStopCollection<T> : global::System.ComponentModel.INotifyPropertyChanged, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable where T : global::Infragistics.Windows.Controls.EffectStop
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x0005AF36 File Offset: 0x00059136
		public void ReplaceAll(global::Infragistics.Windows.Controls.EffectStopCollection<T> newEffectStopCollection)
		{
			this._list.Clear();
			this._list.AddRange(newEffectStopCollection);
			this.BumpListVersion(true);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0005AF56 File Offset: 0x00059156
		public void ResumeChangeNotifications(bool fullReset)
		{
			if (this._changeNotificationsSuspended)
			{
				this._changeNotificationsSuspended = false;
				if (this._changesMadeWhileNotificationsSuspended)
				{
					this._listVersion++;
					this.RaiseChangeEvents(fullReset);
					this._changesMadeWhileNotificationsSuspended = false;
				}
			}
		}

		// Token: 0x06001736 RID: 5942 RVA: 0x0005AF8B File Offset: 0x0005918B
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return this._list.Count > 0;
		}

		// Token: 0x06001737 RID: 5943 RVA: 0x0005AF9B File Offset: 0x0005919B
		public void SuspendChangeNotifications()
		{
			this._changeNotificationsSuspended = true;
			this._changesMadeWhileNotificationsSuspended = true;
		}

		// Token: 0x06001738 RID: 5944 RVA: 0x0005AFAB File Offset: 0x000591AB
		private void BumpListVersion(bool fullReset)
		{
			if (this._changeNotificationsSuspended)
			{
				this._changesMadeWhileNotificationsSuspended = true;
				return;
			}
			this.RaiseChangeEvents(fullReset);
			this._listVersion++;
		}

		// Token: 0x06001739 RID: 5945 RVA: 0x0005AFD4 File Offset: 0x000591D4
		private double GetStopValueForTopOfRange()
		{
			this.VerifyIsSorted();
			if (this._stopValueForTopOfRangeVersion != this._listVersion)
			{
				if (this._sortedList.Count == 0)
				{
					this._stopValueForTopOfRange = 0.0;
				}
				else
				{
					T t = this._sortedList[this._sortedList.Count - 1];
					this._stopValueForTopOfRange = t.Value;
				}
				this._stopValueForTopOfRangeVersion = this._listVersion;
			}
			return this._stopValueForTopOfRange;
		}

		// Token: 0x0600173A RID: 5946 RVA: 0x0005B054 File Offset: 0x00059254
		private double GetStopValueForBottomOfRange()
		{
			this.VerifyIsSorted();
			if (this._stopValueForBottomOfRangeVersion != this._listVersion)
			{
				if (this._sortedList.Count == 0)
				{
					this._stopValueForBottomOfRange = 0.0;
				}
				else
				{
					T t = this._sortedList[0];
					this._stopValueForBottomOfRange = t.Value;
				}
				this._stopValueForBottomOfRangeVersion = this._listVersion;
			}
			return this._stopValueForBottomOfRange;
		}

		// Token: 0x0600173B RID: 5947 RVA: 0x0005B0C5 File Offset: 0x000592C5
		private void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction action, object item, int index)
		{
			if (this._collectionChangedHandler != null)
			{
				if (item is global::System.Collections.IList)
				{
					this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, (global::System.Collections.IList)item, index));
					return;
				}
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action, item, index));
			}
		}

		// Token: 0x0600173C RID: 5948 RVA: 0x0005B105 File Offset: 0x00059305
		private void OnEffectStopPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged("Item[]");
		}

		// Token: 0x0600173D RID: 5949 RVA: 0x0005B112 File Offset: 0x00059312
		private void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x0600173E RID: 5950 RVA: 0x0005B12E File Offset: 0x0005932E
		internal void RaiseChangeEvents(bool fullReset)
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			if (fullReset)
			{
				this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x0005B154 File Offset: 0x00059354
		private void VerifyIsSorted()
		{
			if (this._listSortVersion != this._listVersion)
			{
				int count = this._list.Count;
				this._sortedList = new global::System.Collections.Generic.List<T>(count);
				for (int i = 0; i < count; i++)
				{
					this._sortedList.Add(this._list[i]);
				}
				this._sortedList.Sort();
				this._listSortVersion = this._listVersion;
			}
		}

		// Token: 0x06001740 RID: 5952 RVA: 0x0005B1C4 File Offset: 0x000593C4
		internal double GetStopValueFromOffset(double offset)
		{
			this.VerifyIsSorted();
			global::System.Collections.Generic.List<T> sortedList = this._sortedList;
			int count = sortedList.Count;
			global::Infragistics.Windows.Controls.EffectStop effectStop = sortedList[0];
			global::Infragistics.Windows.Controls.EffectStop effectStop2 = sortedList[count - 1];
			if (offset <= effectStop.Offset)
			{
				return effectStop.Value;
			}
			if (offset >= effectStop2.Offset)
			{
				return effectStop2.Value;
			}
			for (int i = 0; i < count; i++)
			{
				global::Infragistics.Windows.Controls.EffectStop effectStop3 = sortedList[i];
				if (offset <= effectStop3.Offset)
				{
					global::Infragistics.Windows.Controls.EffectStop effectStop4 = sortedList[i - 1];
					double offset2 = effectStop4.Offset;
					double offset3 = effectStop3.Offset;
					double num = (offset - offset2) / (offset3 - offset2);
					double value = effectStop4.Value;
					double value2 = effectStop3.Value;
					return value + num * (value2 - value);
				}
			}
			return effectStop2.Value;
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x0005B2A0 File Offset: 0x000594A0
		internal double GetStopValueFromRange(double rangeLowValue, double rangeHighValue, double valueToEvaluate)
		{
			if (rangeHighValue <= rangeLowValue)
			{
				return 0.0;
			}
			if (valueToEvaluate < rangeLowValue)
			{
				valueToEvaluate = rangeLowValue;
			}
			else if (valueToEvaluate > rangeHighValue)
			{
				valueToEvaluate = rangeHighValue;
			}
			if (valueToEvaluate == rangeLowValue)
			{
				return this.GetStopValueForBottomOfRange();
			}
			if (valueToEvaluate == rangeHighValue)
			{
				return this.GetStopValueForTopOfRange();
			}
			global::System.Collections.Generic.List<T> list = this._list;
			int count = list.Count;
			if (count < 1)
			{
				return 0.0;
			}
			if (count == 1)
			{
				T t = list[0];
				return t.Value;
			}
			return this.GetStopValueFromOffset((valueToEvaluate - rangeLowValue) / (rangeHighValue - rangeLowValue));
		}

		// Token: 0x14000035 RID: 53
		// (add) Token: 0x06001742 RID: 5954 RVA: 0x0005B324 File Offset: 0x00059524
		// (remove) Token: 0x06001743 RID: 5955 RVA: 0x0005B33D File Offset: 0x0005953D
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._collectionChangedHandler = (global::System.Delegate.Combine(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._collectionChangedHandler = (global::System.Delegate.Remove(this._collectionChangedHandler, value) as global::System.Collections.Specialized.NotifyCollectionChangedEventHandler);
			}
		}

		// Token: 0x14000036 RID: 54
		// (add) Token: 0x06001744 RID: 5956 RVA: 0x0005B356 File Offset: 0x00059556
		// (remove) Token: 0x06001745 RID: 5957 RVA: 0x0005B36F File Offset: 0x0005956F
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged
		{
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			add
			{
				this._propertyChangedHandler = (global::System.Delegate.Combine(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
			[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
			remove
			{
				this._propertyChangedHandler = (global::System.Delegate.Remove(this._propertyChangedHandler, value) as global::System.ComponentModel.PropertyChangedEventHandler);
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x0005B388 File Offset: 0x00059588
		public int IndexOf(T item)
		{
			return this._list.IndexOf(item);
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x0005B396 File Offset: 0x00059596
		public void Insert(int index, T item)
		{
			this._list.Insert(index, item);
			this.BumpListVersion(false);
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x0005B3AC File Offset: 0x000595AC
		public void RemoveAt(int index)
		{
			this._list.RemoveAt(index);
			this.BumpListVersion(false);
		}

		// Token: 0x17000540 RID: 1344
		public T this[int index]
		{
			get
			{
				return this._list[index];
			}
			set
			{
				this._list[index] = value;
				this.BumpListVersion(false);
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x0005B3E5 File Offset: 0x000595E5
		public void Add(T item)
		{
			this._list.Add(item);
			this.BumpListVersion(false);
			item.PropertyChanged += this.OnEffectStopPropertyChanged;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x0005B414 File Offset: 0x00059614
		public void Clear()
		{
			foreach (T t in this._list)
			{
				t.PropertyChanged -= this.OnEffectStopPropertyChanged;
			}
			this._list.Clear();
			this.BumpListVersion(true);
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x0005B48C File Offset: 0x0005968C
		public bool Contains(T item)
		{
			return this._list.Contains(item);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x0005B49A File Offset: 0x0005969A
		public void CopyTo(T[] array, int arrayIndex)
		{
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x0600174F RID: 5967 RVA: 0x0005B4A9 File Offset: 0x000596A9
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001750 RID: 5968 RVA: 0x0005B4B6 File Offset: 0x000596B6
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x0005B4B9 File Offset: 0x000596B9
		public bool Remove(T item)
		{
			this.BumpListVersion(false);
			item.PropertyChanged -= this.OnEffectStopPropertyChanged;
			return this._list.Remove(item);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x0005B4E5 File Offset: 0x000596E5
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06001753 RID: 5971 RVA: 0x0005B4F7 File Offset: 0x000596F7
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06001754 RID: 5972 RVA: 0x0005B50C File Offset: 0x0005970C
		int global::System.Collections.IList.Add(object value)
		{
			T item = value as T;
			this.Add(item);
			return this._list.IndexOf(item);
		}

		// Token: 0x06001755 RID: 5973 RVA: 0x0005B538 File Offset: 0x00059738
		void global::System.Collections.IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x06001756 RID: 5974 RVA: 0x0005B540 File Offset: 0x00059740
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.Contains(value as T);
		}

		// Token: 0x06001757 RID: 5975 RVA: 0x0005B553 File Offset: 0x00059753
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this._list.IndexOf(value as T);
		}

		// Token: 0x06001758 RID: 5976 RVA: 0x0005B56C File Offset: 0x0005976C
		void global::System.Collections.IList.Insert(int index, object value)
		{
			T t = value as T;
			this.Insert(index, t);
			this.BumpListVersion(false);
			t.PropertyChanged += this.OnEffectStopPropertyChanged;
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001759 RID: 5977 RVA: 0x0005B5AB File Offset: 0x000597AB
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x0600175A RID: 5978 RVA: 0x0005B5AE File Offset: 0x000597AE
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600175B RID: 5979 RVA: 0x0005B5B1 File Offset: 0x000597B1
		void global::System.Collections.IList.Remove(object value)
		{
			this.Remove(value as T);
		}

		// Token: 0x0600175C RID: 5980 RVA: 0x0005B5C8 File Offset: 0x000597C8
		void global::System.Collections.IList.RemoveAt(int index)
		{
			if (index < this._list.Count)
			{
				this._list[index].PropertyChanged -= this.OnEffectStopPropertyChanged;
			}
			this._list.RemoveAt(index);
			this.BumpListVersion(false);
		}

		// Token: 0x17000545 RID: 1349
		object global::System.Collections.IList.this[int index]
		{
			get
			{
				return this._list[index];
			}
			set
			{
				if (index < this._list.Count)
				{
					this._list[index].PropertyChanged -= this.OnEffectStopPropertyChanged;
					this._list[index] = (value as T);
					this._list[index].PropertyChanged += this.OnEffectStopPropertyChanged;
					this.BumpListVersion(false);
				}
			}
		}

		// Token: 0x0600175F RID: 5983 RVA: 0x0005B6A9 File Offset: 0x000598A9
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			((global::System.Collections.ICollection)this._list).CopyTo(array, index);
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x06001760 RID: 5984 RVA: 0x0005B6B8 File Offset: 0x000598B8
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06001761 RID: 5985 RVA: 0x0005B6C5 File Offset: 0x000598C5
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001762 RID: 5986 RVA: 0x0005B6C8 File Offset: 0x000598C8
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000B4E RID: 2894
		private global::System.Collections.Generic.List<T> _list = new global::System.Collections.Generic.List<T>(3);

		// Token: 0x04000B4F RID: 2895
		private int _listVersion;

		// Token: 0x04000B50 RID: 2896
		private int _listSortVersion = -1;

		// Token: 0x04000B51 RID: 2897
		private global::System.Collections.Generic.List<T> _sortedList;

		// Token: 0x04000B52 RID: 2898
		private double _stopValueForBottomOfRange;

		// Token: 0x04000B53 RID: 2899
		private int _stopValueForBottomOfRangeVersion = -1;

		// Token: 0x04000B54 RID: 2900
		private double _stopValueForTopOfRange = 1.0;

		// Token: 0x04000B55 RID: 2901
		private int _stopValueForTopOfRangeVersion = -1;

		// Token: 0x04000B56 RID: 2902
		private bool _changeNotificationsSuspended;

		// Token: 0x04000B57 RID: 2903
		private bool _changesMadeWhileNotificationsSuspended;

		// Token: 0x04000B58 RID: 2904
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x04000B59 RID: 2905
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;
	}
}
