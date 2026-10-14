using System;

namespace Org.BouncyCastle.Math.EC.Multiplier
{
	// Token: 0x02000237 RID: 567
	public class WTauNafPreCompInfo : global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo
	{
		// Token: 0x170002B6 RID: 694
		// (get) Token: 0x06001714 RID: 5908 RVA: 0x00070501 File Offset: 0x0006E701
		// (set) Token: 0x06001715 RID: 5909 RVA: 0x00070509 File Offset: 0x0006E709
		public virtual global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] PreComp
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

		// Token: 0x040009E7 RID: 2535
		protected global::Org.BouncyCastle.Math.EC.AbstractF2mPoint[] m_preComp;
	}
}
