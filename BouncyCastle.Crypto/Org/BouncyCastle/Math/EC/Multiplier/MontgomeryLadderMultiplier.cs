using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200022D RID: 557
	[global::System.Obsolete("Will be removed")]
	public class MontgomeryLadderMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016D9 RID: 5849 RVA: 0x0006F8E8 File Offset: 0x0006DAE8
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint[] R = new global::Org.BouncyCastle.Math.EC.ECPoint[]
			{
				p.Curve.Infinity,
				p
			};
			int i = k.BitLength;
			while (--i >= 0)
			{
				int b = k.TestBit(i) ? 1 : 0;
				int bp = 1 - b;
				R[bp] = R[bp].Add(R[b]);
				R[b] = R[b].Twice();
			}
			return R[0];
		}
	}
}
