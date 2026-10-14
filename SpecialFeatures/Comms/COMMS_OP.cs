using System;

namespace SpecialFeatures.Comms
{
	// Token: 0x02000153 RID: 339
	public enum COMMS_OP
	{
		// Token: 0x0400093D RID: 2365
		USB_READ_WRITE = 1,
		// Token: 0x0400093E RID: 2366
		USB_CLONE,
		// Token: 0x0400093F RID: 2367
		OTAP_READ_WRITE = 8,
		// Token: 0x04000940 RID: 2368
		OTAP_CLONE = 10,
		// Token: 0x04000941 RID: 2369
		BLUETOOTH_READ_WRITE = 16,
		// Token: 0x04000942 RID: 2370
		BLUETOOTH_CLONE = 32
	}
}
