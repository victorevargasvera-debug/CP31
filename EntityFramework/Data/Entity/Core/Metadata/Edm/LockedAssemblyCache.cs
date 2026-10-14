using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Threading;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050F RID: 1295
	internal class LockedAssemblyCache : global::System.IDisposable
	{
		// Token: 0x06003FE4 RID: 16356 RVA: 0x000D3AE2 File Offset: 0x000D1CE2
		internal LockedAssemblyCache(object lockObject, global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry> globalAssemblyCache)
		{
			this._lockObject = lockObject;
			this._globalAssemblyCache = globalAssemblyCache;
			global::System.Threading.Monitor.Enter(this._lockObject);
		}

		// Token: 0x06003FE5 RID: 16357 RVA: 0x000D3B03 File Offset: 0x000D1D03
		public void Dispose()
		{
			global::System.GC.SuppressFinalize(this);
			global::System.Threading.Monitor.Exit(this._lockObject);
			this._lockObject = null;
			this._globalAssemblyCache = null;
		}

		// Token: 0x06003FE6 RID: 16358 RVA: 0x000D3B24 File Offset: 0x000D1D24
		[global::System.Diagnostics.Conditional("DEBUG")]
		private void AssertLockedByThisThread()
		{
			bool flag = false;
			global::System.Threading.Monitor.TryEnter(this._lockObject, ref flag);
			if (flag)
			{
				global::System.Threading.Monitor.Exit(this._lockObject);
			}
		}

		// Token: 0x06003FE7 RID: 16359 RVA: 0x000D3B4E File Offset: 0x000D1D4E
		internal bool TryGetValue(global::System.Reflection.Assembly assembly, out global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry cacheEntry)
		{
			return this._globalAssemblyCache.TryGetValue(assembly, out cacheEntry);
		}

		// Token: 0x06003FE8 RID: 16360 RVA: 0x000D3B5D File Offset: 0x000D1D5D
		internal void Add(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry assemblyCacheEntry)
		{
			this._globalAssemblyCache.Add(assembly, assemblyCacheEntry);
		}

		// Token: 0x06003FE9 RID: 16361 RVA: 0x000D3B6C File Offset: 0x000D1D6C
		internal void Clear()
		{
			this._globalAssemblyCache.Clear();
		}

		// Token: 0x0400164B RID: 5707
		private object _lockObject;

		// Token: 0x0400164C RID: 5708
		private global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry> _globalAssemblyCache;
	}
}
