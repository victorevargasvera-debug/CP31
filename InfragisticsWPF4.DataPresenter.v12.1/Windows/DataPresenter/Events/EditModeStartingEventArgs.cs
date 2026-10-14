using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x0200027E RID: 638
	public class EditModeStartingEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06001DC4 RID: 7620 RVA: 0x00081220 File Offset: 0x0007F420
		public EditModeStartingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor) : base(cell, editor)
		{
		}

		// Token: 0x1700081D RID: 2077
		// (get) Token: 0x06001DC5 RID: 7621 RVA: 0x0008122A File Offset: 0x0007F42A
		// (set) Token: 0x06001DC6 RID: 7622 RVA: 0x00081232 File Offset: 0x0007F432
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

		// Token: 0x04000EA3 RID: 3747
		private bool _cancel;
	}
}
