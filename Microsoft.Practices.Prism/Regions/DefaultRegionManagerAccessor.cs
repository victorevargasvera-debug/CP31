using System;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200005F RID: 95
	internal class DefaultRegionManagerAccessor : global::Microsoft.Practices.Prism.Regions.IRegionManagerAccessor
	{
		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060002C8 RID: 712 RVA: 0x00008854 File Offset: 0x00006A54
		// (remove) Token: 0x060002C9 RID: 713 RVA: 0x0000885C File Offset: 0x00006A5C
		public event global::System.EventHandler UpdatingRegions
		{
			add
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdatingRegions += value;
			}
			remove
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdatingRegions -= value;
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x00008864 File Offset: 0x00006A64
		public string GetRegionName(global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			return element.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionNameProperty) as string;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x00008884 File Offset: 0x00006A84
		public global::Microsoft.Practices.Prism.Regions.IRegionManager GetRegionManager(global::System.Windows.DependencyObject element)
		{
			if (element == null)
			{
				throw new global::System.ArgumentNullException("element");
			}
			return element.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty) as global::Microsoft.Practices.Prism.Regions.IRegionManager;
		}
	}
}
