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
		// Token: 0x06000359 RID: 857 RVA: 0x0000CA84 File Offset: 0x0000AC84
		static CarouselBreadcrumb()
		{
			global::System.Windows.FrameworkElement.DefaultStyleKeyProperty.OverrideMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb), new global::System.Windows.FrameworkPropertyMetadata(typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb)));
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000CAF0 File Offset: 0x0000ACF0
		public CarouselBreadcrumb(object item)
		{
			base.Content = item;
		}

		// Token: 0x0600035B RID: 859 RVA: 0x0000CAFF File Offset: 0x0000ACFF
		protected override global::System.Windows.Automation.Peers.AutomationPeer OnCreateAutomationPeer()
		{
			return new global::Infragistics.Windows.Automation.Peers.DataPresenter.CarouselBreadcrumbAutomationPeer(this);
		}

		// Token: 0x0600035C RID: 860 RVA: 0x0000CB07 File Offset: 0x0000AD07
		protected override void OnMouseLeftButtonUp(global::System.Windows.Input.MouseButtonEventArgs e)
		{
			base.OnMouseLeftButtonUp(e);
			this.OnCarouselBreadcrumbClick();
			e.Handled = true;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0000CB1D File Offset: 0x0000AD1D
		[global::System.ComponentModel.Bindable(true)]
		[global::System.ComponentModel.ReadOnly(true)]
		public bool IsLastBreadcrumb
		{
			get
			{
				return (bool)base.GetValue(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbProperty);
			}
		}

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600035E RID: 862 RVA: 0x0000CB2F File Offset: 0x0000AD2F
		// (set) Token: 0x0600035F RID: 863 RVA: 0x0000CB37 File Offset: 0x0000AD37
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

		// Token: 0x06000360 RID: 864 RVA: 0x0000CB40 File Offset: 0x0000AD40
		internal void OnCarouselBreadcrumbClick()
		{
			this._parentCollection.BreadcrumbControl.RaiseCarouselBreadcrumbClick(new global::Infragistics.Windows.DataPresenter.Events.CarouselBreadcrumbClickEventArgs(this));
		}

		// Token: 0x040000DA RID: 218
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbCollection _parentCollection;

		// Token: 0x040000DB RID: 219
		internal static readonly global::System.Windows.DependencyPropertyKey IsLastBreadcrumbPropertyKey = global::System.Windows.DependencyProperty.RegisterReadOnly("IsLastBreadcrumb", typeof(bool), typeof(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb), new global::System.Windows.FrameworkPropertyMetadata(global::Infragistics.KnownBoxes.TrueBox));

		// Token: 0x040000DC RID: 220
		public static readonly global::System.Windows.DependencyProperty IsLastBreadcrumbProperty = global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb.IsLastBreadcrumbPropertyKey.DependencyProperty;
	}
}
