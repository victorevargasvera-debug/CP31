using System;
using Infragistics.Windows.Controls.Events;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002B9 RID: 697
	public abstract class ClipboardOperationEventArgs : global::Infragistics.Windows.Controls.Events.CancelableRoutedEventArgs
	{
		// Token: 0x06002220 RID: 8736 RVA: 0x0009774F File Offset: 0x0009594F
		internal ClipboardOperationEventArgs(global::Infragistics.Windows.DataPresenter.CellValueHolderCollection values)
		{
			this._values = values;
		}

		// Token: 0x170009B3 RID: 2483
		// (get) Token: 0x06002221 RID: 8737 RVA: 0x0009775E File Offset: 0x0009595E
		public int FieldCount
		{
			get
			{
				return this.Values.FieldCount;
			}
		}

		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x06002222 RID: 8738 RVA: 0x0009776B File Offset: 0x0009596B
		public int RecordCount
		{
			get
			{
				return this.Values.RecordCount;
			}
		}

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x06002223 RID: 8739 RVA: 0x00097778 File Offset: 0x00095978
		public global::Infragistics.Windows.DataPresenter.CellValueHolderCollection Values
		{
			get
			{
				return this._values;
			}
		}

		// Token: 0x040010FE RID: 4350
		private global::Infragistics.Windows.DataPresenter.CellValueHolderCollection _values;
	}
}
