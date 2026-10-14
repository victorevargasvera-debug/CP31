using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Extensions.DependencyInjection.Abstractions;

namespace Microsoft.Extensions.DependencyInjection.Extensions
{
	// Token: 0x0200000E RID: 14
	public static class ServiceCollectionDescriptorExtensions
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00002B0E File Offset: 0x00000D0E
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection Add(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (descriptor == null)
			{
				throw new global::System.ArgumentNullException("descriptor");
			}
			collection.Add(descriptor);
			return collection;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00002B34 File Offset: 0x00000D34
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection Add(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Collections.Generic.IEnumerable<global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor> descriptors)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (descriptors == null)
			{
				throw new global::System.ArgumentNullException("descriptors");
			}
			foreach (global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor item in descriptors)
			{
				collection.Add(item);
			}
			return collection;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x00002B9C File Offset: 0x00000D9C
		public static void TryAdd(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (descriptor == null)
			{
				throw new global::System.ArgumentNullException("descriptor");
			}
			if (!collection.Any((global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor d) => d.ServiceType == descriptor.ServiceType))
			{
				collection.Add(descriptor);
			}
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00002BF8 File Offset: 0x00000DF8
		public static void TryAdd(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Collections.Generic.IEnumerable<global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor> descriptors)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (descriptors == null)
			{
				throw new global::System.ArgumentNullException("descriptors");
			}
			foreach (global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor in descriptors)
			{
				collection.TryAdd(descriptor);
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002C5C File Offset: 0x00000E5C
		public static void TryAddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Transient(service, service);
			collection.TryAdd(descriptor);
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002C94 File Offset: 0x00000E94
		public static void TryAddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Type implementationType)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Transient(service, implementationType);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00002CDC File Offset: 0x00000EDC
		public static void TryAddTransient(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Transient(service, implementationFactory);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00002D22 File Offset: 0x00000F22
		public static void TryAddTransient<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddTransient(typeof(TService), typeof(TService));
		}

		// Token: 0x06000062 RID: 98 RVA: 0x00002D4C File Offset: 0x00000F4C
		public static void TryAddTransient<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class where TImplementation : class, TService
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddTransient(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002D76 File Offset: 0x00000F76
		public static void TryAddTransient<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			services.TryAdd(global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Transient<TService>(implementationFactory));
		}

		// Token: 0x06000064 RID: 100 RVA: 0x00002D84 File Offset: 0x00000F84
		public static void TryAddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Scoped(service, service);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002DBC File Offset: 0x00000FBC
		public static void TryAddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Type implementationType)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Scoped(service, implementationType);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00002E04 File Offset: 0x00001004
		public static void TryAddScoped(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Scoped(service, implementationFactory);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000067 RID: 103 RVA: 0x00002E4A File Offset: 0x0000104A
		public static void TryAddScoped<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddScoped(typeof(TService), typeof(TService));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00002E74 File Offset: 0x00001074
		public static void TryAddScoped<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class where TImplementation : class, TService
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddScoped(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x06000069 RID: 105 RVA: 0x00002E9E File Offset: 0x0000109E
		public static void TryAddScoped<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			services.TryAdd(global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Scoped<TService>(implementationFactory));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00002EAC File Offset: 0x000010AC
		public static void TryAddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(service, service);
			collection.TryAdd(descriptor);
		}

		// Token: 0x0600006B RID: 107 RVA: 0x00002EE4 File Offset: 0x000010E4
		public static void TryAddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Type implementationType)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(service, implementationType);
			collection.TryAdd(descriptor);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00002F2C File Offset: 0x0000112C
		public static void TryAddSingleton(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::System.Type service, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(service, implementationFactory);
			collection.TryAdd(descriptor);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002F72 File Offset: 0x00001172
		public static void TryAddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddSingleton(typeof(TService), typeof(TService));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00002F9C File Offset: 0x0000119C
		public static void TryAddSingleton<TService, TImplementation>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection) where TService : class where TImplementation : class, TService
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			collection.TryAddSingleton(typeof(TService), typeof(TImplementation));
		}

		// Token: 0x0600006F RID: 111 RVA: 0x00002FC8 File Offset: 0x000011C8
		public static void TryAddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, TService instance) where TService : class
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor = global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(typeof(TService), instance);
			collection.TryAdd(descriptor);
		}

		// Token: 0x06000070 RID: 112 RVA: 0x00003013 File Offset: 0x00001213
		public static void TryAddSingleton<TService>(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			services.TryAdd(global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton<TService>(implementationFactory));
		}

		// Token: 0x06000071 RID: 113 RVA: 0x00003024 File Offset: 0x00001224
		public static void TryAddEnumerable(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (descriptor == null)
			{
				throw new global::System.ArgumentNullException("descriptor");
			}
			global::System.Type implementationType = descriptor.GetImplementationType();
			if (implementationType == typeof(object) || implementationType == descriptor.ServiceType)
			{
				throw new global::System.ArgumentException(global::Microsoft.Extensions.DependencyInjection.Abstractions.Resources.FormatTryAddIndistinguishableTypeToEnumerable(implementationType, descriptor.ServiceType), "descriptor");
			}
			if (!services.Any((global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor d) => d.ServiceType == descriptor.ServiceType && d.GetImplementationType() == implementationType))
			{
				services.Add(descriptor);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x000030D8 File Offset: 0x000012D8
		public static void TryAddEnumerable(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection services, global::System.Collections.Generic.IEnumerable<global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor> descriptors)
		{
			if (services == null)
			{
				throw new global::System.ArgumentNullException("services");
			}
			if (descriptors == null)
			{
				throw new global::System.ArgumentNullException("descriptors");
			}
			foreach (global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor in descriptors)
			{
				services.TryAddEnumerable(descriptor);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000313C File Offset: 0x0000133C
		public static global::Microsoft.Extensions.DependencyInjection.IServiceCollection Replace(this global::Microsoft.Extensions.DependencyInjection.IServiceCollection collection, global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor descriptor)
		{
			if (collection == null)
			{
				throw new global::System.ArgumentNullException("collection");
			}
			if (descriptor == null)
			{
				throw new global::System.ArgumentNullException("descriptor");
			}
			global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor serviceDescriptor = collection.FirstOrDefault((global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor s) => s.ServiceType == descriptor.ServiceType);
			if (serviceDescriptor != null)
			{
				collection.Remove(serviceDescriptor);
			}
			collection.Add(descriptor);
			return collection;
		}
	}
}
