using System;

namespace Microsoft.Extensions.DependencyInjection
{
	// Token: 0x02000009 RID: 9
	public static class ServiceCollectionServiceExtensions
	{
		// Token: 0x0600000F RID: 15 RVA: 0x00002088 File Offset: 0x00000288
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Type implementationType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000020BD File Offset: 0x000002BD
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000011 RID: 17 RVA: 0x000020F2 File Offset: 0x000002F2
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddTransient(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x06000012 RID: 18 RVA: 0x0000211C File Offset: 0x0000031C
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return services.AddTransient(serviceType, serviceType);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00002142 File Offset: 0x00000342
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddTransient(typeof(TService));
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002162 File Offset: 0x00000362
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddTransient(typeof(TService), implementationFactory);
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002191 File Offset: 0x00000391
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddTransient<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddTransient(typeof(TService), implementationFactory);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000021C0 File Offset: 0x000003C0
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Type implementationType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000021F5 File Offset: 0x000003F5
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x06000018 RID: 24 RVA: 0x0000222A File Offset: 0x0000042A
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddScoped(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002254 File Offset: 0x00000454
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return services.AddScoped(serviceType, serviceType);
		}

		// Token: 0x0600001A RID: 26 RVA: 0x0000227A File Offset: 0x0000047A
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddScoped(typeof(TService));
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000229A File Offset: 0x0000049A
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddScoped(typeof(TService), implementationFactory);
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000022C9 File Offset: 0x000004C9
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddScoped<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddScoped(typeof(TService), implementationFactory);
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000022F8 File Offset: 0x000004F8
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Type implementationType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x0600001E RID: 30 RVA: 0x0000232D File Offset: 0x0000052D
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceCollectionServiceExtensions.Add(services, serviceType, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00002362 File Offset: 0x00000562
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddSingleton(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x06000020 RID: 32 RVA: 0x0000238C File Offset: 0x0000058C
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			return services.AddSingleton(serviceType, serviceType);
		}

		// Token: 0x06000021 RID: 33 RVA: 0x000023B2 File Offset: 0x000005B2
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			return services.AddSingleton(typeof(TService));
		}

		// Token: 0x06000022 RID: 34 RVA: 0x000023D2 File Offset: 0x000005D2
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddSingleton(typeof(TService), implementationFactory);
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002401 File Offset: 0x00000601
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return services.AddSingleton(typeof(TService), implementationFactory);
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00002430 File Offset: 0x00000630
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Type serviceType, object implementationInstance)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationInstance == null)
			{
				throw new global::System.ArgumentNullException("implementationInstance");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor item = new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationInstance);
			services.Add(item);
			return services;
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00002477 File Offset: 0x00000677
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection AddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, TService implementationInstance) where TService : class
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (implementationInstance == null)
			{
				throw new global::System.ArgumentNullException("implementationInstance");
			}
			return services.AddSingleton(typeof(TService), implementationInstance);
		}

		// Token: 0x06000026 RID: 38 RVA: 0x000024B0 File Offset: 0x000006B0
		private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection Add(global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type serviceType, global::System.Type implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
		{
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor item = new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationType, lifetime);
			collection.Add(item);
			return collection;
		}

		// Token: 0x06000027 RID: 39 RVA: 0x000024D0 File Offset: 0x000006D0
		private static global::Microsoft.Extensions.DependencyInjection.IServiceCollection Add(global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
		{
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor item = new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationFactory, lifetime);
			collection.Add(item);
			return collection;
		}
	}
}
