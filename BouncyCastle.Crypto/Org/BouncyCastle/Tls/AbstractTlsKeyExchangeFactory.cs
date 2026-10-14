using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000089 RID: 137
	public abstract class AbstractTlsKeyExchangeFactory : global::Org.BouncyCastle.Tls.TlsKeyExchangeFactory
	{
		// Token: 0x0600059E RID: 1438 RVA: 0x00018CC4 File Offset: 0x00016EC4
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600059F RID: 1439 RVA: 0x00018CCD File Offset: 0x00016ECD
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A0 RID: 1440 RVA: 0x00018CD6 File Offset: 0x00016ED6
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A1 RID: 1441 RVA: 0x00018CDF File Offset: 0x00016EDF
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A2 RID: 1442 RVA: 0x00018CE8 File Offset: 0x00016EE8
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A3 RID: 1443 RVA: 0x00018CF1 File Offset: 0x00016EF1
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A4 RID: 1444 RVA: 0x00018CFA File Offset: 0x00016EFA
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeClient(int keyExchange)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A5 RID: 1445 RVA: 0x00018D03 File Offset: 0x00016F03
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDHanonKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A6 RID: 1446 RVA: 0x00018D0C File Offset: 0x00016F0C
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeClient(int keyExchange)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A7 RID: 1447 RVA: 0x00018D15 File Offset: 0x00016F15
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateECDheKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A8 RID: 1448 RVA: 0x00018D1E File Offset: 0x00016F1E
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentity pskIdentity, global::Org.BouncyCastle.Tls.TlsDHGroupVerifier dhGroupVerifier)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005A9 RID: 1449 RVA: 0x00018D27 File Offset: 0x00016F27
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreatePskKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsPskIdentityManager pskIdentityManager, global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig, global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005AA RID: 1450 RVA: 0x00018D30 File Offset: 0x00016F30
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateRsaKeyExchange(int keyExchange)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005AB RID: 1451 RVA: 0x00018D39 File Offset: 0x00016F39
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeClient(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpIdentity srpIdentity, global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier srpConfigVerifier)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060005AC RID: 1452 RVA: 0x00018D42 File Offset: 0x00016F42
		public virtual global::Org.BouncyCastle.Tls.TlsKeyExchange CreateSrpKeyExchangeServer(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpLoginParameters loginParameters)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}
	}
}
