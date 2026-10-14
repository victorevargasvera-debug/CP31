using System;
using System.Collections.Generic;
using System.ServiceModel;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;
using SSLMangrComp;

namespace Motorola.Common.Communication.Service
{
	// Token: 0x02000045 RID: 69
	[global::System.ServiceModel.ServiceContract(SessionMode = global::System.ServiceModel.SessionMode.Required, CallbackContract = typeof(global::Motorola.Common.Communication.Service.IDiscoveryServiceEvent))]
	public interface IDeviceDiscovery : global::System.IDisposable
	{
		// Token: 0x06000277 RID: 631
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(int deviceConnectionType);

		// Token: 0x06000278 RID: 632
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(int deviceConnectionType, string identifier);

		// Token: 0x06000279 RID: 633
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void RegisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x0600027A RID: 634
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		void DeregisterForPresence(global::System.Collections.Generic.List<string> deviceIDs, global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x0600027B RID: 635
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connInfo);

		// Token: 0x0600027C RID: 636
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void ClosePN();

		// Token: 0x0600027D RID: 637
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void UpdatePassword(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords);

		// Token: 0x0600027E RID: 638
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonException))]
		void DetachDevice(string serialnumber);

		// Token: 0x0600027F RID: 639
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonException))]
		[global::System.ServiceModel.OperationContract]
		void RemoveDevice(string radioId);

		// Token: 0x06000280 RID: 640
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonException))]
		void DetectWiFiDevices();

		// Token: 0x06000281 RID: 641
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void ChangeDeviceProcessorToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device);

		// Token: 0x06000282 RID: 642
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		bool IsRadioInBpMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device);

		// Token: 0x06000283 RID: 643
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		bool EstablishSecureConnection(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device, string psk);

		// Token: 0x06000284 RID: 644
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		[global::System.ServiceModel.OperationContract]
		string GetPskId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device);

		// Token: 0x06000285 RID: 645
		[global::System.ServiceModel.OperationContract]
		[global::System.ServiceModel.FaultContract(typeof(global::Motorola.Common.CustomException.CommonExceptionData))]
		void ChangeFromBpToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);
	}
}
