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
		// Token: 0x06000383 RID: 899 RVA: 0x0000D638 File Offset: 0x0000B838
		static CarouselBreadcrumbControl()
		{
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent = global::System.Windows.EventManager.RegisterRoutedEvent("CarouselBreadcrumbClick", global::System.Windows.RoutingStrategy.Bubble, typeof(global::System.EventHandler<global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs>), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl));
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl)));
		}

		// Token: 0x06000384 RID: 900 RVA: 0x0000D72E File Offset: 0x0000B92E
		public CarouselBreadcrumbControl()
		{
			base.SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsPropertyKey, new global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection(new global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb>(), this));
			((global::System.Collections.Specialized.INotifyCollectionChanged)this.Breadcrumbs).CollectionChanged += this.OnBreadcrumbCollectionChanged;
		}

		// Token: 0x170000EF RID: 239
		// (get) Token: 0x06000385 RID: 901 RVA: 0x0000D763 File Offset: 0x0000B963
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection Breadcrumbs
		{
			get
			{
				return (global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsProperty);
			}
		}

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000386 RID: 902 RVA: 0x0000D775 File Offset: 0x0000B975
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool HasCrumbs
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsProperty);
			}
		}

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000387 RID: 903 RVA: 0x0000D787 File Offset: 0x0000B987
		// (set) Token: 0x06000388 RID: 904 RVA: 0x0000D799 File Offset: 0x0000B999
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

		// Token: 0x06000389 RID: 905 RVA: 0x0000D7AC File Offset: 0x0000B9AC
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb PopBreadcrumb()
		{
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb result = this.Breadcrumbs.Pop();
			if (this.Breadcrumbs.Count > 0)
			{
				this.Breadcrumbs[this.Breadcrumbs.Count - 1].SetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbPropertyKey, global::Infragistics.KnownBoxes.TrueBox);
			}
			return result;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x0000D7FC File Offset: 0x0000B9FC
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

		// Token: 0x0600038B RID: 907 RVA: 0x0000D838 File Offset: 0x0000BA38
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

		// Token: 0x0600038C RID: 908 RVA: 0x0000D8AC File Offset: 0x0000BAAC
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

		// Token: 0x0600038D RID: 909 RVA: 0x0000D8F8 File Offset: 0x0000BAF8
		protected virtual void OnCarouselBreadcrumbClick(global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs args)
		{
			base.RaiseEvent(args);
		}

		// Token: 0x0600038E RID: 910 RVA: 0x0000D901 File Offset: 0x0000BB01
		internal void RaiseCarouselBreadcrumbClick(global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs args)
		{
			args.RoutedEvent = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.CarouselBreadcrumbClickEvent;
			args.Source = this;
			this.OnCarouselBreadcrumbClick(args);
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600038F RID: 911 RVA: 0x0000D91C File Offset: 0x0000BB1C
		// (remove) Token: 0x06000390 RID: 912 RVA: 0x0000D92A File Offset: 0x0000BB2A
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

		// Token: 0x040000F1 RID: 241
		private static readonly global::System.Windows.DependencyPropertyKey BreadcrumbsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("Breadcrumbs", typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(null));

		// Token: 0x040000F2 RID: 242
		public static readonly global::System.Windows.DependencyProperty BreadcrumbsProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.BreadcrumbsPropertyKey.DependencyProperty;

		// Token: 0x040000F3 RID: 243
		private static readonly global::System.Windows.DependencyPropertyKey HasCrumbsPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("HasCrumbs", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.FalseBox));

		// Token: 0x040000F4 RID: 244
		public static readonly global::System.Windows.DependencyProperty HasCrumbsProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl.HasCrumbsPropertyKey.DependencyProperty;

		// Token: 0x040000F5 RID: 245
		public static readonly global::System.Windows.DependencyProperty OrientationProperty = global::System.Windows.DependencyProperty.Register("Orientation", typeof(global::System.Windows.Controls.Orientation), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl), new global::System.Windows.FrameworkPropertyMetadata(global::System.Windows.Controls.Orientation.Horizontal));
	}
}
