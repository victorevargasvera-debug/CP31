using System;

namespace Org.BouncyCastle.Math.EC.Abc
{
	// Token: 0x020002B0 RID: 688
	internal class Tnaf
	{
		// Token: 0x06001EC7 RID: 7879 RVA: 0x0008E428 File Offset: 0x0008C628
		public static global::Org.BouncyCastle.Math.BigInteger Norm(sbyte mu, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
		{
			global::Org.BouncyCastle.Math.BigInteger s = lambda.u.Multiply(lambda.u);
			global::Org.BouncyCastle.Math.BigInteger s2 = lambda.u.Multiply(lambda.v);
			global::Org.BouncyCastle.Math.BigInteger s3 = lambda.v.Multiply(lambda.v).ShiftLeft(1);
			global::Org.BouncyCastle.Math.BigInteger norm;
			if (mu == 1)
			{
				norm = s.Add(s2).Add(s3);
			}
			else
			{
				if (mu != -1)
				{
					throw new global::System.ArgumentException("mu must be 1 or -1");
				}
				norm = s.Subtract(s2).Add(s3);
			}
			return norm;
		}

		// Token: 0x06001EC8 RID: 7880 RVA: 0x0008E4A8 File Offset: 0x0008C6A8
		public static global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal Norm(sbyte mu, global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal u, global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal v)
		{
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal s = u.Multiply(u);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal s2 = u.Multiply(v);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal s3 = v.Multiply(v).ShiftLeft(1);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal norm;
			if (mu == 1)
			{
				norm = s.Add(s2).Add(s3);
			}
			else
			{
				if (mu != -1)
				{
					throw new global::System.ArgumentException("mu must be 1 or -1");
				}
				norm = s.Subtract(s2).Add(s3);
			}
			return norm;
		}

		// Token: 0x06001EC9 RID: 7881 RVA: 0x0008E508 File Offset: 0x0008C708
		public static global::Org.BouncyCastle.Math.EC.Abc.ZTauElement Round(global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda0, global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda1, sbyte mu)
		{
			int scale = lambda0.Scale;
			if (lambda1.Scale != scale)
			{
				throw new global::System.ArgumentException("lambda0 and lambda1 do not have same scale");
			}
			if (mu != 1 && mu != -1)
			{
				throw new global::System.ArgumentException("mu must be 1 or -1");
			}
			global::Org.BouncyCastle.Math.BigInteger f0 = lambda0.Round();
			global::Org.BouncyCastle.Math.BigInteger f = lambda1.Round();
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal eta0 = lambda0.Subtract(f0);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal eta = lambda1.Subtract(f);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal eta2 = eta0.Add(eta0);
			if (mu == 1)
			{
				eta2 = eta2.Add(eta);
			}
			else
			{
				eta2 = eta2.Subtract(eta);
			}
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal threeEta = eta.Add(eta).Add(eta);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal fourEta = threeEta.Add(eta);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal check;
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal check2;
			if (mu == 1)
			{
				check = eta0.Subtract(threeEta);
				check2 = eta0.Add(fourEta);
			}
			else
			{
				check = eta0.Add(threeEta);
				check2 = eta0.Subtract(fourEta);
			}
			sbyte h0 = 0;
			sbyte h = 0;
			if (eta2.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) >= 0)
			{
				if (check.CompareTo(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne) < 0)
				{
					h = mu;
				}
				else
				{
					h0 = 1;
				}
			}
			else if (check2.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) >= 0)
			{
				h = mu;
			}
			if (eta2.CompareTo(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne) < 0)
			{
				if (check.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) >= 0)
				{
					h = -mu;
				}
				else
				{
					h0 = -1;
				}
			}
			else if (check2.CompareTo(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusTwo) < 0)
			{
				h = -mu;
			}
			global::Org.BouncyCastle.Math.BigInteger u = f0.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)h0));
			global::Org.BouncyCastle.Math.BigInteger q = f.Add(global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)h));
			return new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(u, q);
		}

		// Token: 0x06001ECA RID: 7882 RVA: 0x0008E678 File Offset: 0x0008C878
		public static global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal ApproximateDivisionByN(global::Org.BouncyCastle.Math.BigInteger k, global::Org.BouncyCastle.Math.BigInteger s, global::Org.BouncyCastle.Math.BigInteger vm, sbyte a, int m, int c)
		{
			int _k = (m + 5) / 2 + c;
			global::Org.BouncyCastle.Math.BigInteger ns = k.ShiftRight(m - _k - 2 + (int)a);
			global::Org.BouncyCastle.Math.BigInteger bigInteger = s.Multiply(ns);
			global::Org.BouncyCastle.Math.BigInteger hs = bigInteger.ShiftRight(m);
			global::Org.BouncyCastle.Math.BigInteger js = vm.Multiply(hs);
			global::Org.BouncyCastle.Math.BigInteger bigInteger2 = bigInteger.Add(js);
			global::Org.BouncyCastle.Math.BigInteger ls = bigInteger2.ShiftRight(_k - c);
			if (bigInteger2.TestBit(_k - c - 1))
			{
				ls = ls.Add(global::Org.BouncyCastle.Math.BigInteger.One);
			}
			return new global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal(ls, c);
		}

		// Token: 0x06001ECB RID: 7883 RVA: 0x0008E6EC File Offset: 0x0008C8EC
		public static sbyte[] TauAdicNaf(sbyte mu, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
		{
			if (mu != 1 && mu != -1)
			{
				throw new global::System.ArgumentException("mu must be 1 or -1");
			}
			int log2Norm = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Norm(mu, lambda).BitLength;
			sbyte[] u = new sbyte[(log2Norm > 30) ? (log2Norm + 4) : 34];
			int i = 0;
			int length = 0;
			global::Org.BouncyCastle.Math.BigInteger r0 = lambda.u;
			global::Org.BouncyCastle.Math.BigInteger r = lambda.v;
			while (!r0.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero) || !r.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero))
			{
				if (r0.TestBit(0))
				{
					u[i] = (sbyte)global::Org.BouncyCastle.Math.BigInteger.Two.Subtract(r0.Subtract(r.ShiftLeft(1)).Mod(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Four)).IntValue;
					if (u[i] == 1)
					{
						r0 = r0.ClearBit(0);
					}
					else
					{
						r0 = r0.Add(global::Org.BouncyCastle.Math.BigInteger.One);
					}
					length = i;
				}
				else
				{
					u[i] = 0;
				}
				global::Org.BouncyCastle.Math.BigInteger bigInteger = r0;
				global::Org.BouncyCastle.Math.BigInteger s = r0.ShiftRight(1);
				if (mu == 1)
				{
					r0 = r.Add(s);
				}
				else
				{
					r0 = r.Subtract(s);
				}
				r = bigInteger.ShiftRight(1).Negate();
				i++;
			}
			length++;
			sbyte[] tnaf = new sbyte[length];
			global::System.Array.Copy(u, 0, tnaf, 0, length);
			return tnaf;
		}

		// Token: 0x06001ECC RID: 7884 RVA: 0x0008E816 File Offset: 0x0008CA16
		public static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint Tau(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p)
		{
			return p.Tau();
		}

		// Token: 0x06001ECD RID: 7885 RVA: 0x0008E820 File Offset: 0x0008CA20
		public static sbyte GetMu(global::Org.BouncyCastle.Math.EC.AbstractF2mCurve curve)
		{
			global::Org.BouncyCastle.Math.BigInteger a = curve.A.ToBigInteger();
			sbyte mu;
			if (a.SignValue == 0)
			{
				mu = -1;
			}
			else
			{
				if (!a.Equals(global::Org.BouncyCastle.Math.BigInteger.One))
				{
					throw new global::System.ArgumentException("No Koblitz curve (ABC), TNAF multiplication not possible");
				}
				mu = 1;
			}
			return mu;
		}

		// Token: 0x06001ECE RID: 7886 RVA: 0x0008E862 File Offset: 0x0008CA62
		public static sbyte GetMu(global::Org.BouncyCastle.Math.EC.ECFieldElement curveA)
		{
			return curveA.IsZero ? -1 : 1;
		}

		// Token: 0x06001ECF RID: 7887 RVA: 0x0008E871 File Offset: 0x0008CA71
		public static sbyte GetMu(int curveA)
		{
			return (curveA == 0) ? -1 : 1;
		}

		// Token: 0x06001ED0 RID: 7888 RVA: 0x0008E87C File Offset: 0x0008CA7C
		public static global::Org.BouncyCastle.Math.BigInteger[] GetLucas(sbyte mu, int k, bool doV)
		{
			if (mu != 1 && mu != -1)
			{
				throw new global::System.ArgumentException("mu must be 1 or -1");
			}
			global::Org.BouncyCastle.Math.BigInteger u0;
			global::Org.BouncyCastle.Math.BigInteger u;
			if (doV)
			{
				u0 = global::Org.BouncyCastle.Math.BigInteger.Two;
				u = global::Org.BouncyCastle.Math.BigInteger.ValueOf((long)mu);
			}
			else
			{
				u0 = global::Org.BouncyCastle.Math.BigInteger.Zero;
				u = global::Org.BouncyCastle.Math.BigInteger.One;
			}
			for (int i = 1; i < k; i++)
			{
				global::Org.BouncyCastle.Math.BigInteger s;
				if (mu == 1)
				{
					s = u;
				}
				else
				{
					s = u.Negate();
				}
				global::Org.BouncyCastle.Math.BigInteger bigInteger = s.Subtract(u0.ShiftLeft(1));
				u0 = u;
				u = bigInteger;
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				u0,
				u
			};
		}

		// Token: 0x06001ED1 RID: 7889 RVA: 0x0008E8F8 File Offset: 0x0008CAF8
		public static global::Org.BouncyCastle.Math.BigInteger GetTw(sbyte mu, int w)
		{
			if (w != 4)
			{
				global::Org.BouncyCastle.Math.BigInteger[] us = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu, w, false);
				global::Org.BouncyCastle.Math.BigInteger twoToW = global::Org.BouncyCastle.Math.BigInteger.Zero.SetBit(w);
				global::Org.BouncyCastle.Math.BigInteger u1invert = us[1].ModInverse(twoToW);
				return global::Org.BouncyCastle.Math.BigInteger.Two.Multiply(us[0]).Multiply(u1invert).Mod(twoToW);
			}
			if (mu == 1)
			{
				return global::Org.BouncyCastle.Math.BigInteger.ValueOf(6L);
			}
			return global::Org.BouncyCastle.Math.BigInteger.ValueOf(10L);
		}

		// Token: 0x06001ED2 RID: 7890 RVA: 0x0008E958 File Offset: 0x0008CB58
		public static global::Org.BouncyCastle.Math.BigInteger[] GetSi(global::Org.BouncyCastle.Math.EC.AbstractF2mCurve curve)
		{
			if (!curve.IsKoblitz)
			{
				throw new global::System.ArgumentException("si is defined for Koblitz curves only");
			}
			int i = curve.FieldSize;
			int a = curve.A.ToBigInteger().IntValue;
			sbyte mu = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu(a);
			int shifts = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetShiftsForCofactor(curve.Cofactor);
			int index = i + 3 - a;
			global::Org.BouncyCastle.Math.BigInteger[] ui = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu, index, false);
			if (mu == 1)
			{
				ui[0] = ui[0].Negate();
				ui[1] = ui[1].Negate();
			}
			global::Org.BouncyCastle.Math.BigInteger dividend0 = global::Org.BouncyCastle.Math.BigInteger.One.Add(ui[1]).ShiftRight(shifts);
			global::Org.BouncyCastle.Math.BigInteger dividend = global::Org.BouncyCastle.Math.BigInteger.One.Add(ui[0]).ShiftRight(shifts).Negate();
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				dividend0,
				dividend
			};
		}

		// Token: 0x06001ED3 RID: 7891 RVA: 0x0008EA10 File Offset: 0x0008CC10
		public static global::Org.BouncyCastle.Math.BigInteger[] GetSi(int fieldSize, int curveA, global::Org.BouncyCastle.Math.BigInteger cofactor)
		{
			sbyte mu = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu(curveA);
			int shifts = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetShiftsForCofactor(cofactor);
			int index = fieldSize + 3 - curveA;
			global::Org.BouncyCastle.Math.BigInteger[] ui = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu, index, false);
			if (mu == 1)
			{
				ui[0] = ui[0].Negate();
				ui[1] = ui[1].Negate();
			}
			global::Org.BouncyCastle.Math.BigInteger dividend0 = global::Org.BouncyCastle.Math.BigInteger.One.Add(ui[1]).ShiftRight(shifts);
			global::Org.BouncyCastle.Math.BigInteger dividend = global::Org.BouncyCastle.Math.BigInteger.One.Add(ui[0]).ShiftRight(shifts).Negate();
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				dividend0,
				dividend
			};
		}

		// Token: 0x06001ED4 RID: 7892 RVA: 0x0008EA90 File Offset: 0x0008CC90
		protected static int GetShiftsForCofactor(global::Org.BouncyCastle.Math.BigInteger h)
		{
			if (h != null && h.BitLength < 4)
			{
				int hi = h.IntValue;
				if (hi == 2)
				{
					return 1;
				}
				if (hi == 4)
				{
					return 2;
				}
			}
			throw new global::System.ArgumentException("h (Cofactor) must be 2 or 4");
		}

		// Token: 0x06001ED5 RID: 7893 RVA: 0x0008EAC8 File Offset: 0x0008CCC8
		public static global::Org.BouncyCastle.Math.EC.Abc.ZTauElement PartModReduction(global::Org.BouncyCastle.Math.BigInteger k, int m, sbyte a, global::Org.BouncyCastle.Math.BigInteger[] s, sbyte mu, sbyte c)
		{
			global::Org.BouncyCastle.Math.BigInteger d0;
			if (mu == 1)
			{
				d0 = s[0].Add(s[1]);
			}
			else
			{
				d0 = s[0].Subtract(s[1]);
			}
			global::Org.BouncyCastle.Math.BigInteger vm = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetLucas(mu, m, true)[1];
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda2 = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.ApproximateDivisionByN(k, s[0], vm, a, m, (int)c);
			global::Org.BouncyCastle.Math.EC.Abc.SimpleBigDecimal lambda = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.ApproximateDivisionByN(k, s[1], vm, a, m, (int)c);
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement q = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Round(lambda2, lambda, mu);
			global::Org.BouncyCastle.Math.BigInteger u = k.Subtract(d0.Multiply(q.u)).Subtract(global::Org.BouncyCastle.Math.BigInteger.ValueOf(2L).Multiply(s[1]).Multiply(q.v));
			global::Org.BouncyCastle.Math.BigInteger r = s[1].Multiply(q.u).Subtract(s[0].Multiply(q.v));
			return new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(u, r);
		}

		// Token: 0x06001ED6 RID: 7894 RVA: 0x0008EB84 File Offset: 0x0008CD84
		public static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyRTnaf(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			global::Org.BouncyCastle.Math.EC.AbstractF2mCurve abstractF2mCurve = (global::Org.BouncyCastle.Math.EC.AbstractF2mCurve)p.Curve;
			int i = abstractF2mCurve.FieldSize;
			int a = abstractF2mCurve.A.ToBigInteger().IntValue;
			sbyte mu = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu(a);
			global::Org.BouncyCastle.Math.BigInteger[] s = abstractF2mCurve.GetSi();
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement rho = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.PartModReduction(k, i, (sbyte)a, s, mu, 10);
			return global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyTnaf(p, rho);
		}

		// Token: 0x06001ED7 RID: 7895 RVA: 0x0008EBD8 File Offset: 0x0008CDD8
		public static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyTnaf(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda)
		{
			sbyte[] u = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicNaf(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu(((global::Org.BouncyCastle.Math.EC.AbstractF2mCurve)p.Curve).A), lambda);
			return global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyFromTnaf(p, u);
		}

		// Token: 0x06001ED8 RID: 7896 RVA: 0x0008EC08 File Offset: 0x0008CE08
		public static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyFromTnaf(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte[] u)
		{
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint q = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)p.Curve.Infinity;
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint pNeg = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)p.Negate();
			int tauCount = 0;
			for (int i = u.Length - 1; i >= 0; i--)
			{
				tauCount++;
				sbyte ui = u[i];
				if (ui != 0)
				{
					q = q.TauPow(tauCount);
					tauCount = 0;
					global::Org.BouncyCastle.Math.EC.ECPoint x = (ui > 0) ? p : pNeg;
					q = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)q.Add(x);
				}
			}
			if (tauCount > 0)
			{
				q = q.TauPow(tauCount);
			}
			return q;
		}

		// Token: 0x06001ED9 RID: 7897 RVA: 0x0008EC84 File Offset: 0x0008CE84
		public static sbyte[] TauAdicWNaf(sbyte mu, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda, sbyte width, global::Org.BouncyCastle.Math.BigInteger pow2w, global::Org.BouncyCastle.Math.BigInteger tw, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] alpha)
		{
			if (mu != 1 && mu != -1)
			{
				throw new global::System.ArgumentException("mu must be 1 or -1");
			}
			int log2Norm = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Norm(mu, lambda).BitLength;
			sbyte[] u = new sbyte[(log2Norm > 30) ? (log2Norm + 4 + (int)width) : ((int)(34 + width))];
			global::Org.BouncyCastle.Math.BigInteger pow2wMin = pow2w.ShiftRight(1);
			global::Org.BouncyCastle.Math.BigInteger r0 = lambda.u;
			global::Org.BouncyCastle.Math.BigInteger r = lambda.v;
			int i = 0;
			while (!r0.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero) || !r.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero))
			{
				if (r0.TestBit(0))
				{
					global::Org.BouncyCastle.Math.BigInteger uUnMod = r0.Add(r.Multiply(tw)).Mod(pow2w);
					sbyte uLocal;
					if (uUnMod.CompareTo(pow2wMin) >= 0)
					{
						uLocal = (sbyte)uUnMod.Subtract(pow2w).IntValue;
					}
					else
					{
						uLocal = (sbyte)uUnMod.IntValue;
					}
					u[i] = uLocal;
					bool s = true;
					if (uLocal < 0)
					{
						s = false;
						uLocal = -uLocal;
					}
					if (s)
					{
						r0 = r0.Subtract(alpha[(int)uLocal].u);
						r = r.Subtract(alpha[(int)uLocal].v);
					}
					else
					{
						r0 = r0.Add(alpha[(int)uLocal].u);
						r = r.Add(alpha[(int)uLocal].v);
					}
				}
				else
				{
					u[i] = 0;
				}
				global::Org.BouncyCastle.Math.BigInteger bigInteger = r0;
				if (mu == 1)
				{
					r0 = r.Add(r0.ShiftRight(1));
				}
				else
				{
					r0 = r.Subtract(r0.ShiftRight(1));
				}
				r = bigInteger.ShiftRight(1).Negate();
				i++;
			}
			return u;
		}

		// Token: 0x06001EDA RID: 7898 RVA: 0x0008EDF8 File Offset: 0x0008CFF8
		public static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] GetPreComp(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte a)
		{
			sbyte[][] alphaTnaf = (a == 0) ? global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf : global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1Tnaf;
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] pu = new global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[(uint)(alphaTnaf.Length + 1) >> 1];
			pu[0] = p;
			uint precompLen = (uint)alphaTnaf.Length;
			for (uint i = 3U; i < precompLen; i += 2U)
			{
				pu[(int)(i >> 1)] = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MultiplyFromTnaf(p, alphaTnaf[(int)i]);
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = p.Curve;
			global::Org.BouncyCastle.Math.EC.ECPoint[] points = pu;
			curve.NormalizeAll(points);
			return pu;
		}

		// Token: 0x06001EDC RID: 7900 RVA: 0x0008EE60 File Offset: 0x0008D060
		// Note: this type is marked as 'beforefieldinit'.
		static Tnaf()
		{
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] array = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[9];
			array[1] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.BigInteger.One, global::Org.BouncyCastle.Math.BigInteger.Zero);
			array[3] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusThree, global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne);
			array[5] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne, global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne);
			array[7] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.BigInteger.One, global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne);
			global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0 = array;
			global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0Tnaf = new sbyte[][]
			{
				default(sbyte[]),
				new sbyte[]
				{
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					-1,
					0,
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					1,
					0,
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					-1,
					0,
					0,
					1
				}
			};
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] array2 = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[9];
			array2[1] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.BigInteger.One, global::Org.BouncyCastle.Math.BigInteger.Zero);
			array2[3] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusThree, global::Org.BouncyCastle.Math.BigInteger.One);
			array2[5] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.EC.Abc.Tnaf.MinusOne, global::Org.BouncyCastle.Math.BigInteger.One);
			array2[7] = new global::Org.BouncyCastle.Math.EC.Abc.ZTauElement(global::Org.BouncyCastle.Math.BigInteger.One, global::Org.BouncyCastle.Math.BigInteger.One);
			global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1 = array2;
			global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1Tnaf = new sbyte[][]
			{
				default(sbyte[]),
				new sbyte[]
				{
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					-1,
					0,
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					1,
					0,
					1
				},
				default(sbyte[]),
				new sbyte[]
				{
					-1,
					0,
					0,
					-1
				}
			};
		}

		// Token: 0x04000B0A RID: 2826
		private static readonly global::Org.BouncyCastle.Math.BigInteger MinusOne = global::Org.BouncyCastle.Math.BigInteger.One.Negate();

		// Token: 0x04000B0B RID: 2827
		private static readonly global::Org.BouncyCastle.Math.BigInteger MinusTwo = global::Org.BouncyCastle.Math.BigInteger.Two.Negate();

		// Token: 0x04000B0C RID: 2828
		private static readonly global::Org.BouncyCastle.Math.BigInteger MinusThree = global::Org.BouncyCastle.Math.BigInteger.Three.Negate();

		// Token: 0x04000B0D RID: 2829
		private static readonly global::Org.BouncyCastle.Math.BigInteger Four = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);

		// Token: 0x04000B0E RID: 2830
		public const sbyte Width = 4;

		// Token: 0x04000B0F RID: 2831
		public const sbyte Pow2Width = 16;

		// Token: 0x04000B10 RID: 2832
		public static readonly global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha0;

		// Token: 0x04000B11 RID: 2833
		public static readonly sbyte[][] Alpha0Tnaf;

		// Token: 0x04000B12 RID: 2834
		public static readonly global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] Alpha1;

		// Token: 0x04000B13 RID: 2835
		public static readonly sbyte[][] Alpha1Tnaf;
	}
}
