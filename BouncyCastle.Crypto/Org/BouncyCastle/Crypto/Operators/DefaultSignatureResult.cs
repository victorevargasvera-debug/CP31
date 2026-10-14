using System;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042D RID: 1069
	public class DefaultSignatureResult : global::Org.BouncyCastle.Crypto.IBlockResult
	{
		// Token: 0x06002934 RID: 10548 RVA: 0x000AEF46 File Offset: 0x000AD146
		public DefaultSignatureResult(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.mSigner = signer;
		}

		// Token: 0x06002935 RID: 10549 RVA: 0x000AEF55 File Offset: 0x000AD155
		public byte[] Collect()
		{
			return this.mSigner.GenerateSignature();
		}

		// Token: 0x06002936 RID: 10550 RVA: 0x000AEF62 File Offset: 0x000AD162
		public int Collect(byte[] sig, int sigOff)
		{
			byte[] array = this.Collect();
			array.CopyTo(sig, sigOff);
			return array.Length;
		}

		// Token: 0x040010B4 RID: 4276
		private readonly global::Org.BouncyCastle.Crypto.ISigner mSigner;
	}
}
