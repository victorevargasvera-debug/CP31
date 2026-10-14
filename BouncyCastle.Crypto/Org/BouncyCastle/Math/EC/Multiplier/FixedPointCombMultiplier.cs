using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000227 RID: 551
	public class FixedPointCombMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016C4 RID: 5828 RVA: 0x0006F594 File Offset: 0x0006D794
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = p.Curve;
			int size = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(curve);
			if (k.BitLength > size)
			{
				throw new global::System.InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
			}
			global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo info = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.Precompute(p);
			global::Org.BouncyCastle.Math.EC.ECLookupTable lookupTable = info.LookupTable;
			int width = info.Width;
			int d = (size + width - 1) / width;
			global::Org.BouncyCastle.Math.EC.ECPoint R = curve.Infinity;
			int num = d * width;
			uint[] K = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(num, k);
			int top = num - 1;
			for (int i = 0; i < d; i++)
			{
				uint secretIndex = 0U;
				for (int j = top - i; j >= 0; j -= d)
				{
					uint secretBit = K[j >> 5] >> j;
					secretIndex ^= secretBit >> 1;
					secretIndex <<= 1;
					secretIndex ^= secretBit;
				}
				global::Org.BouncyCastle.Math.EC.ECPoint add = lookupTable.Lookup((int)secretIndex);
				R = R.TwicePlus(add);
			}
			return R.Add(info.Offset);
		}
	}
}
