using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x0200027B RID: 635
	public class DbCommandInterceptor : global::System.Data.Entity.Infrastructure.Interception.IDbCommandInterceptor, global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x06002016 RID: 8214 RVA: 0x0005A49E File Offset: 0x0005869E
		public virtual void NonQueryExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06002017 RID: 8215 RVA: 0x0005A4A0 File Offset: 0x000586A0
		public virtual void NonQueryExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<int> interceptionContext)
		{
		}

		// Token: 0x06002018 RID: 8216 RVA: 0x0005A4A2 File Offset: 0x000586A2
		public virtual void ReaderExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext)
		{
		}

		// Token: 0x06002019 RID: 8217 RVA: 0x0005A4A4 File Offset: 0x000586A4
		public virtual void ReaderExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<global::System.Data.Common.DbDataReader> interceptionContext)
		{
		}

		// Token: 0x0600201A RID: 8218 RVA: 0x0005A4A6 File Offset: 0x000586A6
		public virtual void ScalarExecuting(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
		}

		// Token: 0x0600201B RID: 8219 RVA: 0x0005A4A8 File Offset: 0x000586A8
		public virtual void ScalarExecuted(global::System.Data.Common.DbCommand command, global::System.Data.Entity.Infrastructure.Interception.DbCommandInterceptionContext<object> interceptionContext)
		{
		}
	}
}
