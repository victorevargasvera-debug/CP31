using System;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050D RID: 1293
	internal sealed class KnownAssemblyEntry
	{
		// Token: 0x06003FD8 RID: 16344 RVA: 0x000D39AC File Offset: 0x000D1BAC
		internal KnownAssemblyEntry(global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry cacheEntry, bool seenWithEdmItemCollection)
		{
			this._cacheEntry = cacheEntry;
			this.ReferencedAssembliesAreLoaded = false;
			this.SeenWithEdmItemCollection = seenWithEdmItemCollection;
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06003FD9 RID: 16345 RVA: 0x000D39C9 File Offset: 0x000D1BC9
		internal global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry CacheEntry
		{
			get
			{
				return this._cacheEntry;
			}
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x06003FDA RID: 16346 RVA: 0x000D39D1 File Offset: 0x000D1BD1
		// (set) Token: 0x06003FDB RID: 16347 RVA: 0x000D39D9 File Offset: 0x000D1BD9
		public bool ReferencedAssembliesAreLoaded { get; set; }

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x06003FDC RID: 16348 RVA: 0x000D39E2 File Offset: 0x000D1BE2
		// (set) Token: 0x06003FDD RID: 16349 RVA: 0x000D39EA File Offset: 0x000D1BEA
		public bool SeenWithEdmItemCollection { get; set; }

		// Token: 0x06003FDE RID: 16350 RVA: 0x000D39F3 File Offset: 0x000D1BF3
		public bool HaveSeenInCompatibleContext(object loaderCookie, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection)
		{
			return this.SeenWithEdmItemCollection || itemCollection == null || global::System.Data.Entity.Core.Metadata.Edm.ObjectItemAssemblyLoader.IsAttributeLoader(loaderCookie);
		}

		// Token: 0x04001646 RID: 5702
		private readonly global::System.Data.Entity.Core.Metadata.Edm.AssemblyCacheEntry _cacheEntry;
	}
}
