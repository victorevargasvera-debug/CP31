using System;

namespace Motorola.Common.Communication.RUDP
{
	// Token: 0x02000019 RID: 25
	public enum RUDPReplyResult
	{
		// Token: 0x040000A6 RID: 166
		RUDPReply_Success,
		// Token: 0x040000A7 RID: 167
		RUDPReply_Isconnected,
		// Token: 0x040000A8 RID: 168
		RUDPReply_Connecting,
		// Token: 0x040000A9 RID: 169
		RUDPReply_ConnectFail,
		// Token: 0x040000AA RID: 170
		RUDPReply_ServerRefusedConnection,
		// Token: 0x040000AB RID: 171
		RUDPReply_Uninitialized,
		// Token: 0x040000AC RID: 172
		RUDPReply_SendFailed,
		// Token: 0x040000AD RID: 173
		RUDPReply_SendTimeout,
		// Token: 0x040000AE RID: 174
		RUDPReply_ReceiveFailed,
		// Token: 0x040000AF RID: 175
		RUDPReply_ReceiveTimeout,
		// Token: 0x040000B0 RID: 176
		RUDPReply_CloseFail,
		// Token: 0x040000B1 RID: 177
		RUDPReply_CloseInProgress
	}
}
