using System;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.DeviceDiscovery;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200002D RID: 45
	internal class AstroWifiTlsDevice : global::Motorola.Common.Communication.CommunicationManager.AstroWiFiDevice
	{
		// Token: 0x06000101 RID: 257 RVA: 0x0001550C File Offset: 0x0001370C
		protected internal AstroWifiTlsDevice(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.DeviceDiscovery.RNDISRadioProfile profile, global::Motorola.Common.Communication.CommunicationManager.ISequenceManagerFactory sequenceManagerFactory, global::Motorola.Common.Communication.CommunicationManager.ICommunicationManager communicationManager, global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeFactory communicationPipeFactory) : base(deviceInfo, profile, sequenceManagerFactory, communicationManager, communicationPipeFactory)
		{
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00015528 File Offset: 0x00013728
		public override void Prefetch()
		{
			short num = (short)746566162;
			short num2 = num;
			num = (short)1216590354;
			switch (num2 == num)
			{
			}
			num = (short)945225728;
			short num3 = num;
			num = (short)335216641;
			if (num != 0)
			{
			}
			num = (short)494927872;
			if (num != 0)
			{
			}
			base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.InitializingDevice);
			this.RetrieveIPAddress(ref this._radioProfile);
			this.InitDeviceParams();
			base.ChangeRadioState(global::Motorola.Common.Communication.CommonUtil.RadioState.Ready);
		}
	}
}
