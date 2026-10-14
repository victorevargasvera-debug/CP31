using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Primitives;
using Microsoft.Practices.Prism.Modularity;

namespace Microsoft.Practices.Prism.MefExtensions.Modularity
{
	// Token: 0x02000005 RID: 5
	[global::System.ComponentModel.Composition.Export]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	public class DownloadedPartCatalogCollection
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002603 File Offset: 0x00000803
		public void Add(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
		{
			this.catalogs.Add(moduleInfo, catalog);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002612 File Offset: 0x00000812
		public global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog Get(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			return this.catalogs[moduleInfo];
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002620 File Offset: 0x00000820
		public bool TryGet(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo, out global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog catalog)
		{
			return this.catalogs.TryGetValue(moduleInfo, out catalog);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x0000262F File Offset: 0x0000082F
		public void Remove(global::Microsoft.Practices.Prism.Modularity.ModuleInfo moduleInfo)
		{
			this.catalogs.Remove(moduleInfo);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000263E File Offset: 0x0000083E
		public void Clear()
		{
			this.catalogs.Clear();
		}

		// Token: 0x04000003 RID: 3
		private global::System.Collections.Generic.Dictionary<global::Microsoft.Practices.Prism.Modularity.ModuleInfo, global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog> catalogs = new global::System.Collections.Generic.Dictionary<global::Microsoft.Practices.Prism.Modularity.ModuleInfo, global::System.ComponentModel.Composition.Primitives.ComposablePartCatalog>();
	}
}
