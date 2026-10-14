using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200035D RID: 861
	internal class TlsClientContextImpl : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsContext, global::Org.BouncyCastle.Crypto.Tls.TlsClientContext, global::Org.BouncyCastle.Crypto.Tls.TlsContext
	{
		// Token: 0x06002312 RID: 8978 RVA: 0x00099BE3 File Offset: 0x00097DE3
		internal TlsClientContextImpl(global::Org.BouncyCastle.Security.SecureRandom secureRandom, global::Org.BouncyCastle.Crypto.Tls.SecurityParameters securityParameters) : base(secureRandom, securityParameters)
		{
		}

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06002313 RID: 8979 RVA: 0x00099BED File Offset: 0x00097DED
		public override bool IsServer
		{
			get
			{
				return false;
			}
		}
	}
}
