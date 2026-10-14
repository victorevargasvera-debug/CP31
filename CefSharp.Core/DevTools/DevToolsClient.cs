using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using CefSharp.Callback;
using CefSharp.DevTools.Accessibility;
using CefSharp.DevTools.Animation;
using CefSharp.DevTools.Audits;
using CefSharp.DevTools.BackgroundService;
using CefSharp.DevTools.Browser;
using CefSharp.DevTools.CacheStorage;
using CefSharp.DevTools.Cast;
using CefSharp.DevTools.CSS;
using CefSharp.DevTools.Database;
using CefSharp.DevTools.Debugger;
using CefSharp.DevTools.DeviceAccess;
using CefSharp.DevTools.DeviceOrientation;
using CefSharp.DevTools.DOM;
using CefSharp.DevTools.DOMDebugger;
using CefSharp.DevTools.DOMSnapshot;
using CefSharp.DevTools.DOMStorage;
using CefSharp.DevTools.Emulation;
using CefSharp.DevTools.EventBreakpoints;
using CefSharp.DevTools.FedCm;
using CefSharp.DevTools.Fetch;
using CefSharp.DevTools.HeadlessExperimental;
using CefSharp.DevTools.HeapProfiler;
using CefSharp.DevTools.IndexedDB;
using CefSharp.DevTools.Input;
using CefSharp.DevTools.Inspector;
using CefSharp.DevTools.IO;
using CefSharp.DevTools.LayerTree;
using CefSharp.DevTools.Log;
using CefSharp.DevTools.Media;
using CefSharp.DevTools.Memory;
using CefSharp.DevTools.Network;
using CefSharp.DevTools.Overlay;
using CefSharp.DevTools.Page;
using CefSharp.DevTools.Performance;
using CefSharp.DevTools.PerformanceTimeline;
using CefSharp.DevTools.Preload;
using CefSharp.DevTools.Profiler;
using CefSharp.DevTools.Runtime;
using CefSharp.DevTools.Security;
using CefSharp.DevTools.ServiceWorker;
using CefSharp.DevTools.Storage;
using CefSharp.DevTools.SystemInfo;
using CefSharp.DevTools.Target;
using CefSharp.DevTools.Tethering;
using CefSharp.DevTools.Tracing;
using CefSharp.DevTools.WebAudio;
using CefSharp.DevTools.WebAuthn;
using CefSharp.Internals;

namespace CefSharp.DevTools
{
	// Token: 0x0200001F RID: 31
	public class DevToolsClient : global::CefSharp.Callback.IDevToolsMessageObserver, global::System.IDisposable, global::CefSharp.DevTools.IDevToolsClient
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000198 RID: 408 RVA: 0x00003BB8 File Offset: 0x00001DB8
		// (remove) Token: 0x06000199 RID: 409 RVA: 0x00003BF0 File Offset: 0x00001DF0
		public event global::System.EventHandler<global::CefSharp.DevTools.DevToolsEventArgs> DevToolsEvent;

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600019A RID: 410 RVA: 0x00003C28 File Offset: 0x00001E28
		// (remove) Token: 0x0600019B RID: 411 RVA: 0x00003C60 File Offset: 0x00001E60
		public event global::System.EventHandler<global::CefSharp.DevTools.DevToolsErrorEventArgs> DevToolsEventError;

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x0600019C RID: 412 RVA: 0x00003C95 File Offset: 0x00001E95
		// (set) Token: 0x0600019D RID: 413 RVA: 0x00003C9D File Offset: 0x00001E9D
		public bool CaptureSyncContext { get; set; }

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x0600019E RID: 414 RVA: 0x00003CA6 File Offset: 0x00001EA6
		// (set) Token: 0x0600019F RID: 415 RVA: 0x00003CAE File Offset: 0x00001EAE
		public global::System.Threading.SynchronizationContext SyncContext
		{
			get
			{
				return this.syncContext;
			}
			set
			{
				this.CaptureSyncContext = false;
				this.syncContext = value;
			}
		}

		// Token: 0x060001A0 RID: 416 RVA: 0x00003CBE File Offset: 0x00001EBE
		public DevToolsClient(global::CefSharp.IBrowser browser)
		{
			this.browser = browser;
			this.CaptureSyncContext = true;
		}

		// Token: 0x060001A1 RID: 417 RVA: 0x00003CEA File Offset: 0x00001EEA
		public void SetDevToolsObserverRegistration(global::CefSharp.IRegistration devToolsRegistration)
		{
			this.devToolsRegistration = devToolsRegistration;
		}

		// Token: 0x060001A2 RID: 418 RVA: 0x00003CF4 File Offset: 0x00001EF4
		public void AddEventHandler<T>(string eventName, global::System.EventHandler<T> eventHandler) where T : global::System.EventArgs
		{
			global::CefSharp.DevTools.IEventProxy orAdd = this.eventHandlers.GetOrAdd(eventName, (string _) => new global::CefSharp.DevTools.EventProxy<T>(new global::System.Func<string, global::System.IO.Stream, T>(global::CefSharp.DevTools.DevToolsClient.DeserializeJsonEvent<T>)));
			global::CefSharp.DevTools.EventProxy<T> eventProxy = (global::CefSharp.DevTools.EventProxy<T>)orAdd;
			eventProxy.AddHandler(eventHandler);
		}

