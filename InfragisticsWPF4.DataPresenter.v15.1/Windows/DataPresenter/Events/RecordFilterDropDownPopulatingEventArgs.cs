using System;
using System.Collections.Generic;
using System.Windows;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002DE RID: 734
	public class RecordFilterDropDownPopulatingEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060022A6 RID: 8870 RVA: 0x00097E56 File Offset: 0x00096056
		private RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl)
		{
			this._field = field;
			this._recordManager = recordManager;
			this._includeUniqueValues = includeUniqueValues;
			this._raisedForCustomFilterSelectionControl = raisedForCustomFilterSelectionControl;
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00097E96 File Offset: 0x00096096
		internal RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> dropDownItems, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, includeUniqueValues, raisedForCustomFilterSelectionControl)
		{
			this._dropDownItems = dropDownItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.DropDownItems;
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00097EB2 File Offset: 0x000960B2
		internal RecordFilterDropDownPopulatingEventArgs(global::Infragistics.Windows.DataPresenter.Field field, global::Infragistics.Windows.DataPresenter.RecordManager recordManager, global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> menuItems, bool includeUniqueValues, bool raisedForCustomFilterSelectionControl) : this(field, recordManager, includeUniqueValues, raisedForCustomFilterSelectionControl)
		{
			this._menuItems = menuItems;
			this._itemsType = global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType.MenuItems;
		}

		// Token: 0x170009FB RID: 2555
		// (get) Token: 0x060022A9 RID: 8873 RVA: 0x00097ECE File Offset: 0x000960CE
		// (set) Token: 0x060022AA RID: 8874 RVA: 0x00097ED6 File Offset: 0x000960D6
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

		// Token: 0x170009FC RID: 2556
		// (get) Token: 0x060022AB RID: 8875 RVA: 0x00097EDF File Offset: 0x000960DF
		// (set) Token: 0x060022AC RID: 8876 RVA: 0x00097EE7 File Offset: 0x000960E7
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

		// Token: 0x170009FD RID: 2557
		// (get) Token: 0x060022AD RID: 8877 RVA: 0x00097EF0 File Offset: 0x000960F0
		// (set) Token: 0x060022AE RID: 8878 RVA: 0x00097EF8 File Offset: 0x000960F8
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

		// Token: 0x170009FE RID: 2558
		// (get) Token: 0x060022AF RID: 8879 RVA: 0x00097F01 File Offset: 0x00096101
		public global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> DropDownItems
		{
			get
			{
				return this._dropDownItems;
			}
		}

		// Token: 0x170009FF RID: 2559
		// (get) Token: 0x060022B0 RID: 8880 RVA: 0x00097F09 File Offset: 0x00096109
		// (set) Token: 0x060022B1 RID: 8881 RVA: 0x00097F11 File Offset: 0x00096111
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

		// Token: 0x17000A00 RID: 2560
		// (get) Token: 0x060022B2 RID: 8882 RVA: 0x00097F1A File Offset: 0x0009611A
		public global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType ItemsType
		{
			get
			{
				return this._itemsType;
			}
		}

		// Token: 0x17000A01 RID: 2561
		// (get) Token: 0x060022B3 RID: 8883 RVA: 0x00097F22 File Offset: 0x00096122
		public global::Infragistics.Windows.DataPresenter.Field Field
		{
			get
			{
				return this._field;
			}
		}

		// Token: 0x17000A02 RID: 2562
		// (get) Token: 0x060022B4 RID: 8884 RVA: 0x00097F2A File Offset: 0x0009612A
		public global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> MenuItems
		{
			get
			{
				return this._menuItems;
			}
		}

		// Token: 0x17000A03 RID: 2563
		// (get) Token: 0x060022B5 RID: 8885 RVA: 0x00097F32 File Offset: 0x00096132
		public global::Infragistics.Windows.DataPresenter.RecordManager RecordManager
		{
			get
			{
				return this._recordManager;
			}
		}

		// Token: 0x17000A04 RID: 2564
		// (get) Token: 0x060022B6 RID: 8886 RVA: 0x00097F3A File Offset: 0x0009613A
		public bool RaisedForCustomFilterSelectionControl
		{
			get
			{
				return this._raisedForCustomFilterSelectionControl;
			}
		}

		// Token: 0x0400113E RID: 4414
		internal const int DefaultAsynchLoadDuration = 50;

		// Token: 0x0400113F RID: 4415
		internal const int DefaultAsynchLoadInterval = 50;

		// Token: 0x04001140 RID: 4416
		internal const int DefaultAsynchLoadThreshhold = 1000;

		// Token: 0x04001141 RID: 4417
		private global::System.Collections.Generic.List<global::Infragistics.Windows.DataPresenter.FilterDropDownItem> _dropDownItems;

		// Token: 0x04001142 RID: 4418
		private bool _raisedForCustomFilterSelectionControl;

		// Token: 0x04001143 RID: 4419
		private bool _includeUniqueValues;

		// Token: 0x04001144 RID: 4420
		private global::Infragistics.Windows.DataPresenter.Field _field;

		// Token: 0x04001145 RID: 4421
		private int _asynchLoadDuration = 50;

		// Token: 0x04001146 RID: 4422
		private int _asynchLoadInterval = 50;

		// Token: 0x04001147 RID: 4423
		private int _asynchLoadThreshhold = 1000;

		// Token: 0x04001148 RID: 4424
		private global::Infragistics.Windows.DataPresenter.FilterDropDownItemsType _itemsType;

		// Token: 0x04001149 RID: 4425
		private global::System.Collections.Generic.IList<global::Infragistics.Windows.DataPresenter.FieldMenuDataItem> _menuItems;

		// Token: 0x0400114A RID: 4426
		private global::Infragistics.Windows.DataPresenter.RecordManager _recordManager;
	}
}
