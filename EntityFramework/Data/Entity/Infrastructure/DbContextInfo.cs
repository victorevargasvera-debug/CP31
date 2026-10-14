using System;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Reflection;
using System.Runtime.ExceptionServices;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000225 RID: 549
	public class DbContextInfo
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x00051070 File Offset: 0x0004F270
		public DbContextInfo(global::System.Type contextType) : this(contextType, null)
		{
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x0005107A File Offset: 0x0004F27A
		internal DbContextInfo(global::System.Type contextType, global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), null, global::System.Data.Entity.Internal.AppConfig.DefaultInstance, null, resolver)
		{
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00051095 File Offset: 0x0004F295
		public DbContextInfo(global::System.Type contextType, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), null, global::System.Data.Entity.Internal.AppConfig.DefaultInstance, global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbConnectionInfo>(connectionInfo, "connectionInfo"), null)
		{
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x000510BA File Offset: 0x0004F2BA
		[global::System.Obsolete("The application configuration can contain multiple settings that affect the connection used by a DbContext. To ensure all configuration is taken into account, use a DbContextInfo constructor that accepts System.Configuration.Configuration")]
		public DbContextInfo(global::System.Type contextType, global::System.Configuration.ConnectionStringSettingsCollection connectionStringSettings) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), null, new global::System.Data.Entity.Internal.AppConfig(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Configuration.ConnectionStringSettingsCollection>(connectionStringSettings, "connectionStringSettings")), null, null)
		{
		}

		// Token: 0x06001CB8 RID: 7352 RVA: 0x000510E0 File Offset: 0x0004F2E0
		public DbContextInfo(global::System.Type contextType, global::System.Configuration.Configuration config) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), null, new global::System.Data.Entity.Internal.AppConfig(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Configuration.Configuration>(config, "config")), null, null)
		{
		}

		// Token: 0x06001CB9 RID: 7353 RVA: 0x00051106 File Offset: 0x0004F306
		public DbContextInfo(global::System.Type contextType, global::System.Configuration.Configuration config, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), null, new global::System.Data.Entity.Internal.AppConfig(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Configuration.Configuration>(config, "config")), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbConnectionInfo>(connectionInfo, "connectionInfo"), null)
		{
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00051136 File Offset: 0x0004F336
		public DbContextInfo(global::System.Type contextType, global::System.Data.Entity.Infrastructure.DbProviderInfo modelProviderInfo) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbProviderInfo>(modelProviderInfo, "modelProviderInfo"), global::System.Data.Entity.Internal.AppConfig.DefaultInstance, null, null)
		{
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x0005115B File Offset: 0x0004F35B
		public DbContextInfo(global::System.Type contextType, global::System.Configuration.Configuration config, global::System.Data.Entity.Infrastructure.DbProviderInfo modelProviderInfo) : this(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(contextType, "contextType"), global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbProviderInfo>(modelProviderInfo, "modelProviderInfo"), new global::System.Data.Entity.Internal.AppConfig(global::System.Data.Entity.Utilities.Check.NotNull<global::System.Configuration.Configuration>(config, "config")), null, null)
		{
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x0005118C File Offset: 0x0004F38C
		internal DbContextInfo(global::System.Data.Entity.DbContext context, global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver = null)
		{
			this._resolver = (() => global::System.Data.Entity.DbConfiguration.DependencyResolver);
			base..ctor();
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbContext>(context, "context");
			global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver2 = resolver;
			if (resolver == null && (resolver2 = global::System.Data.Entity.Infrastructure.DbContextInfo.<>c.<>9__21_0) == null)
			{
				resolver2 = (global::System.Data.Entity.Infrastructure.DbContextInfo.<>c.<>9__21_0 = (() => global::System.Data.Entity.DbConfiguration.DependencyResolver));
			}
			this._resolver = resolver2;
			this._contextType = context.GetType();
			this._appConfig = global::System.Data.Entity.Internal.AppConfig.DefaultInstance;
			global::System.Data.Entity.Internal.InternalContext internalContext = context.InternalContext;
			this._connectionProviderName = internalContext.ProviderName;
			this._connectionInfo = new global::System.Data.Entity.Infrastructure.DbConnectionInfo(internalContext.OriginalConnectionString, this._connectionProviderName);
			this._connectionString = internalContext.OriginalConnectionString;
			this._connectionStringName = internalContext.ConnectionStringName;
			this._connectionStringOrigin = internalContext.ConnectionStringOrigin;
		}

		// Token: 0x06001CBD RID: 7357 RVA: 0x00051260 File Offset: 0x0004F460
		private DbContextInfo(global::System.Type contextType, global::System.Data.Entity.Infrastructure.DbProviderInfo modelProviderInfo, global::System.Data.Entity.Internal.AppConfig config, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo, global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver = null)
		{
			this._resolver = (() => global::System.Data.Entity.DbConfiguration.DependencyResolver);
			base..ctor();
			if (!typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(contextType))
			{
				throw new global::System.ArgumentOutOfRangeException("contextType");
			}
			global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> resolver2 = resolver;
			if (resolver == null && (resolver2 = global::System.Data.Entity.Infrastructure.DbContextInfo.<>c.<>9__22_0) == null)
			{
				resolver2 = (global::System.Data.Entity.Infrastructure.DbContextInfo.<>c.<>9__22_0 = (() => global::System.Data.Entity.DbConfiguration.DependencyResolver));
			}
			this._resolver = resolver2;
			this._contextType = contextType;
			this._modelProviderInfo = modelProviderInfo;
			this._appConfig = config;
			this._connectionInfo = connectionInfo;
			this._activator = this.CreateActivator();
			if (this._activator != null)
			{
				global::System.Data.Entity.DbContext dbContext = this.CreateInstance();
				if (dbContext != null)
				{
					this._isConstructible = true;
					using (dbContext)
					{
						this._connectionString = global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.GetConnectionString(dbContext.InternalContext.Connection, new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithDbContext(dbContext));
						this._connectionStringName = dbContext.InternalContext.ConnectionStringName;
						this._connectionProviderName = dbContext.InternalContext.ProviderName;
						this._connectionStringOrigin = dbContext.InternalContext.ConnectionStringOrigin;
					}
				}
			}
		}

		// Token: 0x17000666 RID: 1638
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x000513A0 File Offset: 0x0004F5A0
		public virtual global::System.Type ContextType
		{
			get
			{
				return this._contextType;
			}
		}

		// Token: 0x17000667 RID: 1639
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x000513A8 File Offset: 0x0004F5A8
		public virtual bool IsConstructible
		{
			get
			{
				return this._isConstructible;
			}
		}

		// Token: 0x17000668 RID: 1640
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x000513B0 File Offset: 0x0004F5B0
		public virtual string ConnectionString
		{
			get
			{
				return this._connectionString;
			}
		}

		// Token: 0x17000669 RID: 1641
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x000513B8 File Offset: 0x0004F5B8
		public virtual string ConnectionStringName
		{
			get
			{
				return this._connectionStringName;
			}
		}

		// Token: 0x1700066A RID: 1642
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x000513C0 File Offset: 0x0004F5C0
		public virtual string ConnectionProviderName
		{
			get
			{
				return this._connectionProviderName;
			}
		}

		// Token: 0x1700066B RID: 1643
		// (get) Token: 0x06001CC3 RID: 7363 RVA: 0x000513C8 File Offset: 0x0004F5C8
		public virtual global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin
		{
			get
			{
				return this._connectionStringOrigin;
			}
		}

		// Token: 0x1700066C RID: 1644
		// (get) Token: 0x06001CC4 RID: 7364 RVA: 0x000513D0 File Offset: 0x0004F5D0
		// (set) Token: 0x06001CC5 RID: 7365 RVA: 0x000513D8 File Offset: 0x0004F5D8
		public virtual global::System.Action<global::System.Data.Entity.DbModelBuilder> OnModelCreating
		{
			get
			{
				return this._onModelCreating;
			}
			set
			{
				this._onModelCreating = value;
			}
		}

		// Token: 0x06001CC6 RID: 7366 RVA: 0x000513E4 File Offset: 0x0004F5E4
		public virtual global::System.Data.Entity.DbContext CreateInstance()
		{
			bool flag = global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.PushConfiguration(this._appConfig, this._contextType);
			global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = this;
			global::System.Data.Entity.DbContext dbContext = null;
			global::System.Data.Entity.DbContext result;
			try
			{
				try
				{
					dbContext = ((this._activator == null) ? null : this._activator());
				}
				catch (global::System.Reflection.TargetInvocationException ex)
				{
					global::System.Runtime.ExceptionServices.ExceptionDispatchInfo.Capture(ex.InnerException).Throw();
					throw ex.InnerException;
				}
				if (dbContext == null)
				{
					result = null;
				}
				else
				{
					dbContext.InternalContext.OnDisposing += delegate(object _, global::System.EventArgs __)
					{
						global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = null;
					};
					if (flag)
					{
						dbContext.InternalContext.OnDisposing += delegate(object _, global::System.EventArgs __)
						{
							global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.PopConfiguration(this._appConfig);
						};
					}
					dbContext.InternalContext.ApplyContextInfo(this);
					result = dbContext;
				}
			}
			catch (global::System.Exception)
			{
				if (dbContext != null)
				{
					dbContext.Dispose();
				}
				throw;
			}
			finally
			{
				if (dbContext == null)
				{
					global::System.Data.Entity.Infrastructure.DbContextInfo.CurrentInfo = null;
					if (flag)
					{
						global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.PopConfiguration(this._appConfig);
					}
				}
			}
			return result;
		}

		// Token: 0x06001CC7 RID: 7367 RVA: 0x000514EC File Offset: 0x0004F6EC
		internal void ConfigureContext(global::System.Data.Entity.DbContext context)
		{
			if (this._modelProviderInfo != null)
			{
				context.InternalContext.ModelProviderInfo = this._modelProviderInfo;
			}
			context.InternalContext.AppConfig = this._appConfig;
			if (this._connectionInfo != null)
			{
				context.InternalContext.OverrideConnection(new global::System.Data.Entity.Internal.LazyInternalConnection(context, this._connectionInfo));
			}
			else if (this._modelProviderInfo != null && this._appConfig == global::System.Data.Entity.Internal.AppConfig.DefaultInstance)
			{
				context.InternalContext.OverrideConnection(new global::System.Data.Entity.Internal.EagerInternalConnection(context, this._resolver().GetService(this._modelProviderInfo.ProviderInvariantName).CreateConnection(), true));
			}
			if (this._onModelCreating != null)
			{
				context.InternalContext.OnModelCreating = this._onModelCreating;
			}
		}

		// Token: 0x06001CC8 RID: 7368 RVA: 0x000515A4 File Offset: 0x0004F7A4
		private global::System.Func<global::System.Data.Entity.DbContext> CreateActivator()
		{
			if (this._contextType.GetPublicConstructor(new global::System.Type[0]) != null)
			{
				return () => (global::System.Data.Entity.DbContext)global::System.Activator.CreateInstance(this._contextType);
			}
			global::System.Func<global::System.Data.Entity.DbContext> service = this._resolver().GetService(this._contextType);
			if (service != null)
			{
				return service;
			}
			global::System.Type type = (from t in this._contextType.Assembly().GetAccessibleTypes()
			where t.IsClass() && typeof(global::System.Data.Entity.Infrastructure.IDbContextFactory<>).MakeGenericType(new global::System.Type[]
			{
				this._contextType
			}).IsAssignableFrom(t)
			select t).FirstOrDefault<global::System.Type>();
			if (type == null)
			{
				return null;
			}
			if (type.GetPublicConstructor(new global::System.Type[0]) == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbContextServices_MissingDefaultCtor(type);
			}
			return new global::System.Func<global::System.Data.Entity.DbContext>(((global::System.Data.Entity.Infrastructure.IDbContextFactory<global::System.Data.Entity.DbContext>)global::System.Activator.CreateInstance(type)).Create);
		}

		// Token: 0x1700066D RID: 1645
		// (get) Token: 0x06001CC9 RID: 7369 RVA: 0x00051657 File Offset: 0x0004F857
		// (set) Token: 0x06001CCA RID: 7370 RVA: 0x0005165E File Offset: 0x0004F85E
		internal static global::System.Data.Entity.Infrastructure.DbContextInfo CurrentInfo
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DbContextInfo._currentInfo;
			}
			set
			{
				global::System.Data.Entity.Infrastructure.DbContextInfo._currentInfo = value;
			}
		}

		// Token: 0x04000B03 RID: 2819
		[global::System.ThreadStatic]
		private static global::System.Data.Entity.Infrastructure.DbContextInfo _currentInfo;

		// Token: 0x04000B04 RID: 2820
		private readonly global::System.Type _contextType;

		// Token: 0x04000B05 RID: 2821
		private readonly global::System.Data.Entity.Infrastructure.DbProviderInfo _modelProviderInfo;

		// Token: 0x04000B06 RID: 2822
		private readonly global::System.Data.Entity.Infrastructure.DbConnectionInfo _connectionInfo;

		// Token: 0x04000B07 RID: 2823
		private readonly global::System.Data.Entity.Internal.AppConfig _appConfig;

		// Token: 0x04000B08 RID: 2824
		private readonly global::System.Func<global::System.Data.Entity.DbContext> _activator;

		// Token: 0x04000B09 RID: 2825
		private readonly string _connectionString;

		// Token: 0x04000B0A RID: 2826
		private readonly string _connectionProviderName;

		// Token: 0x04000B0B RID: 2827
		private readonly bool _isConstructible;

		// Token: 0x04000B0C RID: 2828
		private readonly global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin _connectionStringOrigin;

		// Token: 0x04000B0D RID: 2829
		private readonly string _connectionStringName;

		// Token: 0x04000B0E RID: 2830
		private readonly global::System.Func<global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver> _resolver;

		// Token: 0x04000B0F RID: 2831
		private global::System.Action<global::System.Data.Entity.DbModelBuilder> _onModelCreating;
	}
}
