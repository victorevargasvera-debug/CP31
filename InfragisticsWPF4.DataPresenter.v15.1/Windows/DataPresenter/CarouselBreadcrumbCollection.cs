using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200004A RID: 74
	public class CarouselBreadcrumbCollection : global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb>
	{
		// Token: 0x0600037E RID: 894 RVA: 0x0000D594 File Offset: 0x0000B794
		internal CarouselBreadcrumbCollection(global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb> list, global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl breadcrumbControl) : base(list)
		{
			this._breadcrumbControl = breadcrumbControl;
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600037F RID: 895 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl BreadcrumbControl
		{
			get
			{
				return this._breadcrumbControl;
			}
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0000D5AC File Offset: 0x0000B7AC
		internal global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb Peek()
		{
			if (base.Items.Count < 1)
			{
				return null;
			}
			return base.Items[base.Items.Count - 1];
		}

		// Token: 0x06000381 RID: 897 RVA: 0x0000D5D8 File Offset: 0x0000B7D8
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

		// Token: 0x06000382 RID: 898 RVA: 0x0000D627 File Offset: 0x0000B827
		internal void Push(global::Infragistics.Windows.DataPresenter.CarouselBreadcrumb breadcrumb)
		{
			base.Items.Add(breadcrumb);
		}

		// Token: 0x040000F0 RID: 240
		private global::Infragistics.Windows.DataPresenter.CarouselBreadcrumbControl _breadcrumbControl;
	}
}
