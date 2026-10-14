using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000057 RID: 87
	public class RegionMemberLifetimeBehavior : global::Microsoft.Practices.Prism.Regions.RegionBehavior
	{
		// Token: 0x0600028F RID: 655 RVA: 0x00007C91 File Offset: 0x00005E91
		protected override void OnAttach()
		{
			base.Region.ActiveViews.CollectionChanged += this.OnActiveViewsChanged;
		}

		// Token: 0x06000290 RID: 656 RVA: 0x00007CB0 File Offset: 0x00005EB0
		private void OnActiveViewsChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action != global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				return;
			}
			global::System.Collections.IList oldItems = e.OldItems;
			foreach (object obj in oldItems)
			{
				if (!global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior.ShouldKeepAlive(obj))
				{
					base.Region.Remove(obj);
				}
			}
		}

		// Token: 0x06000291 RID: 657 RVA: 0x00007D20 File Offset: 0x00005F20
		private static bool ShouldKeepAlive(object inactiveView)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionMemberLifetime itemOrContextLifetime = global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior.GetItemOrContextLifetime(inactiveView);
			if (itemOrContextLifetime != null)
			{
				return itemOrContextLifetime.KeepAlive;
			}
			global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute itemOrContextLifetimeAttribute = global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior.GetItemOrContextLifetimeAttribute(inactiveView);
			return itemOrContextLifetimeAttribute == null || itemOrContextLifetimeAttribute.KeepAlive;
		}

		// Token: 0x06000292 RID: 658 RVA: 0x00007D50 File Offset: 0x00005F50
		private static global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute GetItemOrContextLifetimeAttribute(object inactiveView)
		{
			global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute regionMemberLifetimeAttribute = global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior.GetCustomAttributes<global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute>(inactiveView.GetType()).FirstOrDefault<global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute>();
			if (regionMemberLifetimeAttribute != null)
			{
				return regionMemberLifetimeAttribute;
			}
			global::System.Windows.FrameworkElement frameworkElement = inactiveView as global::System.Windows.FrameworkElement;
			if (frameworkElement != null && frameworkElement.DataContext != null)
			{
				object dataContext = frameworkElement.DataContext;
				return global::Microsoft.Practices.Prism.Regions.Behaviors.RegionMemberLifetimeBehavior.GetCustomAttributes<global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute>(dataContext.GetType()).FirstOrDefault<global::Microsoft.Practices.Prism.Regions.RegionMemberLifetimeAttribute>();
			}
			return null;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x00007DA0 File Offset: 0x00005FA0
		private static global::Microsoft.Practices.Prism.Regions.IRegionMemberLifetime GetItemOrContextLifetime(object inactiveView)
		{
			global::Microsoft.Practices.Prism.Regions.IRegionMemberLifetime regionMemberLifetime = inactiveView as global::Microsoft.Practices.Prism.Regions.IRegionMemberLifetime;
			if (regionMemberLifetime != null)
			{
				return regionMemberLifetime;
			}
			global::System.Windows.FrameworkElement frameworkElement = inactiveView as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				return frameworkElement.DataContext as global::Microsoft.Practices.Prism.Regions.IRegionMemberLifetime;
			}
			return null;
		}

		// Token: 0x06000294 RID: 660 RVA: 0x00007DD0 File Offset: 0x00005FD0
		private static global::System.Collections.Generic.IEnumerable<T> GetCustomAttributes<T>(global::System.Type type)
		{
			return type.GetCustomAttributes(typeof(T), true).OfType<T>();
		}

		// Token: 0x04000097 RID: 151
		public const string BehaviorKey = "RegionMemberLifetimeBehavior";
	}
}
