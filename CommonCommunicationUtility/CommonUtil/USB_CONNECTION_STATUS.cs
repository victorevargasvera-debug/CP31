using System;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200004D RID: 77
	public enum USB_CONNECTION_STATUS
	{
		// Token: 0x0400023C RID: 572
		NoDeviceConnected,
		// Token: 0x0400023D RID: 573
		DeviceConnected,
		// Token: 0x0400023E RID: 574
		DeviceFailedEnumeration,
		// Token: 0x0400023F RID: 575
		DeviceGeneralFailure,
		// Token: 0x04000240 RID: 576
		DeviceCausedOvercurrent,
		// Token: 0x04000241 RID: 577
		DeviceNotEnoughPower,
		// Token: 0x04000242 RID: 578
		DeviceNotEnoughBandwidth,
		// Token: 0x04000243 RID: 579
		DeviceHubNestedTooDeeply,
		// Token: 0x04000244 RID: 580
		DeviceInLegacyHub,
		// Token: 0x04000245 RID: 581
		DeviceEnumerating,
		// Token: 0x04000246 RID: 582
		DeviceReset
	}
}
