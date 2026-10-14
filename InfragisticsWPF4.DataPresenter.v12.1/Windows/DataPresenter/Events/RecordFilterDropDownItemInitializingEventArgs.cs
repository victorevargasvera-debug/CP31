using System;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000299 RID: 665
	public class RecordFilterDropDownItemInitializingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E11 RID: 7697 RVA: 0x0008160C File Offset: 0x0007F80C
		internal RecordFilterDropDownItemInitializingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._dropDownItem = dropDownItem;
		}

		// Token: 0x17000846 RID: 2118
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x00081629 File Offset: 0x0007F829
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItem DropDownItem
		{
			get
			{
				return this._dropDownItem;
			}
		}

		// Token: 0x17000847 RID: 2119
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x00081631 File Offset: 0x0007F831
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000848 RID: 2120
		// (get) Token: 0x06001E14 RID: 7700 RVA: 0x00081639 File Offset: 0x0007F839
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x04000ECB RID: 3787
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItem _dropDownItem;

		// Token: 0x04000ECC RID: 3788
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000ECD RID: 3789
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
