using System;

namespace System.Data.Entity.Infrastructure.Design
{
	// Token: 0x020002A6 RID: 678
	internal class WrappedResultHandler : global::System.Data.Entity.Infrastructure.Design.IResultHandler
	{
		// Token: 0x06002189 RID: 8585 RVA: 0x0005CFB0 File Offset: 0x0005B1B0
		public WrappedResultHandler(object handler)
		{
			global::System.Data.Entity.Infrastructure.Design.HandlerBase handlerBase = (handler as global::System.Data.Entity.Infrastructure.Design.HandlerBase) ?? new global::System.Data.Entity.Infrastructure.Design.ForwardingProxy<global::System.Data.Entity.Infrastructure.Design.HandlerBase>(handler).GetTransparentProxy();
			this._handler = ((handler as global::System.Data.Entity.Infrastructure.Design.IResultHandler) ?? (handlerBase.ImplementsContract(typeof(global::System.Data.Entity.Infrastructure.Design.IResultHandler).FullName) ? new global::System.Data.Entity.Infrastructure.Design.ForwardingProxy<global::System.Data.Entity.Infrastructure.Design.IResultHandler>(handler).GetTransparentProxy() : null));
			this._handler2 = ((handler as global::System.Data.Entity.Infrastructure.Design.IResultHandler2) ?? (handlerBase.ImplementsContract(typeof(global::System.Data.Entity.Infrastructure.Design.IResultHandler2).FullName) ? new global::System.Data.Entity.Infrastructure.Design.ForwardingProxy<global::System.Data.Entity.Infrastructure.Design.IResultHandler2>(handler).GetTransparentProxy() : null));
		}

		// Token: 0x0600218A RID: 8586 RVA: 0x0005D043 File Offset: 0x0005B243
		public void SetResult(object value)
		{
			if (this._handler != null)
			{
				this._handler.SetResult(value);
			}
		}

		// Token: 0x0600218B RID: 8587 RVA: 0x0005D059 File Offset: 0x0005B259
		public bool SetError(string type, string message, string stackTrace)
		{
			if (this._handler2 == null)
			{
				return false;
			}
			this._handler2.SetError(type, message, stackTrace);
			return true;
		}

		// Token: 0x04000BAA RID: 2986
		private readonly global::System.Data.Entity.Infrastructure.Design.IResultHandler _handler;

		// Token: 0x04000BAB RID: 2987
		private readonly global::System.Data.Entity.Infrastructure.Design.IResultHandler2 _handler2;
	}
}
