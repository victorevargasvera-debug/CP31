using System;
using System.Collections;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;

namespace Infragistics.Collections
{
	// Token: 0x02000003 RID: 3
	public class AggregateValueCollection : global::System.Windows.DependencyObject, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x06000007 RID: 7 RVA: 0x00002333 File Offset: 0x00000533
		public AggregateValueCollection()
		{
			this.ItemsSources = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Collections.AggregateValueSource>();
			this.ItemsSources.CollectionChanged += this.ItemSourcesCollectionChanged;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000008 RID: 8 RVA: 0x0000235D File Offset: 0x0000055D
		// (set) Token: 0x06000009 RID: 9 RVA: 0x00002365 File Offset: 0x00000565
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Collections.AggregateValueSource> ItemsSources { get; set; }

		// Token: 0x0600000A RID: 10 RVA: 0x00002370 File Offset: 0x00000570
		private void ItemSourcesCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.OldItems != null)
			{
				foreach (object obj in e.OldItems)
				{
					global::Infragistics.Collections.AggregateValueSource aggregateValueSource = obj as global::Infragistics.Collections.AggregateValueSource;
					aggregateValueSource.CollectionChanged -= this.ValueSourceCollectionChanged;
				}
			}
			if (e.NewItems != null)
			{
				foreach (object obj2 in e.NewItems)
				{
					global::Infragistics.Collections.AggregateValueSource aggregateValueSource2 = obj2 as global::Infragistics.Collections.AggregateValueSource;
					aggregateValueSource2.CollectionChanged += this.ValueSourceCollectionChanged;
				}
			}
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002464 File Offset: 0x00000664
		private void ValueSourceCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x0600000C RID: 12 RVA: 0x00002480 File Offset: 0x00000680
		// (remove) Token: 0x0600000D RID: 13 RVA: 0x000024B8 File Offset: 0x000006B8
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x0600000E RID: 14 RVA: 0x000024ED File Offset: 0x000006ED
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			return new global::Infragistics.Collections.AggregateValueEnumerator(this);
		}
	}
}
