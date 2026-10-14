using System;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Resources;

namespace System.Data.Entity.Internal
{
	// Token: 0x020000FC RID: 252
	internal class EagerInternalContext : global::System.Data.Entity.Internal.InternalContext
	{
		// Token: 0x0600125B RID: 4699 RVA: 0x0002F4CF File Offset: 0x0002D6CF
		public EagerInternalContext(global::System.Data.Entity.DbContext owner) : base(owner, null)
		{
		}

		// Token: 0x0600125C RID: 4700 RVA: 0x0002F4DC File Offset: 0x0002D6DC
		public EagerInternalContext(global::System.Data.Entity.DbContext owner, global::System.Data.Entity.Core.Objects.ObjectContext objectContext, bool objectContextOwned) : base(owner, null)
		{
			this._objectContext = objectContext;
			this._objectContextOwned = objectContextOwned;
			this._originalConnectionString = global::System.Data.Entity.Internal.InternalConnection.GetStoreConnectionString(this._objectContext.Connection);
			this._objectContext.InterceptionContext = this._objectContext.InterceptionContext.WithDbContext(owner);
			base.LoadContextConfigs();
			base.ResetDbSets();
			this._objectContext.InitializeMappingViewCacheFactory(base.Owner);
		}

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x0600125D RID: 4701 RVA: 0x0002F54E File Offset: 0x0002D74E
		public override global::System.Data.Entity.Core.Objects.ObjectContext ObjectContext
		{
			get
			{
				base.Initialize();
				return this.ObjectContextInUse;
			}
		}

		// Token: 0x0600125E RID: 4702 RVA: 0x0002F55C File Offset: 0x0002D75C
		public override global::System.Data.Entity.Core.Objects.ObjectContext GetObjectContextWithoutDatabaseInitialization()
		{
			this.InitializeContext();
			return this.ObjectContextInUse;
		}

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x0600125F RID: 4703 RVA: 0x0002F56A File Offset: 0x0002D76A
		private global::System.Data.Entity.Core.Objects.ObjectContext ObjectContextInUse
		{
			get
			{
				return base.TempObjectContext ?? this._objectContext;
			}
		}

		// Token: 0x06001260 RID: 4704 RVA: 0x0002F57C File Offset: 0x0002D77C
		protected override void InitializeContext()
		{
			base.CheckContextNotDisposed();
		}

		// Token: 0x06001261 RID: 4705 RVA: 0x0002F584 File Offset: 0x0002D784
		public override void MarkDatabaseNotInitialized()
		{
		}

		// Token: 0x06001262 RID: 4706 RVA: 0x0002F586 File Offset: 0x0002D786
		public override void MarkDatabaseInitialized()
		{
		}

		// Token: 0x06001263 RID: 4707 RVA: 0x0002F588 File Offset: 0x0002D788
		protected override void InitializeDatabase()
		{
		}

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001264 RID: 4708 RVA: 0x0002F58A File Offset: 0x0002D78A
		public override global::System.Data.Entity.IDatabaseInitializer<global::System.Data.Entity.DbContext> DefaultInitializer
		{
			get
			{
				return null;
			}
		}

		// Token: 0x06001265 RID: 4709 RVA: 0x0002F58D File Offset: 0x0002D78D
		public override void DisposeContext(bool disposing)
		{
			if (!base.IsDisposed)
			{
				base.DisposeContext(disposing);
				if (disposing && this._objectContextOwned)
				{
					this._objectContext.Dispose();
				}
			}
		}

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001266 RID: 4710 RVA: 0x0002F5B4 File Offset: 0x0002D7B4
		public override global::System.Data.Common.DbConnection Connection
		{
			get
			{
				base.CheckContextNotDisposed();
				return ((global::System.Data.Entity.Core.EntityClient.EntityConnection)this._objectContext.Connection).StoreConnection;
			}
		}

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001267 RID: 4711 RVA: 0x0002F5D1 File Offset: 0x0002D7D1
		public override string OriginalConnectionString
		{
			get
			{
				return this._originalConnectionString;
			}
		}

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001268 RID: 4712 RVA: 0x0002F5D9 File Offset: 0x0002D7D9
		public override global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin ConnectionStringOrigin
		{
			get
			{
				return global::System.Data.Entity.Infrastructure.DbConnectionStringOrigin.UserCode;
			}
		}

