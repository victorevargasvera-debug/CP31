using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CefSharp.DevTools.Network;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000EE RID: 238
	public class FetchClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x060007C4 RID: 1988 RVA: 0x0000A34F File Offset: 0x0000854F
		public FetchClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x14000039 RID: 57
		// (add) Token: 0x060007C5 RID: 1989 RVA: 0x0000A35E File Offset: 0x0000855E
		// (remove) Token: 0x060007C6 RID: 1990 RVA: 0x0000A371 File Offset: 0x00008571
		public event global::System.EventHandler<global::CefSharp.DevTools.Fetch.RequestPausedEventArgs> RequestPaused
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Fetch.RequestPausedEventArgs>("Fetch.requestPaused", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Fetch.RequestPausedEventArgs>("Fetch.requestPaused", value);
			}
		}

		// Token: 0x1400003A RID: 58
		// (add) Token: 0x060007C7 RID: 1991 RVA: 0x0000A385 File Offset: 0x00008585
		// (remove) Token: 0x060007C8 RID: 1992 RVA: 0x0000A398 File Offset: 0x00008598
		public event global::System.EventHandler<global::CefSharp.DevTools.Fetch.AuthRequiredEventArgs> AuthRequired
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Fetch.AuthRequiredEventArgs>("Fetch.authRequired", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Fetch.AuthRequiredEventArgs>("Fetch.authRequired", value);
			}
		}

		// Token: 0x060007C9 RID: 1993 RVA: 0x0000A3AC File Offset: 0x000085AC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.disable", parameters);
		}

		// Token: 0x060007CA RID: 1994 RVA: 0x0000A3CC File Offset: 0x000085CC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync(global::System.Collections.Generic.IList<global::CefSharp.DevTools.Fetch.RequestPattern> patterns = null, bool? handleAuthRequests = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (patterns != null)
			{
				dictionary.Add("patterns", from x in patterns
				select x.ToDictionary());
			}
			if (handleAuthRequests != null)
			{
				dictionary.Add("handleAuthRequests", handleAuthRequests.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.enable", dictionary);
		}

		// Token: 0x060007CB RID: 1995 RVA: 0x0000A444 File Offset: 0x00008644
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> FailRequestAsync(string requestId, global::CefSharp.DevTools.Network.ErrorReason errorReason)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			dictionary.Add("errorReason", base.EnumToString(errorReason));
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.failRequest", dictionary);
		}

		// Token: 0x060007CC RID: 1996 RVA: 0x0000A48C File Offset: 0x0000868C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> FulfillRequestAsync(string requestId, int responseCode, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Fetch.HeaderEntry> responseHeaders = null, byte[] binaryResponseHeaders = null, byte[] body = null, string responsePhrase = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			dictionary.Add("responseCode", responseCode);
			if (responseHeaders != null)
			{
				dictionary.Add("responseHeaders", from x in responseHeaders
				select x.ToDictionary());
			}
			if (binaryResponseHeaders != null)
			{
				dictionary.Add("binaryResponseHeaders", base.ToBase64String(binaryResponseHeaders));
			}
			if (body != null)
			{
				dictionary.Add("body", base.ToBase64String(body));
			}
			if (!string.IsNullOrEmpty(responsePhrase))
			{
				dictionary.Add("responsePhrase", responsePhrase);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.fulfillRequest", dictionary);
		}

		// Token: 0x060007CD RID: 1997 RVA: 0x0000A544 File Offset: 0x00008744
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ContinueRequestAsync(string requestId, string url = null, string method = null, byte[] postData = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Fetch.HeaderEntry> headers = null, bool? interceptResponse = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			if (!string.IsNullOrEmpty(url))
			{
				dictionary.Add("url", url);
			}
			if (!string.IsNullOrEmpty(method))
			{
				dictionary.Add("method", method);
			}
			if (postData != null)
			{
				dictionary.Add("postData", base.ToBase64String(postData));
			}
			if (headers != null)
			{
				dictionary.Add("headers", from x in headers
				select x.ToDictionary());
			}
			if (interceptResponse != null)
			{
				dictionary.Add("interceptResponse", interceptResponse.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.continueRequest", dictionary);
		}

		// Token: 0x060007CE RID: 1998 RVA: 0x0000A608 File Offset: 0x00008808
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ContinueWithAuthAsync(string requestId, global::CefSharp.DevTools.Fetch.AuthChallengeResponse authChallengeResponse)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			dictionary.Add("authChallengeResponse", authChallengeResponse.ToDictionary());
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.continueWithAuth", dictionary);
		}

		// Token: 0x060007CF RID: 1999 RVA: 0x0000A64C File Offset: 0x0000884C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ContinueResponseAsync(string requestId, int? responseCode = null, string responsePhrase = null, global::System.Collections.Generic.IList<global::CefSharp.DevTools.Fetch.HeaderEntry> responseHeaders = null, byte[] binaryResponseHeaders = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			if (responseCode != null)
			{
				dictionary.Add("responseCode", responseCode.Value);
			}
			if (!string.IsNullOrEmpty(responsePhrase))
			{
				dictionary.Add("responsePhrase", responsePhrase);
			}
			if (responseHeaders != null)
			{
				dictionary.Add("responseHeaders", from x in responseHeaders
				select x.ToDictionary());
			}
			if (binaryResponseHeaders != null)
			{
				dictionary.Add("binaryResponseHeaders", base.ToBase64String(binaryResponseHeaders));
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Fetch.continueResponse", dictionary);
		}

		// Token: 0x060007D0 RID: 2000 RVA: 0x0000A6FC File Offset: 0x000088FC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Fetch.GetResponseBodyResponse> GetResponseBodyAsync(string requestId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Fetch.GetResponseBodyResponse>("Fetch.getResponseBody", dictionary);
		}

		// Token: 0x060007D1 RID: 2001 RVA: 0x0000A72C File Offset: 0x0000892C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Fetch.TakeResponseBodyAsStreamResponse> TakeResponseBodyAsStreamAsync(string requestId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Fetch.TakeResponseBodyAsStreamResponse>("Fetch.takeResponseBodyAsStream", dictionary);
		}

		// Token: 0x0400037A RID: 890
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
