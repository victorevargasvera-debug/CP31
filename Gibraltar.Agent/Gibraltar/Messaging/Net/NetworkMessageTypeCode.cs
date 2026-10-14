using System;

namespace Gibraltar.Messaging.Net
{
	// Token: 0x0200024A RID: 586
	internal enum NetworkMessageTypeCode
	{
		// Token: 0x04000AF0 RID: 2800
		Unknown,
		// Token: 0x04000AF1 RID: 2801
		LiveViewStartCommand,
		// Token: 0x04000AF2 RID: 2802
		LiveViewStopCommand,
		// Token: 0x04000AF3 RID: 2803
		SendSession,
		// Token: 0x04000AF4 RID: 2804
		SessionHeader,
		// Token: 0x04000AF5 RID: 2805
		GetSessionHeaders,
		// Token: 0x04000AF6 RID: 2806
		RegisterAnalystCommand,
		// Token: 0x04000AF7 RID: 2807
		RegisterAgentCommand,
		// Token: 0x04000AF8 RID: 2808
		SessionClosed,
		// Token: 0x04000AF9 RID: 2809
		PacketStreamStartCommand,
		// Token: 0x04000AFA RID: 2810
		ClockDrift
	}
}
