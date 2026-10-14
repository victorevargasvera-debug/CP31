using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C3 RID: 707
	public class EditModeEndingEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x0600224C RID: 8780 RVA: 0x000979A5 File Offset: 0x00095BA5
		public EditModeEndingEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool acceptChanges, bool force, global::Infragistics.Windows.DataPresenter.EditModeEndingReason reason = global::Infragistics.Windows.DataPresenter.EditModeEndingReason.Other) : base(cell, editor)
		{
			this._acceptChanges = acceptChanges;
			this._force = force;
			this._reason = reason;
		}

		// Token: 0x170009C7 RID: 2503
		// (get) Token: 0x0600224D RID: 8781 RVA: 0x000979C6 File Offset: 0x00095BC6
		// (set) Token: 0x0600224E RID: 8782 RVA: 0x000979CE File Offset: 0x00095BCE
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

		// Token: 0x170009C8 RID: 2504
		// (get) Token: 0x0600224F RID: 8783 RVA: 0x000979D7 File Offset: 0x00095BD7
		// (set) Token: 0x06002250 RID: 8784 RVA: 0x000979DF File Offset: 0x00095BDF
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

		// Token: 0x170009C9 RID: 2505
		// (get) Token: 0x06002251 RID: 8785 RVA: 0x00097A03 File Offset: 0x00095C03
		public bool Force
		{
			get
			{
				return this._force;
			}
		}

		// Token: 0x170009CA RID: 2506
		// (get) Token: 0x06002252 RID: 8786 RVA: 0x00097A0B File Offset: 0x00095C0B
		public global::Infragistics.Windows.DataPresenter.EditModeEndingReason Reason
		{
			get
			{
				return this._reason;
			}
		}

		// Token: 0x0400110B RID: 4363
		private bool _cancel;

		// Token: 0x0400110C RID: 4364
		private bool _force;

		// Token: 0x0400110D RID: 4365
		private bool _acceptChanges;

		// Token: 0x0400110E RID: 4366
		private global::Infragistics.Windows.DataPresenter.EditModeEndingReason _reason;
	}
}
