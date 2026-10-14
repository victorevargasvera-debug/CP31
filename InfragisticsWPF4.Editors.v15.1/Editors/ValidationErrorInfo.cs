using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000F1 RID: 241
	public class ValidationErrorInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000BAE RID: 2990 RVA: 0x000323C4 File Offset: 0x000305C4
		public ValidationErrorInfo(global::System.Exception exception)
		{
			this._exception = exception;
			this._errorMessage = exception.Message;
		}

		// Token: 0x17000312 RID: 786
		// (get) Token: 0x06000BAF RID: 2991 RVA: 0x000323DF File Offset: 0x000305DF
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x000323E7 File Offset: 0x000305E7
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x04000439 RID: 1081
		private global::System.Exception _exception;

		// Token: 0x0400043A RID: 1082
		private string _errorMessage;
	}
}
