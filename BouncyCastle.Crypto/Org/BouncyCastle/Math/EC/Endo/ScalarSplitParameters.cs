using System;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x02000242 RID: 578
	public class ScalarSplitParameters
	{
		// Token: 0x0600173E RID: 5950 RVA: 0x000708AF File Offset: 0x0006EAAF
		private static void CheckVector(global::Org.BouncyCastle.Math.BigInteger[] v, string name)
		{
			if (v == null || v.Length != 2 || v[0] == null || v[1] == null)
			{
				throw new global::System.ArgumentException("Must consist of exactly 2 (non-null) values", name);
			}
		}

		// Token: 0x0600173F RID: 5951 RVA: 0x000708D0 File Offset: 0x0006EAD0
		public ScalarSplitParameters(global::Org.BouncyCastle.Math.BigInteger[] v1, global::Org.BouncyCastle.Math.BigInteger[] v2, global::Org.BouncyCastle.Math.BigInteger g1, global::Org.BouncyCastle.Math.BigInteger g2, int bits)
		{
			global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters.CheckVector(v1, "v1");
			global::Org.BouncyCastle.Math.EC.Endo.ScalarSplitParameters.CheckVector(v2, "v2");
			this.m_v1A = v1[0];
			this.m_v1B = v1[1];
			this.m_v2A = v2[0];
			this.m_v2B = v2[1];
			this.m_g1 = g1;
			this.m_g2 = g2;
			this.m_bits = bits;
		}

		// Token: 0x170002CA RID: 714
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00070934 File Offset: 0x0006EB34
		public virtual global::Org.BouncyCastle.Math.BigInteger V1A
		{
			get
			{
				return this.m_v1A;
			}
		}

		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06001741 RID: 5953 RVA: 0x0007093C File Offset: 0x0006EB3C
		public virtual global::Org.BouncyCastle.Math.BigInteger V1B
		{
			get
			{
				return this.m_v1B;
			}
		}

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06001742 RID: 5954 RVA: 0x00070944 File Offset: 0x0006EB44
		public virtual global::Org.BouncyCastle.Math.BigInteger V2A
		{
			get
			{
				return this.m_v2A;
			}
		}

		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06001743 RID: 5955 RVA: 0x0007094C File Offset: 0x0006EB4C
		public virtual global::Org.BouncyCastle.Math.BigInteger V2B
		{
			get
			{
				return this.m_v2B;
			}
		}

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06001744 RID: 5956 RVA: 0x00070954 File Offset: 0x0006EB54
		public virtual global::Org.BouncyCastle.Math.BigInteger G1
		{
			get
			{
				return this.m_g1;
			}
		}

		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x0007095C File Offset: 0x0006EB5C
		public virtual global::Org.BouncyCastle.Math.BigInteger G2
		{
			get
			{
				return this.m_g2;
			}
		}

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06001746 RID: 5958 RVA: 0x00070964 File Offset: 0x0006EB64
		public virtual int Bits
		{
			get
			{
				return this.m_bits;
			}
		}

		// Token: 0x040009F5 RID: 2549
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_v1A;

		// Token: 0x040009F6 RID: 2550
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_v1B;

		// Token: 0x040009F7 RID: 2551
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_v2A;

		// Token: 0x040009F8 RID: 2552
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_v2B;

		// Token: 0x040009F9 RID: 2553
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_g1;

		// Token: 0x040009FA RID: 2554
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_g2;

		// Token: 0x040009FB RID: 2555
		protected readonly int m_bits;
	}
}
