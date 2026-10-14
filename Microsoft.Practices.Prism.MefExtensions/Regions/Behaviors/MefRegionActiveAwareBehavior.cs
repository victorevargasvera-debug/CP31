using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x02000012 RID: 18
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefRegionActiveAwareBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior
	{
	}
}
