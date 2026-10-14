using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NLog.LogReceiverService
{
	// Token: 0x02000097 RID: 151
	public sealed class WcfLogReceiverTwoWayClient : global::NLog.LogReceiverService.WcfLogReceiverClientBase<global::NLog.LogReceiverService.ILogReceiverTwoWayClient>, global::NLog.LogReceiverService.ILogReceiverTwoWayClient
	{
		// Token: 0x06000983 RID: 2435 RVA: 0x000186F4 File Offset: 0x000168F4
		public WcfLogReceiverTwoWayClient()
		{
		}

		// Token: 0x06000984 RID: 2436 RVA: 0x000186FC File Offset: 0x000168FC
		public WcfLogReceiverTwoWayClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		// Token: 0x06000985 RID: 2437 RVA: 0x00018705 File Offset: 0x00016905
		public WcfLogReceiverTwoWayClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000986 RID: 2438 RVA: 0x0001870F File Offset: 0x0001690F
		public WcfLogReceiverTwoWayClient(string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000987 RID: 2439 RVA: 0x00018719 File Offset: 0x00016919
		public WcfLogReceiverTwoWayClient(global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		// Token: 0x06000988 RID: 2440 RVA: 0x00018723 File Offset: 0x00016923
		public override global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginProcessLogMessages(events, callback, asyncState);
		}

		// Token: 0x06000989 RID: 2441 RVA: 0x00018733 File Offset: 0x00016933
		public override void EndProcessLogMessages(global::System.IAsyncResult result)
		{
			base.Channel.EndProcessLogMessages(result);
		}
	}
}
