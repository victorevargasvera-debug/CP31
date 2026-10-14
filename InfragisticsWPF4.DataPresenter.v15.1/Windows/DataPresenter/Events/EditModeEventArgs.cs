using System;
using System.Windows;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C0 RID: 704
	public abstract class EditModeEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x06002245 RID: 8773 RVA: 0x0009795A File Offset: 0x00095B5A
		protected EditModeEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor)
		{
			this._cell = cell;
			this._editor = editor;
		}

		// Token: 0x170009C4 RID: 2500
		// (get) Token: 0x06002246 RID: 8774 RVA: 0x00097970 File Offset: 0x00095B70
		public global::Infragistics.Windows.DataPresenter.Cell Cell
		{
			get
			{
				return this._cell;
			}
		}

		// Token: 0x170009C5 RID: 2501
		// (get) Token: 0x06002247 RID: 8775 RVA: 0x00097978 File Offset: 0x00095B78
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x04001108 RID: 4360
		private global::Infragistics.Windows.DataPresenter.Cell _cell;

		// Token: 0x04001109 RID: 4361
		private global::Infragistics.Windows.Editors.ValueEditor _editor;
	}
}
