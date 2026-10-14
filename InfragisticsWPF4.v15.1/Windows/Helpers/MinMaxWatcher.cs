using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000197 RID: 407
	internal class MinMaxWatcher : global::System.Windows.DependencyObject
	{
		// Token: 0x06000D9B RID: 3483 RVA: 0x0002CB24 File Offset: 0x0002AD24
		internal MinMaxWatcher(global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner owner, global::System.Windows.FrameworkElement element)
		{
			if (owner == null)
			{
				throw new global::System.ArgumentNullException("owner");
			}
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Helpers.MinMaxWatcher.MinWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinWidthProperty, global::System.Windows.Data.BindingMode.OneWay, element));
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxWidthProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxWidthProperty, global::System.Windows.Data.BindingMode.OneWay, element));
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Helpers.MinMaxWatcher.MinHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinHeightProperty, global::System.Windows.Data.BindingMode.OneWay, element));
			global::System.Windows.Data.BindingOperations.SetBinding(this, global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxHeightProperty, global::Infragistics.Windows.Utilities.CreateBindingObject(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxHeightProperty, global::System.Windows.Data.BindingMode.OneWay, element));
			this._owner = owner;
			this._element = element;
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x06000D9C RID: 3484 RVA: 0x0002CBC1 File Offset: 0x0002ADC1
		public global::System.Windows.FrameworkElement Element
		{
			get
			{
				return this._element;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x06000D9D RID: 3485 RVA: 0x0002CBC9 File Offset: 0x0002ADC9
		// (set) Token: 0x06000D9E RID: 3486 RVA: 0x0002CBDB File Offset: 0x0002ADDB
		internal double MinWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinWidthProperty, value);
			}
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x06000D9F RID: 3487 RVA: 0x0002CBEE File Offset: 0x0002ADEE
		// (set) Token: 0x06000DA0 RID: 3488 RVA: 0x0002CC00 File Offset: 0x0002AE00
		internal double MaxWidth
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxWidthProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxWidthProperty, value);
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x06000DA1 RID: 3489 RVA: 0x0002CC13 File Offset: 0x0002AE13
		// (set) Token: 0x06000DA2 RID: 3490 RVA: 0x0002CC25 File Offset: 0x0002AE25
		internal double MinHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MinHeightProperty, value);
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x06000DA3 RID: 3491 RVA: 0x0002CC38 File Offset: 0x0002AE38
		// (set) Token: 0x06000DA4 RID: 3492 RVA: 0x0002CC4A File Offset: 0x0002AE4A
		internal double MaxHeight
		{
			get
			{
				return (double)base.GetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxHeightProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.Helpers.MinMaxWatcher.MaxHeightProperty, value);
			}
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x0002CC5D File Offset: 0x0002AE5D
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (this._owner != null)
			{
				this._owner.OnMinMaxChanged(this);
			}
		}

		// Token: 0x0400067C RID: 1660
		private global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner _owner;

		// Token: 0x0400067D RID: 1661
		private global::System.Windows.FrameworkElement _element;

		// Token: 0x0400067E RID: 1662
		internal static readonly global::System.Windows.DependencyProperty MinWidthProperty = global::System.Windows.FrameworkElement.MinWidthProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x0400067F RID: 1663
		internal static readonly global::System.Windows.DependencyProperty MaxWidthProperty = global::System.Windows.FrameworkElement.MaxWidthProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x04000680 RID: 1664
		internal static readonly global::System.Windows.DependencyProperty MinHeightProperty = global::System.Windows.FrameworkElement.MinHeightProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x04000681 RID: 1665
		internal static readonly global::System.Windows.DependencyProperty MaxHeightProperty = global::System.Windows.FrameworkElement.MaxHeightProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));
	}
}
