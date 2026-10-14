using System;
using System.Collections.Generic;
using Microsoft.Extensions.DependencyInjection.Abstractions;

namespace Microsoft.Extensions.DependencyInjection
{
	// Token: 0x0200000C RID: 12
	public static class ServiceProviderServiceExtensions
	{
		// Token: 0x06000046 RID: 70 RVA: 0x00002825 File Offset: 0x00000A25
		public static T GetService<T>(this global::System.IServiceProvider provider)
		{
			if (provider == null)
			{
				throw new global::System.ArgumentNullException("provider");
			}
			return (T)((object)provider.GetService(typeof(T)));
		}

		// Token: 0x06000047 RID: 71 RVA: 0x0000284C File Offset: 0x00000A4C
		public static object GetRequiredService(this global::System.IServiceProvider provider, global::System.Type serviceType)
		{
			if (provider == null)
			{
				throw new global::System.ArgumentNullException("provider");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			global::Microsoft.Extensions.DependencyInjection.ISupportRequiredService supportRequiredService = provider as global::Microsoft.Extensions.DependencyInjection.ISupportRequiredService;
			if (supportRequiredService != null)
			{
				return supportRequiredService.GetRequiredService(serviceType);
			}
			object service = provider.GetService(serviceType);
			if (service == null)
			{
				throw new global::System.InvalidOperationException(global::Microsoft.Extensions.DependencyInjection.Abstractions.Resources.FormatNoServiceRegistered(serviceType));
			}
			return service;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x0000289D File Offset: 0x00000A9D
		public static T GetRequiredService<T>(this global::System.IServiceProvider provider)
		{
			if (provider == null)
			{
				throw new global::System.ArgumentNullException("provider");
			}
			return (T)((object)provider.GetRequiredService(typeof(T)));
		}

		// Token: 0x06000049 RID: 73 RVA: 0x000028C2 File Offset: 0x00000AC2
		public static global::System.Collections.Generic.IEnumerable<T> GetServices<T>(this global::System.IServiceProvider provider)
		{
			if (provider == null)
			{
				throw new global::System.ArgumentNullException("provider");
			}
			return provider.GetRequiredService<global::System.Collections.Generic.IEnumerable<T>>();
		}

		// Token: 0x0600004A RID: 74 RVA: 0x000028D8 File Offset: 0x00000AD8
		public static global::System.Collections.Generic.IEnumerable<object> GetServices(this global::System.IServiceProvider provider, global::System.Type serviceType)
		{
			if (provider == null)
			{
				throw new global::System.ArgumentNullException("provider");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			global::System.Type serviceType2 = typeof(global::System.Collections.Generic.IEnumerable<>).MakeGenericType(new global::System.Type[]
			{
				serviceType
			});
			return (global::System.Collections.Generic.IEnumerable<object>)provider.GetRequiredService(serviceType2);
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00002927 File Offset: 0x00000B27
		public static global::Microsoft.Extensions.DependencyInjection.IServiceScope CreateScope(this global::System.IServiceProvider provider)
		{
			return provider.GetRequiredService<global::Microsoft.Extensions.DependencyInjection.IServiceScopeFactory>().CreateScope();
		}
	}
}
