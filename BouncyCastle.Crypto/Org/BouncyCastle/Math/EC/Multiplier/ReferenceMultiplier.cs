using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000231 RID: 561
	[global::System.Obsolete("Will be removed")]
	public class ReferenceMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016DF RID: 5855 RVA: 0x0006FA42 File Offset: 0x0006DC42
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ReferenceMultiply(p, k);
		}
	}
}
