using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023F RID: 575
	public class GlvTypeAParameters
	{
		// Token: 0x0600172C RID: 5932 RVA: 0x00070768 File Offset: 0x0006E968
		public GlvTypeAParameters(global::Org.BouncyCastle.Math.BigInteger i, global::Org.BouncyCastle.Math.BigInteger lambda, global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters splitParams)
		{
			this.m_i = i;
			this.m_lambda = lambda;
			this.m_splitParams = splitParams;
		}

		// Token: 0x170002BD RID: 701
		// (get) Token: 0x0600172D RID: 5933 RVA: 0x00070785 File Offset: 0x0006E985
		public virtual global::Org.BouncyCastle.Math.BigInteger I
		{
			get
			{
				return this.m_i;
			}
		}

		// Token: 0x170002BE RID: 702
		// (get) Token: 0x0600172E RID: 5934 RVA: 0x0007078D File Offset: 0x0006E98D
		public virtual global::Org.BouncyCastle.Math.BigInteger Lambda
		{
			get
			{
				return this.m_lambda;
			}
		}

		// Token: 0x170002BF RID: 703
		// (get) Token: 0x0600172F RID: 5935 RVA: 0x00070795 File Offset: 0x0006E995
		public virtual global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters SplitParams
		{
			get
			{
				return this.m_splitParams;
			}
		}

		// Token: 0x040009ED RID: 2541
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_i;

		// Token: 0x040009EE RID: 2542
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_lambda;

		// Token: 0x040009EF RID: 2543
		protected readonly global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters m_splitParams;
	}
}
