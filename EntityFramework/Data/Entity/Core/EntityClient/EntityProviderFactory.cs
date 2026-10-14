using System;
using System.Data.Common;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.EntityClient.Internal;
using System.Security;
using System.Security.Permissions;

namespace System.Data.Entity.Core.EntityClient
{
	// Token: 0x020005E1 RID: 1505
	public sealed class EntityProviderFactory : global::System.Data.Common.DbProviderFactory, global::System.IServiceProvider
	{
		// Token: 0x060049AB RID: 18859 RVA: 0x00104699 File Offset: 0x00102899
		private EntityProviderFactory()
		{
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x001046A1 File Offset: 0x001028A1
		public override global::System.Data.Common.DbCommand CreateCommand()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityCommand();
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x001046A8 File Offset: 0x001028A8
		public override global::System.Data.Common.DbCommandBuilder CreateCommandBuilder()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x001046AF File Offset: 0x001028AF
		public override global::System.Data.Common.DbConnection CreateConnection()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityConnection();
		}

		// Token: 0x060049AF RID: 18863 RVA: 0x001046B6 File Offset: 0x001028B6
		public override global::System.Data.Common.DbConnectionStringBuilder CreateConnectionStringBuilder()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityConnectionStringBuilder();
		}

		// Token: 0x060049B0 RID: 18864 RVA: 0x001046BD File Offset: 0x001028BD
		public override global::System.Data.Common.DbDataAdapter CreateDataAdapter()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x001046C4 File Offset: 0x001028C4
		public override global::System.Data.Common.DbParameter CreateParameter()
		{
			return new global::System.Data.Entity.Core.EntityClient.EntityParameter();
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x001046CB File Offset: 0x001028CB
		public override global::System.Security.CodeAccessPermission CreatePermission(global::System.Security.Permissions.PermissionState state)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x001046D2 File Offset: 0x001028D2
		object global::System.IServiceProvider.GetService(global::System.Type serviceType)
		{
			if (!(serviceType == typeof(global::System.Data.Entity.Core.Common.DbProviderServices)))
			{
				return null;
			}
			return global::System.Data.Entity.Core.EntityClient.Internal.EntityProviderServices.Instance;
		}

		// Token: 0x04001A02 RID: 6658
		public static readonly global::System.Data.Entity.Core.EntityClient.EntityProviderFactory Instance = new global::System.Data.Entity.Core.EntityClient.EntityProviderFactory();
	}
}
