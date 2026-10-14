using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000074 RID: 116
	public interface IRegionManager
	{
		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000329 RID: 809
		global::Microsoft.Practices.Prism.Regions.IRegionCollection Regions { get; }

		// Token: 0x0600032A RID: 810
		global::Microsoft.Practices.Prism.Regions.IRegionManager CreateRegionManager();
	}
}
