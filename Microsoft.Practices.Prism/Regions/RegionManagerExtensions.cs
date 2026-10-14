using System;
using System.Globalization;
using System.Threading;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000084 RID: 132
	public static class RegionManagerExtensions
	{
		// Token: 0x06000385 RID: 901 RVA: 0x00009D48 File Offset: 0x00007F48
		public static global::Microsoft.Practices.Prism.Regions.IRegionManager AddToRegion(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, object view)
		{
			if (regionManager == null)
			{
				throw new global::System.ArgumentNullException("regionManager");
			}
			if (!regionManager.Regions.ContainsRegionWithName(regionName))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Threading.Thread.CurrentThread.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionNotFound, new object[]
				{
					regionName
				}), "regionName");
			}
			global::Microsoft.Practices.Prism.Regions.IRegion region = regionManager.Regions[regionName];
			return region.Add(view);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00009DB0 File Offset: 0x00007FB0
		public static global::Microsoft.Practices.Prism.Regions.IRegionManager RegisterViewWithRegion(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, global::System.Type viewType)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry>();
			instance.RegisterViewWithRegion(regionName, viewType);
			return regionManager;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00009DD4 File Offset: 0x00007FD4
		public static global::Microsoft.Practices.Prism.Regions.IRegionManager RegisterViewWithRegion(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, global::System.Func<object> getContentDelegate)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry instance = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry>();
			instance.RegisterViewWithRegion(regionName, getContentDelegate);
			return regionManager;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00009DF8 File Offset: 0x00007FF8
		public static void Add(this global::Microsoft.Practices.Prism.Regions.IRegionCollection regionCollection, string regionName, global::Microsoft.Practices.Prism.Regions.IRegion region)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			if (regionCollection == null)
			{
				throw new global::System.ArgumentNullException("regionCollection");
			}
			if (region.Name != null && region.Name != regionName)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionManagerWithDifferentNameException, new object[]
				{
					region.Name,
					regionName
				}), "regionName");
			}
			if (region.Name == null)
			{
				region.Name = regionName;
			}
			regionCollection.Add(region);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00009E7C File Offset: 0x0000807C
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, global::System.Uri source, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			if (regionManager == null)
			{
				throw new global::System.ArgumentNullException("regionManager");
			}
			if (navigationCallback == null)
			{
				throw new global::System.ArgumentNullException("navigationCallback");
			}
			if (regionManager.Regions.ContainsRegionWithName(regionName))
			{
				regionManager.Regions[regionName].RequestNavigate(source, navigationCallback);
				return;
			}
			navigationCallback(new global::Microsoft.Practices.Prism.Regions.NavigationResult(new global::Microsoft.Practices.Prism.Regions.NavigationContext(null, source), new bool?(false)));
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00009EE1 File Offset: 0x000080E1
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, global::System.Uri source)
		{
			regionManager.RequestNavigate(regionName, source, delegate(global::Microsoft.Practices.Prism.Regions.NavigationResult nr)
			{
			});
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00009F08 File Offset: 0x00008108
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, string source, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			regionManager.RequestNavigate(regionName, new global::System.Uri(source, global::System.UriKind.RelativeOrAbsolute), navigationCallback);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00009F29 File Offset: 0x00008129
		public static void RequestNavigate(this global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager, string regionName, string source)
		{
			regionManager.RequestNavigate(regionName, source, delegate(global::Microsoft.Practices.Prism.Regions.NavigationResult nr)
			{
			});
		}
	}
}
