using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B1 RID: 689
	public class CarouselBreadcrumbClickEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060021FF RID: 8703 RVA: 0x0009756C File Offset: 0x0009576C
		internal CarouselBreadcrumbClickEventArgs(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			this._breadcrumb = breadcrumb;
		}

		// Token: 0x1700099D RID: 2461
		// (get) Token: 0x06002200 RID: 8704 RVA: 0x0009757B File Offset: 0x0009577B
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb Breadcrumb
		{
			get
			{
				return this._breadcrumb;
			}
		}

		// Token: 0x040010EB RID: 4331
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb _breadcrumb;
	}
}
