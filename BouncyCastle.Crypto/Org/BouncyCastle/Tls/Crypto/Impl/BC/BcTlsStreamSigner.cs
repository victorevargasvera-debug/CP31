using System;
using System.IO;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200018A RID: 394
	internal sealed class BcTlsStreamSigner : global::Org.BouncyCastle.Tls.Crypto.TlsStreamSigner
	{
		// Token: 0x06000ED5 RID: 3797 RVA: 0x00036C1F File Offset: 0x00034E1F
		internal BcTlsStreamSigner(global::Org.BouncyCastle.Crypto.ISigner signer)
		{
			this.m_output = new global::Org.BouncyCastle.Crypto.IO.SignerSink(signer);
		}

		// Token: 0x06000ED6 RID: 3798 RVA: 0x00036C33 File Offset: 0x00034E33
		public global::System.IO.Stream GetOutputStream()
		{
			return this.m_output;
		}

		// Token: 0x06000ED7 RID: 3799 RVA: 0x00036C3C File Offset: 0x00034E3C
		public byte[] GetSignature()
		{
			byte[] result;
			try
			{
				result = this.m_output.Signer.GenerateSignature();
			}
			catch (global::Org.BouncyCastle.Crypto.CryptoException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			return result;
		}

		// Token: 0x0400083C RID: 2108
		private readonly global::Org.BouncyCastle.Crypto.IO.SignerSink m_output;
	}
}
