using System;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x02000064 RID: 100
	public class DropCreateDatabaseAlways<TContext> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x06000358 RID: 856 RVA: 0x0000AFF7 File Offset: 0x000091F7
		static DropCreateDatabaseAlways()
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
		}

		// Token: 0x06000359 RID: 857 RVA: 0x0000B010 File Offset: 0x00009210
		public virtual void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
			context.Database.Delete();
			context.Database.Create(global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist);
			this.Seed(context);
			context.SaveChanges();
		}

		// Token: 0x0600035A RID: 858 RVA: 0x0000B05E File Offset: 0x0000925E
		protected virtual void Seed(TContext context)
		{
		}
	}
}
