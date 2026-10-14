using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Practices.ServiceLocation.Properties;

namespace Microsoft.Practices.ServiceLocation
{
	// Token: 0x02000006 RID: 6
	public abstract class ServiceLocatorImplBase : global::Microsoft.Practices.ServiceLocation.IServiceLocator, global::System.IServiceProvider
	{
		// Token: 0x06000013 RID: 19 RVA: 0x0000218E File Offset: 0x0000118E
		public virtual object GetService(global::System.Type serviceType)
		{
			return this.GetInstance(serviceType, null);
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002198 File Offset: 0x00001198
		public virtual object GetInstance(global::System.Type serviceType)
		{
			return this.GetInstance(serviceType, null);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000021A4 File Offset: 0x000011A4
		public virtual object GetInstance(global::System.Type serviceType, string key)
		{
			object result;
			try
			{
				result = this.DoGetInstance(serviceType, key);
			}
			catch (global::System.Exception ex)
			{
				throw new global::Microsoft.Practices.ServiceLocation.ActivationException(this.FormatActivationExceptionMessage(ex, serviceType, key), ex);
			}
			return result;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021E0 File Offset: 0x000011E0
		public virtual global::System.Collections.Generic.IEnumerable<object> GetAllInstances(global::System.Type serviceType)
		{
			global::System.Collections.Generic.IEnumerable<object> result;
			try
			{
				result = this.DoGetAllInstances(serviceType);
			}
			catch (global::System.Exception ex)
			{
				throw new global::Microsoft.Practices.ServiceLocation.ActivationException(this.FormatActivateAllExceptionMessage(ex, serviceType), ex);
			}
			return result;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002218 File Offset: 0x00001218
		public virtual TService GetInstance<TService>()
		{
			return (TService)((object)this.GetInstance(typeof(TService), null));
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002230 File Offset: 0x00001230
		public virtual TService GetInstance<TService>(string key)
		{
			return (TService)((object)this.GetInstance(typeof(TService), key));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x000023DC File Offset: 0x000013DC
		public virtual global::System.Collections.Generic.IEnumerable<TService> GetAllInstances<TService>()
		{
			global::Microsoft.Practices.ServiceLocation.ServiceLocatorImplBase.<GetAllInstances>d__0<TService> <GetAllInstances>d__ = new global::Microsoft.Practices.ServiceLocation.ServiceLocatorImplBase.<GetAllInstances>d__0<TService>(-2);
			<GetAllInstances>d__.<>4__this = this;
			return <GetAllInstances>d__;
		}

		// Token: 0x0600001A RID: 26
		protected abstract object DoGetInstance(global::System.Type serviceType, string key);

		// Token: 0x0600001B RID: 27
		protected abstract global::System.Collections.Generic.IEnumerable<object> DoGetAllInstances(global::System.Type serviceType);

		// Token: 0x0600001C RID: 28 RVA: 0x000023FC File Offset: 0x000013FC
		protected virtual string FormatActivationExceptionMessage(global::System.Exception actualException, global::System.Type serviceType, string key)
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentUICulture, global::Microsoft.Practices.ServiceLocation.Properties.Resources.ActivationExceptionMessage, new object[]
			{
				serviceType.Name,
				key
			});
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00002430 File Offset: 0x00001430
		protected virtual string FormatActivateAllExceptionMessage(global::System.Exception actualException, global::System.Type serviceType)
		{
			return string.Format(global::System.Globalization.CultureInfo.CurrentUICulture, global::Microsoft.Practices.ServiceLocation.Properties.Resources.ActivateAllExceptionMessage, new object[]
			{
				serviceType.Name
			});
		}
	}
}
