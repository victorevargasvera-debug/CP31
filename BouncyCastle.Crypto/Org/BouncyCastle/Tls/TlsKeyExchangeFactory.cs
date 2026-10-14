using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000113 RID: 275
	public interface TlsKeyExchangeFactory
	{
		// Token: 0x06000A69 RID: 2665
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange);

		// Token: 0x06000A6A RID: 2666
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier);

		// Token: 0x06000A6B RID: 2667
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig);

		// Token: 0x06000A6C RID: 2668
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier);

		// Token: 0x06000A6D RID: 2669
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig);

		// Token: 0x06000A6E RID: 2670
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange);

		// Token: 0x06000A6F RID: 2671
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange);

		// Token: 0x06000A70 RID: 2672
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig);

		// Token: 0x06000A71 RID: 2673
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange);

		// Token: 0x06000A72 RID: 2674
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig);

		// Token: 0x06000A73 RID: 2675
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier);

		// Token: 0x06000A74 RID: 2676
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig);

		// Token: 0x06000A75 RID: 2677
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateRsaKeyExchange(int keyExchange);

		// Token: 0x06000A76 RID: 2678
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpIdentity srpIdentity, global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier srpConfigVerifier);

		// Token: 0x06000A77 RID: 2679
		global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpLoginParameters loginParameters);
	}
}
