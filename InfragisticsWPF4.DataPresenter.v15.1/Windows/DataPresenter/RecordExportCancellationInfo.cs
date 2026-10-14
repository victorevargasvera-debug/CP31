using System;

namespace Infragistics.Windows.DataPresenter
{
	// Token: 0x0200010D RID: 269
	public class RecordExportCancellationInfo
	{
		// Token: 0x06001098 RID: 4248 RVA: 0x0004A1DD File Offset: 0x000483DD
		public RecordExportCancellationInfo(global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason reason, global::System.Exception exception)
		{
			this._exception = exception;
			this._reason = reason;
		}

		// Token: 0x17000417 RID: 1047
		// (get) Token: 0x06001099 RID: 4249 RVA: 0x0004A1F3 File Offset: 0x000483F3
		public global::System.Exception Exception
		{
			get
			{
				return this._exception;
			}
		}

		// Token: 0x17000418 RID: 1048
		// (get) Token: 0x0600109A RID: 4250 RVA: 0x0004A1FB File Offset: 0x000483FB
		public global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason Reason
		{
			get
			{
				return this._reason;
			}
		}

		// Token: 0x04000699 RID: 1689
		private global::System.Exception _exception;

		// Token: 0x0400069A RID: 1690
		private global::Infragistics.Windows.DataPresenter.RecordExportCancellationReason _reason;
	}
}
