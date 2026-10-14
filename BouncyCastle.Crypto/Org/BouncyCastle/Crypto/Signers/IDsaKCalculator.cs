using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A6 RID: 934
	public interface IDsaKCalculator
	{
		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06002604 RID: 9732
		bool IsDeterministic { get; }

		// Token: 0x06002605 RID: 9733
		void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Security.SecureRandom random);

		// Token: 0x06002606 RID: 9734
		void Init(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger d, byte[] message);

		// Token: 0x06002607 RID: 9735
		global::Org.BouncyCastle.Math.BigInteger NextK();
	}
}
