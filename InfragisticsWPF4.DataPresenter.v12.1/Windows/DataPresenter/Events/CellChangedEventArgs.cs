using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000271 RID: 625
	public class CellChangedEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001D81 RID: 7553 RVA: 0x00080E51 File Offset: 0x0007F051
		internal CellChangedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this._cell = cell;
			this._editor = editor;
		}

		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00080E67 File Offset: 0x0007F067
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00080E6F File Offset: 0x0007F06F
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x04000E87 RID: 3719
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04000E88 RID: 3720
		private global::Infragistics.Windows.Editors.ValueEditor _editor;
	}
}
