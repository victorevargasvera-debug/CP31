using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Operators
{
	// Token: 0x0200042F RID: 1071
	public class DefaultVerifierResult : global::Org.BouncyCastle.Crypto.IVerifier
	{
		// Token: 0x0600293A RID: 10554 RVA: 0x000AEFA2 File Offset: 0x000AD1A2
		public DefaultVerifierResult(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.mSigner = signer;
		}

		// Token: 0x0600293B RID: 10555 RVA: 0x000AEFB1 File Offset: 0x000AD1B1
		public bool IsVerified(byte[] signature)
		{
			return this.mSigner.VerifySignature(signature);
		}

		// Token: 0x0600293C RID: 10556 RVA: 0x000AEFC0 File Offset: 0x000AD1C0
		public bool IsVerified(byte[] sig, int sigOff, int sigLen)
		{
			byte[] signature = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(sig, sigOff, sigOff + sigLen);
			return this.IsVerified(signature);
		}

		// Token: 0x040010B6 RID: 4278
		private readonly global::Org.BouncyCastle.Crypto.ISigner mSigner;
	}
}