		// Token: 0x060001A3 RID: 419 RVA: 0x00003D3C File Offset: 0x00001F3C
		public bool RemoveEventHandler<T>(string eventName, global::System.EventHandler<T> eventHandler) where T : global::System.EventArgs
		{
			global::CefSharp.DevTools.IEventProxy eventProxy;
			if (this.eventHandlers.TryGetValue(eventName, out eventProxy))
			{
				global::CefSharp.DevTools.EventProxy<T> eventProxy2 = (global::CefSharp.DevTools.EventProxy<T>)eventProxy;
				if (eventProxy2.RemoveHandler(eventHandler))
				{
					global::CefSharp.DevTools.IEventProxy eventProxy3;
					return !this.eventHandlers.TryRemove(eventName, out eventProxy3);
				}
			}
			return true;
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00003D7C File Offset: 0x00001F7C
		public global::System.Threading.Tasks.Task<global::CefSharp.DevTools.DevToolsMethodResponse> ExecuteDevToolsMethodAsync(string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null)
		{
			return this.ExecuteDevToolsMethodAsync<global::CefSharp.DevTools.DevToolsMethodResponse>(method, parameters);
		}

		// Token: 0x060001A5 RID: 421 RVA: 0x00003D88 File Offset: 0x00001F88
		public global::System.Threading.Tasks.Task<T> ExecuteDevToolsMethodAsync<T>(string method, global::System.Collections.Generic.IDictionary<string, object> parameters = null) where T : global::CefSharp.DevTools.DevToolsDomainResponseBase
		{
			if (this.browser == null || this.browser.IsDisposed)
			{
				throw new global::System.ObjectDisposedException("IBrowser");
			}
			global::System.Threading.Tasks.TaskCompletionSource<T> taskCompletionSource = new global::System.Threading.Tasks.TaskCompletionSource<T>();
			global::CefSharp.DevTools.DevToolsMethodResponseContext methodResultContext = new global::CefSharp.DevTools.DevToolsMethodResponseContext(typeof(T), (object o) => taskCompletionSource.TrySetResult((T)((object)o)), new global::System.Func<global::System.Exception, bool>(taskCompletionSource.TrySetException), this.CaptureSyncContext ? global::System.Threading.SynchronizationContext.Current : this.SyncContext);
			global::CefSharp.IBrowserHost browserHost = this.browser.GetHost();
			int messageId = browserHost.GetNextDevToolsMessageId();
			if (!this.queuedCommandResults.TryAdd(messageId, methodResultContext))
			{
				throw new global::CefSharp.DevTools.DevToolsClientException(string.Format("Unable to add MessageId {0} to queuedCommandResults ConcurrentDictionary.", messageId));
			}
			if (global::CefSharp.Internals.CefThread.CurrentlyOnUiThread)
			{
				this.ExecuteDevToolsMethod(browserHost, messageId, method, parameters, methodResultContext);
			}
			else
			{
				if (!global::CefSharp.Internals.CefThread.CanExecuteOnUiThread)
				{
					this.queuedCommandResults.TryRemove(messageId, out methodResultContext);
					throw new global::CefSharp.DevTools.DevToolsClientException("Unable to invoke ExecuteDevToolsMethod on CEF UI Thread.");
				}
				global::CefSharp.Internals.CefThread.ExecuteOnUiThread(delegate()
				{
					this.ExecuteDevToolsMethod(browserHost, messageId, method, parameters, methodResultContext);
				});
			}
			return taskCompletionSource.Task;
		}

		// Token: 0x060001A6 RID: 422 RVA: 0x00003EF0 File Offset: 0x000020F0
		private void ExecuteDevToolsMethod(global::CefSharp.IBrowserHost browserHost, int messageId, string method, global::System.Collections.Generic.IDictionary<string, object> parameters, global::CefSharp.DevTools.DevToolsMethodResponseContext methodResultContext)
		{
			try
			{
				int num = browserHost.ExecuteDevToolsMethod(messageId, method, parameters);
				if (num == 0)
				{
					throw new global::CefSharp.DevTools.DevToolsClientException(string.Format("Failed to execute dev tools method {0}.", method));
				}
				if (num != messageId)
				{
					throw new global::CefSharp.DevTools.DevToolsClientException(string.Format("Generated MessageId {0} doesn't match returned Message Id {1}", num, messageId));
				}
			}
			catch (global::System.Exception exception)
			{
				global::CefSharp.DevTools.DevToolsMethodResponseContext devToolsMethodResponseContext;
				this.queuedCommandResults.TryRemove(messageId, out devToolsMethodResponseContext);
				methodResultContext.SetException(exception);
			}
		}

		// Token: 0x060001A7 RID: 423 RVA: 0x00003F68 File Offset: 0x00002168
		public void Dispose()
		{
			if (global::System.Threading.Interlocked.Increment(ref this.disposeCount) == 1)
			{
				this.DevToolsEvent = null;
				global::CefSharp.IRegistration registration = this.devToolsRegistration;
				if (registration != null)
				{
					registration.Dispose();
				}
				this.devToolsRegistration = null;
				this.browser = null;
				global::System.Collections.Generic.ICollection<global::CefSharp.DevTools.IEventProxy> values = this.eventHandlers.Values;
				this.eventHandlers.Clear();
				foreach (global::CefSharp.DevTools.IEventProxy eventProxy in values)
				{
					eventProxy.Dispose();
				}
			}
		}

		// Token: 0x060001A8 RID: 424 RVA: 0x00003FFC File Offset: 0x000021FC
		void global::CefSharp.Callback.IDevToolsMessageObserver.OnDevToolsAgentAttached(global::CefSharp.IBrowser browser)
		{
			this.devToolsAttached = true;
		}

		// Token: 0x060001A9 RID: 425 RVA: 0x00004005 File Offset: 0x00002205
		void global::CefSharp.Callback.IDevToolsMessageObserver.OnDevToolsAgentDetached(global::CefSharp.IBrowser browser)
		{
			this.devToolsAttached = false;
		}

		// Token: 0x060001AA RID: 426 RVA: 0x00004010 File Offset: 0x00002210
		void global::CefSharp.Callback.IDevToolsMessageObserver.OnDevToolsEvent(global::CefSharp.IBrowser browser, string method, global::System.IO.Stream parameters)
		{
			try
			{
				global::System.EventHandler<global::CefSharp.DevTools.DevToolsEventArgs> devToolsEvent = this.DevToolsEvent;
				if (devToolsEvent != null)
				{
					string paramsAsJsonString = global::CefSharp.DevTools.DevToolsClient.StreamToString(parameters, true);
					devToolsEvent(this, new global::CefSharp.DevTools.DevToolsEventArgs(method, paramsAsJsonString));
				}
				global::CefSharp.DevTools.IEventProxy eventProxy;
				if (this.eventHandlers.TryGetValue(method, out eventProxy))
				{
					eventProxy.Raise(this, method, parameters, this.SyncContext);
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.EventHandler<global::CefSharp.DevTools.DevToolsErrorEventArgs> devToolsEventError = this.DevToolsEventError;
				string json = "";
				if (parameters.Length > 0L)
				{
					parameters.Position = 0L;
					try
					{
						json = global::CefSharp.DevTools.DevToolsClient.StreamToString(parameters, false);
					}
					catch (global::System.Exception)
					{
					}
				}
				global::CefSharp.DevTools.DevToolsErrorEventArgs e = new global::CefSharp.DevTools.DevToolsErrorEventArgs(method, json, ex);
				if (devToolsEventError != null)
				{
					devToolsEventError(this, e);
				}
			}
		}

		// Token: 0x060001AB RID: 427 RVA: 0x000040C8 File Offset: 0x000022C8
		bool global::CefSharp.Callback.IDevToolsMessageObserver.OnDevToolsMessage(global::CefSharp.IBrowser browser, global::System.IO.Stream message)
		{
			return false;
		}

		// Token: 0x060001AC RID: 428 RVA: 0x000040CC File Offset: 0x000022CC
		void global::CefSharp.Callback.IDevToolsMessageObserver.OnDevToolsMethodResult(global::CefSharp.IBrowser browser, int messageId, bool success, global::System.IO.Stream result)
		{
			global::CefSharp.DevTools.DevToolsMethodResponseContext devToolsMethodResponseContext;
			if (this.queuedCommandResults.TryRemove(messageId, out devToolsMethodResponseContext))
			{
				if (success)
				{
					if (devToolsMethodResponseContext.Type == typeof(global::CefSharp.DevTools.DevToolsMethodResponse) || devToolsMethodResponseContext.Type == typeof(global::CefSharp.DevTools.DevToolsDomainResponseBase))
					{
						devToolsMethodResponseContext.SetResult(new global::CefSharp.DevTools.DevToolsMethodResponse
						{
							Success = success,
							MessageId = messageId,
							ResponseAsJsonString = global::CefSharp.DevTools.DevToolsClient.StreamToString(result, false)
						});
						return;
					}
					try
					{
						devToolsMethodResponseContext.SetResult(global::CefSharp.DevTools.DevToolsClient.DeserializeJson(devToolsMethodResponseContext.Type, result));
						return;
					}
					catch (global::System.Exception exception)
					{
						devToolsMethodResponseContext.SetException(exception);
						return;
					}
				}
				global::CefSharp.DevTools.DevToolsDomainErrorResponse devToolsDomainErrorResponse = global::CefSharp.DevTools.DevToolsClient.DeserializeJson<global::CefSharp.DevTools.DevToolsDomainErrorResponse>(result);
				devToolsDomainErrorResponse.MessageId = messageId;
				devToolsMethodResponseContext.SetException(new global::CefSharp.DevTools.DevToolsClientException("DevTools Client Error :" + devToolsDomainErrorResponse.Message, devToolsDomainErrorResponse));
			}
		}

		// Token: 0x060001AD RID: 429 RVA: 0x000041A4 File Offset: 0x000023A4
		private static T DeserializeJsonEvent<T>(string eventName, global::System.IO.Stream stream) where T : global::System.EventArgs
		{
			if (typeof(T) == typeof(global::System.EventArgs))
			{
				return (T)((object)global::System.EventArgs.Empty);
			}
			if (typeof(T) == typeof(global::CefSharp.DevTools.DevToolsEventArgs))
			{
				string paramsAsJsonString = global::CefSharp.DevTools.DevToolsClient.StreamToString(stream, true);
				global::CefSharp.DevTools.DevToolsEventArgs devToolsEventArgs = new global::CefSharp.DevTools.DevToolsEventArgs(eventName, paramsAsJsonString);
				return (T)((object)devToolsEventArgs);
			}
			return (T)((object)global::CefSharp.DevTools.DevToolsClient.DeserializeJson(typeof(T), stream));
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0000421E File Offset: 0x0000241E
		private static T DeserializeJson<T>(global::System.IO.Stream stream)
		{
			return (T)((object)global::CefSharp.DevTools.DevToolsClient.DeserializeJson(typeof(T), stream));
		}

		// Token: 0x060001AF RID: 431 RVA: 0x00004238 File Offset: 0x00002438
		private static object DeserializeJson(global::System.Type type, global::System.IO.Stream stream)
		{
			global::System.Runtime.Serialization.Json.DataContractJsonSerializer dataContractJsonSerializer = new global::System.Runtime.Serialization.Json.DataContractJsonSerializer(type, new global::System.Runtime.Serialization.Json.DataContractJsonSerializerSettings
			{
				UseSimpleDictionaryFormat = true
			});
			return dataContractJsonSerializer.ReadObject(stream);
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00004264 File Offset: 0x00002464
		private static string StreamToString(global::System.IO.Stream stream, bool leaveOpen = false)
		{
			string result;
			using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream, global::System.Text.Encoding.UTF8, false, 1024, leaveOpen))
			{
				result = streamReader.ReadToEnd();
			}
			return result;
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001B1 RID: 433 RVA: 0x000042A8 File Offset: 0x000024A8
		public global::CefSharp.DevTools.Accessibility.AccessibilityClient Accessibility
		{
			get
			{
				if (this._Accessibility == null)
				{
					this._Accessibility = new global::CefSharp.DevTools.Accessibility.AccessibilityClient(this);
				}
				return this._Accessibility;
			}
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x000042C4 File Offset: 0x000024C4
		public global::CefSharp.DevTools.Animation.AnimationClient Animation
		{
			get
			{
				if (this._Animation == null)
				{
					this._Animation = new global::CefSharp.DevTools.Animation.AnimationClient(this);
				}
				return this._Animation;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x000042E0 File Offset: 0x000024E0
		public global::CefSharp.DevTools.Audits.AuditsClient Audits
		{
			get
			{
				if (this._Audits == null)
				{
					this._Audits = new global::CefSharp.DevTools.Audits.AuditsClient(this);
				}
				return this._Audits;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x000042FC File Offset: 0x000024FC
		public global::CefSharp.DevTools.BackgroundService.BackgroundServiceClient BackgroundService
		{
			get
			{
				if (this._BackgroundService == null)
				{
					this._BackgroundService = new global::CefSharp.DevTools.BackgroundService.BackgroundServiceClient(this);
				}
				return this._BackgroundService;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00004318 File Offset: 0x00002518
		public global::CefSharp.DevTools.Browser.BrowserClient Browser
		{
			get
			{
				if (this._Browser == null)
				{
					this._Browser = new global::CefSharp.DevTools.Browser.BrowserClient(this);
				}
				return this._Browser;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00004334 File Offset: 0x00002534
		public global::CefSharp.DevTools.CSS.CSSClient CSS
		{
			get
			{
				if (this._CSS == null)
				{
					this._CSS = new global::CefSharp.DevTools.CSS.CSSClient(this);
				}
				return this._CSS;
			}
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001B7 RID: 439 RVA: 0x00004350 File Offset: 0x00002550
		public global::CefSharp.DevTools.CacheStorage.CacheStorageClient CacheStorage
		{
			get
			{
				if (this._CacheStorage == null)
				{
					this._CacheStorage = new global::CefSharp.DevTools.CacheStorage.CacheStorageClient(this);
				}
				return this._CacheStorage;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000436C File Offset: 0x0000256C
		public global::CefSharp.DevTools.Cast.CastClient Cast
		{
			get
			{
				if (this._Cast == null)
				{
					this._Cast = new global::CefSharp.DevTools.Cast.CastClient(this);
				}
				return this._Cast;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001B9 RID: 441 RVA: 0x00004388 File Offset: 0x00002588
		public global::CefSharp.DevTools.DOM.DOMClient DOM
		{
			get
			{
				if (this._DOM == null)
				{
					this._DOM = new global::CefSharp.DevTools.DOM.DOMClient(this);
				}
				return this._DOM;
			}
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001BA RID: 442 RVA: 0x000043A4 File Offset: 0x000025A4
		public global::CefSharp.DevTools.DOMDebugger.DOMDebuggerClient DOMDebugger
		{
			get
			{
				if (this._DOMDebugger == null)
				{
					this._DOMDebugger = new global::CefSharp.DevTools.DOMDebugger.DOMDebuggerClient(this);
				}
				return this._DOMDebugger;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x060001BB RID: 443 RVA: 0x000043C0 File Offset: 0x000025C0
		public global::CefSharp.DevTools.EventBreakpoints.EventBreakpointsClient EventBreakpoints
		{
			get
			{
				if (this._EventBreakpoints == null)
				{
					this._EventBreakpoints = new global::CefSharp.DevTools.EventBreakpoints.EventBreakpointsClient(this);
				}
				return this._EventBreakpoints;
			}
		}

		// Token: 0x1700007E RID: 126
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000043DC File Offset: 0x000025DC
		public global::CefSharp.DevTools.DOMSnapshot.DOMSnapshotClient DOMSnapshot
		{
			get
			{
				if (this._DOMSnapshot == null)
				{
					this._DOMSnapshot = new global::CefSharp.DevTools.DOMSnapshot.DOMSnapshotClient(this);
				}
				return this._DOMSnapshot;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x060001BD RID: 445 RVA: 0x000043F8 File Offset: 0x000025F8
		public global::CefSharp.DevTools.DOMStorage.DOMStorageClient DOMStorage
		{
			get
			{
				if (this._DOMStorage == null)
				{
					this._DOMStorage = new global::CefSharp.DevTools.DOMStorage.DOMStorageClient(this);
				}
				return this._DOMStorage;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00004414 File Offset: 0x00002614
		public global::CefSharp.DevTools.Database.DatabaseClient Database
		{
			get
			{
				if (this._Database == null)
				{
					this._Database = new global::CefSharp.DevTools.Database.DatabaseClient(this);
				}
				return this._Database;
			}
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x060001BF RID: 447 RVA: 0x00004430 File Offset: 0x00002630
		public global::CefSharp.DevTools.DeviceOrientation.DeviceOrientationClient DeviceOrientation
		{
			get
			{
				if (this._DeviceOrientation == null)
				{
					this._DeviceOrientation = new global::CefSharp.DevTools.DeviceOrientation.DeviceOrientationClient(this);
				}
				return this._DeviceOrientation;
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x0000444C File Offset: 0x0000264C
		public global::CefSharp.DevTools.Emulation.EmulationClient Emulation
		{
			get
			{
				if (this._Emulation == null)
				{
					this._Emulation = new global::CefSharp.DevTools.Emulation.EmulationClient(this);
				}
				return this._Emulation;
			}
		}

		// Token: 0x17000083 RID: 131
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x00004468 File Offset: 0x00002668
		public global::CefSharp.DevTools.HeadlessExperimental.HeadlessExperimentalClient HeadlessExperimental
		{
			get
			{
				if (this._HeadlessExperimental == null)
				{
					this._HeadlessExperimental = new global::CefSharp.DevTools.HeadlessExperimental.HeadlessExperimentalClient(this);
				}
				return this._HeadlessExperimental;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x00004484 File Offset: 0x00002684
		public global::CefSharp.DevTools.IO.IOClient IO
		{
			get
			{
				if (this._IO == null)
				{
					this._IO = new global::CefSharp.DevTools.IO.IOClient(this);
				}
				return this._IO;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x060001C3 RID: 451 RVA: 0x000044A0 File Offset: 0x000026A0
		public global::CefSharp.DevTools.IndexedDB.IndexedDBClient IndexedDB
		{
			get
			{
				if (this._IndexedDB == null)
				{
					this._IndexedDB = new global::CefSharp.DevTools.IndexedDB.IndexedDBClient(this);
				}
				return this._IndexedDB;
			}
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x060001C4 RID: 452 RVA: 0x000044BC File Offset: 0x000026BC
		public global::CefSharp.DevTools.Input.InputClient Input
		{
			get
			{
				if (this._Input == null)
				{
					this._Input = new global::CefSharp.DevTools.Input.InputClient(this);
				}
				return this._Input;
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x060001C5 RID: 453 RVA: 0x000044D8 File Offset: 0x000026D8
		public global::CefSharp.DevTools.Inspector.InspectorClient Inspector
		{
			get
			{
				if (this._Inspector == null)
				{
					this._Inspector = new global::CefSharp.DevTools.Inspector.InspectorClient(this);
				}
				return this._Inspector;
			}
		}

		// Token: 0x17000088 RID: 136
		// (get) Token: 0x060001C6 RID: 454 RVA: 0x000044F4 File Offset: 0x000026F4
		public global::CefSharp.DevTools.LayerTree.LayerTreeClient LayerTree
		{
			get
			{
				if (this._LayerTree == null)
				{
					this._LayerTree = new global::CefSharp.DevTools.LayerTree.LayerTreeClient(this);
				}
				return this._LayerTree;
			}
		}

		// Token: 0x17000089 RID: 137
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x00004510 File Offset: 0x00002710
		public global::CefSharp.DevTools.Log.LogClient Log
		{
			get
			{
				if (this._Log == null)
				{
					this._Log = new global::CefSharp.DevTools.Log.LogClient(this);
				}
				return this._Log;
			}
		}

		// Token: 0x1700008A RID: 138
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x0000452C File Offset: 0x0000272C
		public global::CefSharp.DevTools.Memory.MemoryClient Memory
		{
			get
			{
				if (this._Memory == null)
				{
					this._Memory = new global::CefSharp.DevTools.Memory.MemoryClient(this);
				}
				return this._Memory;
			}
		}

		// Token: 0x1700008B RID: 139
		// (get) Token: 0x060001C9 RID: 457 RVA: 0x00004548 File Offset: 0x00002748
		public global::CefSharp.DevTools.Network.NetworkClient Network
		{
			get
			{
				if (this._Network == null)
				{
					this._Network = new global::CefSharp.DevTools.Network.NetworkClient(this);
				}
				return this._Network;
			}
		}

		// Token: 0x1700008C RID: 140
		// (get) Token: 0x060001CA RID: 458 RVA: 0x00004564 File Offset: 0x00002764
		public global::CefSharp.DevTools.Overlay.OverlayClient Overlay
		{
			get
			{
				if (this._Overlay == null)
				{
					this._Overlay = new global::CefSharp.DevTools.Overlay.OverlayClient(this);
				}
				return this._Overlay;
			}
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x060001CB RID: 459 RVA: 0x00004580 File Offset: 0x00002780
		public global::CefSharp.DevTools.Page.PageClient Page
		{
			get
			{
				if (this._Page == null)
				{
					this._Page = new global::CefSharp.DevTools.Page.PageClient(this);
				}
				return this._Page;
			}
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x060001CC RID: 460 RVA: 0x0000459C File Offset: 0x0000279C
		public global::CefSharp.DevTools.Performance.PerformanceClient Performance
		{
			get
			{
				if (this._Performance == null)
				{
					this._Performance = new global::CefSharp.DevTools.Performance.PerformanceClient(this);
				}
				return this._Performance;
			}
		}

		// Token: 0x1700008F RID: 143
		// (get) Token: 0x060001CD RID: 461 RVA: 0x000045B8 File Offset: 0x000027B8
		public global::CefSharp.DevTools.PerformanceTimeline.PerformanceTimelineClient PerformanceTimeline
		{
			get
			{
				if (this._PerformanceTimeline == null)
				{
					this._PerformanceTimeline = new global::CefSharp.DevTools.PerformanceTimeline.PerformanceTimelineClient(this);
				}
				return this._PerformanceTimeline;
			}
		}

		// Token: 0x17000090 RID: 144
		// (get) Token: 0x060001CE RID: 462 RVA: 0x000045D4 File Offset: 0x000027D4
		public global::CefSharp.DevTools.Security.SecurityClient Security
		{
			get
			{
				if (this._Security == null)
				{
					this._Security = new global::CefSharp.DevTools.Security.SecurityClient(this);
				}
				return this._Security;
			}
		}

		// Token: 0x17000091 RID: 145
		// (get) Token: 0x060001CF RID: 463 RVA: 0x000045F0 File Offset: 0x000027F0
		public global::CefSharp.DevTools.ServiceWorker.ServiceWorkerClient ServiceWorker
		{
			get
			{
				if (this._ServiceWorker == null)
				{
					this._ServiceWorker = new global::CefSharp.DevTools.ServiceWorker.ServiceWorkerClient(this);
				}
				return this._ServiceWorker;
			}
		}

		// Token: 0x17000092 RID: 146
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x0000460C File Offset: 0x0000280C
		public global::CefSharp.DevTools.Storage.StorageClient Storage
		{
			get
			{
				if (this._Storage == null)
				{
					this._Storage = new global::CefSharp.DevTools.Storage.StorageClient(this);
				}
				return this._Storage;
			}
		}

		// Token: 0x17000093 RID: 147
		// (get) Token: 0x060001D1 RID: 465 RVA: 0x00004628 File Offset: 0x00002828
		public global::CefSharp.DevTools.SystemInfo.SystemInfoClient SystemInfo
		{
			get
			{
				if (this._SystemInfo == null)
				{
					this._SystemInfo = new global::CefSharp.DevTools.SystemInfo.SystemInfoClient(this);
				}
				return this._SystemInfo;
			}
		}

		// Token: 0x17000094 RID: 148
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00004644 File Offset: 0x00002844
		public global::CefSharp.DevTools.Target.TargetClient Target
		{
			get
			{
				if (this._Target == null)
				{
					this._Target = new global::CefSharp.DevTools.Target.TargetClient(this);
				}
				return this._Target;
			}
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060001D3 RID: 467 RVA: 0x00004660 File Offset: 0x00002860
		public global::CefSharp.DevTools.Tethering.TetheringClient Tethering
		{
			get
			{
				if (this._Tethering == null)
				{
					this._Tethering = new global::CefSharp.DevTools.Tethering.TetheringClient(this);
				}
				return this._Tethering;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060001D4 RID: 468 RVA: 0x0000467C File Offset: 0x0000287C
		public global::CefSharp.DevTools.Tracing.TracingClient Tracing
		{
			get
			{
				if (this._Tracing == null)
				{
					this._Tracing = new global::CefSharp.DevTools.Tracing.TracingClient(this);
				}
				return this._Tracing;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060001D5 RID: 469 RVA: 0x00004698 File Offset: 0x00002898
		public global::CefSharp.DevTools.Fetch.FetchClient Fetch
		{
			get
			{
				if (this._Fetch == null)
				{
					this._Fetch = new global::CefSharp.DevTools.Fetch.FetchClient(this);
				}
				return this._Fetch;
			}
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060001D6 RID: 470 RVA: 0x000046B4 File Offset: 0x000028B4
		public global::CefSharp.DevTools.WebAudio.WebAudioClient WebAudio
		{
			get
			{
				if (this._WebAudio == null)
				{
					this._WebAudio = new global::CefSharp.DevTools.WebAudio.WebAudioClient(this);
				}
				return this._WebAudio;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060001D7 RID: 471 RVA: 0x000046D0 File Offset: 0x000028D0
		public global::CefSharp.DevTools.WebAuthn.WebAuthnClient WebAuthn
		{
			get
			{
				if (this._WebAuthn == null)
				{
					this._WebAuthn = new global::CefSharp.DevTools.WebAuthn.WebAuthnClient(this);
				}
				return this._WebAuthn;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x000046EC File Offset: 0x000028EC
		public global::CefSharp.DevTools.Media.MediaClient Media
		{
			get
			{
				if (this._Media == null)
				{
					this._Media = new global::CefSharp.DevTools.Media.MediaClient(this);
				}
				return this._Media;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00004708 File Offset: 0x00002908
		public global::CefSharp.DevTools.DeviceAccess.DeviceAccessClient DeviceAccess
		{
			get
			{
				if (this._DeviceAccess == null)
				{
					this._DeviceAccess = new global::CefSharp.DevTools.DeviceAccess.DeviceAccessClient(this);
				}
				return this._DeviceAccess;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060001DA RID: 474 RVA: 0x00004724 File Offset: 0x00002924
		public global::CefSharp.DevTools.Preload.PreloadClient Preload
		{
			get
			{
				if (this._Preload == null)
				{
					this._Preload = new global::CefSharp.DevTools.Preload.PreloadClient(this);
				}
				return this._Preload;
			}
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060001DB RID: 475 RVA: 0x00004740 File Offset: 0x00002940
		public global::CefSharp.DevTools.FedCm.FedCmClient FedCm
		{
			get
			{
				if (this._FedCm == null)
				{
					this._FedCm = new global::CefSharp.DevTools.FedCm.FedCmClient(this);
				}
				return this._FedCm;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060001DC RID: 476 RVA: 0x0000475C File Offset: 0x0000295C
		public global::CefSharp.DevTools.Debugger.DebuggerClient Debugger
		{
			get
			{
				if (this._Debugger == null)
				{
					this._Debugger = new global::CefSharp.DevTools.Debugger.DebuggerClient(this);
				}
				return this._Debugger;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060001DD RID: 477 RVA: 0x00004778 File Offset: 0x00002978
		public global::CefSharp.DevTools.HeapProfiler.HeapProfilerClient HeapProfiler
		{
			get
			{
				if (this._HeapProfiler == null)
				{
					this._HeapProfiler = new global::CefSharp.DevTools.HeapProfiler.HeapProfilerClient(this);
				}
				return this._HeapProfiler;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060001DE RID: 478 RVA: 0x00004794 File Offset: 0x00002994
		public global::CefSharp.DevTools.Profiler.ProfilerClient Profiler
		{
			get
			{
				if (this._Profiler == null)
				{
					this._Profiler = new global::CefSharp.DevTools.Profiler.ProfilerClient(this);
				}
				return this._Profiler;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060001DF RID: 479 RVA: 0x000047B0 File Offset: 0x000029B0
		public global::CefSharp.DevTools.Runtime.RuntimeClient Runtime
		{
			get
			{
				if (this._Runtime == null)
				{
					this._Runtime = new global::CefSharp.DevTools.Runtime.RuntimeClient(this);
				}
				return this._Runtime;
			}
		}

		// Token: 0x0400001B RID: 27
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<int, global::CefSharp.DevTools.DevToolsMethodResponseContext> queuedCommandResults = new global::System.Collections.Concurrent.ConcurrentDictionary<int, global::CefSharp.DevTools.DevToolsMethodResponseContext>();

		// Token: 0x0400001C RID: 28
		private readonly global::System.Collections.Concurrent.ConcurrentDictionary<string, global::CefSharp.DevTools.IEventProxy> eventHandlers = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::CefSharp.DevTools.IEventProxy>();

		// Token: 0x0400001D RID: 29
		private global::CefSharp.IBrowser browser;

		// Token: 0x0400001E RID: 30
		private global::CefSharp.IRegistration devToolsRegistration;

		// Token: 0x0400001F RID: 31
		private bool devToolsAttached;

		// Token: 0x04000020 RID: 32
		private global::System.Threading.SynchronizationContext syncContext;

		// Token: 0x04000021 RID: 33
		private int disposeCount;

		// Token: 0x04000025 RID: 37
		private global::CefSharp.DevTools.Accessibility.AccessibilityClient _Accessibility;

		// Token: 0x04000026 RID: 38
		private global::CefSharp.DevTools.Animation.AnimationClient _Animation;

		// Token: 0x04000027 RID: 39
		private global::CefSharp.DevTools.Audits.AuditsClient _Audits;

		// Token: 0x04000028 RID: 40
		private global::CefSharp.DevTools.BackgroundService.BackgroundServiceClient _BackgroundService;

		// Token: 0x04000029 RID: 41
		private global::CefSharp.DevTools.Browser.BrowserClient _Browser;

		// Token: 0x0400002A RID: 42
		private global::CefSharp.DevTools.CSS.CSSClient _CSS;

		// Token: 0x0400002B RID: 43
		private global::CefSharp.DevTools.CacheStorage.CacheStorageClient _CacheStorage;

		// Token: 0x0400002C RID: 44
		private global::CefSharp.DevTools.Cast.CastClient _Cast;

		// Token: 0x0400002D RID: 45
		private global::CefSharp.DevTools.DOM.DOMClient _DOM;

		// Token: 0x0400002E RID: 46
		private global::CefSharp.DevTools.DOMDebugger.DOMDebuggerClient _DOMDebugger;

		// Token: 0x0400002F RID: 47
		private global::CefSharp.DevTools.EventBreakpoints.EventBreakpointsClient _EventBreakpoints;

		// Token: 0x04000030 RID: 48
		private global::CefSharp.DevTools.DOMSnapshot.DOMSnapshotClient _DOMSnapshot;

		// Token: 0x04000031 RID: 49
		private global::CefSharp.DevTools.DOMStorage.DOMStorageClient _DOMStorage;

		// Token: 0x04000032 RID: 50
		private global::CefSharp.DevTools.Database.DatabaseClient _Database;

		// Token: 0x04000033 RID: 51
		private global::CefSharp.DevTools.DeviceOrientation.DeviceOrientationClient _DeviceOrientation;

		// Token: 0x04000034 RID: 52
		private global::CefSharp.DevTools.Emulation.EmulationClient _Emulation;

		// Token: 0x04000035 RID: 53
		private global::CefSharp.DevTools.HeadlessExperimental.HeadlessExperimentalClient _HeadlessExperimental;

		// Token: 0x04000036 RID: 54
		private global::CefSharp.DevTools.IO.IOClient _IO;

		// Token: 0x04000037 RID: 55
		private global::CefSharp.DevTools.IndexedDB.IndexedDBClient _IndexedDB;

		// Token: 0x04000038 RID: 56
		private global::CefSharp.DevTools.Input.InputClient _Input;

		// Token: 0x04000039 RID: 57
		private global::CefSharp.DevTools.Inspector.InspectorClient _Inspector;

		// Token: 0x0400003A RID: 58
		private global::CefSharp.DevTools.LayerTree.LayerTreeClient _LayerTree;

		// Token: 0x0400003B RID: 59
		private global::CefSharp.DevTools.Log.LogClient _Log;

		// Token: 0x0400003C RID: 60
		private global::CefSharp.DevTools.Memory.MemoryClient _Memory;

		// Token: 0x0400003D RID: 61
		private global::CefSharp.DevTools.Network.NetworkClient _Network;

		// Token: 0x0400003E RID: 62
		private global::CefSharp.DevTools.Overlay.OverlayClient _Overlay;

		// Token: 0x0400003F RID: 63
		private global::CefSharp.DevTools.Page.PageClient _Page;

		// Token: 0x04000040 RID: 64
		private global::CefSharp.DevTools.Performance.PerformanceClient _Performance;

		// Token: 0x04000041 RID: 65
		private global::CefSharp.DevTools.PerformanceTimeline.PerformanceTimelineClient _PerformanceTimeline;

		// Token: 0x04000042 RID: 66
		private global::CefSharp.DevTools.Security.SecurityClient _Security;

		// Token: 0x04000043 RID: 67
		private global::CefSharp.DevTools.ServiceWorker.ServiceWorkerClient _ServiceWorker;

		// Token: 0x04000044 RID: 68
		private global::CefSharp.DevTools.Storage.StorageClient _Storage;

		// Token: 0x04000045 RID: 69
		private global::CefSharp.DevTools.SystemInfo.SystemInfoClient _SystemInfo;

		// Token: 0x04000046 RID: 70
		private global::CefSharp.DevTools.Target.TargetClient _Target;

		// Token: 0x04000047 RID: 71
		private global::CefSharp.DevTools.Tethering.TetheringClient _Tethering;

		// Token: 0x04000048 RID: 72
		private global::CefSharp.DevTools.Tracing.TracingClient _Tracing;

		// Token: 0x04000049 RID: 73
		private global::CefSharp.DevTools.Fetch.FetchClient _Fetch;

		// Token: 0x0400004A RID: 74
		private global::CefSharp.DevTools.WebAudio.WebAudioClient _WebAudio;

		// Token: 0x0400004B RID: 75
		private global::CefSharp.DevTools.WebAuthn.WebAuthnClient _WebAuthn;

		// Token: 0x0400004C RID: 76
		private global::CefSharp.DevTools.Media.MediaClient _Media;

		// Token: 0x0400004D RID: 77
		private global::CefSharp.DevTools.DeviceAccess.DeviceAccessClient _DeviceAccess;

		// Token: 0x0400004E RID: 78
		private global::CefSharp.DevTools.Preload.PreloadClient _Preload;

		// Token: 0x0400004F RID: 79
		private global::CefSharp.DevTools.FedCm.FedCmClient _FedCm;

		// Token: 0x04000050 RID: 80
		private global::CefSharp.DevTools.Debugger.DebuggerClient _Debugger;

		// Token: 0x04000051 RID: 81
		private global::CefSharp.DevTools.HeapProfiler.HeapProfilerClient _HeapProfiler;

		// Token: 0x04000052 RID: 82
		private global::CefSharp.DevTools.Profiler.ProfilerClient _Profiler;

		// Token: 0x04000053 RID: 83
		private global::CefSharp.DevTools.Runtime.RuntimeClient _Runtime;
	}
}
