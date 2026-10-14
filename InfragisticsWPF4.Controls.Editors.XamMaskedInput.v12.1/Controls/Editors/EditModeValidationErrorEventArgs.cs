using System;
using System.Windows;

namespace Infragistics.Controls.Editors
{
	// Token: 0x0200002A RID: 42
	public class EditModeValidationErrorEventArgs : global::System.Windows.RoutedEventArgs
	{
		// Token: 0x0600012B RID: 299 RVA: 0x00009542 File Offset: 0x00007742
		public EditModeValidationErrorEventArgs(global::Infragistics.Controls.Editors.ValueInput editor, global::System.Exception exception, string errorMessage)
		{
			this._editor = editor;
			this._exception = exception;
			this._errorMessage = errorMessage;
			this._invalidValueBehavior = editor.InvalidValueBehaviorResolved;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x0600012C RID: 300 RVA: 0x0000956B File Offset: 0x0000776B
		public global::Infragistics.Controls.Editors.ValueInput Editor
		{
			get
			{
				return this._editor;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x0600012D RID: 301 RVA: 0x00009573 File Offset: 0x00007773
		// (set) Token: 0x0600012E RID: 302 RVA: 0x0000957B File Offset: 0x0000777B
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

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x0600012F RID: 303 RVA: 0x00009584 File Offset: 0x00007784
		// (set) Token: 0x06000130 RID: 304 RVA: 0x0000958C File Offset: 0x0000778C
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

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000131 RID: 305 RVA: 0x00009595 File Offset: 0x00007795
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x04000098 RID: 152
		private global::Infragistics.Controls.Editors.ValueInput _editor;

		// Token: 0x04000099 RID: 153
		private global::Infragistics.Controls.Editors.InvalidValueBehavior _invalidValueBehavior;

		// Token: 0x0400009A RID: 154
		private string _errorMessage;

		// Token: 0x0400009B RID: 155
		private global::System.Exception _exception;
	}
}
