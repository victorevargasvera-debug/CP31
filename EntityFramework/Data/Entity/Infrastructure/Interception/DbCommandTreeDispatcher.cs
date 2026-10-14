using System;
using System.Data.Entity.Core.Common.CommandTrees;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027C RID: 636
	internal class DbCommandTreeDispatcher
	{
		// Token: 0x170006F2 RID: 1778
		// (get) Token: 0x0600201D RID: 8221 RVA: 0x0005A4B2 File Offset: 0x000586B2
		public global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandTreeInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x0600201E RID: 8222 RVA: 0x0005A4BA File Offset: 0x000586BA
		public virtual global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree Created(global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree commandTree, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return this._internalDispatcher.Dispatch<global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext, global::System.Data.Entity.Core.Common.CommandTrees.DbCommandTree>(commandTree, new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext(interceptionContext), delegate(global::System.Data.Entity.Infrastructure.Interception.IDbCommandTreeInterceptor i, global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeInterceptionContext c)
			{
				i.TreeCreated(c);
			});
		}

		// Token: 0x04000B78 RID: 2936
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandTreeInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.IDbCommandTreeInterceptor>();
	}
}
