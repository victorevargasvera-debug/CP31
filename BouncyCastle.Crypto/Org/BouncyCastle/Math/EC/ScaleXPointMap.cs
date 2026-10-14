using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200021A RID: 538
	public class ScaleXPointMap : global::Org.BouncyCastle.Math.EC.ECPointMap
	{
		// Token: 0x060015BB RID: 5563 RVA: 0x00066C66 File Offset: 0x00064E66
		public ScaleXPointMap(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			this.scale = scale;
		}

		// Token: 0x060015BC RID: 5564 RVA: 0x00066C75 File Offset: 0x00064E75
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Map(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return p.ScaleX(this.scale);
		}

		// Token: 0x04000971 RID: 2417
		protected readonly global::Org.BouncyCastle.Math.EC.ECFieldElement scale;
	}
}
