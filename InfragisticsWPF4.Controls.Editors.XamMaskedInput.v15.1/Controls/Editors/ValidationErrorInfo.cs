using System;

namespace Infragistics.Controls.Editors
{
	// Token: 0x02000055 RID: 85
	public class ValidationErrorInfo : global::Infragistics.PropertyChangeNotifier
	{
		// Token: 0x060003EC RID: 1004 RVA: 0x00014534 File Offset: 0x00012734
		public ValidationErrorInfo(global::System.Exception exception)
		{
			this._exception = exception;
			this._errorMessage = exception.Message;
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x060003ED RID: 1005 RVA: 0x0001454F File Offset: 0x0001274F
		public string ErrorMessage
		{
			get
			{
				return this._errorMessage;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x060003EE RID: 1006 RVA: 0x00014557 File Offset: 0x00012757
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x0400017D RID: 381
		private global::System.Exception _exception;

		// Token: 0x0400017E RID: 382
		private string _errorMessage;
	}
}
