using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000384 RID: 900
	internal class TlsServerContextImpl : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext, global::Org.BouncyCastle.Crypto.Tls.TlsServerContext, global::Org.BouncyCastle.Crypto.Tls.TlsContext
	{
		// Token: 0x0600249A RID: 9370 RVA: 0x0009ED98 File Offset: 0x0009CF98
		internal TlsServerContextImpl(global::Org.BouncyCastle.Security.SecureRandom secureRandom, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters) : base(secureRandom, securityParameters)
		{
		}

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x0600249B RID: 9371 RVA: 0x0009EDA2 File Offset: 0x0009CFA2
		public override bool IsServer
		{
			get
			{
				return true;
			}
		}
	}
}
