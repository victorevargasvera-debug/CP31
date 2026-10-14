using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x02000282 RID: 642
	public class EditModeValidationErrorEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06001DD0 RID: 7632 RVA: 0x000812BC File Offset: 0x0007F4BC
		public EditModeValidationErrorEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool forceExitEditMode, global::System.Exception exception, string errorMessage) : base(cell, editor)
		{
			this._forceExitEditMode = forceExitEditMode;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = cell.Field.InvalidValueBehaviorResolved;
		}

		// Token: 0x17000822 RID: 2082
		// (get) Token: 0x06001DD1 RID: 7633 RVA: 0x000812EE File Offset: 0x0007F4EE
		public bool ForceExitEditMode
		{
			get
			{
				return this._forceExitEditMode;
			}
		}

		// Token: 0x17000823 RID: 2083
		// (get) Token: 0x06001DD2 RID: 7634 RVA: 0x000812F6 File Offset: 0x0007F4F6
		// (set) Token: 0x06001DD3 RID: 7635 RVA: 0x000812FE File Offset: 0x0007F4FE
		public global::Infragistics.Windows.Editors.InvalidValueBehavior InvalidValueBehavior
		{
			get
			{
				return this._invalidValueBehavior;
			}
			set
			{
				this._invalidValueBehavior = value;
			}
		}

		// Token: 0x17000824 RID: 2084
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x00081307 File Offset: 0x0007F507
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0008130F File Offset: 0x0007F50F
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
			set
			{
				this._errorMessage = value;
			}
		}

		// Token: 0x17000825 RID: 2085
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x00081318 File Offset: 0x0007F518
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x04000EA8 RID: 3752
		private bool _forceExitEditMode;

		// Token: 0x04000EA9 RID: 3753
		private global::System.Exception _exception;

		// Token: 0x04000EAA RID: 3754
		private string _errorMessage;

		// Token: 0x04000EAB RID: 3755
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _invalidValueBehavior;
	}
}
