using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DD RID: 733
	public class RecordFilterDropDownOpeningEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600229D RID: 8861 RVA: 0x00097DD5 File Offset: 0x00095FD5
		private RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, bool raisedForCustomFilterSelectionControl)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._raisedForCustomFilterSelectionControl = raisedForCustomFilterSelectionControl;
		}

		// Token: 0x0600229E RID: 8862 RVA: 0x00097DF2 File Offset: 0x00095FF2
		internal RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> dropDownItems, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, raisedForCustomFilterSelectionControl)
		{
			this._dropDownItems = dropDownItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.DropDownItems;
		}

		// Token: 0x0600229F RID: 8863 RVA: 0x00097E0C File Offset: 0x0009600C
		internal RecordFilterDropDownOpeningEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> menuItems, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, raisedForCustomFilterSelectionControl)
		{
			this._menuItems = menuItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.MenuItems;
		}

		// Token: 0x170009F5 RID: 2549
		// (get) Token: 0x060022A0 RID: 8864 RVA: 0x00097E26 File Offset: 0x00096026
		public global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> DropDownItems
		{
			get
			{
				return this._dropDownItems;
			}
		}

		// Token: 0x170009F6 RID: 2550
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x00097E2E File Offset: 0x0009602E
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x170009F7 RID: 2551
		// (get) Token: 0x060022A2 RID: 8866 RVA: 0x00097E36 File Offset: 0x00096036
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType ItemsType
		{
			get
			{
				return this._itemsType;
			}
		}

		// Token: 0x170009F8 RID: 2552
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x00097E3E File Offset: 0x0009603E
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> MenuItems
		{
			get
			{
				return this._menuItems;
			}
		}

		// Token: 0x170009F9 RID: 2553
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x00097E46 File Offset: 0x00096046
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x170009FA RID: 2554
		// (get) Token: 0x060022A5 RID: 8869 RVA: 0x00097E4E File Offset: 0x0009604E
		public bool RaisedForCustomFilterSelectionControl
		{
			get
			{
				return this._raisedForCustomFilterSelectionControl;
			}
		}

		// Token: 0x04001138 RID: 4408
		private global::System.Collections.ObjectModel.ObservableCollection<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _dropDownItems;

		// Token: 0x04001139 RID: 4409
		private bool _raisedForCustomFilterSelectionControl;

		// Token: 0x0400113A RID: 4410
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x0400113B RID: 4411
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;

		// Token: 0x0400113C RID: 4412
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType _itemsType;

		// Token: 0x0400113D RID: 4413
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> _menuItems;
	}
}
