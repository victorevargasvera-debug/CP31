using System;

namespace Org.BouncyCastle.Crypto.Prng.Drbg
{
	// Token: 0x020003C4 RID: 964
	public interface ISP80090Drbg
	{
		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x060026F5 RID: 9973
		int BlockSize { get; }

		// Token: 0x060026F6 RID: 9974
		int Generate(byte[] output, byte[] additionalInput, bool predictionResistant);

		// Token: 0x060026F7 RID: 9975
		void Reseed(byte[] additionalInput);
	}
}
