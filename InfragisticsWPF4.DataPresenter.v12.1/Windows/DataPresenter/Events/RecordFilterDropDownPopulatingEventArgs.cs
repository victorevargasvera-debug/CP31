using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200029B RID: 667
	public class RecordFilterDropDownPopulatingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001E1E RID: 7710 RVA: 0x000816C2 File Offset: 0x0007F8C2
		private RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._includeUniqueValues = includeUniqueValues;
			this._raisedForCustomFilterSelectionControl = raisedForCustomFilterSelectionControl;
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x00081702 File Offset: 0x0007F902
		internal RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> dropDownItems, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, includeUniqueValues, raisedForCustomFilterSelectionControl)
		{
			this._dropDownItems = dropDownItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.DropDownItems;
		}

		// Token: 0x06001E20 RID: 7712 RVA: 0x0008171E File Offset: 0x0007F91E
		internal RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> menuItems, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, includeUniqueValues, raisedForCustomFilterSelectionControl)
		{
			this._menuItems = menuItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.MenuItems;
		}

		// Token: 0x1700084F RID: 2127
		// (get) Token: 0x06001E21 RID: 7713 RVA: 0x0008173A File Offset: 0x0007F93A
		// (set) Token: 0x06001E22 RID: 7714 RVA: 0x00081742 File Offset: 0x0007F942
		public int AsynchLoadDuration
		{
			get
			{
				return this._asynchLoadDuration;
			}
			set
			{
				this._asynchLoadDuration = value;
			}
		}

		// Token: 0x17000850 RID: 2128
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0008174B File Offset: 0x0007F94B
		// (set) Token: 0x06001E24 RID: 7716 RVA: 0x00081753 File Offset: 0x0007F953
		public int AsynchLoadInterval
		{
			get
			{
				return this._asynchLoadInterval;
			}
			set
			{
				this._asynchLoadInterval = value;
			}
		}

		// Token: 0x17000851 RID: 2129
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0008175C File Offset: 0x0007F95C
		// (set) Token: 0x06001E26 RID: 7718 RVA: 0x00081764 File Offset: 0x0007F964
		public int AsynchLoadThreshhold
		{
			get
			{
				return this._asynchLoadThreshhold;
			}
			set
			{
				this._asynchLoadThreshhold = value;
			}
		}

		// Token: 0x17000852 RID: 2130
		// (get) Token: 0x06001E27 RID: 7719 RVA: 0x0008176D File Offset: 0x0007F96D
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> DropDownItems
		{
			get
			{
				return this._dropDownItems;
			}
		}

		// Token: 0x17000853 RID: 2131
		// (get) Token: 0x06001E28 RID: 7720 RVA: 0x00081775 File Offset: 0x0007F975
		// (set) Token: 0x06001E29 RID: 7721 RVA: 0x0008177D File Offset: 0x0007F97D
		public bool IncludeUniqueValues
		{
			get
			{
				return this._includeUniqueValues;
			}
			set
			{
				this._includeUniqueValues = value;
			}
		}

		// Token: 0x17000854 RID: 2132
		// (get) Token: 0x06001E2A RID: 7722 RVA: 0x00081786 File Offset: 0x0007F986
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType ItemsType
		{
			get
			{
				return this._itemsType;
			}
		}

		// Token: 0x17000855 RID: 2133
		// (get) Token: 0x06001E2B RID: 7723 RVA: 0x0008178E File Offset: 0x0007F98E
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000856 RID: 2134
		// (get) Token: 0x06001E2C RID: 7724 RVA: 0x00081796 File Offset: 0x0007F996
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> MenuItems
		{
			get
			{
				return this._menuItems;
			}
		}

		// Token: 0x17000857 RID: 2135
		// (get) Token: 0x06001E2D RID: 7725 RVA: 0x0008179E File Offset: 0x0007F99E
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x17000858 RID: 2136
		// (get) Token: 0x06001E2E RID: 7726 RVA: 0x000817A6 File Offset: 0x0007F9A6
		public bool RaisedForCustomFilterSelectionControl
		{
			get
			{
				return this._raisedForCustomFilterSelectionControl;
			}
		}

		// Token: 0x04000ED4 RID: 3796
		internal const int DefaultAsynchLoadDuration = 50;

		// Token: 0x04000ED5 RID: 3797
		internal const int DefaultAsynchLoadInterval = 50;

		// Token: 0x04000ED6 RID: 3798
		internal const int DefaultAsynchLoadThreshhold = 1000;

		// Token: 0x04000ED7 RID: 3799
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _dropDownItems;

		// Token: 0x04000ED8 RID: 3800
		private bool _raisedForCustomFilterSelectionControl;

		// Token: 0x04000ED9 RID: 3801
		private bool _includeUniqueValues;

		// Token: 0x04000EDA RID: 3802
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04000EDB RID: 3803
		private int _asynchLoadDuration = 50;

		// Token: 0x04000EDC RID: 3804
		private int _asynchLoadInterval = 50;

		// Token: 0x04000EDD RID: 3805
		private int _asynchLoadThreshhold = 1000;

		// Token: 0x04000EDE RID: 3806
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType _itemsType;

		// Token: 0x04000EDF RID: 3807
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> _menuItems;

		// Token: 0x04000EE0 RID: 3808
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
