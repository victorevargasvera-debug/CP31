using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000AD RID: 173
	public abstract class DefaultTlsClient : global::Org.BouncyCastle.Tls.AbstractTlsClient
	{
		// Token: 0x06000692 RID: 1682 RVA: 0x0001B295 File Offset: 0x00019495
		public DefaultTlsClient(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto)
		{
		}

		// Token: 0x06000693 RID: 1683 RVA: 0x0001B29E File Offset: 0x0001949E
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.DefaultTlsClient.DefaultCipherSuites);
		}

		// Token: 0x040004C5 RID: 1221
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			52393,
			49195,
			49187,
			49161,
			52392,
			49199,
			49191,
			49171,
			52394,
			158,
			103,
			51,
			156,
			60,
			47
		};
	}
}
