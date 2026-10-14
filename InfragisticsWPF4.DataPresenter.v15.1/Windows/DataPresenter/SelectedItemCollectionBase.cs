using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000398 RID: 920
	public abstract class SelectedItemCollectionBase : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x06002BD0 RID: 11216 RVA: 0x000C0A31 File Offset: 0x000BEC31
		protected SelectedItemCollectionBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			if (dataPresenter == null)
			{
				throw new global::System.ArgumentNullException("dataPresenter");
			}
			this._dataPresenter = dataPresenter;
			this._list = new global::Infragistics.Windows.DataPresenter.SparseList();
		}

		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002BD1 RID: 11217 RVA: 0x000C0A59 File Offset: 0x000BEC59
		public int Count
		{
			get
			{
				return this.List.Count;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002BD2 RID: 11218
		public abstract bool IsReadOnly { get; }

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002BD3 RID: 11219 RVA: 0x000C0A66 File Offset: 0x000BEC66
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002BD4 RID: 11220 RVA: 0x000C0A6E File Offset: 0x000BEC6E
		protected global::System.Collections.IList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002BD5 RID: 11221 RVA: 0x000C0A76 File Offset: 0x000BEC76
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x06002BD6 RID: 11222 RVA: 0x000C0A7E File Offset: 0x000BEC7E
		public bool Contains(object item)
		{
			return this.List.Contains(item);
		}

		// Token: 0x06002BD7 RID: 11223 RVA: 0x000C0A8C File Offset: 0x000BEC8C
		public int IndexOf(object item)
		{
			return this.List.IndexOf(item);
		}

		// Token: 0x06002BD8 RID: 11224 RVA: 0x000C0A9A File Offset: 0x000BEC9A
		internal void BeginUpdate()
		{
			this._beginUpdateCount++;
		}

		// Token: 0x06002BD9 RID: 11225 RVA: 0x000C0AAC File Offset: 0x000BECAC
		internal void EndUpdate()
		{
			this._beginUpdateCount--;
			if (this._beginUpdateCount <= 0 && this._pendingChangeCount > 0)
			{
				this._pendingChangeCount = 0;
				if (this._pendingChange != null)
				{
					global::System.Collections.Specialized.NotifyCollectionChangedEventArgs pendingChange = this._pendingChange;
					this._pendingChange = null;
					this.RaiseNotifications(pendingChange);
					return;
				}
				this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x06002BDA RID: 11226 RVA: 0x000C0B0A File Offset: 0x000BED0A
		internal global::Infragistics.Windows.Selection.ISelectableItem GetItem(int index)
		{
			return this._list[index] as global::Infragistics.Windows.Selection.ISelectableItem;
		}

		// Token: 0x06002BDB RID: 11227 RVA: 0x000C0B1D File Offset: 0x000BED1D
		internal void Initialize(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder owner)
		{
			this._owner = owner;
		}

		// Token: 0x06002BDC RID: 11228 RVA: 0x000C0B28 File Offset: 0x000BED28
		internal void RaiseNotifications(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (this._beginUpdateCount > 0)
			{
				if (this._pendingChangeCount == 0)
				{
					this._pendingChange = args;
				}
				else
				{
					this._pendingChange = null;
				}
				this._pendingChangeCount++;
				return;
			}
			base.RaisePropertyChangedEvent("Count");
			base.RaisePropertyChangedEvent("Item[]");
			this.RaiseCollectionChangedEvent(args);
		}

		// Token: 0x06002BDD RID: 11229
		internal abstract void ResetItemSelectionStates();

		// Token: 0x06002BDE RID: 11230 RVA: 0x000C0B84 File Offset: 0x000BED84
		protected int InternalAdd(object item)
		{
			int num = this.List.Add(item);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, num));
			return num;
		}

		// Token: 0x06002BDF RID: 11231 RVA: 0x000C0BAD File Offset: 0x000BEDAD
		protected internal void InternalAddRange(global::System.Collections.ICollection collection)
		{
			this.InternalAddRange(collection, false);
		}

		// Token: 0x06002BE0 RID: 11232 RVA: 0x000C0BB7 File Offset: 0x000BEDB7
		internal void InternalAddRange(global::System.Collections.ICollection collection, bool clear)
		{
			int count = this.Count;
			if (clear)
			{
				this._list.Clear();
			}
			this._list.AddRange(collection);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06002BE1 RID: 11233 RVA: 0x000C0BE6 File Offset: 0x000BEDE6
		protected internal void InternalClear()
		{
			this.List.Clear();
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06002BE2 RID: 11234 RVA: 0x000C0BFF File Offset: 0x000BEDFF
		internal void InternalClear(bool resetItemSelectionStates)
		{
			if (resetItemSelectionStates)
			{
				this.ResetItemSelectionStates();
			}
			this.InternalClear();
		}

		// Token: 0x06002BE3 RID: 11235 RVA: 0x000C0C10 File Offset: 0x000BEE10
		protected void InternalInsert(int index, object item)
		{
			this.List.Insert(index, item);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x06002BE4 RID: 11236 RVA: 0x000C0C30 File Offset: 0x000BEE30
		protected void InternalRemove(object item)
		{
			int num = this.IndexOf(item);
			if (0 <= num)
			{
				this.InternalRemoveAt(num);
			}
		}

		// Token: 0x06002BE5 RID: 11237 RVA: 0x000C0C50 File Offset: 0x000BEE50
		protected void InternalRemoveAt(int index)
		{
			object changedItem = this.List[index];
			this.List.RemoveAt(index);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, changedItem));
		}

		// Token: 0x06002BE6 RID: 11238 RVA: 0x000C0C83 File Offset: 0x000BEE83
		protected void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedAction action)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action));
			}
		}

		// Token: 0x06002BE7 RID: 11239 RVA: 0x000C0C9F File Offset: 0x000BEE9F
		protected void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, e);
			}
		}

		// Token: 0x1400007E RID: 126
		// (add) Token: 0x06002BE8 RID: 11240 RVA: 0x000C0CB6 File Offset: 0x000BEEB6
		// (remove) Token: 0x06002BE9 RID: 11241 RVA: 0x000C0CCF File Offset: 0x000BEECF
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

		// Token: 0x06002BEA RID: 11242 RVA: 0x000C0CE8 File Offset: 0x000BEEE8
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.List.CopyTo(array, index);
		}

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002BEB RID: 11243 RVA: 0x000C0CF7 File Offset: 0x000BEEF7
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return this.List.IsSynchronized;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002BEC RID: 11244 RVA: 0x000C0D04 File Offset: 0x000BEF04
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this.List.SyncRoot;
			}
		}

		// Token: 0x06002BED RID: 11245 RVA: 0x000C0D11 File Offset: 0x000BEF11
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.List.GetEnumerator();
		}

		// Token: 0x04001510 RID: 5392
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _owner;

		// Token: 0x04001511 RID: 5393
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x04001512 RID: 5394
		private global::Infragistics.Windows.DataPresenter.SparseList _list;

		// Token: 0x04001513 RID: 5395
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x04001514 RID: 5396
		private int _beginUpdateCount;

		// Token: 0x04001515 RID: 5397
		private int _pendingChangeCount;

		// Token: 0x04001516 RID: 5398
		private global::System.Collections.Specialized.NotifyCollectionChangedEventArgs _pendingChange;
	}
}
