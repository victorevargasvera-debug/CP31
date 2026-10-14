using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000073 RID: 115
	internal static class DbConnectionExtensions
	{
		// Token: 0x0600042E RID: 1070 RVA: 0x0000E9B9 File Offset: 0x0000CBB9
		public static string GetProviderInvariantName(this global::System.Data.Common.DbConnection connection)
		{
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderFactory(connection)).Name;
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		public static global::System.Data.Entity.Infrastructure.DbProviderInfo GetProviderInfo(this global::System.Data.Common.DbConnection connection, out global::System.Data.Entity.Core.Common.DbProviderManifest providerManifest)
		{
			string text = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IManifestTokenResolver>().ResolveManifestToken(connection);
			global::System.Data.Entity.Infrastructure.DbProviderInfo result = new global::System.Data.Entity.Infrastructure.DbProviderInfo(connection.GetProviderInvariantName(), text);
			providerManifest = global::System.Data.Entity.Core.Common.DbProviderServices.GetProviderServices(connection).GetProviderManifest(text);
			return result;
		}

		// Token: 0x06000430 RID: 1072 RVA: 0x0000EA08 File Offset: 0x0000CC08
		public static global::System.Data.Common.DbProviderFactory GetProviderFactory(this global::System.Data.Common.DbConnection connection)
		{
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver>().ResolveProviderFactory(connection);
		}
	}
}
