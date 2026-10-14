using System;
using System.Globalization;
using System.Linq.Expressions;
using System.Reflection;

namespace Autofac.Util
{
	// Token: 0x0200001F RID: 31
	internal static class ReflectionExtensions
	{
		// Token: 0x0600011C RID: 284 RVA: 0x00004B00 File Offset: 0x00002D00
		public static bool TryGetDeclaringProperty(this global::System.Reflection.ParameterInfo pi, out global::System.Reflection.PropertyInfo prop)
		{
			global::System.Reflection.MethodInfo methodInfo = pi.Member as global::System.Reflection.MethodInfo;
			if (methodInfo != null && methodInfo.IsSpecialName && methodInfo.Name.StartsWith("set_", global::System.StringComparison.Ordinal) && methodInfo.DeclaringType != null)
			{
				prop = methodInfo.DeclaringType.GetTypeInfo().GetDeclaredProperty(methodInfo.Name.Substring(4));
				return true;
			}
			prop = null;
			return false;
		}

		// Token: 0x0600011D RID: 285 RVA: 0x00004B70 File Offset: 0x00002D70
		public static global::System.Reflection.PropertyInfo GetProperty<TDeclaring, TProperty>(global::System.Linq.Expressions.Expression<global::System.Func<TDeclaring, TProperty>> propertyAccessor)
		{
			if (propertyAccessor == null)
			{
				throw new global::System.ArgumentNullException("propertyAccessor");
			}
			global::System.Linq.Expressions.MemberExpression memberExpression = propertyAccessor.Body as global::System.Linq.Expressions.MemberExpression;
			if (!(((memberExpression != null) ? memberExpression.Member : null) is global::System.Reflection.PropertyInfo))
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.ReflectionExtensionsResources.ExpressionNotPropertyAccessor, new object[]
				{
					propertyAccessor
				}));
			}
			return (global::System.Reflection.PropertyInfo)memberExpression.Member;
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004BD4 File Offset: 0x00002DD4
		public static global::System.Reflection.MethodInfo GetMethod<TDeclaring>(global::System.Linq.Expressions.Expression<global::System.Action<TDeclaring>> methodCallExpression)
		{
			if (methodCallExpression == null)
			{
				throw new global::System.ArgumentNullException("methodCallExpression");
			}
			global::System.Linq.Expressions.MethodCallExpression methodCallExpression2 = methodCallExpression.Body as global::System.Linq.Expressions.MethodCallExpression;
			if (methodCallExpression2 == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.ReflectionExtensionsResources.ExpressionNotMethodCall, new object[]
				{
					methodCallExpression
				}));
			}
			return methodCallExpression2.Method;
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004C24 File Offset: 0x00002E24
		public static global::System.Reflection.ConstructorInfo GetConstructor<TDeclaring>(global::System.Linq.Expressions.Expression<global::System.Func<TDeclaring>> constructorCallExpression)
		{
			if (constructorCallExpression == null)
			{
				throw new global::System.ArgumentNullException("constructorCallExpression");
			}
			global::System.Linq.Expressions.NewExpression newExpression = constructorCallExpression.Body as global::System.Linq.Expressions.NewExpression;
			if (newExpression == null)
			{
				throw new global::System.ArgumentException(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, global::Autofac.Util.ReflectionExtensionsResources.ExpressionNotConstructorCall, new object[]
				{
					constructorCallExpression
				}));
			}
			return newExpression.Constructor;
		}
	}
}
