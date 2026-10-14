using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C4 RID: 708
	public class EditModeEndedEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06002253 RID: 8787 RVA: 0x00097A13 File Offset: 0x00095C13
		public EditModeEndedEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool changesAccepted, global::Infragistics.Windows.DataPresenter.EditModeEndingReason reason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.Other) : base(cell, editor)
		{
			this._changesAccepted = changesAccepted;
			this._reason = reason;
		}

		// Token: 0x170009CB RID: 2507
		// (get) Token: 0x06002254 RID: 8788 RVA: 0x00097A2C File Offset: 0x00095C2C
		public bool ChangesAccepted
		{
			get
			{
				return this._changesAccepted;
			}
		}

		// Token: 0x170009CC RID: 2508
		// (get) Token: 0x06002255 RID: 8789 RVA: 0x00097A34 File Offset: 0x00095C34
		public global::Infragistics.Windows.DataPresenter.EditModeEndingReason Reason
		{
			get
			{
				return this._reason;
			}
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x06002256 RID: 8790 RVA: 0x00097A3C File Offset: 0x00095C3C
		// (set) Token: 0x06002257 RID: 8791 RVA: 0x00097A44 File Offset: 0x00095C44
		public bool SelectCell
		{
			get
			{
				return this._selectCell;
			}
			set
			{
				this._selectCell = value;
			}
		}

		// Token: 0x0400110F RID: 4367
		private bool _changesAccepted;

		// Token: 0x04001110 RID: 4368
		private bool _selectCell;

		// Token: 0x04001111 RID: 4369
		private global::Infragistics.Windows.DataPresenter.EditModeEndingReason _reason;
	}
}
