using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Threading;

namespace Infragistics
{
	// Token: 0x0200003D RID: 61
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	[global::System.Runtime.CompilerServices.WidgetModule("Gauge")]
	public class FastItemsSource : global::System.Collections.IEnumerable, global::Infragistics.IFastItemsSource
	{
		// Token: 0x14000008 RID: 8
		// (add) Token: 0x0600038A RID: 906 RVA: 0x0000E340 File Offset: 0x0000C540
		// (remove) Token: 0x0600038B RID: 907 RVA: 0x0000E378 File Offset: 0x0000C578
		public event global::System.EventHandler<global::Infragistics.FastItemsSourceEventArgs> Event;

		// Token: 0x0600038C RID: 908 RVA: 0x0000E3AD File Offset: 0x0000C5AD
		private void RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction action, int position, int count)
		{
			if (this.Event != null)
			{
				this.Event(this, new global::Infragistics.FastItemsSourceEventArgs(action, position, count));
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x0000E3CB File Offset: 0x0000C5CB
		private void RaiseDataSourceEvent(int position, string propertyName)
		{
			if (this.Event != null)
			{
				this.Event(this, new global::Infragistics.FastItemsSourceEventArgs(position, propertyName));
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x0600038E RID: 910 RVA: 0x0000E3E8 File Offset: 0x0000C5E8
		// (set) Token: 0x0600038F RID: 911 RVA: 0x0000E3F0 File Offset: 0x0000C5F0
		public global::System.Windows.Threading.Dispatcher Dispatcher { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000390 RID: 912 RVA: 0x0000E3F9 File Offset: 0x0000C5F9
		// (set) Token: 0x06000391 RID: 913 RVA: 0x0000E404 File Offset: 0x0000C604
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return this.itemsSource;
			}
			set
			{
				if (this.itemsSource == value)
				{
					return;
				}
				this.Detach();
				this.itemsSource = value;
				this.contents.Clear();
				this.index = null;
				this.Attach();
				foreach (global::Infragistics.ColumnReference columnReference in this.columns.Values)
				{
					columnReference.FastItemColumn.Reset();
				}
				this.RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction.Insert, 0, this.contents.Count);
			}
		}

		// Token: 0x06000392 RID: 914 RVA: 0x0000E4A4 File Offset: 0x0000C6A4
		public void Detach()
		{
			if (this.itemsSource != null)
			{
				if (this.itemsSource is global::System.Collections.Specialized.INotifyCollectionChanged)
				{
					(this.itemsSource as global::System.Collections.Specialized.INotifyCollectionChanged).CollectionChanged -= this.ItemsSourceEventProxy.CollectionChanged;
				}
				foreach (object obj in this.contents)
				{
					if (obj is global::System.ComponentModel.INotifyPropertyChanged)
					{
						(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged -= this.ItemsSourceEventProxy.PropertyChanged;
					}
				}
				this.ItemsSourceEventProxy.WeakCollectionChanged = null;
				this.ItemsSourceEventProxy.WeakPropertyChanged = null;
				this.ItemsSourceEventProxy = null;
			}
		}

		// Token: 0x06000393 RID: 915 RVA: 0x0000E604 File Offset: 0x0000C804
		public void Attach()
		{
			if (this.itemsSource != null)
			{
				this.ItemsSourceEventProxy = new global::Infragistics.ItemSourceEventProxy(this);
				this.ItemsSourceEventProxy.WeakCollectionChanged = delegate(global::Infragistics.IFastItemsSource fastItemsSource, object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
				{
					global::Infragistics.FastItemsSource fastItemsSource2 = (global::Infragistics.FastItemsSource)fastItemsSource;
					switch (e.Action)
					{
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
						fastItemsSource2.dataSourceAdd(e.NewStartingIndex, e.NewItems);
						return;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
						fastItemsSource2.dataSourceRemove(e.OldStartingIndex, e.OldItems);
						return;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Replace:
						fastItemsSource2.dataSourceReplace(e.NewStartingIndex, e.OldItems, e.NewItems);
						return;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Move:
						break;
					case global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset:
						fastItemsSource2.dataSourceReset();
						break;
					default:
						return;
					}
				};
				this.ItemsSourceEventProxy.WeakPropertyChanged = delegate(global::Infragistics.IFastItemsSource fastItemsSource, object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
				{
					global::Infragistics.FastItemsSource fastItemsSource2 = (global::Infragistics.FastItemsSource)fastItemsSource;
					fastItemsSource2.dataSourceChange(sender, e.PropertyName);
				};
				if (this.itemsSource is global::System.Collections.Specialized.INotifyCollectionChanged)
				{
					(this.itemsSource as global::System.Collections.Specialized.INotifyCollectionChanged).CollectionChanged += this.ItemsSourceEventProxy.CollectionChanged;
				}
				foreach (object obj in this.itemsSource)
				{
					this.contents.Add(obj);
					if (obj is global::System.ComponentModel.INotifyPropertyChanged)
					{
						(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged += this.ItemsSourceEventProxy.PropertyChanged;
					}
				}
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x0000E70C File Offset: 0x0000C90C
		private void dataSourceAdd(int position, global::System.Collections.IList newItems)
		{
			foreach (object obj in newItems)
			{
				if (obj is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged += this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			if (this.index != null)
			{
				for (int i = 0; i < newItems.Count; i++)
				{
					this.index.Add(newItems[i], position + i);
				}
				for (int j = position; j < this.contents.Count; j++)
				{
					this.index[this.contents[j]] = j + newItems.Count;
				}
			}
			this.contents.InsertRange(position, newItems);
			foreach (global::Infragistics.ColumnReference columnReference in this.columns.Values)
			{
				columnReference.FastItemColumn.InsertRange(position, newItems.Count);
			}
			this.RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction.Insert, position, newItems.Count);
		}

		// Token: 0x06000395 RID: 917 RVA: 0x0000E84C File Offset: 0x0000CA4C
		private void dataSourceRemove(int position, global::System.Collections.IList oldItems)
		{
			foreach (object obj in oldItems)
			{
				if (obj is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged -= this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			this.contents.RemoveRange(position, oldItems.Count);
			if (this.index != null)
			{
				foreach (object key in oldItems)
				{
					this.index.Remove(key);
				}
				for (int i = position; i < this.contents.Count; i++)
				{
					this.index[this.contents[i]] = i;
				}
			}
			foreach (global::Infragistics.ColumnReference columnReference in this.columns.Values)
			{
				columnReference.FastItemColumn.RemoveRange(position, oldItems.Count);
			}
			this.RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction.Remove, position, oldItems.Count);
		}

		// Token: 0x06000396 RID: 918 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		private void dataSourceReplace(int position, global::System.Collections.IList oldItems, global::System.Collections.IList newItems)
		{
			foreach (object obj in oldItems)
			{
				if (obj is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged -= this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			foreach (object obj2 in newItems)
			{
				if (obj2 is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj2 as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged += this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			for (int i = 0; i < newItems.Count; i++)
			{
				this.contents[position + i] = newItems[i];
			}
			if (this.index != null)
			{
				foreach (object key in oldItems)
				{
					this.index.Remove(key);
				}
				for (int j = 0; j < newItems.Count; j++)
				{
					this.index.Add(newItems[j], position + j);
				}
			}
			foreach (global::Infragistics.ColumnReference columnReference in this.columns.Values)
			{
				columnReference.FastItemColumn.ReplaceRange(position, newItems.Count);
			}
			this.RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction.Replace, position, oldItems.Count);
		}

		// Token: 0x06000397 RID: 919 RVA: 0x0000EB84 File Offset: 0x0000CD84
		private void dataSourceReset()
		{
			foreach (object obj in this.contents)
			{
				if (obj is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged -= this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			this.contents.Clear();
			this.index = null;
			foreach (object obj2 in this.itemsSource)
			{
				this.contents.Add(obj2);
				if (obj2 is global::System.ComponentModel.INotifyPropertyChanged)
				{
					(obj2 as global::System.ComponentModel.INotifyPropertyChanged).PropertyChanged += this.ItemsSourceEventProxy.PropertyChanged;
				}
			}
			foreach (global::Infragistics.ColumnReference columnReference in this.columns.Values)
			{
				columnReference.FastItemColumn.Reset();
			}
			this.RaiseDataSourceEvent(global::Infragistics.FastItemsSourceEventAction.Reset, 0, this.contents.Count);
		}

		// Token: 0x06000398 RID: 920 RVA: 0x0000ECD4 File Offset: 0x0000CED4
		private void dataSourceChange(object item, string propertyName)
		{
			global::Infragistics.ColumnReference columnReference = null;
			int num = this.IndexOf(item);
			if (num == -1)
			{
				throw new global::System.ArgumentException("item");
			}
			if (this.columns.TryGetValue(propertyName, out columnReference))
			{
				columnReference.FastItemColumn.ReplaceRange(num, 1);
			}
			if (this.columns.TryGetValue(propertyName + "_object", out columnReference))
			{
				columnReference.FastItemColumn.ReplaceRange(num, 1);
			}
			this.RaiseDataSourceEvent(num, propertyName);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000399 RID: 921 RVA: 0x0000ED48 File Offset: 0x0000CF48
		public int Count
		{
			get
			{
				return this.contents.Count;
			}
		}

		// Token: 0x170000E1 RID: 225
		public object this[int n]
		{
			get
			{
				return this.contents[n];
			}
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000ED63 File Offset: 0x0000CF63
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return this.contents.GetEnumerator();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000ED70 File Offset: 0x0000CF70
		public int IndexOf(object item)
		{
			if (this.index == null && this.contents.Count > 0)
			{
				this.index = new global::System.Collections.Generic.Dictionary<object, int>();
				for (int i = 0; i < this.contents.Count; i++)
				{
					object key = this.contents[i];
					if (!this.index.ContainsKey(key))
					{
						this.index.Add(key, i);
					}
				}
			}
			int result;
			if (this.index.TryGetValue(item, out result))
			{
				return result;
			}
			return -1;
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000EDF0 File Offset: 0x0000CFF0
		public global::Infragistics.IFastItemColumn<global::System.DateTime> RegisterColumnDateTime(string propertyName)
		{
			global::Infragistics.IFastItemColumn<global::System.DateTime> result = null;
			if (propertyName != null)
			{
				global::Infragistics.ColumnReference columnReference = null;
				if (!this.columns.TryGetValue(propertyName, out columnReference))
				{
					columnReference = new global::Infragistics.ColumnReference(new global::Infragistics.FastItemDateTimeColumn(this, propertyName));
					this.columns.Add(propertyName, columnReference);
				}
				columnReference.References++;
				result = (columnReference.FastItemColumn as global::Infragistics.IFastItemColumn<global::System.DateTime>);
			}
			return result;
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000EE4C File Offset: 0x0000D04C
		public global::Infragistics.IFastItemColumn<object> RegisterColumnObject(string propertyName)
		{
			global::Infragistics.IFastItemColumn<object> result = null;
			string key = propertyName + "_object";
			if (propertyName != null)
			{
				global::Infragistics.ColumnReference columnReference = null;
				if (!this.columns.TryGetValue(key, out columnReference))
				{
					columnReference = new global::Infragistics.ColumnReference(new global::Infragistics.FastItemObjectColumn(this, propertyName));
					this.columns.Add(key, columnReference);
				}
				columnReference.References++;
				result = (columnReference.FastItemColumn as global::Infragistics.IFastItemColumn<object>);
			}
			return result;
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000EEB4 File Offset: 0x0000D0B4
		public global::Infragistics.IFastItemColumn<int> RegisterColumnInt(string propertyName)
		{
			if (propertyName == null)
			{
				propertyName = "";
			}
			global::Infragistics.ColumnReference columnReference = null;
			if (!this.columns.TryGetValue(propertyName, out columnReference))
			{
				columnReference = new global::Infragistics.ColumnReference(new global::Infragistics.FastItemIntColumn(this, propertyName));
				this.columns.Add(propertyName, columnReference);
			}
			columnReference.References++;
			return columnReference.FastItemColumn as global::Infragistics.IFastItemColumn<int>;
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000EF14 File Offset: 0x0000D114
		public global::Infragistics.IFastItemColumn<double> RegisterColumn(string propertyName)
		{
			if (propertyName == null)
			{
				propertyName = "";
			}
			global::Infragistics.ColumnReference columnReference = null;
			if (!this.columns.TryGetValue(propertyName, out columnReference))
			{
				columnReference = new global::Infragistics.ColumnReference(new global::Infragistics.FastItemColumn(this, propertyName));
				this.columns.Add(propertyName, columnReference);
			}
			columnReference.References++;
			return columnReference.FastItemColumn as global::Infragistics.IFastItemColumn<double>;
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000EF74 File Offset: 0x0000D174
		public void DeregisterColumn(global::Infragistics.IFastItemColumnPropertyName fastItemColumn)
		{
			string text = (fastItemColumn != null) ? fastItemColumn.PropertyName : null;
			string text2 = text;
			if (fastItemColumn is global::Infragistics.IFastItemColumn<object>)
			{
				text2 += "_object";
			}
			if (text != null)
			{
				global::Infragistics.ColumnReference columnReference = null;
				if (this.columns.TryGetValue(text, out columnReference))
				{
					columnReference.References--;
					if (columnReference.References == 0)
					{
						this.columns.Remove(text2);
					}
				}
			}
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000EFDC File Offset: 0x0000D1DC
		public global::System.Collections.IList ContentsAsIList()
		{
			return this.contents;
		}

		// Token: 0x04000132 RID: 306
		internal global::Infragistics.ItemSourceEventProxy ItemsSourceEventProxy;

		// Token: 0x04000134 RID: 308
		private global::System.Collections.Generic.Dictionary<string, global::Infragistics.ColumnReference> columns = new global::System.Collections.Generic.Dictionary<string, global::Infragistics.ColumnReference>();

		// Token: 0x04000135 RID: 309
		private global::System.Collections.IEnumerable itemsSource;

		// Token: 0x04000136 RID: 310
		private global::System.Collections.ArrayList contents = new global::System.Collections.ArrayList();

		// Token: 0x04000137 RID: 311
		private global::System.Collections.Generic.Dictionary<object, int> index;
	}
}
