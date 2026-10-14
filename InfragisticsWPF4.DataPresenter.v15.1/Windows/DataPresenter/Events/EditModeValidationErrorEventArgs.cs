using System;
using Infragistics.Windows.Editors;

namespace Infragistics.Windows.DataPresenter.Events
{
	// Token: 0x020002C5 RID: 709
	public class EditModeValidationErrorEventArgs : global::Infragistics.Windows.DataPresenter.Events.EditModeEventArgs
	{
		// Token: 0x06002258 RID: 8792 RVA: 0x00097A4D File Offset: 0x00095C4D
		public EditModeValidationErrorEventArgs(global::Infragistics.Windows.DataPresenter.Cell cell, global::Infragistics.Windows.Editors.ValueEditor editor, bool forceExitEditMode, global::System.Exception exception, string errorMessage) : base(cell, editor)
		{
			this._forceExitEditMode = forceExitEditMode;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = cell.Field.InvalidValueBehaviorResolved;
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x06002259 RID: 8793 RVA: 0x00097A7F File Offset: 0x00095C7F
		public bool ForceExitEditMode
		{
			get
			{
				return this._forceExitEditMode;
			}
		}

		// Token: 0x170009CF RID: 2511
		// (get) Token: 0x0600225A RID: 8794 RVA: 0x00097A87 File Offset: 0x00095C87
		// (set) Token: 0x0600225B RID: 8795 RVA: 0x00097A8F File Offset: 0x00095C8F
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

		// Token: 0x170009D0 RID: 2512
		// (get) Token: 0x0600225C RID: 8796 RVA: 0x00097A98 File Offset: 0x00095C98
		// (set) Token: 0x0600225D RID: 8797 RVA: 0x00097AA0 File Offset: 0x00095CA0
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

		// Token: 0x170009D1 RID: 2513
		// (get) Token: 0x0600225E RID: 8798 RVA: 0x00097AA9 File Offset: 0x00095CA9
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x04001112 RID: 4370
		private bool _forceExitEditMode;

		// Token: 0x04001113 RID: 4371
		private global::System.Exception _exception;

		// Token: 0x04001114 RID: 4372
		private string _errorMessage;

		// Token: 0x04001115 RID: 4373
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _invalidValueBehavior;
	}
}
