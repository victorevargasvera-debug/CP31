using System;
using System.Data.Common;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200024F RID: 591
	public interface IDbProviderFactoryResolver
	{
		// Token: 0x06001EBA RID: 7866
		global::System.Data.Common.DbProviderFactory ResolveProviderFactory(global::System.Data.Common.DbConnection connection);
	}
}
