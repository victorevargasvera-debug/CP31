using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x02000011 RID: 17
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.DelayedRegionCreationBehavior))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefDelayedRegionCreationBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.DelayedRegionCreationBehavior
	{
		// Token: 0x06000065 RID: 101 RVA: 0x00003031 File Offset: 0x00001231
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefDelayedRegionCreationBehavior(global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings regionAdapterMappings) : base(regionAdapterMappings)
		{
		}
	}
}
