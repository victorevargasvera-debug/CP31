using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000140 RID: 320
	internal interface IInternalQuery<out TElement> : global::System.Data.Entity.Internal.Linq.IInternalQuery
	{
		// Token: 0x06001509 RID: 5385
		global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> Include(string path);

		// Token: 0x0600150A RID: 5386
		global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> AsNoTracking();

		// Token: 0x0600150B RID: 5387
		global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> AsStreaming();

		// Token: 0x0600150C RID: 5388
		global::System.Data.Entity.Internal.Linq.IInternalQuery<TElement> WithExecutionStrategy(global::System.Data.Entity.Infrastructure.IDbExecutionStrategy executionStrategy);

		// Token: 0x0600150D RID: 5389
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TElement> GetAsyncEnumerator();

		// Token: 0x0600150E RID: 5390
		global::System.Collections.Generic.IEnumerator<TElement> GetEnumerator();
	}
}
