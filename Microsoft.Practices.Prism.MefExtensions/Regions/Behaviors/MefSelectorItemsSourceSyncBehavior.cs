using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.MefExtensions.Regions.Behaviors
{
	// Token: 0x02000015 RID: 21
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.Behaviors.SelectorItemsSourceSyncBehavior))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefSelectorItemsSourceSyncBehavior : global::Microsoft.Practices.Prism.Regions.Behaviors.SelectorItemsSourceSyncBehavior
	{
	}
}
