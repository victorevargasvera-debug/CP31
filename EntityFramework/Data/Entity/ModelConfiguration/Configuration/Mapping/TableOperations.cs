using System;
using System.Data.Entity.Core.Metadata.Edm;

namespace System.Data.Entity.ModelConfiguration.Configuration.Mapping
{
	// Token: 0x02000211 RID: 529
	internal static class TableOperations
	{
		// Token: 0x06001C18 RID: 7192 RVA: 0x0004E72C File Offset: 0x0004C92C
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty CopyColumnAndAnyConstraints(global::System.Data.Entity.Core.Metadata.Edm.EdmModel database, global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, global::System.Func<global::System.Data.Entity.Core.Metadata.Edm.EdmProperty, bool> isCompatible, bool useExisting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty edmProperty = column;
			if (fromTable != toTable)
			{
				edmProperty = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.IncludeColumn(toTable, column, isCompatible, useExisting);
				if (!edmProperty.IsPrimaryKeyColumn)
				{
					global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.CopyAllForeignKeyConstraintsForColumn(database, fromTable, toTable, column, edmProperty);
				}
			}
			return edmProperty;
		}

		// Token: 0x06001C19 RID: 7193 RVA: 0x0004E760 File Offset: 0x0004C960
		public static global::System.Data.Entity.Core.Metadata.Edm.EdmProperty MoveColumnAndAnyConstraints(global::System.Data.Entity.Core.Metadata.Edm.EntityType fromTable, global::System.Data.Entity.Core.Metadata.Edm.EntityType toTable, global::System.Data.Entity.Core.Metadata.Edm.EdmProperty column, bool useExisting)
		{
			global::System.Data.Entity.Core.Metadata.Edm.EdmProperty result = column;
			if (fromTable != toTable)
			{
				result = global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.IncludeColumn(toTable, column, global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.GetNameMatcher(column.Name), useExisting);
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.TablePrimitiveOperations.RemoveColumn(fromTable, column);
				global::System.Data.Entity.ModelConfiguration.Configuration.Mapping.ForeignKeyPrimitiveOperations.MoveAllForeignKeyConstraintsForColumn(fromTable, toTable, column);
			}
			return result;
		}
	}
}
