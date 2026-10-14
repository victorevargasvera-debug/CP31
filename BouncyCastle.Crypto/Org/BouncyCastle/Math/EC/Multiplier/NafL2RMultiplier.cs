using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200022E RID: 558
	[global::System.Obsolete("Will be removed")]
	public class NafL2RMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016DB RID: 5851 RVA: 0x0006F958 File Offset: 0x0006DB58
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int[] naf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactNaf(k);
			global::Org.BouncyCastle.Math.EC.ECPoint addP = p.Normalize();
			global::Org.BouncyCastle.Math.EC.ECPoint subP = addP.Negate();
			global::Org.BouncyCastle.Math.EC.ECPoint R = p.Curve.Infinity;
			int i = naf.Length;
			while (--i >= 0)
			{
				int num = naf[i];
				int digit = num >> 16;
				int zeroes = num & 65535;
				R = R.TwicePlus((digit < 0) ? subP : addP);
				R = R.TimesPow2(zeroes);
			}
			return R;
		}
	}
}
