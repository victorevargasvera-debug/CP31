using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000AB RID: 171
	public interface DatagramSender
	{
		// Token: 0x06000690 RID: 1680
		int GetSendLimit();

		// Token: 0x06000691 RID: 1681
		void Send(byte[] buf, int off, int len);
	}
}
