using System;

namespace Org.BouncyCastle.Math.Field
{
	// Token: 0x02000201 RID: 513
	public interface IPolynomial
	{
		// Token: 0x17000270 RID: 624
		// (get) Token: 0x0600142E RID: 5166
		int Degree { get; }

		// Token: 0x0600142F RID: 5167
		int[] GetExponentsPresent();
	}
}
