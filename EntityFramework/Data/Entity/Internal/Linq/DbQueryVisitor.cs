using System;
using System.Collections.Concurrent;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.Utilities;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;

namespace System.Data.Entity.Internal.Linq
{
	// Token: 0x0200013D RID: 317
	internal class DbQueryVisitor : global::System.Linq.Expressions.ExpressionVisitor
	{
		// Token: 0x060014F6 RID: 5366 RVA: 0x000360FC File Offset: 0x000342FC
		protected override global::System.Linq.Expressions.Expression VisitMethodCall(global::System.Linq.Expressions.MethodCallExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.MethodCallExpression>(node, "node");
			if (typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(node.Method.DeclaringType))
			{
				global::System.Data.Entity.DbContext dbContext = null;
				global::System.Linq.Expressions.MemberExpression memberExpression = node.Object as global::System.Linq.Expressions.MemberExpression;
				if (memberExpression != null)
				{
					dbContext = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetContextFromConstantExpression(memberExpression.Expression, memberExpression.Member);
				}
				else
				{
					global::System.Linq.Expressions.ConstantExpression constantExpression = node.Object as global::System.Linq.Expressions.ConstantExpression;
					if (constantExpression != null)
					{
						dbContext = (constantExpression.Value as global::System.Data.Entity.DbContext);
					}
				}
				if (dbContext != null && !node.Method.GetCustomAttributes(false).Any<global::System.Data.Entity.DbFunctionAttribute>() && node.Method.GetParameters().Length == 0)
				{
					global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.CreateObjectQueryConstant(node.Method.Invoke(dbContext, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, null, null));
					if (expression != null)
					{
						return expression;
					}
				}
			}
			return base.VisitMethodCall(node);
		}

		// Token: 0x060014F7 RID: 5367 RVA: 0x000361BC File Offset: 0x000343BC
		protected override global::System.Linq.Expressions.Expression VisitMember(global::System.Linq.Expressions.MemberExpression node)
		{
			global::System.Data.Entity.Utilities.Check.NotNull<global::System.Linq.Expressions.MemberExpression>(node, "node");
			global::System.Reflection.PropertyInfo propertyInfo = node.Member as global::System.Reflection.PropertyInfo;
			global::System.Linq.Expressions.MemberExpression memberExpression = node.Expression as global::System.Linq.Expressions.MemberExpression;
			if (propertyInfo != null && memberExpression != null && typeof(global::System.Linq.IQueryable).IsAssignableFrom(propertyInfo.PropertyType) && typeof(global::System.Data.Entity.DbContext).IsAssignableFrom(node.Member.DeclaringType))
			{
				global::System.Data.Entity.DbContext contextFromConstantExpression = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetContextFromConstantExpression(memberExpression.Expression, memberExpression.Member);
				if (contextFromConstantExpression != null)
				{
					global::System.Linq.Expressions.Expression expression = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.CreateObjectQueryConstant(propertyInfo.GetValue(contextFromConstantExpression, global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, null, null));
					if (expression != null)
					{
						return expression;
					}
				}
			}
			return base.VisitMember(node);
		}

		// Token: 0x060014F8 RID: 5368 RVA: 0x00036260 File Offset: 0x00034460
		private static global::System.Data.Entity.DbContext GetContextFromConstantExpression(global::System.Linq.Expressions.Expression expression, global::System.Reflection.MemberInfo member)
		{
			if (expression == null)
			{
				return global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetContextFromMember(member, null);
			}
			object expressionValue = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetExpressionValue(expression);
			if (expressionValue != null)
			{
				return global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetContextFromMember(member, expressionValue);
			}
			return null;
		}

