using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001BA RID: 442
	internal class SuppressedEventsCollection
	{
		// Token: 0x060018B5 RID: 6325 RVA: 0x0006E9A9 File Offset: 0x0006CBA9
		public SuppressedEventsCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			this._dp = dp;
			this._collection = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper>();
			this._collection.CollectionChanged += this.OnCollectionCollectionChanged;
			this._hashSet = new global::Infragistics.Windows.Helpers.HashSet();
		}

		// Token: 0x1700069E RID: 1694
		// (get) Token: 0x060018B6 RID: 6326 RVA: 0x0006E9E5 File Offset: 0x0006CBE5
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper> Collection
		{
			get
			{
				return this._collection;
			}
		}

		// Token: 0x060018B7 RID: 6327 RVA: 0x0006E9ED File Offset: 0x0006CBED
		private void OnCollectionCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._isCollectionDirty = true;
			this._dp._cachedInitializeRecordEventSuppressed = null;
		}

		// Token: 0x060018B8 RID: 6328 RVA: 0x0006EA08 File Offset: 0x0006CC08
		public bool IsEventSuppressed(global::System.Windows.RoutedEvent routedEvent)
		{
			if (this._isCollectionDirty)
			{
				this._isCollectionDirty = false;
				this._hashSet.Clear();
				foreach (global::Infragistics.Windows.DataPresenter.RoutedEventWrapper routedEventWrapper in this._collection)
				{
					if (routedEventWrapper.RoutedEvent != null)
					{
						this._hashSet.Add(routedEventWrapper.RoutedEvent);
					}
				}
			}
			return this._hashSet.Exists(routedEvent);
		}

		// Token: 0x04000A24 RID: 2596
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper> _collection;

		// Token: 0x04000A25 RID: 2597
		private bool _isCollectionDirty;

		// Token: 0x04000A26 RID: 2598
		private global::Infragistics.Windows.Helpers.HashSet _hashSet;

		// Token: 0x04000A27 RID: 2599
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
	}
}
