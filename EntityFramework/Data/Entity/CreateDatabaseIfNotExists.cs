using System;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;

namespace System.Data.Entity
{
	// Token: 0x02000057 RID: 87
	public class CreateDatabaseIfNotExists<TContext> : global::System.Data.Entity.IDatabaseInitializer<TContext> where TContext : global::System.Data.Entity.DbContext
	{
		// Token: 0x0600021F RID: 543 RVA: 0x0000816D File Offset: 0x0000636D
		static CreateDatabaseIfNotExists()
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(typeof(TContext));
		}

		// Token: 0x06000220 RID: 544 RVA: 0x00008184 File Offset: 0x00006384
		public virtual void InitializeDatabase(TContext context)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TContext>(context, "context");
			global::System.Data.Entity.Internal.DatabaseExistenceState databaseExistenceState = new global::System.Data.Entity.Internal.DatabaseTableChecker().AnyModelTableExists(context.InternalContext);
			if (databaseExistenceState == global::System.Data.Entity.Internal.DatabaseExistenceState.Exists)
			{
				if (!context.Database.CompatibleWithModel(false, databaseExistenceState))
				{
					throw global::System.Data.Entity.Resources.Error.DatabaseInitializationStrategy_ModelMismatch(context.GetType().Name);
				}
			}
			else
			{
				context.Database.Create(databaseExistenceState);
				this.Seed(context);
				context.SaveChanges();
			}
		}

		// Token: 0x06000221 RID: 545 RVA: 0x00008205 File Offset: 0x00006405
		protected virtual void Seed(TContext context)
		{
		}
	}
}
