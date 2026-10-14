using System;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000245 RID: 581
	public interface IDbAsyncEnumerable<out T> : global::System.Data.Entity.Infrastructure.IDbAsyncEnumerable
	{
		// Token: 0x06001EA8 RID: 7848
		global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator();
	}
}
