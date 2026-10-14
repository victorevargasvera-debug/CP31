using System;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.SqlServer
{
	// Token: 0x0200000A RID: 10
	public class SqlAzureExecutionStrategy : global::System.Data.Entity.Infrastructure.DbExecutionStrategy
	{
		// Token: 0x0600003B RID: 59 RVA: 0x0000252D File Offset: 0x0000072D
		public SqlAzureExecutionStrategy()
		{
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002535 File Offset: 0x00000735
		public SqlAzureExecutionStrategy(int maxRetryCount, global::System.TimeSpan maxDelay) : base(maxRetryCount, maxDelay)
		{
		}

		// Token: 0x0600003D RID: 61 RVA: 0x0000253F File Offset: 0x0000073F
		protected override bool ShouldRetryOn(global::System.Exception exception)
		{
			return global::System.Data.Entity.SqlServer.SqlAzureRetriableExceptionDetector.ShouldRetryOn(exception);
		}
	}
}
