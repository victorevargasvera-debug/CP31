using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000233 RID: 563
	public class WNafL2RMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016E9 RID: 5865 RVA: 0x0006FA9C File Offset: 0x0006DC9C
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int minWidth = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(k.BitLength);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo wnafPreCompInfo = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(p, minWidth, true);
			global::Org.BouncyCastle.Math.EC.ECPoint[] preComp = wnafPreCompInfo.PreComp;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNeg = wnafPreCompInfo.PreCompNeg;
			int width = wnafPreCompInfo.Width;
			int[] wnaf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactWindowNaf(width, k);
			global::Org.BouncyCastle.Math.EC.ECPoint R = p.Curve.Infinity;
			int i = wnaf.Length;
			if (i > 1)
			{
				int num = wnaf[--i];
				int digit = num >> 16;
				int zeroes = num & 65535;
				int j = global::System.Math.Abs(digit);
				global::Org.BouncyCastle.Math.EC.ECPoint[] table = (digit < 0) ? preCompNeg : preComp;
				if (j << 2 < 1 << width)
				{
					int highest = 32 - global::Org.BouncyCastle.Utilities.Integers.NumberOfLeadingZeros(j);
					int scale = width - highest;
					int num2 = j ^ 1 << highest - 1;
					int i2 = (1 << width - 1) - 1;
					int i3 = (num2 << scale) + 1;
					R = table[i2 >> 1].Add(table[i3 >> 1]);
					zeroes -= scale;
				}
				else
				{
					R = table[j >> 1];
				}
				R = R.TimesPow2(zeroes);
			}
			while (i > 0)
			{
				int num3 = wnaf[--i];
				int digit2 = num3 >> 16;
				int zeroes2 = num3 & 65535;
				int l = global::System.Math.Abs(digit2);
				global::Org.BouncyCastle.Math.EC.ECPoint r = ((digit2 < 0) ? preCompNeg : preComp)[l >> 1];
				R = R.TwicePlus(r);
				R = R.TimesPow2(zeroes2);
			}
			return R;
		}
	}
}
