using System;
using System.Collections.Generic;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000023 RID: 35
	public interface ICommunicationManager : global::Motorola.Common.Communication.CommonUtil.IObserver, global::System.IDisposable
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x06000111 RID: 273
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> DeviceInfoList { get; }

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x06000112 RID: 274
		global::Motorola.Common.Communication.CommonUtil.WorkMode DiscoveryWorkMode { get; }

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x06000113 RID: 275
		// (set) Token: 0x06000114 RID: 276
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x06000115 RID: 277
		// (set) Token: 0x06000116 RID: 278
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler { get; set; }

		// Token: 0x06000117 RID: 279
		void Start(global::Motorola.Common.Communication.CommonUtil.ProductFamily deviceFamilySet, global::Motorola.Common.Communication.CommonUtil.WorkMode workMode);

		// Token: 0x06000118 RID: 280
		void Stop();

		// Token: 0x06000119 RID: 281
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> CheckForDevice(global::Motorola.Common.Communication.CommonUtil.ProductFamily _deviceFamilySet, int _deviceConnectionType, string serialNumber);

		// Token: 0x0600011A RID: 282
		global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> ListConnectedDevices(global::Motorola.Common.Communication.CommonUtil.ProductFamily _deviceFamilySet, int _deviceConnectionType);

		// Token: 0x0600011B RID: 283
		void AddDevice(global::Motorola.Common.Communication.IMotoDevice device);

		// Token: 0x0600011C RID: 284
		void ReDetectDevice(string deviceID);

		// Token: 0x0600011D RID: 285
		void RemoveNonPlugPlayDevice(string deviceID);

		// Token: 0x0600011E RID: 286
		global::Motorola.Common.Communication.IMotoDevice GetDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600011F RID: 287
		void DetectWiFiDevices();

		// Token: 0x06000120 RID: 288
		global::Motorola.Common.Communication.IMotoDevice GetDevice(string deviceID);

		// Token: 0x06000121 RID: 289
		string GetManagedRadioId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000122 RID: 290
		void UpdatePasswords(global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.AuthenticationInfo> passwords);

		// Token: 0x06000123 RID: 291
		void DetachDevice(string serialnumber);

		// Token: 0x06000124 RID: 292
		bool ContainWiFiDevice(string radioID);

		// Token: 0x06000125 RID: 293
		bool AttachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf);

		// Token: 0x06000126 RID: 294
		bool DetachDevice(global::Motorola.Common.Communication.IRadioProfile radioProf);

		// Token: 0x06000127 RID: 295
		void RemoveDevice(string deviceID);

		// Token: 0x06000128 RID: 296
		void ChangeFromBpToAp(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x06000129 RID: 297
		bool IsRadioInBpMode(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo);

		// Token: 0x0600012A RID: 298
		bool EstablishSecureConnection(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device, string psk);

		// Token: 0x0600012B RID: 299
		string GetPskId(global::Motorola.Common.Communication.CommonUtil.DeviceInfo device);
	}
}
