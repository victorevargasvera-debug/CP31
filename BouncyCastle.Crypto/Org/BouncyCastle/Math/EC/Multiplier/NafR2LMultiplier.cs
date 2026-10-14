using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200022F RID: 559
	[global::System.Obsolete("Will be removed")]
	public class NafR2LMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016DD RID: 5853 RVA: 0x0006F9CC File Offset: 0x0006DBCC
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int[] naf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactNaf(k);
			global::Org.BouncyCastle.Math.EC.ECPoint R0 = p.Curve.Infinity;
			global::Org.BouncyCastle.Math.EC.ECPoint R = p;
			int zeroes = 0;
			foreach (int ni in naf)
			{
				int digit = ni >> 16;
				zeroes += (ni & 65535);
				R = R.TimesPow2(zeroes);
				R0 = R0.Add((digit < 0) ? R.Negate() : R);
				zeroes = 1;
			}
			return R0;
		}
	}
}
