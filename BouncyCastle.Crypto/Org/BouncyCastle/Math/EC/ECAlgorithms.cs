using System;
using Org.BouncyCastle.Math.EC.Endo;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000205 RID: 517
	public class ECAlgorithms
	{
		// Token: 0x0600143A RID: 5178 RVA: 0x0005F702 File Offset: 0x0005D902
		public static bool IsF2mCurve(global::Org.BouncyCastle.Math.EC.ECCurve c)
		{
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsF2mField(c.Field);
		}

		// Token: 0x0600143B RID: 5179 RVA: 0x0005F70F File Offset: 0x0005D90F
		public static bool IsF2mField(global::Org.BouncyCastle.Math.Field.IFiniteField field)
		{
			return field.Dimension > 1 && field.Characteristic.Equals(global::Org.BouncyCastle.Math.BigInteger.Two) && field is global::Org.BouncyCastle.Math.Field.IPolynomialExtensionField;
		}

		// Token: 0x0600143C RID: 5180 RVA: 0x0005F737 File Offset: 0x0005D937
		public static bool IsFpCurve(global::Org.BouncyCastle.Math.EC.ECCurve c)
		{
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.IsFpField(c.Field);
		}

		// Token: 0x0600143D RID: 5181 RVA: 0x0005F744 File Offset: 0x0005D944
		public static bool IsFpField(global::Org.BouncyCastle.Math.Field.IFiniteField field)
		{
			return field.Dimension == 1;
		}

		// Token: 0x0600143E RID: 5182 RVA: 0x0005F750 File Offset: 0x0005D950
		public static global::Org.BouncyCastle.Math.EC.ECPoint SumOfMultiplies(global::Org.BouncyCastle.Math.EC.ECPoint[] ps, global::Org.BouncyCastle.Math.BigInteger[] ks)
		{
			if (ps == null || ks == null || ps.Length != ks.Length || ps.Length < 1)
			{
				throw new global::System.ArgumentException("point and scalar arrays should be non-null, and of equal, non-zero, length");
			}
			int count = ps.Length;
			if (count == 1)
			{
				return ps[0].Multiply(ks[0]);
			}
			if (count == 2)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.SumOfTwoMultiplies(ps[0], ks[0], ps[1], ks[1]);
			}
			global::Org.BouncyCastle.Math.EC.ECPoint p = ps[0];
			global::Org.BouncyCastle.Math.EC.ECCurve c = p.Curve;
			global::Org.BouncyCastle.Math.EC.ECPoint[] imported = new global::Org.BouncyCastle.Math.EC.ECPoint[count];
			imported[0] = p;
			for (int i = 1; i < count; i++)
			{
				imported[i] = global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(c, ps[i]);
			}
			global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism = c.GetEndomorphism() as global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism;
			if (glvEndomorphism != null)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultipliesGlv(imported, ks, glvEndomorphism));
			}
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(imported, ks));
		}

		// Token: 0x0600143F RID: 5183 RVA: 0x0005F808 File Offset: 0x0005DA08
		public static global::Org.BouncyCastle.Math.EC.ECPoint SumOfTwoMultiplies(global::Org.BouncyCastle.Math.EC.ECPoint P, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.EC.ECPoint Q, global::Org.BouncyCastle.Math.BigInteger b)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve cp = P.Curve;
			Q = global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(cp, Q);
			global::Org.BouncyCastle.Math.EC.AbstractF2mCurve f2mCurve = cp as global::Org.BouncyCastle.Math.EC.AbstractF2mCurve;
			if (f2mCurve != null && f2mCurve.IsKoblitz)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(P.Multiply(a).Add(Q.Multiply(b)));
			}
			global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism = cp.GetEndomorphism() as global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism;
			if (glvEndomorphism != null)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultipliesGlv(new global::Org.BouncyCastle.Math.EC.ECPoint[]
				{
					P,
					Q
				}, new global::Org.BouncyCastle.Math.BigInteger[]
				{
					a,
					b
				}, glvEndomorphism));
			}
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(P, a, Q, b));
		}

		// Token: 0x06001440 RID: 5184 RVA: 0x0005F895 File Offset: 0x0005DA95
		public static global::Org.BouncyCastle.Math.EC.ECPoint ShamirsTrick(global::Org.BouncyCastle.Math.EC.ECPoint P, global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.EC.ECPoint Q, global::Org.BouncyCastle.Math.BigInteger l)
		{
			Q = global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(P.Curve, Q);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickJsf(P, k, Q, l));
		}

		// Token: 0x06001441 RID: 5185 RVA: 0x0005F8B4 File Offset: 0x0005DAB4
		public static global::Org.BouncyCastle.Math.EC.ECPoint ImportPoint(global::Org.BouncyCastle.Math.EC.ECCurve c, global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve cp = p.Curve;
			if (!c.Equals(cp))
			{
				throw new global::System.ArgumentException("Point must be on the same curve");
			}
			return c.ImportPoint(p);
		}

		// Token: 0x06001442 RID: 5186 RVA: 0x0005F8E3 File Offset: 0x0005DAE3
		public static void MontgomeryTrick(global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, int off, int len)
		{
			global::Org.BouncyCastle.Math.EC.ECAlgorithms.MontgomeryTrick(zs, off, len, null);
		}

		// Token: 0x06001443 RID: 5187 RVA: 0x0005F8F0 File Offset: 0x0005DAF0
		public static void MontgomeryTrick(global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, int off, int len, global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement[] c = new global::Org.BouncyCastle.Math.EC.ECFieldElement[len];
			c[0] = zs[off];
			int i = 0;
			while (++i < len)
			{
				c[i] = c[i - 1].Multiply(zs[off + i]);
			}
			i--;
			if (scale != null)
			{
				c[i] = c[i].Multiply(scale);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement u = c[i].Invert();
			while (i > 0)
			{
				int j = off + i--;
				global::Org.BouncyCastle.Math.EC.ECFieldElement tmp = zs[j];
				zs[j] = c[i].Multiply(u);
				u = u.Multiply(tmp);
			}
			zs[off] = u;
		}

		// Token: 0x06001444 RID: 5188 RVA: 0x0005F970 File Offset: 0x0005DB70
		public static global::Org.BouncyCastle.Math.EC.ECPoint ReferenceMultiply(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.BigInteger x = k.Abs();
			global::Org.BouncyCastle.Math.EC.ECPoint q = p.Curve.Infinity;
			int t = x.BitLength;
			if (t > 0)
			{
				if (x.TestBit(0))
				{
					q = p;
				}
				for (int i = 1; i < t; i++)
				{
					p = p.Twice();
					if (x.TestBit(i))
					{
						q = q.Add(p);
					}
				}
			}
			if (k.SignValue >= 0)
			{
				return q;
			}
			return q.Negate();
		}

		// Token: 0x06001445 RID: 5189 RVA: 0x0005F9DC File Offset: 0x0005DBDC
		public static global::Org.BouncyCastle.Math.EC.ECPoint ValidatePoint(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			if (!p.IsValid())
			{
				throw new global::System.InvalidOperationException("Invalid point");
			}
			return p;
		}

		// Token: 0x06001446 RID: 5190 RVA: 0x0005F9F4 File Offset: 0x0005DBF4
		public static global::Org.BouncyCastle.Math.EC.ECPoint CleanPoint(global::Org.BouncyCastle.Math.EC.ECCurve c, global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve cp = p.Curve;
			if (!c.Equals(cp))
			{
				throw new global::System.ArgumentException("Point must be on the same curve", "p");
			}
			return c.DecodePoint(p.GetEncoded(false));
		}

		// Token: 0x06001447 RID: 5191 RVA: 0x0005FA2E File Offset: 0x0005DC2E
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplCheckResult(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			if (!p.IsValidPartial())
			{
				throw new global::System.InvalidOperationException("Invalid result");
			}
			return p;
		}

		// Token: 0x06001448 RID: 5192 RVA: 0x0005FA44 File Offset: 0x0005DC44
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickJsf(global::Org.BouncyCastle.Math.EC.ECPoint P, global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.EC.ECPoint Q, global::Org.BouncyCastle.Math.BigInteger l)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = P.Curve;
			global::Org.BouncyCastle.Math.EC.ECPoint infinity = curve.Infinity;
			global::Org.BouncyCastle.Math.EC.ECPoint PaddQ = P.Add(Q);
			global::Org.BouncyCastle.Math.EC.ECPoint PsubQ = P.Subtract(Q);
			global::Org.BouncyCastle.Math.EC.ECPoint[] points = new global::Org.BouncyCastle.Math.EC.ECPoint[]
			{
				Q,
				PsubQ,
				P,
				PaddQ
			};
			curve.NormalizeAll(points);
			global::Org.BouncyCastle.Math.EC.ECPoint[] table = new global::Org.BouncyCastle.Math.EC.ECPoint[]
			{
				points[3].Negate(),
				points[2].Negate(),
				points[1].Negate(),
				points[0].Negate(),
				infinity,
				points[0],
				points[1],
				points[2],
				points[3]
			};
			byte[] jsf = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateJsf(k, l);
			global::Org.BouncyCastle.Math.EC.ECPoint R = infinity;
			int i = jsf.Length;
			while (--i >= 0)
			{
				byte b = jsf[i];
				int kDigit = b << 24 >> 28;
				int lDigit = b << 28 >> 28;
				int index = 4 + kDigit * 3 + lDigit;
				R = R.TwicePlus(table[index]);
			}
			return R;
		}

		// Token: 0x06001449 RID: 5193 RVA: 0x0005FB38 File Offset: 0x0005DD38
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(global::Org.BouncyCastle.Math.EC.ECPoint P, global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.EC.ECPoint Q, global::Org.BouncyCastle.Math.BigInteger l)
		{
			bool negK = k.SignValue < 0;
			bool negL = l.SignValue < 0;
			global::Org.BouncyCastle.Math.BigInteger kAbs = k.Abs();
			global::Org.BouncyCastle.Math.BigInteger lAbs = l.Abs();
			int minWidthP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(kAbs.BitLength, 8);
			int minWidthQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(lAbs.BitLength, 8);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(P, minWidthP, true);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(Q, minWidthQ, true);
			int combSize = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(P.Curve);
			if (!negK && !negL && k.BitLength <= combSize && l.BitLength <= combSize && infoP.IsPromoted && infoQ.IsPromoted)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickFixedPoint(P, k, Q, l);
			}
			int widthP = global::System.Math.Min(8, infoP.Width);
			int width = global::System.Math.Min(8, infoQ.Width);
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompP = negK ? infoP.PreCompNeg : infoP.PreComp;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompQ = negL ? infoQ.PreCompNeg : infoQ.PreComp;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegP = negK ? infoP.PreComp : infoP.PreCompNeg;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegQ = negL ? infoQ.PreComp : infoQ.PreCompNeg;
			byte[] wnafP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(widthP, kAbs);
			byte[] wnafQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width, lAbs);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(preCompP, preCompNegP, wnafP, preCompQ, preCompNegQ, wnafQ);
		}

		// Token: 0x0600144A RID: 5194 RVA: 0x0005FC70 File Offset: 0x0005DE70
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism, global::Org.BouncyCastle.Math.EC.ECPoint P, global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.BigInteger l)
		{
			bool negK = k.SignValue < 0;
			bool negL = l.SignValue < 0;
			k = k.Abs();
			l = l.Abs();
			int minWidth = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(global::System.Math.Max(k.BitLength, l.BitLength), 8);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(P, minWidth, true);
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PrecomputeWithPointMap(global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.MapPoint(endomorphism, P), endomorphism.PointMap, infoP, true);
			int widthP = global::System.Math.Min(8, infoP.Width);
			int width = global::System.Math.Min(8, infoQ.Width);
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompP = negK ? infoP.PreCompNeg : infoP.PreComp;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompQ = negL ? infoQ.PreCompNeg : infoQ.PreComp;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegP = negK ? infoP.PreComp : infoP.PreCompNeg;
			global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegQ = negL ? infoQ.PreComp : infoQ.PreCompNeg;
			byte[] wnafP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(widthP, k);
			byte[] wnafQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width, l);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(preCompP, preCompNegP, wnafP, preCompQ, preCompNegQ, wnafQ);
		}

		// Token: 0x0600144B RID: 5195 RVA: 0x0005FD68 File Offset: 0x0005DF68
		private static global::Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickWNaf(global::Org.BouncyCastle.Math.EC.ECPoint[] preCompP, global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegP, byte[] wnafP, global::Org.BouncyCastle.Math.EC.ECPoint[] preCompQ, global::Org.BouncyCastle.Math.EC.ECPoint[] preCompNegQ, byte[] wnafQ)
		{
			int num = global::System.Math.Max(wnafP.Length, wnafQ.Length);
			global::Org.BouncyCastle.Math.EC.ECPoint infinity = preCompP[0].Curve.Infinity;
			global::Org.BouncyCastle.Math.EC.ECPoint R = infinity;
			int zeroes = 0;
			for (int i = num - 1; i >= 0; i--)
			{
				int wiP = (int)((i < wnafP.Length) ? ((sbyte)wnafP[i]) : 0);
				int wiQ = (int)((i < wnafQ.Length) ? ((sbyte)wnafQ[i]) : 0);
				if ((wiP | wiQ) == 0)
				{
					zeroes++;
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.ECPoint r = infinity;
					if (wiP != 0)
					{
						int nP = global::System.Math.Abs(wiP);
						global::Org.BouncyCastle.Math.EC.ECPoint[] tableP = (wiP < 0) ? preCompNegP : preCompP;
						r = r.Add(tableP[nP >> 1]);
					}
					if (wiQ != 0)
					{
						int nQ = global::System.Math.Abs(wiQ);
						global::Org.BouncyCastle.Math.EC.ECPoint[] tableQ = (wiQ < 0) ? preCompNegQ : preCompQ;
						r = r.Add(tableQ[nQ >> 1]);
					}
					if (zeroes > 0)
					{
						R = R.TimesPow2(zeroes);
						zeroes = 0;
					}
					R = R.TwicePlus(r);
				}
			}
			if (zeroes > 0)
			{
				R = R.TimesPow2(zeroes);
			}
			return R;
		}

		// Token: 0x0600144C RID: 5196 RVA: 0x0005FE4C File Offset: 0x0005E04C
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(global::Org.BouncyCastle.Math.EC.ECPoint[] ps, global::Org.BouncyCastle.Math.BigInteger[] ks)
		{
			int count = ps.Length;
			bool[] negs = new bool[count];
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] infos = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[count];
			byte[][] wnafs = new byte[count][];
			for (int i = 0; i < count; i++)
			{
				global::Org.BouncyCastle.Math.BigInteger ki = ks[i];
				negs[i] = (ki.SignValue < 0);
				ki = ki.Abs();
				int minWidth = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(ki.BitLength, 8);
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo info = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(ps[i], minWidth, true);
				int width = global::System.Math.Min(8, info.Width);
				infos[i] = info;
				wnafs[i] = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(width, ki);
			}
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs, infos, wnafs);
		}

		// Token: 0x0600144D RID: 5197 RVA: 0x0005FEE8 File Offset: 0x0005E0E8
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultipliesGlv(global::Org.BouncyCastle.Math.EC.ECPoint[] ps, global::Org.BouncyCastle.Math.BigInteger[] ks, global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism)
		{
			global::Org.BouncyCastle.Math.BigInteger i = ps[0].Curve.Order;
			int len = ps.Length;
			global::Org.BouncyCastle.Math.BigInteger[] abs = new global::Org.BouncyCastle.Math.BigInteger[len << 1];
			int j = 0;
			int k = 0;
			while (j < len)
			{
				global::Org.BouncyCastle.Math.BigInteger[] ab = glvEndomorphism.DecomposeScalar(ks[j].Mod(i));
				abs[k++] = ab[0];
				abs[k++] = ab[1];
				j++;
			}
			if (glvEndomorphism.HasEfficientPointMap)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(glvEndomorphism, ps, abs);
			}
			global::Org.BouncyCastle.Math.EC.ECPoint[] pqs = new global::Org.BouncyCastle.Math.EC.ECPoint[len << 1];
			int l = 0;
			int m = 0;
			while (l < len)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint p = ps[l];
				global::Org.BouncyCastle.Math.EC.ECPoint q = global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.MapPoint(glvEndomorphism, p);
				pqs[m++] = p;
				pqs[m++] = q;
				l++;
			}
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(pqs, abs);
		}

		// Token: 0x0600144E RID: 5198 RVA: 0x0005FFAC File Offset: 0x0005E1AC
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism endomorphism, global::Org.BouncyCastle.Math.EC.ECPoint[] ps, global::Org.BouncyCastle.Math.BigInteger[] ks)
		{
			int halfCount = ps.Length;
			int num = halfCount << 1;
			bool[] negs = new bool[num];
			global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] infos = new global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[num];
			byte[][] wnafs = new byte[num][];
			global::Org.BouncyCastle.Math.EC.ECPointMap pointMap = endomorphism.PointMap;
			for (int i = 0; i < halfCount; i++)
			{
				int j0 = i << 1;
				int j = j0 + 1;
				global::Org.BouncyCastle.Math.BigInteger kj0 = ks[j0];
				negs[j0] = (kj0.SignValue < 0);
				kj0 = kj0.Abs();
				global::Org.BouncyCastle.Math.BigInteger kj = ks[j];
				negs[j] = (kj.SignValue < 0);
				kj = kj.Abs();
				int minWidth = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GetWindowSize(global::System.Math.Max(kj0.BitLength, kj.BitLength), 8);
				global::Org.BouncyCastle.Math.EC.ECPoint P = ps[i];
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoP = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.Precompute(P, minWidth, true);
				global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo infoQ = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.PrecomputeWithPointMap(global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.MapPoint(endomorphism, P), pointMap, infoP, true);
				int widthP = global::System.Math.Min(8, infoP.Width);
				int widthQ = global::System.Math.Min(8, infoQ.Width);
				infos[j0] = infoP;
				infos[j] = infoQ;
				wnafs[j0] = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(widthP, kj0);
				wnafs[j] = global::Org.BouncyCastle.Math.EC.Multiplier.WNafUtilities.GenerateWindowNaf(widthQ, kj);
			}
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplSumOfMultiplies(negs, infos, wnafs);
		}

		// Token: 0x0600144F RID: 5199 RVA: 0x000600C8 File Offset: 0x0005E2C8
		private static global::Org.BouncyCastle.Math.EC.ECPoint ImplSumOfMultiplies(bool[] negs, global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo[] infos, byte[][] wnafs)
		{
			int len = 0;
			int count = wnafs.Length;
			for (int i = 0; i < count; i++)
			{
				len = global::System.Math.Max(len, wnafs[i].Length);
			}
			global::Org.BouncyCastle.Math.EC.ECPoint infinity = infos[0].PreComp[0].Curve.Infinity;
			global::Org.BouncyCastle.Math.EC.ECPoint R = infinity;
			int zeroes = 0;
			for (int j = len - 1; j >= 0; j--)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint r = infinity;
				for (int k = 0; k < count; k++)
				{
					byte[] wnaf = wnafs[k];
					int wi = (int)((j < wnaf.Length) ? ((sbyte)wnaf[j]) : 0);
					if (wi != 0)
					{
						int l = global::System.Math.Abs(wi);
						global::Org.BouncyCastle.Math.EC.Multiplier.WNafPreCompInfo info = infos[k];
						global::Org.BouncyCastle.Math.EC.ECPoint[] table = (wi < 0 == negs[k]) ? info.PreComp : info.PreCompNeg;
						r = r.Add(table[l >> 1]);
					}
				}
				if (r == infinity)
				{
					zeroes++;
				}
				else
				{
					if (zeroes > 0)
					{
						R = R.TimesPow2(zeroes);
						zeroes = 0;
					}
					R = R.TwicePlus(r);
				}
			}
			if (zeroes > 0)
			{
				R = R.TimesPow2(zeroes);
			}
			return R;
		}

		// Token: 0x06001450 RID: 5200 RVA: 0x000601CC File Offset: 0x0005E3CC
		private static global::Org.BouncyCastle.Math.EC.ECPoint ImplShamirsTrickFixedPoint(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.EC.ECPoint q, global::Org.BouncyCastle.Math.BigInteger l)
		{
			global::Org.BouncyCastle.Math.EC.ECCurve c = p.Curve;
			int combSize = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.GetCombSize(c);
			if (k.BitLength > combSize || l.BitLength > combSize)
			{
				throw new global::System.InvalidOperationException("fixed-point comb doesn't support scalars larger than the curve order");
			}
			global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo infoP = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.Precompute(p);
			global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointPreCompInfo infoQ = global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointUtilities.Precompute(q);
			global::Org.BouncyCastle.Math.EC.ECLookupTable lookupTableP = infoP.LookupTable;
			global::Org.BouncyCastle.Math.EC.ECLookupTable lookupTableQ = infoQ.LookupTable;
			int widthP = infoP.Width;
			int widthQ = infoQ.Width;
			if (widthP != widthQ)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier fixedPointCombMultiplier = new global::Org.BouncyCastle.Math.EC.Multiplier.FixedPointCombMultiplier();
				global::Org.BouncyCastle.Math.EC.ECPoint r = fixedPointCombMultiplier.Multiply(p, k);
				global::Org.BouncyCastle.Math.EC.ECPoint r2 = fixedPointCombMultiplier.Multiply(q, l);
				return r.Add(r2);
			}
			int width = widthP;
			int d = (combSize + width - 1) / width;
			global::Org.BouncyCastle.Math.EC.ECPoint R = c.Infinity;
			int num = d * width;
			uint[] K = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(num, k);
			uint[] L = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(num, l);
			int top = num - 1;
			for (int i = 0; i < d; i++)
			{
				uint secretIndexK = 0U;
				uint secretIndexL = 0U;
				for (int j = top - i; j >= 0; j -= d)
				{
					uint secretBitK = K[j >> 5] >> j;
					secretIndexK ^= secretBitK >> 1;
					secretIndexK <<= 1;
					secretIndexK ^= secretBitK;
					uint secretBitL = L[j >> 5] >> j;
					secretIndexL ^= secretBitL >> 1;
					secretIndexL <<= 1;
					secretIndexL ^= secretBitL;
				}
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = lookupTableP.LookupVar((int)secretIndexK);
				global::Org.BouncyCastle.Math.EC.ECPoint addQ = lookupTableQ.LookupVar((int)secretIndexL);
				global::Org.BouncyCastle.Math.EC.ECPoint T = ecpoint.Add(addQ);
				R = R.TwicePlus(T);
			}
			return R.Add(infoP.Offset).Add(infoQ.Offset);
		}
	}
}
