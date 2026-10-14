using System;
using System.Windows;

namespace Microsoft.Windows.Controls
{
	// Token: 0x02000069 RID: 105
	public class DataGridPreparingCellForEditEventArgs : global::System.EventArgs
	{
		// Token: 0x060007B5 RID: 1973 RVA: 0x000227DF File Offset: 0x000209DF
		public DataGridPreparingCellForEditEventArgs(global::Microsoft.Windows.Controls.DataGridColumn column, global::Microsoft.Windows.Controls.DataGridRow row, global::System.Windows.RoutedEventArgs editingEventArgs, global::System.Windows.FrameworkElement editingElement)
		{
			this._dataGridColumn = column;
			this._dataGridRow = row;
			this._editingEventArgs = editingEventArgs;
			this._editingElement = editingElement;
		}

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x060007B6 RID: 1974 RVA: 0x00022804 File Offset: 0x00020A04
		public global::Microsoft.Windows.Controls.DataGridColumn Column
		{
			get
			{
				return this._dataGridColumn;
			}
		}

		// Token: 0x170001DE RID: 478
		// (get) Token: 0x060007B7 RID: 1975 RVA: 0x0002280C File Offset: 0x00020A0C
		public global::Microsoft.Windows.Controls.DataGridRow Row
		{
			get
			{
				return this._dataGridRow;
			}
		}

		// Token: 0x170001DF RID: 479
		// (get) Token: 0x060007B8 RID: 1976 RVA: 0x00022814 File Offset: 0x00020A14
		public global::System.Windows.RoutedEventArgs EditingEventArgs
		{
			get
			{
				return this._editingEventArgs;
			}
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x060007B9 RID: 1977 RVA: 0x0002281C File Offset: 0x00020A1C
		public global::System.Windows.FrameworkElement EditingElement
		{
			get
			{
				return this._editingElement;
			}
		}

		// Token: 0x04000270 RID: 624
		private global::Microsoft.Windows.Controls.DataGridColumn _dataGridColumn;

		// Token: 0x04000271 RID: 625
		private global::Microsoft.Windows.Controls.DataGridRow _dataGridRow;

		// Token: 0x04000272 RID: 626
		private global::System.Windows.RoutedEventArgs _editingEventArgs;

		// Token: 0x04000273 RID: 627
		private global::System.Windows.FrameworkElement _editingElement;
	}
}
