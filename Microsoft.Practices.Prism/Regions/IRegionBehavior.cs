using System;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200004E RID: 78
	public interface IRegionBehavior
	{
		// Token: 0x1700009E RID: 158
		// (get) Token: 0x0600024D RID: 589
		// (set) Token: 0x0600024E RID: 590
		global::Microsoft.Practices.Prism.Regions.IRegion Region { get; set; }

		// Token: 0x0600024F RID: 591
		void Attach();
	}
}
