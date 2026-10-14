using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004A RID: 74
	public class CarouselBreadcrumbCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb>
	{
		// Token: 0x06000361 RID: 865 RVA: 0x0000CB58 File Offset: 0x0000AD58
		internal CarouselBreadcrumbCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb> list, global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl breadcrumbControl) : base(list)
		{
			this._breadcrumbControl = breadcrumbControl;
		}

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000362 RID: 866 RVA: 0x0000CB68 File Offset: 0x0000AD68
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl BreadcrumbControl
		{
			get
			{
				return this._breadcrumbControl;
			}
		}

		// Token: 0x06000363 RID: 867 RVA: 0x0000CB70 File Offset: 0x0000AD70
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb Peek()
		{
			if (base.Items.Count < 1)
			{
				return null;
			}
			return base.Items[base.Items.Count - 1];
		}

		// Token: 0x06000364 RID: 868 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb Pop()
		{
			if (base.Items.Count < 1)
			{
				return null;
			}
			global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb result = base.Items[base.Items.Count - 1];
			base.Items.RemoveAt(base.Items.Count - 1);
			return result;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x0000CBEB File Offset: 0x0000ADEB
		internal void Push(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			base.Items.Add(breadcrumb);
		}

		// Token: 0x040000DD RID: 221
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl _breadcrumbControl;
	}
}
