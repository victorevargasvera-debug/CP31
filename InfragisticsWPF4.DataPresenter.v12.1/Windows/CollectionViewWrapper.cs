using System;
using System.Collections;
using System.Collections.Specialized;
using System.Windows.Data;

namespace Infragistics.Windows
{
	// Token: 0x02000004 RID: 4
	internal class CollectionViewWrapper : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06000009 RID: 9 RVA: 0x000028A8 File Offset: 0x00000AA8
		internal CollectionViewWrapper(global::System.Windows.Data.CollectionView collectionView, global::Infragistics.Windows.EditableCollectionViewProxy proxy)
		{
			this._collectionView = collectionView;
			this._proxy = proxy;
			if (this._proxy != null)
			{
				this._lastNewItemPlaceholderPosition = this._proxy.NewItemPlaceholderPosition;
			}
			else
			{
				this._lastNewItemPlaceholderPosition = global::Infragistics.Windows.NewItemPlaceholderPositionProxy.None;
			}
			((global::System.Collections.Specialized.INotifyCollectionChanged)this._collectionView).CollectionChanged += this.OnCollectionChanged;
		}

		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600000A RID: 10 RVA: 0x00002904 File Offset: 0x00000B04
		internal int CurrentPosition
		{
			get
			{
				int num = this._collectionView.CurrentPosition;
				if (num >= 0)
				{
					num = this.GetIndex(num);
				}
				return num;
			}
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600000B RID: 11 RVA: 0x0000292A File Offset: 0x00000B2A
		internal global::Infragistics.Windows.EditableCollectionViewProxy EditableCollectionViewProxy
		{
			get
			{
				return this._proxy;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600000C RID: 12 RVA: 0x00002932 File Offset: 0x00000B32
		internal global::System.Windows.Data.CollectionView View
		{
			get
			{
				return this._collectionView;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x0000293A File Offset: 0x00000B3A
		private int GetAdjustedProxyIndex(int index)
		{
			if (this._proxy == null || this._proxy.NewItemPlaceholderPosition != global::Infragistics.Windows.NewItemPlaceholderPositionProxy.AtBeginning)
			{
				return index;
			}
			return index + 1;
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002957 File Offset: 0x00000B57
		private int GetIndex(int proxyIndex)
		{
			if (proxyIndex < 1 || this._proxy == null || this._proxy.NewItemPlaceholderPosition != global::Infragistics.Windows.NewItemPlaceholderPositionProxy.AtBeginning)
			{
				return proxyIndex;
			}
			return proxyIndex - 1;
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002978 File Offset: 0x00000B78
		internal bool MoveCurrentToPosition(int position)
		{
			return this._collectionView.MoveCurrentToPosition((position < 0) ? position : this.GetAdjustedProxyIndex(position));
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00002994 File Offset: 0x00000B94
		private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs = null;
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				if (this._proxy != null)
				{
					global::Infragistics.Windows.NewItemPlaceholderPositionProxy newItemPlaceholderPosition = this._proxy.NewItemPlaceholderPosition;
					if (this._lastNewItemPlaceholderPosition != newItemPlaceholderPosition && this._lastNewItemPlaceholderPosition == global::Infragistics.Windows.NewItemPlaceholderPositionProxy.None)
					{
						if (newItemPlaceholderPosition == global::Infragistics.Windows.NewItemPlaceholderPositionProxy.AtBeginning)
						{
							if (e.NewStartingIndex == 0)
							{
								break;
							}
						}
						else if (e.NewStartingIndex == this.Count)
						{
							break;
						}
					}
				}
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.NewItems, this.GetIndex(e.NewStartingIndex));
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				if (this._proxy != null)
				{
					global::Infragistics.Windows.NewItemPlaceholderPositionProxy newItemPlaceholderPosition2 = this._proxy.NewItemPlaceholderPosition;
					if (this._lastNewItemPlaceholderPosition != newItemPlaceholderPosition2 && newItemPlaceholderPosition2 == global::Infragistics.Windows.NewItemPlaceholderPositionProxy.None)
					{
						if (this._lastNewItemPlaceholderPosition == global::Infragistics.Windows.NewItemPlaceholderPositionProxy.AtBeginning)
						{
							if (e.OldStartingIndex == 0)
							{
								break;
							}
						}
						else if (e.OldStartingIndex == this.Count)
						{
							break;
						}
					}
				}
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.OldItems, this.GetIndex(e.OldStartingIndex));
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
				notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.NewItems, e.OldItems, this.GetIndex(e.NewStartingIndex));
				break;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
			{
				int count = this.Count;
				if ((e.NewStartingIndex < count && e.OldStartingIndex < count) || this._proxy == null || this._lastNewItemPlaceholderPosition == this._proxy.NewItemPlaceholderPosition)
				{
					notifyCollectionChangedEventArgs = new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(e.Action, e.NewItems, this.GetIndex(e.NewStartingIndex), this.GetIndex(e.OldStartingIndex));
				}
				break;
			}
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				notifyCollectionChangedEventArgs = e;
				break;
			}
			if (notifyCollectionChangedEventArgs != null && this.CollectionChanged != null)
			{
				this.CollectionChanged(this, notifyCollectionChangedEventArgs);
			}
			if (this._proxy != null)
			{
				this._lastNewItemPlaceholderPosition = this._proxy.NewItemPlaceholderPosition;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002B5B File Offset: 0x00000D5B
		public int Add(object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002B62 File Offset: 0x00000D62
		public void Clear()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002B69 File Offset: 0x00000D69
		public bool Contains(object value)
		{
			return this._collectionView.Contains(value);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002B77 File Offset: 0x00000D77
		public int IndexOf(object value)
		{
			return this.GetIndex(this._collectionView.IndexOf(value));
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002B8B File Offset: 0x00000D8B
		public void Insert(int index, object value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00002B92 File Offset: 0x00000D92
		public bool IsFixedSize
		{
			get
			{
				return this._proxy == null || (!this._proxy.CanAddNew && !this._proxy.CanRemove);
			}
		}

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x06000017 RID: 23 RVA: 0x00002BBB File Offset: 0x00000DBB
		public bool IsReadOnly
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002BBE File Offset: 0x00000DBE
		public void Remove(object value)
		{
			if (this._proxy != null)
			{
				this._proxy.Remove(value);
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002BDA File Offset: 0x00000DDA
		public void RemoveAt(int index)
		{
			if (this._proxy != null)
			{
				this._proxy.RemoveAt(this.GetAdjustedProxyIndex(index));
				return;
			}
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000006 RID: 6
		public object this[int index]
		{
			get
			{
				return this._collectionView.GetItemAt(this.GetAdjustedProxyIndex(index));
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00002C18 File Offset: 0x00000E18
		public void CopyTo(global::System.Array array, int index)
		{
			object[] array2 = new object[this.Count];
			int num = 0;
			foreach (object obj in this)
			{
				array2[num] = obj;
				num++;
			}
			global::System.Array.Copy(array2, 0, array, index, array2.Length);
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002C88 File Offset: 0x00000E88
		public int Count
		{
			get
			{
				int num = this._collectionView.Count;
				if (num > 0 && this._proxy != null && this._proxy.NewItemPlaceholderPosition != global::Infragistics.Windows.NewItemPlaceholderPositionProxy.None)
				{
					num--;
				}
				return num;
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002CBF File Offset: 0x00000EBF
		public bool IsSynchronized
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002CC2 File Offset: 0x00000EC2
		public object SyncRoot
		{
			get
			{
				return this;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00002CC5 File Offset: 0x00000EC5
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::Infragistics.Windows.CollectionViewWrapper.Enumerator(this);
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000021 RID: 33 RVA: 0x00002CD0 File Offset: 0x00000ED0
		// (remove) Token: 0x06000022 RID: 34 RVA: 0x00002D08 File Offset: 0x00000F08
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x04000003 RID: 3
		private global::System.Windows.Data.CollectionView _collectionView;

		// Token: 0x04000004 RID: 4
		private global::Infragistics.Windows.EditableCollectionViewProxy _proxy;

		// Token: 0x04000005 RID: 5
		private global::Infragistics.Windows.NewItemPlaceholderPositionProxy _lastNewItemPlaceholderPosition;

		// Token: 0x02000005 RID: 5
		private class Enumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x06000023 RID: 35 RVA: 0x00002D3D File Offset: 0x00000F3D
			internal Enumerator(global::Infragistics.Windows.CollectionViewWrapper collectionViewWrapper)
			{
				this._collectionViewWrapper = collectionViewWrapper;
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.CollectionViewWrapper.Enumerator.UnsetObjectMarker;
			}

			// Token: 0x06000024 RID: 36 RVA: 0x00002D5E File Offset: 0x00000F5E
			public void Dispose()
			{
				this.Reset();
			}

			// Token: 0x06000025 RID: 37 RVA: 0x00002D68 File Offset: 0x00000F68
			public bool MoveNext()
			{
				int count = this._collectionViewWrapper.Count;
				if (this._currentPosition < count - 1)
				{
					this._currentPosition++;
					this._currentItem = this._collectionViewWrapper[this._currentPosition];
					return true;
				}
				this._currentPosition = count;
				this._currentItem = global::Infragistics.Windows.CollectionViewWrapper.Enumerator.UnsetObjectMarker;
				return false;
			}

			// Token: 0x06000026 RID: 38 RVA: 0x00002DC6 File Offset: 0x00000FC6
			public void Reset()
			{
				this._currentPosition = -1;
				this._currentItem = global::Infragistics.Windows.CollectionViewWrapper.Enumerator.UnsetObjectMarker;
			}

			// Token: 0x1700000A RID: 10
			// (get) Token: 0x06000027 RID: 39 RVA: 0x00002DDA File Offset: 0x00000FDA
			object global::System.Collections.IEnumerator.Current
			{
				get
				{
					if (this._currentItem == global::Infragistics.Windows.CollectionViewWrapper.Enumerator.UnsetObjectMarker)
					{
						throw new global::System.InvalidOperationException();
					}
					return this._currentItem;
				}
			}

			// Token: 0x04000007 RID: 7
			private global::Infragistics.Windows.CollectionViewWrapper _collectionViewWrapper;

			// Token: 0x04000008 RID: 8
			private int _currentPosition;

			// Token: 0x04000009 RID: 9
			private object _currentItem;

			// Token: 0x0400000A RID: 10
			private static object UnsetObjectMarker = new object();
		}
	}
}
