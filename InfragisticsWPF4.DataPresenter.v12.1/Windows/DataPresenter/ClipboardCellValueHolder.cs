using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200007E RID: 126
	internal class ClipboardCellValueHolder : global::Infragistics.Windows.DataPresenter.CellValueHolder
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x00018173 File Offset: 0x00016373
		internal ClipboardCellValueHolder(global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder source) : base(source)
		{
			this._originalDisplayText = source._originalDisplayText;
			this._originalValue = source._originalValue;
		}

		// Token: 0x06000625 RID: 1573 RVA: 0x00018194 File Offset: 0x00016394
		internal ClipboardCellValueHolder(object value, bool isDisplayText, object originalValue, string originalDisplayText) : base(value, isDisplayText)
		{
			this._originalValue = originalValue;
			this._originalDisplayText = originalDisplayText;
		}

		// Token: 0x170001B0 RID: 432
		// (get) Token: 0x06000626 RID: 1574 RVA: 0x000181AD File Offset: 0x000163AD
		internal object OriginalValue
		{
			get
			{
				return this._originalValue;
			}
		}

		// Token: 0x170001B1 RID: 433
		// (get) Token: 0x06000627 RID: 1575 RVA: 0x000181B5 File Offset: 0x000163B5
		internal string OriginalDisplayText
		{
			get
			{
				return this._originalDisplayText;
			}
		}

		// Token: 0x06000628 RID: 1576 RVA: 0x000181BD File Offset: 0x000163BD
		internal override global::Infragistics.Windows.DataPresenter.CellValueHolder Clone()
		{
			return new global::Infragistics.Windows.DataPresenter.ClipboardCellValueHolder(this);
		}

		// Token: 0x040001DA RID: 474
		private object _originalValue;

		// Token: 0x040001DB RID: 475
		private string _originalDisplayText;
	}
}
