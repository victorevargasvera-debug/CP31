using System;
using System.Diagnostics;

namespace Microsoft.Extensions.DependencyInjection
{
	// Token: 0x0200000A RID: 10
	[global::System.Diagnostics.DebuggerDisplay("Lifetime = {Lifetime}, ServiceType = {ServiceType}, ImplementationType = {ImplementationType}")]
	public class ServiceDescriptor
	{
		// Token: 0x06000028 RID: 40 RVA: 0x000024EE File Offset: 0x000006EE
		public ServiceDescriptor(global::System.Type serviceType, global::System.Type implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime) : this(serviceType, lifetime)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			this.ImplementationType = implementationType;
		}

		// Token: 0x06000029 RID: 41 RVA: 0x0000251B File Offset: 0x0000071B
		public ServiceDescriptor(global::System.Type serviceType, object instance) : this(serviceType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (instance == null)
			{
				throw new global::System.ArgumentNullException("instance");
			}
			this.ImplementationInstance = instance;
		}

		// Token: 0x0600002A RID: 42 RVA: 0x00002548 File Offset: 0x00000748
		public ServiceDescriptor(global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> factory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime) : this(serviceType, lifetime)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (factory == null)
			{
				throw new global::System.ArgumentNullException("factory");
			}
			this.ImplementationFactory = factory;
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002575 File Offset: 0x00000775
		private ServiceDescriptor(global::System.Type serviceType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
		{
			this.Lifetime = lifetime;
			this.ServiceType = serviceType;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x0600002C RID: 44 RVA: 0x0000258B File Offset: 0x0000078B
		public global::Microsoft.Extensions.DependencyInjection.ServiceLifetime Lifetime { get; }

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x0600002D RID: 45 RVA: 0x00002593 File Offset: 0x00000793
		public global::System.Type ServiceType { get; }

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x0600002E RID: 46 RVA: 0x0000259B File Offset: 0x0000079B
		public global::System.Type ImplementationType { get; }

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002F RID: 47 RVA: 0x000025A3 File Offset: 0x000007A3
		public object ImplementationInstance { get; }

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000025AB File Offset: 0x000007AB
		public global::System.Func<global::System.IServiceProvider, object> ImplementationFactory { get; }

		// Token: 0x06000031 RID: 49 RVA: 0x000025B4 File Offset: 0x000007B4
		internal global::System.Type GetImplementationType()
		{
			if (this.ImplementationType != null)
			{
				return this.ImplementationType;
			}
			if (this.ImplementationInstance != null)
			{
				return this.ImplementationInstance.GetType();
			}
			if (this.ImplementationFactory != null)
			{
				return this.ImplementationFactory.GetType().GenericTypeArguments[1];
			}
			return null;
		}

		// Token: 0x06000032 RID: 50 RVA: 0x00002600 File Offset: 0x00000800
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Transient<TService, TImplementation>() where TService : class where TImplementation : class, TService
		{
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe<TService, TImplementation>(global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x00002608 File Offset: 0x00000808
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Transient(global::System.Type service, global::System.Type implementationType)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(service, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000262E File Offset: 0x0000082E
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Transient<TService, TImplementation>(global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000035 RID: 53 RVA: 0x0000264F File Offset: 0x0000084F
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Transient<TService>(global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00002670 File Offset: 0x00000870
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Transient(global::System.Type service, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(service, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Transient);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002696 File Offset: 0x00000896
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Scoped<TService, TImplementation>() where TService : class where TImplementation : class, TService
		{
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe<TService, TImplementation>(global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x0000269E File Offset: 0x0000089E
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Scoped(global::System.Type service, global::System.Type implementationType)
		{
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(service, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000026A8 File Offset: 0x000008A8
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Scoped<TService, TImplementation>(global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000026C9 File Offset: 0x000008C9
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Scoped<TService>(global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000026EA File Offset: 0x000008EA
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Scoped(global::System.Type service, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(service, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Scoped);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002710 File Offset: 0x00000910
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton<TService, TImplementation>() where TService : class where TImplementation : class, TService
		{
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe<TService, TImplementation>(global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002718 File Offset: 0x00000918
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton(global::System.Type service, global::System.Type implementationType)
		{
			if (service == null)
			{
				throw new global::System.ArgumentNullException("service");
			}
			if (implementationType == null)
			{
				throw new global::System.ArgumentNullException("implementationType");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(service, implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000273E File Offset: 0x0000093E
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton<TService, TImplementation>(global::System.Func<global::System.IServiceProvider, TImplementation> implementationFactory) where TService : class where TImplementation : class, TService
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x0000275F File Offset: 0x0000095F
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton<TService>(global::System.Func<global::System.IServiceProvider, TService> implementationFactory) where TService : class
		{
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00002780 File Offset: 0x00000980
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton(global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationFactory == null)
			{
				throw new global::System.ArgumentNullException("implementationFactory");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(serviceType, implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime.Singleton);
		}

		// Token: 0x06000041 RID: 65 RVA: 0x000027A6 File Offset: 0x000009A6
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton<TService>(TService implementationInstance) where TService : class
		{
			if (implementationInstance == null)
			{
				throw new global::System.ArgumentNullException("implementationInstance");
			}
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Singleton(typeof(TService), implementationInstance);
		}

		// Token: 0x06000042 RID: 66 RVA: 0x000027D0 File Offset: 0x000009D0
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Singleton(global::System.Type serviceType, object implementationInstance)
		{
			if (serviceType == null)
			{
				throw new global::System.ArgumentNullException("serviceType");
			}
			if (implementationInstance == null)
			{
				throw new global::System.ArgumentNullException("implementationInstance");
			}
			return new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationInstance);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000027F5 File Offset: 0x000009F5
		private static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Describe<TService, TImplementation>(global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime) where TService : class where TImplementation : class, TService
		{
			return global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor.Describe(typeof(TService), typeof(TImplementation), lifetime);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00002811 File Offset: 0x00000A11
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Describe(global::System.Type serviceType, global::System.Type implementationType, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
		{
			return new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationType, lifetime);
		}

		// Token: 0x06000045 RID: 69 RVA: 0x0000281B File Offset: 0x00000A1B
		public static global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor Describe(global::System.Type serviceType, global::System.Func<global::System.IServiceProvider, object> implementationFactory, global::Microsoft.Extensions.DependencyInjection.ServiceLifetime lifetime)
		{
			return new global::Microsoft.Extensions.DependencyInjection.ServiceDescriptor(serviceType, implementationFactory, lifetime);
		}
	}
}