		// Token: 0x06001269 RID: 4713 RVA: 0x0002F5DC File Offset: 0x0002D7DC
		public override void OverrideConnection(global::System.Data.Entity.Internal.IInternalConnection connection)
		{
			throw global::System.Data.Entity.Resources.Error.EagerInternalContext_CannotSetConnectionInfo();
		}

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x0600126A RID: 4714 RVA: 0x0002F5E3 File Offset: 0x0002D7E3
		// (set) Token: 0x0600126B RID: 4715 RVA: 0x0002F5F5 File Offset: 0x0002D7F5
		public override bool EnsureTransactionsForFunctionsAndCommands
		{
			get
			{
				return this.ObjectContextInUse.ContextOptions.EnsureTransactionsForFunctionsAndCommands;
			}
			set
			{
				this.ObjectContextInUse.ContextOptions.EnsureTransactionsForFunctionsAndCommands = value;
			}
		}

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x0600126C RID: 4716 RVA: 0x0002F608 File Offset: 0x0002D808
		// (set) Token: 0x0600126D RID: 4717 RVA: 0x0002F61A File Offset: 0x0002D81A
		public override bool LazyLoadingEnabled
		{
			get
			{
				return this.ObjectContextInUse.ContextOptions.LazyLoadingEnabled;
			}
			set
			{
				this.ObjectContextInUse.ContextOptions.LazyLoadingEnabled = value;
			}
		}

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x0600126E RID: 4718 RVA: 0x0002F62D File Offset: 0x0002D82D
		// (set) Token: 0x0600126F RID: 4719 RVA: 0x0002F63F File Offset: 0x0002D83F
		public override bool ProxyCreationEnabled
		{
			get
			{
				return this.ObjectContextInUse.ContextOptions.ProxyCreationEnabled;
			}
			set
			{
				this.ObjectContextInUse.ContextOptions.ProxyCreationEnabled = value;
			}
		}

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001270 RID: 4720 RVA: 0x0002F652 File Offset: 0x0002D852
		// (set) Token: 0x06001271 RID: 4721 RVA: 0x0002F667 File Offset: 0x0002D867
		public override bool UseDatabaseNullSemantics
		{
			get
			{
				return !this.ObjectContextInUse.ContextOptions.UseCSharpNullComparisonBehavior;
			}
			set
			{
				this.ObjectContextInUse.ContextOptions.UseCSharpNullComparisonBehavior = !value;
			}
		}

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001272 RID: 4722 RVA: 0x0002F67D File Offset: 0x0002D87D
		// (set) Token: 0x06001273 RID: 4723 RVA: 0x0002F692 File Offset: 0x0002D892
		public override bool DisableFilterOverProjectionSimplificationForCustomFunctions
		{
			get
			{
				return !this.ObjectContextInUse.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions;
			}
			set
			{
				this.ObjectContextInUse.ContextOptions.DisableFilterOverProjectionSimplificationForCustomFunctions = !value;
			}
		}

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001274 RID: 4724 RVA: 0x0002F6A8 File Offset: 0x0002D8A8
		// (set) Token: 0x06001275 RID: 4725 RVA: 0x0002F6B5 File Offset: 0x0002D8B5
		public override int? CommandTimeout
		{
			get
			{
				return this.ObjectContextInUse.CommandTimeout;
			}
			set
			{
				this.ObjectContextInUse.CommandTimeout = value;
			}
		}

		// Token: 0x0400091A RID: 2330
		private readonly global::System.Data.Entity.Core.Objects.ObjectContext _objectContext;

		// Token: 0x0400091B RID: 2331
		private readonly bool _objectContextOwned;

		// Token: 0x0400091C RID: 2332
		private readonly string _originalConnectionString;
	}
}
