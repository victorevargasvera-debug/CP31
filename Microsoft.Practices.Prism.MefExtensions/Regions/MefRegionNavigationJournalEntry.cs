using System;
using System.ComponentModel.Composition;
using Microsoft.Practices.Prism.Regions;

namespace Microsoft.Practices.Prism.MefExtensions.Regions
{
	// Token: 0x0200001E RID: 30
	[global::System.ComponentModel.Composition.PartCreationPolicy(global::System.ComponentModel.Composition.CreationPolicy.NonShared)]
	[global::System.ComponentModel.Composition.Export(typeof(global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry))]
	public class MefRegionNavigationJournalEntry : global::Microsoft.Practices.Prism.Regions.RegionNavigationJournalEntry
	{
	}
}
