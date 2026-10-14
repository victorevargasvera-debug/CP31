using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;
using System.Data.Entity.Validation;
using System.Linq.Expressions;
using System.Threading;
using System.Threading.Tasks;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000227 RID: 551
	public class DbEntityEntry<TEntity> where TEntity : class
	{
		// Token: 0x06001CE7 RID: 7399 RVA: 0x00051955 File Offset: 0x0004FB55
		internal DbEntityEntry(global::System.Data.Entity.Internal.InternalEntityEntry internalEntityEntry)
		{
			this._internalEntityEntry = internalEntityEntry;
		}

		// Token: 0x17000673 RID: 1651
		// (get) Token: 0x06001CE8 RID: 7400 RVA: 0x00051964 File Offset: 0x0004FB64
		public TEntity Entity
		{
			get
			{
				return (TEntity)((object)this._internalEntityEntry.Entity);
			}
		}

		// Token: 0x17000674 RID: 1652
		// (get) Token: 0x06001CE9 RID: 7401 RVA: 0x00051976 File Offset: 0x0004FB76
		// (set) Token: 0x06001CEA RID: 7402 RVA: 0x00051983 File Offset: 0x0004FB83
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

		// Token: 0x17000675 RID: 1653
		// (get) Token: 0x06001CEB RID: 7403 RVA: 0x00051991 File Offset: 0x0004FB91
		public global::System.Data.Entity.Infrastructure.DbPropertyValues CurrentValues
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(this._internalEntityEntry.CurrentValues);
			}
		}

		// Token: 0x17000676 RID: 1654
		// (get) Token: 0x06001CEC RID: 7404 RVA: 0x000519A3 File Offset: 0x0004FBA3
		public global::System.Data.Entity.Infrastructure.DbPropertyValues OriginalValues
		{
			get
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(this._internalEntityEntry.OriginalValues);
			}
		}

		// Token: 0x06001CED RID: 7405 RVA: 0x000519B8 File Offset: 0x0004FBB8
		public global::System.Data.Entity.Infrastructure.DbPropertyValues GetDatabaseValues()
		{
			global::System.Data.Entity.Internal.InternalPropertyValues databaseValues = this._internalEntityEntry.GetDatabaseValues();
			if (databaseValues != null)
			{
				return new global::System.Data.Entity.Infrastructure.DbPropertyValues(databaseValues);
			}
			return null;
		}

		// Token: 0x06001CEE RID: 7406 RVA: 0x000519DC File Offset: 0x0004FBDC
		public global::System.Threading.Tasks.Task<global::System.Data.Entity.Infrastructure.DbPropertyValues> GetDatabaseValuesAsync()
		{
			return this.GetDatabaseValuesAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001CEF RID: 7407 RVA: 0x000519EC File Offset: 0x0004FBEC
		public async global::System.Threading.Tasks.Task<global::System.Data.Entity.Infrastructure.DbPropertyValues> GetDatabaseValuesAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			global::System.Data.Entity.Internal.InternalPropertyValues internalPropertyValues = await this._internalEntityEntry.GetDatabaseValuesAsync(cancellationToken).WithCurrentCulture<global::System.Data.Entity.Internal.InternalPropertyValues>();
			return (internalPropertyValues == null) ? null : new global::System.Data.Entity.Infrastructure.DbPropertyValues(internalPropertyValues);
		}

		// Token: 0x06001CF0 RID: 7408 RVA: 0x00051A39 File Offset: 0x0004FC39
		public void Reload()
		{
			this._internalEntityEntry.Reload();
		}

		// Token: 0x06001CF1 RID: 7409 RVA: 0x00051A46 File Offset: 0x0004FC46
		public global::System.Threading.Tasks.Task ReloadAsync()
		{
			return this._internalEntityEntry.ReloadAsync(global::System.Threading.CancellationToken.None);
		}

		// Token: 0x06001CF2 RID: 7410 RVA: 0x00051A58 File Offset: 0x0004FC58
		public global::System.Threading.Tasks.Task ReloadAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			return this._internalEntityEntry.ReloadAsync(cancellationToken);
		}

		// Token: 0x06001CF3 RID: 7411 RVA: 0x00051A66 File Offset: 0x0004FC66
		public global::System.Data.Entity.Infrastructure.DbReferenceEntry Reference(string navigationProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry.Create(this._internalEntityEntry.Reference(navigationProperty, null));
		}

		// Token: 0x06001CF4 RID: 7412 RVA: 0x00051A86 File Offset: 0x0004FC86
		public global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty> Reference<TProperty>(string navigationProperty) where TProperty : class
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty>.Create(this._internalEntityEntry.Reference(navigationProperty, typeof(TProperty)));
		}

		// Token: 0x06001CF5 RID: 7413 RVA: 0x00051AAF File Offset: 0x0004FCAF
		public global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty> Reference<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TProperty>> navigationProperty) where TProperty : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TProperty>>>(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbReferenceEntry<TEntity, TProperty>.Create(this._internalEntityEntry.Reference(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TEntity, TProperty>(navigationProperty, "Reference", "navigationProperty"), typeof(TProperty)));
		}

		// Token: 0x06001CF6 RID: 7414 RVA: 0x00051AE7 File Offset: 0x0004FCE7
		public global::System.Data.Entity.Infrastructure.DbCollectionEntry Collection(string navigationProperty)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbCollectionEntry.Create(this._internalEntityEntry.Collection(navigationProperty, null));
		}

		// Token: 0x06001CF7 RID: 7415 RVA: 0x00051B07 File Offset: 0x0004FD07
		public global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> Collection<TElement>(string navigationProperty) where TElement : class
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(navigationProperty, "navigationProperty");
			return global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement>.Create(this._internalEntityEntry.Collection(navigationProperty, typeof(TElement)));
		}

		// Token: 0x06001CF8 RID: 7416 RVA: 0x00051B30 File Offset: 0x0004FD30
		public global::System.Data.Entity.Infrastructure.DbCollectionEntry<TEntity, TElement> Collection<TElement>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, global::System.Collections.Generic.ICollection<TElement>>> navigationProperty) where TElement : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, global::System.Collections.Generic.ICollection<TElement>>>>(navigationProperty, "navigationProperty");
			return this.Collection<TElement>(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TEntity, global::System.Collections.Generic.ICollection<TElement>>(navigationProperty, "Collection", "navigationProperty"));
		}

		// Token: 0x06001CF9 RID: 7417 RVA: 0x00051B54 File Offset: 0x0004FD54
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry Property(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry.Create(this._internalEntityEntry.Property(propertyName, null, false));
		}

		// Token: 0x06001CFA RID: 7418 RVA: 0x00051B75 File Offset: 0x0004FD75
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty> Property<TProperty>(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty>.Create(this._internalEntityEntry.Property(propertyName, typeof(TProperty), false));
		}

		// Token: 0x06001CFB RID: 7419 RVA: 0x00051B9F File Offset: 0x0004FD9F
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TProperty> Property<TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TProperty>> property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TProperty>>>(property, "property");
			return this.Property<TProperty>(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TEntity, TProperty>(property, "Property", "property"));
		}

		// Token: 0x06001CFC RID: 7420 RVA: 0x00051BC3 File Offset: 0x0004FDC3
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry ComplexProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(this._internalEntityEntry.Property(propertyName, null, true));
		}

		// Token: 0x06001CFD RID: 7421 RVA: 0x00051BE4 File Offset: 0x0004FDE4
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty> ComplexProperty<TComplexProperty>(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty>.Create(this._internalEntityEntry.Property(propertyName, typeof(TComplexProperty), true));
		}

		// Token: 0x06001CFE RID: 7422 RVA: 0x00051C0E File Offset: 0x0004FE0E
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty> ComplexProperty<TComplexProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TComplexProperty>> property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, TComplexProperty>>>(property, "property");
			return this.ComplexProperty<TComplexProperty>(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TEntity, TComplexProperty>(property, "Property", "property"));
		}

		// Token: 0x06001CFF RID: 7423 RVA: 0x00051C32 File Offset: 0x0004FE32
		public global::System.Data.Entity.Infrastructure.DbMemberEntry Member(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbMemberEntry.Create(this._internalEntityEntry.Member(propertyName, null));
		}

		// Token: 0x06001D00 RID: 7424 RVA: 0x00051C52 File Offset: 0x0004FE52
		public global::System.Data.Entity.Infrastructure.DbMemberEntry<TEntity, TMember> Member<TMember>(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return this._internalEntityEntry.Member(propertyName, typeof(TMember)).CreateDbMemberEntry<TEntity, TMember>();
		}

		// Token: 0x06001D01 RID: 7425 RVA: 0x00051C7B File Offset: 0x0004FE7B
		public static implicit operator global::System.Data.Entity.Infrastructure.DbEntityEntry(global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> entry)
		{
			return new global::System.Data.Entity.Infrastructure.DbEntityEntry(entry._internalEntityEntry);
		}

		// Token: 0x06001D02 RID: 7426 RVA: 0x00051C88 File Offset: 0x0004FE88
		public global::System.Data.Entity.Validation.DbEntityValidationResult GetValidationResult()
		{
			return this._internalEntityEntry.InternalContext.Owner.CallValidateEntity(this);
		}

		// Token: 0x06001D03 RID: 7427 RVA: 0x00051CA5 File Offset: 0x0004FEA5
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override bool Equals(object obj)
		{
			return obj != null && !(obj.GetType() != typeof(global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>)) && this.Equals((global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity>)obj);
		}

		// Token: 0x06001D04 RID: 7428 RVA: 0x00051CCF File Offset: 0x0004FECF
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public bool Equals(global::System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> other)
		{
			return this == other || (other != null && this._internalEntityEntry.Equals(other._internalEntityEntry));
		}

		// Token: 0x06001D05 RID: 7429 RVA: 0x00051CED File Offset: 0x0004FEED
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return this._internalEntityEntry.GetHashCode();
		}

		// Token: 0x06001D06 RID: 7430 RVA: 0x00051CFA File Offset: 0x0004FEFA
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}

		// Token: 0x06001D07 RID: 7431 RVA: 0x00051D02 File Offset: 0x0004FF02
		[global::System.ComponentModel.EditorBrowsable(global::System.ComponentModel.EditorBrowsableState.Never)]
		public new global::System.Type GetType()
		{
			return base.GetType();
		}

		// Token: 0x04000B11 RID: 2833
		private readonly global::System.Data.Entity.Internal.InternalEntityEntry _internalEntityEntry;
	}
}
