using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x02000021 RID: 33
	public enum DeviceDetectorType
	{
		// Token: 0x0400006D RID: 109
		Unknown,
		// Token: 0x0400006E RID: 110
		VCOMDetector,
		// Token: 0x0400006F RID: 111
		RNDISDetector,
		// Token: 0x04000070 RID: 112
		PCRRemoteDeviceDetector,
		// Token: 0x04000071 RID: 113
		PBBDeviceDetector,
		// Token: 0x04000072 RID: 114
		DNSSDDetector,
		// Token: 0x04000073 RID: 115
		LTEDetector,
		// Token: 0x04000074 RID: 116
		VirtualDeviceDetector = 255
	}
}
