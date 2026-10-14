using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NLog.LogReceiverService
{
	// Token: 0x02000096 RID: 150
	public sealed class WcfLogReceiverOneWayClient : global::NLog.LogReceiverService.WcfLogReceiverClientBase<global::NLog.LogReceiverService.ILogReceiverOneWayClient>, global::NLog.LogReceiverService.ILogReceiverOneWayClient
	{
		// Token: 0x0600097C RID: 2428 RVA: 0x000186A7 File Offset: 0x000168A7
		public WcfLogReceiverOneWayClient()
		{
		}

		// Token: 0x0600097D RID: 2429 RVA: 0x000186AF File Offset: 0x000168AF
		public WcfLogReceiverOneWayClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		// Token: 0x0600097E RID: 2430 RVA: 0x000186B8 File Offset: 0x000168B8
		public WcfLogReceiverOneWayClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x0600097F RID: 2431 RVA: 0x000186C2 File Offset: 0x000168C2
		public WcfLogReceiverOneWayClient(string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000980 RID: 2432 RVA: 0x000186CC File Offset: 0x000168CC
		public WcfLogReceiverOneWayClient(global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		// Token: 0x06000981 RID: 2433 RVA: 0x000186D6 File Offset: 0x000168D6
		public override global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginProcessLogMessages(events, callback, asyncState);
		}

		// Token: 0x06000982 RID: 2434 RVA: 0x000186E6 File Offset: 0x000168E6
		public override void EndProcessLogMessages(global::System.IAsyncResult result)
		{
			base.Channel.EndProcessLogMessages(result);
		}
	}
}
