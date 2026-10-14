using System;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC.Endo
{
	// Token: 0x0200023B RID: 571
	public class EndoPreCompInfo : global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo
	{
		// Token: 0x170002B9 RID: 697
		// (get) Token: 0x0600171D RID: 5917 RVA: 0x000705EE File Offset: 0x0006E7EE
		// (set) Token: 0x0600171E RID: 5918 RVA: 0x000705F6 File Offset: 0x0006E7F6
		public virtual global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism Endomorphism
		{
			get
			{
				return this.m_endomorphism;
			}
			set
			{
				this.m_endomorphism = value;
			}
		}

		// Token: 0x170002BA RID: 698
		// (get) Token: 0x0600171F RID: 5919 RVA: 0x000705FF File Offset: 0x0006E7FF
		// (set) Token: 0x06001720 RID: 5920 RVA: 0x00070607 File Offset: 0x0006E807
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint MappedPoint
		{
			get
			{
				return this.m_mappedPoint;
			}
			set
			{
				this.m_mappedPoint = value;
			}
		}

		// Token: 0x040009E8 RID: 2536
		protected global::Org.BouncyCastle.Math.EC.Endo.ECEndomorphism m_endomorphism;

		// Token: 0x040009E9 RID: 2537
		protected global::Org.BouncyCastle.Math.EC.ECPoint m_mappedPoint;
	}
}
