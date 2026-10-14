using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002AF RID: 687
	internal class DbConfigurationManager
	{
		// Token: 0x060021B4 RID: 8628 RVA: 0x0005D974 File Offset: 0x0005BB74
		public DbConfigurationManager(global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoader loader, global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationFinder finder)
		{
			this._loader = loader;
			this._finder = finder;
			this._configuration = new global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>(delegate()
			{
				global::System.Data.Entity.DbConfiguration dbConfiguration = this._newConfiguration ?? this._newConfigurationType.CreateInstance(new global::System.Func<string, string, string>(global::System.Data.Entity.Resources.Strings.CreateInstance_BadDbConfigurationType), null);
				dbConfiguration.InternalConfiguration.Lock();
				return dbConfiguration.InternalConfiguration;
			});
		}

		// Token: 0x17000733 RID: 1843
		// (get) Token: 0x060021B5 RID: 8629 RVA: 0x0005D9FE File Offset: 0x0005BBFE
		public static global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager Instance
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager._configManager;
			}
		}

		// Token: 0x060021B6 RID: 8630 RVA: 0x0005DA05 File Offset: 0x0005BC05
		public virtual void AddLoadedHandler(global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs> handler)
		{
			if (this.ConfigurationSet)
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.AddHandlerToInUseConfiguration);
			}
			this._loadedHandler = (global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs>)global::System.Delegate.Combine(this._loadedHandler, handler);
		}

		// Token: 0x060021B7 RID: 8631 RVA: 0x0005DA31 File Offset: 0x0005BC31
		public virtual void RemoveLoadedHandler(global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs> handler)
		{
			this._loadedHandler = (global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs>)global::System.Delegate.Remove(this._loadedHandler, handler);
		}

		// Token: 0x060021B8 RID: 8632 RVA: 0x0005DA4C File Offset: 0x0005BC4C
		public virtual void OnLoaded(global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration configuration)
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs dbConfigurationLoadedEventArgs = new global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs(configuration);
			global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs> loadedHandler = this._loadedHandler;
			if (loadedHandler != null)
			{
				loadedHandler(configuration.Owner, dbConfigurationLoadedEventArgs);
			}
			configuration.DispatchLoadedInterceptors(dbConfigurationLoadedEventArgs);
		}

		// Token: 0x060021B9 RID: 8633 RVA: 0x0005DA80 File Offset: 0x0005BC80
		public virtual global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration GetConfiguration()
		{
			if (this._configurationOverrides.IsValueCreated)
			{
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._configurationOverrides.Value.Count != 0)
					{
						return this._configurationOverrides.Value.Last<global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>>().Item2;
					}
				}
			}
			return this._configuration.Value;
		}

		// Token: 0x060021BA RID: 8634 RVA: 0x0005DB00 File Offset: 0x0005BD00
		public virtual void SetConfigurationType(global::System.Type configurationType)
		{
			this._newConfigurationType = configurationType;
		}

		// Token: 0x060021BB RID: 8635 RVA: 0x0005DB0C File Offset: 0x0005BD0C
		public virtual void SetConfiguration(global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration configuration)
		{
			global::System.Type type = this._loader.TryLoadFromConfig(global::System.Data.Entity.Internal.AppConfig.DefaultInstance);
			if (type != null)
			{
				configuration = type.CreateInstance(new global::System.Func<string, string, string>(global::System.Data.Entity.Resources.Strings.CreateInstance_BadDbConfigurationType), null).InternalConfiguration;
			}
			this._newConfiguration = configuration.Owner;
			if (!(this._configuration.Value.Owner.GetType() != configuration.Owner.GetType()))
			{
				return;
			}
			if (this._configuration.Value.Owner.GetType() == typeof(global::System.Data.Entity.DbConfiguration))
			{
				throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.DefaultConfigurationUsedBeforeSet(configuration.Owner.GetType().Name));
			}
			throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConfigurationSetTwice(configuration.Owner.GetType().Name, this._configuration.Value.Owner.GetType().Name));
		}

		// Token: 0x060021BC RID: 8636 RVA: 0x0005DBF8 File Offset: 0x0005BDF8
		public virtual void EnsureLoadedForContext(global::System.Type contextType)
		{
			this.EnsureLoadedForAssembly(contextType.Assembly(), contextType);
		}

		// Token: 0x060021BD RID: 8637 RVA: 0x0005DC08 File Offset: 0x0005BE08
		public virtual void EnsureLoadedForAssembly(global::System.Reflection.Assembly assemblyHint, global::System.Type contextTypeHint)
		{
			if (contextTypeHint == typeof(global::System.Data.Entity.DbContext) || this._knownAssemblies.ContainsKey(assemblyHint))
			{
				return;
			}
			if (this._configurationOverrides.IsValueCreated)
			{
				object @lock = this._lock;
				lock (@lock)
				{
					if (this._configurationOverrides.Value.Count != 0)
					{
						return;
					}
				}
			}
			if (!this.ConfigurationSet)
			{
				global::System.Type type = this._loader.TryLoadFromConfig(global::System.Data.Entity.Internal.AppConfig.DefaultInstance) ?? this._finder.TryFindConfigurationType(assemblyHint, this._finder.TryFindContextType(assemblyHint, contextTypeHint, null), null);
				if (type != null)
				{
					this.SetConfigurationType(type);
				}
			}
			else if (!assemblyHint.IsDynamic && !this._loader.AppConfigContainsDbConfigurationType(global::System.Data.Entity.Internal.AppConfig.DefaultInstance))
			{
				contextTypeHint = this._finder.TryFindContextType(assemblyHint, contextTypeHint, null);
				global::System.Type type2 = this._finder.TryFindConfigurationType(assemblyHint, contextTypeHint, null);
				if (type2 != null)
				{
					if (this._configuration.Value.Owner.GetType() == typeof(global::System.Data.Entity.DbConfiguration))
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.ConfigurationNotDiscovered(type2.Name));
					}
					if (contextTypeHint != null && type2 != this._configuration.Value.Owner.GetType())
					{
						throw new global::System.InvalidOperationException(global::System.Data.Entity.Resources.Strings.SetConfigurationNotDiscovered(this._configuration.Value.Owner.GetType().Name, contextTypeHint.Name));
					}
				}
			}
			this._knownAssemblies.TryAdd(assemblyHint, null);
		}

		// Token: 0x17000734 RID: 1844
		// (get) Token: 0x060021BE RID: 8638 RVA: 0x0005DDB8 File Offset: 0x0005BFB8
		private bool ConfigurationSet
		{
			get
			{
				return this._configuration.IsValueCreated;
			}
		}

		// Token: 0x060021BF RID: 8639 RVA: 0x0005DDC8 File Offset: 0x0005BFC8
		public virtual bool PushConfiguration(global::System.Data.Entity.Internal.AppConfig config, global::System.Type contextType)
		{
			if (config == global::System.Data.Entity.Internal.AppConfig.DefaultInstance && (contextType == typeof(global::System.Data.Entity.DbContext) || this._knownAssemblies.ContainsKey(contextType.Assembly())))
			{
				return false;
			}
			global::System.Type type;
			if ((type = this._loader.TryLoadFromConfig(config)) == null)
			{
				type = (this._finder.TryFindConfigurationType(contextType, null) ?? typeof(global::System.Data.Entity.DbConfiguration));
			}
			global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration internalConfiguration = type.CreateInstance(new global::System.Func<string, string, string>(global::System.Data.Entity.Resources.Strings.CreateInstance_BadDbConfigurationType), null).InternalConfiguration;
			internalConfiguration.SwitchInRootResolver(this._configuration.Value.RootResolver);
			internalConfiguration.AddAppConfigResolver(new global::System.Data.Entity.Infrastructure.DependencyResolution.AppConfigDependencyResolver(config, internalConfiguration, null));
			object @lock = this._lock;
			lock (@lock)
			{
				this._configurationOverrides.Value.Add(global::System.Tuple.Create<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>(config, internalConfiguration));
			}
			internalConfiguration.Lock();
			return true;
		}

		// Token: 0x060021C0 RID: 8640 RVA: 0x0005DEB8 File Offset: 0x0005C0B8
		public virtual void PopConfiguration(global::System.Data.Entity.Internal.AppConfig config)
		{
			object @lock = this._lock;
			lock (@lock)
			{
				global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration> tuple = this._configurationOverrides.Value.FirstOrDefault((global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration> c) => c.Item1 == config);
				if (tuple != null)
				{
					this._configurationOverrides.Value.Remove(tuple);
				}
			}
		}

		// Token: 0x04000BBA RID: 3002
		private static readonly global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager _configManager = new global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager(new global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoader(), new global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationFinder());

		// Token: 0x04000BBB RID: 3003
		private global::System.EventHandler<global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoadedEventArgs> _loadedHandler;

		// Token: 0x04000BBC RID: 3004
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationLoader _loader;

		// Token: 0x04000BBD RID: 3005
		private readonly global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationFinder _finder;

		// Token: 0x04000BBE RID: 3006
		private readonly global::System.Lazy<global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration> _configuration;

		// Token: 0x04000BBF RID: 3007
		private volatile global::System.Data.Entity.DbConfiguration _newConfiguration;

		// Token: 0x04000BC0 RID: 3008
		private volatile global::System.Type _newConfigurationType = typeof(global::System.Data.Entity.DbConfiguration);

		// Token: 0x04000BC1 RID: 3009
		private readonly object _lock = new object();

		// Token: 0x04000BC2 RID: 3010
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.Assembly, object> _knownAssemblies = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Reflection.Assembly, object>();

		// Token: 0x04000BC3 RID: 3011
		private readonly global::System.Lazy<global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>>> _configurationOverrides = new global::System.Lazy<global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>>>(() => new global::System.Collections.Generic.List<global::System.Tuple<global::System.Data.Entity.Internal.AppConfig, global::System.Data.Entity.Infrastructure.DependencyResolution.InternalConfiguration>>());
	}
}
