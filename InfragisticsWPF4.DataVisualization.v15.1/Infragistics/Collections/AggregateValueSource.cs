using System;
using System.Collections;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;

namespace Infragistics.Collections
{
	// Token: 0x02000005 RID: 5
	public class AggregateValueSource : global::System.Windows.DependencyObject, global::System.ComponentModel.INotifyPropertyChanged, global::System.Collections.Specialized.INotifyCollectionChanged
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600001A RID: 26 RVA: 0x00002607 File Offset: 0x00000807
		// (set) Token: 0x0600001B RID: 27 RVA: 0x00002619 File Offset: 0x00000819
		public global::System.Collections.IEnumerable ItemsSource
		{
			get
			{
				return base.GetValue(global::Infragistics.Collections.AggregateValueSource.ItemsSourceProperty) as global::System.Collections.IEnumerable;
			}
			set
			{
				base.SetValue(global::Infragistics.Collections.AggregateValueSource.ItemsSourceProperty, value);
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001C RID: 28 RVA: 0x00002627 File Offset: 0x00000827
		// (set) Token: 0x0600001D RID: 29 RVA: 0x00002639 File Offset: 0x00000839
		public string ValueMemberPath
		{
			get
			{
				return base.GetValue(global::Infragistics.Collections.AggregateValueSource.ValueMemberPathProperty) as string;
			}
			set
			{
				base.SetValue(global::Infragistics.Collections.AggregateValueSource.ValueMemberPathProperty, value);
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002647 File Offset: 0x00000847
		// (set) Token: 0x0600001F RID: 31 RVA: 0x0000264F File Offset: 0x0000084F
		internal global::Infragistics.IFastItemColumn<double> ValueColumn { get; private set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000020 RID: 32 RVA: 0x00002658 File Offset: 0x00000858
		// (set) Token: 0x06000021 RID: 33 RVA: 0x0000266A File Offset: 0x0000086A
		private global::Infragistics.IFastItemsSource FastItemsSource
		{
			get
			{
				return base.GetValue(global::Infragistics.Collections.AggregateValueSource.FastItemsSourceProperty) as global::Infragistics.IFastItemsSource;
			}
			set
			{
				base.SetValue(global::Infragistics.Collections.AggregateValueSource.FastItemsSourceProperty, value);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00002678 File Offset: 0x00000878
		private void HandleFastItemsSourceEvent(object sender, global::Infragistics.FastItemsSourceEventArgs e)
		{
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000023 RID: 35 RVA: 0x00002694 File Offset: 0x00000894
		// (remove) Token: 0x06000024 RID: 36 RVA: 0x000026CC File Offset: 0x000008CC
		public event global::System.ComponentModel.PropertyChangedEventHandler PropertyChanged;

		// Token: 0x06000025 RID: 37 RVA: 0x00002704 File Offset: 0x00000904
		private void OnPropertyChanged(string propertyName, object oldValue, object newValue)
		{
			if (propertyName != null)
			{
				if (!(propertyName == "ItemsSource"))
				{
					if (!(propertyName == "FastItemsSource"))
					{
						if (propertyName == "ValueMemberPath")
						{
							if (this.FastItemsSource != null)
							{
								this.FastItemsSource.DeregisterColumn(this.ValueColumn);
								this.ValueColumn = this.FastItemsSource.RegisterColumn(this.ValueMemberPath);
							}
						}
					}
					else
					{
						global::Infragistics.IFastItemsSource fastItemsSource = oldValue as global::Infragistics.IFastItemsSource;
						if (fastItemsSource != null)
						{
							fastItemsSource.Event -= this.HandleFastItemsSourceEvent;
							fastItemsSource.DeregisterColumn(this.ValueColumn);
							this.ValueColumn = null;
						}
						global::Infragistics.IFastItemsSource fastItemsSource2 = newValue as global::Infragistics.IFastItemsSource;
						if (fastItemsSource2 != null)
						{
							fastItemsSource2.Event += this.HandleFastItemsSourceEvent;
							this.ValueColumn = fastItemsSource2.RegisterColumn(this.ValueMemberPath);
						}
					}
				}
				else
				{
					this.FastItemsSource = new global::Infragistics.FastItemsSource
					{
						ItemsSource = this.ItemsSource
					};
				}
			}
			if (this.PropertyChanged != null)
			{
				this.PropertyChanged(this, new global::System.ComponentModel.PropertyChangedEventArgs(propertyName));
			}
			if (this.CollectionChanged != null)
			{
				this.CollectionChanged(this, new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Reset));
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000026 RID: 38 RVA: 0x0000282C File Offset: 0x00000A2C
		// (remove) Token: 0x06000027 RID: 39 RVA: 0x00002864 File Offset: 0x00000A64
		public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

		// Token: 0x04000008 RID: 8
		private const string ItemsSourcePropertyName = "ItemsSource";

		// Token: 0x04000009 RID: 9
		private const string ValueMemberPathPropertyName = "ValueMemberPath";

		// Token: 0x0400000A RID: 10
		private const string FastItemsSourcePropertyName = "FastItemsSource";

		// Token: 0x0400000B RID: 11
		public static readonly global::System.Windows.DependencyProperty ItemsSourceProperty = global::System.Windows.DependencyProperty.Register("ItemsSource", typeof(global::System.Collections.IEnumerable), typeof(global::Infragistics.Collections.AggregateValueSource), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Collections.AggregateValueSource).OnPropertyChanged("ItemsSource", e.OldValue, e.NewValue);
		}));

		// Token: 0x0400000C RID: 12
		public static readonly global::System.Windows.DependencyProperty ValueMemberPathProperty = global::System.Windows.DependencyProperty.Register("ValueMemberPath", typeof(string), typeof(global::Infragistics.Collections.AggregateValueSource), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Collections.AggregateValueSource).OnPropertyChanged("ValueMemberPath", e.OldValue, e.NewValue);
		}));

		// Token: 0x0400000D RID: 13
		private static readonly global::System.Windows.DependencyProperty FastItemsSourceProperty = global::System.Windows.DependencyProperty.Register("FastItemsSource", typeof(global::Infragistics.IFastItemsSource), typeof(global::Infragistics.Collections.AggregateValueSource), new global::System.Windows.PropertyMetadata(null, delegate(global::System.Windows.DependencyObject sender, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			(sender as global::Infragistics.Collections.AggregateValueSource).OnPropertyChanged("FastItemsSource", e.OldValue, e.NewValue);
		}));
	}
}
