using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x0200000C RID: 12
	public enum RUDPSockState
	{
		// Token: 0x04000069 RID: 105
		INIT,
		// Token: 0x0400006A RID: 106
		CLOSE_WAIT,
		// Token: 0x0400006B RID: 107
		CLOSE,
		// Token: 0x0400006C RID: 108
		OPEN,
		// Token: 0x0400006D RID: 109
		LISTEN,
		// Token: 0x0400006E RID: 110
		BIND,
		// Token: 0x0400006F RID: 111
		SYN_SENT,
		// Token: 0x04000070 RID: 112
		SYN_RCVD
	}
}
