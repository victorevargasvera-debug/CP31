using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.EntityClient;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000258 RID: 600
	internal class Net40DefaultDbProviderFactoryResolver : global::System.Data.Entity.Infrastructure.IDbProviderFactoryResolver
	{
		// Token: 0x06001ECB RID: 7883 RVA: 0x00054AE3 File Offset: 0x00052CE3
		public Net40DefaultDbProviderFactoryResolver() : this(new global::System.Data.Entity.Utilities.ProviderRowFinder())
		{
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x00054AF0 File Offset: 0x00052CF0
		public Net40DefaultDbProviderFactoryResolver(global::System.Data.Entity.Utilities.ProviderRowFinder finder)
		{
			this._finder = finder;
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x00054B2B File Offset: 0x00052D2B
		public global::System.Data.Common.DbProviderFactory ResolveProviderFactory(global::System.Data.Common.DbConnection connection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(connection, "connection");
			return this.GetProviderFactory(connection, global::System.Data.Common.DbProviderFactories.GetFactoryClasses().Rows.OfType<global::System.Data.DataRow>());
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x00054B50 File Offset: 0x00052D50
		public global::System.Data.Common.DbProviderFactory GetProviderFactory(global::System.Data.Common.DbConnection connection, global::System.Collections.Generic.IEnumerable<global::System.Data.DataRow> dataRows)
		{
			global::System.Type type = connection.GetType();
			return this._cache.GetOrAdd(type, delegate(global::System.Type t)
			{
				global::System.Data.DataRow dataRow;
				if ((dataRow = this._finder.FindRow(t, (global::System.Data.DataRow r) => global::System.Data.Entity.Infrastructure.Net40DefaultDbProviderFactoryResolver.ExactMatch(r, t), dataRows)) == null && (dataRow = this._finder.FindRow(null, (global::System.Data.DataRow r) => global::System.Data.Entity.Infrastructure.Net40DefaultDbProviderFactoryResolver.ExactMatch(r, t), dataRows)) == null)
				{
					dataRow = (this._finder.FindRow(t, (global::System.Data.DataRow r) => global::System.Data.Entity.Infrastructure.Net40DefaultDbProviderFactoryResolver.AssignableMatch(r, t), dataRows) ?? this._finder.FindRow(null, (global::System.Data.DataRow r) => global::System.Data.Entity.Infrastructure.Net40DefaultDbProviderFactoryResolver.AssignableMatch(r, t), dataRows));
				}
				global::System.Data.DataRow dataRow2 = dataRow;
				if (dataRow2 == null)
				{
					throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.ProviderNotFound(connection.ToString()));
				}
				return global::System.Data.Common.DbProviderFactories.GetFactory(dataRow2);
			});
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x00054B9C File Offset: 0x00052D9C
		private static bool ExactMatch(global::System.Data.DataRow row, global::System.Type connectionType)
		{
			return global::System.Data.Common.DbProviderFactories.GetFactory(row).CreateConnection().GetType() == connectionType;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x00054BB4 File Offset: 0x00052DB4
		private static bool AssignableMatch(global::System.Data.DataRow row, global::System.Type connectionType)
		{
			return connectionType.IsInstanceOfType(global::System.Data.Common.DbProviderFactories.GetFactory(row).CreateConnection());
		}

		// Token: 0x04000B37 RID: 2871
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Data.Common.DbProviderFactory> _cache = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Data.Common.DbProviderFactory>(new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Common.DbProviderFactory>[]
		{
			new global::System.Collections.Generic.KeyValuePair<global::System.Type, global::System.Data.Common.DbProviderFactory>(typeof(global::System.Data.Entity.Core.EntityClient.EntityConnection), global::System.Data.Entity.Core.EntityClient.EntityProviderFactory.Instance)
		});

		// Token: 0x04000B38 RID: 2872
		private readonly global::System.Data.Entity.Utilities.ProviderRowFinder _finder;
	}
}
