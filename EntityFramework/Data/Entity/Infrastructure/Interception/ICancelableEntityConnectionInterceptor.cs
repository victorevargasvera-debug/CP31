using System;
using System.Data.Entity.Core.EntityClient;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200028C RID: 652
	internal interface ICancelableEntityConnectionInterceptor : global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x060020C4 RID: 8388
		bool ConnectionOpening(global::System.Data.Entity.Core.EntityClient.EntityConnection connection, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext);
	}
}
