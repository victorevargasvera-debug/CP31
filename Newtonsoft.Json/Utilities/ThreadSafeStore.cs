using System;
using System.Collections.Concurrent;
using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x0200006E RID: 110
	[global::System.Runtime.CompilerServices.NullableContext(1)]
	[global::System.Runtime.CompilerServices.Nullable(0)]
	internal class ThreadSafeStore<[global::System.Runtime.CompilerServices.Nullable(2)] TKey, [global::System.Runtime.CompilerServices.Nullable(2)] TValue>
	{
		// Token: 0x060005F2 RID: 1522 RVA: 0x0001941F File Offset: 0x0001761F
		public ThreadSafeStore(global::System.Func<TKey, TValue> creator)
		{
			global::Newtonsoft.Json.Utilities.ValidationUtils.ArgumentNotNull(creator, "creator");
			this._creator = creator;
			this._concurrentStore = new global::System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue>();
		}

		// Token: 0x060005F3 RID: 1523 RVA: 0x00019444 File Offset: 0x00017644
		public TValue Get(TKey key)
		{
			return this._concurrentStore.GetOrAdd(key, this._creator);
		}

		// Token: 0x0400020D RID: 525
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<TKey, TValue> _concurrentStore;

		// Token: 0x0400020E RID: 526
		private readonly global::System.Func<TKey, TValue> _creator;
	}
}
