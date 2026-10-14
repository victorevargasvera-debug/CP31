using System;

namespace Infragistics.Windows.Reporting.Events
{
	// Token: 0x0200000A RID: 10
	public class EmbeddedVisualPaginationEventArgs : global::System.EventArgs
	{
		// Token: 0x0600003F RID: 63 RVA: 0x000032A8 File Offset: 0x000014A8
		public EmbeddedVisualPaginationEventArgs(global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator visualPaginator)
		{
			this._visualPaginator = visualPaginator;
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000032B7 File Offset: 0x000014B7
		public global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator VisualPaginator
		{
			get
			{
				return this._visualPaginator;
			}
		}

		// Token: 0x0400001E RID: 30
		private global::Infragistics.Windows.Reporting.IEmbeddedVisualPaginator _visualPaginator;
	}
}
