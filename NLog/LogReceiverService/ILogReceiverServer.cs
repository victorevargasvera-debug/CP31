using System;
using System.ServiceModel;

namespace NLog.LogReceiverService
{
	// Token: 0x0200008A RID: 138
	[global::System.ServiceModel.ServiceContract(Namespace = "http://nlog-project.org/ws/")]
	public interface ILogReceiverServer
	{
		// Token: 0x060008E6 RID: 2278
		[global::System.ServiceModel.OperationContract]
		void ProcessLogMessages(global::NLog.LogReceiverService.NLogEvents events);
	}
}
