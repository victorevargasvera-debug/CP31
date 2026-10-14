using System;
using System.ServiceModel;

namespace NLog.LogReceiverService
{
	// Token: 0x0200008B RID: 139
	[global::System.ServiceModel.ServiceContract(Namespace = "http://nlog-project.org/ws/", ConfigurationName = "NLog.LogReceiverService.ILogReceiverClient")]
	public interface ILogReceiverTwoWayClient
	{
		// Token: 0x060008E7 RID: 2279
		[global::System.ServiceModel.OperationContract(AsyncPattern = true, Action = "http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessages", ReplyAction = "http://nlog-project.org/ws/ILogReceiverServer/ProcessLogMessagesResponse")]
		global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x060008E8 RID: 2280
		void EndProcessLogMessages(global::System.IAsyncResult result);
	}
}
