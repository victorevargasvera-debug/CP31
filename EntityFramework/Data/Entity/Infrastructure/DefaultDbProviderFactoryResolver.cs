using System;
using System.Data.Common;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x0200023C RID: 572
	internal class DefaultDbProviderFactoryResolver : global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver
	{
		// Token: 0x06001E2F RID: 7727 RVA: 0x00053562 File Offset: 0x00051762
		public global::System.Data.Common.DbProviderFactory ResolveProviderFactory(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			return global::System.Data.Common.DbProviderFactories.GetFactory(connection);
		}
	}
}
