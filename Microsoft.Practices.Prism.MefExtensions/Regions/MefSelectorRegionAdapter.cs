using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x02000021 RID: 33
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.SelectorRegionAdapter))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	public class MefSelectorRegionAdapter : global::Microsoft.Practices.Prism.Regions.SelectorRegionAdapter
	{
		// Token: 0x06000075 RID: 117 RVA: 0x000030BA File Offset: 0x000012BA
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefSelectorRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}
	}
}
