using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200021C RID: 540
	public class ScaleYPointMap : global::Org.BouncyCastle.Math.EC.ECPointMap
	{
		// Token: 0x060015BF RID: 5567 RVA: 0x00066CA0 File Offset: 0x00064EA0
		public ScaleYPointMap(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			this.scale = scale;
		}

		// Token: 0x060015C0 RID: 5568 RVA: 0x00066CAF File Offset: 0x00064EAF
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Map(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			return p.ScaleY(this.scale);
		}

		// Token: 0x04000973 RID: 2419
		protected readonly global::Org.BouncyCastle.Math.EC.ECFieldElement scale;
	}
}
