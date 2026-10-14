using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002A7 RID: 679
	internal class AppConfigDependencyResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x0600218C RID: 8588 RVA: 0x0005D074 File Offset: 0x0005B274
		public AppConfigDependencyResolver()
		{
		}

		// Token: 0x0600218D RID: 8589 RVA: 0x0005D0A0 File Offset: 0x0005B2A0
		public AppConfigDependencyResolver(global::System.Data.Entity.Internal.AppConfig appConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration internalConfiguration, global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory providerServicesFactory = null)
		{
			this._appConfig = appConfig;
			this._internalConfiguration = internalConfiguration;
			this._providerServicesFactory = (providerServicesFactory ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory());
		}

		// Token: 0x0600218E RID: 8590 RVA: 0x0005D0F4 File Offset: 0x0005B2F4
		public virtual object GetService(global::System.Type type, object key)
		{
			return this._serviceFactories.GetOrAdd(global::System.Tuple.Create<global::System.Type, object>(type, key), (global::System.Tuple<global::System.Type, object> t) => this.GetServiceFactory(type, key as string))();
		}

		// Token: 0x0600218F RID: 8591 RVA: 0x0005D14C File Offset: 0x0005B34C
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return (from f in this._servicesFactories.GetOrAdd(global::System.Tuple.Create<global::System.Type, object>(type, key), (global::System.Tuple<global::System.Type, object> t) => this.GetServicesFactory(type, key))
			select f() into s
			where s != null
			select s).ToList<object>();
		}

		// Token: 0x06002190 RID: 8592 RVA: 0x0005D1EC File Offset: 0x0005B3EC
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Func<object>> GetServicesFactory(global::System.Type type, object key)
		{
			if (type == typeof(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor))
			{
				return (from i in this._appConfig.Interceptors
				select () => i).ToList<global::System.Func<object>>();
			}
			return new global::System.Collections.Generic.List<global::System.Func<object>>
			{
				this.GetServiceFactory(type, key as string)
			};
		}

		// Token: 0x06002191 RID: 8593 RVA: 0x0005D258 File Offset: 0x0005B458
		public virtual global::System.Func<object> GetServiceFactory(global::System.Type type, string name)
		{
			if (!this._providersRegistered)
			{
				global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.DbProviderServices> providerFactories = this._providerFactories;
				lock (providerFactories)
				{
					if (!this._providersRegistered)
					{
						this.RegisterDbProviderServices();
						this._providersRegistered = true;
					}
				}
			}
			if (!string.IsNullOrWhiteSpace(name) && type == typeof(global::System.Data.Entity.Core.Common.DbProviderServices))
			{
				global::System.Data.Entity.Core.Common.DbProviderServices providerFactory;
				this._providerFactories.TryGetValue(name, out providerFactory);
				return () => providerFactory;
			}
			if (type == typeof(global::System.Data.Entity.Infrastructure.IDbConnectionFactory))
			{
				if (!global::System.Data.Entity.Database.DefaultConnectionFactoryChanged)
				{
					global::System.Data.Entity.Infrastructure.IDbConnectionFactory dbConnectionFactory = this._appConfig.TryGetDefaultConnectionFactory();
					if (dbConnectionFactory != null)
					{
						global::System.Data.Entity.Database.DefaultConnectionFactory = dbConnectionFactory;
					}
				}
				return delegate()
				{
					if (!global::System.Data.Entity.Database.DefaultConnectionFactoryChanged)
					{
						return null;
					}
					return global::System.Data.Entity.Database.SetDefaultConnectionFactory;
				};
			}
			global::System.Type type2 = type.TryGetElementType(typeof(global::System.Data.Entity.IDatabaseInitializer<>));
			if (type2 != null)
			{
				object initializer = this._appConfig.Initializers.TryGetInitializer(type2);
				return () => initializer;
			}
			return () => null;
		}

		// Token: 0x06002192 RID: 8594 RVA: 0x0005D3A4 File Offset: 0x0005B5A4
		private void RegisterDbProviderServices()
		{
			global::System.Collections.Generic.IList<global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService> dbProviderServices = this._appConfig.DbProviderServices;
			if (dbProviderServices.All((global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService p) => p.InvariantName != "System.Data.SqlClient"))
			{
				this.RegisterSqlServerProvider();
			}
			dbProviderServices.Each(delegate(global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService p)
			{
				this._providerFactories[p.InvariantName] = p.ProviderServices;
				this._internalConfiguration.AddDefaultResolver(p.ProviderServices);
			});
		}

		// Token: 0x06002193 RID: 8595 RVA: 0x0005D3FC File Offset: 0x0005B5FC
		private void RegisterSqlServerProvider()
		{
			string providerTypeName = string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer, Version={0}, Culture=neutral, PublicKeyToken=b77a5c561934e089", new object[]
			{
				new global::System.Reflection.AssemblyName(typeof(global::System.Data.Entity.DbContext).Assembly().FullName).Version
			});
			global::System.Data.Entity.Core.Common.DbProviderServices dbProviderServices = this._providerServicesFactory.TryGetInstance(providerTypeName);
			if (dbProviderServices != null)
			{
				this._internalConfiguration.SetDefaultProviderServices(dbProviderServices, "System.Data.SqlClient");
			}
		}

		// Token: 0x04000BAC RID: 2988
		private readonly global::System.Data.Entity.Internal.AppConfig _appConfig;

		// Token: 0x04000BAD RID: 2989
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration _internalConfiguration;

		// Token: 0x04000BAE RID: 2990
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Func<object>> _serviceFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Func<object>>();

		// Token: 0x04000BAF RID: 2991
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Collections.Generic.IEnumerable<global::System.Func<object>>> _servicesFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Tuple<global::System.Type, object>, global::System.Collections.Generic.IEnumerable<global::System.Func<object>>>();

		// Token: 0x04000BB0 RID: 2992
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.DbProviderServices> _providerFactories = new global::System.Collections.Generic.Dictionary<string, global::System.Data.Entity.Core.Common.DbProviderServices>();

		// Token: 0x04000BB1 RID: 2993
		private bool _providersRegistered;

		// Token: 0x04000BB2 RID: 2994
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory _providerServicesFactory;
	}
}
