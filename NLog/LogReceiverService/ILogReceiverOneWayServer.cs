using System;
using System.ServiceModel;

namespace NLog.LogReceiverService
{
	// Token: 0x02000089 RID: 137
	[global::System.ServiceModel.ServiceContract(Namespace = "http://nlog-project.org/ws/")]
	public interface ILogReceiverOneWayServer
	{
		// Token: 0x060008E5 RID: 2277
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void ProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events);
	}
}
