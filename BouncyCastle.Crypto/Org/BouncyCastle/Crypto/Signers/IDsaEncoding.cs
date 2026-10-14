using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Signers
{
	// Token: 0x020003A5 RID: 933
	public interface IDsaEncoding
	{
		// Token: 0x06002602 RID: 9730
		global::Org.BouncyCastle.Math.BigInteger[] Decode(global::Org.BouncyCastle.Math.BigInteger n, byte[] encoding);

		// Token: 0x06002603 RID: 9731
		byte[] Encode(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s);
	}
}
