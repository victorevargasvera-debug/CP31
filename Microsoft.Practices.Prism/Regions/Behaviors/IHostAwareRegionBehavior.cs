using System;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000054 RID: 84
	public interface IHostAwareRegionBehavior : global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x0600027C RID: 636
		// (set) Token: 0x0600027D RID: 637
		global::System.Windows.DependencyObject HostControl { get; set; }
	}
}
