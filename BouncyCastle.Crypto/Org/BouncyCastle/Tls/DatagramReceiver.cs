using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000AA RID: 170
	public interface DatagramReceiver
	{
		// Token: 0x0600068E RID: 1678
		int GetReceiveLimit();

		// Token: 0x0600068F RID: 1679
		int Receive(byte[] buf, int off, int len, int waitMillis);
	}
}
