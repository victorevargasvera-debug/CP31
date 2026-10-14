using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x020002A2 RID: 674
	internal class Reporter
	{
		// Token: 0x06002172 RID: 8562 RVA: 0x0005CDDC File Offset: 0x0005AFDC
		public Reporter(global::System.Data.Entity.Infrastructure.Design.IReportHandler handler)
		{
			this._handler = handler;
		}

		// Token: 0x06002173 RID: 8563 RVA: 0x0005CDEB File Offset: 0x0005AFEB
		public void WriteError(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnError(message);
		}

		// Token: 0x06002174 RID: 8564 RVA: 0x0005CDFE File Offset: 0x0005AFFE
		public void WriteWarning(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnWarning(message);
		}

		// Token: 0x06002175 RID: 8565 RVA: 0x0005CE11 File Offset: 0x0005B011
		public void WriteInformation(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnInformation(message);
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x0005CE24 File Offset: 0x0005B024
		public void WriteVerbose(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnVerbose(message);
		}

		// Token: 0x04000B9F RID: 2975
		private readonly global::System.Data.Entity.Infrastructure.Design.IReportHandler _handler;
	}
}
