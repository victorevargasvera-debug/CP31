using System;
using System.Windows;

namespace Infragistics.Windows.Editors.Events
{
	// Token: 0x020000B8 RID: 184
	public class EditModeValidationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x060009F7 RID: 2551 RVA: 0x0002D6A8 File Offset: 0x0002B8A8
		public EditModeValidationErrorEventArgs(global::Infragistics.Windows.Editors.ValueEditor editor, bool forceExitEditMode, global::System.Exception exception, string errorMessage)
		{
			this._editor = editor;
			this._forceExitEditMode = forceExitEditMode;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = editor.InvalidValueBehaviorResolved;
		}

		// Token: 0x1700024F RID: 591
		// (get) Token: 0x060009F8 RID: 2552 RVA: 0x0002D6D9 File Offset: 0x0002B8D9
		public global::Infragistics.Windows.Editors.ValueEditor Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060009F9 RID: 2553 RVA: 0x0002D6E1 File Offset: 0x0002B8E1
		public bool ForceExitEditMode
		{
			get
			{
				return this._forceExitEditMode;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060009FA RID: 2554 RVA: 0x0002D6E9 File Offset: 0x0002B8E9
		// (set) Token: 0x060009FB RID: 2555 RVA: 0x0002D6F1 File Offset: 0x0002B8F1
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

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060009FC RID: 2556 RVA: 0x0002D6FA File Offset: 0x0002B8FA
		// (set) Token: 0x060009FD RID: 2557 RVA: 0x0002D702 File Offset: 0x0002B902
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

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0002D70B File Offset: 0x0002B90B
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x0400037E RID: 894
		private global::Infragistics.Windows.Editors.ValueEditor _editor;

		// Token: 0x0400037F RID: 895
		private bool _forceExitEditMode;

		// Token: 0x04000380 RID: 896
		private global::Infragistics.Windows.Editors.InvalidValueBehavior _invalidValueBehavior;

		// Token: 0x04000381 RID: 897
		private string _errorMessage;

		// Token: 0x04000382 RID: 898
		private global::System.Exception _exception;
	}
}
