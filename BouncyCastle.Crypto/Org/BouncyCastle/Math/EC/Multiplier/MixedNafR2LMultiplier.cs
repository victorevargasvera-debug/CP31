using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200022C RID: 556
	[global::System.Obsolete("Will be removed")]
	public class MixedNafR2LMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016D5 RID: 5845 RVA: 0x0006F7C9 File Offset: 0x0006D9C9
		public MixedNafR2LMultiplier() : this(2, 4)
		{
		}

		// Token: 0x060016D6 RID: 5846 RVA: 0x0006F7D3 File Offset: 0x0006D9D3
		public MixedNafR2LMultiplier(int additionCoord, int doublingCoord)
		{
			this.additionCoord = additionCoord;
			this.doublingCoord = doublingCoord;
		}

		// Token: 0x060016D7 RID: 5847 RVA: 0x0006F7EC File Offset: 0x0006D9EC
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curveOrig = p.Curve;
			global::Org.BouncyCastle.Math.EC.ECCurve curveAdd = this.ConfigureCurve(curveOrig, this.additionCoord);
			global::Org.BouncyCastle.Math.EC.ECCurve eccurve = this.ConfigureCurve(curveOrig, this.doublingCoord);
			int[] naf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateCompactNaf(k);
			global::Org.BouncyCastle.Math.EC.ECPoint Ra = curveAdd.Infinity;
			global::Org.BouncyCastle.Math.EC.ECPoint Td = eccurve.ImportPoint(p);
			int zeroes = 0;
			foreach (int ni in naf)
			{
				int num = ni >> 16;
				zeroes += (ni & 65535);
				Td = Td.TimesPow2(zeroes);
				global::Org.BouncyCastle.Math.EC.ECPoint Tj = curveAdd.ImportPoint(Td);
				if (num < 0)
				{
					Tj = Tj.Negate();
				}
				Ra = Ra.Add(Tj);
				zeroes = 1;
			}
			return curveOrig.ImportPoint(Ra);
		}

		// Token: 0x060016D8 RID: 5848 RVA: 0x0006F894 File Offset: 0x0006DA94
		protected virtual global::Org.BouncyCastle.Math.EC.ECCurve ConfigureCurve(global::Org.BouncyCastle.Math.EC.ECCurve c, int coord)
		{
			if (c.CoordinateSystem == coord)
			{
				return c;
			}
			if (!c.SupportsCoordinateSystem(coord))
			{
				throw new global::System.ArgumentException("Coordinate system " + coord.ToString() + " not supported by this curve", "coord");
			}
			return c.Configure().SetCoordinateSystem(coord).Create();
		}

		// Token: 0x040009D6 RID: 2518
		protected readonly int additionCoord;

		// Token: 0x040009D7 RID: 2519
		protected readonly int doublingCoord;
	}
}
