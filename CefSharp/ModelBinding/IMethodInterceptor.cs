using System;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000C0 RID: 192
	public interface IMethodInterceptor
	{
		// Token: 0x060005BB RID: 1467
		object Intercept(global::System.Func<object[], object> method, object[] parameters, string methodName);
	}
}
