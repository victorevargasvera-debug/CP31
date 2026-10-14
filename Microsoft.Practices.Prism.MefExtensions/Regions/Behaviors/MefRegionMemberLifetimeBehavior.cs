using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x02000013 RID: 19
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefRegionMemberLifetimeBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00003042 File Offset: 0x00001242
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefRegionMemberLifetimeBehavior()
		{
		}
	}
}
