using System;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000078 RID: 120
	internal static class DbProviderInfoExtensions
	{
		// Token: 0x06000438 RID: 1080 RVA: 0x0000EBDB File Offset: 0x0000CDDB
		public static bool IsSqlCe(this global::System.Data.Entity.Infrastructure.DbProviderInfo providerInfo)
		{
			return !string.IsNullOrWhiteSpace(providerInfo.ProviderInvariantName) && providerInfo.ProviderInvariantName.StartsWith("System.Data.SqlServerCe", global::System.StringComparison.OrdinalIgnoreCase);
		}
	}
}
