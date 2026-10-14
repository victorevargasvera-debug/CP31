using System;
using System.IO;

namespace CefSharp.Callback
{
	// Token: 0x02000124 RID: 292
	public interface IDevToolsMessageObserver : global::System.IDisposable
	{
		// Token: 0x06000857 RID: 2135
		bool OnDevToolsMessage(global::CefSharp.IBrowser browser, global::System.IO.Stream message);

		// Token: 0x06000858 RID: 2136
		void OnDevToolsMethodResult(global::CefSharp.IBrowser browser, int messageId, bool success, global::System.IO.Stream result);

		// Token: 0x06000859 RID: 2137
		void OnDevToolsEvent(global::CefSharp.IBrowser browser, string method, global::System.IO.Stream parameters);

		// Token: 0x0600085A RID: 2138
		void OnDevToolsAgentAttached(global::CefSharp.IBrowser browser);

		// Token: 0x0600085B RID: 2139
		void OnDevToolsAgentDetached(global::CefSharp.IBrowser browser);
	}
}
