using System;
using System.Collections;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using Infragistics.Windows.Selection;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000352 RID: 850
	public abstract class SelectedItemCollectionBase : global::Infragistics.PropertyChangeNotifier, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.Collections.ICollection, global::System.Collections.IEnumerable
	{
		// Token: 0x060027E8 RID: 10216 RVA: 0x000ABDD5 File Offset: 0x000A9FD5
		protected SelectedItemCollectionBase(global::Infragistics.Windows.DataPresenter.DataPresenterBase dataPresenter)
		{
			if (dataPresenter == null)
			{
				throw new global::System.ArgumentNullException("dataPresenter");
			}
			this._dataPresenter = dataPresenter;
			this._list = new global::Infragistics.Windows.DataPresenter.SparseList();
		}

		// Token: 0x17000C15 RID: 3093
		// (get) Token: 0x060027E9 RID: 10217 RVA: 0x000ABDFD File Offset: 0x000A9FFD
		public int Count
		{
			get
			{
				return this.List.Count;
			}
		}

		// Token: 0x17000C16 RID: 3094
		// (get) Token: 0x060027EA RID: 10218
		public abstract bool IsReadOnly { get; }

		// Token: 0x17000C17 RID: 3095
		// (get) Token: 0x060027EB RID: 10219 RVA: 0x000ABE0A File Offset: 0x000AA00A
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase DataPresenter
		{
			get
			{
				return this._dataPresenter;
			}
		}

		// Token: 0x17000C18 RID: 3096
		// (get) Token: 0x060027EC RID: 10220 RVA: 0x000ABE12 File Offset: 0x000AA012
		protected global::System.Collections.IList List
		{
			get
			{
				return this._list;
			}
		}

		// Token: 0x17000C19 RID: 3097
		// (get) Token: 0x060027ED RID: 10221 RVA: 0x000ABE1A File Offset: 0x000AA01A
		internal global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder Owner
		{
			get
			{
				return this._owner;
			}
		}

		// Token: 0x060027EE RID: 10222 RVA: 0x000ABE22 File Offset: 0x000AA022
		public bool Contains(object item)
		{
			return this.List.Contains(item);
		}

		// Token: 0x060027EF RID: 10223 RVA: 0x000ABE30 File Offset: 0x000AA030
		public int IndexOf(object item)
		{
			return this.List.IndexOf(item);
		}

		// Token: 0x060027F0 RID: 10224 RVA: 0x000ABE3E File Offset: 0x000AA03E
		internal void BeginUpdate()
		{
			this._beginUpdateCount++;
		}

		// Token: 0x060027F1 RID: 10225 RVA: 0x000ABE4E File Offset: 0x000AA04E
		internal void EndUpdate()
		{
			this._beginUpdateCount--;
			if (this._beginUpdateCount < 0 && this._isDirty)
			{
				this._isDirty = true;
				this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x060027F2 RID: 10226 RVA: 0x000ABE82 File Offset: 0x000AA082
		internal global::Infragistics.Windows.Selection.ISelectableItem GetItem(int index)
		{
			return this._list[index] as global::Infragistics.Windows.Selection.ISelectableItem;
		}

		// Token: 0x060027F3 RID: 10227 RVA: 0x000ABE95 File Offset: 0x000AA095
		internal void Initialize(global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder owner)
		{
			this._owner = owner;
		}

		// Token: 0x060027F4 RID: 10228 RVA: 0x000ABE9E File Offset: 0x000AA09E
		internal void RaiseNotifications(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			if (this._beginUpdateCount > 0)
			{
				this._isDirty = true;
				return;
			}
			base.RaisePropertyChangedEvent("Count");
			base.RaisePropertyChangedEvent("Item[]");
			this.RaiseCollectionChangedEvent(args);
		}

		// Token: 0x060027F5 RID: 10229
		internal abstract void ResetItemSelectionStates();

		// Token: 0x060027F6 RID: 10230 RVA: 0x000ABED0 File Offset: 0x000AA0D0
		protected int InternalAdd(object item)
		{
			int num = this.List.Add(item);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, num));
			return num;
		}

		// Token: 0x060027F7 RID: 10231 RVA: 0x000ABEF9 File Offset: 0x000AA0F9
		protected internal void InternalAddRange(global::System.Collections.ICollection collection)
		{
			this.InternalAddRange(collection, false);
		}

		// Token: 0x060027F8 RID: 10232 RVA: 0x000ABF03 File Offset: 0x000AA103
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

		// Token: 0x060027F9 RID: 10233 RVA: 0x000ABF32 File Offset: 0x000AA132
		protected internal void InternalClear()
		{
			this.List.Clear();
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000ABF4B File Offset: 0x000AA14B
		internal void InternalClear(bool resetItemSelectionStates)
		{
			if (resetItemSelectionStates)
			{
				this.ResetItemSelectionStates();
			}
			this.InternalClear();
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000ABF5C File Offset: 0x000AA15C
		protected void InternalInsert(int index, object item)
		{
			this.List.Insert(index, item);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, item, index));
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000ABF7C File Offset: 0x000AA17C
		protected void InternalRemove(object item)
		{
			int num = this.IndexOf(item);
			if (0 <= num)
			{
				this.InternalRemoveAt(num);
			}
		}

		// Token: 0x060027FD RID: 10237 RVA: 0x000ABF9C File Offset: 0x000AA19C
		protected void InternalRemoveAt(int index)
		{
			object changedItem = this.List[index];
			this.List.RemoveAt(index);
			this.RaiseNotifications(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, changedItem));
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000ABFCF File Offset: 0x000AA1CF
		protected void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedAction action)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(action));
			}
		}

		// Token: 0x060027FF RID: 10239 RVA: 0x000ABFEB File Offset: 0x000AA1EB
		protected void RaiseCollectionChangedEvent(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this._collectionChangedHandler != null)
			{
				this._collectionChangedHandler(this, e);
			}
		}

		// Token: 0x1400007D RID: 125
		// (add) Token: 0x06002800 RID: 10240 RVA: 0x000AC002 File Offset: 0x000AA202
		// (remove) Token: 0x06002801 RID: 10241 RVA: 0x000AC01B File Offset: 0x000AA21B
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

		// Token: 0x06002802 RID: 10242 RVA: 0x000AC034 File Offset: 0x000AA234
		void global::System.Collections.ICollection.CopyTo(global::System.Array array, int index)
		{
			this.List.CopyTo(array, index);
		}

		// Token: 0x17000C1A RID: 3098
		// (get) Token: 0x06002803 RID: 10243 RVA: 0x000AC043 File Offset: 0x000AA243
		bool global::System.Collections.ICollection.IsSynchronized
		{
			get
			{
				return this.List.IsSynchronized;
			}
		}

		// Token: 0x17000C1B RID: 3099
		// (get) Token: 0x06002804 RID: 10244 RVA: 0x000AC050 File Offset: 0x000AA250
		object global::System.Collections.ICollection.SyncRoot
		{
			get
			{
				return this.List.SyncRoot;
			}
		}

		// Token: 0x06002805 RID: 10245 RVA: 0x000AC05D File Offset: 0x000AA25D
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.List.GetEnumerator();
		}

		// Token: 0x040012E8 RID: 4840
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase.SelectedItemHolder _owner;

		// Token: 0x040012E9 RID: 4841
		private global::System.Collections.Specialized.NotifyCollectionChangedEventHandler _collectionChangedHandler;

		// Token: 0x040012EA RID: 4842
		private global::Infragistics.Windows.DataPresenter.SparseList _list;

		// Token: 0x040012EB RID: 4843
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dataPresenter;

		// Token: 0x040012EC RID: 4844
		private int _beginUpdateCount;

		// Token: 0x040012ED RID: 4845
		private bool _isDirty;
	}
}
