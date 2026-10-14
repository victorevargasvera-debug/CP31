using System;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200004A RID: 74
	public interface IOperationServiceEvent
	{
		// Token: 0x0600029B RID: 667
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnProgress(int percentComplete, global::Motorola.Common.Communication.CommonUtil.ProgressStatus status);
	}
}
