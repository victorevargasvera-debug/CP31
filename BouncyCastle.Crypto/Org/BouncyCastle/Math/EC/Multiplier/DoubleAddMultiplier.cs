using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000225 RID: 549
	[global::System.Obsolete("Will be removed")]
	public class DoubleAddMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016C1 RID: 5825 RVA: 0x0006F52C File Offset: 0x0006D72C
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint[] R = new global::Org.BouncyCastle.Math.EC.ECPoint[]
			{
				p.Curve.Infinity,
				p
			};
			int i = k.BitLength;
			for (int j = 0; j < i; j++)
			{
				int b = k.TestBit(j) ? 1 : 0;
				int bp = 1 - b;
				R[bp] = R[bp].TwicePlus(R[b]);
			}
			return R[0];
		}
	}
}
