using System;
using System.Collections.Specialized;
using System.Linq;
using System.Windows.Controls;
using System.Windows.Data;
using Microsoft.Practices.Prism.Properties;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200005D RID: 93
	public class ContentControlRegionAdapter : global::Microsoft.Practices.Prism.Regions.RegionAdapterBase<global::System.Windows.Controls.ContentControl>
	{
		// Token: 0x060002C1 RID: 705 RVA: 0x00008740 File Offset: 0x00006940
		public ContentControlRegionAdapter(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
		{
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x000087A4 File Offset: 0x000069A4
		protected override void Adapt(global::Microsoft.Practices.Prism.Regions.IRegion region, global::System.Windows.Controls.ContentControl regionTarget)
		{
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			bool flag = regionTarget.Content != null || global::System.Windows.Data.BindingOperations.GetBinding(regionTarget, global::System.Windows.Controls.ContentControl.ContentProperty) != null;
			if (flag)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.ContentControlHasContentException);
			}
			region.ActiveViews.CollectionChanged += delegate(object A_1, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs A_2)
			{
				regionTarget.Content = region.ActiveViews.FirstOrDefault<object>();
			};
			region.Views.CollectionChanged += delegate(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
			{
				if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add && region.ActiveViews.Count<object>() == 0)
				{
					region.Activate(e.NewItems[0]);
				}
			};
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000884D File Offset: 0x00006A4D
		protected override global::Microsoft.Practices.Prism.Regions.IRegion CreateRegion()
		{
			return new global::Microsoft.Practices.Prism.Regions.SingleActiveRegion();
		}
	}
}
