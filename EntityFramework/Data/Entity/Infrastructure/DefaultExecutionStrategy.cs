using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023D RID: 573
	public class DefaultExecutionStrategy : global::System.Data.Entity.Infrastructure.IDbExecutionStrategy
	{
		// Token: 0x170006BA RID: 1722
		// (get) Token: 0x06001E31 RID: 7729 RVA: 0x0005357E File Offset: 0x0005177E
		public bool RetriesOnFailure
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06001E32 RID: 7730 RVA: 0x00053581 File Offset: 0x00051781
		public void Execute(global::System.Action operation)
		{
			operation();
		}

		// Token: 0x06001E33 RID: 7731 RVA: 0x00053589 File Offset: 0x00051789
		public TResult Execute<TResult>(global::System.Func<TResult> operation)
		{
			return operation();
		}

		// Token: 0x06001E34 RID: 7732 RVA: 0x00053591 File Offset: 0x00051791
		public global::System.Threading.Tasks.Task ExecuteAsync(global::System.Func<global::System.Threading.Tasks.Task> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return operation();
		}

		// Token: 0x06001E35 RID: 7733 RVA: 0x000535A0 File Offset: 0x000517A0
		public global::System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(global::System.Func<global::System.Threading.Tasks.Task<TResult>> operation, global::System.Threading.CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			return operation();
		}
	}
}
