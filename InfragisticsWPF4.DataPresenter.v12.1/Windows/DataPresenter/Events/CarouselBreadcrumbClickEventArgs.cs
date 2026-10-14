using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200026E RID: 622
	public class CarouselBreadcrumbClickEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D7B RID: 7547 RVA: 0x00080E0C File Offset: 0x0007F00C
		internal CarouselBreadcrumbClickEventArgs(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			this._breadcrumb = breadcrumb;
		}

		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00080E1B File Offset: 0x0007F01B
		public global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb Breadcrumb
		{
			get
			{
				return this._breadcrumb;
			}
		}

		// Token: 0x04000E84 RID: 3716
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb _breadcrumb;
	}
}
