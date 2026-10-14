using System;
using System.Collections.ObjectModel;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013E RID: 318
	internal class RecordFilterTreeItemParent : global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx
	{
		// Token: 0x060012E6 RID: 4838 RVA: 0x000527E4 File Offset: 0x000509E4
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

		// Token: 0x060012E7 RID: 4839 RVA: 0x00052846 File Offset: 0x00050A46
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemParent(base.ItemType, this.DisplayTextInternal, this.Value, base.DropDownItem);
		}

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x060012E8 RID: 4840 RVA: 0x00052865 File Offset: 0x00050A65
		// (set) Token: 0x060012E9 RID: 4841 RVA: 0x0005286D File Offset: 0x00050A6D
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

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x060012EA RID: 4842 RVA: 0x0005288A File Offset: 0x00050A8A
		internal override int ItemsCount
		{
			get
			{
				return this._itemsSource.Count;
			}
		}

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x060012EB RID: 4843 RVA: 0x00052897 File Offset: 0x00050A97
		internal override global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> ItemsInternal
		{
			get
			{
				return this._items;
			}
		}

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x060012EC RID: 4844 RVA: 0x0005289F File Offset: 0x00050A9F
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection ItemsSource
		{
			get
			{
				return this._itemsSource;
			}
		}

		// Token: 0x0400079B RID: 1947
		private bool _isExpanded;

		// Token: 0x0400079C RID: 1948
		private global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem.RecordFilterTreeItemCollection _itemsSource;

		// Token: 0x0400079D RID: 1949
		private global::System.Collections.ObjectModel.ReadOnlyObservableCollection<global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem> _items;
	}
}
