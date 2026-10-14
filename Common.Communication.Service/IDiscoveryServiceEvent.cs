using System;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x0200004B RID: 75
	public interface IDiscoveryServiceEvent
	{
		// Token: 0x0600029C RID: 668
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceConnected(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x0600029D RID: 669
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x0600029E RID: 670
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnMasterSystemLost(global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs args);

		// Token: 0x0600029F RID: 671
		[global::System.ServiceModel.OperationContract(IsOneWay = true)]
		void OnDeviceSwitchOver(global::Motorola.Common.Communication.CommonUtil.SwitchOverEventArgs args);
	}
}
