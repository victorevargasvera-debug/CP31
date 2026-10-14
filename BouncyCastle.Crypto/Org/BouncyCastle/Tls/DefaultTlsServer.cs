using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000B2 RID: 178
	public abstract class DefaultTlsServer : global::Org.BouncyCastle.Tls.AbstractTlsServer
	{
		// Token: 0x060006BA RID: 1722 RVA: 0x0001B66B File Offset: 0x0001986B
		public DefaultTlsServer(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto) : base(crypto)
		{
		}

		// Token: 0x060006BB RID: 1723 RVA: 0x0001B674 File Offset: 0x00019874
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedSigner GetDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060006BC RID: 1724 RVA: 0x0001B67D File Offset: 0x0001987D
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedSigner GetECDsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060006BD RID: 1725 RVA: 0x0001B686 File Offset: 0x00019886
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor GetRsaEncryptionCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060006BE RID: 1726 RVA: 0x0001B68F File Offset: 0x0001988F
		protected virtual global::Org.BouncyCastle.Tls.TlsCredentialedSigner GetRsaSignerCredentials()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x060006BF RID: 1727 RVA: 0x0001B698 File Offset: 0x00019898
		protected override int[] GetSupportedCipherSuites()
		{
			return global::Org.BouncyCastle.Tls.TlsUtilities.GetSupportedCipherSuites(this.Crypto, global::Org.BouncyCastle.Tls.DefaultTlsServer.DefaultCipherSuites);
		}

		// Token: 0x060006C0 RID: 1728 RVA: 0x0001B6AC File Offset: 0x000198AC
		public override global::Org.BouncyCastle.Tls.TlsCredentials GetCredentials()
		{
			int keyExchangeAlgorithm = this.m_context.SecurityParameters.KeyExchangeAlgorithm;
			switch (keyExchangeAlgorithm)
			{
			case 1:
				return this.GetRsaEncryptionCredentials();
			case 2:
			case 4:
				goto IL_6B;
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
						goto IL_6B;
					case 19:
						goto IL_5D;
					case 20:
						break;
					default:
						goto IL_6B;
					}
				}
				return null;
			}
			IL_5D:
			return this.GetRsaSignerCredentials();
			IL_6B:
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x040004D1 RID: 1233
		private static readonly int[] DefaultCipherSuites = new int[]
		{
			52392,
			49200,
			49199,
			49192,
			49191,
			49172,
			49171,
			52394,
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
}
