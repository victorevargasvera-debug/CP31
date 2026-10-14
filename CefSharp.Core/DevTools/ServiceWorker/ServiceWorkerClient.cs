using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000148 RID: 328
	public class ServiceWorkerClient : global::CefSharp.DevTools.DevToolsDomainBase
	{
		// Token: 0x06000A32 RID: 2610 RVA: 0x0000CB73 File Offset: 0x0000AD73
		public ServiceWorkerClient(global::CefSharp.DevTools.IDevToolsClient client)
		{
			this._client = client;
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x06000A33 RID: 2611 RVA: 0x0000CB82 File Offset: 0x0000AD82
		// (remove) Token: 0x06000A34 RID: 2612 RVA: 0x0000CB95 File Offset: 0x0000AD95
		public event global::System.EventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerErrorReportedEventArgs> WorkerErrorReported
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerErrorReportedEventArgs>("ServiceWorker.workerErrorReported", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerErrorReportedEventArgs>("ServiceWorker.workerErrorReported", value);
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x06000A35 RID: 2613 RVA: 0x0000CBA9 File Offset: 0x0000ADA9
		// (remove) Token: 0x06000A36 RID: 2614 RVA: 0x0000CBBC File Offset: 0x0000ADBC
		public event global::System.EventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerRegistrationUpdatedEventArgs> WorkerRegistrationUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerRegistrationUpdatedEventArgs>("ServiceWorker.workerRegistrationUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerRegistrationUpdatedEventArgs>("ServiceWorker.workerRegistrationUpdated", value);
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x06000A37 RID: 2615 RVA: 0x0000CBD0 File Offset: 0x0000ADD0
		// (remove) Token: 0x06000A38 RID: 2616 RVA: 0x0000CBE3 File Offset: 0x0000ADE3
		public event global::System.EventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerVersionUpdatedEventArgs> WorkerVersionUpdated
		{
			add
			{
				this._client.AddEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerVersionUpdatedEventArgs>("ServiceWorker.workerVersionUpdated", value);
			}
			remove
			{
				this._client.RemoveEventHandler<global::CefSharp.DevTools.ServiceWorker.WorkerVersionUpdatedEventArgs>("ServiceWorker.workerVersionUpdated", value);
			}
		}

		// Token: 0x06000A39 RID: 2617 RVA: 0x0000CBF8 File Offset: 0x0000ADF8
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DeliverPushMessageAsync(string origin, string registrationId, string data)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			dictionary.Add("registrationId", registrationId);
			dictionary.Add("data", data);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.deliverPushMessage", dictionary);
		}

		// Token: 0x06000A3A RID: 2618 RVA: 0x0000CC40 File Offset: 0x0000AE40
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DisableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.disable", parameters);
		}

		// Token: 0x06000A3B RID: 2619 RVA: 0x0000CC60 File Offset: 0x0000AE60
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchSyncEventAsync(string origin, string registrationId, string tag, bool lastChance)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			dictionary.Add("registrationId", registrationId);
			dictionary.Add("tag", tag);
			dictionary.Add("lastChance", lastChance);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.dispatchSyncEvent", dictionary);
		}

		// Token: 0x06000A3C RID: 2620 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> DispatchPeriodicSyncEventAsync(string origin, string registrationId, string tag)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("origin", origin);
			dictionary.Add("registrationId", registrationId);
			dictionary.Add("tag", tag);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.dispatchPeriodicSyncEvent", dictionary);
		}

		// Token: 0x06000A3D RID: 2621 RVA: 0x0000CD04 File Offset: 0x0000AF04
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> EnableAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.enable", parameters);
		}

		// Token: 0x06000A3E RID: 2622 RVA: 0x0000CD24 File Offset: 0x0000AF24
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> InspectWorkerAsync(string versionId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("versionId", versionId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.inspectWorker", dictionary);
		}

		// Token: 0x06000A3F RID: 2623 RVA: 0x0000CD54 File Offset: 0x0000AF54
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SetForceUpdateOnPageLoadAsync(bool forceUpdateOnPageLoad)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("forceUpdateOnPageLoad", forceUpdateOnPageLoad);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.setForceUpdateOnPageLoad", dictionary);
		}

		// Token: 0x06000A40 RID: 2624 RVA: 0x0000CD8C File Offset: 0x0000AF8C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> SkipWaitingAsync(string scopeURL)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scopeURL", scopeURL);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.skipWaiting", dictionary);
		}

		// Token: 0x06000A41 RID: 2625 RVA: 0x0000CDBC File Offset: 0x0000AFBC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StartWorkerAsync(string scopeURL)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scopeURL", scopeURL);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.startWorker", dictionary);
		}

		// Token: 0x06000A42 RID: 2626 RVA: 0x0000CDEC File Offset: 0x0000AFEC
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopAllWorkersAsync()
		{
			global::System.Collections.Generic.Dictionary<string, object> parameters = null;
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.stopAllWorkers", parameters);
		}

		// Token: 0x06000A43 RID: 2627 RVA: 0x0000CE0C File Offset: 0x0000B00C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> StopWorkerAsync(string versionId)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("versionId", versionId);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.stopWorker", dictionary);
		}

		// Token: 0x06000A44 RID: 2628 RVA: 0x0000CE3C File Offset: 0x0000B03C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UnregisterAsync(string scopeURL)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scopeURL", scopeURL);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.unregister", dictionary);
		}

		// Token: 0x06000A45 RID: 2629 RVA: 0x0000CE6C File Offset: 0x0000B06C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> UpdateRegistrationAsync(string scopeURL)
		{
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			dictionary.Add("scopeURL", scopeURL);
			return this._client.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>("ServiceWorker.updateRegistration", dictionary);
		}

		// Token: 0x04000496 RID: 1174
		private global::CefSharp.DevTools.IDevToolsClient _client;
	}
}
