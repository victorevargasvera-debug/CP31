using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200028D RID: 653
	public interface IDbCommandInterceptor : global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x060020C5 RID: 8389
		void NonQueryExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext);

		// Token: 0x060020C6 RID: 8390
		void NonQueryExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext);

		// Token: 0x060020C7 RID: 8391
		void ReaderExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext);

		// Token: 0x060020C8 RID: 8392
		void ReaderExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext);

		// Token: 0x060020C9 RID: 8393
		void ScalarExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext);

		// Token: 0x060020CA RID: 8394
		void ScalarExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext);
	}
}
