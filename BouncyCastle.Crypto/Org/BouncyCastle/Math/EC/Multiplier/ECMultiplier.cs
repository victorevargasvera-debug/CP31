using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000226 RID: 550
	public interface ECMultiplier
	{
		// Token: 0x060016C3 RID: 5827
		global::Org.BouncyCastle.Math.EC.ECPoint Multiply(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k);
	}
}
