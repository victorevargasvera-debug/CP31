using System;

namespace NPOI.POIFS.Crypt
{
	// Token: 0x020002FB RID: 763
	public class RC2ParameterSpec : global::NPOI.POIFS.Crypt.AlgorithmParameterSpec
	{
		// Token: 0x06001603 RID: 5635 RVA: 0x00042163 File Offset: 0x00040363
		public RC2ParameterSpec(int v, byte[] vec)
		{
			this.effectiveKeyBits = v;
			this.iv = vec;
		}

		// Token: 0x06001604 RID: 5636 RVA: 0x00042179 File Offset: 0x00040379
		public int GetEffectiveKeyBits()
		{
			return this.effectiveKeyBits;
		}

		// Token: 0x06001605 RID: 5637 RVA: 0x00042181 File Offset: 0x00040381
		public byte[] GetIV()
		{
			return this.iv;
		}

		// Token: 0x040008F3 RID: 2291
		private byte[] iv;

		// Token: 0x040008F4 RID: 2292
		private int effectiveKeyBits;
	}
}
