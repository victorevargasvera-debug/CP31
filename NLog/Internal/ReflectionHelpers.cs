using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x0200011A RID: 282
	internal static class ReflectionHelpers
	{
		// Token: 0x06000D75 RID: 3445 RVA: 0x00021CA8 File Offset: 0x0001FEA8
		public static global::System.Type[] SafeGetTypes(this global::System.Reflection.Assembly assembly)
		{
			global::System.Type[] result;
			try
			{
				result = assembly.GetTypes();
			}
			catch (global::System.Reflection.ReflectionTypeLoadException ex)
			{
				global::System.Exception[] loaderExceptions = ex.LoaderExceptions;
				for (int i = 0; i < loaderExceptions.Length; i++)
				{
					global::NLog.Common.InternalLogger.Warn(loaderExceptions[i], "Type load exception.");
				}
				global::System.Collections.Generic.List<global::System.Type> list = new global::System.Collections.Generic.List<global::System.Type>();
				foreach (global::System.Type type in ex.Types)
				{
					if (type != null)
					{
						list.Add(type);
					}
				}
				result = list.ToArray();
			}
			catch (global::System.Exception ex2)
			{
				global::NLog.Common.InternalLogger.Warn(ex2, "Type load exception.");
				result = global::NLog.Internal.ArrayHelper.Empty<global::System.Type>();
			}
			return result;
		}

		// Token: 0x06000D76 RID: 3446 RVA: 0x00021D58 File Offset: 0x0001FF58
		public static bool IsStaticClass(this global::System.Type type)
		{
			return type.IsClass() && type.IsAbstract() && type.IsSealed();
		}

		// Token: 0x06000D77 RID: 3447 RVA: 0x00021D74 File Offset: 0x0001FF74
		public static global::NLog.Internal.ReflectionHelpers.LateBoundMethod CreateLateBoundMethod(global::System.Reflection.MethodInfo methodInfo)
		{
			global::System.Linq.Expressions.ParameterExpression parameterExpression = global::System.Linq.Expressions.Expression.Parameter(typeof(object), "instance");
			global::System.Linq.Expressions.ParameterExpression parameterExpression2 = global::System.Linq.Expressions.Expression.Parameter(typeof(object[]), "parameters");
			global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression> list = new global::System.Collections.Generic.List<global::System.Linq.Expressions.Expression>();
			global::System.Reflection.ParameterInfo[] parameters2 = methodInfo.GetParameters();
			for (int i = 0; i < parameters2.Length; i++)
			{
				global::System.Linq.Expressions.Expression expression = global::System.Linq.Expressions.Expression.ArrayIndex(parameterExpression2, global::System.Linq.Expressions.Expression.Constant(i));
				global::System.Type type = parameters2[i].ParameterType;
				if (type.IsByRef)
				{
					type = type.GetElementType();
				}
				global::System.Linq.Expressions.UnaryExpression item = global::System.Linq.Expressions.Expression.Convert(expression, type);
				list.Add(item);
			}
			global::System.Linq.Expressions.MethodCallExpression methodCallExpression = global::System.Linq.Expressions.Expression.Call(methodInfo.IsStatic ? null : global::System.Linq.Expressions.Expression.Convert(parameterExpression, methodInfo.DeclaringType), methodInfo, list);
			if (methodCallExpression.Type == typeof(void))
			{
				global::System.Linq.Expressions.Expression<global::System.Action<object, object[]>> expression2 = global::System.Linq.Expressions.Expression.Lambda<global::System.Action<object, object[]>>(methodCallExpression, new global::System.Linq.Expressions.ParameterExpression[]
				{
					parameterExpression,
					parameterExpression2
				});
				global::System.Action<object, object[]> execute = expression2.Compile();
				return delegate(object instance, object[] parameters)
				{
					execute(instance, parameters);
					return null;
				};
			}
			return global::System.Linq.Expressions.Expression.Lambda<global::NLog.Internal.ReflectionHelpers.LateBoundMethod>(global::System.Linq.Expressions.Expression.Convert(methodCallExpression, typeof(object)), new global::System.Linq.Expressions.ParameterExpression[]
			{
				parameterExpression,
				parameterExpression2
			}).Compile();
		}

		// Token: 0x06000D78 RID: 3448 RVA: 0x00021EA5 File Offset: 0x000200A5
		public static bool IsEnum(this global::System.Type type)
		{
			return type.IsEnum;
		}

		// Token: 0x06000D79 RID: 3449 RVA: 0x00021EAD File Offset: 0x000200AD
		public static bool IsPrimitive(this global::System.Type type)
		{
			return type.IsPrimitive;
		}

		// Token: 0x06000D7A RID: 3450 RVA: 0x00021EB5 File Offset: 0x000200B5
		public static bool IsSealed(this global::System.Type type)
		{
			return type.IsSealed;
		}

		// Token: 0x06000D7B RID: 3451 RVA: 0x00021EBD File Offset: 0x000200BD
		public static bool IsAbstract(this global::System.Type type)
		{
			return type.IsAbstract;
		}

		// Token: 0x06000D7C RID: 3452 RVA: 0x00021EC5 File Offset: 0x000200C5
		public static bool IsClass(this global::System.Type type)
		{
			return type.IsClass;
		}

		// Token: 0x06000D7D RID: 3453 RVA: 0x00021ECD File Offset: 0x000200CD
		public static bool IsGenericType(this global::System.Type type)
		{
			return type.IsGenericType;
		}

		// Token: 0x06000D7E RID: 3454 RVA: 0x00021ED5 File Offset: 0x000200D5
		public static TAttr GetCustomAttribute<TAttr>(this global::System.Type type) where TAttr : global::System.Attribute
		{
			return (TAttr)((object)global::System.Attribute.GetCustomAttribute(type, typeof(TAttr)));
		}

		// Token: 0x06000D7F RID: 3455 RVA: 0x00021EEC File Offset: 0x000200EC
		public static TAttr GetCustomAttribute<TAttr>(this global::System.Reflection.PropertyInfo info) where TAttr : global::System.Attribute
		{
			return (TAttr)((object)global::System.Attribute.GetCustomAttribute(info, typeof(TAttr)));
		}

		// Token: 0x06000D80 RID: 3456 RVA: 0x00021F03 File Offset: 0x00020103
		public static TAttr GetCustomAttribute<TAttr>(this global::System.Reflection.Assembly assembly) where TAttr : global::System.Attribute
		{
			return (TAttr)((object)global::System.Attribute.GetCustomAttribute(assembly, typeof(TAttr)));
		}

		// Token: 0x06000D81 RID: 3457 RVA: 0x00021F1A File Offset: 0x0002011A
		public static global::System.Collections.Generic.IEnumerable<TAttr> GetCustomAttributes<TAttr>(this global::System.Type type, bool inherit) where TAttr : global::System.Attribute
		{
			return (TAttr[])type.GetCustomAttributes(typeof(TAttr), inherit);
		}

		// Token: 0x06000D82 RID: 3458 RVA: 0x00021F32 File Offset: 0x00020132
		public static global::System.Reflection.Assembly GetAssembly(this global::System.Type type)
		{
			return type.Assembly;
		}

		// Token: 0x0200020F RID: 527
		// (Invoke) Token: 0x060012ED RID: 4845
		public delegate object LateBoundMethod(object target, object[] arguments);
	}
}
