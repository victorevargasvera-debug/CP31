using System;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000226 RID: 550
	public class DbEntityEntry
	{
		// Token: 0x06001CCE RID: 7374 RVA: 0x000516BA File Offset: 0x0004F8BA
		internal DbEntityEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry)
		{
			this._internalEntityEntry = internalEntityEntry;
		}

		// Token: 0x1700066E RID: 1646
		// (get) Token: 0x06001CCF RID: 7375 RVA: 0x000516C9 File Offset: 0x0004F8C9
		public object Entity
		{
			get
			{
				return this._internalEntityEntry.Entity;
			}
		}

		// Token: 0x1700066F RID: 1647
		// (get) Token: 0x06001CD0 RID: 7376 RVA: 0x000516D6 File Offset: 0x0004F8D6
		// (set) Token: 0x06001CD1 RID: 7377 RVA: 0x000516E3 File Offset: 0x0004F8E3
		public global::System.Data.Entity.EntityState State
		{
			get
			{
				return this._internalEntityEntry.State;
			}
			set
			{
				this._internalEntityEntry.State = value;
			}
		}

		// Token: 0x17000670 RID: 1648
		// (get) Token: 0x06001CD2 RID: 7378 RVA: 0x000516F1 File Offset: 0x0004F8F1
		public global::System.Data.Entity.Infrastructure.DbPropertyValues CurrentValues
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(this._internalEntityEntry.CurrentValues);
			}
		}

		// Token: 0x17000671 RID: 1649
		// (get) Token: 0x06001CD3 RID: 7379 RVA: 0x00051703 File Offset: 0x0004F903
		public global::System.Data.Entity.Infrastructure.DbPropertyValues OriginalValues
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(this._internalEntityEntry.OriginalValues);
			}
		}

		// Token: 0x06001CD4 RID: 7380 RVA: 0x00051718 File Offset: 0x0004F918
		public global::System.Data.Entity.Infrastructure.DbPropertyValues GetDatabaseValues()
		{
			global::System.Data.Entity.Internal.InternalPropertyValues databaseValues = this._internalEntityEntry.GetDatabaseValues();
			if (databaseValues != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(databaseValues);
			}
			return null;
		}

		// Token: 0x06001CD5 RID: 7381 RVA: 0x0005173C File Offset: 0x0004F93C
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Infrastructure.DbPropertyValues> GetDatabaseValuesAsync()
		{
			return this.GetDatabaseValuesAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001CD6 RID: 7382 RVA: 0x0005174C File Offset: 0x0004F94C
		public async global::System.Threading.Tasks.Task<global::System.Data.Entity.Infrastructure.DbPropertyValues> GetDatabaseValuesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = await this._internalEntityEntry.GetDatabaseValuesAsync(cancellationToken).WithCurrentCulture<global::System.Data.Entity.Internal.InternalPropertyValues>();
			return (internalPropertyValues == null) ? null : new global::System.Data.Entity.Infrastructure.DbPropertyValues(internalPropertyValues);
		}

		// Token: 0x06001CD7 RID: 7383 RVA: 0x00051799 File Offset: 0x0004F999
		public void Reload()
		{
			this._internalEntityEntry.Reload();
		}

		// Token: 0x06001CD8 RID: 7384 RVA: 0x000517A6 File Offset: 0x0004F9A6
		public global::System.Threading.Tasks.Task ReloadAsync()
		{
			return this._internalEntityEntry.ReloadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001CD9 RID: 7385 RVA: 0x000517B8 File Offset: 0x0004F9B8
		public global::System.Threading.Tasks.Task ReloadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalEntityEntry.ReloadAsync(cancellationToken);
		}

		// Token: 0x06001CDA RID: 7386 RVA: 0x000517C6 File Offset: 0x0004F9C6
		public global::System.Data.Entity.Infrastructure.DbReferenceEntry Reference(string navigationProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry.Create(this._internalEntityEntry.Reference(navigationProperty, null));
		}

		// Token: 0x06001CDB RID: 7387 RVA: 0x000517E6 File Offset: 0x0004F9E6
		public global::System.Data.Entity.Infrastructure.DbCollectionEntry Collection(string navigationProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbCollectionEntry.Create(this._internalEntityEntry.Collection(navigationProperty, null));
		}

		// Token: 0x06001CDC RID: 7388 RVA: 0x00051806 File Offset: 0x0004FA06
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry Property(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry.Create(this._internalEntityEntry.Property(propertyName, null, false));
		}

		// Token: 0x06001CDD RID: 7389 RVA: 0x00051827 File Offset: 0x0004FA27
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry ComplexProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(this._internalEntityEntry.Property(propertyName, null, true));
		}

		// Token: 0x06001CDE RID: 7390 RVA: 0x00051848 File Offset: 0x0004FA48
		public global::System.Data.Entity.Infrastructure.DbMemberEntry Member(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbMemberEntry.Create(this._internalEntityEntry.Member(propertyName, null));
		}

		// Token: 0x06001CDF RID: 7391 RVA: 0x00051868 File Offset: 0x0004FA68
		public global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Cast<TEntity>() where TEntity : class
		{
			if (!typeof(TEntity).IsAssignableFrom(this._internalEntityEntry.EntityType))
			{
				throw global::System.Data.Entity.Resources.Error.DbEntity_BadTypeForCast(typeof(global::System.Data.Entity.Infrastructure.DbEntityEntry).Name, typeof(TEntity).Name, this._internalEntityEntry.EntityType.Name);
			}
			return new global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>(this._internalEntityEntry);
		}

		// Token: 0x06001CE0 RID: 7392 RVA: 0x000518D0 File Offset: 0x0004FAD0
		public global::System.Data.Entity.Validation.DbEntityValidationResult GetValidationResult()
		{
			return this._internalEntityEntry.InternalContext.Owner.CallValidateEntity(this);
		}

		// Token: 0x17000672 RID: 1650
		// (get) Token: 0x06001CE1 RID: 7393 RVA: 0x000518E8 File Offset: 0x0004FAE8
		internal global::System.Data.Entity.Internal.InternalEntityEntry InternalEntry
		{
			get
			{
				return this._internalEntityEntry;
			}
		}

		// Token: 0x06001CE2 RID: 7394 RVA: 0x000518F0 File Offset: 0x0004FAF0
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return obj != null && !(obj.GetType() != typeof(global::System.Data.Entity.Infrastructure.DbEntityEntry)) && this.Equals((global::System.Data.Entity.Infrastructure.DbEntityEntry)obj);
		}

		// Token: 0x06001CE3 RID: 7395 RVA: 0x0005191A File Offset: 0x0004FB1A
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool Equals(global::System.Data.Entity.Infrastructure.DbEntityEntry other)
		{
			return this == other || (other != null && this._internalEntityEntry.Equals(other._internalEntityEntry));
		}

		// Token: 0x06001CE4 RID: 7396 RVA: 0x00051938 File Offset: 0x0004FB38
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this._internalEntityEntry.GetHashCode();
		}

		// Token: 0x06001CE5 RID: 7397 RVA: 0x00051945 File Offset: 0x0004FB45
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001CE6 RID: 7398 RVA: 0x0005194D File Offset: 0x0004FB4D
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B10 RID: 2832
		private readonly global::System.Data.Entity.Internal.InternalEntityEntry _internalEntityEntry;
	}
}
