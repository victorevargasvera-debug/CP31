using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public enum ConnectFunction : byte
	{
		// Token: 0x0400004F RID: 79
		CANConnectivityTest = 1,
		// Token: 0x04000050 RID: 80
		EthernetConnectivityTest,
		// Token: 0x04000051 RID: 81
		RS232ConnectivityTest,
		// Token: 0x04000052 RID: 82
		USBConnectivityTest,
		// Token: 0x04000053 RID: 83
		SDConnectivityTest,
		// Token: 0x04000054 RID: 84
		SSIConnectivityTest,
		// Token: 0x04000055 RID: 85
		BTSSIConnectivityTest,
		// Token: 0x04000056 RID: 86
		BTGPSConnectivityTest,
		// Token: 0x04000057 RID: 87
		FactoryControlHeadConnectivityTest,
		// Token: 0x04000058 RID: 88
		GPSBISTPatchDownload,
		// Token: 0x04000059 RID: 89
		MarvellICTestMode = 12
	}
}
