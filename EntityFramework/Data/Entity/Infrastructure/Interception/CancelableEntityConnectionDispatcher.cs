using System;
using System.Data.Entity.Core.EntityClient;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000275 RID: 629
	internal class CancelableEntityConnectionDispatcher
	{
		// Token: 0x170006E2 RID: 1762
		// (get) Token: 0x06001F9B RID: 8091 RVA: 0x000591F0 File Offset: 0x000573F0
		public global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableEntityConnectionInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06001F9C RID: 8092 RVA: 0x000591F8 File Offset: 0x000573F8
		public virtual bool Opening(global::System.Data.Entity.Core.EntityClient.EntityConnection entityConnection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return this._internalDispatcher.Dispatch<bool>(true, (bool b, global::System.Data.Entity.Infrastructure.Interception.ICancelableEntityConnectionInterceptor i) => i.ConnectionOpening(entityConnection, interceptionContext) && b);
		}

		// Token: 0x04000B6D RID: 2925
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableEntityConnectionInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableEntityConnectionInterceptor>();
	}
}
