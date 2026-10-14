using System;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x02000065 RID: 101
	public class DropCreateDatabaseIfModelChanges<TContext> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x0600035C RID: 860 RVA: 0x0000B068 File Offset: 0x00009268
		static DropCreateDatabaseIfModelChanges()
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
		}

		// Token: 0x0600035D RID: 861 RVA: 0x0000B080 File Offset: 0x00009280
		public virtual void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
			global::System.Data.Entity.Internal.DatabaseExistenceState databaseExistenceState = new global::System.Data.Entity.Internal.DatabaseTableChecker().AnyModelTableExists(context.InternalContext);
			if (databaseExistenceState == global::System.Data.Entity.Internal.DatabaseExistenceState.Exists)
			{
				if (context.Database.CompatibleWithModel(true))
				{
					return;
				}
				context.Database.Delete();
				databaseExistenceState = global::System.Data.Entity.Internal.DatabaseExistenceState.DoesNotExist;
			}
			context.Database.Create(databaseExistenceState);
			this.Seed(context);
			context.SaveChanges();
		}

		// Token: 0x0600035E RID: 862 RVA: 0x0000B0FE File Offset: 0x000092FE
		protected virtual void Seed(TContext context)
		{
		}
	}
}
