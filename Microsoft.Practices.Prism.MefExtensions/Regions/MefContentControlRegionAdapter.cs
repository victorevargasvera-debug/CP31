using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x02000017 RID: 23
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.ContentControlRegionAdapter))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	public class MefContentControlRegionAdapter : global::Microsoft.Practices.Prism.Regions.ContentControlRegionAdapter
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00003062 File Offset: 0x00001262
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefContentControlRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}
	}
}
