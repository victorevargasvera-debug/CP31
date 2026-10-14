using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200014C RID: 332
	public interface TlsMac
	{
		// Token: 0x06000D3B RID: 3387
		void SetKey(byte[] key, int keyOff, int keyLen);

		// Token: 0x06000D3C RID: 3388
		void Update(byte[] input, int inOff, int length);

		// Token: 0x06000D3D RID: 3389
		byte[] CalculateMac();

		// Token: 0x06000D3E RID: 3390
		void CalculateMac(byte[] output, int outOff);

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x06000D3F RID: 3391
		int MacLength { get; }

		// Token: 0x06000D40 RID: 3392
		void Reset();
	}
}
