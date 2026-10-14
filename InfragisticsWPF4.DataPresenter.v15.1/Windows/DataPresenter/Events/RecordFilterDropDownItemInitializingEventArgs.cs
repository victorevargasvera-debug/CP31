using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DC RID: 732
	public class RecordFilterDropDownItemInitializingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002299 RID: 8857 RVA: 0x00097DA0 File Offset: 0x00095FA0
		internal RecordFilterDropDownItemInitializingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._dropDownItem = dropDownItem;
		}

		// Token: 0x170009F2 RID: 2546
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x00097DBD File Offset: 0x00095FBD
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItem DropDownItem
		{
			get
			{
				return this._dropDownItem;
			}
		}

		// Token: 0x170009F3 RID: 2547
		// (get) Token: 0x0600229B RID: 8859 RVA: 0x00097DC5 File Offset: 0x00095FC5
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009F4 RID: 2548
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x00097DCD File Offset: 0x00095FCD
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x04001135 RID: 4405
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x04001136 RID: 4406
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001137 RID: 4407
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
