using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x02000083 RID: 131
	internal class ClipboardCellValueHolder : global::Infragistics.Windows.DataPresenter.CellValueHolder
	{
		// Token: 0x0600069F RID: 1695 RVA: 0x0001A6F3 File Offset: 0x000188F3
		internal ClipboardCellValueHolder(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder source) : base(source)
		{
			this._originalDisplayText = source._originalDisplayText;
			this._originalValue = source._originalValue;
		}

		// Token: 0x060006A0 RID: 1696 RVA: 0x0001A714 File Offset: 0x00018914
		internal ClipboardCellValueHolder(object value, bool isDisplayText, object originalValue, string originalDisplayText) : base(value, isDisplayText)
		{
			this._originalValue = originalValue;
			this._originalDisplayText = originalDisplayText;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x060006A1 RID: 1697 RVA: 0x0001A72D File Offset: 0x0001892D
		internal object OriginalValue
		{
			get
			{
				return this._originalValue;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x060006A2 RID: 1698 RVA: 0x0001A735 File Offset: 0x00018935
		internal string OriginalDisplayText
		{
			get
			{
				return this._originalDisplayText;
			}
		}

		// Token: 0x060006A3 RID: 1699 RVA: 0x0001A73D File Offset: 0x0001893D
		internal override global::Infragistics.Windows.DataPresenter.CellValueHolder Clone()
		{
			return new global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder(this);
		}

		// Token: 0x04000216 RID: 534
		private object _originalValue;

		// Token: 0x04000217 RID: 535
		private string _originalDisplayText;
	}
}
