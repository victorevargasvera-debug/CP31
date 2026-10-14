using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x02000305 RID: 773
	public interface IKey
	{
		// Token: 0x06001679 RID: 5753
		string GetAlgorithm();

		// Token: 0x0600167A RID: 5754
		string GetFormat();

		// Token: 0x0600167B RID: 5755
		byte[] GetEncoded();
	}
}
