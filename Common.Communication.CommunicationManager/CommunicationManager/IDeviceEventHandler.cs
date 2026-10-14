using System;
using Motorola.Common.Communication.CommonUtil;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000023 RID: 35
	internal interface IDeviceEventHandler
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x0600007B RID: 123
		// (set) Token: 0x0600007C RID: 124
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEventHandler { get; set; }

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600007D RID: 125
		// (set) Token: 0x0600007E RID: 126
		global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEventHandler { get; set; }
	}
}
