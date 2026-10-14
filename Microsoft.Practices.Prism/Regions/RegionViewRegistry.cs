using System;
using System.Collections.Generic;
using System.Globalization;
using System.Reflection;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.Prism.Properties;
using Microsoft.Practices.ServiceLocation;

namespace Microsoft.Practices.Prism.Regions
{
	// Token: 0x0200007D RID: 125
	public class RegionViewRegistry : global::Microsoft.Practices.Prism.Regions.IRegionViewRegistry
	{
		// Token: 0x0600036C RID: 876 RVA: 0x00009AA3 File Offset: 0x00007CA3
		public RegionViewRegistry(global::Microsoft.Practices.ServiceLocation.IServiceLocator locator)
		{
			this.locator = locator;
		}

		// Token: 0x14000019 RID: 25
		// (add) Token: 0x0600036D RID: 877 RVA: 0x00009AC8 File Offset: 0x00007CC8
		// (remove) Token: 0x0600036E RID: 878 RVA: 0x00009AD6 File Offset: 0x00007CD6
		public event global::System.EventHandler<global::Microsoft.Practices.Prism.Regions.ViewRegisteredEventArgs> ContentRegistered
		{
			add
			{
				this.contentRegisteredListeners.AddListener(value);
			}
			remove
			{
				this.contentRegisteredListeners.RemoveListener(value);
			}
		}

		// Token: 0x0600036F RID: 879 RVA: 0x00009AE4 File Offset: 0x00007CE4
		public global::System.Collections.Generic.IEnumerable<object> GetContents(string regionName)
		{
			global::System.Collections.Generic.List<object> list = new global::System.Collections.Generic.List<object>();
			foreach (global::System.Func<object> func in this.registeredContent[regionName])
			{
				list.Add(func());
			}
			return list;
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00009B60 File Offset: 0x00007D60
		public void RegisterViewWithRegion(string regionName, global::System.Type viewType)
		{
			this.RegisterViewWithRegion(regionName, () => this.CreateInstance(viewType));
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00009B94 File Offset: 0x00007D94
		public void RegisterViewWithRegion(string regionName, global::System.Func<object> getContentDelegate)
		{
			this.registeredContent.Add(regionName, getContentDelegate);
			this.OnContentRegistered(new global::Microsoft.Practices.Prism.Regions.ViewRegisteredEventArgs(regionName, getContentDelegate));
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00009BB0 File Offset: 0x00007DB0
		protected virtual object CreateInstance(global::System.Type type)
		{
			return this.locator.GetInstance(type);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x00009BC0 File Offset: 0x00007DC0
		private void OnContentRegistered(global::Microsoft.Practices.Prism.Regions.ViewRegisteredEventArgs e)
		{
			try
			{
				this.contentRegisteredListeners.Raise(new object[]
				{
					this,
					e
				});
			}
			catch (global::System.Reflection.TargetInvocationException ex)
			{
				global::System.Exception rootException;
				if (ex.InnerException != null)
				{
					rootException = ex.InnerException.GetRootException();
				}
				else
				{
					rootException = ex.GetRootException();
				}
				throw new global::Microsoft.Practices.Prism.Regions.ViewRegistrationException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Microsoft.Practices.Prism.Properties.Resources.OnViewRegisteredException, new object[]
				{
					e.RegionName,
					rootException
				}), ex.InnerException);
			}
		}

		// Token: 0x040000C9 RID: 201
		private readonly global::Microsoft.Practices.ServiceLocation.IServiceLocator locator;

		// Token: 0x040000CA RID: 202
		private readonly global::Microsoft.Practices.Prism.ListDictionary<string, global::System.Func<object>> registeredContent = new global::Microsoft.Practices.Prism.ListDictionary<string, global::System.Func<object>>();

		// Token: 0x040000CB RID: 203
		private readonly global::Microsoft.Practices.Prism.Events.WeakDelegatesManager contentRegisteredListeners = new global::Microsoft.Practices.Prism.Events.WeakDelegatesManager();
	}
}
