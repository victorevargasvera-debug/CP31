using System;
using System.Data.Common;
using System.Data.Entity.Infrastructure;

namespace System.Data.Entity.Migrations.Utilities
{
	// Token: 0x020000A3 RID: 163
	internal class DatabaseCreator
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x0001E364 File Offset: 0x0001C564
		public DatabaseCreator(int? commandTimeout)
		{
			this._commandTimeout = commandTimeout;
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0001E374 File Offset: 0x0001C574
		public virtual bool Exists(global::System.Data.Common.DbConnection connection)
		{
			bool result;
			using (global::System.Data.Entity.Migrations.Utilities.EmptyContext emptyContext = new global::System.Data.Entity.Migrations.Utilities.EmptyContext(connection))
			{
				emptyContext.Database.CommandTimeout = this._commandTimeout;
				result = ((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)emptyContext).ObjectContext.DatabaseExists();
			}
			return result;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0001E3C4 File Offset: 0x0001C5C4
		public virtual void Create(global::System.Data.Common.DbConnection connection)
		{
			using (global::System.Data.Entity.Migrations.Utilities.EmptyContext emptyContext = new global::System.Data.Entity.Migrations.Utilities.EmptyContext(connection))
			{
				emptyContext.Database.CommandTimeout = this._commandTimeout;
				((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)emptyContext).ObjectContext.CreateDatabase();
			}
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0001E410 File Offset: 0x0001C610
		public virtual void Delete(global::System.Data.Common.DbConnection connection)
		{
			using (global::System.Data.Entity.Migrations.Utilities.EmptyContext emptyContext = new global::System.Data.Entity.Migrations.Utilities.EmptyContext(connection))
			{
				emptyContext.Database.CommandTimeout = this._commandTimeout;
				((global::System.Data.Entity.Infrastructure.IObjectContextAdapter)emptyContext).ObjectContext.DeleteDatabase();
			}
		}

		// Token: 0x04000833 RID: 2099
		private readonly int? _commandTimeout;
	}
}
