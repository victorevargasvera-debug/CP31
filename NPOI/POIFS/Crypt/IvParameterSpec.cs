using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002FC RID: 764
	public class IvParameterSpec : global::NPOI.POIFS.Crypt.AlgorithmParameterSpec
	{
		// Token: 0x06001606 RID: 5638 RVA: 0x00042189 File Offset: 0x00040389
		public IvParameterSpec(byte[] iv)
		{
			this.iv = iv;
		}

		// Token: 0x06001607 RID: 5639 RVA: 0x00042198 File Offset: 0x00040398
		public byte[] GetIV()
		{
			return this.iv;
		}

		// Token: 0x040008F5 RID: 2293
		private byte[] iv;
	}
}
