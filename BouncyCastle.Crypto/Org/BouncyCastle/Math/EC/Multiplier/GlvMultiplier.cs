using System;
using Org.BouncyCastle.Math.EC.Endo;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x0200022A RID: 554
	public class GlvMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.AbstractECMultiplier
	{
		// Token: 0x060016D2 RID: 5842 RVA: 0x0006F718 File Offset: 0x0006D918
		public GlvMultiplier(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism)
		{
			if (curve == null || curve.Order == null)
			{
				throw new global::System.ArgumentException("Need curve with known group order", "curve");
			}
			this.curve = curve;
			this.glvEndomorphism = glvEndomorphism;
		}

		// Token: 0x060016D3 RID: 5843 RVA: 0x0006F74C File Offset: 0x0006D94C
		protected override global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			if (!this.curve.Equals(p.Curve))
			{
				throw new global::System.InvalidOperationException();
			}
			global::Org.BouncyCastle.Math.BigInteger i = p.Curve.Order;
			global::Org.BouncyCastle.Math.BigInteger[] array = this.glvEndomorphism.DecomposeScalar(k.Mod(i));
			global::Org.BouncyCastle.Math.BigInteger a = array[0];
			global::Org.BouncyCastle.Math.BigInteger b = array[1];
			if (this.glvEndomorphism.HasEfficientPointMap)
			{
				return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(this.glvEndomorphism, p, a, b);
			}
			global::Org.BouncyCastle.Math.EC.ECPoint q = global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.MapPoint(this.glvEndomorphism, p);
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplShamirsTrickWNaf(p, a, q, b);
		}

		// Token: 0x040009D4 RID: 2516
		protected readonly global::Org.BouncyCastle.Math.EC.ECCurve curve;

		// Token: 0x040009D5 RID: 2517
		protected readonly global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism glvEndomorphism;
	}
}
