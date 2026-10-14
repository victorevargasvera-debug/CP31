using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity.Infrastructure.MappingViews
{
	// Token: 0x0200026E RID: 622
	public class DbMappingView
	{
		// Token: 0x06001F7B RID: 8059 RVA: 0x00058EC2 File Offset: 0x000570C2
		public DbMappingView(string entitySql)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(entitySql, "entitySql");
			this._entitySql = entitySql;
		}

		// Token: 0x170006DC RID: 1756
		// (get) Token: 0x06001F7C RID: 8060 RVA: 0x00058EDD File Offset: 0x000570DD
		public string EntitySql
		{
			get
			{
				return this._entitySql;
			}
		}

		// Token: 0x04000B67 RID: 2919
		private readonly string _entitySql;
	}
}
