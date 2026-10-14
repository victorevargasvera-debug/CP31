using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000122 RID: 290
	internal class TlsServerContextImpl : global::Org.BouncyCastle.Tls.AbstractTlsContext, global::Org.BouncyCastle.Tls.TlsServerContext, global::Org.BouncyCastle.Tls.TlsContext
	{
		// Token: 0x06000B33 RID: 2867 RVA: 0x00029BC4 File Offset: 0x00027DC4
		internal TlsServerContextImpl(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto, 0)
		{
		}

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000B34 RID: 2868 RVA: 0x00029BCE File Offset: 0x00027DCE
		public override bool IsServer
		{
			get
			{
				return true;
			}
		}
	}
}
