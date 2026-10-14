using System;

namespace Infragistics.Windows.Editors
{
	// Token: 0x020000E5 RID: 229
	public class ValidationErrorInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x06000B2B RID: 2859 RVA: 0x00030270 File Offset: 0x0002E470
		public ValidationErrorInfo(global::System.Exception exception)
		{
			this._exception = exception;
			this._errorMessage = exception.Message;
		}

		// Token: 0x170002EE RID: 750
		// (get) Token: 0x06000B2C RID: 2860 RVA: 0x0003028B File Offset: 0x0002E48B
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x170002EF RID: 751
		// (get) Token: 0x06000B2D RID: 2861 RVA: 0x00030293 File Offset: 0x0002E493
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x040003FF RID: 1023
		private global::System.Exception _exception;

		// Token: 0x04000400 RID: 1024
		private string _errorMessage;
	}
}
