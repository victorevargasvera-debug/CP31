using System;
using System.ServiceModel;
using Motorola.CommonCPS.Server.EntityModel.CallBacks;
using Motorola.CommonCPS.Server.ServiceModel.CallBack;

namespace Motorola.CommonCPS.ServerCallbackContract
{
	// Token: 0x02000004 RID: 4
	public interface IServerCallback
	{
		// Token: 0x0600000A RID: 10
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void OnServerEvent(global::Motorola.CommonCPS.Server.EntityModel.CallBacks.ClientEventInfo e);

		// Token: 0x0600000B RID: 11
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		[global::Motorola.CommonCPS.ServerCallbackContract.ApplyDataContractResolver]
		void OnRMServerEvent(global::Motorola.CommonCPS.Server.ServiceModel.CallBack.ServerEventInfo e);
	}
}
