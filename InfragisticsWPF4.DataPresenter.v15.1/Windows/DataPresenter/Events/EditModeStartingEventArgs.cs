using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C1 RID: 705
	public class EditModeStartingEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06002248 RID: 8776 RVA: 0x00097980 File Offset: 0x00095B80
		public EditModeStartingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor) : base(cell, editor)
		{
		}

		// Token: 0x170009C6 RID: 2502
		// (get) Token: 0x06002249 RID: 8777 RVA: 0x0009798A File Offset: 0x00095B8A
		// (set) Token: 0x0600224A RID: 8778 RVA: 0x00097992 File Offset: 0x00095B92
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				this._cancel = value;
			}
		}

		// Token: 0x0400110A RID: 4362
		private bool _cancel;
	}
}
