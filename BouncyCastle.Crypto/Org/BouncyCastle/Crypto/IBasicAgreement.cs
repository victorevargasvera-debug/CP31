using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C4 RID: 708
	public interface IBasicAgreement
	{
		// Token: 0x06001F6C RID: 8044
		void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001F6D RID: 8045
		int GetFieldSize();

		// Token: 0x06001F6E RID: 8046
		global::Org.BouncyCastle.Math.BigInteger CalculateAgreement(global::Org.BouncyCastle.Crypto.ICipherParameters pubKey);
	}
}
