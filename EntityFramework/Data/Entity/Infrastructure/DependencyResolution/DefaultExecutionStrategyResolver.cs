using System;
using System.Collections.Generic;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B0 RID: 688
	internal class DefaultExecutionStrategyResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021C3 RID: 8643 RVA: 0x0005DF84 File Offset: 0x0005C184
		public object GetService(global::System.Type type, object key)
		{
			if (!(type == typeof(global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>)))
			{
				return null;
			}
			global::System.Data.Entity.Utilities.Check.NotNull<object>(key, "key");
			if (!(key is global::System.Data.Entity.Infrastructure.ExecutionStrategyKey))
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_InvalidKey(typeof(global::System.Data.Entity.Infrastructure.ExecutionStrategyKey).Name, "Func<IExecutionStrategy>"));
			}
			return new global::System.Func<global::System.Data.Entity.Infrastructure.IDbExecutionStrategy>(() => new global::System.Data.Entity.Infrastructure.DefaultExecutionStrategy());
		}

		// Token: 0x060021C4 RID: 8644 RVA: 0x0005DFF7 File Offset: 0x0005C1F7
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}
	}
}
