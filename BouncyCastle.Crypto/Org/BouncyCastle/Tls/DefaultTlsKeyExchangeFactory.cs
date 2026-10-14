using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B1 RID: 177
	public class DefaultTlsKeyExchangeFactory : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchangeFactory
	{
		// Token: 0x060006AA RID: 1706 RVA: 0x0001B5DC File Offset: 0x000197DC
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Tls.TlsDHKeyExchange(keyExchange);
		}

		// Token: 0x060006AB RID: 1707 RVA: 0x0001B5E4 File Offset: 0x000197E4
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			return new global::Org.BouncyCastle.Tls.TlsDHanonKeyExchange(keyExchange, dhGroupVerifier);
		}

		// Token: 0x060006AC RID: 1708 RVA: 0x0001B5ED File Offset: 0x000197ED
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			return new global::Org.BouncyCastle.Tls.TlsDHanonKeyExchange(keyExchange, dhConfig);
		}

		// Token: 0x060006AD RID: 1709 RVA: 0x0001B5F6 File Offset: 0x000197F6
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			return new global::Org.BouncyCastle.Tls.TlsDheKeyExchange(keyExchange, dhGroupVerifier);
		}

		// Token: 0x060006AE RID: 1710 RVA: 0x0001B5FF File Offset: 0x000197FF
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			return new global::Org.BouncyCastle.Tls.TlsDheKeyExchange(keyExchange, dhConfig);
		}

		// Token: 0x060006AF RID: 1711 RVA: 0x0001B608 File Offset: 0x00019808
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Tls.TlsECDHKeyExchange(keyExchange);
		}

		// Token: 0x060006B0 RID: 1712 RVA: 0x0001B610 File Offset: 0x00019810
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange)
		{
			return new global::Org.BouncyCastle.Tls.TlsECDHanonKeyExchange(keyExchange);
		}

		// Token: 0x060006B1 RID: 1713 RVA: 0x0001B618 File Offset: 0x00019818
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			return new global::Org.BouncyCastle.Tls.TlsECDHanonKeyExchange(keyExchange, ecConfig);
		}

		// Token: 0x060006B2 RID: 1714 RVA: 0x0001B621 File Offset: 0x00019821
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange)
		{
			return new global::Org.BouncyCastle.Tls.TlsECDheKeyExchange(keyExchange);
		}

		// Token: 0x060006B3 RID: 1715 RVA: 0x0001B629 File Offset: 0x00019829
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			return new global::Org.BouncyCastle.Tls.TlsECDheKeyExchange(keyExchange, ecConfig);
		}

		// Token: 0x060006B4 RID: 1716 RVA: 0x0001B632 File Offset: 0x00019832
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			return new global::Org.BouncyCastle.Tls.TlsPskKeyExchange(keyExchange, pskIdentity, dhGroupVerifier);
		}

		// Token: 0x060006B5 RID: 1717 RVA: 0x0001B63C File Offset: 0x0001983C
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			return new global::Org.BouncyCastle.Tls.TlsPskKeyExchange(keyExchange, pskIdentityManager, dhConfig, ecConfig);
		}

		// Token: 0x060006B6 RID: 1718 RVA: 0x0001B648 File Offset: 0x00019848
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateRsaKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Tls.TlsRsaKeyExchange(keyExchange);
		}

		// Token: 0x060006B7 RID: 1719 RVA: 0x0001B650 File Offset: 0x00019850
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpIdentity srpIdentity, global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier srpConfigVerifier)
		{
			return new global::Org.BouncyCastle.Tls.TlsSrpKeyExchange(keyExchange, srpIdentity, srpConfigVerifier);
		}

		// Token: 0x060006B8 RID: 1720 RVA: 0x0001B65A File Offset: 0x0001985A
		public override global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpLoginParameters loginParameters)
		{
			return new global::Org.BouncyCastle.Tls.TlsSrpKeyExchange(keyExchange, loginParameters);
		}
	}
}
