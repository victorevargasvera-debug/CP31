using System;
using System.Linq.Expressions;

namespace CefSharp.Internals
{
	// Token: 0x020000F0 RID: 240
	internal static class ReflectionUtils
	{
		// Token: 0x06000730 RID: 1840 RVA: 0x0000BABC File Offset: 0x00009CBC
		public static string GetMethodName<T>(global::System.Linq.Expressions.Expression<global::System.Func<T, object>> expression)
		{
			global::System.Linq.Expressions.MethodCallExpression methodCallExpression = (global::System.Linq.Expressions.MethodCallExpression)expression.Body;
			return methodCallExpression.Method.Name;
		}
	}
}
