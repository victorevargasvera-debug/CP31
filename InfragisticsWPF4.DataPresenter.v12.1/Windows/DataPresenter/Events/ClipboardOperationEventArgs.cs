using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000276 RID: 630
	public abstract class ClipboardOperationEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06001D9C RID: 7580 RVA: 0x00080FEF File Offset: 0x0007F1EF
		internal ClipboardOperationEventArgs(global::Infragistics.Windows.DataPresenter.CellValueHolderCollection values)
		{
			this._values = values;
		}

		// Token: 0x1700080A RID: 2058
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x00080FFE File Offset: 0x0007F1FE
		public int FieldCount
		{
			get
			{
				return this.Values.FieldCount;
			}
		}

		// Token: 0x1700080B RID: 2059
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x0008100B File Offset: 0x0007F20B
		public int RecordCount
		{
			get
			{
				return this.Values.RecordCount;
			}
		}

		// Token: 0x1700080C RID: 2060
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x00081018 File Offset: 0x0007F218
		public global::Infragistics.Windows.DataPresenter.CellValueHolderCollection Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x04000E97 RID: 3735
		private global::Infragistics.Windows.DataPresenter.CellValueHolderCollection _values;
	}
}
