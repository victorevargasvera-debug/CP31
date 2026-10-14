using System;
using System.Windows.Controls.Primitives;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007E RID: 126
	public class SelectorRegionAdapter : global::Microsoft.Practices.Prism.Regions.RegionAdapterBase<global::System.Windows.Controls.Primitives.Selector>
	{
		// Token: 0x06000374 RID: 884 RVA: 0x00009C48 File Offset: 0x00007E48
		public SelectorRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00009C51 File Offset: 0x00007E51
		protected override void Adapt(global::Microsoft.Practices.Prism.Regions.IRegion region, global::System.Windows.Controls.Primitives.Selector regionTarget)
		{
		}

		// Token: 0x06000376 RID: 886 RVA: 0x00009C54 File Offset: 0x00007E54
		protected override void AttachBehaviors(global::Microsoft.Practices.Prism.Regions.IRegion region, global::System.Windows.Controls.Primitives.Selector regionTarget)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			region.Behaviors.Add(global::Microsoft.Practices.Prism.Regions.Behaviors.SelectorItemsSourceSyncBehavior.BehaviorKey, new global::Microsoft.Practices.Prism.Regions.Behaviors.SelectorItemsSourceSyncBehavior
			{
				HostControl = regionTarget
			});
			base.AttachBehaviors(region, regionTarget);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x00009C95 File Offset: 0x00007E95
		protected override global::Microsoft.Practices.Prism.Regions.IRegion CreateRegion()
		{
			return new global::Microsoft.Practices.Prism.Regions.Region();
		}
	}
}
