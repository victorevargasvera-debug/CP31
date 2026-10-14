using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Windows;
using Infragistics.Windows.Helpers;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020001DD RID: 477
	internal class SuppressedEventsCollection
	{
		// Token: 0x06001C7E RID: 7294 RVA: 0x00081D15 File Offset: 0x0007FF15
		public SuppressedEventsCollection(global::Infragistics.Windows.DataPresenter.DataPresenterBase dp)
		{
			this._dp = dp;
			this._collection = new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper>();
			this._collection.CollectionChanged += this.OnCollectionCollectionChanged;
			this._hashSet = new global::Infragistics.Windows.Helpers.HashSet();
		}

		// Token: 0x17000804 RID: 2052
		// (get) Token: 0x06001C7F RID: 7295 RVA: 0x00081D51 File Offset: 0x0007FF51
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper> Collection
		{
			get
			{
				return this._collection;
			}
		}

		// Token: 0x06001C80 RID: 7296 RVA: 0x00081D59 File Offset: 0x0007FF59
		private void OnCollectionCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			this._isCollectionDirty = true;
			this._dp._cachedInitializeRecordEventSuppressed = null;
		}

		// Token: 0x06001C81 RID: 7297 RVA: 0x00081D74 File Offset: 0x0007FF74
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

		// Token: 0x04000BF7 RID: 3063
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.RoutedEventWrapper> _collection;

		// Token: 0x04000BF8 RID: 3064
		private bool _isCollectionDirty;

		// Token: 0x04000BF9 RID: 3065
		private global::Infragistics.Windows.Helpers.HashSet _hashSet;

		// Token: 0x04000BFA RID: 3066
		private global::Infragistics.Windows.DataPresenter.DataPresenterBase _dp;
	}
}
