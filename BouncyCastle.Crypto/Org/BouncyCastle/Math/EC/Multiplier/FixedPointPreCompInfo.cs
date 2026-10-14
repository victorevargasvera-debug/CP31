using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000228 RID: 552
	public class FixedPointPreCompInfo : global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo
	{
		// Token: 0x170002AC RID: 684
		// (get) Token: 0x060016C6 RID: 5830 RVA: 0x0006F673 File Offset: 0x0006D873
		// (set) Token: 0x060016C7 RID: 5831 RVA: 0x0006F67B File Offset: 0x0006D87B
		public virtual global::Org.BouncyCastle.Math.EC.ECLookupTable LookupTable
		{
			get
			{
				return this.m_lookupTable;
			}
			set
			{
				this.m_lookupTable = value;
			}
		}

		// Token: 0x170002AD RID: 685
		// (get) Token: 0x060016C8 RID: 5832 RVA: 0x0006F684 File Offset: 0x0006D884
		// (set) Token: 0x060016C9 RID: 5833 RVA: 0x0006F68C File Offset: 0x0006D88C
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Offset
		{
			get
			{
				return this.m_offset;
			}
			set
			{
				this.m_offset = value;
			}
		}

		// Token: 0x170002AE RID: 686
		// (get) Token: 0x060016CA RID: 5834 RVA: 0x0006F695 File Offset: 0x0006D895
		// (set) Token: 0x060016CB RID: 5835 RVA: 0x0006F69D File Offset: 0x0006D89D
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

		// Token: 0x040009D0 RID: 2512
		protected global::Org.BouncyCastle.Math.EC.ECPoint m_offset;

		// Token: 0x040009D1 RID: 2513
		protected global::Org.BouncyCastle.Math.EC.ECLookupTable m_lookupTable;

		// Token: 0x040009D2 RID: 2514
		protected int m_width = -1;
	}
}
