using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity
{
	// Token: 0x02000063 RID: 99
	public class DbSet<TEntity> : global::System.Data.Entity.Infrastructure.DbQuery<TEntity>, global::System.Data.Entity.IDbSet<TEntity>, global::System.Linq.IQueryable<TEntity>, global::System.Collections.Generic.IEnumerable<TEntity>, global::System.Collections.IEnumerable, global::System.Linq.IQueryable, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter where TEntity : class
	{
		// Token: 0x06000343 RID: 835 RVA: 0x0000ADCC File Offset: 0x00008FCC
		internal DbSet(global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> internalSet) : base(internalSet)
		{
			this._internalSet = internalSet;
		}

		// Token: 0x06000344 RID: 836 RVA: 0x0000ADDC File Offset: 0x00008FDC
		protected DbSet() : this(null)
		{
		}

		// Token: 0x06000345 RID: 837 RVA: 0x0000ADE5 File Offset: 0x00008FE5
		public virtual TEntity Find(params object[] keyValues)
		{
			return this.GetInternalSetWithCheck("Find").Find(keyValues);
		}

		// Token: 0x06000346 RID: 838 RVA: 0x0000ADF8 File Offset: 0x00008FF8
		public virtual global::System.Threading.Tasks.Task<TEntity> FindAsync(global::System.Threading.CancellationToken cancellationToken, params object[] keyValues)
		{
			return this.GetInternalSetWithCheck("FindAsync").FindAsync(cancellationToken, keyValues);
		}

		// Token: 0x06000347 RID: 839 RVA: 0x0000AE0C File Offset: 0x0000900C
		public virtual global::System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
		{
			return this.FindAsync(global::System.Threading.CancellationToken.None, keyValues);
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000348 RID: 840 RVA: 0x0000AE1A File Offset: 0x0000901A
		public virtual global::System.Collections.ObjectModel.ObservableCollection<TEntity> Local
		{
			get
			{
				return this.GetInternalSetWithCheck("Local").Local;
			}
		}

		// Token: 0x06000349 RID: 841 RVA: 0x0000AE2C File Offset: 0x0000902C
		public virtual TEntity Attach(TEntity entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			this.GetInternalSetWithCheck("Attach").Attach(entity);
			return entity;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x0000AE51 File Offset: 0x00009051
		public virtual TEntity Add(TEntity entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			this.GetInternalSetWithCheck("Add").Add(entity);
			return entity;
		}

		// Token: 0x0600034B RID: 843 RVA: 0x0000AE76 File Offset: 0x00009076
		public virtual global::System.Collections.Generic.IEnumerable<TEntity> AddRange(global::System.Collections.Generic.IEnumerable<TEntity> entities)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<TEntity>>(entities, "entities");
			this.GetInternalSetWithCheck("AddRange").AddRange(entities);
			return entities;
		}

		// Token: 0x0600034C RID: 844 RVA: 0x0000AE96 File Offset: 0x00009096
		public virtual TEntity Remove(TEntity entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity>(entity, "entity");
			this.GetInternalSetWithCheck("Remove").Remove(entity);
			return entity;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0000AEBB File Offset: 0x000090BB
		public virtual global::System.Collections.Generic.IEnumerable<TEntity> RemoveRange(global::System.Collections.Generic.IEnumerable<TEntity> entities)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.Generic.IEnumerable<TEntity>>(entities, "entities");
			this.GetInternalSetWithCheck("RemoveRange").RemoveRange(entities);
			return entities;
		}

		// Token: 0x0600034E RID: 846 RVA: 0x0000AEDB File Offset: 0x000090DB
		public virtual TEntity Create()
		{
			return this.GetInternalSetWithCheck("Create").Create();
		}

		// Token: 0x0600034F RID: 847 RVA: 0x0000AEED File Offset: 0x000090ED
		public virtual TDerivedEntity Create<TDerivedEntity>() where TDerivedEntity : class, TEntity
		{
			return (TDerivedEntity)((object)this.GetInternalSetWithCheck("Create").Create(typeof(TDerivedEntity)));
		}

		// Token: 0x06000350 RID: 848 RVA: 0x0000AF14 File Offset: 0x00009114
		public static implicit operator global::System.Data.Entity.DbSet(global::System.Data.Entity.DbSet<TEntity> entry)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.DbSet<TEntity>>(entry, "entry");
			if (entry._internalSet == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.TestDoublesCannotBeConverted);
			}
			return (global::System.Data.Entity.DbSet)entry._internalSet.InternalContext.Set(entry._internalSet.ElementType);
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000351 RID: 849 RVA: 0x0000AF60 File Offset: 0x00009160
		global::System.Data.Entity.Internal.Linq.IInternalSet global::System.Data.Entity.Internal.Linq.IInternalSetAdapter.InternalSet
		{
			get
			{
				return this._internalSet;
			}
		}

		// Token: 0x06000352 RID: 850 RVA: 0x0000AF68 File Offset: 0x00009168
		private global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> GetInternalSetWithCheck(string memberName)
		{
			if (this._internalSet == null)
			{
				throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.DbSet<>).Name));
			}
			return this._internalSet;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x0000AF9E File Offset: 0x0000919E
		public virtual global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity> SqlQuery(string sql, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			return new global::System.Data.Entity.Infrastructure.DbSqlQuery<TEntity>((this._internalSet != null) ? new global::System.Data.Entity.Internal.InternalSqlSetQuery(this._internalSet, sql, false, parameters) : null);
		}

		// Token: 0x06000354 RID: 852 RVA: 0x0000AFD6 File Offset: 0x000091D6
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000355 RID: 853 RVA: 0x0000AFDF File Offset: 0x000091DF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x0000AFE7 File Offset: 0x000091E7
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x040000C3 RID: 195
		private readonly global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> _internalSet;
	}
}
