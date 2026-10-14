using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.DependencyResolution
{
	// Token: 0x020002B1 RID: 689
	internal class DefaultInvariantNameResolver : global::System.Data.Entity.Infrastructure.DependencyResolution.IDbDependencyResolver
	{
		// Token: 0x060021C6 RID: 8646 RVA: 0x0005E00C File Offset: 0x0005C20C
		public virtual object GetService(global::System.Type type, object key)
		{
			if (!(type == typeof(global::System.Data.Entity.Infrastructure.IProviderInvariantName)))
			{
				return null;
			}
			global::System.Data.Common.DbProviderFactory dbProviderFactory = key as global::System.Data.Common.DbProviderFactory;
			if (dbProviderFactory == null)
			{
				throw new global::System.ArgumentException(global::System.Data.Entity.Resources.Strings.DbDependencyResolver_InvalidKey(typeof(global::System.Data.Common.DbProviderFactory).Name, typeof(global::System.Data.Entity.Infrastructure.IProviderInvariantName)));
			}
			return new global::System.Data.Entity.Infrastructure.ProviderInvariantName(dbProviderFactory.GetProviderInvariantName());
		}

		// Token: 0x060021C7 RID: 8647 RVA: 0x0005E064 File Offset: 0x0005C264
		public global::System.Collections.Generic.IEnumerable<object> GetServices(global::System.Type type, object key)
		{
			return this.GetServiceAsServices(type, key);
		}
	}
}
