using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Windows;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.Prism.Regions.Behaviors;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000075 RID: 117
	public class RegionManager : global::Microsoft.Practices.Prism.Regions.IRegionManager
	{
		// Token: 0x0600032B RID: 811 RVA: 0x000091C8 File Offset: 0x000073C8
		public static void SetRegionName(global::System.Windows.DependencyObject regionTarget, string regionName)
		{
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			regionTarget.SetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionNameProperty, regionName);
		}

		// Token: 0x0600032C RID: 812 RVA: 0x000091E4 File Offset: 0x000073E4
		public static string GetRegionName(global::System.Windows.DependencyObject regionTarget)
		{
			if (regionTarget == null)
			{
				throw new global::System.ArgumentNullException("regionTarget");
			}
			return regionTarget.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionNameProperty) as string;
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00009204 File Offset: 0x00007404
		public static global::Microsoft.Practices.Prism.ObservableObject<global::Microsoft.Practices.Prism.Regions.IRegion> GetObservableRegion(global::System.Windows.DependencyObject view)
		{
			if (view == null)
			{
				throw new global::System.ArgumentNullException("view");
			}
			global::Microsoft.Practices.Prism.ObservableObject<global::Microsoft.Practices.Prism.Regions.IRegion> observableObject = view.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.ObservableRegionProperty) as global::Microsoft.Practices.Prism.ObservableObject<global::Microsoft.Practices.Prism.Regions.IRegion>;
			if (observableObject == null)
			{
				observableObject = new global::Microsoft.Practices.Prism.ObservableObject<global::Microsoft.Practices.Prism.Regions.IRegion>();
				view.SetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.ObservableRegionProperty, observableObject);
			}
			return observableObject;
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00009246 File Offset: 0x00007446
		private static void OnSetRegionNameCallback(global::System.Windows.DependencyObject element, global::System.Windows.DependencyPropertyChangedEventArgs args)
		{
			if (!global::Microsoft.Practices.Prism.Regions.RegionManager.IsInDesignMode(element))
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.CreateRegion(element);
			}
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00009258 File Offset: 0x00007458
		private static void CreateRegion(global::System.Windows.DependencyObject element)
		{
			global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator = global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current;
			global::Microsoft.Practices.Prism.Regions.Behaviors.DelayedRegionCreationBehavior instance = serviceLocator.GetInstance<global::Microsoft.Practices.Prism.Regions.Behaviors.DelayedRegionCreationBehavior>();
			instance.TargetElement = element;
			instance.Attach();
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000927F File Offset: 0x0000747F
		public static global::Microsoft.Practices.Prism.Regions.IRegionManager GetRegionManager(global::System.Windows.DependencyObject target)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			return (global::Microsoft.Practices.Prism.Regions.IRegionManager)target.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty);
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000929F File Offset: 0x0000749F
		public static void SetRegionManager(global::System.Windows.DependencyObject target, global::Microsoft.Practices.Prism.Regions.IRegionManager value)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			target.SetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionManagerProperty, value);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x000092BB File Offset: 0x000074BB
		private static void OnRegionContextChanged(global::System.Windows.DependencyObject depObj, global::System.Windows.DependencyPropertyChangedEventArgs e)
		{
			if (global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(depObj).Value != e.NewValue)
			{
				global::Microsoft.Practices.Prism.Regions.RegionContext.GetObservableContext(depObj).Value = e.NewValue;
			}
		}

		// Token: 0x06000333 RID: 819 RVA: 0x000092E3 File Offset: 0x000074E3
		public static object GetRegionContext(global::System.Windows.DependencyObject target)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			return target.GetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionContextProperty);
		}

		// Token: 0x06000334 RID: 820 RVA: 0x000092FE File Offset: 0x000074FE
		public static void SetRegionContext(global::System.Windows.DependencyObject target, object value)
		{
			if (target == null)
			{
				throw new global::System.ArgumentNullException("target");
			}
			target.SetValue(global::Microsoft.Practices.Prism.Regions.RegionManager.RegionContextProperty, value);
		}

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000335 RID: 821 RVA: 0x0000931A File Offset: 0x0000751A
		// (remove) Token: 0x06000336 RID: 822 RVA: 0x00009327 File Offset: 0x00007527
		public static event global::System.EventHandler UpdatingRegions
		{
			add
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.updatingRegionsListeners.AddListener(value);
			}
			remove
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.updatingRegionsListeners.RemoveListener(value);
			}
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00009334 File Offset: 0x00007534
		public static void UpdateRegions()
		{
			try
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.updatingRegionsListeners.Raise(new object[]
				{
					null,
					global::System.EventArgs.Empty
				});
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				global::System.Exception rootException = ex.GetRootException();
				throw new global::Microsoft.Practices.Prism.Regions.UpdateRegionsException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.UpdateRegionException, new object[]
				{
					rootException
				}), ex.InnerException);
			}
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000939C File Offset: 0x0000759C
		private static bool IsInDesignMode(global::System.Windows.DependencyObject element)
		{
			return global::System.ComponentModel.DesignerProperties.GetIsInDesignMode(element) || global::System.Windows.Application.Current == null || global::System.Windows.Application.Current.GetType() == typeof(global::System.Windows.Application);
		}

		// Token: 0x06000339 RID: 825 RVA: 0x000093C8 File Offset: 0x000075C8
		public RegionManager()
		{
			this.regionCollection = new global::Microsoft.Practices.Prism.Regions.RegionManager.RegionCollection(this);
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x0600033A RID: 826 RVA: 0x000093DC File Offset: 0x000075DC
		public global::Microsoft.Practices.Prism.Regions.IRegionCollection Regions
		{
			get
			{
				return this.regionCollection;
			}
		}

		// Token: 0x0600033B RID: 827 RVA: 0x000093E4 File Offset: 0x000075E4
		public global::Microsoft.Practices.Prism.Regions.IRegionManager CreateRegionManager()
		{
			return new global::Microsoft.Practices.Prism.Regions.RegionManager();
		}

		// Token: 0x040000B7 RID: 183
		private static readonly global::Microsoft.Practices.Prism.Events.WeakDelegatesManager updatingRegionsListeners = new global::Microsoft.Practices.Prism.Events.WeakDelegatesManager();

		// Token: 0x040000B8 RID: 184
		public static readonly global::System.Windows.DependencyProperty RegionNameProperty = global::System.Windows.DependencyProperty.RegisterAttached("RegionName", typeof(string), typeof(global::Microsoft.Practices.Prism.Regions.RegionManager), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.Regions.RegionManager.OnSetRegionNameCallback)));

		// Token: 0x040000B9 RID: 185
		private static readonly global::System.Windows.DependencyProperty ObservableRegionProperty = global::System.Windows.DependencyProperty.RegisterAttached("ObservableRegion", typeof(global::Microsoft.Practices.Prism.ObservableObject<global::Microsoft.Practices.Prism.Regions.IRegion>), typeof(global::Microsoft.Practices.Prism.Regions.RegionManager), null);

		// Token: 0x040000BA RID: 186
		public static readonly global::System.Windows.DependencyProperty RegionManagerProperty = global::System.Windows.DependencyProperty.RegisterAttached("RegionManager", typeof(global::Microsoft.Practices.Prism.Regions.IRegionManager), typeof(global::Microsoft.Practices.Prism.Regions.RegionManager), null);

		// Token: 0x040000BB RID: 187
		public static readonly global::System.Windows.DependencyProperty RegionContextProperty = global::System.Windows.DependencyProperty.RegisterAttached("RegionContext", typeof(object), typeof(global::Microsoft.Practices.Prism.Regions.RegionManager), new global::System.Windows.PropertyMetadata(new global::System.Windows.PropertyChangedCallback(global::Microsoft.Practices.Prism.Regions.RegionManager.OnRegionContextChanged)));

		// Token: 0x040000BC RID: 188
		private readonly global::Microsoft.Practices.Prism.Regions.RegionManager.RegionCollection regionCollection;

		// Token: 0x02000077 RID: 119
		private class RegionCollection : global::Microsoft.Practices.Prism.Regions.IRegionCollection, global::System.Collections.Generic.IEnumerable<global::Microsoft.Practices.Prism.Regions.IRegion>, global::System.Collections.IEnumerable, global::System.Collections.Specialized.INotifyCollectionChanged
		{
			// Token: 0x06000341 RID: 833 RVA: 0x000094B3 File Offset: 0x000076B3
			public RegionCollection(global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager)
			{
				this.regionManager = regionManager;
				this.regions = new global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Regions.IRegion>();
			}

			// Token: 0x14000017 RID: 23
			// (add) Token: 0x06000342 RID: 834 RVA: 0x000094D0 File Offset: 0x000076D0
			// (remove) Token: 0x06000343 RID: 835 RVA: 0x00009508 File Offset: 0x00007708
			public event global::System.Collections.Specialized.NotifyCollectionChangedEventHandler CollectionChanged;

			// Token: 0x06000344 RID: 836 RVA: 0x0000953D File Offset: 0x0000773D
			public global::System.Collections.Generic.IEnumerator<global::Microsoft.Practices.Prism.Regions.IRegion> GetEnumerator()
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
				return this.regions.GetEnumerator();
			}

			// Token: 0x06000345 RID: 837 RVA: 0x00009554 File Offset: 0x00007754
			global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
			{
				return this.GetEnumerator();
			}

			// Token: 0x170000C3 RID: 195
			public global::Microsoft.Practices.Prism.Regions.IRegion this[string regionName]
			{
				get
				{
					global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
					global::Microsoft.Practices.Prism.Regions.IRegion regionByName = this.GetRegionByName(regionName);
					if (regionByName == null)
					{
						throw new global::System.Collections.Generic.KeyNotFoundException(string.Format(global::System.Globalization.CultureInfo.CurrentUICulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionNotInRegionManagerException, new object[]
						{
							regionName
						}));
					}
					return regionByName;
				}
			}

			// Token: 0x06000347 RID: 839 RVA: 0x0000959C File Offset: 0x0000779C
			public void Add(global::Microsoft.Practices.Prism.Regions.IRegion region)
			{
				if (region == null)
				{
					throw new global::System.ArgumentNullException("region");
				}
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
				if (region.Name == null)
				{
					throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.RegionNameCannotBeEmptyException);
				}
				if (this.GetRegionByName(region.Name) != null)
				{
					throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.InvariantCulture, global::Microsoft.Practices.Prism.Properties.Resources.RegionNameExistsException, new object[]
					{
						region.Name
					}));
				}
				this.regions.Add(region);
				region.RegionManager = this.regionManager;
				this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Add, region, 0));
			}

			// Token: 0x06000348 RID: 840 RVA: 0x0000962C File Offset: 0x0000782C
			public bool Remove(string regionName)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
				bool result = false;
				global::Microsoft.Practices.Prism.Regions.IRegion regionByName = this.GetRegionByName(regionName);
				if (regionByName != null)
				{
					result = true;
					this.regions.Remove(regionByName);
					regionByName.RegionManager = null;
					this.OnCollectionChanged(new global::System.Collections.Specialized.NotifyCollectionChangedEventArgs(global::System.Collections.Specialized.NotifyCollectionChangedAction.Remove, regionByName, 0));
				}
				return result;
			}

			// Token: 0x06000349 RID: 841 RVA: 0x00009670 File Offset: 0x00007870
			public bool ContainsRegionWithName(string regionName)
			{
				global::Microsoft.Practices.Prism.Regions.RegionManager.UpdateRegions();
				return this.GetRegionByName(regionName) != null;
			}

			// Token: 0x0600034A RID: 842 RVA: 0x000096A0 File Offset: 0x000078A0
			private global::Microsoft.Practices.Prism.Regions.IRegion GetRegionByName(string regionName)
			{
				return this.regions.FirstOrDefault((global::Microsoft.Practices.Prism.Regions.IRegion r) => r.Name == regionName);
			}

			// Token: 0x0600034B RID: 843 RVA: 0x000096D4 File Offset: 0x000078D4
			private void OnCollectionChanged(global::System.Collections.Specialized.NotifyCollectionChangedEventArgs notifyCollectionChangedEventArgs)
			{
				global::System.Collections.Specialized.NotifyCollectionChangedEventHandler collectionChanged = this.CollectionChanged;
				if (collectionChanged != null)
				{
					collectionChanged(this, notifyCollectionChangedEventArgs);
				}
			}

			// Token: 0x040000BD RID: 189
			private readonly global::Microsoft.Practices.Prism.Regions.IRegionManager regionManager;

			// Token: 0x040000BE RID: 190
			private readonly global::System.Collections.Generic.List<global::Microsoft.Practices.Prism.Regions.IRegion> regions;
		}
	}
}
