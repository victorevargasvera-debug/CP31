using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000224 RID: 548
	public abstract class AbstractECMultiplier : global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier
	{
		// Token: 0x060016BD RID: 5821 RVA: 0x0006F4CC File Offset: 0x0006D6CC
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Multiply(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int sign = k.SignValue;
			if (sign == 0 || p.IsInfinity)
			{
				return p.Curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.ECPoint positive = this.MultiplyPositive(p, k.Abs());
			global::Org.BouncyCastle.Math.EC.ECPoint result = (sign > 0) ? positive : positive.Negate();
			return this.CheckResult(result);
		}

		// Token: 0x060016BE RID: 5822
		protected abstract global::Org.BouncyCastle.Math.EC.ECPoint MultiplyPositive(global::Org.BouncyCastle.Math.EC.ECPoint p, global::Org.BouncyCastle.Math.BigInteger k);

		// Token: 0x060016BF RID: 5823 RVA: 0x0006F51A File Offset: 0x0006D71A
		protected virtual global::Org.BouncyCastle.Math.EC.ECPoint CheckResult(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImplCheckResult(p);
		}
	}
}
