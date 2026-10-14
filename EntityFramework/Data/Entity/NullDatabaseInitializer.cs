using System;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x0200006A RID: 106
	public class NullDatabaseInitializer<TContext> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x0600036D RID: 877 RVA: 0x0000B1CE File Offset: 0x000093CE
		public virtual void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
		}
	}
}
