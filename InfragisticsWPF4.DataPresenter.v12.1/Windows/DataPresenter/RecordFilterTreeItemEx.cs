using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000121 RID: 289
	internal class RecordFilterTreeItemEx : global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem
	{
		// Token: 0x06000F7C RID: 3964 RVA: 0x00041B7E File Offset: 0x0003FD7E
		internal RecordFilterTreeItemEx(global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemType itemType, string displayText, object value, global::Infragistics.Windows.DataPresenter.FilterDropDownItem dropDownItem) : base(itemType, dropDownItem)
		{
			this._displayText = displayText;
			this._value = value;
		}

		// Token: 0x06000F7D RID: 3965 RVA: 0x00041B97 File Offset: 0x0003FD97
		internal override global::Infragistics.Windows.DataPresenter.RecordFilterTreeItem CreateNew()
		{
			return new global::Infragistics.Windows.DataPresenter.RecordFilterTreeItemEx(base.ItemType, this._displayText, this._value, base.DropDownItem);
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x06000F7E RID: 3966 RVA: 0x00041BB6 File Offset: 0x0003FDB6
		internal override string DisplayTextInternal
		{
			get
			{
				return this._displayText;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x06000F7F RID: 3967 RVA: 0x00041BBE File Offset: 0x0003FDBE
		internal override object Value
		{
			get
			{
				return this._value;
			}
		}

		// Token: 0x040005F7 RID: 1527
		private string _displayText;

		// Token: 0x040005F8 RID: 1528
		private object _value;
	}
}
