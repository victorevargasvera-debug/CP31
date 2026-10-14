using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B4 RID: 692
	public class ExecutionStrategyResolver<T> : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver where T : global::System.Data.Entity.Infrastructure.IDbExecutionStrategy
	{
		// Token: 0x060021D1 RID: 8657 RVA: 0x0005E1F1 File Offset: 0x0005C3F1
		public ExecutionStrategyResolver(string providerInvariantName, string serverName, global::System.Func<T> getExecutionStrategy)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(providerInvariantName, "providerInvariantName");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Func<T>>(getExecutionStrategy, "getExecutionStrategy");
			this._providerInvariantName = providerInvariantName;
			this._serverName = serverName;
			this._getExecutionStrategy = getExecutionStrategy;
		}

		// Token: 0x060021D2 RID: 8658 RVA: 0x0005E228 File Offset: 0x0005C428
		public object GetService(global::System.Type type, object key)
		{
			if (!(type == typeof(global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>)))
			{
				return null;
			}
			global::System.Data.Entity.Infrastructure.ExecutionStrategyKey executionStrategyKey = key as global::System.Data.Entity.Infrastructure.ExecutionStrategyKey;
			if (executionStrategyKey == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_InvalidKey(typeof(global::System.Data.Entity.Infrastructure.ExecutionStrategyKey).Name, "Func<IExecutionStrategy>"));
			}
			if (!executionStrategyKey.ProviderInvariantName.Equals(this._providerInvariantName, global::System.StringComparison.Ordinal))
			{
				return null;
			}
			if (this._serverName != null && !this._serverName.Equals(executionStrategyKey.ServerName, global::System.StringComparison.Ordinal))
			{
				return null;
			}
			return this._getExecutionStrategy;
		}

		// Token: 0x060021D3 RID: 8659 RVA: 0x0005E2AC File Offset: 0x0005C4AC
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}

		// Token: 0x04000BC4 RID: 3012
		private readonly global::System.Func<T> _getExecutionStrategy;

		// Token: 0x04000BC5 RID: 3013
		private readonly string _providerInvariantName;

		// Token: 0x04000BC6 RID: 3014
		private readonly string _serverName;
	}
}
