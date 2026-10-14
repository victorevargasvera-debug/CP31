using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000294 RID: 660
	public interface IDbTransactionInterceptor : global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor
	{
		// Token: 0x060020E7 RID: 8423
		void ConnectionGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext);

		// Token: 0x060020E8 RID: 8424
		void ConnectionGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.Common.DbConnection> interceptionContext);

		// Token: 0x060020E9 RID: 8425
		void IsolationLevelGetting(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext);

		// Token: 0x060020EA RID: 8426
		void IsolationLevelGot(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext<global::System.Data.IsolationLevel> interceptionContext);

		// Token: 0x060020EB RID: 8427
		void Committing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);

		// Token: 0x060020EC RID: 8428
		void Committed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);

		// Token: 0x060020ED RID: 8429
		void Disposing(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);

		// Token: 0x060020EE RID: 8430
		void Disposed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);

		// Token: 0x060020EF RID: 8431
		void RollingBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);

		// Token: 0x060020F0 RID: 8432
		void RolledBack(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext);
	}
}
