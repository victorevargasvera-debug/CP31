using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Common;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Migrations.Model;
using System.Linq;

namespace System.Data.Entity.Migrations.Sql
{
	// Token: 0x020000A8 RID: 168
	public abstract class MigrationSqlGenerator
	{
		// Token: 0x170003D6 RID: 982
		// (get) Token: 0x06000EF2 RID: 3826 RVA: 0x0001EABC File Offset: 0x0001CCBC
		// (set) Token: 0x06000EF3 RID: 3827 RVA: 0x0001EAC4 File Offset: 0x0001CCC4
		protected global::System.Data.Entity.Core.Common.DbProviderManifest ProviderManifest { get; set; }

		// Token: 0x06000EF4 RID: 3828
		public abstract global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Sql.MigrationStatement> Generate(global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Migrations.Model.MigrationOperation> migrationOperations, string providerManifestToken);

		// Token: 0x06000EF5 RID: 3829 RVA: 0x0001EACD File Offset: 0x0001CCCD
		public virtual string GenerateProcedureBody(global::System.Collections.Generic.ICollection<global::System.Data.Entity.Core.Common.CommandTrees.DbModificationCommandTree> commandTrees, string rowsAffectedParameter, string providerManifestToken)
		{
			return null;
		}

		// Token: 0x06000EF6 RID: 3830 RVA: 0x0001EAD0 File Offset: 0x0001CCD0
		public virtual bool IsPermissionDeniedError(global::System.Exception exception)
		{
			return false;
		}

		// Token: 0x06000EF7 RID: 3831 RVA: 0x0001EAD4 File Offset: 0x0001CCD4
		protected virtual global::System.Data.Entity.Core.Metadata.Edm.TypeUsage BuildStoreTypeUsage(string storeTypeName, global::System.Data.Entity.Migrations.Model.PropertyModel propertyModel)
		{
			global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType primitiveType = this.ProviderManifest.GetStoreTypes().SingleOrDefault((global::System.Data.Entity.Core.Metadata.Edm.PrimitiveType p) => string.Equals(p.Name, storeTypeName, global::System.StringComparison.OrdinalIgnoreCase));
			if (primitiveType != null)
			{
				return global::System.Data.Entity.Core.Metadata.Edm.TypeUsage.Create(primitiveType, propertyModel.ToFacetValues());
			}
			return null;
		}
	}
}
