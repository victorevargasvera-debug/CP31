using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Core.Objects;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000260 RID: 608
	public abstract class TableExistenceChecker
	{
		// Token: 0x06001EED RID: 7917
		public abstract bool AnyModelTableExistsInDatabase(global::System.Data.Entity.Core.Objects.ObjectContext context, global::System.Data.Common.DbConnection connection, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Core.Metadata.Edm.EntitySet> modelTables, string edmMetadataContextTableName);

		// Token: 0x06001EEE RID: 7918 RVA: 0x00054EF4 File Offset: 0x000530F4
		protected virtual string GetTableName(global::System.Data.Entity.Core.Metadata.Edm.EntitySet modelTable)
		{
			if (!modelTable.MetadataProperties.Contains("Table") || modelTable.MetadataProperties["Table"].Value == null)
			{
				return modelTable.Name;
			}
			return (string)modelTable.MetadataProperties["Table"].Value;
		}
	}
}
