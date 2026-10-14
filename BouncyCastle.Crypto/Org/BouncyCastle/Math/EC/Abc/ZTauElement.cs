using System;

namespace Org.BouncyCastle.Math.EC.Abc
{
	// Token: 0x020002B1 RID: 689
	internal class ZTauElement
	{
		// Token: 0x06001EDD RID: 7901 RVA: 0x0008EFE4 File Offset: 0x0008D1E4
		public ZTauElement(global::Org.BouncyCastle.Math.BigInteger u, global::Org.BouncyCastle.Math.BigInteger v)
		{
			this.u = u;
			this.v = v;
		}

		// Token: 0x04000B14 RID: 2836
		public readonly global::Org.BouncyCastle.Math.BigInteger u;

		// Token: 0x04000B15 RID: 2837
		public readonly global::Org.BouncyCastle.Math.BigInteger v;
	}
}
