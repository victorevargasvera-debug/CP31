using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.SchemeHandler
{
	// Token: 0x020000B5 RID: 181
	public class OwinSchemeHandlerFactory : global::CefSharp.ISchemeHandlerFactory
	{
		// Token: 0x06000589 RID: 1417 RVA: 0x00008B17 File Offset: 0x00006D17
		public OwinSchemeHandlerFactory(global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, global::System.Threading.Tasks.Task> appFunc)
		{
			this.appFunc = appFunc;
		}

		// Token: 0x0600058A RID: 1418 RVA: 0x00008B26 File Offset: 0x00006D26
		public global::CefSharp.IResourceHandler Create(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string schemeName, global::CefSharp.IRequest request)
		{
			return new global::CefSharp.SchemeHandler.OwinResourceHandler(this.appFunc);
		}

		// Token: 0x04000346 RID: 838
		private readonly global::System.Func<global::System.Collections.Generic.IDictionary<string, object>, global::System.Threading.Tasks.Task> appFunc;
	}
}
