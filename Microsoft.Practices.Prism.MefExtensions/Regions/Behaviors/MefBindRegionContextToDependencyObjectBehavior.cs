using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x0200000F RID: 15
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior))]
	public class MefBindRegionContextToDependencyObjectBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.BindRegionContextToDependencyObjectBehavior
	{
	}
}
