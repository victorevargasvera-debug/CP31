using System;
using Motorola.Common.Communication.CommonUtil;
using SSLMangrComp;

namespace SpecialFeatures.Comms
{
	// Token: 0x0200015F RID: 351
	public interface IDeviceManager
	{
		// Token: 0x060011C7 RID: 4551
		global::Motorola.Common.Communication.CommonUtil.DeviceInfo[] GetAllConnectedDevice();

		// Token: 0x060011C8 RID: 4552
		global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connectionConfig);

		// Token: 0x060011C9 RID: 4553
		global::SpecialFeatures.Comms.IDeviceProxy CreateDeviceProxy(global::SpecialFeatures.Comms.RadioParams radioPara, global::Motorola.Common.Communication.CommonUtil.RadioOperation radioOp);

		// Token: 0x14000011 RID: 17
		// (add) Token: 0x060011CA RID: 4554
		// (remove) Token: 0x060011CB RID: 4555
		event global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEvent;

		// Token: 0x14000012 RID: 18
		// (add) Token: 0x060011CC RID: 4556
		// (remove) Token: 0x060011CD RID: 4557
		event global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEvent;
	}
}
