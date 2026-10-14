using System;
using System.ComponentModel;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace NLog.LogReceiverService
{
	// Token: 0x02000094 RID: 148
	public sealed class WcfLogReceiverClient : global::NLog.LogReceiverService.IWcfLogReceiverClient, global::System.ServiceModel.ICommunicationObject
	{
		// Token: 0x17000185 RID: 389
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00017F6E File Offset: 0x0001616E
		// (set) Token: 0x06000927 RID: 2343 RVA: 0x00017F76 File Offset: 0x00016176
		public global::NLog.LogReceiverService.IWcfLogReceiverClient ProxiedClient { get; private set; }

		// Token: 0x17000186 RID: 390
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00017F7F File Offset: 0x0001617F
		// (set) Token: 0x06000929 RID: 2345 RVA: 0x00017F87 File Offset: 0x00016187
		public bool UseOneWay { get; private set; }

		// Token: 0x0600092A RID: 2346 RVA: 0x00017F90 File Offset: 0x00016190
		public WcfLogReceiverClient(bool useOneWay)
		{
			this.UseOneWay = useOneWay;
			global::NLog.LogReceiverService.IWcfLogReceiverClient proxiedClient;
			if (!useOneWay)
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverTwoWayClient();
				proxiedClient = wcfLogReceiverClient;
			}
			else
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverOneWayClient();
				proxiedClient = wcfLogReceiverClient;
			}
			this.ProxiedClient = proxiedClient;
		}

		// Token: 0x0600092B RID: 2347 RVA: 0x00017FC4 File Offset: 0x000161C4
		public WcfLogReceiverClient(bool useOneWay, string endpointConfigurationName)
		{
			this.UseOneWay = useOneWay;
			global::NLog.LogReceiverService.IWcfLogReceiverClient proxiedClient;
			if (!useOneWay)
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverTwoWayClient(endpointConfigurationName);
				proxiedClient = wcfLogReceiverClient;
			}
			else
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverOneWayClient(endpointConfigurationName);
				proxiedClient = wcfLogReceiverClient;
			}
			this.ProxiedClient = proxiedClient;
		}

		// Token: 0x0600092C RID: 2348 RVA: 0x00017FFC File Offset: 0x000161FC
		public WcfLogReceiverClient(bool useOneWay, string endpointConfigurationName, string remoteAddress)
		{
			this.UseOneWay = useOneWay;
			global::NLog.LogReceiverService.IWcfLogReceiverClient proxiedClient;
			if (!useOneWay)
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverTwoWayClient(endpointConfigurationName, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			else
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverOneWayClient(endpointConfigurationName, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			this.ProxiedClient = proxiedClient;
		}

		// Token: 0x0600092D RID: 2349 RVA: 0x00018034 File Offset: 0x00016234
		public WcfLogReceiverClient(bool useOneWay, string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress)
		{
			this.UseOneWay = useOneWay;
			global::NLog.LogReceiverService.IWcfLogReceiverClient proxiedClient;
			if (!useOneWay)
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverTwoWayClient(endpointConfigurationName, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			else
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverOneWayClient(endpointConfigurationName, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			this.ProxiedClient = proxiedClient;
		}

		// Token: 0x0600092E RID: 2350 RVA: 0x0001806C File Offset: 0x0001626C
		public WcfLogReceiverClient(bool useOneWay, global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress)
		{
			this.UseOneWay = useOneWay;
			global::NLog.LogReceiverService.IWcfLogReceiverClient proxiedClient;
			if (!useOneWay)
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverTwoWayClient(binding, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			else
			{
				global::NLog.LogReceiverService.IWcfLogReceiverClient wcfLogReceiverClient = new global::NLog.LogReceiverService.WcfLogReceiverOneWayClient(binding, remoteAddress);
				proxiedClient = wcfLogReceiverClient;
			}
			this.ProxiedClient = proxiedClient;
		}

		// Token: 0x0600092F RID: 2351 RVA: 0x000180A3 File Offset: 0x000162A3
		public void Abort()
		{
			this.ProxiedClient.Abort();
		}

		// Token: 0x06000930 RID: 2352 RVA: 0x000180B0 File Offset: 0x000162B0
		public global::System.IAsyncResult BeginClose(global::System.AsyncCallback callback, object state)
		{
			return this.ProxiedClient.BeginClose(callback, state);
		}

		// Token: 0x06000931 RID: 2353 RVA: 0x000180BF File Offset: 0x000162BF
		public global::System.IAsyncResult BeginClose(global::System.TimeSpan timeout, global::System.AsyncCallback callback, object state)
		{
			return this.ProxiedClient.BeginClose(timeout, callback, state);
		}

		// Token: 0x06000932 RID: 2354 RVA: 0x000180CF File Offset: 0x000162CF
		public global::System.IAsyncResult BeginOpen(global::System.AsyncCallback callback, object state)
		{
			return this.ProxiedClient.BeginOpen(callback, state);
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x000180DE File Offset: 0x000162DE
		public global::System.IAsyncResult BeginOpen(global::System.TimeSpan timeout, global::System.AsyncCallback callback, object state)
		{
			return this.ProxiedClient.BeginOpen(timeout, callback, state);
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x000180EE File Offset: 0x000162EE
		public global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState)
		{
			return this.ProxiedClient.BeginProcessLogMessages(events, callback, asyncState);
		}

		// Token: 0x17000187 RID: 391
		// (get) Token: 0x06000935 RID: 2357 RVA: 0x000180FE File Offset: 0x000162FE
		public global::System.ServiceModel.Description.ClientCredentials ClientCredentials
		{
			get
			{
				return this.ProxiedClient.ClientCredentials;
			}
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x0001810B File Offset: 0x0001630B
		public void Close(global::System.TimeSpan timeout)
		{
			this.ProxiedClient.Close(timeout);
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00018119 File Offset: 0x00016319
		public void Close()
		{
			this.ProxiedClient.Close();
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00018126 File Offset: 0x00016326
		public void CloseAsync(object userState)
		{
			this.ProxiedClient.CloseAsync(userState);
		}

		// Token: 0x06000939 RID: 2361 RVA: 0x00018134 File Offset: 0x00016334
		public void CloseAsync()
		{
			this.ProxiedClient.CloseAsync();
		}

		// Token: 0x1400000B RID: 11
		// (add) Token: 0x0600093A RID: 2362 RVA: 0x00018141 File Offset: 0x00016341
		// (remove) Token: 0x0600093B RID: 2363 RVA: 0x0001814F File Offset: 0x0001634F
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted
		{
			add
			{
				this.ProxiedClient.CloseCompleted += value;
			}
			remove
			{
				this.ProxiedClient.CloseCompleted -= value;
			}
		}

		// Token: 0x1400000C RID: 12
		// (add) Token: 0x0600093C RID: 2364 RVA: 0x0001815D File Offset: 0x0001635D
		// (remove) Token: 0x0600093D RID: 2365 RVA: 0x0001816B File Offset: 0x0001636B
		public event global::System.EventHandler Closed
		{
			add
			{
				this.ProxiedClient.Closed += value;
			}
			remove
			{
				this.ProxiedClient.Closed -= value;
			}
		}

		// Token: 0x1400000D RID: 13
		// (add) Token: 0x0600093E RID: 2366 RVA: 0x00018179 File Offset: 0x00016379
		// (remove) Token: 0x0600093F RID: 2367 RVA: 0x00018187 File Offset: 0x00016387
		public event global::System.EventHandler Closing
		{
			add
			{
				this.ProxiedClient.Closing += value;
			}
			remove
			{
				this.ProxiedClient.Closing -= value;
			}
		}

		// Token: 0x06000940 RID: 2368 RVA: 0x00018195 File Offset: 0x00016395
		public void DisplayInitializationUI()
		{
			this.ProxiedClient.DisplayInitializationUI();
		}

		// Token: 0x17000188 RID: 392
		// (get) Token: 0x06000941 RID: 2369 RVA: 0x000181A2 File Offset: 0x000163A2
		// (set) Token: 0x06000942 RID: 2370 RVA: 0x000181AF File Offset: 0x000163AF
		public global::System.Net.CookieContainer CookieContainer
		{
			get
			{
				return this.ProxiedClient.CookieContainer;
			}
			set
			{
				this.ProxiedClient.CookieContainer = value;
			}
		}

		// Token: 0x06000943 RID: 2371 RVA: 0x000181BD File Offset: 0x000163BD
		public void EndClose(global::System.IAsyncResult result)
		{
			this.ProxiedClient.EndClose(result);
		}

		// Token: 0x06000944 RID: 2372 RVA: 0x000181CB File Offset: 0x000163CB
		public void EndOpen(global::System.IAsyncResult result)
		{
			this.ProxiedClient.EndOpen(result);
		}

		// Token: 0x17000189 RID: 393
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x000181D9 File Offset: 0x000163D9
		public global::System.ServiceModel.Description.ServiceEndpoint Endpoint
		{
			get
			{
				return this.ProxiedClient.Endpoint;
			}
		}

		// Token: 0x06000946 RID: 2374 RVA: 0x000181E6 File Offset: 0x000163E6
		public void EndProcessLogMessages(global::System.IAsyncResult result)
		{
			this.ProxiedClient.EndProcessLogMessages(result);
		}

		// Token: 0x1400000E RID: 14
		// (add) Token: 0x06000947 RID: 2375 RVA: 0x000181F4 File Offset: 0x000163F4
		// (remove) Token: 0x06000948 RID: 2376 RVA: 0x00018202 File Offset: 0x00016402
		public event global::System.EventHandler Faulted
		{
			add
			{
				this.ProxiedClient.Faulted += value;
			}
			remove
			{
				this.ProxiedClient.Faulted -= value;
			}
		}

		// Token: 0x1700018A RID: 394
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x00018210 File Offset: 0x00016410
		public global::System.ServiceModel.IClientChannel InnerChannel
		{
			get
			{
				return this.ProxiedClient.InnerChannel;
			}
		}

		// Token: 0x0600094A RID: 2378 RVA: 0x0001821D File Offset: 0x0001641D
		public void Open()
		{
			this.ProxiedClient.Open();
		}

		// Token: 0x0600094B RID: 2379 RVA: 0x0001822A File Offset: 0x0001642A
		public void Open(global::System.TimeSpan timeout)
		{
			this.ProxiedClient.Open(timeout);
		}

		// Token: 0x0600094C RID: 2380 RVA: 0x00018238 File Offset: 0x00016438
		public void OpenAsync()
		{
			this.ProxiedClient.OpenAsync();
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x00018245 File Offset: 0x00016445
		public void OpenAsync(object userState)
		{
			this.ProxiedClient.OpenAsync(userState);
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x0600094E RID: 2382 RVA: 0x00018253 File Offset: 0x00016453
		// (remove) Token: 0x0600094F RID: 2383 RVA: 0x00018261 File Offset: 0x00016461
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted
		{
			add
			{
				this.ProxiedClient.OpenCompleted += value;
			}
			remove
			{
				this.ProxiedClient.OpenCompleted -= value;
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x06000950 RID: 2384 RVA: 0x0001826F File Offset: 0x0001646F
		// (remove) Token: 0x06000951 RID: 2385 RVA: 0x0001827D File Offset: 0x0001647D
		public event global::System.EventHandler Opened
		{
			add
			{
				this.ProxiedClient.Opened += value;
			}
			remove
			{
				this.ProxiedClient.Opened -= value;
			}
		}

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x06000952 RID: 2386 RVA: 0x0001828B File Offset: 0x0001648B
		// (remove) Token: 0x06000953 RID: 2387 RVA: 0x00018299 File Offset: 0x00016499
		public event global::System.EventHandler Opening
		{
			add
			{
				this.ProxiedClient.Opening += value;
			}
			remove
			{
				this.ProxiedClient.Opening -= value;
			}
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x000182A7 File Offset: 0x000164A7
		public void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events)
		{
			this.ProxiedClient.ProcessLogMessagesAsync(events);
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000182B5 File Offset: 0x000164B5
		public void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events, object userState)
		{
			this.ProxiedClient.ProcessLogMessagesAsync(events, userState);
		}

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x06000956 RID: 2390 RVA: 0x000182C4 File Offset: 0x000164C4
		// (remove) Token: 0x06000957 RID: 2391 RVA: 0x000182D2 File Offset: 0x000164D2
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> ProcessLogMessagesCompleted
		{
			add
			{
				this.ProxiedClient.ProcessLogMessagesCompleted += value;
			}
			remove
			{
				this.ProxiedClient.ProcessLogMessagesCompleted -= value;
			}
		}

		// Token: 0x1700018B RID: 395
		// (get) Token: 0x06000958 RID: 2392 RVA: 0x000182E0 File Offset: 0x000164E0
		public global::System.ServiceModel.CommunicationState State
		{
			get
			{
				return this.ProxiedClient.State;
			}
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x000182ED File Offset: 0x000164ED
		public void CloseCommunicationObject()
		{
			this.ProxiedClient.Close();
		}
	}
}
