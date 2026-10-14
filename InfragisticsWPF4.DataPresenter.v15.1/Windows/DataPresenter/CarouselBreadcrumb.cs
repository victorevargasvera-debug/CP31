using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Automation.Peers;
using System.Windows.Controls;
using System.Windows.Input;
using Infragistics.Windows.Automation.Peers.DataPresenter;
using Infragistics.Windows.DataPresenter.Events;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000049 RID: 73
	[global::System.ComponentModel.DesignTimeVisible(false)]
	public class CarouselBreadcrumb : global::System.Windows.Controls.ContentControl
	{
		// Token: 0x06000376 RID: 886 RVA: 0x0000D4C0 File Offset: 0x0000B6C0
		static CarouselBreadcrumb()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb)));
		}

		// Token: 0x06000377 RID: 887 RVA: 0x0000D52C File Offset: 0x0000B72C
		public CarouselBreadcrumb(object item)
		{
			base.Content = item;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0000D53B File Offset: 0x0000B73B
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CarouselBreadcrumbAutomationPeer(this);
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0000D543 File Offset: 0x0000B743
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.OnCarouselBreadcrumbClick();
			e.Handled = true;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x0600037A RID: 890 RVA: 0x0000D559 File Offset: 0x0000B759
		[global::System.ComponentModel.ReadOnly(true)]
		[global::System.ComponentModel.Bindable(true)]
		public bool IsLastBreadcrumb
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbProperty);
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0000D56B File Offset: 0x0000B76B
		// (set) Token: 0x0600037C RID: 892 RVA: 0x0000D573 File Offset: 0x0000B773
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection ParentCollection
		{
			get
			{
				return this._parentCollection;
			}
			set
			{
				this._parentCollection = value;
			}
		}

		// Token: 0x0600037D RID: 893 RVA: 0x0000D57C File Offset: 0x0000B77C
		internal void OnCarouselBreadcrumbClick()
		{
			this._parentCollection.BreadcrumbControl.RaiseCarouselBreadcrumbClick(new global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs(this));
		}

		// Token: 0x040000ED RID: 237
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection _parentCollection;

		// Token: 0x040000EE RID: 238
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastBreadcrumbPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLastBreadcrumb", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040000EF RID: 239
		public static readonly global::System.Windows.DependencyProperty IsLastBreadcrumbProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbPropertyKey.DependencyProperty;
	}
}
