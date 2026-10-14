using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.Internals
{
	// Token: 0x020000D8 RID: 216
	public interface IJavascriptObjectRepositoryInternal : global::CefSharp.IJavascriptObjectRepository, global::System.IDisposable
	{
		// Token: 0x0600064A RID: 1610
		global::CefSharp.Internals.TryCallMethodResult TryCallMethod(long objectId, string name, object[] parameters);

		// Token: 0x0600064B RID: 1611
		global::System.Threading.Tasks.Task<global::CefSharp.Internals.TryCallMethodResult> TryCallMethodAsync(long objectId, string name, object[] parameters);

		// Token: 0x0600064C RID: 1612
		bool TryGetProperty(long objectId, string name, out object result, out string exception);

		// Token: 0x0600064D RID: 1613
		bool TrySetProperty(long objectId, string name, object value, out string exception);

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x0600064E RID: 1614
		// (set) Token: 0x0600064F RID: 1615
		bool IsBrowserInitialized { get; set; }

		// Token: 0x06000650 RID: 1616
		global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptObject> GetObjects(global::System.Collections.Generic.List<string> names = null);

		// Token: 0x06000651 RID: 1617
		global::System.Collections.Generic.List<global::CefSharp.Internals.JavascriptObject> GetLegacyBoundObjects();

		// Token: 0x06000652 RID: 1618
		void ObjectsBound(global::System.Collections.Generic.List<global::System.Tuple<string, bool, bool>> objs);
	}
}
