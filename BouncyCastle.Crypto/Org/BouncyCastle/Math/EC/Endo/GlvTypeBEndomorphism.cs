using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x02000240 RID: 576
	public class GlvTypeBEndomorphism : global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism, global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism
	{
		// Token: 0x06001730 RID: 5936 RVA: 0x0007079D File Offset: 0x0006E99D
		public GlvTypeBEndomorphism(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters parameters)
		{
			this.m_parameters = parameters;
			this.m_pointMap = new global::Org.BouncyCastle.Math.EC.ScaleXPointMap(curve.FromBigInteger(parameters.Beta));
		}

		// Token: 0x06001731 RID: 5937 RVA: 0x000707C3 File Offset: 0x0006E9C3
		public virtual global::Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(global::Org.BouncyCastle.Math.BigInteger k)
		{
			return global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.DecomposeScalar(this.m_parameters.SplitParams, k);
		}

		// Token: 0x170002C0 RID: 704
		// (get) Token: 0x06001732 RID: 5938 RVA: 0x000707D6 File Offset: 0x0006E9D6
		public virtual global::Org.BouncyCastle.Math.EC.ECPointMap PointMap
		{
			get
			{
				return this.m_pointMap;
			}
		}

		// Token: 0x170002C1 RID: 705
		// (get) Token: 0x06001733 RID: 5939 RVA: 0x000707DE File Offset: 0x0006E9DE
		public virtual bool HasEfficientPointMap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040009F0 RID: 2544
		protected readonly global::Org.BouncyCastle.Math.EC.Endo.GlvTypeBParameters m_parameters;

		// Token: 0x040009F1 RID: 2545
		protected readonly global::Org.BouncyCastle.Math.EC.ECPointMap m_pointMap;
	}
}
