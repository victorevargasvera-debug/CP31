using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000E1 RID: 225
	public class PskTlsClient : global::Org.BouncyCastle.Tls.AbstractTlsClient
	{
		// Token: 0x06000817 RID: 2071 RVA: 0x00021ED1 File Offset: 0x000200D1
		public PskTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, byte[] identity, byte[] psk) : this(crypto, new global::Org.BouncyCastle.Tls.BasicTlsPskIdentity(identity, psk))
		{
		}

		// Token: 0x06000818 RID: 2072 RVA: 0x00021EE1 File Offset: 0x000200E1
		public PskTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity) : base(crypto)
		{
			this.m_pskIdentity = pskIdentity;
		}

		// Token: 0x06000819 RID: 2073 RVA: 0x00021EF1 File Offset: 0x000200F1
		protected override global::Org.BouncyCastle.Tls.ProtocolVersion[] GetSupportedVersions()
		{
			return global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv12.DownTo(global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10);
		}

		// Token: 0x0600081A RID: 2074 RVA: 0x00021F02 File Offset: 0x00020102
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.PskTlsClient.DefaultCipherSuites);
		}

		// Token: 0x0600081B RID: 2075 RVA: 0x00021F14 File Offset: 0x00020114
		public override global::Org.BouncyCastle.Tls.TlsPskIdentity GetPskIdentity()
		{
			return this.m_pskIdentity;
		}

		// Token: 0x0600081C RID: 2076 RVA: 0x00021F1C File Offset: 0x0002011C
		public override global::Org.BouncyCastle.Tls.TlsAuthentication GetAuthentication()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0400062B RID: 1579
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			52396,
			49207,
			49205,
			52397,
			170,
			178,
			144
		};

		// Token: 0x0400062C RID: 1580
		protected readonly global::Org.BouncyCastle.Tls.TlsPskIdentity m_pskIdentity;
	}
}
