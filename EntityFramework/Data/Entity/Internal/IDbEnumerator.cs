using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000117 RID: 279
	internal interface IDbEnumerator<out T> : global::System.Collections.Generic.IEnumerator<!0>, global::System.IDisposable, global::System.Collections.IEnumerator, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>, global::System.Data.Entity.Infrastructure.IDbAsyncEnumerator
	{
		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001365 RID: 4965
		T Current { get; }
	}
}
