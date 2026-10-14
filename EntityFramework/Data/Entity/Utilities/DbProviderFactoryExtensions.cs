using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Resources;
using System.Data.SqlClient;
using System.Linq;

namespace System.Data.Entity.Utilities
{
	// Token: 0x02000077 RID: 119
	internal static class DbProviderFactoryExtensions
	{
		// Token: 0x06000436 RID: 1078 RVA: 0x0000EB14 File Offset: 0x0000CD14
		public static string GetProviderInvariantName(this global::System.Data.Common.DbProviderFactory factory)
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.DataRow> dataRows = global::System.Data.Common.DbProviderFactories.GetFactoryClasses().Rows.OfType<global::System.Data.DataRow>();
			global::System.Data.DataRow dataRow = new global::System.Data.Entity.Utilities.ProviderRowFinder().FindRow(factory.GetType(), (global::System.Data.DataRow r) => global::System.Data.Common.DbProviderFactories.GetFactory(r).GetType() == factory.GetType(), dataRows);
			if (dataRow != null)
			{
				return (string)dataRow[2];
			}
			if (factory.GetType() == typeof(global::System.Data.SqlClient.SqlClientFactory))
			{
				return "System.Data.SqlClient";
			}
			throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ProviderNameNotFound(factory));
		}

		// Token: 0x06000437 RID: 1079 RVA: 0x0000EBA4 File Offset: 0x0000CDA4
		internal static global::System.Data.Entity.Core.Common.DbProviderServices GetProviderServices(this global::System.Data.Common.DbProviderFactory factory)
		{
			if (factory is global::System.Data.Entity.Core.EntityClient.EntityProviderFactory)
			{
				return global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices.Instance;
			}
			global::System.Data.Entity.Infrastructure.IProviderInvariantName service = global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(factory);
			return global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService(service.Name);
		}
	}
}
