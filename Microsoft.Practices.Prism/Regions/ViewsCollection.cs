using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Linq;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000086 RID: 134
	public class ViewsCollection : global::Microsoft.Practices.Prism.Regions.IViewsCollection, global::System.Collections.Generic.IEnumerable<object>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06000393 RID: 915 RVA: 0x00009F78 File Offset: 0x00008178
		public ViewsCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Practices.Prism.Regions.ItemMetadata> list, global::System.Predicate<global::Microsoft.Practices.Prism.Regions.ItemMetadata> filter)
		{
			this.subjectCollection = list;
			this.filter = filter;
			this.MonitorAllMetadataItems();
			this.subjectCollection.CollectionChanged += this.SourceCollectionChanged;
			this.UpdateFilteredItemsList();
		}

		// Token: 0x1400001A RID: 26
		// (add) Token: 0x06000394 RID: 916 RVA: 0x00009FD4 File Offset: 0x000081D4
		// (remove) Token: 0x06000395 RID: 917 RVA: 0x0000A00C File Offset: 0x0000820C
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000396 RID: 918 RVA: 0x0000A041 File Offset: 0x00008241
		// (set) Token: 0x06000397 RID: 919 RVA: 0x0000A049 File Offset: 0x00008249
		public global::System.Comparison<object> SortComparison
		{
			get
			{
				return this.sort;
			}
			set
			{
				if (this.sort != value)
				{
					this.sort = value;
					this.UpdateFilteredItemsList();
					this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
				}
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000398 RID: 920 RVA: 0x0000A072 File Offset: 0x00008272
		private global::System.Collections.Generic.IEnumerable<object> FilteredItems
		{
			get
			{
				return this.filteredItems;
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x0000A07A File Offset: 0x0000827A
		public bool Contains(object value)
		{
			return this.FilteredItems.Contains(value);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x0000A088 File Offset: 0x00008288
		public global::System.Collections.Generic.IEnumerator<object> GetEnumerator()
		{
			return this.FilteredItems.GetEnumerator();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x0000A095 File Offset: 0x00008295
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0000A0A0 File Offset: 0x000082A0
		private void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x0000A0BF File Offset: 0x000082BF
		private void NotifyReset()
		{
			this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0000A0CD File Offset: 0x000082CD
		private void ResetAllMonitors()
		{
			this.RemoveAllMetadataMonitors();
			this.MonitorAllMetadataItems();
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0000A0DC File Offset: 0x000082DC
		private void MonitorAllMetadataItems()
		{
			foreach (global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata in this.subjectCollection)
			{
				this.AddMetadataMonitor(itemMetadata, this.filter(itemMetadata));
			}
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x0000A138 File Offset: 0x00008338
		private void RemoveAllMetadataMonitors()
		{
			foreach (global::System.Collections.Generic.KeyValuePair<global::Microsoft.Practices.Prism.Regions.ItemMetadata, global::Microsoft.Practices.Prism.Regions.ViewsCollection.MonitorInfo> keyValuePair in this.monitoredItems)
			{
				keyValuePair.Key.MetadataChanged -= this.OnItemMetadataChanged;
			}
			this.monitoredItems.Clear();
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x0000A1A8 File Offset: 0x000083A8
		private void AddMetadataMonitor(global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata, bool isInList)
		{
			itemMetadata.MetadataChanged += this.OnItemMetadataChanged;
			this.monitoredItems.Add(itemMetadata, new global::Microsoft.Practices.Prism.Regions.ViewsCollection.MonitorInfo
			{
				IsInList = isInList
			});
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x0000A1E1 File Offset: 0x000083E1
		private void RemoveMetadataMonitor(global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata)
		{
			itemMetadata.MetadataChanged -= this.OnItemMetadataChanged;
			this.monitoredItems.Remove(itemMetadata);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x0000A204 File Offset: 0x00008404
		private void OnItemMetadataChanged(object sender, global::System.EventArgs e)
		{
			global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = (global::Microsoft.Practices.Prism.Regions.ItemMetadata)sender;
			global::Microsoft.Practices.Prism.Regions.ViewsCollection.MonitorInfo monitorInfo;
			if (!this.monitoredItems.TryGetValue(itemMetadata, out monitorInfo))
			{
				return;
			}
			if (this.filter(itemMetadata))
			{
				if (!monitorInfo.IsInList)
				{
					monitorInfo.IsInList = true;
					this.UpdateFilteredItemsList();
					this.NotifyAdd(itemMetadata.Item);
					return;
				}
			}
			else
			{
				monitorInfo.IsInList = false;
				this.RemoveFromFilteredList(itemMetadata.Item);
			}
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x0000A270 File Offset: 0x00008470
		private void SourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			switch (e.Action)
			{
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Add:
				this.UpdateFilteredItemsList();
				foreach (object obj in e.NewItems)
				{
					global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata = (global::Microsoft.Practices.Prism.Regions.ItemMetadata)obj;
					bool flag = this.filter(itemMetadata);
					this.AddMetadataMonitor(itemMetadata, flag);
					if (flag)
					{
						this.NotifyAdd(itemMetadata.Item);
					}
				}
				if (this.sort != null)
				{
					this.NotifyReset();
					return;
				}
				return;
			case global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove:
				using (global::System.Collections.IEnumerator enumerator2 = e.OldItems.GetEnumerator())
				{
					while (enumerator2.MoveNext())
					{
						object obj2 = enumerator2.Current;
						global::Microsoft.Practices.Prism.Regions.ItemMetadata itemMetadata2 = (global::Microsoft.Practices.Prism.Regions.ItemMetadata)obj2;
						this.RemoveMetadataMonitor(itemMetadata2);
						if (this.filter(itemMetadata2))
						{
							this.RemoveFromFilteredList(itemMetadata2.Item);
						}
					}
					return;
				}
				break;
			}
			this.ResetAllMonitors();
			this.UpdateFilteredItemsList();
			this.NotifyReset();
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x0000A398 File Offset: 0x00008598
		private void NotifyAdd(object item)
		{
			int newStartingIndex = this.filteredItems.IndexOf(item);
			this.NotifyAdd(new object[]
			{
				item
			}, newStartingIndex);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x0000A3C8 File Offset: 0x000085C8
		private void RemoveFromFilteredList(object item)
		{
			int originalIndex = this.filteredItems.IndexOf(item);
			this.UpdateFilteredItemsList();
			this.NotifyRemove(new object[]
			{
				item
			}, originalIndex);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x0000A414 File Offset: 0x00008614
		private void UpdateFilteredItemsList()
		{
			this.filteredItems = (from i in this.subjectCollection
			where this.filter(i)
			select i.Item).OrderBy((object o) => o, new global::Microsoft.Practices.Prism.Regions.ViewsCollection.RegionItemComparer(this.SortComparison)).ToList<object>();
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x0000A492 File Offset: 0x00008692
		private void NotifyAdd(global::System.Collections.IList items, int newStartingIndex)
		{
			if (items.Count > 0)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, items, newStartingIndex));
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x0000A4AB File Offset: 0x000086AB
		private void NotifyRemove(global::System.Collections.IList items, int originalIndex)
		{
			if (items.Count > 0)
			{
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, items, originalIndex));
			}
		}

		// Token: 0x040000D0 RID: 208
		private readonly global::System.Collections.ObjectModel.ObservableCollection<global::Microsoft.Practices.Prism.Regions.ItemMetadata> subjectCollection;

		// Token: 0x040000D1 RID: 209
		private readonly global::System.Collections.Generic.Dictionary<global::Microsoft.Practices.Prism.Regions.ItemMetadata, global::Microsoft.Practices.Prism.Regions.ViewsCollection.MonitorInfo> monitoredItems = new global::System.Collections.Generic.Dictionary<global::Microsoft.Practices.Prism.Regions.ItemMetadata, global::Microsoft.Practices.Prism.Regions.ViewsCollection.MonitorInfo>();

		// Token: 0x040000D2 RID: 210
		private readonly global::System.Predicate<global::Microsoft.Practices.Prism.Regions.ItemMetadata> filter;

		// Token: 0x040000D3 RID: 211
		private global::System.Comparison<object> sort;

		// Token: 0x040000D4 RID: 212
		private global::System.Collections.Generic.List<object> filteredItems = new global::System.Collections.Generic.List<object>();

		// Token: 0x02000087 RID: 135
		private class MonitorInfo
		{
			// Token: 0x170000D2 RID: 210
			// (get) Token: 0x060003AD RID: 941 RVA: 0x0000A4C4 File Offset: 0x000086C4
			// (set) Token: 0x060003AE RID: 942 RVA: 0x0000A4CC File Offset: 0x000086CC
			public bool IsInList { get; set; }
		}

		// Token: 0x02000088 RID: 136
		private class RegionItemComparer : global::System.Collections.Generic.Comparer<object>
		{
			// Token: 0x060003B0 RID: 944 RVA: 0x0000A4DD File Offset: 0x000086DD
			public RegionItemComparer(global::System.Comparison<object> comparer)
			{
				this.comparer = comparer;
			}

			// Token: 0x060003B1 RID: 945 RVA: 0x0000A4EC File Offset: 0x000086EC
			public override int Compare(object x, object y)
			{
				if (this.comparer == null)
				{
					return 0;
				}
				return this.comparer(x, y);
			}

			// Token: 0x040000D9 RID: 217
			private readonly global::System.Comparison<object> comparer;
		}
	}
}
