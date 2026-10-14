using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000238 RID: 568
	[global::System.Obsolete("Will be removed")]
	public class ZSignedDigitL2RMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x06001717 RID: 5911 RVA: 0x0007051C File Offset: 0x0006E71C
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECPoint addP = p.Normalize();
			global::Org.BouncyCastle.Math.EC.ECPoint subP = addP.Negate();
			global::Org.BouncyCastle.Math.EC.ECPoint R0 = addP;
			int bitLength = k.BitLength;
			int s = k.GetLowestSetBit();
			int i = bitLength;
			while (--i > s)
			{
				R0 = R0.TwicePlus(k.TestBit(i) ? addP : subP);
			}
			return R0.TimesPow2(s);
		}
	}
}
