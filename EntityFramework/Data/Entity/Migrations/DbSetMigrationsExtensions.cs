using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.Entity.Internal.Linq;
using System.Data.Entity.ModelConfiguration.Utilities;
using System.Data.Entity.Resources;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Migrations
{
	// Token: 0x020000A1 RID: 161
	public static class DbSetMigrationsExtensions
	{
		// Token: 0x06000EB5 RID: 3765 RVA: 0x0001DEA0 File Offset: 0x0001C0A0
		public static void AddOrUpdate<TEntity>(this global::System.Data.Entity.IDbSet<TEntity> set, params TEntity[] entities) where TEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.IDbSet<TEntity>>(set, "set");
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity[]>(entities, "entities");
			global::System.Data.Entity.DbSet<TEntity> dbSet = set as global::System.Data.Entity.DbSet<TEntity>;
			if (dbSet != null)
			{
				global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> internalSet = (global::System.Data.Entity.Internal.Linq.InternalSet<TEntity>)((global::System.Data.Entity.Internal.Linq.IInternalSetAdapter)dbSet).InternalSet;
				if (internalSet != null)
				{
					dbSet.AddOrUpdate(global::System.Data.Entity.Migrations.DbSetMigrationsExtensions.GetKeyProperties<TEntity>(typeof(TEntity), internalSet), internalSet, entities);
					return;
				}
			}
			global::System.Type type = set.GetType();
			global::System.Reflection.MethodInfo declaredMethod = type.GetDeclaredMethod("AddOrUpdate", new global::System.Type[]
			{
				typeof(TEntity[])
			});
			if (declaredMethod == null)
			{
				throw global::System.Data.Entity.Resources.Error.UnableToDispatchAddOrUpdate(type);
			}
			object[] parameters = new TEntity[][]
			{
				entities
			};
			declaredMethod.Invoke(set, parameters);
		}

		// Token: 0x06000EB6 RID: 3766 RVA: 0x0001DF40 File Offset: 0x0001C140
		public static void AddOrUpdate<TEntity>(this global::System.Data.Entity.IDbSet<TEntity> set, global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>> identifierExpression, params TEntity[] entities) where TEntity : class
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Data.Entity.IDbSet<TEntity>>(set, "set");
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>>>(identifierExpression, "identifierExpression");
			global::System.Data.Entity.Utilities.Check.NotNull<TEntity[]>(entities, "entities");
			global::System.Data.Entity.DbSet<TEntity> dbSet = set as global::System.Data.Entity.DbSet<TEntity>;
			if (dbSet != null)
			{
				global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> internalSet = (global::System.Data.Entity.Internal.Linq.InternalSet<TEntity>)((global::System.Data.Entity.Internal.Linq.IInternalSetAdapter)dbSet).InternalSet;
				if (internalSet != null)
				{
					global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> simplePropertyAccessList = identifierExpression.GetSimplePropertyAccessList();
					dbSet.AddOrUpdate(simplePropertyAccessList, internalSet, entities);
					return;
				}
			}
			global::System.Type type = set.GetType();
			global::System.Reflection.MethodInfo declaredMethod = type.GetDeclaredMethod("AddOrUpdate", new global::System.Type[]
			{
				typeof(global::System.Linq.Expressions.Expression<global::System.Func<TEntity, object>>),
				typeof(TEntity[])
			});
			if (declaredMethod == null)
			{
				throw global::System.Data.Entity.Resources.Error.UnableToDispatchAddOrUpdate(type);
			}
			declaredMethod.Invoke(set, new object[]
			{
				identifierExpression,
				entities
			});
		}

		// Token: 0x06000EB7 RID: 3767 RVA: 0x0001DFF4 File Offset: 0x0001C1F4
		private static void AddOrUpdate<TEntity>(this global::System.Data.Entity.DbSet<TEntity> set, global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> identifyingProperties, global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> internalSet, params TEntity[] entities) where TEntity : class
		{
			global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> keyProperties = global::System.Data.Entity.Migrations.DbSetMigrationsExtensions.GetKeyProperties<TEntity>(typeof(TEntity), internalSet);
			global::System.Linq.Expressions.ParameterExpression parameter = global::System.Linq.Expressions.Expression.Parameter(typeof(TEntity));
			for (int i = 0; i < entities.Length; i++)
			{
				TEntity entity = entities[i];
				global::System.Linq.Expressions.Expression body = (from pi in identifyingProperties
				select global::System.Linq.Expressions.Expression.Equal(global::System.Linq.Expressions.Expression.Property(parameter, pi.Single<global::System.Reflection.PropertyInfo>()), global::System.Linq.Expressions.Expression.Constant(pi.Last<global::System.Reflection.PropertyInfo>().GetValue(entity, null), pi.Last<global::System.Reflection.PropertyInfo>().PropertyType))).Aggregate(null, delegate(global::System.Linq.Expressions.Expression current, global::System.Linq.Expressions.BinaryExpression predicate)
				{
					if (current != null)
					{
						return global::System.Linq.Expressions.Expression.AndAlso(current, predicate);
					}
					return predicate;
				});
				TEntity tentity = set.SingleOrDefault(global::System.Linq.Expressions.Expression.Lambda<global::System.Func<TEntity, bool>>(body, new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameter
				}));
				if (tentity != null)
				{
					foreach (global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath source in keyProperties)
					{
						source.Single<global::System.Reflection.PropertyInfo>().GetPropertyInfoForSet().SetValue(entity, source.Single<global::System.Reflection.PropertyInfo>().GetValue(tentity, null), null);
					}
					internalSet.InternalContext.Owner.Entry<TEntity>(tentity).CurrentValues.SetValues(entity);
				}
				else
				{
					internalSet.Add(entity);
				}
			}
		}

		// Token: 0x06000EB8 RID: 3768 RVA: 0x0001E174 File Offset: 0x0001C374
		private static global::System.Collections.Generic.IEnumerable<global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath> GetKeyProperties<TEntity>(global::System.Type entityType, global::System.Data.Entity.Internal.Linq.InternalSet<TEntity> internalSet) where TEntity : class
		{
			return from km in internalSet.InternalContext.GetEntitySetAndBaseTypeForType(typeof(TEntity)).EntitySet.ElementType.KeyMembers
			select new global::System.Data.Entity.ModelConfiguration.Utilities.PropertyPath(entityType.GetAnyProperty(km.Name));
		}
	}
}
