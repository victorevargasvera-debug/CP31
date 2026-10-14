using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools
{
	// Token: 0x0200002B RID: 43
	public interface IDevToolsClient : global::System.IDisposable
	{
		// Token: 0x14000005 RID: 5
		// (add) Token: 0x0600021E RID: 542
		// (remove) Token: 0x0600021F RID: 543
		event global::System.EventHandler<global::CefSharp.DevTools.DevToolsEventArgs> DevToolsEvent;

		// Token: 0x14000006 RID: 6
		// (add) Token: 0x06000220 RID: 544
		// (remove) Token: 0x06000221 RID: 545
		event global::System.EventHandler<global::CefSharp.DevTools.DevToolsErrorEventArgs> DevToolsEventError;

		// Token: 0x06000222 RID: 546
		void AddEventHandler<T>(string eventName, global::System.EventHandler<T> eventHandler) where T : global::System.EventArgs;

		// Token: 0x06000223 RID: 547
		bool RemoveEventHandler<T>(string eventName, global::System.EventHandler<T> eventHandler) where T : global::System.EventArgs;

		// Token: 0x06000224 RID: 548
		global::System.Threading.Tasks.Task<T> ExecuteDevToolsMethodAsync<T>(string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null) where T : global::CefSharp.DevTools.DevToolsDomainResponseBase;
	}
}
