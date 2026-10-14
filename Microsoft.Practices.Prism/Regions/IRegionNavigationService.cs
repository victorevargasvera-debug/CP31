using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000066 RID: 102
	public interface IRegionNavigationService : global::Microsoft.Practices.Prism.Regions.INavigateAsync
	{
		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x060002E0 RID: 736
		// (set) Token: 0x060002E1 RID: 737
		global::Microsoft.Practices.Prism.Regions.IRegion Region { get; set; }

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x060002E2 RID: 738
		global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal Journal { get; }

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060002E3 RID: 739
		// (remove) Token: 0x060002E4 RID: 740
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs> Navigating;

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x060002E5 RID: 741
		// (remove) Token: 0x060002E6 RID: 742
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs> Navigated;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x060002E7 RID: 743
		// (remove) Token: 0x060002E8 RID: 744
		event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationFailedEventArgs> NavigationFailed;
	}
}
