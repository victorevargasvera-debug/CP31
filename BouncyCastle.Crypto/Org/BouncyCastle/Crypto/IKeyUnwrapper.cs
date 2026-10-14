using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D5 RID: 725
	public interface IKeyUnwrapper
	{
		// Token: 0x1700045B RID: 1115
		// (get) Token: 0x06001FA7 RID: 8103
		object AlgorithmDetails { get; }

		// Token: 0x06001FA8 RID: 8104
		global::Org.BouncyCastle.Crypto.IBlockResult Unwrap(byte[] cipherText, int offset, int length);
	}
}
