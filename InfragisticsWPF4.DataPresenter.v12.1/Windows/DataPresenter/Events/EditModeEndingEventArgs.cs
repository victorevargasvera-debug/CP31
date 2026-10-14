using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000280 RID: 640
	public class EditModeEndingEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06001DC8 RID: 7624 RVA: 0x00081245 File Offset: 0x0007F445
		public EditModeEndingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool acceptChanges, bool force) : base(cell, editor)
		{
			this._acceptChanges = acceptChanges;
			this._force = force;
		}

		// Token: 0x1700081E RID: 2078
		// (get) Token: 0x06001DC9 RID: 7625 RVA: 0x0008125E File Offset: 0x0007F45E
		// (set) Token: 0x06001DCA RID: 7626 RVA: 0x00081266 File Offset: 0x0007F466
		public bool AcceptChanges
		{
			get
			{
				return this._acceptChanges;
			}
			set
			{
				this._acceptChanges = value;
			}
		}

		// Token: 0x1700081F RID: 2079
		// (get) Token: 0x06001DCB RID: 7627 RVA: 0x0008126F File Offset: 0x0007F46F
		// (set) Token: 0x06001DCC RID: 7628 RVA: 0x00081277 File Offset: 0x0007F477
		public bool Cancel
		{
			get
			{
				return this._cancel;
			}
			set
			{
				if (value && this._force)
				{
					throw new global::System.NotSupportedException(global::Infragistics.Windows.DataPresenter.DataPresenterBase.GetString("LE_NotSupportedException_5"));
				}
				this._cancel = value;
			}
		}

		// Token: 0x17000820 RID: 2080
		// (get) Token: 0x06001DCD RID: 7629 RVA: 0x0008129B File Offset: 0x0007F49B
		public bool Force
		{
			get
			{
				return this._force;
			}
		}

		// Token: 0x04000EA4 RID: 3748
		private bool _cancel;

		// Token: 0x04000EA5 RID: 3749
		private bool _force;

		// Token: 0x04000EA6 RID: 3750
		private bool _acceptChanges;
	}
}
