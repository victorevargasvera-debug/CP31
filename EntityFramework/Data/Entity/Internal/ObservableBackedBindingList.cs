using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000127 RID: 295
	internal class ObservableBackedBindingList<T> : global::System.Data.Entity.Internal.SortableBindingList<T>
	{
		// Token: 0x06001488 RID: 5256 RVA: 0x00034914 File Offset: 0x00032B14
		public ObservableBackedBindingList(global::System.Collections.ObjectModel.ObservableCollection<T> obervableCollection) : base(obervableCollection.ToList<T>())
		{
			this._obervableCollection = obervableCollection;
			this._obervableCollection.CollectionChanged += this.ObservableCollectionChanged;
		}

		// Token: 0x06001489 RID: 5257 RVA: 0x00034940 File Offset: 0x00032B40
		protected override object AddNewCore()
		{
			this._addingNewInstance = true;
			this._addNewInstance = (T)((object)base.AddNewCore());
			return this._addNewInstance;
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00034968 File Offset: 0x00032B68
		public override void CancelNew(int itemIndex)
		{
			if (itemIndex >= 0 && itemIndex < base.Count && object.Equals(base[itemIndex], this._addNewInstance))
			{
				this._cancelNewInstance = this._addNewInstance;
				this._addNewInstance = default(T);
				this._addingNewInstance = false;
			}
			base.CancelNew(itemIndex);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x000349C8 File Offset: 0x00032BC8
		protected override void ClearItems()
		{
			foreach (T item in base.Items)
			{
				this.RemoveFromObservableCollection(item);
			}
			base.ClearItems();
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00034A1C File Offset: 0x00032C1C
		public override void EndNew(int itemIndex)
		{
			if (itemIndex >= 0 && itemIndex < base.Count && object.Equals(base[itemIndex], this._addNewInstance))
			{
				this.AddToObservableCollection(this._addNewInstance);
				this._addNewInstance = default(T);
				this._addingNewInstance = false;
			}
			base.EndNew(itemIndex);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00034A7A File Offset: 0x00032C7A
		protected override void InsertItem(int index, T item)
		{
			base.InsertItem(index, item);
			if (!this._addingNewInstance && index >= 0 && index <= base.Count)
			{
				this.AddToObservableCollection(item);
			}
		}

		// Token: 0x0600148E RID: 5262 RVA: 0x00034AA0 File Offset: 0x00032CA0
		protected override void RemoveItem(int index)
		{
			if (index >= 0 && index < base.Count && object.Equals(base[index], this._cancelNewInstance))
			{
				this._cancelNewInstance = default(T);
			}
			else
			{
				this.RemoveFromObservableCollection(base[index]);
			}
			base.RemoveItem(index);
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00034AFC File Offset: 0x00032CFC
		protected override void SetItem(int index, T item)
		{
			T t = base[index];
			base.SetItem(index, item);
			if (index >= 0 && index < base.Count)
			{
				if (object.Equals(t, this._addNewInstance))
				{
					this._addNewInstance = default(T);
					this._addingNewInstance = false;
				}
				else
				{
					this.RemoveFromObservableCollection(t);
				}
				this.AddToObservableCollection(item);
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00034B64 File Offset: 0x00032D64
		private void ObservableCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (!this._changingObservableCollection)
			{
				try
				{
					this._inCollectionChanged = true;
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset)
					{
						base.Clear();
					}
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
					{
						foreach (object obj in e.OldItems)
						{
							T item = (T)((object)obj);
							base.Remove(item);
						}
					}
					if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add || e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace)
					{
						foreach (object obj2 in e.NewItems)
						{
							T item2 = (T)((object)obj2);
							base.Add(item2);
						}
					}
				}
				finally
				{
					this._inCollectionChanged = false;
				}
			}
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00034C60 File Offset: 0x00032E60
		private void AddToObservableCollection(T item)
		{
			if (!this._inCollectionChanged)
			{
				try
				{
					this._changingObservableCollection = true;
					this._obervableCollection.Add(item);
				}
				finally
				{
					this._changingObservableCollection = false;
				}
			}
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00034CA4 File Offset: 0x00032EA4
		private void RemoveFromObservableCollection(T item)
		{
			if (!this._inCollectionChanged)
			{
				try
				{
					this._changingObservableCollection = true;
					this._obervableCollection.Remove(item);
				}
				finally
				{
					this._changingObservableCollection = false;
				}
			}
		}

		// Token: 0x040009A1 RID: 2465
		private bool _addingNewInstance;

		// Token: 0x040009A2 RID: 2466
		private T _addNewInstance;

		// Token: 0x040009A3 RID: 2467
		private T _cancelNewInstance;

		// Token: 0x040009A4 RID: 2468
		private readonly global::System.Collections.ObjectModel.ObservableCollection<T> _obervableCollection;

		// Token: 0x040009A5 RID: 2469
		private bool _inCollectionChanged;

		// Token: 0x040009A6 RID: 2470
		private bool _changingObservableCollection;
	}
}
