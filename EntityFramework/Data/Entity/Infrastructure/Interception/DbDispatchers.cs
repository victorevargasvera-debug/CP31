using System;
using System.ComponentModel;

namespace System.Data.Entity.Infrastructure.Interception
{
	// Token: 0x02000284 RID: 644
	public class DbDispatchers
	{
		// Token: 0x06002073 RID: 8307 RVA: 0x0005B07C File Offset: 0x0005927C
		internal DbDispatchers()
		{
		}

		// Token: 0x170006FB RID: 1787
		// (get) Token: 0x06002074 RID: 8308 RVA: 0x0005B0DC File Offset: 0x000592DC
		internal virtual global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher CommandTree
		{
			get
			{
				return this._commandTreeDispatcher;
			}
		}

		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06002075 RID: 8309 RVA: 0x0005B0E4 File Offset: 0x000592E4
		public virtual global::System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher Command
		{
			get
			{
				return this._commandDispatcher;
			}
		}

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x06002076 RID: 8310 RVA: 0x0005B0EC File Offset: 0x000592EC
		public virtual global::System.Data.Entity.Infrastructure.Interception.DbTransactionDispatcher Transaction
		{
			get
			{
				return this._transactionDispatcher;
			}
		}

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x06002077 RID: 8311 RVA: 0x0005B0F4 File Offset: 0x000592F4
		public virtual global::System.Data.Entity.Infrastructure.Interception.DbConnectionDispatcher Connection
		{
			get
			{
				return this._dbConnectionDispatcher;
			}
		}

		// Token: 0x170006FF RID: 1791
		// (get) Token: 0x06002078 RID: 8312 RVA: 0x0005B0FC File Offset: 0x000592FC
		internal virtual global::System.Data.Entity.Infrastructure.Interception.DbConfigurationDispatcher Configuration
		{
			get
			{
				return this._configurationDispatcher;
			}
		}

		// Token: 0x17000700 RID: 1792
		// (get) Token: 0x06002079 RID: 8313 RVA: 0x0005B104 File Offset: 0x00059304
		internal virtual global::System.Data.Entity.Infrastructure.Interception.CancelableEntityConnectionDispatcher CancelableEntityConnection
		{
			get
			{
				return this._cancelableEntityConnectionDispatcher;
			}
		}

		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x0600207A RID: 8314 RVA: 0x0005B10C File Offset: 0x0005930C
		internal virtual global::System.Data.Entity.Infrastructure.Interception.CancelableDbCommandDispatcher CancelableCommand
		{
			get
			{
				return this._cancelableCommandDispatcher;
			}
		}

		// Token: 0x0600207B RID: 8315 RVA: 0x0005B114 File Offset: 0x00059314
		internal virtual void AddInterceptor(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			this._commandTreeDispatcher.InternalDispatcher.Add(interceptor);
			this._commandDispatcher.InternalDispatcher.Add(interceptor);
			this._transactionDispatcher.InternalDispatcher.Add(interceptor);
			this._dbConnectionDispatcher.InternalDispatcher.Add(interceptor);
			this._cancelableEntityConnectionDispatcher.InternalDispatcher.Add(interceptor);
			this._cancelableCommandDispatcher.InternalDispatcher.Add(interceptor);
			this._configurationDispatcher.InternalDispatcher.Add(interceptor);
		}

		// Token: 0x0600207C RID: 8316 RVA: 0x0005B198 File Offset: 0x00059398
		internal virtual void RemoveInterceptor(global::System.Data.Entity.Infrastructure.Interception.IDbInterceptor interceptor)
		{
			this._commandTreeDispatcher.InternalDispatcher.Remove(interceptor);
			this._commandDispatcher.InternalDispatcher.Remove(interceptor);
			this._transactionDispatcher.InternalDispatcher.Remove(interceptor);
			this._dbConnectionDispatcher.InternalDispatcher.Remove(interceptor);
			this._cancelableEntityConnectionDispatcher.InternalDispatcher.Remove(interceptor);
			this._cancelableCommandDispatcher.InternalDispatcher.Remove(interceptor);
			this._configurationDispatcher.InternalDispatcher.Remove(interceptor);
		}

		// Token: 0x0600207D RID: 8317 RVA: 0x0005B21C File Offset: 0x0005941C
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x0600207E RID: 8318 RVA: 0x0005B224 File Offset: 0x00059424
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600207F RID: 8319 RVA: 0x0005B22D File Offset: 0x0005942D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06002080 RID: 8320 RVA: 0x0005B235 File Offset: 0x00059435
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B7C RID: 2940
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher _commandTreeDispatcher = new global::System.Data.Entity.Infrastructure.Interception.DbCommandTreeDispatcher();

		// Token: 0x04000B7D RID: 2941
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher _commandDispatcher = new global::System.Data.Entity.Infrastructure.Interception.DbCommandDispatcher();

		// Token: 0x04000B7E RID: 2942
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbTransactionDispatcher _transactionDispatcher = new global::System.Data.Entity.Infrastructure.Interception.DbTransactionDispatcher();

		// Token: 0x04000B7F RID: 2943
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbConnectionDispatcher _dbConnectionDispatcher = new global::System.Data.Entity.Infrastructure.Interception.DbConnectionDispatcher();

		// Token: 0x04000B80 RID: 2944
		private readonly global::System.Data.Entity.Infrastructure.Interception.DbConfigurationDispatcher _configurationDispatcher = new global::System.Data.Entity.Infrastructure.Interception.DbConfigurationDispatcher();

		// Token: 0x04000B81 RID: 2945
		private readonly global::System.Data.Entity.Infrastructure.Interception.CancelableEntityConnectionDispatcher _cancelableEntityConnectionDispatcher = new global::System.Data.Entity.Infrastructure.Interception.CancelableEntityConnectionDispatcher();

		// Token: 0x04000B82 RID: 2946
		private readonly global::System.Data.Entity.Infrastructure.Interception.CancelableDbCommandDispatcher _cancelableCommandDispatcher = new global::System.Data.Entity.Infrastructure.Interception.CancelableDbCommandDispatcher();
	}
}
