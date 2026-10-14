using System;
using System.Collections.Specialized;
using System.ComponentModel;

namespace Infragistics
{
	// Token: 0x02000046 RID: 70
	[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
	internal sealed class ItemSourceEventProxy
	{
		// Token: 0x060003CF RID: 975 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		public ItemSourceEventProxy(global::Infragistics.IFastItemsSource fastItemsSource)
		{
			this.FastItemsSource = new global::System.WeakReference(fastItemsSource);
			this.CollectionChanged = new global::System.Collections.Specialized.NotifyCollectionChangedEventHandler(this.collectionChanged);
			this.PropertyChanged = new global::System.ComponentModel.PropertyChangedEventHandler(this.propertyChanged);
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003D0 RID: 976 RVA: 0x0000F934 File Offset: 0x0000DB34
		// (set) Token: 0x060003D1 RID: 977 RVA: 0x0000F93C File Offset: 0x0000DB3C
		public global::System.WeakReference FastItemsSource { get; private set; }

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x060003D2 RID: 978 RVA: 0x0000F945 File Offset: 0x0000DB45
		// (set) Token: 0x060003D3 RID: 979 RVA: 0x0000F94D File Offset: 0x0000DB4D
		public global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged { get; private set; }

		// Token: 0x060003D4 RID: 980 RVA: 0x0000F958 File Offset: 0x0000DB58
		private void collectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.FastItemsSource.Target != null && this.WeakCollectionChanged != null)
			{
				global::Infragistics.IFastItemsSource fastItemsSource = this.FastItemsSource.Target as global::Infragistics.IFastItemsSource;
				if (fastItemsSource.Dispatcher == null || fastItemsSource.Dispatcher.CheckAccess())
				{
					this.WeakCollectionChanged(fastItemsSource, sender, e);
					return;
				}
				fastItemsSource.Dispatcher.BeginInvoke(new global::System.Action<global::Infragistics.IFastItemsSource, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs>(this.WeakCollectionChanged.Invoke), new object[]
				{
					fastItemsSource,
					sender,
					e
				});
			}
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x060003D5 RID: 981 RVA: 0x0000F9E0 File Offset: 0x0000DBE0
		// (set) Token: 0x060003D6 RID: 982 RVA: 0x0000F9E8 File Offset: 0x0000DBE8
		public global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged { get; private set; }

		// Token: 0x060003D7 RID: 983 RVA: 0x0000F9F4 File Offset: 0x0000DBF4
		private void propertyChanged(object sender, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			if (this.FastItemsSource.Target != null && this.WeakPropertyChanged != null)
			{
				global::Infragistics.IFastItemsSource fastItemsSource = this.FastItemsSource.Target as global::Infragistics.IFastItemsSource;
				if (fastItemsSource.Dispatcher == null || fastItemsSource.Dispatcher.CheckAccess())
				{
					this.WeakPropertyChanged(fastItemsSource, sender, e);
					return;
				}
				fastItemsSource.Dispatcher.BeginInvoke(new global::System.Action<global::Infragistics.IFastItemsSource, object, global::System.ComponentModel.PropertyChangedEventArgs>(this.WeakPropertyChanged.Invoke), new object[]
				{
					fastItemsSource,
					sender,
					e
				});
			}
		}

		// Token: 0x0400015F RID: 351
		public global::System.Action<global::Infragistics.IFastItemsSource, object, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs> WeakCollectionChanged;

		// Token: 0x04000160 RID: 352
		public global::System.Action<global::Infragistics.IFastItemsSource, object, global::System.ComponentModel.PropertyChangedEventArgs> WeakPropertyChanged;
	}
}
