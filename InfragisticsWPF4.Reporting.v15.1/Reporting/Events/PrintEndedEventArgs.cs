using System;

namespace Infragistics.Windows.Reporting.Events
{
	// Token: 0x0200000C RID: 12
	public class PrintEndedEventArgs : global::System.EventArgs
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00003304 File Offset: 0x00001504
		public PrintEndedEventArgs(global::Infragistics.Windows.Reporting.PrintStatus status, int pages)
		{
			this._totalPrintedPages = pages;
			this._status = status;
			if (status == global::Infragistics.Windows.Reporting.PrintStatus.Canceled)
			{
				this._reason = global::Infragistics.Windows.Reporting.PrintCancelationReason.User;
				return;
			}
			this._reason = global::Infragistics.Windows.Reporting.PrintCancelationReason.NotCanceled;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000332D File Offset: 0x0000152D
		public PrintEndedEventArgs(global::Infragistics.Windows.Reporting.PrintStatus status, int pages, global::Infragistics.Windows.Reporting.PrintCancelationReason reason)
		{
			this._totalPrintedPages = pages;
			this._status = status;
			this._reason = reason;
		}

		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000048 RID: 72 RVA: 0x0000334A File Offset: 0x0000154A
		public global::Infragistics.Windows.Reporting.PrintCancelationReason Reason
		{
			get
			{
				return this._reason;
			}
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000049 RID: 73 RVA: 0x00003352 File Offset: 0x00001552
		public global::Infragistics.Windows.Reporting.PrintStatus Status
		{
			get
			{
				return this._status;
			}
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x0600004A RID: 74 RVA: 0x0000335A File Offset: 0x0000155A
		public int TotalPrintedPages
		{
			get
			{
				return this._totalPrintedPages;
			}
		}

		// Token: 0x04000022 RID: 34
		private global::Infragistics.Windows.Reporting.PrintStatus _status;

		// Token: 0x04000023 RID: 35
		private global::Infragistics.Windows.Reporting.PrintCancelationReason _reason;

		// Token: 0x04000024 RID: 36
		private int _totalPrintedPages;
	}
}
