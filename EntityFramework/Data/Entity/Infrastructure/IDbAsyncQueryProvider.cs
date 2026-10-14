using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000249 RID: 585
	public interface IDbAsyncQueryProvider : global::System.Linq.IQueryProvider
	{
		// Token: 0x06001EAE RID: 7854
		global::System.Threading.Tasks.Task<object> ExecuteAsync(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x06001EAF RID: 7855
		global::System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(global::System.Linq.Expressions.Expression expression, global::System.Threading.CancellationToken cancellationToken);
	}
}
