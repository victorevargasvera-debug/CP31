using System;
using System.ComponentModel;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.Threading;

namespace NLog.LogReceiverService
{
	// Token: 0x02000095 RID: 149
	public abstract class WcfLogReceiverClientBase<TService> : global::System.ServiceModel.ClientBase<TService>, global::NLog.LogReceiverService.IWcfLogReceiverClient, global::System.ServiceModel.ICommunicationObject where TService : class
	{
		// Token: 0x0600095A RID: 2394 RVA: 0x000182FA File Offset: 0x000164FA
		protected WcfLogReceiverClientBase()
		{
		}

		// Token: 0x0600095B RID: 2395 RVA: 0x00018302 File Offset: 0x00016502
		protected WcfLogReceiverClientBase(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		// Token: 0x0600095C RID: 2396 RVA: 0x0001830B File Offset: 0x0001650B
		protected WcfLogReceiverClientBase(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x0600095D RID: 2397 RVA: 0x00018315 File Offset: 0x00016515
		protected WcfLogReceiverClientBase(string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x0600095E RID: 2398 RVA: 0x0001831F File Offset: 0x0001651F
		protected WcfLogReceiverClientBase(global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		// Token: 0x14000013 RID: 19
		// (add) Token: 0x0600095F RID: 2399 RVA: 0x0001832C File Offset: 0x0001652C
		// (remove) Token: 0x06000960 RID: 2400 RVA: 0x00018364 File Offset: 0x00016564
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> ProcessLogMessagesCompleted;

		// Token: 0x14000014 RID: 20
		// (add) Token: 0x06000961 RID: 2401 RVA: 0x0001839C File Offset: 0x0001659C
		// (remove) Token: 0x06000962 RID: 2402 RVA: 0x000183D4 File Offset: 0x000165D4
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;

		// Token: 0x14000015 RID: 21
		// (add) Token: 0x06000963 RID: 2403 RVA: 0x0001840C File Offset: 0x0001660C
		// (remove) Token: 0x06000964 RID: 2404 RVA: 0x00018444 File Offset: 0x00016644
		public event global::System.EventHandler<global::System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;

		// Token: 0x1700018C RID: 396
		// (get) Token: 0x06000965 RID: 2405 RVA: 0x00018479 File Offset: 0x00016679
		// (set) Token: 0x06000966 RID: 2406 RVA: 0x00018494 File Offset: 0x00016694
		public global::System.Net.CookieContainer CookieContainer
		{
			get
			{
				global::System.ServiceModel.Channels.IHttpCookieContainerManager property = base.InnerChannel.GetProperty<global::System.ServiceModel.Channels.IHttpCookieContainerManager>();
				if (property == null)
				{
					return null;
				}
				return property.CookieContainer;
			}
			set
			{
				global::System.ServiceModel.Channels.IHttpCookieContainerManager property = base.InnerChannel.GetProperty<global::System.ServiceModel.Channels.IHttpCookieContainerManager>();
				if (property != null)
				{
					property.CookieContainer = value;
					return;
				}
				throw new global::System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpCookieContainerBindingElement.");
			}
		}

		// Token: 0x06000967 RID: 2407 RVA: 0x000184C2 File Offset: 0x000166C2
		public void OpenAsync()
		{
			this.OpenAsync(null);
		}

		// Token: 0x06000968 RID: 2408 RVA: 0x000184CB File Offset: 0x000166CB
		public void OpenAsync(object userState)
		{
			base.InvokeAsync(new global::System.ServiceModel.ClientBase<TService>.BeginOperationDelegate(this.OnBeginOpen), null, new global::System.ServiceModel.ClientBase<TService>.EndOperationDelegate(this.OnEndOpen), new global::System.Threading.SendOrPostCallback(this.OnOpenCompleted), userState);
		}

		// Token: 0x06000969 RID: 2409 RVA: 0x000184F9 File Offset: 0x000166F9
		public void CloseAsync()
		{
			this.CloseAsync(null);
		}

		// Token: 0x0600096A RID: 2410 RVA: 0x00018502 File Offset: 0x00016702
		public void CloseAsync(object userState)
		{
			base.InvokeAsync(new global::System.ServiceModel.ClientBase<TService>.BeginOperationDelegate(this.OnBeginClose), null, new global::System.ServiceModel.ClientBase<TService>.EndOperationDelegate(this.OnEndClose), new global::System.Threading.SendOrPostCallback(this.OnCloseCompleted), userState);
		}

		// Token: 0x0600096B RID: 2411 RVA: 0x00018530 File Offset: 0x00016730
		public void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events)
		{
			this.ProcessLogMessagesAsync(events, null);
		}

		// Token: 0x0600096C RID: 2412 RVA: 0x0001853A File Offset: 0x0001673A
		public void ProcessLogMessagesAsync(global::NLog.LogReceiverService.NLogEvents events, object userState)
		{
			base.InvokeAsync(new global::System.ServiceModel.ClientBase<TService>.BeginOperationDelegate(this.OnBeginProcessLogMessages), new object[]
			{
				events
			}, new global::System.ServiceModel.ClientBase<TService>.EndOperationDelegate(this.OnEndProcessLogMessages), new global::System.Threading.SendOrPostCallback(this.OnProcessLogMessagesCompleted), userState);
		}

		// Token: 0x0600096D RID: 2413
		public abstract global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x0600096E RID: 2414
		public abstract void EndProcessLogMessages(global::System.IAsyncResult result);

		// Token: 0x0600096F RID: 2415 RVA: 0x00018574 File Offset: 0x00016774
		private global::System.IAsyncResult OnBeginProcessLogMessages(object[] inValues, global::System.AsyncCallback callback, object asyncState)
		{
			global::NLog.LogReceiverService.NLogEvents events = (global::NLog.LogReceiverService.NLogEvents)inValues[0];
			return this.BeginProcessLogMessages(events, callback, asyncState);
		}

		// Token: 0x06000970 RID: 2416 RVA: 0x00018593 File Offset: 0x00016793
		private object[] OnEndProcessLogMessages(global::System.IAsyncResult result)
		{
			this.EndProcessLogMessages(result);
			return null;
		}

		// Token: 0x06000971 RID: 2417 RVA: 0x000185A0 File Offset: 0x000167A0
		private void OnProcessLogMessagesCompleted(object state)
		{
			if (this.ProcessLogMessagesCompleted != null)
			{
				global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs)state;
				this.ProcessLogMessagesCompleted(this, new global::System.ComponentModel.AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000972 RID: 2418 RVA: 0x000185DF File Offset: 0x000167DF
		private global::System.IAsyncResult OnBeginOpen(object[] inValues, global::System.AsyncCallback callback, object asyncState)
		{
			return ((global::System.ServiceModel.ICommunicationObject)this).BeginOpen(callback, asyncState);
		}

		// Token: 0x06000973 RID: 2419 RVA: 0x000185E9 File Offset: 0x000167E9
		private object[] OnEndOpen(global::System.IAsyncResult result)
		{
			((global::System.ServiceModel.ICommunicationObject)this).EndOpen(result);
			return null;
		}

		// Token: 0x06000974 RID: 2420 RVA: 0x000185F4 File Offset: 0x000167F4
		private void OnOpenCompleted(object state)
		{
			if (this.OpenCompleted != null)
			{
				global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs)state;
				this.OpenCompleted(this, new global::System.ComponentModel.AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000975 RID: 2421 RVA: 0x00018633 File Offset: 0x00016833
		private global::System.IAsyncResult OnBeginClose(object[] inValues, global::System.AsyncCallback callback, object asyncState)
		{
			return ((global::System.ServiceModel.ICommunicationObject)this).BeginClose(callback, asyncState);
		}

		// Token: 0x06000976 RID: 2422 RVA: 0x0001863D File Offset: 0x0001683D
		private object[] OnEndClose(global::System.IAsyncResult result)
		{
			((global::System.ServiceModel.ICommunicationObject)this).EndClose(result);
			return null;
		}

		// Token: 0x06000977 RID: 2423 RVA: 0x00018648 File Offset: 0x00016848
		private void OnCloseCompleted(object state)
		{
			if (this.CloseCompleted != null)
			{
				global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs invokeAsyncCompletedEventArgs = (global::System.ServiceModel.ClientBase<TService>.InvokeAsyncCompletedEventArgs)state;
				this.CloseCompleted(this, new global::System.ComponentModel.AsyncCompletedEventArgs(invokeAsyncCompletedEventArgs.Error, invokeAsyncCompletedEventArgs.Cancelled, invokeAsyncCompletedEventArgs.UserState));
			}
		}

		// Token: 0x06000978 RID: 2424 RVA: 0x00018687 File Offset: 0x00016887
		global::System.ServiceModel.Description.ClientCredentials global::NLog.LogReceiverService.IWcfLogReceiverClient.get_ClientCredentials()
		{
			return base.ClientCredentials;
		}

		// Token: 0x06000979 RID: 2425 RVA: 0x0001868F File Offset: 0x0001688F
		global::System.ServiceModel.IClientChannel global::NLog.LogReceiverService.IWcfLogReceiverClient.get_InnerChannel()
		{
			return base.InnerChannel;
		}

		// Token: 0x0600097A RID: 2426 RVA: 0x00018697 File Offset: 0x00016897
		global::System.ServiceModel.Description.ServiceEndpoint global::NLog.LogReceiverService.IWcfLogReceiverClient.get_Endpoint()
		{
			return base.Endpoint;
		}

		// Token: 0x0600097B RID: 2427 RVA: 0x0001869F File Offset: 0x0001689F
		void global::NLog.LogReceiverService.IWcfLogReceiverClient.DisplayInitializationUI()
		{
			base.DisplayInitializationUI();
		}
	}
}
