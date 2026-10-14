using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000234 RID: 564
	public class WNafPreCompInfo : global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo
	{
		// Token: 0x060016EB RID: 5867 RVA: 0x0006FBEC File Offset: 0x0006DDEC
		internal int DecrementPromotionCountdown()
		{
			int t = this.m_promotionCountdown;
			if (t > 0)
			{
				t = (this.m_promotionCountdown = t - 1);
			}
			return t;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x060016EC RID: 5868 RVA: 0x0006FC14 File Offset: 0x0006DE14
		// (set) Token: 0x060016ED RID: 5869 RVA: 0x0006FC1E File Offset: 0x0006DE1E
		internal int PromotionCountdown
		{
			get
			{
				return this.m_promotionCountdown;
			}
			set
			{
				this.m_promotionCountdown = value;
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x060016EE RID: 5870 RVA: 0x0006FC29 File Offset: 0x0006DE29
		public virtual bool IsPromoted
		{
			get
			{
				return this.m_promotionCountdown <= 0;
			}
		}

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x060016EF RID: 5871 RVA: 0x0006FC39 File Offset: 0x0006DE39
		// (set) Token: 0x060016F0 RID: 5872 RVA: 0x0006FC41 File Offset: 0x0006DE41
		public virtual int ConfWidth
		{
			get
			{
				return this.m_confWidth;
			}
			set
			{
				this.m_confWidth = value;
			}
		}

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x060016F1 RID: 5873 RVA: 0x0006FC4A File Offset: 0x0006DE4A
		// (set) Token: 0x060016F2 RID: 5874 RVA: 0x0006FC52 File Offset: 0x0006DE52
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint[] PreComp
		{
			get
			{
				return this.m_preComp;
			}
			set
			{
				this.m_preComp = value;
			}
		}

		// Token: 0x170002B3 RID: 691
		// (get) Token: 0x060016F3 RID: 5875 RVA: 0x0006FC5B File Offset: 0x0006DE5B
		// (set) Token: 0x060016F4 RID: 5876 RVA: 0x0006FC63 File Offset: 0x0006DE63
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint[] PreCompNeg
		{
			get
			{
				return this.m_preCompNeg;
			}
			set
			{
				this.m_preCompNeg = value;
			}
		}

		// Token: 0x170002B4 RID: 692
		// (get) Token: 0x060016F5 RID: 5877 RVA: 0x0006FC6C File Offset: 0x0006DE6C
		// (set) Token: 0x060016F6 RID: 5878 RVA: 0x0006FC74 File Offset: 0x0006DE74
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Twice
		{
			get
			{
				return this.m_twice;
			}
			set
			{
				this.m_twice = value;
			}
		}

		// Token: 0x170002B5 RID: 693
		// (get) Token: 0x060016F7 RID: 5879 RVA: 0x0006FC7D File Offset: 0x0006DE7D
		// (set) Token: 0x060016F8 RID: 5880 RVA: 0x0006FC85 File Offset: 0x0006DE85
		public virtual int Width
		{
			get
			{
				return this.m_width;
			}
			set
			{
				this.m_width = value;
			}
		}

		// Token: 0x040009DC RID: 2524
		internal volatile int m_promotionCountdown = 4;

		// Token: 0x040009DD RID: 2525
		protected int m_confWidth = -1;

		// Token: 0x040009DE RID: 2526
		protected global::Org.BouncyCastle.Math.EC.ECPoint[] m_preComp;

		// Token: 0x040009DF RID: 2527
		protected global::Org.BouncyCastle.Math.EC.ECPoint[] m_preCompNeg;

		// Token: 0x040009E0 RID: 2528
		protected global::Org.BouncyCastle.Math.EC.ECPoint m_twice;

		// Token: 0x040009E1 RID: 2529
		protected int m_width = -1;
	}
}
