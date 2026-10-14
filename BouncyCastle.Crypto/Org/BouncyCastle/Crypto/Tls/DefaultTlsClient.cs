using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000318 RID: 792
	public abstract class DefaultTlsClient : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsClient
	{
		// Token: 0x0600215F RID: 8543 RVA: 0x00093625 File Offset: 0x00091825
		public DefaultTlsClient() : this(new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsCipherFactory())
		{
		}

		// Token: 0x06002160 RID: 8544 RVA: 0x00093632 File Offset: 0x00091832
		public DefaultTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : this(cipherFactory, new global::Org.BouncyCastle.Crypto.Tls.DefaultTlsDHVerifier())
		{
		}

		// Token: 0x06002161 RID: 8545 RVA: 0x00093640 File Offset: 0x00091840
		public DefaultTlsClient(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory, global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier dhVerifier) : base(cipherFactory)
		{
			this.mDHVerifier = dhVerifier;
		}

		// Token: 0x06002162 RID: 8546 RVA: 0x00093650 File Offset: 0x00091850
		public override int[] GetCipherSuites()
		{
			return new int[]
			{
				49195,
				49187,
				49161,
				49199,
				49191,
				49171,
				156,
				60,
				47
			};
		}

		// Token: 0x06002163 RID: 8547 RVA: 0x00093664 File Offset: 0x00091864
		public override global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			switch (keyExchangeAlgorithm)
			{
			case 1:
				return this.CreateRsaKeyExchange();
			case 3:
			case 5:
				return this.CreateDheKeyExchange(keyExchangeAlgorithm);
			case 7:
			case 9:
			case 11:
				return this.CreateDHKeyExchange(keyExchangeAlgorithm);
			case 16:
			case 18:
			case 20:
				return this.CreateECDHKeyExchange(keyExchangeAlgorithm);
			case 17:
			case 19:
				return this.CreateECDheKeyExchange(keyExchangeAlgorithm);
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002164 RID: 8548 RVA: 0x00093705 File Offset: 0x00091905
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDHKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mDHVerifier, null);
		}

		// Token: 0x06002165 RID: 8549 RVA: 0x0009371A File Offset: 0x0009191A
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDheKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDheKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mDHVerifier, null);
		}

		// Token: 0x06002166 RID: 8550 RVA: 0x0009372F File Offset: 0x0009192F
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsECDHKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06002167 RID: 8551 RVA: 0x0009374F File Offset: 0x0009194F
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDheKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsECDheKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06002168 RID: 8552 RVA: 0x0009376F File Offset: 0x0009196F
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateRsaKeyExchange()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaKeyExchange(this.mSupportedSignatureAlgorithms);
		}

		// Token: 0x04000CCF RID: 3279
		protected global::Org.BouncyCastle.Crypto.Tls.TlsDHVerifier mDHVerifier;
	}
}
