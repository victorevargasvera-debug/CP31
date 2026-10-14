using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000122 RID: 290
	internal class RecordFilterTreeItemParent : global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x00041BC8 File Offset: 0x0003FDC8
		internal RecordFilterTreeItemParent(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType, string displayText, object value, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem) : base(itemType, displayText, value, dropDownItem)
		{
			this._itemsSource = new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection(this);
			switch (itemType)
			{
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.SelectAll:
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.SelectAllSearchResults:
			case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.AddCurrentSelectionToFilter:
				break;
			default:
				switch (itemType)
				{
				case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Second:
				case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Value:
				case global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType.Blanks:
					break;
				default:
					this._items = new global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem>(this.ItemsSource);
					break;
				}
				break;
			}
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00041C2A File Offset: 0x0003FE2A
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(base.ItemType, this.DisplayTextInternal, this.Value, base.DropDownItem);
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06000F82 RID: 3970 RVA: 0x00041C49 File Offset: 0x0003FE49
		// (set) Token: 0x06000F83 RID: 3971 RVA: 0x00041C51 File Offset: 0x0003FE51
		internal override bool IsExpandedInternal
		{
			get
			{
				return this._isExpanded;
			}
			set
			{
				if (this._isExpanded != value)
				{
					this._isExpanded = value;
					this.OnPropertyChanged("IsExpanded");
				}
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06000F84 RID: 3972 RVA: 0x00041C6E File Offset: 0x0003FE6E
		internal override int ItemsCount
		{
			get
			{
				return this._itemsSource.Count;
			}
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06000F85 RID: 3973 RVA: 0x00041C7B File Offset: 0x0003FE7B
		internal override global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> ItemsInternal
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06000F86 RID: 3974 RVA: 0x00041C83 File Offset: 0x0003FE83
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection ItemsSource
		{
			get
			{
				return this._itemsSource;
			}
		}

		// Token: 0x040005F9 RID: 1529
		private bool _isExpanded;

		// Token: 0x040005FA RID: 1530
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection _itemsSource;

		// Token: 0x040005FB RID: 1531
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _items;
	}
}
