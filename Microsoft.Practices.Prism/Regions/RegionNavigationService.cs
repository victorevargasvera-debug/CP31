using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x02000097 RID: 151
	public class RegionNavigationService : global::Microsoft.Practices.Prism.Regions.IRegionNavigationService, global::Microsoft.Practices.Prism.Regions.INavigateAsync
	{
		// Token: 0x060003F9 RID: 1017 RVA: 0x0000B698 File Offset: 0x00009898
		public RegionNavigationService(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator, global::Microsoft.Practices.Prism.Regions.IRegionNavigationContentLoader regionNavigationContentLoader, global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal journal)
		{
			if (serviceLocator == null)
			{
				throw new global::System.ArgumentNullException("serviceLocator");
			}
			if (regionNavigationContentLoader == null)
			{
				throw new global::System.ArgumentNullException("regionNavigationContentLoader");
			}
			if (journal == null)
			{
				throw new global::System.ArgumentNullException("journal");
			}
			this.serviceLocator = serviceLocator;
			this.regionNavigationContentLoader = regionNavigationContentLoader;
			this.journal = journal;
			this.journal.NavigationTarget = this;
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003FA RID: 1018 RVA: 0x0000B6F6 File Offset: 0x000098F6
		// (set) Token: 0x060003FB RID: 1019 RVA: 0x0000B6FE File Offset: 0x000098FE
		public global::Microsoft.Practices.Prism.Regions.IRegion Region { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003FC RID: 1020 RVA: 0x0000B707 File Offset: 0x00009907
		public global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal Journal
		{
			get
			{
				return this.journal;
			}
		}

		// Token: 0x1400001C RID: 28
		// (add) Token: 0x060003FD RID: 1021 RVA: 0x0000B710 File Offset: 0x00009910
		// (remove) Token: 0x060003FE RID: 1022 RVA: 0x0000B748 File Offset: 0x00009948
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs> Navigating;

		// Token: 0x060003FF RID: 1023 RVA: 0x0000B77D File Offset: 0x0000997D
		private void RaiseNavigating(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (this.Navigating != null)
			{
				this.Navigating(this, new global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs(navigationContext));
			}
		}

		// Token: 0x1400001D RID: 29
		// (add) Token: 0x06000400 RID: 1024 RVA: 0x0000B79C File Offset: 0x0000999C
		// (remove) Token: 0x06000401 RID: 1025 RVA: 0x0000B7D4 File Offset: 0x000099D4
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs> Navigated;

		// Token: 0x06000402 RID: 1026 RVA: 0x0000B809 File Offset: 0x00009A09
		private void RaiseNavigated(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (this.Navigated != null)
			{
				this.Navigated(this, new global::Microsoft.Practices.Prism.Regions.RegionNavigationEventArgs(navigationContext));
			}
		}

		// Token: 0x1400001E RID: 30
		// (add) Token: 0x06000403 RID: 1027 RVA: 0x0000B828 File Offset: 0x00009A28
		// (remove) Token: 0x06000404 RID: 1028 RVA: 0x0000B860 File Offset: 0x00009A60
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.RegionNavigationFailedEventArgs> NavigationFailed;

		// Token: 0x06000405 RID: 1029 RVA: 0x0000B895 File Offset: 0x00009A95
		private void RaiseNavigationFailed(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Exception error)
		{
			if (this.NavigationFailed != null)
			{
				this.NavigationFailed(this, new global::Microsoft.Practices.Prism.Regions.RegionNavigationFailedEventArgs(navigationContext, error));
			}
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x0000B8B4 File Offset: 0x00009AB4
		public void RequestNavigate(global::System.Uri target, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			if (navigationCallback == null)
			{
				throw new global::System.ArgumentNullException("navigationCallback");
			}
			try
			{
				this.DoNavigate(target, navigationCallback);
			}
			catch (global::System.Exception e)
			{
				this.NotifyNavigationFailed(new global::Microsoft.Practices.Prism.Regions.NavigationContext(this, target), navigationCallback, e);
			}
		}

		// Token: 0x06000407 RID: 1031 RVA: 0x0000B8FC File Offset: 0x00009AFC
		private void DoNavigate(global::System.Uri source, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			if (source == null)
			{
				throw new global::System.ArgumentNullException("source");
			}
			if (this.Region == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Practices.Prism.Properties.Resources.NavigationServiceHasNoRegion);
			}
			this.currentNavigationContext = new global::Microsoft.Practices.Prism.Regions.NavigationContext(this, source);
			this.RequestCanNavigateFromOnCurrentlyActiveView(this.currentNavigationContext, navigationCallback, this.Region.ActiveViews.ToArray<object>(), 0);
		}

		// Token: 0x06000408 RID: 1032 RVA: 0x0000B9C4 File Offset: 0x00009BC4
		private void RequestCanNavigateFromOnCurrentlyActiveView(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback, object[] activeViews, int currentViewIndex)
		{
			if (currentViewIndex >= activeViews.Length)
			{
				this.ExecuteNavigation(navigationContext, activeViews, navigationCallback);
				return;
			}
			global::Microsoft.Practices.Prism.Regions.IConfirmNavigationRequest confirmNavigationRequest = activeViews[currentViewIndex] as global::Microsoft.Practices.Prism.Regions.IConfirmNavigationRequest;
			if (confirmNavigationRequest != null)
			{
				confirmNavigationRequest.ConfirmNavigationRequest(navigationContext, delegate(bool canNavigate)
				{
					if (this.currentNavigationContext == navigationContext && canNavigate)
					{
						this.RequestCanNavigateFromOnCurrentlyActiveViewModel(navigationContext, navigationCallback, activeViews, currentViewIndex);
						return;
					}
					this.NotifyNavigationFailed(navigationContext, navigationCallback, null);
				});
				return;
			}
			this.RequestCanNavigateFromOnCurrentlyActiveViewModel(navigationContext, navigationCallback, activeViews, currentViewIndex);
		}

		// Token: 0x06000409 RID: 1033 RVA: 0x0000BAE4 File Offset: 0x00009CE4
		private void RequestCanNavigateFromOnCurrentlyActiveViewModel(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback, object[] activeViews, int currentViewIndex)
		{
			global::System.Windows.FrameworkElement frameworkElement = activeViews[currentViewIndex] as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				global::Microsoft.Practices.Prism.Regions.IConfirmNavigationRequest confirmNavigationRequest = frameworkElement.DataContext as global::Microsoft.Practices.Prism.Regions.IConfirmNavigationRequest;
				if (confirmNavigationRequest != null)
				{
					confirmNavigationRequest.ConfirmNavigationRequest(navigationContext, delegate(bool canNavigate)
					{
						if (this.currentNavigationContext == navigationContext && canNavigate)
						{
							this.RequestCanNavigateFromOnCurrentlyActiveView(navigationContext, navigationCallback, activeViews, currentViewIndex + 1);
							return;
						}
						this.NotifyNavigationFailed(navigationContext, navigationCallback, null);
					});
					return;
				}
			}
			this.RequestCanNavigateFromOnCurrentlyActiveView(navigationContext, navigationCallback, activeViews, currentViewIndex + 1);
		}

		// Token: 0x0600040A RID: 1034 RVA: 0x0000BB98 File Offset: 0x00009D98
		private void ExecuteNavigation(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, object[] activeViews, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback)
		{
			try
			{
				global::Microsoft.Practices.Prism.Regions.RegionNavigationService.NotifyActiveViewsNavigatingFrom(navigationContext, activeViews);
				object obj = this.regionNavigationContentLoader.LoadContent(this.Region, navigationContext);
				this.RaiseNavigating(navigationContext);
				this.Region.Activate(obj);
				global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry instance = this.serviceLocator.GetInstance<global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournalEntry>();
				instance.Uri = navigationContext.Uri;
				this.journal.RecordNavigation(instance);
				global::Microsoft.Practices.Prism.Regions.RegionNavigationService.InvokeOnNavigationAwareElement(obj, delegate(global::Microsoft.Practices.Prism.Regions.INavigationAware n)
				{
					n.OnNavigatedTo(navigationContext);
				});
				navigationCallback(new global::Microsoft.Practices.Prism.Regions.NavigationResult(navigationContext, new bool?(true)));
				this.RaiseNavigated(navigationContext);
			}
			catch (global::System.Exception e)
			{
				this.NotifyNavigationFailed(navigationContext, navigationCallback, e);
			}
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x0000BC80 File Offset: 0x00009E80
		private void NotifyNavigationFailed(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, global::System.Action<global::Microsoft.Practices.Prism.Regions.NavigationResult> navigationCallback, global::System.Exception e)
		{
			global::Microsoft.Practices.Prism.Regions.NavigationResult obj = (e != null) ? new global::Microsoft.Practices.Prism.Regions.NavigationResult(navigationContext, e) : new global::Microsoft.Practices.Prism.Regions.NavigationResult(navigationContext, new bool?(false));
			navigationCallback(obj);
			this.RaiseNavigationFailed(navigationContext, e);
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x0000BCCC File Offset: 0x00009ECC
		private static void NotifyActiveViewsNavigatingFrom(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext, object[] activeViews)
		{
			global::Microsoft.Practices.Prism.Regions.RegionNavigationService.InvokeOnNavigationAwareElements(activeViews, delegate(global::Microsoft.Practices.Prism.Regions.INavigationAware n)
			{
				n.OnNavigatedFrom(navigationContext);
			});
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x0000BCF8 File Offset: 0x00009EF8
		private static void InvokeOnNavigationAwareElements(global::System.Collections.Generic.IEnumerable<object> items, global::System.Action<global::Microsoft.Practices.Prism.Regions.INavigationAware> invocation)
		{
			foreach (object item in items)
			{
				global::Microsoft.Practices.Prism.Regions.RegionNavigationService.InvokeOnNavigationAwareElement(item, invocation);
			}
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x0000BD40 File Offset: 0x00009F40
		private static void InvokeOnNavigationAwareElement(object item, global::System.Action<global::Microsoft.Practices.Prism.Regions.INavigationAware> invocation)
		{
			global::Microsoft.Practices.Prism.Regions.INavigationAware navigationAware = item as global::Microsoft.Practices.Prism.Regions.INavigationAware;
			if (navigationAware != null)
			{
				invocation(navigationAware);
			}
			global::System.Windows.FrameworkElement frameworkElement = item as global::System.Windows.FrameworkElement;
			if (frameworkElement != null)
			{
				global::Microsoft.Practices.Prism.Regions.INavigationAware navigationAware2 = frameworkElement.DataContext as global::Microsoft.Practices.Prism.Regions.INavigationAware;
				if (navigationAware2 != null)
				{
					invocation(navigationAware2);
				}
			}
		}

		// Token: 0x040000E8 RID: 232
		private readonly global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator;

		// Token: 0x040000E9 RID: 233
		private readonly global::Microsoft.Practices.Prism.Regions.IRegionNavigationContentLoader regionNavigationContentLoader;

		// Token: 0x040000EA RID: 234
		private global::Microsoft.Practices.Prism.Regions.IRegionNavigationJournal journal;

		// Token: 0x040000EB RID: 235
		private global::Microsoft.Practices.Prism.Regions.NavigationContext currentNavigationContext;
	}
}
