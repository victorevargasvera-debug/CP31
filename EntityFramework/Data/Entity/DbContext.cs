using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Infrastructure.DependencyResolution;
using System.Data.Entity.Internal;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity
{
	// Token: 0x0200005B RID: 91
	public class DbContext : global::System.IDisposable, global::System.Data.Entity.Infrastructure.IObjectContextAdapter
	{
		// Token: 0x0600027B RID: 635 RVA: 0x000091C8 File Offset: 0x000073C8
		protected DbContext()
		{
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.LazyInternalConnection(this, this.GetType().DatabaseName()), null);
		}

		// Token: 0x0600027C RID: 636 RVA: 0x000091E8 File Offset: 0x000073E8
		protected DbContext(global::System.Data.Entity.Infrastructure.DbCompiledModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbCompiledModel>(model, "model");
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.LazyInternalConnection(this, this.GetType().DatabaseName()), model);
		}

		// Token: 0x0600027D RID: 637 RVA: 0x00009214 File Offset: 0x00007414
		public DbContext(string nameOrConnectionString)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.LazyInternalConnection(this, nameOrConnectionString), null);
		}

		// Token: 0x0600027E RID: 638 RVA: 0x00009236 File Offset: 0x00007436
		public DbContext(string nameOrConnectionString, global::System.Data.Entity.Infrastructure.DbCompiledModel model)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(nameOrConnectionString, "nameOrConnectionString");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbCompiledModel>(model, "model");
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.LazyInternalConnection(this, nameOrConnectionString), model);
		}

		// Token: 0x0600027F RID: 639 RVA: 0x00009264 File Offset: 0x00007464
		public DbContext(global::System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(existingConnection, "existingConnection");
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.EagerInternalConnection(this, existingConnection, contextOwnsConnection), null);
		}

		// Token: 0x06000280 RID: 640 RVA: 0x00009287 File Offset: 0x00007487
		public DbContext(global::System.Data.Common.DbConnection existingConnection, global::System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Common.DbConnection>(existingConnection, "existingConnection");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbCompiledModel>(model, "model");
			this.InitializeLazyInternalContext(new global::System.Data.Entity.Internal.EagerInternalConnection(this, existingConnection, contextOwnsConnection), model);
		}

		// Token: 0x06000281 RID: 641 RVA: 0x000092B6 File Offset: 0x000074B6
		public DbContext(global::System.Data.Entity.Core.Objects.ObjectContext objectContext, bool dbContextOwnsObjectContext)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Core.Objects.ObjectContext>(objectContext, "objectContext");
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(this.GetType());
			this._internalContext = new global::System.Data.Entity.Internal.EagerInternalContext(this, objectContext, dbContextOwnsObjectContext);
			this.DiscoverAndInitializeSets();
		}

		// Token: 0x06000282 RID: 642 RVA: 0x000092EE File Offset: 0x000074EE
		internal virtual void InitializeLazyInternalContext(global::System.Data.Entity.Internal.IInternalConnection internalConnection, global::System.Data.Entity.Infrastructure.DbCompiledModel model = null)
		{
			global::System.Data.Entity.Infrastructure.DependencyResolution.DbConfigurationManager.Instance.EnsureLoadedForContext(this.GetType());
			this._internalContext = new global::System.Data.Entity.Internal.LazyInternalContext(this, internalConnection, model, global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Func<global::System.Data.Entity.DbContext, global::System.Data.Entity.Infrastructure.IDbModelCacheKey>>(), global::System.Data.Entity.DbConfiguration.DependencyResolver.GetService<global::System.Data.Entity.ModelConfiguration.Utilities.AttributeProvider>(), null, null);
			this.DiscoverAndInitializeSets();
		}

		// Token: 0x06000283 RID: 643 RVA: 0x0000932A File Offset: 0x0000752A
		private void DiscoverAndInitializeSets()
		{
			new global::System.Data.Entity.Internal.DbSetDiscoveryService(this).InitializeSets();
		}

		// Token: 0x06000284 RID: 644 RVA: 0x00009337 File Offset: 0x00007537
		protected virtual void OnModelCreating(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
		}

		// Token: 0x06000285 RID: 645 RVA: 0x00009339 File Offset: 0x00007539
		internal void CallOnModelCreating(global::System.Data.Entity.DbModelBuilder modelBuilder)
		{
			this.OnModelCreating(modelBuilder);
		}

		// Token: 0x170000B5 RID: 181
		// (get) Token: 0x06000286 RID: 646 RVA: 0x00009342 File Offset: 0x00007542
		public global::System.Data.Entity.Database Database
		{
			get
			{
				if (this._database == null)
				{
					this._database = new global::System.Data.Entity.Database(this.InternalContext);
				}
				return this._database;
			}
		}

		// Token: 0x06000287 RID: 647 RVA: 0x00009363 File Offset: 0x00007563
		public virtual global::System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
		{
			return (global::System.Data.Entity.DbSet<TEntity>)this.InternalContext.Set<TEntity>();
		}

		// Token: 0x06000288 RID: 648 RVA: 0x00009375 File Offset: 0x00007575
		public virtual global::System.Data.Entity.DbSet Set(global::System.Type entityType)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Type>(entityType, "entityType");
			return (global::System.Data.Entity.DbSet)this.InternalContext.Set(entityType);
		}

		// Token: 0x06000289 RID: 649 RVA: 0x00009394 File Offset: 0x00007594
		public virtual int SaveChanges()
		{
			return this.InternalContext.SaveChanges();
		}

		// Token: 0x0600028A RID: 650 RVA: 0x000093A1 File Offset: 0x000075A1
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync()
		{
			return this.SaveChangesAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x0600028B RID: 651 RVA: 0x000093AE File Offset: 0x000075AE
		public virtual global::System.Threading.Tasks.Task<int> SaveChangesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this.InternalContext.SaveChangesAsync(cancellationToken);
		}

		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x0600028C RID: 652 RVA: 0x000093BC File Offset: 0x000075BC
		global::System.Data.Entity.Core.Objects.ObjectContext global::System.Data.Entity.Infrastructure.IObjectContextAdapter.ObjectContext
		{
			get
			{
				this.InternalContext.ForceOSpaceLoadingForKnownEntityTypes();
				return this.InternalContext.ObjectContext;
			}
		}

		// Token: 0x0600028D RID: 653 RVA: 0x000093D4 File Offset: 0x000075D4
		public global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
		{
			global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbEntityValidationResult> list = new global::System.Collections.Generic.List<global::System.Data.Entity.Validation.DbEntityValidationResult>();
			foreach (global::System.Data.Entity.Infrastructure.DbEntityEntry dbEntityEntry in this.ChangeTracker.Entries())
			{
				if (dbEntityEntry.InternalEntry.EntityType != typeof(global::System.Data.Entity.Infrastructure.EdmMetadata) && this.ShouldValidateEntity(dbEntityEntry))
				{
					global::System.Data.Entity.Validation.DbEntityValidationResult dbEntityValidationResult = this.ValidateEntity(dbEntityEntry, new global::System.Collections.Generic.Dictionary<object, object>());
					if (dbEntityValidationResult != null && !dbEntityValidationResult.IsValid)
					{
						list.Add(dbEntityValidationResult);
					}
				}
			}
			return list;
		}

		// Token: 0x0600028E RID: 654 RVA: 0x0000946C File Offset: 0x0000766C
		protected virtual bool ShouldValidateEntity(global::System.Data.Entity.Infrastructure.DbEntityEntry entityEntry)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbEntityEntry>(entityEntry, "entityEntry");
			return (entityEntry.State & (global::System.Data.Entity.EntityState.Added | global::System.Data.Entity.EntityState.Modified)) > (global::System.Data.Entity.EntityState)0;
		}

		// Token: 0x0600028F RID: 655 RVA: 0x00009486 File Offset: 0x00007686
		protected virtual global::System.Data.Entity.Validation.DbEntityValidationResult ValidateEntity(global::System.Data.Entity.Infrastructure.DbEntityEntry entityEntry, global::System.Collections.Generic.IDictionary<object, object> items)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.Infrastructure.DbEntityEntry>(entityEntry, "entityEntry");
			return entityEntry.InternalEntry.GetValidationResult(items);
		}

		// Token: 0x06000290 RID: 656 RVA: 0x000094A0 File Offset: 0x000076A0
		internal virtual global::System.Data.Entity.Validation.DbEntityValidationResult CallValidateEntity(global::System.Data.Entity.Infrastructure.DbEntityEntry entityEntry)
		{
			return this.ValidateEntity(entityEntry, new global::System.Collections.Generic.Dictionary<object, object>());
		}

		// Token: 0x06000291 RID: 657 RVA: 0x000094AE File Offset: 0x000076AE
		public global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			return new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(new global::System.Data.Entity.Internal.InternalEntityEntry(this.InternalContext, entity));
		}

		// Token: 0x06000292 RID: 658 RVA: 0x000094D2 File Offset: 0x000076D2
		public global::System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			return new global::System.Data.Entity.Infrastructure.DbEntityEntry(new global::System.Data.Entity.Internal.InternalEntityEntry(this.InternalContext, entity));
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000293 RID: 659 RVA: 0x000094F1 File Offset: 0x000076F1
		public global::System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbChangeTracker(this.InternalContext);
			}
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000294 RID: 660 RVA: 0x000094FE File Offset: 0x000076FE
		public global::System.Data.Entity.Infrastructure.DbContextConfiguration Configuration
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbContextConfiguration(this.InternalContext);
			}
		}

		// Token: 0x06000295 RID: 661 RVA: 0x0000950B File Offset: 0x0000770B
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000296 RID: 662 RVA: 0x0000951A File Offset: 0x0000771A
		protected virtual void Dispose(bool disposing)
		{
			this._internalContext.Dispose();
		}

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x06000297 RID: 663 RVA: 0x00009527 File Offset: 0x00007727
		internal virtual global::System.Data.Entity.Internal.InternalContext InternalContext
		{
			get
			{
				return this._internalContext;
			}
		}

		// Token: 0x06000298 RID: 664 RVA: 0x0000952F File Offset: 0x0000772F
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06000299 RID: 665 RVA: 0x00009537 File Offset: 0x00007737
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x0600029A RID: 666 RVA: 0x00009540 File Offset: 0x00007740
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x0600029B RID: 667 RVA: 0x00009548 File Offset: 0x00007748
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040000B0 RID: 176
		private global::System.Data.Entity.Internal.InternalContext _internalContext;

		// Token: 0x040000B1 RID: 177
		private global::System.Data.Entity.Database _database;
	}
}
