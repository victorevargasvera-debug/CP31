using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x02000018 RID: 24
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.ItemsControlRegionAdapter))]
	public class MefItemsControlRegionAdapter : global::Microsoft.Practices.Prism.Regions.ItemsControlRegionAdapter
	{
		// Token: 0x0600006C RID: 108 RVA: 0x0000306B File Offset: 0x0000126B
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefItemsControlRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}
	}
}
