using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x02000241 RID: 577
	public class GlvTypeBParameters
	{
		// Token: 0x06001734 RID: 5940 RVA: 0x000707E1 File Offset: 0x0006E9E1
		[global::System.Obsolete("Use constructor taking a ScalarSplitParameters instead")]
		public GlvTypeBParameters(global::Org.BouncyCastle.Math.BigInteger beta, global::Org.BouncyCastle.Math.BigInteger lambda, global::Org.BouncyCastle.Math.BigInteger[] v1, global::Org.BouncyCastle.Math.BigInteger[] v2, global::Org.BouncyCastle.Math.BigInteger g1, global::Org.BouncyCastle.Math.BigInteger g2, int bits)
		{
			this.m_beta = beta;
			this.m_lambda = lambda;
			this.m_splitParams = new global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters(v1, v2, g1, g2, bits);
		}

		// Token: 0x06001735 RID: 5941 RVA: 0x0007080B File Offset: 0x0006EA0B
		public GlvTypeBParameters(global::Org.BouncyCastle.Math.BigInteger beta, global::Org.BouncyCastle.Math.BigInteger lambda, global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters splitParams)
		{
			this.m_beta = beta;
			this.m_lambda = lambda;
			this.m_splitParams = splitParams;
		}

		// Token: 0x170002C2 RID: 706
		// (get) Token: 0x06001736 RID: 5942 RVA: 0x00070828 File Offset: 0x0006EA28
		public virtual global::Org.BouncyCastle.Math.BigInteger Beta
		{
			get
			{
				return this.m_beta;
			}
		}

		// Token: 0x170002C3 RID: 707
		// (get) Token: 0x06001737 RID: 5943 RVA: 0x00070830 File Offset: 0x0006EA30
		public virtual global::Org.BouncyCastle.Math.BigInteger Lambda
		{
			get
			{
				return this.m_lambda;
			}
		}

		// Token: 0x170002C4 RID: 708
		// (get) Token: 0x06001738 RID: 5944 RVA: 0x00070838 File Offset: 0x0006EA38
		public virtual global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters SplitParams
		{
			get
			{
				return this.m_splitParams;
			}
		}

		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x06001739 RID: 5945 RVA: 0x00070840 File Offset: 0x0006EA40
		[global::System.Obsolete("Access via SplitParams instead")]
		public virtual global::Org.BouncyCastle.Math.BigInteger[] V1
		{
			get
			{
				return new global::Org.BouncyCastle.Math.BigInteger[]
				{
					this.m_splitParams.V1A,
					this.m_splitParams.V1B
				};
			}
		}

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600173A RID: 5946 RVA: 0x00070864 File Offset: 0x0006EA64
		[global::System.Obsolete("Access via SplitParams instead")]
		public virtual global::Org.BouncyCastle.Math.BigInteger[] V2
		{
			get
			{
				return new global::Org.BouncyCastle.Math.BigInteger[]
				{
					this.m_splitParams.V2A,
					this.m_splitParams.V2B
				};
			}
		}

		// Token: 0x170002C7 RID: 711
		// (get) Token: 0x0600173B RID: 5947 RVA: 0x00070888 File Offset: 0x0006EA88
		[global::System.Obsolete("Access via SplitParams instead")]
		public virtual global::Org.BouncyCastle.Math.BigInteger G1
		{
			get
			{
				return this.m_splitParams.G1;
			}
		}

		// Token: 0x170002C8 RID: 712
		// (get) Token: 0x0600173C RID: 5948 RVA: 0x00070895 File Offset: 0x0006EA95
		[global::System.Obsolete("Access via SplitParams instead")]
		public virtual global::Org.BouncyCastle.Math.BigInteger G2
		{
			get
			{
				return this.m_splitParams.G2;
			}
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x0600173D RID: 5949 RVA: 0x000708A2 File Offset: 0x0006EAA2
		[global::System.Obsolete("Access via SplitParams instead")]
		public virtual int Bits
		{
			get
			{
				return this.m_splitParams.Bits;
			}
		}

		// Token: 0x040009F2 RID: 2546
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_beta;

		// Token: 0x040009F3 RID: 2547
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_lambda;

		// Token: 0x040009F4 RID: 2548
		protected readonly global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters m_splitParams;
	}
}
