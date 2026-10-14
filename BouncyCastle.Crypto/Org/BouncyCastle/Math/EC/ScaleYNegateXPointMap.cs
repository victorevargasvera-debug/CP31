using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200021B RID: 539
	public class ScaleYNegateXPointMap : global::Org.BouncyCastle.Math.EC.ECPointMap
	{
		// Token: 0x060015BD RID: 5565 RVA: 0x00066C83 File Offset: 0x00064E83
		public ScaleYNegateXPointMap(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			this.scale = scale;
		}

		// Token: 0x060015BE RID: 5566 RVA: 0x00066C92 File Offset: 0x00064E92
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Map(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return p.ScaleYNegateX(this.scale);
		}

		// Token: 0x04000972 RID: 2418
		protected readonly global::Org.BouncyCastle.Math.EC.ECFieldElement scale;
	}
}
