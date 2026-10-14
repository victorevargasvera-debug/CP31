using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018B RID: 395
	internal sealed class BcTlsStreamVerifier : global::Org.BouncyCastle.Tls.Crypto.TlsStreamVerifier
	{
		// Token: 0x06000ED8 RID: 3800 RVA: 0x00036C78 File Offset: 0x00034E78
		internal BcTlsStreamVerifier(global::Org.BouncyCastle.Crypto.ISigner verifier, byte[] signature)
		{
			this.m_output = new global::Org.BouncyCastle.Crypto.IO.SignerSink(verifier);
			this.m_signature = signature;
		}

		// Token: 0x06000ED9 RID: 3801 RVA: 0x00036C93 File Offset: 0x00034E93
		public global::System.IO.Stream GetOutputStream()
		{
			return this.m_output;
		}

		// Token: 0x06000EDA RID: 3802 RVA: 0x00036C9B File Offset: 0x00034E9B
		public bool IsVerified()
		{
			return this.m_output.Signer.VerifySignature(this.m_signature);
		}

		// Token: 0x0400083D RID: 2109
		private readonly global::Org.BouncyCastle.Crypto.IO.SignerSink m_output;

		// Token: 0x0400083E RID: 2110
		private readonly byte[] m_signature;
	}
}
