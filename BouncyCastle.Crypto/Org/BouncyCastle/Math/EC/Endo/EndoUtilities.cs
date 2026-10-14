using System;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023C RID: 572
	public abstract class EndoUtilities
	{
		// Token: 0x06001722 RID: 5922 RVA: 0x00070618 File Offset: 0x0006E818
		public static global::Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int bits = p.Bits;
			global::Org.BouncyCastle.Math.BigInteger b = global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.CalculateB(k, p.G1, bits);
			global::Org.BouncyCastle.Math.BigInteger b2 = global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.CalculateB(k, p.G2, bits);
			global::Org.BouncyCastle.Math.BigInteger a = k.Subtract(b.Multiply(p.V1A).Add(b2.Multiply(p.V2A)));
			global::Org.BouncyCastle.Math.BigInteger b3 = b.Multiply(p.V1B).Add(b2.Multiply(p.V2B)).Negate();
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				a,
				b3
			};
		}

		// Token: 0x06001723 RID: 5923 RVA: 0x0007069F File Offset: 0x0006E89F
		public static global::Org.BouncyCastle.Math.EC.ECPoint MapPoint(global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism, global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return ((global::Org.BouncyCastle.Math.EC.Endo.EndoPreCompInfo)p.Curve.Precompute(p, global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.PRECOMP_NAME, new global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.MapPointCallback(endomorphism, p))).MappedPoint;
		}

		// Token: 0x06001724 RID: 5924 RVA: 0x000706C4 File Offset: 0x0006E8C4
		private static global::Org.BouncyCastle.Math.BigInteger CalculateB(global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.BigInteger g, int t)
		{
			bool flag = g.SignValue < 0;
			global::Org.BouncyCastle.Math.BigInteger b = k.Multiply(g.Abs());
			bool flag2 = b.TestBit(t - 1);
			b = b.ShiftRight(t);
			if (flag2)
			{
				b = b.Add(global::Org.BouncyCastle.Math.BigInteger.One);
			}
			if (!flag)
			{
				return b;
			}
			return b.Negate();
		}

		// Token: 0x040009EA RID: 2538
		public static readonly string PRECOMP_NAME = "bc_endo";

		// Token: 0x020007D3 RID: 2003
		private class MapPointCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004585 RID: 17797 RVA: 0x00133D4C File Offset: 0x00131F4C
			internal MapPointCallback(global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism, global::Org.BouncyCastle.Math.EC.ECPoint point)
			{
				this.m_endomorphism = endomorphism;
				this.m_point = point;
			}

			// Token: 0x06004586 RID: 17798 RVA: 0x00133D64 File Offset: 0x00131F64
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Endo.EndoPreCompInfo existingEndo = existing as global::Org.BouncyCastle.Math.EC.Endo.EndoPreCompInfo;
				if (this.CheckExisting(existingEndo, this.m_endomorphism))
				{
					return existingEndo;
				}
				global::Org.BouncyCastle.Math.EC.ECPoint mappedPoint = this.m_endomorphism.PointMap.Map(this.m_point);
				return new global::Org.BouncyCastle.Math.EC.Endo.EndoPreCompInfo
				{
					Endomorphism = this.m_endomorphism,
					MappedPoint = mappedPoint
				};
			}

			// Token: 0x06004587 RID: 17799 RVA: 0x00133DB8 File Offset: 0x00131FB8
			private bool CheckExisting(global::Org.BouncyCastle.Math.EC.Endo.EndoPreCompInfo existingEndo, global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism)
			{
				return existingEndo != null && existingEndo.Endomorphism == endomorphism && existingEndo.MappedPoint != null;
			}

			// Token: 0x0400241B RID: 9243
			private readonly global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism;

			// Token: 0x0400241C RID: 9244
			private readonly global::Org.BouncyCastle.Math.EC.ECPoint m_point;
		}
	}
}
