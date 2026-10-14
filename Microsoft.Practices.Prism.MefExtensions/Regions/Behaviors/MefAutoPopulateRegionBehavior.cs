using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x0200000E RID: 14
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.AutoPopulateRegionBehavior))]
	public class MefAutoPopulateRegionBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.AutoPopulateRegionBehavior
	{
		// Token: 0x06000062 RID: 98 RVA: 0x00003018 File Offset: 0x00001218
		[global::System.ComponentModel.Composition.ImportingConstructor]
		public MefAutoPopulateRegionBehavior(global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry regionViewRegistry) : base(regionViewRegistry)
		{
		}
	}
}
