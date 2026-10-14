using System;
using System.Collections;
using System.ComponentModel;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Internal;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity
{
	// Token: 0x02000062 RID: 98
	public abstract class DbSet : global::System.Data.Entity.Infrastructure.DbQuery, global::System.Data.Entity.Internal.Linq.IInternalSetAdapter
	{
		// Token: 0x0600032F RID: 815 RVA: 0x0000AB34 File Offset: 0x00008D34
		protected internal DbSet()
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x0000AB3C File Offset: 0x00008D3C
		public virtual object Find(params object[] keyValues)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented("Find", this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x06000331 RID: 817 RVA: 0x0000AB67 File Offset: 0x00008D67
		public virtual global::System.Threading.Tasks.Task<object> FindAsync(params object[] keyValues)
		{
			return this.FindAsync(global::System.Threading.CancellationToken.None, keyValues);
		}

		// Token: 0x06000332 RID: 818 RVA: 0x0000AB75 File Offset: 0x00008D75
		public virtual global::System.Threading.Tasks.Task<object> FindAsync(global::System.Threading.CancellationToken cancellationToken, params object[] keyValues)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented("FindAsync", this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000333 RID: 819 RVA: 0x0000ABA0 File Offset: 0x00008DA0
		public virtual global::System.Collections.IList Local
		{
			get
			{
				throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented("Local", this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
			}
		}

		// Token: 0x06000334 RID: 820 RVA: 0x0000ABCB File Offset: 0x00008DCB
		public virtual object Attach(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.GetInternalSetWithCheck("Attach").Attach(entity);
			return entity;
		}

		// Token: 0x06000335 RID: 821 RVA: 0x0000ABEB File Offset: 0x00008DEB
		public virtual object Add(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.GetInternalSetWithCheck("Add").Add(entity);
			return entity;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x0000AC0B File Offset: 0x00008E0B
		public virtual global::System.Collections.IEnumerable AddRange(global::System.Collections.IEnumerable entities)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IEnumerable>(entities, "entities");
			this.GetInternalSetWithCheck("AddRange").AddRange(entities);
			return entities;
		}

		// Token: 0x06000337 RID: 823 RVA: 0x0000AC2B File Offset: 0x00008E2B
		public virtual object Remove(object entity)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<object>(entity, "entity");
			this.GetInternalSetWithCheck("Remove").Remove(entity);
			return entity;
		}

		// Token: 0x06000338 RID: 824 RVA: 0x0000AC4B File Offset: 0x00008E4B
		public virtual global::System.Collections.IEnumerable RemoveRange(global::System.Collections.IEnumerable entities)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Collections.IEnumerable>(entities, "entities");
			this.GetInternalSetWithCheck("RemoveRange").RemoveRange(entities);
			return entities;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x0000AC6B File Offset: 0x00008E6B
		public virtual object Create()
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented("Create", this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x0600033A RID: 826 RVA: 0x0000AC96 File Offset: 0x00008E96
		public virtual object Create(global::System.Type derivedEntityType)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented("Create", this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x0600033B RID: 827 RVA: 0x0000ACC4 File Offset: 0x00008EC4
		public new global::System.Data.Entity.DbSet<TEntity> Cast<TEntity>() where TEntity : class
		{
			if (this.InternalSet == null)
			{
				throw new global::System.NotSupportedException(global::System.Data.Entity.Resources.Strings.TestDoublesCannotBeConverted);
			}
			if (typeof(TEntity) != this.InternalSet.ElementType)
			{
				throw global::System.Data.Entity.Resources.Error.DbEntity_BadTypeForCast(typeof(global::System.Data.Entity.DbSet).Name, typeof(TEntity).Name, this.InternalSet.ElementType.Name);
			}
			return (global::System.Data.Entity.DbSet<TEntity>)this.InternalSet.InternalContext.Set<TEntity>();
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600033C RID: 828 RVA: 0x0000AD49 File Offset: 0x00008F49
		global::System.Data.Entity.Internal.Linq.IInternalSet global::System.Data.Entity.Internal.Linq.IInternalSetAdapter.InternalSet
		{
			get
			{
				return this.InternalSet;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600033D RID: 829 RVA: 0x0000AD51 File Offset: 0x00008F51
		internal virtual global::System.Data.Entity.Internal.Linq.IInternalSet InternalSet
		{
			get
			{
				return null;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x0000AD54 File Offset: 0x00008F54
		internal virtual global::System.Data.Entity.Internal.Linq.IInternalSet GetInternalSetWithCheck(string memberName)
		{
			throw new global::System.NotImplementedException(global::System.Data.Entity.Resources.Strings.TestDoubleNotImplemented(memberName, this.GetType().Name, typeof(global::System.Data.Entity.DbSet).Name));
		}

		// Token: 0x0600033F RID: 831 RVA: 0x0000AD7B File Offset: 0x00008F7B
		public virtual global::System.Data.Entity.Infrastructure.DbSqlQuery SqlQuery(string sql, params object[] parameters)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(sql, "sql");
			global::System.Data.Entity.Utilities.Check.NotNull<object[]>(parameters, "parameters");
			return new global::System.Data.Entity.Infrastructure.DbSqlQuery((this.InternalSet == null) ? null : new global::System.Data.Entity.Internal.InternalSqlSetQuery(this.InternalSet, sql, false, parameters));
		}

		// Token: 0x06000340 RID: 832 RVA: 0x0000ADB3 File Offset: 0x00008FB3
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return base.Equals(obj);
		}

		// Token: 0x06000341 RID: 833 RVA: 0x0000ADBC File Offset: 0x00008FBC
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		// Token: 0x06000342 RID: 834 RVA: 0x0000ADC4 File Offset: 0x00008FC4
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}
	}
}
