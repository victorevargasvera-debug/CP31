using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Infrastructure.Interception;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.Internal
{
	// Token: 0x02000123 RID: 291
	internal class LazyInternalConnection : global::System.Data.Entity.Internal.InternalConnection
	{
		// Token: 0x06001443 RID: 5187 RVA: 0x00033921 File Offset: 0x00031B21
		public LazyInternalConnection(string nameOrConnectionString) : this(null, nameOrConnectionString)
		{
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0003392B File Offset: 0x00031B2B
		public LazyInternalConnection(global::System.Data.Entity.DbContext context, string nameOrConnectionString) : base((context == null) ? null : new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithDbContext(context))
		{
			this._nameOrConnectionString = nameOrConnectionString;
			this.AppConfig = global::System.Data.Entity.Internal.AppConfig.DefaultInstance;
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x00033956 File Offset: 0x00031B56
		public LazyInternalConnection(global::System.Data.Entity.DbContext context, global::System.Data.Entity.Infrastructure.DbConnectionInfo connectionInfo) : base(new global::System.Data.Entity.Infrastructure.Interception.DbInterceptionContext().WithDbContext(context))
		{
			this._connectionInfo = connectionInfo;
			this.AppConfig = global::System.Data.Entity.Internal.AppConfig.DefaultInstance;
		}

		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001446 RID: 5190 RVA: 0x0003397B File Offset: 0x00031B7B
		public override global::System.Data.Common.DbConnection Connection
		{
			get
			{
				this.Initialize();
				return base.Connection;
			}
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06001447 RID: 5191 RVA: 0x00033989 File Offset: 0x00031B89
		public override global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin
		{
			get
			{
				this.Initialize();
				return this._connectionStringOrigin;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06001448 RID: 5192 RVA: 0x00033997 File Offset: 0x00031B97
		public override string ConnectionStringName
		{
			get
			{
				this.Initialize();
				return this._connectionStringName;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06001449 RID: 5193 RVA: 0x000339A5 File Offset: 0x00031BA5
		public override string ConnectionKey
		{
			get
			{
				this.Initialize();
				return base.ConnectionKey;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600144A RID: 5194 RVA: 0x000339B3 File Offset: 0x00031BB3
		public override string OriginalConnectionString
		{
			get
			{
				this.Initialize();
				return base.OriginalConnectionString;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600144B RID: 5195 RVA: 0x000339C1 File Offset: 0x00031BC1
		// (set) Token: 0x0600144C RID: 5196 RVA: 0x000339CF File Offset: 0x00031BCF
		public override string ProviderName
		{
			get
			{
				this.Initialize();
				return base.ProviderName;
			}
			set
			{
				base.ProviderName = value;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x0600144D RID: 5197 RVA: 0x000339D8 File Offset: 0x00031BD8
		public override bool ConnectionHasModel
		{
			get
			{
				if (this._hasModel == null)
				{
					if (base.UnderlyingConnection == null)
					{
						string nameOrConnectionString = this._nameOrConnectionString;
						string text;
						if (this._connectionInfo != null)
						{
							nameOrConnectionString = this._connectionInfo.GetConnectionString(this.AppConfig).ConnectionString;
						}
						else if (global::System.Data.Entity.Internal.DbHelpers.TryGetConnectionName(this._nameOrConnectionString, out text))
						{
							global::System.Configuration.ConnectionStringSettings connectionStringSettings = global::System.Data.Entity.Internal.LazyInternalConnection.FindConnectionInConfig(text, this.AppConfig);
							if (connectionStringSettings == null && global::System.Data.Entity.Internal.DbHelpers.TreatAsConnectionString(this._nameOrConnectionString))
							{
								throw global::System.Data.Entity.Resources.Error.DbContext_ConnectionStringNotFound(text);
							}
							if (connectionStringSettings != null)
							{
								nameOrConnectionString = connectionStringSettings.ConnectionString;
							}
						}
						this._hasModel = new bool?(global::System.Data.Entity.Internal.DbHelpers.IsFullEFConnectionString(nameOrConnectionString));
					}
					else
					{
						this._hasModel = new bool?(base.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection);
					}
				}
				return this._hasModel.Value;
			}
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x00033A99 File Offset: 0x00031C99
		public override global::System.Data.Entity.Core.Objects.ObjectContext CreateObjectContextFromConnectionModel()
		{
			this.Initialize();
			return base.CreateObjectContextFromConnectionModel();
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x00033AA8 File Offset: 0x00031CA8
		public override void Dispose()
		{
			if (base.UnderlyingConnection != null)
			{
				if (base.UnderlyingConnection is global::System.Data.Entity.Core.EntityClient.EntityConnection)
				{
					base.UnderlyingConnection.Dispose();
				}
				else
				{
					global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.Dispose(base.UnderlyingConnection, base.InterceptionContext);
				}
				base.UnderlyingConnection = null;
			}
		}

		// Token: 0x17000548 RID: 1352
		// (get) Token: 0x06001450 RID: 5200 RVA: 0x00033AF9 File Offset: 0x00031CF9
		internal bool IsInitialized
		{
			get
			{
				return base.UnderlyingConnection != null;
			}
		}

		// Token: 0x06001451 RID: 5201 RVA: 0x00033B04 File Offset: 0x00031D04
		private void Initialize()
		{
			if (base.UnderlyingConnection == null)
			{
				string text;
				if (this._connectionInfo != null)
				{
					global::System.Configuration.ConnectionStringSettings connectionString = this._connectionInfo.GetConnectionString(this.AppConfig);
					this.InitializeFromConnectionStringSetting(connectionString);
					this._connectionStringOrigin = global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.DbContextInfo;
					this._connectionStringName = connectionString.Name;
				}
				else if (!global::System.Data.Entity.Internal.DbHelpers.TryGetConnectionName(this._nameOrConnectionString, out text) || !this.TryInitializeFromAppConfig(text, this.AppConfig))
				{
					if (text != null && global::System.Data.Entity.Internal.DbHelpers.TreatAsConnectionString(this._nameOrConnectionString))
					{
						throw global::System.Data.Entity.Resources.Error.DbContext_ConnectionStringNotFound(text);
					}
					if (global::System.Data.Entity.Internal.DbHelpers.IsFullEFConnectionString(this._nameOrConnectionString))
					{
						base.UnderlyingConnection = new global::System.Data.Entity.Core.EntityClient.EntityConnection(this._nameOrConnectionString);
					}
					else if (base.ProviderName != null)
					{
						this.CreateConnectionFromProviderName(base.ProviderName);
					}
					else
					{
						base.UnderlyingConnection = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IDbConnectionFactory>().CreateConnection(text ?? this._nameOrConnectionString);
						if (base.UnderlyingConnection == null)
						{
							throw global::System.Data.Entity.Resources.Error.DbContext_ConnectionFactoryReturnedNullConnection();
						}
					}
					if (text != null)
					{
						this._connectionStringOrigin = global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.Convention;
						this._connectionStringName = text;
					}
					else
					{
						this._connectionStringOrigin = global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.UserCode;
					}
				}
				base.OnConnectionInitialized();
			}
		}

		// Token: 0x06001452 RID: 5202 RVA: 0x00033C14 File Offset: 0x00031E14
		private bool TryInitializeFromAppConfig(string name, global::System.Data.Entity.Internal.AppConfig config)
		{
			global::System.Configuration.ConnectionStringSettings connectionStringSettings = global::System.Data.Entity.Internal.LazyInternalConnection.FindConnectionInConfig(name, config);
			if (connectionStringSettings != null)
			{
				this.InitializeFromConnectionStringSetting(connectionStringSettings);
				this._connectionStringOrigin = global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.Configuration;
				this._connectionStringName = connectionStringSettings.Name;
				return true;
			}
			return false;
		}

		// Token: 0x06001453 RID: 5203 RVA: 0x00033C4C File Offset: 0x00031E4C
		private static global::System.Configuration.ConnectionStringSettings FindConnectionInConfig(string name, global::System.Data.Entity.Internal.AppConfig config)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>
			{
				name
			};
			int num = name.LastIndexOf('.');
			if (num >= 0 && num + 1 < name.Length)
			{
				list.Add(name.Substring(num + 1));
			}
			return (from c in list
			where config.GetConnectionString(c) != null
			select config.GetConnectionString(c)).FirstOrDefault<global::System.Configuration.ConnectionStringSettings>();
		}

		// Token: 0x06001454 RID: 5204 RVA: 0x00033CC4 File Offset: 0x00031EC4
		private void InitializeFromConnectionStringSetting(global::System.Configuration.ConnectionStringSettings appConfigConnection)
		{
			string providerName = appConfigConnection.ProviderName;
			if (string.IsNullOrWhiteSpace(providerName))
			{
				throw global::System.Data.Entity.Resources.Error.DbContext_ProviderNameMissing(appConfigConnection.Name);
			}
			if (string.Equals(providerName, "System.Data.EntityClient", global::System.StringComparison.OrdinalIgnoreCase))
			{
				base.UnderlyingConnection = new global::System.Data.Entity.Core.EntityClient.EntityConnection(appConfigConnection.ConnectionString);
				return;
			}
			this.CreateConnectionFromProviderName(providerName);
			global::System.Data.Entity.Infrastructure.Interception.DbInterception.Dispatch.Connection.SetConnectionString(base.UnderlyingConnection, new global::System.Data.Entity.Infrastructure.Interception.DbConnectionPropertyInterceptionContext<string>().WithValue(appConfigConnection.ConnectionString));
		}

		// Token: 0x06001455 RID: 5205 RVA: 0x00033D38 File Offset: 0x00031F38
		private void CreateConnectionFromProviderName(string providerInvariantName)
		{
			global::System.Data.Common.DbProviderFactory service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(providerInvariantName);
			base.UnderlyingConnection = service.CreateConnection();
			if (base.UnderlyingConnection == null)
			{
				throw global::System.Data.Entity.Resources.Error.DbContext_ProviderReturnedNullConnection();
			}
		}

		// Token: 0x04000988 RID: 2440
		private readonly string _nameOrConnectionString;

		// Token: 0x04000989 RID: 2441
		private global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin _connectionStringOrigin;

		// Token: 0x0400098A RID: 2442
		private string _connectionStringName;

		// Token: 0x0400098B RID: 2443
		private readonly global::System.Data.Entity.Infrastructure.DbConnectionInfo _connectionInfo;

		// Token: 0x0400098C RID: 2444
		private bool? _hasModel;
	}
}
