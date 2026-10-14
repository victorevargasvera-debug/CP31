using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics.Controls.Grids.Primitives
{
	// Token: 0x020000E5 RID: 229
	public abstract class FilterItemCollection : global::System.Collections.IList, global::System.Collections.ICollection, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged, global::System.ComponentModel.INotifyPropertyChanged
	{
		// Token: 0x0600075E RID: 1886
		public abstract int AddSilently(object item);

		// Token: 0x0600075F RID: 1887 RVA: 0x0001F3E0 File Offset: 0x0001D5E0
		public virtual void RaiseCollectionChanged()
		{
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0001F3F0 File Offset: 0x0001D5F0
		protected virtual void OnPropertyChanged(string propertyName)
		{
			global::System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
			if (propertyChanged != null)
			{
				propertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0001F414 File Offset: 0x0001D614
		protected virtual void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs args)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
			switch (args.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
				this.OnPropertyChanged("Count");
				break;
			}
			this.OnPropertyChanged("Item[]");
			if (collectionChanged != null)
			{
				collectionChanged(this, args);
			}
		}

		// Token: 0x06000762 RID: 1890
		public abstract global::System.Collections.IEnumerator GetEnumerator();

		// Token: 0x06000763 RID: 1891
		public abstract void CopyTo(global::System.Array array, int index);

		// Token: 0x17000244 RID: 580
		// (get) Token: 0x06000764 RID: 1892
		public abstract int Count { get; }

		// Token: 0x17000245 RID: 581
		// (get) Token: 0x06000765 RID: 1893
		public abstract bool IsSynchronized { get; }

		// Token: 0x17000246 RID: 582
		// (get) Token: 0x06000766 RID: 1894
		public abstract object SyncRoot { get; }

		// Token: 0x06000767 RID: 1895
		public abstract int Add(object value);

		// Token: 0x06000768 RID: 1896
		public abstract void Clear();

		// Token: 0x06000769 RID: 1897
		public abstract bool Contains(object value);

		// Token: 0x0600076A RID: 1898
		public abstract int IndexOf(object value);

		// Token: 0x0600076B RID: 1899
		public abstract void Insert(int index, object value);

		// Token: 0x0600076C RID: 1900
		public abstract void Remove(object value);

		// Token: 0x0600076D RID: 1901
		public abstract void RemoveAt(int index);

		// Token: 0x17000247 RID: 583
		// (get) Token: 0x0600076E RID: 1902
		public abstract bool IsFixedSize { get; }

		// Token: 0x17000248 RID: 584
		// (get) Token: 0x0600076F RID: 1903
		public abstract bool IsReadOnly { get; }

		// Token: 0x17000249 RID: 585
		public abstract object this[int index]
		{
			get;
			set;
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x06000772 RID: 1906 RVA: 0x0001F46C File Offset: 0x0001D66C
		// (remove) Token: 0x06000773 RID: 1907 RVA: 0x0001F4A4 File Offset: 0x0001D6A4
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000774 RID: 1908 RVA: 0x0001F4DC File Offset: 0x0001D6DC
		// (remove) Token: 0x06000775 RID: 1909 RVA: 0x0001F514 File Offset: 0x0001D714
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
	}
}
