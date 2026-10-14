using System;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.ModelConfiguration.Edm;
using System.Data.Entity.Resources;
using System.Linq;

namespace System.Data.Entity.ModelConfiguration.Conventions
{
	// Token: 0x020001A1 RID: 417
	public class ColumnOrderingConventionStrict : global::System.Data.Entity.ModelConfiguration.Conventions.ColumnOrderingConvention
	{
		// Token: 0x06001760 RID: 5984 RVA: 0x0003DAE4 File Offset: 0x0003BCE4
		protected override void ValidateColumns(global::System.Data.Entity.Core.Metadata.Edm.EntityType table, string tableName)
		{
			if ((from c in table.Properties
			select c.GetOrder() into o
			where o != null
			group o by o).Any((global::System.Linq.IGrouping<int?, int?> g) => g.Count<int?>() > 1))
			{
				throw global::System.Data.Entity.Resources.Error.DuplicateConfiguredColumnOrder(tableName);
			}
		}
	}
}
