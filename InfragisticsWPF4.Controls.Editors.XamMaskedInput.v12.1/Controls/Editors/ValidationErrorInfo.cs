using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000056 RID: 86
	public class ValidationErrorInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00014610 File Offset: 0x00012810
		public ValidationErrorInfo(global::System.Exception exception)
		{
			this._exception = exception;
			this._errorMessage = exception.Message;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x060003E8 RID: 1000 RVA: 0x0001462B File Offset: 0x0001282B
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x060003E9 RID: 1001 RVA: 0x00014633 File Offset: 0x00012833
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x04000179 RID: 377
		private global::System.Exception _exception;

		// Token: 0x0400017A RID: 378
		private string _errorMessage;
	}
}
