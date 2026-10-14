using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Utilities;
using System.Globalization;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000214 RID: 532
	internal static class DatabaseOperations
	{
		// Token: 0x06001C25 RID: 7205 RVA: 0x0004ECC4 File Offset: 0x0004CEC4
		public static void AddTypeConstraint(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType entityType, global::System.Data.Entity.Core.Metadata.Edm.EntityType principalTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType dependentTable, bool isSplitting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder foreignKeyBuilder = new global::System.Data.Entity.Core.Metadata.Edm.ForeignKeyBuilder(database, string.Format(global::System.Globalization.CultureInfo.InvariantCulture, "{0}_TypeConstraint_From_{1}_To_{2}", new object[]
			{
				entityType.Name,
				principalTable.Name,
				dependentTable.Name
			}))
			{
				PrincipalTable = principalTable
			};
			dependentTable.AddForeignKey(foreignKeyBuilder);
			if (isSplitting)
			{
				foreignKeyBuilder.SetIsSplitConstraint();
			}
			else
			{
				foreignKeyBuilder.SetIsTypeConstraint();
			}
			foreignKeyBuilder.DependentColumns = from c in dependentTable.Properties
			where c.IsPrimaryKeyColumn
			select c;
			(from c in dependentTable.Properties
			where c.IsPrimaryKeyColumn
			select c).Each(delegate(global::System.Data.Entity.Core.Metadata.Edm.EdmProperty c)
			{
				c.RemoveStoreGeneratedIdentityPattern();
			});
		}
	}
}
