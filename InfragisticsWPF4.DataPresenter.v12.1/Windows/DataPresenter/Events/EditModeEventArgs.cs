using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027D RID: 637
	public abstract class EditModeEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06001DC1 RID: 7617 RVA: 0x000811FA File Offset: 0x0007F3FA
		protected EditModeEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this._cell = cell;
			this._editor = editor;
		}

		// Token: 0x1700081B RID: 2075
		// (get) Token: 0x06001DC2 RID: 7618 RVA: 0x00081210 File Offset: 0x0007F410
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x1700081C RID: 2076
		// (get) Token: 0x06001DC3 RID: 7619 RVA: 0x00081218 File Offset: 0x0007F418
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x04000EA1 RID: 3745
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04000EA2 RID: 3746
		private global::Infragistics.Windows.Editors.ValueEditor _editor;
	}
}
