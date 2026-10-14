using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000372 RID: 882
	public class AuditsClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06001AA1 RID: 6817 RVA: 0x0001C338 File Offset: 0x0001A538
		public AuditsClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x140000B2 RID: 178
		// (add) Token: 0x06001AA2 RID: 6818 RVA: 0x0001C347 File Offset: 0x0001A547
		// (remove) Token: 0x06001AA3 RID: 6819 RVA: 0x0001C35A File Offset: 0x0001A55A
		public event global::System.EventHandler<global::CefSharp.DevTools.Audits.IssueAddedEventArgs> IssueAdded
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.Audits.IssueAddedEventArgs>("Audits.issueAdded", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.Audits.IssueAddedEventArgs>("Audits.issueAdded", value);
			}
		}

		// Token: 0x06001AA4 RID: 6820 RVA: 0x0001C370 File Offset: 0x0001A570
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.Audits.GetEncodedResponseResponse> GetEncodedResponseAsync(string requestId, global::CefSharp.DevTools.Audits.GetEncodedResponseEncoding encoding, double? quality = null, bool? sizeOnly = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("requestId", requestId);
			dictionary.Add("encoding", base.EnumToString(encoding));
			if (quality != null)
			{
				dictionary.Add("quality", quality.Value);
			}
			if (sizeOnly != null)
			{
				dictionary.Add("sizeOnly", sizeOnly.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.Audits.GetEncodedResponseResponse>("Audits.getEncodedResponse", dictionary);
		}

		// Token: 0x06001AA5 RID: 6821 RVA: 0x0001C3F8 File Offset: 0x0001A5F8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Audits.disable", parameters);
		}

		// Token: 0x06001AA6 RID: 6822 RVA: 0x0001C418 File Offset: 0x0001A618
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Audits.enable", parameters);
		}

		// Token: 0x06001AA7 RID: 6823 RVA: 0x0001C438 File Offset: 0x0001A638
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> CheckContrastAsync(bool? reportAAA = null)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			if (reportAAA != null)
			{
				dictionary.Add("reportAAA", reportAAA.Value);
			}
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("Audits.checkContrast", dictionary);
		}

		// Token: 0x04000E39 RID: 3641
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
