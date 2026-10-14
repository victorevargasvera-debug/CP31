using System;
using System.Net.Security;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace CefSharp.Internals.Wcf
{
	// Token: 0x020000F8 RID: 248
	public class BrowserProcessServiceHost : global::System.ServiceModel.ServiceHost
	{
		// Token: 0x1700022C RID: 556
		// (get) Token: 0x06000754 RID: 1876 RVA: 0x0000BFD0 File Offset: 0x0000A1D0
		// (set) Token: 0x06000755 RID: 1877 RVA: 0x0000BFD8 File Offset: 0x0000A1D8
		public global::CefSharp.Internals.IJavascriptObjectRepositoryInternal JavascriptObjectRepository { get; private set; }

		// Token: 0x06000756 RID: 1878 RVA: 0x0000BFE4 File Offset: 0x0000A1E4
		public BrowserProcessServiceHost(global::CefSharp.Internals.IJavascriptObjectRepositoryInternal javascriptObjectRepository, int parentProcessId, int browserId, global::CefSharp.Internals.IJavascriptCallbackFactory callbackFactory) : base(typeof(global::CefSharp.Internals.Wcf.BrowserProcessService), new global::System.Uri[0])
		{
			this.JavascriptObjectRepository = javascriptObjectRepository;
			string serviceName = global::CefSharp.Internals.RenderprocessClientFactory.GetServiceName(parentProcessId, browserId);
			base.Description.ApplyServiceBehavior(() => new global::System.ServiceModel.Description.ServiceDebugBehavior(), delegate(global::System.ServiceModel.Description.ServiceDebugBehavior p)
			{
				p.IncludeExceptionDetailInFaults = true;
			});
			global::System.ServiceModel.Channels.CustomBinding binding = global::CefSharp.Internals.Wcf.BrowserProcessServiceHost.CreateBinding();
			global::System.ServiceModel.Description.ServiceEndpoint serviceEndpoint = base.AddServiceEndpoint(typeof(global::CefSharp.Internals.Wcf.IBrowserProcess), binding, new global::System.Uri(serviceName));
			serviceEndpoint.Contract.ProtectionLevel = global::System.Net.Security.ProtectionLevel.None;
			serviceEndpoint.Behaviors.Add(new global::CefSharp.Internals.Wcf.JavascriptCallbackEndpointBehavior(callbackFactory));
		}

		// Token: 0x06000757 RID: 1879 RVA: 0x0000C09B File Offset: 0x0000A29B
		protected override void OnClosed()
		{
			base.OnClosed();
			this.JavascriptObjectRepository = null;
		}

		// Token: 0x06000758 RID: 1880 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		public static global::System.ServiceModel.Channels.CustomBinding CreateBinding()
		{
			global::System.ServiceModel.Channels.CustomBinding customBinding = new global::System.ServiceModel.Channels.CustomBinding(new global::System.ServiceModel.NetNamedPipeBinding(global::System.ServiceModel.NetNamedPipeSecurityMode.None)
			{
				MaxReceivedMessageSize = 134217728L,
				ReceiveTimeout = global::System.TimeSpan.MaxValue,
				SendTimeout = global::System.TimeSpan.MaxValue,
				OpenTimeout = global::System.TimeSpan.MaxValue,
				CloseTimeout = global::System.TimeSpan.MaxValue,
				ReaderQuotas = 
				{
					MaxStringContentLength = int.MaxValue,
					MaxArrayLength = int.MaxValue,
					MaxDepth = int.MaxValue,
					MaxNameTableCharCount = int.MaxValue,
					MaxBytesPerRead = int.MaxValue
				}
			});
			global::System.ServiceModel.Channels.NamedPipeConnectionPoolSettings connectionPoolSettings = customBinding.Elements.Find<global::System.ServiceModel.Channels.NamedPipeTransportBindingElement>().ConnectionPoolSettings;
			connectionPoolSettings.IdleTimeout = global::System.TimeSpan.MaxValue;
			connectionPoolSettings.MaxOutboundConnectionsPerEndpoint = 0;
			return customBinding;
		}

		// Token: 0x040003D1 RID: 977
		private const long OneHundredAndTwentyEightMegaBytesInBytes = 134217728L;
	}
}
