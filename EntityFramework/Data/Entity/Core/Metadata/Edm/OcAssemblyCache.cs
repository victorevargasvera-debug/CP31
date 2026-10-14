using System;
using System.Collections.Generic;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x020004A7 RID: 1191
	internal class OcAssemblyCache
	{
		// Token: 0x06003AAF RID: 15023 RVA: 0x000C0EAC File Offset: 0x000BF0AC
		internal OcAssemblyCache()
		{
			this._conventionalOcCache = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry>();
		}

		// Token: 0x06003AB0 RID: 15024 RVA: 0x000C0EBF File Offset: 0x000BF0BF
		internal bool TryGetConventionalOcCacheFromAssemblyCache(global::System.Reflection.Assembly assemblyToLookup, out global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry cacheEntry)
		{
			cacheEntry = null;
			return this._conventionalOcCache.TryGetValue(assemblyToLookup, out cacheEntry);
		}

		// Token: 0x06003AB1 RID: 15025 RVA: 0x000C0ED1 File Offset: 0x000BF0D1
		internal void AddAssemblyToOcCacheFromAssemblyCache(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry cacheEntry)
		{
			if (this._conventionalOcCache.ContainsKey(assembly))
			{
				return;
			}
			this._conventionalOcCache.Add(assembly, cacheEntry);
		}

		// Token: 0x0400142C RID: 5164
		private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry> _conventionalOcCache;
	}
}
