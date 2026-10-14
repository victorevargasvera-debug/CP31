using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200006C RID: 108
	public class RegionNavigationContentLoader : global::Microsoft.Practices.Prism.Regions.IRegionNavigationContentLoader
	{
		// Token: 0x06000301 RID: 769 RVA: 0x00008BC3 File Offset: 0x00006DC3
		public RegionNavigationContentLoader(global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator)
		{
			this.serviceLocator = serviceLocator;
		}

		// Token: 0x06000302 RID: 770 RVA: 0x00008C2C File Offset: 0x00006E2C
		public object LoadContent(global::Microsoft.Practices.Prism.Regions.IRegion region, global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			if (navigationContext == null)
			{
				throw new global::System.ArgumentNullException("navigationContext");
			}
			string contractFromNavigationContext = this.GetContractFromNavigationContext(navigationContext);
			global::System.Collections.Generic.IEnumerable<object> candidatesFromRegion = this.GetCandidatesFromRegion(region, contractFromNavigationContext);
			global::System.Collections.Generic.IEnumerable<object> source = candidatesFromRegion.Where(delegate(object v)
			{
				global::Microsoft.Practices.Prism.Regions.INavigationAware navigationAware = v as global::Microsoft.Practices.Prism.Regions.INavigationAware;
				if (navigationAware != null && !navigationAware.IsNavigationTarget(navigationContext))
				{
					return false;
				}
				global::System.Windows.FrameworkElement frameworkElement = v as global::System.Windows.FrameworkElement;
				if (frameworkElement == null)
				{
					return true;
				}
				navigationAware = (frameworkElement.DataContext as global::Microsoft.Practices.Prism.Regions.INavigationAware);
				return navigationAware == null || navigationAware.IsNavigationTarget(navigationContext);
			});
			object obj = source.FirstOrDefault<object>();
			if (obj != null)
			{
				return obj;
			}
			obj = this.CreateNewRegionItem(contractFromNavigationContext);
			region.Add(obj);
			return obj;
		}

		// Token: 0x06000303 RID: 771 RVA: 0x00008CB4 File Offset: 0x00006EB4
		protected virtual object CreateNewRegionItem(string candidateTargetContract)
		{
			object instance;
			try
			{
				instance = this.serviceLocator.GetInstance<object>(candidateTargetContract);
			}
			catch (global::Microsoft.Practices.ServiceLocation.ActivationException innerException)
			{
				throw new global::System.InvalidOperationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.CannotCreateNavigationTarget, new object[]
				{
					candidateTargetContract
				}), innerException);
			}
			return instance;
		}

		// Token: 0x06000304 RID: 772 RVA: 0x00008D04 File Offset: 0x00006F04
		protected virtual string GetContractFromNavigationContext(global::Microsoft.Practices.Prism.Regions.NavigationContext navigationContext)
		{
			if (navigationContext == null)
			{
				throw new global::System.ArgumentNullException("navigationContext");
			}
			string absolutePath = global::Microsoft.Practices.Prism.UriParsingHelper.GetAbsolutePath(navigationContext.Uri);
			return absolutePath.TrimStart(new char[]
			{
				'/'
			});
		}

		// Token: 0x06000305 RID: 773 RVA: 0x00008D7C File Offset: 0x00006F7C
		protected virtual global::System.Collections.Generic.IEnumerable<object> GetCandidatesFromRegion(global::Microsoft.Practices.Prism.Regions.IRegion region, string candidateNavigationContract)
		{
			if (region == null)
			{
				throw new global::System.ArgumentNullException("region");
			}
			return from v in region.Views
			where string.Equals(v.GetType().Name, candidateNavigationContract, global::System.StringComparison.Ordinal) || string.Equals(v.GetType().FullName, candidateNavigationContract, global::System.StringComparison.Ordinal)
			select v;
		}

		// Token: 0x040000AA RID: 170
		private readonly global::Microsoft.Practices.ServiceLocation.IServiceLocator serviceLocator;
	}
}
