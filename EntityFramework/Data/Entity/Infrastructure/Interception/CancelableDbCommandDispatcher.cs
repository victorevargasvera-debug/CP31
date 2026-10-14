using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000274 RID: 628
	internal class CancelableDbCommandDispatcher
	{
		// Token: 0x170006E1 RID: 1761
		// (get) Token: 0x06001F98 RID: 8088 RVA: 0x0005919B File Offset: 0x0005739B
		public global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableDbCommandInterceptor> InternalDispatcher
		{
			get
			{
				return this._internalDispatcher;
			}
		}

		// Token: 0x06001F99 RID: 8089 RVA: 0x000591A4 File Offset: 0x000573A4
		public virtual bool Executing(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext interceptionContext)
		{
			return this._internalDispatcher.Dispatch<bool>(true, (bool b, global::System.Data.Entity.Infrastructure.Interception.ICancelableDbCommandInterceptor i) => i.CommandExecuting(command, interceptionContext) && b);
		}

		// Token: 0x04000B6C RID: 2924
		private readonly global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableDbCommandInterceptor> _internalDispatcher = new global::System.Data.Entity.Infrastructure.Interception.InternalDispatcher<global::System.Data.Entity.Infrastructure.Interception.ICancelableDbCommandInterceptor>();
	}
}
