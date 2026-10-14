using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000028 RID: 40
	public enum UsbRouteControlFunction : byte
	{
		// Token: 0x040000C7 RID: 199
		SetApplicationProcessorRoute = 1,
		// Token: 0x040000C8 RID: 200
		SetBasebandProcessorRoute,
		// Token: 0x040000C9 RID: 201
		SetPermanentUsbMuxFlagToApplicationProcessorRoute,
		// Token: 0x040000CA RID: 202
		SetPermanentUsbMuxFlagToBasebandProcessorRoute,
		// Token: 0x040000CB RID: 203
		SetGobRoute,
		// Token: 0x040000CC RID: 204
		SetApplicationProcessorRoutePlusEdlMode = 17,
		// Token: 0x040000CD RID: 205
		SetApplicationProcessorRoutePlusFastbootMode
	}
}
