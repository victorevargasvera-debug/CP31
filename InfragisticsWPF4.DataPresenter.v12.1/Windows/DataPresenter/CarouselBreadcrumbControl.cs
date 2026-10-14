using System;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004B RID: 75
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselBreadcrumbControl : global::System.Windows.Controls.Control
	{
		// Token: 0x06000366 RID: 870 RVA: 0x0000CBFC File Offset: 0x0000ADFC
		static CarouselBreadcrumbControl()
		{
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CarouselBreadcrumbClick", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl)));
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0000CCF2 File Offset: 0x0000AEF2
		public CarouselBreadcrumbControl()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsPropertyKey, new global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb>(), this));
			((global::System.Collections.Specialized.INotifyCollectionChanged)this.Breadcrumbs).CollectionChanged += this.OnBreadcrumbCollectionChanged;
		}

		// Token: 0x170000E3 RID: 227
		// (get) Token: 0x06000368 RID: 872 RVA: 0x0000CD27 File Offset: 0x0000AF27
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection Breadcrumbs
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsProperty);
			}
		}

		// Token: 0x170000E4 RID: 228
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0000CD39 File Offset: 0x0000AF39
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool HasCrumbs
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsProperty);
			}
		}

		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x0600036A RID: 874 RVA: 0x0000CD4B File Offset: 0x0000AF4B
		// (set) Token: 0x0600036B RID: 875 RVA: 0x0000CD5D File Offset: 0x0000AF5D
		[global::System.ComponentModel.Bindable(true)]
		public global::System.Windows.Controls.Orientation Orientation
		{
			get
			{
				return (global::System.Windows.Controls.Orientation)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.OrientationProperty);
			}
			set
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.OrientationProperty, value);
			}
		}

		// Token: 0x0600036C RID: 876 RVA: 0x0000CD70 File Offset: 0x0000AF70
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb PopBreadcrumb()
		{
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb result = this.Breadcrumbs.Pop();
			if (this.Breadcrumbs.Count > 0)
			{
				this.Breadcrumbs[this.Breadcrumbs.Count - 1].SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			return result;
		}

		// Token: 0x0600036D RID: 877 RVA: 0x0000CDC0 File Offset: 0x0000AFC0
		public int PopBreadcrumbsUpTo(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb carouselBreadcrumb = this.Breadcrumbs.Peek();
			int num = 0;
			while (carouselBreadcrumb != breadcrumb)
			{
				this.PopBreadcrumb();
				num++;
				carouselBreadcrumb = this.Breadcrumbs.Peek();
			}
			return num;
		}

		// Token: 0x0600036E RID: 878 RVA: 0x0000CDFC File Offset: 0x0000AFFC
		public void PushBreadcrumb(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			if (breadcrumb == null)
			{
				throw new global::System.ArgumentNullException("breadcrumb", global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_ArgumentNullException_1"));
			}
			breadcrumb.ParentCollection = this.Breadcrumbs;
			this.Breadcrumbs.Push(breadcrumb);
			if (this.Breadcrumbs.Count > 1)
			{
				this.Breadcrumbs[this.Breadcrumbs.Count - 2].SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x0000CE70 File Offset: 0x0000B070
		private void OnBreadcrumbCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (this.Breadcrumbs.Count < 1)
			{
				if (this.HasCrumbs)
				{
					base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsPropertyKey, global::Infragistics.KnownBoxes.FalseBox);
					return;
				}
			}
			else if (!this.HasCrumbs)
			{
				base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
		}

		// Token: 0x06000370 RID: 880 RVA: 0x0000CEBC File Offset: 0x0000B0BC
		protected virtual void OnCarouselBreadcrumbClick(global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x0000CEC5 File Offset: 0x0000B0C5
		internal void RaiseCarouselBreadcrumbClick(global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent;
			args.Source = this;
			this.OnCarouselBreadcrumbClick(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x06000372 RID: 882 RVA: 0x0000CEE0 File Offset: 0x0000B0E0
		// (remove) Token: 0x06000373 RID: 883 RVA: 0x0000CEEE File Offset: 0x0000B0EE
		public event global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs> CarouselBreadcrumbClick
		{
			add
			{
				base.AddHandler(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent, value);
			}
			remove
			{
				base.RemoveHandler(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent, value);
			}
		}

		// Token: 0x040000DE RID: 222
		private static readonly global::System.Windows.DependencyPropertyKey BreadcrumbsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Breadcrumbs", typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040000DF RID: 223
		public static readonly global::System.Windows.DependencyProperty BreadcrumbsProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsPropertyKey.DependencyProperty;

		// Token: 0x040000E0 RID: 224
		private static readonly global::System.Windows.DependencyPropertyKey HasCrumbsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasCrumbs", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040000E1 RID: 225
		public static readonly global::System.Windows.DependencyProperty HasCrumbsProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsPropertyKey.DependencyProperty;

		// Token: 0x040000E2 RID: 226
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal));
	}
}
