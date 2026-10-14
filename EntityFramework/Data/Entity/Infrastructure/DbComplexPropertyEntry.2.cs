using System;
using System.Data.Entity.Internal;
using System.Data.Entity.Utilities;
using System.Linq.Expressions;

namespace System.Data.Entity.Infrastructure
{
	// Token: 0x02000221 RID: 545
	public class DbComplexPropertyEntry<TEntity, TComplexProperty> : global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TComplexProperty> where TEntity : class
	{
		// Token: 0x06001C91 RID: 7313 RVA: 0x00050DE0 File Offset: 0x0004EFE0
		internal new static global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty> Create(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry)
		{
			return (global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty>)internalPropertyEntry.CreateDbMemberEntry<TEntity, TComplexProperty>();
		}

		// Token: 0x06001C92 RID: 7314 RVA: 0x00050DED File Offset: 0x0004EFED
		internal DbComplexPropertyEntry(global::System.Data.Entity.Internal.InternalPropertyEntry internalPropertyEntry) : base(internalPropertyEntry)
		{
		}

		// Token: 0x06001C93 RID: 7315 RVA: 0x00050DF6 File Offset: 0x0004EFF6
		public static implicit operator global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry(global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TComplexProperty> entry)
		{
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(entry.InternalPropertyEntry);
		}

		// Token: 0x06001C94 RID: 7316 RVA: 0x00050E03 File Offset: 0x0004F003
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry Property(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry.Create(base.InternalPropertyEntry.Property(propertyName, null, false));
		}

		// Token: 0x06001C95 RID: 7317 RVA: 0x00050E24 File Offset: 0x0004F024
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TNestedProperty> Property<TNestedProperty>(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TNestedProperty>.Create(base.InternalPropertyEntry.Property(propertyName, typeof(TNestedProperty), false));
		}

		// Token: 0x06001C96 RID: 7318 RVA: 0x00050E4E File Offset: 0x0004F04E
		public global::System.Data.Entity.Infrastructure.DbPropertyEntry<TEntity, TNestedProperty> Property<TNestedProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TComplexProperty, TNestedProperty>> property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TComplexProperty, TNestedProperty>>>(property, "property");
			return this.Property<TNestedProperty>(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TComplexProperty, TNestedProperty>(property, "Property", "property"));
		}

		// Token: 0x06001C97 RID: 7319 RVA: 0x00050E72 File Offset: 0x0004F072
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry ComplexProperty(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry.Create(base.InternalPropertyEntry.Property(propertyName, null, true));
		}

		// Token: 0x06001C98 RID: 7320 RVA: 0x00050E93 File Offset: 0x0004F093
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TNestedComplexProperty> ComplexProperty<TNestedComplexProperty>(string propertyName)
		{
			global::System.Data.Entity.Utilities.Check.NotEmpty(propertyName, "propertyName");
			return global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TNestedComplexProperty>.Create(base.InternalPropertyEntry.Property(propertyName, typeof(TNestedComplexProperty), true));
		}

		// Token: 0x06001C99 RID: 7321 RVA: 0x00050EBD File Offset: 0x0004F0BD
		public global::System.Data.Entity.Infrastructure.DbComplexPropertyEntry<TEntity, TNestedComplexProperty> ComplexProperty<TNestedComplexProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TComplexProperty, TNestedComplexProperty>> property)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TComplexProperty, TNestedComplexProperty>>>(property, "property");
			return this.ComplexProperty<TNestedComplexProperty>(global::System.Data.Entity.Internal.DbHelpers.ParsePropertySelector<TComplexProperty, TNestedComplexProperty>(property, "Property", "property"));
		}
	}
}
