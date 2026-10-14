using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000229 RID: 553
	public class FixedPointUtilities
	{
		// Token: 0x060016CD RID: 5837 RVA: 0x0006F6B8 File Offset: 0x0006D8B8
		public static int GetCombSize(global::Org.BouncyCastle.Math.EC.ECCurve c)
		{
			global::Org.BouncyCastle.Math.BigInteger order = c.Order;
			if (order != null)
			{
				return order.BitLength;
			}
			return c.FieldSize + 1;
		}

		// Token: 0x060016CE RID: 5838 RVA: 0x0006F6DE File Offset: 0x0006D8DE
		public static global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo GetFixedPointPreCompInfo(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo preCompInfo)
		{
			return preCompInfo as global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo;
		}

		// Token: 0x060016CF RID: 5839 RVA: 0x0006F6E6 File Offset: 0x0006D8E6
		public static global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return (global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo)p.Curve.Precompute(p, global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.FixedPointCallback(p));
		}

		// Token: 0x040009D3 RID: 2515
		public static readonly string PRECOMP_NAME = "bc_fixed_point";

		// Token: 0x020007CD RID: 1997
		private class FixedPointCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004573 RID: 17779 RVA: 0x001335AF File Offset: 0x001317AF
			internal FixedPointCallback(global::Org.BouncyCastle.Math.EC.ECPoint p)
			{
				this.m_p = p;
			}

			// Token: 0x06004574 RID: 17780 RVA: 0x001335C0 File Offset: 0x001317C0
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo existingFP = (existing is global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo) ? ((global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo)existing) : null;
				global::Org.BouncyCastle.Math.EC.ECCurve c = this.m_p.Curve;
				int bits = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(c);
				int minWidth = (bits > 250) ? 6 : 5;
				int i = 1 << minWidth;
				if (this.CheckExisting(existingFP, i))
				{
					return existingFP;
				}
				int d = (bits + minWidth - 1) / minWidth;
				global::Org.BouncyCastle.Math.EC.ECPoint[] pow2Table = new global::Org.BouncyCastle.Math.EC.ECPoint[minWidth + 1];
				pow2Table[0] = this.m_p;
				for (int j = 1; j < minWidth; j++)
				{
					pow2Table[j] = pow2Table[j - 1].TimesPow2(d);
				}
				pow2Table[minWidth] = pow2Table[0].Subtract(pow2Table[1]);
				c.NormalizeAll(pow2Table);
				global::Org.BouncyCastle.Math.EC.ECPoint[] lookupTable = new global::Org.BouncyCastle.Math.EC.ECPoint[i];
				lookupTable[0] = pow2Table[0];
				for (int bit = minWidth - 1; bit >= 0; bit--)
				{
					global::Org.BouncyCastle.Math.EC.ECPoint pow2 = pow2Table[bit];
					int step = 1 << bit;
					for (int k = step; k < i; k += step << 1)
					{
						lookupTable[k] = lookupTable[k - step].Add(pow2);
					}
				}
				c.NormalizeAll(lookupTable);
				return new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo
				{
					LookupTable = c.CreateCacheSafeLookupTable(lookupTable, 0, lookupTable.Length),
					Offset = pow2Table[minWidth],
					Width = minWidth
				};
			}

			// Token: 0x06004575 RID: 17781 RVA: 0x001336FA File Offset: 0x001318FA
			private bool CheckExisting(global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo existingFP, int n)
			{
				return existingFP != null && this.CheckTable(existingFP.LookupTable, n);
			}

			// Token: 0x06004576 RID: 17782 RVA: 0x0013370E File Offset: 0x0013190E
			private bool CheckTable(global::Org.BouncyCastle.Math.EC.ECLookupTable table, int n)
			{
				return table != null && table.Size >= n;
			}

			// Token: 0x0400240C RID: 9228
			private readonly global::Org.BouncyCastle.Math.EC.ECPoint m_p;
		}
	}
}
