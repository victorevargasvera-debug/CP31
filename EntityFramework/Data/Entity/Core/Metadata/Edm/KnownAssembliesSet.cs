using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Core.Metadata.Edm
{
	// Token: 0x0200050C RID: 1292
	internal class KnownAssembliesSet
	{
		// Token: 0x06003FD1 RID: 16337 RVA: 0x000D38C0 File Offset: 0x000D1AC0
		internal KnownAssembliesSet()
		{
			this._assemblies = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry>();
		}

		// Token: 0x06003FD2 RID: 16338 RVA: 0x000D38D3 File Offset: 0x000D1AD3
		internal KnownAssembliesSet(global::System.Data.Entity.Core.Metadata.Edm.KnownAssembliesSet set)
		{
			this._assemblies = new global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry>(set._assemblies);
		}

		// Token: 0x06003FD3 RID: 16339 RVA: 0x000D38EC File Offset: 0x000D1AEC
		internal virtual bool TryGetKnownAssembly(global::System.Reflection.Assembly assembly, object loaderCookie, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection, out global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry entry)
		{
			return this._assemblies.TryGetValue(assembly, out entry) && entry.HaveSeenInCompatibleContext(loaderCookie, itemCollection);
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06003FD4 RID: 16340 RVA: 0x000D390F File Offset: 0x000D1B0F
		internal global::System.Collections.Generic.IEnumerable<global::System.Reflection.Assembly> Assemblies
		{
			get
			{
				return this._assemblies.Keys;
			}
		}

		// Token: 0x06003FD5 RID: 16341 RVA: 0x000D391C File Offset: 0x000D1B1C
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry> GetEntries(object loaderCookie, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection)
		{
			return from e in this._assemblies.Values
			where e.HaveSeenInCompatibleContext(loaderCookie, itemCollection)
			select e;
		}

		// Token: 0x06003FD6 RID: 16342 RVA: 0x000D395C File Offset: 0x000D1B5C
		internal bool Contains(global::System.Reflection.Assembly assembly, object loaderCookie, global::System.Data.Entity.Core.Metadata.Edm.EdmItemCollection itemCollection)
		{
			global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry;
			return this.TryGetKnownAssembly(assembly, loaderCookie, itemCollection, out knownAssemblyEntry);
		}

		// Token: 0x06003FD7 RID: 16343 RVA: 0x000D3974 File Offset: 0x000D1B74
		internal void Add(global::System.Reflection.Assembly assembly, global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry)
		{
			global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry knownAssemblyEntry2;
			if (this._assemblies.TryGetValue(assembly, out knownAssemblyEntry2))
			{
				this._assemblies[assembly] = knownAssemblyEntry;
				return;
			}
			this._assemblies.Add(assembly, knownAssemblyEntry);
		}

		// Token: 0x04001645 RID: 5701
		private readonly global::System.Collections.Generic.Dictionary<global::System.Reflection.Assembly, global::System.Data.Entity.Core.Metadata.Edm.KnownAssemblyEntry> _assemblies;
	}
}
