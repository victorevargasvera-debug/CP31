using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200029A RID: 666
	public class RecordFilterDropDownOpeningEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E15 RID: 7701 RVA: 0x00081641 File Offset: 0x0007F841
		private RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, bool raisedForCustomFilterSelectionControl)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._raisedForCustomFilterSelectionControl = raisedForCustomFilterSelectionControl;
		}

		// Token: 0x06001E16 RID: 7702 RVA: 0x0008165E File Offset: 0x0007F85E
		internal RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> dropDownItems, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, raisedForCustomFilterSelectionControl)
		{
			this._dropDownItems = dropDownItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.DropDownItems;
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x00081678 File Offset: 0x0007F878
		internal RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> menuItems, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, raisedForCustomFilterSelectionControl)
		{
			this._menuItems = menuItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.MenuItems;
		}

		// Token: 0x17000849 RID: 2121
		// (get) Token: 0x06001E18 RID: 7704 RVA: 0x00081692 File Offset: 0x0007F892
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> DropDownItems
		{
			get
			{
				return this._dropDownItems;
			}
		}

		// Token: 0x1700084A RID: 2122
		// (get) Token: 0x06001E19 RID: 7705 RVA: 0x0008169A File Offset: 0x0007F89A
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x1700084B RID: 2123
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x000816A2 File Offset: 0x0007F8A2
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType ItemsType
		{
			get
			{
				return this._itemsType;
			}
		}

		// Token: 0x1700084C RID: 2124
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x000816AA File Offset: 0x0007F8AA
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> MenuItems
		{
			get
			{
				return this._menuItems;
			}
		}

		// Token: 0x1700084D RID: 2125
		// (get) Token: 0x06001E1C RID: 7708 RVA: 0x000816B2 File Offset: 0x0007F8B2
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x1700084E RID: 2126
		// (get) Token: 0x06001E1D RID: 7709 RVA: 0x000816BA File Offset: 0x0007F8BA
		public bool RaisedForCustomFilterSelectionControl
		{
			get
			{
				return this._raisedForCustomFilterSelectionControl;
			}
		}

		// Token: 0x04000ECE RID: 3790
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _dropDownItems;

		// Token: 0x04000ECF RID: 3791
		private bool _raisedForCustomFilterSelectionControl;

		// Token: 0x04000ED0 RID: 3792
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000ED1 RID: 3793
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x04000ED2 RID: 3794
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType _itemsType;

		// Token: 0x04000ED3 RID: 3795
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> _menuItems;
	}
}
