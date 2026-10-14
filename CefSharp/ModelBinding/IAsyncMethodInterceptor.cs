using System;
using System.Threading.Tasks;

namespace CefSharp.ModelBinding
{
	// Token: 0x020000BE RID: 190
	public interface IAsyncMethodInterceptor : global::CefSharp.ModelBinding.IMethodInterceptor
	{
		// Token: 0x060005B9 RID: 1465
		global::System.Threading.Tasks.Task<object> InterceptAsync(global::System.Func<object[], object> method, object[] parameters, string methodName);
	}
}
