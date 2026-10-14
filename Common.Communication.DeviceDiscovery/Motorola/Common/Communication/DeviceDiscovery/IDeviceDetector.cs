using System;

namespace Motorola.Common.Communication.DeviceDiscovery
{
	// Token: 0x0200000B RID: 11
	public interface IDeviceDetector
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000047 RID: 71
		global::Motorola.Common.Communication.DeviceDiscovery.DeviceDetectorType DetectorType { get; }

		// Token: 0x06000048 RID: 72
		bool Start();

		// Token: 0x06000049 RID: 73
		void Stop();

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x0600004A RID: 74
		// (remove) Token: 0x0600004B RID: 75
		event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceAttached;

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x0600004C RID: 76
		// (remove) Token: 0x0600004D RID: 77
		event global::Motorola.Common.Communication.DeviceDiscovery.DeviceEventHandler deviceDetached;

		// Token: 0x0600004E RID: 78
		bool DeviceChanged(global::Motorola.Common.Communication.DeviceDiscovery.OriginalPnPMsg pnpMsg);
	}
}
