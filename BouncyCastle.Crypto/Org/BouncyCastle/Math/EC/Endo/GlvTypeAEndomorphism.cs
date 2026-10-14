using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023E RID: 574
	public class GlvTypeAEndomorphism : global::Org.BouncyCastle.Math.EC.Endo.GlvEndomorphism, global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism
	{
		// Token: 0x06001728 RID: 5928 RVA: 0x00070724 File Offset: 0x0006E924
		public GlvTypeAEndomorphism(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.Endo.GlvTypeAParameters parameters)
		{
			this.m_parameters = parameters;
			this.m_pointMap = new global::Org.BouncyCastle.Math.EC.ScaleYNegateXPointMap(curve.FromBigInteger(parameters.I));
		}

		// Token: 0x06001729 RID: 5929 RVA: 0x0007074A File Offset: 0x0006E94A
		public virtual global::Org.BouncyCastle.Math.BigInteger[] DecomposeScalar(global::Org.BouncyCastle.Math.BigInteger k)
		{
			return global::Org.BouncyCastle.Math.EC.Endo.EndoUtilities.DecomposeScalar(this.m_parameters.SplitParams, k);
		}

		// Token: 0x170002BB RID: 699
		// (get) Token: 0x0600172A RID: 5930 RVA: 0x0007075D File Offset: 0x0006E95D
		public virtual global::Org.BouncyCastle.Math.EC.ECPointMap PointMap
		{
			get
			{
				return this.m_pointMap;
			}
		}

		// Token: 0x170002BC RID: 700
		// (get) Token: 0x0600172B RID: 5931 RVA: 0x00070765 File Offset: 0x0006E965
		public virtual bool HasEfficientPointMap
		{
			get
			{
				return true;
			}
		}

		// Token: 0x040009EB RID: 2539
		protected readonly global::Org.BouncyCastle.Math.EC.Endo.GlvTypeAParameters m_parameters;

		// Token: 0x040009EC RID: 2540
		protected readonly global::Org.BouncyCastle.Math.EC.ECPointMap m_pointMap;
	}
}
