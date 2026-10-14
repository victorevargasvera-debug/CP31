using System;
using System.ServiceModel;
using System.ServiceModel.Channels;

namespace NLog.LogReceiverService
{
	// Token: 0x02000093 RID: 147
	[global::System.Obsolete("Use WcfLogReceiverOneWayClient class instead. Marked obsolete before v4.3.11 and it may be removed in a future release.")]
	public sealed class WcfILogReceiverClient : global::NLog.LogReceiverService.WcfLogReceiverClientBase<global::NLog.LogReceiverService.ILogReceiverClient>, global::NLog.LogReceiverService.ILogReceiverClient
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00017F21 File Offset: 0x00016121
		public WcfILogReceiverClient()
		{
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00017F29 File Offset: 0x00016129
		public WcfILogReceiverClient(string endpointConfigurationName) : base(endpointConfigurationName)
		{
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00017F32 File Offset: 0x00016132
		public WcfILogReceiverClient(string endpointConfigurationName, string remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00017F3C File Offset: 0x0001613C
		public WcfILogReceiverClient(string endpointConfigurationName, global::System.ServiceModel.EndpointAddress remoteAddress) : base(endpointConfigurationName, remoteAddress)
		{
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x00017F46 File Offset: 0x00016146
		public WcfILogReceiverClient(global::System.ServiceModel.Channels.Binding binding, global::System.ServiceModel.EndpointAddress remoteAddress) : base(binding, remoteAddress)
		{
		}

		// Token: 0x06000924 RID: 2340 RVA: 0x00017F50 File Offset: 0x00016150
		public override global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState)
		{
			return base.Channel.BeginProcessLogMessages(events, callback, asyncState);
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00017F60 File Offset: 0x00016160
		public override void EndProcessLogMessages(global::System.IAsyncResult result)
		{
			base.Channel.EndProcessLogMessages(result);
		}
	}
}
