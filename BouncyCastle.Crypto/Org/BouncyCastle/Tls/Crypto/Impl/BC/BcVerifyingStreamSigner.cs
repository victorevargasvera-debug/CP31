using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018D RID: 397
	internal sealed class BcVerifyingStreamSigner : global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner
	{
		// Token: 0x06000EDE RID: 3806 RVA: 0x00036D0C File Offset: 0x00034F0C
		internal BcVerifyingStreamSigner(global::Org.BouncyCastle.Crypto.ISigner signer, global::Org.BouncyCastle.Crypto.ISigner verifier)
		{
			global::System.IO.Stream outputSigner = new global::Org.BouncyCastle.Crypto.IO.SignerSink(signer);
			global::System.IO.Stream outputVerifier = new global::Org.BouncyCastle.Crypto.IO.SignerSink(verifier);
			this.m_signer = signer;
			this.m_verifier = verifier;
			this.m_output = new global::Org.BouncyCastle.Utilities.IO.TeeOutputStream(outputSigner, outputVerifier);
		}

		// Token: 0x06000EDF RID: 3807 RVA: 0x00036D48 File Offset: 0x00034F48
		public global::System.IO.Stream GetOutputStream()
		{
			return this.m_output;
		}

		// Token: 0x06000EE0 RID: 3808 RVA: 0x00036D50 File Offset: 0x00034F50
		public byte[] GetSignature()
		{
			try
			{
				byte[] signature = this.m_signer.GenerateSignature();
				if (this.m_verifier.VerifySignature(signature))
				{
					return signature;
				}
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x04000841 RID: 2113
		private readonly global::Org.BouncyCastle.Crypto.ISigner m_signer;

		// Token: 0x04000842 RID: 2114
		private readonly global::Org.BouncyCastle.Crypto.ISigner m_verifier;

		// Token: 0x04000843 RID: 2115
		private readonly global::Org.BouncyCastle.Utilities.IO.TeeOutputStream m_output;
	}
}
