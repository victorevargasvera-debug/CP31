using System;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x02000514 RID: 1300
	internal sealed class ObjectItemCachedAssemblyLoader : global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader
	{
		// Token: 0x17000C86 RID: 3206
		// (get) Token: 0x0600401D RID: 16413 RVA: 0x000D4EFB File Offset: 0x000D30FB
		private new global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry CacheEntry
		{
			get
			{
				return (global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry)base.CacheEntry;
			}
		}

		// Token: 0x0600401E RID: 16414 RVA: 0x000D4F08 File Offset: 0x000D3108
		internal ObjectItemCachedAssemblyLoader(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.ImmutableAssemblyCacheEntry cacheEntry, global::System.Data.Entity.Core.Metadata.Edm.ObjectItemLoadingSessionData sessionData) : base(assembly, cacheEntry, sessionData)
		{
		}

		// Token: 0x0600401F RID: 16415 RVA: 0x000D4F13 File Offset: 0x000D3113
		protected override void AddToAssembliesLoaded()
		{
		}

		// Token: 0x06004020 RID: 16416 RVA: 0x000D4F18 File Offset: 0x000D3118
		protected override void LoadTypesFromAssembly()
		{
			foreach (global::System.Data.Entity.Core.Metadata.Edm.EdmType edmType in this.CacheEntry.TypesInAssembly)
			{
				if (!base.SessionData.TypesInLoading.ContainsKey(edmType.Identity))
				{
					base.SessionData.TypesInLoading.Add(edmType.Identity, edmType);
				}
			}
		}
	}
}
