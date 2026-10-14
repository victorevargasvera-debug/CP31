using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002BF RID: 703
	public class TransactionHandlerResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x06002212 RID: 8722 RVA: 0x0005ED84 File Offset: 0x0005CF84
		public TransactionHandlerResolver(global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> transactionHandlerFactory, string providerInvariantName, string serverName)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>>(transactionHandlerFactory, "transactionHandlerFactory");
			this._providerInvariantName = providerInvariantName;
			this._serverName = serverName;
			this._transactionHandlerFactory = transactionHandlerFactory;
		}

		// Token: 0x06002213 RID: 8723 RVA: 0x0005EDB0 File Offset: 0x0005CFB0
		public object GetService(global::System.Type type, object key)
		{
			if (!(type == typeof(global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler>)))
			{
				return null;
			}
			global::System.Data.Entity.Infrastructure.ExecutionStrategyKey executionStrategyKey = key as global::System.Data.Entity.Infrastructure.ExecutionStrategyKey;
			if (executionStrategyKey == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_InvalidKey(typeof(global::System.Data.Entity.Infrastructure.ExecutionStrategyKey).Name, "Func<TransactionHandler>"));
			}
			if (this._providerInvariantName != null && !executionStrategyKey.ProviderInvariantName.Equals(this._providerInvariantName, global::System.StringComparison.Ordinal))
			{
				return null;
			}
			if (this._serverName != null && !this._serverName.Equals(executionStrategyKey.ServerName, global::System.StringComparison.Ordinal))
			{
				return null;
			}
			return this._transactionHandlerFactory;
		}

		// Token: 0x06002214 RID: 8724 RVA: 0x0005EE3C File Offset: 0x0005D03C
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x06002215 RID: 8725 RVA: 0x0005EE48 File Offset: 0x0005D048
		public override bool Equals(object obj)
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionHandlerResolver transactionHandlerResolver = obj as global::System.Data.Entity.Infrastructure.DependencyResolution.TransactionHandlerResolver;
			return transactionHandlerResolver != null && (this._transactionHandlerFactory == transactionHandlerResolver._transactionHandlerFactory && this._providerInvariantName == transactionHandlerResolver._providerInvariantName) && this._serverName == transactionHandlerResolver._serverName;
		}

		// Token: 0x06002216 RID: 8726 RVA: 0x0005EE9C File Offset: 0x0005D09C
		public override int GetHashCode()
		{
			int num = this._transactionHandlerFactory.GetHashCode();
			if (this._providerInvariantName != null)
			{
				num = num * 41 + this._providerInvariantName.GetHashCode();
			}
			if (this._serverName != null)
			{
				num = num * 41 + this._serverName.GetHashCode();
			}
			return num;
		}

		// Token: 0x04000BD9 RID: 3033
		private readonly global::System.Func<global::System.Data.Entity.Infrastructure.TransactionHandler> _transactionHandlerFactory;

		// Token: 0x04000BDA RID: 3034
		private readonly string _providerInvariantName;

		// Token: 0x04000BDB RID: 3035
		private readonly string _serverName;
	}
}
