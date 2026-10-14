using System;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000246 RID: 582
	public interface IDbAsyncEnumerator : global::System.IDisposable
	{
		// Token: 0x06001EA9 RID: 7849
		global::System.Threading.Tasks.Task<bool> MoveNextAsync(global::System.Threading.CancellationToken cancellationToken);

		// Token: 0x170006BF RID: 1727
		// (get) Token: 0x06001EAA RID: 7850
		object Current { get; }
	}
}
