using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000210 RID: 528
	public interface ECLookupTable
	{
		// Token: 0x1700029A RID: 666
		// (get) Token: 0x0600150F RID: 5391
		int Size { get; }

		// Token: 0x06001510 RID: 5392
		global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index);

		// Token: 0x06001511 RID: 5393
		global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index);
	}
}
