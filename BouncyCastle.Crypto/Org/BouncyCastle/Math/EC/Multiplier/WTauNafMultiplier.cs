using System;
using Org.BouncyCastle.Math.EC.Abc;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000236 RID: 566
	public class WTauNafMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x0600170F RID: 5903 RVA: 0x00070340 File Offset: 0x0006E540
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint point, global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (!(point is global::Org.BouncyCastle.Math.EC.AbstractF2mPoint))
			{
				throw new global::System.ArgumentException("Only AbstractF2mPoint can be used in WTauNafMultiplier");
			}
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)point;
			global::Org.BouncyCastle.Math.EC.AbstractF2mCurve abstractF2mCurve = (global::Org.BouncyCastle.Math.EC.AbstractF2mCurve)p.Curve;
			int i = abstractF2mCurve.FieldSize;
			sbyte a = (sbyte)abstractF2mCurve.A.ToBigInteger().IntValue;
			sbyte mu = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetMu((int)a);
			global::Org.BouncyCastle.Math.BigInteger[] s = abstractF2mCurve.GetSi();
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement rho = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.PartModReduction(k, i, a, s, mu, 10);
			return this.MultiplyWTnaf(p, rho, a, mu);
		}

		// Token: 0x06001710 RID: 5904 RVA: 0x000703B4 File Offset: 0x0006E5B4
		private global::Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyWTnaf(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, global::Org.BouncyCastle.Math.EC.Abc.ZTauElement lambda, sbyte a, sbyte mu)
		{
			global::Org.BouncyCastle.Math.EC.Abc.ZTauElement[] alpha = (a == 0) ? global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha0 : global::Org.BouncyCastle.Math.EC.Abc.Tnaf.Alpha1;
			global::Org.BouncyCastle.Math.BigInteger tw = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetTw(mu, 4);
			sbyte[] u = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.TauAdicWNaf(mu, lambda, 4, global::Org.BouncyCastle.Math.BigInteger.ValueOf(16L), tw, alpha);
			return global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.MultiplyFromWTnaf(p, u);
		}

		// Token: 0x06001711 RID: 5905 RVA: 0x000703F8 File Offset: 0x0006E5F8
		private static global::Org.BouncyCastle.Math.EC.AbstractF2mPoint MultiplyFromWTnaf(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte[] u)
		{
			global::Org.BouncyCastle.Math.EC.AbstractF2mCurve abstractF2mCurve = (global::Org.BouncyCastle.Math.EC.AbstractF2mCurve)p.Curve;
			sbyte a = (sbyte)abstractF2mCurve.A.ToBigInteger().IntValue;
			global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.WTauNafCallback callback = new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.WTauNafCallback(p, a);
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] pu = ((global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafPreCompInfo)abstractF2mCurve.Precompute(p, global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier.PRECOMP_NAME, callback)).PreComp;
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] puNeg = new global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[pu.Length];
			for (int i = 0; i < pu.Length; i++)
			{
				puNeg[i] = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)pu[i].Negate();
			}
			global::Org.BouncyCastle.Math.EC.AbstractF2mPoint q = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)p.Curve.Infinity;
			int tauCount = 0;
			for (int j = u.Length - 1; j >= 0; j--)
			{
				tauCount++;
				int ui = (int)u[j];
				if (ui != 0)
				{
					q = q.TauPow(tauCount);
					tauCount = 0;
					global::Org.BouncyCastle.Math.EC.ECPoint x = (ui > 0) ? pu[ui >> 1] : puNeg[-ui >> 1];
					q = (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)q.Add(x);
				}
			}
			if (tauCount > 0)
			{
				q = q.TauPow(tauCount);
			}
			return q;
		}

		// Token: 0x040009E6 RID: 2534
		internal static readonly string PRECOMP_NAME = "bc_wtnaf";

		// Token: 0x020007D2 RID: 2002
		private class WTauNafCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004583 RID: 17795 RVA: 0x00133D0E File Offset: 0x00131F0E
			internal WTauNafCallback(global::Org.BouncyCastle.Math.EC.AbstractF2mPoint p, sbyte a)
			{
				this.m_p = p;
				this.m_a = a;
			}

			// Token: 0x06004584 RID: 17796 RVA: 0x00133D24 File Offset: 0x00131F24
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				if (existing is global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafPreCompInfo)
				{
					return existing;
				}
				return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafPreCompInfo
				{
					PreComp = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetPreComp(this.m_p, this.m_a)
				};
			}

			// Token: 0x04002419 RID: 9241
			private readonly global::Org.BouncyCastle.Math.EC.AbstractF2mPoint m_p;

			// Token: 0x0400241A RID: 9242
			private readonly sbyte m_a;
		}
	}
}
