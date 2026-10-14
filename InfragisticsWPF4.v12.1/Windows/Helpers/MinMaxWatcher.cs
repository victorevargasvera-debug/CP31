using System;
using System.Windows;
using System.Windows.Data;

namespace Infragistics.Windows.Helpers
{
	// Token: 0x02000175 RID: 373
	internal class MinMaxWatcher : global::System.Windows.DependencyObject
	{
		// Token: 0x06000C86 RID: 3206 RVA: 0x0002899C File Offset: 0x00026B9C
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

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000C87 RID: 3207 RVA: 0x00028A39 File Offset: 0x00026C39
		public global::System.Windows.FrameworkElement Element
		{
			get
			{
				return this._element;
			}
		}

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000C88 RID: 3208 RVA: 0x00028A41 File Offset: 0x00026C41
		// (set) Token: 0x06000C89 RID: 3209 RVA: 0x00028A53 File Offset: 0x00026C53
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

		// Token: 0x17000268 RID: 616
		// (get) Token: 0x06000C8A RID: 3210 RVA: 0x00028A66 File Offset: 0x00026C66
		// (set) Token: 0x06000C8B RID: 3211 RVA: 0x00028A78 File Offset: 0x00026C78
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

		// Token: 0x17000269 RID: 617
		// (get) Token: 0x06000C8C RID: 3212 RVA: 0x00028A8B File Offset: 0x00026C8B
		// (set) Token: 0x06000C8D RID: 3213 RVA: 0x00028A9D File Offset: 0x00026C9D
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

		// Token: 0x1700026A RID: 618
		// (get) Token: 0x06000C8E RID: 3214 RVA: 0x00028AB0 File Offset: 0x00026CB0
		// (set) Token: 0x06000C8F RID: 3215 RVA: 0x00028AC2 File Offset: 0x00026CC2
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

		// Token: 0x06000C90 RID: 3216 RVA: 0x00028AD5 File Offset: 0x00026CD5
		protected override void OnPropertyChanged(global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (this._owner != null)
			{
				this._owner.OnMinMaxChanged(this);
			}
		}

		// Token: 0x040005B7 RID: 1463
		private global::Infragistics.Windows.Helpers.IMinMaxWatcherOwner _owner;

		// Token: 0x040005B8 RID: 1464
		private global::System.Windows.FrameworkElement _element;

		// Token: 0x040005B9 RID: 1465
		internal static readonly global::System.Windows.DependencyProperty MinWidthProperty = global::System.Windows.FrameworkElement.MinWidthProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x040005BA RID: 1466
		internal static readonly global::System.Windows.DependencyProperty MaxWidthProperty = global::System.Windows.FrameworkElement.MaxWidthProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x040005BB RID: 1467
		internal static readonly global::System.Windows.DependencyProperty MinHeightProperty = global::System.Windows.FrameworkElement.MinHeightProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));

		// Token: 0x040005BC RID: 1468
		internal static readonly global::System.Windows.DependencyProperty MaxHeightProperty = global::System.Windows.FrameworkElement.MaxHeightProperty.AddOwner(typeof(global::Infragistics.Windows.Helpers.MinMaxWatcher));
	}
}
