using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Windows;

namespace Microsoft.Practices.Prism.Regions.Behaviors
{
	// Token: 0x02000055 RID: 85
	public class RegionActiveAwareBehavior : global::Microsoft.Practices.Prism.Regions.IRegionBehavior
	{
		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x0600027E RID: 638 RVA: 0x00007986 File Offset: 0x00005B86
		// (set) Token: 0x0600027F RID: 639 RVA: 0x0000798E File Offset: 0x00005B8E
		public global::Microsoft.Practices.Prism.Regions.IRegion Region { get; set; }

		// Token: 0x06000280 RID: 640 RVA: 0x00007998 File Offset: 0x00005B98
		public void Attach()
		{
			global::System.Collections.Specialized.INotifyCollectionChanged collection = this.GetCollection();
			if (collection != null)
			{
				collection.CollectionChanged += this.OnCollectionChanged;
			}
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000079C4 File Offset: 0x00005BC4
		public void Detach()
		{
			global::System.Collections.Specialized.INotifyCollectionChanged collection = this.GetCollection();
			if (collection != null)
			{
				collection.CollectionChanged -= this.OnCollectionChanged;
			}
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000079F0 File Offset: 0x00005BF0
		private static void InvokeOnActiveAwareElement(object item, global::System.Action<global::Microsoft.Practices.Prism.IActiveAware> invocation)
		{
			global::Microsoft.Practices.Prism.IActiveAware activeAware = item as global::Microsoft.Practices.Prism.IActiveAware;
			if (activeAware != null)
			{
				invocation(activeAware);
			}
			global::System.Windows.FrameworkElement frameworkElement = item as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				global::Microsoft.Practices.Prism.IActiveAware activeAware2 = frameworkElement.DataContext as global::Microsoft.Practices.Prism.IActiveAware;
				if (activeAware2 != null)
				{
					invocation(activeAware2);
				}
			}
		}

		// Token: 0x06000283 RID: 643 RVA: 0x00007A40 File Offset: 0x00005C40
		private void OnCollectionChanged(object sender, global::System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
		{
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Add)
			{
				using (global::System.Collections.IEnumerator enumerator = e.NewItems.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						object item = enumerator.Current;
						global::System.Action<global::Microsoft.Practices.Prism.IActiveAware> invocation = delegate(global::Microsoft.Practices.Prism.IActiveAware activeAware)
						{
							activeAware.IsActive = true;
						};
						global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior.InvokeOnActiveAwareElement(item, invocation);
						this.InvokeOnSynchronizedActiveAwareChildren(item, invocation);
					}
					return;
				}
			}
			if (e.Action == global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove)
			{
				foreach (object item2 in e.OldItems)
				{
					global::System.Action<global::Microsoft.Practices.Prism.IActiveAware> invocation2 = delegate(global::Microsoft.Practices.Prism.IActiveAware activeAware)
					{
						activeAware.IsActive = false;
					};
					global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior.InvokeOnActiveAwareElement(item2, invocation2);
					this.InvokeOnSynchronizedActiveAwareChildren(item2, invocation2);
				}
			}
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00007B50 File Offset: 0x00005D50
		private void InvokeOnSynchronizedActiveAwareChildren(object item, global::System.Action<global::Microsoft.Practices.Prism.IActiveAware> invocation)
		{
			global::System.Windows.DependencyObject dependencyObject = item as global::System.Windows.DependencyObject;
			if (dependencyObject != null)
			{
				global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager = global::Microsoft.Practices.Prism.Regions.RegionManager.GetRegionManager(dependencyObject);
				if (regionManager == null || regionManager == this.Region.RegionManager)
				{
					return;
				}
				global::System.Collections.Generic.IEnumerable<object> source = regionManager.Regions.SelectMany((global::Microsoft.Practices.Prism.Regions.IRegion e) => e.ActiveViews);
				global::System.Collections.Generic.IEnumerable<object> enumerable = source.Where(new global::System.Func<object, bool>(this.ShouldSyncActiveState));
				foreach (object item2 in enumerable)
				{
					global::Microsoft.Practices.Prism.Regions.Behaviors.RegionActiveAwareBehavior.InvokeOnActiveAwareElement(item2, invocation);
				}
			}
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00007C04 File Offset: 0x00005E04
		private bool ShouldSyncActiveState(object view)
		{
			if (global::System.Attribute.IsDefined(view.GetType(), typeof(global::Microsoft.Practices.Prism.Regions.SyncActiveStateAttribute)))
			{
				return true;
			}
			global::System.Windows.FrameworkElement frameworkElement = view as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				object dataContext = frameworkElement.DataContext;
				return dataContext != null && global::System.Attribute.IsDefined(dataContext.GetType(), typeof(global::Microsoft.Practices.Prism.Regions.SyncActiveStateAttribute));
			}
			return false;
		}

		// Token: 0x06000286 RID: 646 RVA: 0x00007C57 File Offset: 0x00005E57
		private global::System.Collections.Specialized.INotifyCollectionChanged GetCollection()
		{
			return this.Region.ActiveViews;
		}

		// Token: 0x04000092 RID: 146
		public const string BehaviorKey = "ActiveAware";
	}
}
