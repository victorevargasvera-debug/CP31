using System;

namespace CefSharp.RenderProcess
{
	// Token: 0x020000B7 RID: 183
	public interface IRenderProcessHandler
	{
		// Token: 0x0600058F RID: 1423
		void OnContextCreated(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.RenderProcess.IV8Context context);

		// Token: 0x06000590 RID: 1424
		void OnContextReleased(global::CefSharp.IBrowser browser, global::CefSharp.IFrame frame, global::CefSharp.RenderProcess.IV8Context context);

		// Token: 0x06000591 RID: 1425
		void OnWebKitInitialized();
	}
}
