using System;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000029 RID: 41
	public class EditModeValidationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600012A RID: 298 RVA: 0x00009122 File Offset: 0x00007322
		public EditModeValidationErrorEventArgs(global::Infragistics.Controls.Editors.ValueInput editor, global::System.Exception exception, string errorMessage)
		{
			this._editor = editor;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = editor.InvalidValueBehaviorResolved;
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x0600012B RID: 299 RVA: 0x0000914B File Offset: 0x0000734B
		public global::Infragistics.Controls.Editors.ValueInput Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00009153 File Offset: 0x00007353
		// (set) Token: 0x0600012D RID: 301 RVA: 0x0000915B File Offset: 0x0000735B
		public global::Infragistics.Controls.Editors.InvalidValueBehavior InvalidValueBehavior
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

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00009164 File Offset: 0x00007364
		// (set) Token: 0x0600012F RID: 303 RVA: 0x0000916C File Offset: 0x0000736C
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

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x06000130 RID: 304 RVA: 0x00009175 File Offset: 0x00007375
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x0400009A RID: 154
		private global::Infragistics.Controls.Editors.ValueInput _editor;

		// Token: 0x0400009B RID: 155
		private global::Infragistics.Controls.Editors.InvalidValueBehavior _invalidValueBehavior;

		// Token: 0x0400009C RID: 156
		private string _errorMessage;

		// Token: 0x0400009D RID: 157
		private global::System.Exception _exception;
	}
}
