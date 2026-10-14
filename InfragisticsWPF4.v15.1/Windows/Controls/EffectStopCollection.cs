using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Infragistics.Windows.Controls
{
	// Token: 0x02000262 RID: 610
	public abstract class EffectStopCollection<T> : global::System.ComponentModel.INotifyPropertyChanged, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.Generic.IList<!0>, global::System.Collections.Generic.ICollection<!0>, global::System.Collections.Generic.IEnumerable<!0>, global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable where T : global::Infragistics.Windows.Controls.EffectStop
	{
		// Token: 0x06001936 RID: 6454 RVA: 0x000619AE File Offset: 0x0005FBAE
		public void ReplaceAll(global::Infragistics.Windows.Controls.EffectStopCollection<T> newEffectStopCollection)
		{
			this._list.Clear();
			this._list.AddRange(newEffectStopCollection);
			this.BumpListVersion(true);
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000619CE File Offset: 0x0005FBCE
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

		// Token: 0x06001938 RID: 6456 RVA: 0x00061A03 File Offset: 0x0005FC03
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool ShouldSerialize()
		{
			return this._list.Count > 0;
		}

		// Token: 0x06001939 RID: 6457 RVA: 0x00061A13 File Offset: 0x0005FC13
		public void SuspendChangeNotifications()
		{
			this._changeNotificationsSuspended = true;
			this._changesMadeWhileNotificationsSuspended = true;
		}

		// Token: 0x0600193A RID: 6458 RVA: 0x00061A23 File Offset: 0x0005FC23
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

		// Token: 0x0600193B RID: 6459 RVA: 0x00061A4C File Offset: 0x0005FC4C
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

		// Token: 0x0600193C RID: 6460 RVA: 0x00061ACC File Offset: 0x0005FCCC
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

		// Token: 0x0600193D RID: 6461 RVA: 0x00061B3D File Offset: 0x0005FD3D
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

		// Token: 0x0600193E RID: 6462 RVA: 0x00061B7D File Offset: 0x0005FD7D
		private void OnEffectStopPropertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			this.OnPropertyChanged("Item[]");
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00061B8A File Offset: 0x0005FD8A
		private void OnPropertyChanged(string propertyName)
		{
			if (this._propertyChangedHandler != null)
			{
				this._propertyChangedHandler(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00061BA6 File Offset: 0x0005FDA6
		internal void RaiseChangeEvents(bool fullReset)
		{
			this.OnPropertyChanged("Count");
			this.OnPropertyChanged("Item[]");
			if (fullReset)
			{
				this.OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset, null, -1);
			}
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x00061BCC File Offset: 0x0005FDCC
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

		// Token: 0x06001942 RID: 6466 RVA: 0x00061C3C File Offset: 0x0005FE3C
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

		// Token: 0x06001943 RID: 6467 RVA: 0x00061D18 File Offset: 0x0005FF18
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

		// Token: 0x14000037 RID: 55
		// (add) Token: 0x06001944 RID: 6468 RVA: 0x00061D9C File Offset: 0x0005FF9C
		// (remove) Token: 0x06001945 RID: 6469 RVA: 0x00061DB5 File Offset: 0x0005FFB5
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

		// Token: 0x14000038 RID: 56
		// (add) Token: 0x06001946 RID: 6470 RVA: 0x00061DCE File Offset: 0x0005FFCE
		// (remove) Token: 0x06001947 RID: 6471 RVA: 0x00061DE7 File Offset: 0x0005FFE7
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

		// Token: 0x06001948 RID: 6472 RVA: 0x00061E00 File Offset: 0x00060000
		public int IndexOf(T item)
		{
			return this._list.IndexOf(item);
		}

		// Token: 0x06001949 RID: 6473 RVA: 0x00061E0E File Offset: 0x0006000E
		public void Insert(int index, T item)
		{
			this._list.Insert(index, item);
			this.BumpListVersion(false);
		}

		// Token: 0x0600194A RID: 6474 RVA: 0x00061E24 File Offset: 0x00060024
		public void RemoveAt(int index)
		{
			this._list.RemoveAt(index);
			this.BumpListVersion(false);
		}

		// Token: 0x170005BD RID: 1469
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

		// Token: 0x0600194D RID: 6477 RVA: 0x00061E5D File Offset: 0x0006005D
		public void Add(T item)
		{
			this._list.Add(item);
			this.BumpListVersion(false);
			item.PropertyChanged += this.OnEffectStopPropertyChanged;
		}

		// Token: 0x0600194E RID: 6478 RVA: 0x00061E8C File Offset: 0x0006008C
		public void Clear()
		{
			foreach (T t in this._list)
			{
				t.PropertyChanged -= this.OnEffectStopPropertyChanged;
			}
			this._list.Clear();
			this.BumpListVersion(true);
		}

		// Token: 0x0600194F RID: 6479 RVA: 0x00061F04 File Offset: 0x00060104
		public bool Contains(T item)
		{
			return this._list.Contains(item);
		}

		// Token: 0x06001950 RID: 6480 RVA: 0x00061F12 File Offset: 0x00060112
		public void CopyTo(T[] array, int arrayIndex)
		{
			this._list.CopyTo(array, arrayIndex);
		}

		// Token: 0x170005BE RID: 1470
		// (get) Token: 0x06001951 RID: 6481 RVA: 0x00061F21 File Offset: 0x00060121
		public int Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x170005BF RID: 1471
		// (get) Token: 0x06001952 RID: 6482 RVA: 0x00061F2E File Offset: 0x0006012E
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001953 RID: 6483 RVA: 0x00061F31 File Offset: 0x00060131
		public bool Remove(T item)
		{
			this.BumpListVersion(false);
			item.PropertyChanged -= this.OnEffectStopPropertyChanged;
			return this._list.Remove(item);
		}

		// Token: 0x06001954 RID: 6484 RVA: 0x00061F5D File Offset: 0x0006015D
		global::System.Collections.Generic.IEnumerator<T> global::System.Collections.Generic.IEnumerable<!0>.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06001955 RID: 6485 RVA: 0x00061F6F File Offset: 0x0006016F
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this._list.GetEnumerator();
		}

		// Token: 0x06001956 RID: 6486 RVA: 0x00061F84 File Offset: 0x00060184
		int global::System.Collections.IList.Add(object value)
		{
			T item = value as T;
			this.Add(item);
			return this._list.IndexOf(item);
		}

		// Token: 0x06001957 RID: 6487 RVA: 0x00061FB0 File Offset: 0x000601B0
		void global::System.Collections.IList.Clear()
		{
			this.Clear();
		}

		// Token: 0x06001958 RID: 6488 RVA: 0x00061FB8 File Offset: 0x000601B8
		bool global::System.Collections.IList.Contains(object value)
		{
			return this.Contains(value as T);
		}

		// Token: 0x06001959 RID: 6489 RVA: 0x00061FCB File Offset: 0x000601CB
		int global::System.Collections.IList.IndexOf(object value)
		{
			return this._list.IndexOf(value as T);
		}

		// Token: 0x0600195A RID: 6490 RVA: 0x00061FE4 File Offset: 0x000601E4
		void global::System.Collections.IList.Insert(int index, object value)
		{
			T t = value as T;
			this.Insert(index, t);
			this.BumpListVersion(false);
			t.PropertyChanged += this.OnEffectStopPropertyChanged;
		}

		// Token: 0x170005C0 RID: 1472
		// (get) Token: 0x0600195B RID: 6491 RVA: 0x00062023 File Offset: 0x00060223
		bool global::System.Collections.IList.IsFixedSize
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C1 RID: 1473
		// (get) Token: 0x0600195C RID: 6492 RVA: 0x00062026 File Offset: 0x00060226
		bool global::System.Collections.IList.IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600195D RID: 6493 RVA: 0x00062029 File Offset: 0x00060229
		void global::System.Collections.IList.Remove(object value)
		{
			this.Remove(value as T);
		}

		// Token: 0x0600195E RID: 6494 RVA: 0x00062040 File Offset: 0x00060240
		void global::System.Collections.IList.RemoveAt(int index)
		{
			if (index < this._list.Count)
			{
				this._list[index].PropertyChanged -= this.OnEffectStopPropertyChanged;
			}
			this._list.RemoveAt(index);
			this.BumpListVersion(false);
		}

		// Token: 0x170005C2 RID: 1474
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

		// Token: 0x06001961 RID: 6497 RVA: 0x00062121 File Offset: 0x00060321
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			((global::System.Collections.ICollection)this._list).CopyTo(array, index);
		}

		// Token: 0x170005C3 RID: 1475
		// (get) Token: 0x06001962 RID: 6498 RVA: 0x00062130 File Offset: 0x00060330
		int global::System.Collections.ICollection.Count
		{
			get
			{
				return this._list.Count;
			}
		}

		// Token: 0x170005C4 RID: 1476
		// (get) Token: 0x06001963 RID: 6499 RVA: 0x0006213D File Offset: 0x0006033D
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005C5 RID: 1477
		// (get) Token: 0x06001964 RID: 6500 RVA: 0x00062140 File Offset: 0x00060340
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x04000CB1 RID: 3249
		private global::System.Collections.Generic.List<T> _list = new global::System.Collections.Generic.List<T>(3);

		// Token: 0x04000CB2 RID: 3250
		private int _listVersion;

		// Token: 0x04000CB3 RID: 3251
		private int _listSortVersion = -1;

		// Token: 0x04000CB4 RID: 3252
		private global::System.Collections.Generic.List<T> _sortedList;

		// Token: 0x04000CB5 RID: 3253
		private double _stopValueForBottomOfRange;

		// Token: 0x04000CB6 RID: 3254
		private int _stopValueForBottomOfRangeVersion = -1;

		// Token: 0x04000CB7 RID: 3255
		private double _stopValueForTopOfRange = 1.0;

		// Token: 0x04000CB8 RID: 3256
		private int _stopValueForTopOfRangeVersion = -1;

		// Token: 0x04000CB9 RID: 3257
		private bool _changeNotificationsSuspended;

		// Token: 0x04000CBA RID: 3258
		private bool _changesMadeWhileNotificationsSuspended;

		// Token: 0x04000CBB RID: 3259
		private global::System.ComponentModel.PropertyChangedEventHandler _propertyChangedHandler;

		// Token: 0x04000CBC RID: 3260
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;
	}
}
