using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000FB RID: 251
	internal class TlsClientContextImpl : global::Org.BouncyCastle.Tls.AbstractTlsContext, global::Org.BouncyCastle.Tls.TlsClientContext, global::Org.BouncyCastle.Tls.TlsContext
	{
		// Token: 0x06000901 RID: 2305 RVA: 0x00023C1D File Offset: 0x00021E1D
		internal TlsClientContextImpl(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto, 1)
		{
		}

		// Token: 0x17000195 RID: 405
		// (get) Token: 0x06000902 RID: 2306 RVA: 0x00023C27 File Offset: 0x00021E27
		public override bool IsServer
		{
			get
			{
				return false;
			}
		}
	}
}
