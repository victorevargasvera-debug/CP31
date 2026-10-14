using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000263 RID: 611
	internal class DefaultTransactionHandler : global::System.Data.Entity.Infrastructure.TransactionHandler
	{
		// Token: 0x06001F11 RID: 7953 RVA: 0x000557AE File Offset: 0x000539AE
		public override string BuildDatabaseInitializationScript()
		{
			return string.Empty;
		}

		// Token: 0x06001F12 RID: 7954 RVA: 0x000557B5 File Offset: 0x000539B5
		public override void Committed(global::System.Data.Common.DbTransaction transaction, global::System.Data.Entity.Infrastructure.Interception.DbTransactionInterceptionContext interceptionContext)
		{
			if (interceptionContext.Exception != null && interceptionContext.Connection != null && this.MatchesParentContext(interceptionContext.Connection, interceptionContext))
			{
				interceptionContext.Exception = new global::System.Data.Entity.Infrastructure.CommitFailedException(global::System.Data.Entity.Resources.Strings.CommitFailed, interceptionContext.Exception);
			}
		}
	}
}
