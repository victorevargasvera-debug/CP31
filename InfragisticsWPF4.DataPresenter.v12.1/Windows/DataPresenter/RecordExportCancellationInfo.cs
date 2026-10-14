using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x020000EF RID: 239
	public class RecordExportCancellationInfo
	{
		// Token: 0x06000D23 RID: 3363 RVA: 0x00039819 File Offset: 0x00037A19
		public RecordExportCancellationInfo(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason reason, global::System.Exception exception)
		{
			this._exception = exception;
			this._reason = reason;
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x06000D24 RID: 3364 RVA: 0x0003982F File Offset: 0x00037A2F
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000D25 RID: 3365 RVA: 0x00039837 File Offset: 0x00037A37
		public global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason Reason
		{
			get
			{
				return this._reason;
			}
		}

		// Token: 0x040004FC RID: 1276
		private global::System.Exception _exception;

		// Token: 0x040004FD RID: 1277
		private global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason _reason;
	}
}
