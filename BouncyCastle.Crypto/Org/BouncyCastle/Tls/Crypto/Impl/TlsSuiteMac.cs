using System;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x02000163 RID: 355
	public interface TlsSuiteMac
	{
		// Token: 0x170001FF RID: 511
		// (get) Token: 0x06000DD6 RID: 3542
		int Size { get; }

		// Token: 0x06000DD7 RID: 3543
		byte[] CalculateMac(long seqNo, short type, byte[] message, int offset, int length);

		// Token: 0x06000DD8 RID: 3544
		byte[] CalculateMacConstantTime(long seqNo, short type, byte[] message, int offset, int length, int expectedLength, byte[] randomData);
	}
}
