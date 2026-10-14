using System;

namespace CefSharp
{
	// Token: 0x02000096 RID: 150
	public interface ISchemeHandlerFactory
	{
		// Token: 0x06000446 RID: 1094
		global::CefSharp.IResourceHandler Create(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, string schemeName, global::CefSharp.IRequest request);
	}
}
