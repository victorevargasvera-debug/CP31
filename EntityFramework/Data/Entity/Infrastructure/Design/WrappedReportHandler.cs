using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x020002A5 RID: 677
	internal class WrappedReportHandler : global::System.Data.Entity.Infrastructure.Design.IReportHandler
	{
		// Token: 0x06002184 RID: 8580 RVA: 0x0005CF00 File Offset: 0x0005B100
		public WrappedReportHandler(object handler)
		{
			if (handler != null)
			{
				global::System.Data.Entity.Infrastructure.Design.HandlerBase handlerBase = (handler as global::System.Data.Entity.Infrastructure.Design.HandlerBase) ?? new global::System.Data.Entity.Infrastructure.Design.ForwardingProxy<global::System.Data.Entity.Infrastructure.Design.HandlerBase>(handler).GetTransparentProxy();
				this._handler = ((handler as global::System.Data.Entity.Infrastructure.Design.IReportHandler) ?? (handlerBase.ImplementsContract(typeof(global::System.Data.Entity.Infrastructure.Design.IReportHandler).FullName) ? new global::System.Data.Entity.Infrastructure.Design.ForwardingProxy<global::System.Data.Entity.Infrastructure.Design.IReportHandler>(handler).GetTransparentProxy() : null));
			}
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x0005CF61 File Offset: 0x0005B161
		public void OnError(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnError(message);
		}

		// Token: 0x06002186 RID: 8582 RVA: 0x0005CF74 File Offset: 0x0005B174
		public void OnInformation(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnInformation(message);
		}

		// Token: 0x06002187 RID: 8583 RVA: 0x0005CF87 File Offset: 0x0005B187
		public void OnVerbose(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnVerbose(message);
		}

		// Token: 0x06002188 RID: 8584 RVA: 0x0005CF9A File Offset: 0x0005B19A
		public void OnWarning(string message)
		{
			global::System.Data.Entity.Infrastructure.Design.IReportHandler handler = this._handler;
			if (handler == null)
			{
				return;
			}
			handler.OnWarning(message);
		}

		// Token: 0x04000BA9 RID: 2985
		private readonly global::System.Data.Entity.Infrastructure.Design.IReportHandler _handler;
	}
}
