using System;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x02000148 RID: 328
	internal class NonGenericDbQueryProvider : global::System.Data.Entity.Internal.Linq.DbQueryProvider
	{
		// Token: 0x06001576 RID: 5494 RVA: 0x0003726E File Offset: 0x0003546E
		public NonGenericDbQueryProvider(global::System.Data.Entity.Internal.InternalContext internalContext, global::System.Data.Entity.Internal.Linq.IInternalQuery internalQuery) : base(internalContext, internalQuery)
		{
		}

		// Token: 0x06001577 RID: 5495 RVA: 0x00037278 File Offset: 0x00035478
		public override global::System.Linq.IQueryable<TElement> CreateQuery<TElement>(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = base.CreateObjectQuery(expression);
			if (typeof(TElement) != ((global::System.Linq.IQueryable)objectQuery).ElementType)
			{
				return (global::System.Linq.IQueryable<TElement>)this.CreateQuery(objectQuery);
			}
			return new global::System.Data.Entity.Internal.Linq.InternalDbQuery<TElement>(new global::System.Data.Entity.Internal.Linq.InternalQuery<TElement>(base.InternalContext, objectQuery));
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x000372CE File Offset: 0x000354CE
		public override global::System.Linq.IQueryable CreateQuery(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression>(expression, "expression");
			return this.CreateQuery(base.CreateObjectQuery(expression));
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x000372EC File Offset: 0x000354EC
		private global::System.Linq.IQueryable CreateQuery(global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery)
		{
			global::System.Data.Entity.Internal.Linq.IInternalQuery internalQuery = base.CreateInternalQuery(objectQuery);
			return (global::System.Linq.IQueryable)typeof(global::System.Data.Entity.Internal.Linq.InternalDbQuery<>).MakeGenericType(new global::System.Type[]
			{
				internalQuery.ElementType
			}).GetConstructors(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public).Single<global::System.Reflection.ConstructorInfo>().Invoke(new object[]
			{
				internalQuery
			});
		}
	}
}
