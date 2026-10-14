using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x02000010 RID: 16
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior))]
	public class MefClearChildViewsRegionBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.ClearChildViewsRegionBehavior
	{
	}
}
