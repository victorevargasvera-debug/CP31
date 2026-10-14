using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000219 RID: 537
	public class ScaleXNegateYPointMap : global::Org.BouncyCastle.Math.EC.ECPointMap
	{
		// Token: 0x060015B9 RID: 5561 RVA: 0x00066C49 File Offset: 0x00064E49
		public ScaleXNegateYPointMap(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			this.scale = scale;
		}

		// Token: 0x060015BA RID: 5562 RVA: 0x00066C58 File Offset: 0x00064E58
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Map(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return p.ScaleXNegateY(this.scale);
		}

		// Token: 0x04000970 RID: 2416
		protected readonly global::Org.BouncyCastle.Math.EC.ECFieldElement scale;
	}
}
