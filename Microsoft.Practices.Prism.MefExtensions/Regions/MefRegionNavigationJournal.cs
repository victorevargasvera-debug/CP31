using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x0200001D RID: 29
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal))]
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	public class MefRegionNavigationJournal : global::Microsoft.Practices.Prism.Regions.RegionNavigationJournal
	{
	}
}
