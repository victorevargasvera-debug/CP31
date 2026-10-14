using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x0200001A RID: 26
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.Shared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings))]
	public class MefRegionAdapterMappings : global::Microsoft.Practices.Prism.Regions.RegionAdapterMappings
	{
	}
}
