using System;
using System.Globalization;
using System.Windows;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.Prism.Regions.Behaviors;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200005C RID: 92
	public abstract class RegionAdapterBase<T> : global::Microsoft.Practices.Prism.Regions.IRegionAdapter where T : class
	{
		// Token: 0x060002B6 RID: 694 RVA: 0x00008581 File Offset: 0x00006781
		protected RegionAdapterBase(global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory)
		{
			this.RegionBehaviorFactory = regionBehaviorFactory;
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002B7 RID: 695 RVA: 0x00008590 File Offset: 0x00006790
		// (set) Token: 0x060002B8 RID: 696 RVA: 0x00008598 File Offset: 0x00006798
		protected global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory RegionBehaviorFactory { get; set; }

		// Token: 0x060002B9 RID: 697 RVA: 0x000085A4 File Offset: 0x000067A4
		public global::Microsoft.Practices.Prism.Regions.IRegion Initialize(T regionTarget, string regionName)
		{
			if (regionName == null)
			{
				throw new global::System.ArgumentNullException("regionName");
			}
			global::Microsoft.Practices.Prism.Regions.IRegion region = this.CreateRegion();
			region.Name = regionName;
			global::Microsoft.Practices.Prism.Regions.RegionAdapterBase<T>.SetObservableRegionOnHostingControl(region, regionTarget);
			this.Adapt(region, regionTarget);
			this.AttachBehaviors(region, regionTarget);
			this.AttachDefaultBehaviors(region, regionTarget);
			return region;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000085ED File Offset: 0x000067ED
		global::Microsoft.Practices.Prism.Regions.IRegion global::Microsoft.Practices.Prism.Regions.IRegionAdapter.Initialize(object regionTarget, string regionName)
		{
			return this.Initialize(global::Microsoft.Practices.Prism.Regions.RegionAdapterBase<T>.GetCastedObject(regionTarget), regionName);
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000085FC File Offset: 0x000067FC
		protected virtual void AttachDefaultBehaviors(global::Microsoft.Practices.Prism.Regions.IRegion region, T regionTarget)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			global::Microsoft.Practices.Prism.Regions.IRegionBehaviorFactory regionBehaviorFactory = this.RegionBehaviorFactory;
			if (regionBehaviorFactory != null)
			{
				global::System.Windows.DependencyObject dependencyObject = regionTarget as global::System.Windows.DependencyObject;
				foreach (string key in regionBehaviorFactory)
				{
					if (!region.Behaviors.ContainsKey(key))
					{
						global::Microsoft.Practices.Prism.Regions.IRegionBehavior regionBehavior = regionBehaviorFactory.CreateFromKey(key);
						if (dependencyObject != null)
						{
							global::Microsoft.Practices.Prism.Regions.Behaviors.IHostAwareRegionBehavior hostAwareRegionBehavior = regionBehavior as global::Microsoft.Practices.Prism.Regions.Behaviors.IHostAwareRegionBehavior;
							if (hostAwareRegionBehavior != null)
							{
								hostAwareRegionBehavior.HostControl = dependencyObject;
							}
						}
						region.Behaviors.Add(key, regionBehavior);
					}
				}
			}
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000086B4 File Offset: 0x000068B4
		protected virtual void AttachBehaviors(global::Microsoft.Practices.Prism.Regions.IRegion region, T regionTarget)
		{
		}

		// Token: 0x060002BD RID: 701
		protected abstract void Adapt(global::Microsoft.Practices.Prism.Regions.IRegion region, T regionTarget);

		// Token: 0x060002BE RID: 702
		protected abstract global::Microsoft.Practices.Prism.Regions.IRegion CreateRegion();

		// Token: 0x060002BF RID: 703 RVA: 0x000086B8 File Offset: 0x000068B8
		private static T GetCastedObject(object regionTarget)
		{
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			T t = regionTarget as T;
			if (t == null)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.Practices.Prism.Properties.Resources.AdapterInvalidTypeException, new object[]
				{
					typeof(T).Name
				}));
			}
			return t;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x00008718 File Offset: 0x00006918
		private static void SetObservableRegionOnHostingControl(global::Microsoft.Practices.Prism.Regions.IRegion region, T regionTarget)
		{
			global::System.Windows.DependencyObject dependencyObject = regionTarget as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.GetObservableRegion(dependencyObject).Value = region;
			}
		}
	}
}
