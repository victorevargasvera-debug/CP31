using System;
using Microsoft.Practices.Prism.Regions;

namespace Motorola.CommonCPS.RadioManagement.Infrastructure
{
	// Token: 0x02000028 RID: 40
	public interface IRegionManagerAware
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000081 RID: 129
		// (set) Token: 0x06000082 RID: 130
		global::Microsoft.Practices.Prism.Regions.IRegionManager RegionManager { get; set; }
	}
}