		// Token: 0x060014F9 RID: 5369 RVA: 0x0003628C File Offset: 0x0003448C
		private static object GetExpressionValue(global::System.Linq.Expressions.Expression expression)
		{
			global::System.Linq.Expressions.ConstantExpression constantExpression = expression as global::System.Linq.Expressions.ConstantExpression;
			if (constantExpression != null)
			{
				return constantExpression.Value;
			}
			global::System.Linq.Expressions.MemberExpression memberExpression = expression as global::System.Linq.Expressions.MemberExpression;
			if (memberExpression != null)
			{
				global::System.Reflection.FieldInfo fieldInfo = memberExpression.Member as global::System.Reflection.FieldInfo;
				if (fieldInfo != null)
				{
					object expressionValue = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetExpressionValue(memberExpression.Expression);
					if (expressionValue != null)
					{
						return fieldInfo.GetValue(expressionValue);
					}
				}
				global::System.Reflection.PropertyInfo propertyInfo = memberExpression.Member as global::System.Reflection.PropertyInfo;
				if (propertyInfo != null)
				{
					object expressionValue2 = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.GetExpressionValue(memberExpression.Expression);
					if (expressionValue2 != null)
					{
						return propertyInfo.GetValue(expressionValue2, null);
					}
				}
			}
			return null;
		}

		// Token: 0x060014FA RID: 5370 RVA: 0x00036314 File Offset: 0x00034514
		private static global::System.Data.Entity.DbContext GetContextFromMember(global::System.Reflection.MemberInfo member, object value)
		{
			global::System.Reflection.FieldInfo fieldInfo = member as global::System.Reflection.FieldInfo;
			if (fieldInfo != null)
			{
				return fieldInfo.GetValue(value) as global::System.Data.Entity.DbContext;
			}
			global::System.Reflection.PropertyInfo propertyInfo = member as global::System.Reflection.PropertyInfo;
			if (propertyInfo != null)
			{
				return propertyInfo.GetValue(value, null) as global::System.Data.Entity.DbContext;
			}
			return null;
		}

		// Token: 0x060014FB RID: 5371 RVA: 0x00036360 File Offset: 0x00034560
		private static global::System.Linq.Expressions.Expression CreateObjectQueryConstant(object dbQuery)
		{
			global::System.Data.Entity.Core.Objects.ObjectQuery objectQuery = global::System.Data.Entity.Internal.Linq.DbQueryVisitor.ExtractObjectQuery(dbQuery);
			if (objectQuery != null)
			{
				global::System.Type type = objectQuery.GetType().GetGenericArguments().Single<global::System.Type>();
				global::System.Func<global::System.Data.Entity.Core.Objects.ObjectQuery, object> func;
				if (!global::System.Data.Entity.Internal.Linq.DbQueryVisitor._wrapperFactories.TryGetValue(type, out func))
				{
					global::System.Reflection.MethodInfo declaredMethod = typeof(global::System.Data.Entity.Infrastructure.ReplacementDbQueryWrapper<>).MakeGenericType(new global::System.Type[]
					{
						type
					}).GetDeclaredMethod("Create", new global::System.Type[]
					{
						typeof(global::System.Data.Entity.Core.Objects.ObjectQuery)
					});
					func = (global::System.Func<global::System.Data.Entity.Core.Objects.ObjectQuery, object>)global::System.Delegate.CreateDelegate(typeof(global::System.Func<global::System.Data.Entity.Core.Objects.ObjectQuery, object>), declaredMethod);
					global::System.Data.Entity.Internal.Linq.DbQueryVisitor._wrapperFactories.TryAdd(type, func);
				}
				object obj = func(objectQuery);
				return global::System.Linq.Expressions.Expression.Property(global::System.Linq.Expressions.Expression.Constant(obj, obj.GetType()), "Query");
			}
			return null;
		}

		// Token: 0x060014FC RID: 5372 RVA: 0x00036414 File Offset: 0x00034614
		private static global::System.Data.Entity.Core.Objects.ObjectQuery ExtractObjectQuery(object dbQuery)
		{
			global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter internalQueryAdapter = dbQuery as global::System.Data.Entity.Internal.Linq.IInternalQueryAdapter;
			if (internalQueryAdapter != null)
			{
				return internalQueryAdapter.InternalQuery.ObjectQuery;
			}
			return null;
		}

		// Token: 0x040009CA RID: 2506
		private const global::System.Reflection.BindingFlags SetAccessBindingFlags = global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic;

		// Token: 0x040009CB RID: 2507
		private static readonly global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Core.Objects.ObjectQuery, object>> _wrapperFactories = new global::System.Collections.Concurrent.ConcurrentDictionary<global::System.Type, global::System.Func<global::System.Data.Entity.Core.Objects.ObjectQuery, object>>();
	}
}
