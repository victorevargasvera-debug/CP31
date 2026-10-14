using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200013D RID: 317
	internal class RecordFilterTreeItemEx : global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem
	{
		// Token: 0x060012E2 RID: 4834 RVA: 0x0005279A File Offset: 0x0005099A
		internal RecordFilterTreeItemEx(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType, string displayText, object value, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem) : base(itemType, dropDownItem)
		{
			this._displayText = displayText;
			this._value = value;
		}

		// Token: 0x060012E3 RID: 4835 RVA: 0x000527B3 File Offset: 0x000509B3
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx(base.ItemType, this._displayText, this._value, base.DropDownItem);
		}

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x060012E4 RID: 4836 RVA: 0x000527D2 File Offset: 0x000509D2
		internal override string DisplayTextInternal
		{
			get
			{
				return this._displayText;
			}
		}

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x060012E5 RID: 4837 RVA: 0x000527DA File Offset: 0x000509DA
		internal override object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x04000799 RID: 1945
		private string _displayText;

		// Token: 0x0400079A RID: 1946
		private object _value;
	}
}
