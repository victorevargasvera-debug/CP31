using System;
using System.ServiceModel;

namespace NLog.LogReceiverService
{
	// Token: 0x02000087 RID: 135
	[global::System.ServiceModel.ServiceContract(Namespace = "http://nlog-project.org/ws/", ConfigurationName = "NLog.LogReceiverService.ILogReceiverClient")]
	[global::System.Obsolete("Use ILogReceiverOneWayClient or ILogReceiverTwoWayClient instead. Marked obsolete before v4.3.11 and it may be removed in a future release.")]
	public interface ILogReceiverClient
	{
		// Token: 0x060008E1 RID: 2273
		[global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessages", ReplyAction = "http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessagesResponse")]
		global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x060008E2 RID: 2274
		void EndProcessLogMessages(global::System.IAsyncResult result);
	}
}
