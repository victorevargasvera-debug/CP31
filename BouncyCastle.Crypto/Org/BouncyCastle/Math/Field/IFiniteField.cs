using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000200 RID: 512
	public interface IFiniteField
	{
		// Token: 0x1700026E RID: 622
		// (get) Token: 0x0600142C RID: 5164
		global::Org.BouncyCastle.Math.BigInteger Characteristic { get; }

		// Token: 0x1700026F RID: 623
		// (get) Token: 0x0600142D RID: 5165
		int Dimension { get; }
	}
}
