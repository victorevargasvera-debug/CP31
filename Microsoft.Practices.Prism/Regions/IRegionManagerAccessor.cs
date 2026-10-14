using System;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200005E RID: 94
	public interface IRegionManagerAccessor
	{
		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060002C4 RID: 708
		// (remove) Token: 0x060002C5 RID: 709
		event global::System.EventHandler UpdatingRegions;

		// Token: 0x060002C6 RID: 710
		string GetRegionName(global::System.Windows.DependencyObject element);

		// Token: 0x060002C7 RID: 711
		global::Microsoft.Practices.Prism.Regions.IRegionManager GetRegionManager(global::System.Windows.DependencyObject element);
	}
}
