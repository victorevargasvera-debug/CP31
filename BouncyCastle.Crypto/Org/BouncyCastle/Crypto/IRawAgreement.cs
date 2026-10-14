using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DB RID: 731
	public interface IRawAgreement
	{
		// Token: 0x06001FB8 RID: 8120
		void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x1700045F RID: 1119
		// (get) Token: 0x06001FB9 RID: 8121
		int AgreementSize { get; }

		// Token: 0x06001FBA RID: 8122
		void CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters publicKey, byte[] buf, int off);
	}
}
