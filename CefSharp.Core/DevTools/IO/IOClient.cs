using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.IO
{
	// Token: 0x0200002F RID: 47
	public class IOClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000234 RID: 564 RVA: 0x00004FCE File Offset: 0x000031CE
		public IOClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x06000235 RID: 565 RVA: 0x00004FE0 File Offset: 0x000031E0
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CloseAsync(string handle)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("handle", handle);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("IO.close", dictionary);
		}

		// Token: 0x06000236 RID: 566 RVA: 0x00005010 File Offset: 0x00003210
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IO.ReadResponse> ReadAsync(string handle, int? offset = null, int? size = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("handle", handle);
			if (offset != null)
			{
				dictionary.Add("offset", offset.Value);
			}
			if (size != null)
			{
				dictionary.Add("size", size.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IO.ReadResponse>("IO.read", dictionary);
		}

		// Token: 0x06000237 RID: 567 RVA: 0x00005080 File Offset: 0x00003280
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.IO.ResolveBlobResponse> ResolveBlobAsync(string objectId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("objectId", objectId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.IO.ResolveBlobResponse>("IO.resolveBlob", dictionary);
		}

		// Token: 0x0400006A RID: 106
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
