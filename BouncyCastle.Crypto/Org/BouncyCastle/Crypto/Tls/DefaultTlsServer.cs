using System;
using Org.BouncyCastle.Crypto.Agreement;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031B RID: 795
	public abstract class DefaultTlsServer : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsServer
	{
		// Token: 0x06002177 RID: 8567 RVA: 0x000939DC File Offset: 0x00091BDC
		public DefaultTlsServer()
		{
		}

		// Token: 0x06002178 RID: 8568 RVA: 0x000939E4 File Offset: 0x00091BE4
		public DefaultTlsServer(global::Org.BouncyCastle.Crypto.Tls.TlsCipherFactory cipherFactory) : base(cipherFactory)
		{
		}

		// Token: 0x06002179 RID: 8569 RVA: 0x000939ED File Offset: 0x00091BED
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600217A RID: 8570 RVA: 0x000939F6 File Offset: 0x00091BF6
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetECDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600217B RID: 8571 RVA: 0x000939FF File Offset: 0x00091BFF
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials GetRsaEncryptionCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600217C RID: 8572 RVA: 0x00093A08 File Offset: 0x00091C08
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials GetRsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x0600217D RID: 8573 RVA: 0x00093A11 File Offset: 0x00091C11
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.DHParameters GetDHParameters()
		{
			return global::Org.BouncyCastle.Crypto.Agreement.DHStandardGroups.rfc7919_ffdhe2048;
		}

		// Token: 0x0600217E RID: 8574 RVA: 0x00093A18 File Offset: 0x00091C18
		protected override int[] GetCipherSuites()
		{
			return new int[]
			{
				49200,
				49199,
				49192,
				49191,
				49172,
				49171,
				159,
				158,
				107,
				103,
				57,
				51,
				157,
				156,
				61,
				60,
				53,
				47
			};
		}

		// Token: 0x0600217F RID: 8575 RVA: 0x00093A2C File Offset: 0x00091C2C
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials()
		{
			int keyExchangeAlgorithm = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.GetKeyExchangeAlgorithm(this.mSelectedCipherSuite);
			switch (keyExchangeAlgorithm)
			{
			case 1:
				return this.GetRsaEncryptionCredentials();
			case 2:
			case 4:
				goto IL_66;
			case 3:
				return this.GetDsaSignerCredentials();
			case 5:
				break;
			default:
				if (keyExchangeAlgorithm != 11)
				{
					switch (keyExchangeAlgorithm)
					{
					case 17:
						return this.GetECDsaSignerCredentials();
					case 18:
						goto IL_66;
					case 19:
						goto IL_58;
					case 20:
						break;
					default:
						goto IL_66;
					}
				}
				return null;
			}
			IL_58:
			return this.GetRsaSignerCredentials();
			IL_66:
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002180 RID: 8576 RVA: 0x00093AA8 File Offset: 0x00091CA8
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

		// Token: 0x06002181 RID: 8577 RVA: 0x00093B49 File Offset: 0x00091D49
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDHKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, null, this.GetDHParameters());
		}

		// Token: 0x06002182 RID: 8578 RVA: 0x00093B5E File Offset: 0x00091D5E
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateDheKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDheKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, null, this.GetDHParameters());
		}

		// Token: 0x06002183 RID: 8579 RVA: 0x00093B73 File Offset: 0x00091D73
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDHKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsECDHKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06002184 RID: 8580 RVA: 0x00093B93 File Offset: 0x00091D93
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateECDheKeyExchange(int keyExchange)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsECDheKeyExchange(keyExchange, this.mSupportedSignatureAlgorithms, this.mNamedCurves, this.mClientECPointFormats, this.mServerECPointFormats);
		}

		// Token: 0x06002185 RID: 8581 RVA: 0x00093BB3 File Offset: 0x00091DB3
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange CreateRsaKeyExchange()
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsRsaKeyExchange(this.mSupportedSignatureAlgorithms);
		}
	}
}
