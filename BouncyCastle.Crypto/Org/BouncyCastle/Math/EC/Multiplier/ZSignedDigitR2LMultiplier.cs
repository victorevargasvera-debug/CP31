using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000239 RID: 569
	[global::System.Obsolete("Will be removed")]
	public class ZSignedDigitR2LMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x06001719 RID: 5913 RVA: 0x0007057C File Offset: 0x0006E77C
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint R0 = p.Curve.Infinity;
			int i = k.BitLength;
			int s = k.GetLowestSetBit();
			global::Org.BouncyCastle.Math.EC.ECPoint R = p.TimesPow2(s);
			int j = s;
			while (++j < i)
			{
				R0 = R0.Add(k.TestBit(j) ? R : R.Negate());
				R = R.Twice();
			}
			return R0.Add(R);
		}
	}
}
