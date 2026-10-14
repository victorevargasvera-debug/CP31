using System;
using System.ServiceModel;

namespace NLog.LogReceiverService
{
	// Token: 0x02000088 RID: 136
	[global::System.ServiceModel.ServiceContract(Namespace = "http://nlog-project.org/ws/", ConfigurationName = "NLog.LogReceiverService.ILogReceiverOneWayClient")]
	public interface ILogReceiverOneWayClient
	{
		// Token: 0x060008E3 RID: 2275
		[global::System.ServiceModel.OperationContract(IsOneWay = true, AsyncPattern = true, Action = "http://nlog-project.org/ws/ILogReceiverOneWayServer/ProcessLogMessages")]
		global::System.IAsyncResult BeginProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events, global::System.AsyncCallback callback, object asyncState);

		// Token: 0x060008E4 RID: 2276
		void EndProcessLogMessages(global::System.IAsyncResult result);
	}
}
