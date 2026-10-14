using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal.ConfigFile;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000EC RID: 236
	internal class AppConfig
	{
		// Token: 0x060011EB RID: 4587 RVA: 0x0002D7B1 File Offset: 0x0002B9B1
		public AppConfig(global::System.Configuration.Configuration configuration) : this(configuration.ConnectionStrings.ConnectionStrings, configuration.AppSettings.Settings, (global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection)configuration.GetSection("entityFramework"), null)
		{
		}

		// Token: 0x060011EC RID: 4588 RVA: 0x0002D7E0 File Offset: 0x0002B9E0
		public AppConfig(global::System.Configuration.ConnectionStringSettingsCollection connectionStrings) : this(connectionStrings, null, null, null)
		{
		}

		// Token: 0x060011ED RID: 4589 RVA: 0x0002D7EC File Offset: 0x0002B9EC
		private AppConfig() : this(global::System.Configuration.ConfigurationManager.ConnectionStrings, global::System.Data.Entity.Internal.AppConfig.Convert(global::System.Configuration.ConfigurationManager.AppSettings), (global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection)global::System.Configuration.ConfigurationManager.GetSection("entityFramework"), null)
		{
		}

		// Token: 0x060011EE RID: 4590 RVA: 0x0002D814 File Offset: 0x0002BA14
		internal AppConfig(global::System.Configuration.ConnectionStringSettingsCollection connectionStrings, global::System.Configuration.KeyValueConfigurationCollection appSettings, global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection entityFrameworkSettings, global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory providerServicesFactory = null)
		{
			this._connectionStrings = connectionStrings;
			this._appSettings = (appSettings ?? new global::System.Configuration.KeyValueConfigurationCollection());
			this._entityFrameworkSettings = (entityFrameworkSettings ?? new global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection());
			this._providerServicesFactory = (providerServicesFactory ?? new global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory());
			this._providerServices = new global::System.Lazy<global::System.Collections.Generic.IList<global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService>>(() => (from e in this._entityFrameworkSettings.Providers.OfType<global::System.Data.Entity.Internal.ConfigFile.ProviderElement>()
			select new global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService(e.InvariantName, this._providerServicesFactory.GetInstance(e.ProviderTypeName, e.InvariantName))).ToList<global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService>());
			if (this._entityFrameworkSettings.DefaultConnectionFactory.ElementInformation.IsPresent)
			{
				this._defaultConnectionFactory = new global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(delegate()
				{
					global::System.Data.Entity.Internal.ConfigFile.DefaultConnectionFactoryElement defaultConnectionFactory = this._entityFrameworkSettings.DefaultConnectionFactory;
					global::System.Data.Entity.Infrastructure.IDbConnectionFactory result;
					try
					{
						global::System.Type factoryType = defaultConnectionFactory.GetFactoryType();
						object[] typedParameterValues = defaultConnectionFactory.Parameters.GetTypedParameterValues();
						result = (global::System.Data.Entity.Infrastructure.IDbConnectionFactory)global::System.Activator.CreateInstance(factoryType, typedParameterValues);
					}
					catch (global::System.Exception innerException)
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.SetConnectionFactoryFromConfigFailed(defaultConnectionFactory.FactoryTypeName), innerException);
					}
					return result;
				}, true);
				return;
			}
			this._defaultConnectionFactory = this._defaultDefaultConnectionFactory;
		}

		// Token: 0x060011EF RID: 4591 RVA: 0x0002D8DD File Offset: 0x0002BADD
		public virtual global::System.Data.Entity.Infrastructure.IDbConnectionFactory TryGetDefaultConnectionFactory()
		{
			return this._defaultConnectionFactory.Value;
		}

		// Token: 0x060011F0 RID: 4592 RVA: 0x0002D8EA File Offset: 0x0002BAEA
		public global::System.Configuration.ConnectionStringSettings GetConnectionString(string name)
		{
			return this._connectionStrings[name];
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060011F1 RID: 4593 RVA: 0x0002D8F8 File Offset: 0x0002BAF8
		public static global::System.Data.Entity.Internal.AppConfig DefaultInstance
		{
			get
			{
				return global::System.Data.Entity.Internal.AppConfig._defaultInstance;
			}
		}

		// Token: 0x060011F2 RID: 4594 RVA: 0x0002D900 File Offset: 0x0002BB00
		private static global::System.Configuration.KeyValueConfigurationCollection Convert(global::System.Collections.Specialized.NameValueCollection collection)
		{
			global::System.Configuration.KeyValueConfigurationCollection keyValueConfigurationCollection = new global::System.Configuration.KeyValueConfigurationCollection();
			foreach (string text in collection.AllKeys)
			{
				keyValueConfigurationCollection.Add(text, global::System.Configuration.ConfigurationManager.AppSettings[text]);
			}
			return keyValueConfigurationCollection;
		}

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x060011F3 RID: 4595 RVA: 0x0002D93F File Offset: 0x0002BB3F
		public virtual global::System.Data.Entity.Internal.ContextConfig ContextConfigs
		{
			get
			{
				return new global::System.Data.Entity.Internal.ContextConfig(this._entityFrameworkSettings);
			}
		}

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x060011F4 RID: 4596 RVA: 0x0002D94C File Offset: 0x0002BB4C
		public virtual global::System.Data.Entity.Internal.InitializerConfig Initializers
		{
			get
			{
				return new global::System.Data.Entity.Internal.InitializerConfig(this._entityFrameworkSettings, this._appSettings);
			}
		}

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x060011F5 RID: 4597 RVA: 0x0002D95F File Offset: 0x0002BB5F
		public virtual string ConfigurationTypeName
		{
			get
			{
				return this._entityFrameworkSettings.ConfigurationTypeName;
			}
		}

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x060011F6 RID: 4598 RVA: 0x0002D96C File Offset: 0x0002BB6C
		public virtual global::System.Collections.Generic.IList<global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService> DbProviderServices
		{
			get
			{
				return this._providerServices.Value;
			}
		}

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x060011F7 RID: 4599 RVA: 0x0002D979 File Offset: 0x0002BB79
		public virtual global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor> Interceptors
		{
			get
			{
				return this._entityFrameworkSettings.Interceptors.Interceptors;
			}
		}

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x060011F8 RID: 4600 RVA: 0x0002D98B File Offset: 0x0002BB8B
		public virtual global::System.Data.Entity.Internal.QueryCacheConfig QueryCache
		{
			get
			{
				return new global::System.Data.Entity.Internal.QueryCacheConfig(this._entityFrameworkSettings);
			}
		}

		// Token: 0x040008EE RID: 2286
		public const string EFSectionName = "entityFramework";

		// Token: 0x040008EF RID: 2287
		private static readonly global::System.Data.Entity.Internal.AppConfig _defaultInstance = new global::System.Data.Entity.Internal.AppConfig();

		// Token: 0x040008F0 RID: 2288
		private readonly global::System.Configuration.KeyValueConfigurationCollection _appSettings;

		// Token: 0x040008F1 RID: 2289
		private readonly global::System.Configuration.ConnectionStringSettingsCollection _connectionStrings;

		// Token: 0x040008F2 RID: 2290
		private readonly global::System.Data.Entity.Internal.ConfigFile.EntityFrameworkSection _entityFrameworkSettings;

		// Token: 0x040008F3 RID: 2291
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory> _defaultConnectionFactory;

		// Token: 0x040008F4 RID: 2292
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory> _defaultDefaultConnectionFactory = new global::System.Lazy<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>(() => null, true);

		// Token: 0x040008F5 RID: 2293
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.ProviderServicesFactory _providerServicesFactory;

		// Token: 0x040008F6 RID: 2294
		private readonly global::System.Lazy<global::System.Collections.Generic.IList<global::System.Data.Entity.Infrastructure.DependencyResolution.NamedDbProviderService>> _providerServices;
	}
}
