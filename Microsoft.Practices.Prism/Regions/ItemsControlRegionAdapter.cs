using System;
using System.Collections;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000068 RID: 104
	public class ItemsControlRegionAdapter : global::Microsoft.Practices.Prism.Regions.RegionAdapterBase<global::System.Windows.Controls.ItemsControl>
	{
		// Token: 0x060002F5 RID: 757 RVA: 0x00008A2D File Offset: 0x00006C2D
		public ItemsControlRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x00008A38 File Offset: 0x00006C38
		protected override void Adapt(global::Microsoft.Practices.Prism.Regions.IRegion region, global::System.Windows.Controls.ItemsControl regionTarget)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			bool flag = regionTarget.ItemsSource != null || global::System.Windows.Data.BindingOperations.GetBinding(regionTarget, global::System.Windows.Controls.ItemsControl.ItemsSourceProperty) != null;
			if (flag)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.ItemsControlHasItemsSourceException);
			}
			if (regionTarget.Items.Count > 0)
			{
				foreach (object view in ((global::System.Collections.IEnumerable)regionTarget.Items))
				{
					region.Add(view);
				}
				regionTarget.Items.Clear();
			}
			regionTarget.ItemsSource = region.Views;
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x00008B04 File Offset: 0x00006D04
		protected override global::Microsoft.Practices.Prism.Regions.IRegion CreateRegion()
		{
			return new global::Microsoft.Practices.Prism.Regions.AllActiveRegion();
		}
	}
}
