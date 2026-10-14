using System;
using System.IO;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000129 RID: 297
	public class TlsSrpKeyExchange : global::Org.BouncyCastle.Tls.AbstractTlsKeyExchange
	{
		// Token: 0x06000B64 RID: 2916 RVA: 0x0002B480 File Offset: 0x00029680
		private static int CheckKeyExchange(int keyExchange)
		{
			if (keyExchange - 21 <= 2)
			{
				return keyExchange;
			}
			throw new global::System.ArgumentException("unsupported key exchange algorithm", "keyExchange");
		}

		// Token: 0x06000B65 RID: 2917 RVA: 0x0002B49A File Offset: 0x0002969A
		public TlsSrpKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpIdentity srpIdentity, global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier srpConfigVerifier) : base(global::Org.BouncyCastle.Tls.TlsSrpKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_srpIdentity = srpIdentity;
			this.m_srpConfigVerifier = srpConfigVerifier;
		}

		// Token: 0x06000B66 RID: 2918 RVA: 0x0002B4B6 File Offset: 0x000296B6
		public TlsSrpKeyExchange(int keyExchange, global::Org.BouncyCastle.Tls.TlsSrpLoginParameters srpLoginParameters) : base(global::Org.BouncyCastle.Tls.TlsSrpKeyExchange.CheckKeyExchange(keyExchange))
		{
			this.m_srpLoginParameters = srpLoginParameters;
		}

		// Token: 0x06000B67 RID: 2919 RVA: 0x0002B4CB File Offset: 0x000296CB
		public override void SkipServerCredentials()
		{
			if (this.m_keyExchange != 21)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000B68 RID: 2920 RVA: 0x0002B4DF File Offset: 0x000296DF
		public override void ProcessServerCredentials(global::Org.BouncyCastle.Tls.TlsCredentials serverCredentials)
		{
			if (this.m_keyExchange == 21)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_serverCredentials = global::Org.BouncyCastle.Tls.TlsUtilities.RequireSignerCredentials(serverCredentials);
		}

		// Token: 0x06000B69 RID: 2921 RVA: 0x0002B4FF File Offset: 0x000296FF
		public override void ProcessServerCertificate(global::Org.BouncyCastle.Tls.Certificate serverCertificate)
		{
			if (this.m_keyExchange == 21)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_serverCertificate = serverCertificate.GetCertificateAt(0);
		}

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000B6A RID: 2922 RVA: 0x0002B520 File Offset: 0x00029720
		public override bool RequiresServerKeyExchange
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000B6B RID: 2923 RVA: 0x0002B524 File Offset: 0x00029724
		public override byte[] GenerateServerKeyExchange()
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig config = this.m_srpLoginParameters.Config;
			this.m_srpServer = this.m_context.Crypto.CreateSrp6Server(config, this.m_srpLoginParameters.Verifier);
			global::Org.BouncyCastle.Math.BigInteger B = this.m_srpServer.GenerateServerCredentials();
			global::Org.BouncyCastle.Math.BigInteger[] ng = config.GetExplicitNG();
			global::Org.BouncyCastle.Tls.ServerSrpParams serverSrpParams = new global::Org.BouncyCastle.Tls.ServerSrpParams(ng[0], ng[1], this.m_srpLoginParameters.Salt, B);
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
			serverSrpParams.Encode(digestBuffer);
			if (this.m_serverCredentials != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.GenerateServerKeyExchangeSignature(this.m_context, this.m_serverCredentials, null, digestBuffer);
			}
			return digestBuffer.ToArray();
		}

		// Token: 0x06000B6C RID: 2924 RVA: 0x0002B5B8 File Offset: 0x000297B8
		public override void ProcessServerKeyExchange(global::System.IO.Stream input)
		{
			global::Org.BouncyCastle.Tls.DigestInputBuffer digestBuffer = null;
			global::System.IO.Stream teeIn = input;
			if (this.m_keyExchange != 21)
			{
				digestBuffer = new global::Org.BouncyCastle.Tls.DigestInputBuffer();
				teeIn = new global::Org.BouncyCastle.Utilities.IO.TeeInputStream(input, digestBuffer);
			}
			global::Org.BouncyCastle.Tls.ServerSrpParams srpParams = global::Org.BouncyCastle.Tls.ServerSrpParams.Parse(teeIn);
			if (digestBuffer != null)
			{
				global::Org.BouncyCastle.Tls.TlsUtilities.VerifyServerKeyExchangeSignature(this.m_context, input, this.m_serverCertificate, null, digestBuffer);
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig config = new global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig();
			config.SetExplicitNG(new global::Org.BouncyCastle.Math.BigInteger[]
			{
				srpParams.N,
				srpParams.G
			});
			if (!this.m_srpConfigVerifier.Accept(config))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(71);
			}
			this.m_srpSalt = srpParams.S;
			this.m_srpPeerCredentials = global::Org.BouncyCastle.Tls.TlsSrpKeyExchange.ValidatePublicValue(srpParams.N, srpParams.B);
			this.m_srpClient = this.m_context.Crypto.CreateSrp6Client(config);
		}

		// Token: 0x06000B6D RID: 2925 RVA: 0x0002B673 File Offset: 0x00029873
		public override void ProcessClientCredentials(global::Org.BouncyCastle.Tls.TlsCredentials clientCredentials)
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000B6E RID: 2926 RVA: 0x0002B67C File Offset: 0x0002987C
		public override void GenerateClientKeyExchange(global::System.IO.Stream output)
		{
			byte[] identity = this.m_srpIdentity.GetSrpIdentity();
			byte[] password = this.m_srpIdentity.GetSrpPassword();
			global::Org.BouncyCastle.Tls.TlsSrpUtilities.WriteSrpParameter(this.m_srpClient.GenerateClientCredentials(this.m_srpSalt, identity, password), output);
			this.m_context.SecurityParameters.m_srpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
		}

		// Token: 0x06000B6F RID: 2927 RVA: 0x0002B6D0 File Offset: 0x000298D0
		public override void ProcessClientKeyExchange(global::System.IO.Stream input)
		{
			this.m_srpPeerCredentials = global::Org.BouncyCastle.Tls.TlsSrpKeyExchange.ValidatePublicValue(this.m_srpLoginParameters.Config.GetExplicitNG()[0], global::Org.BouncyCastle.Tls.TlsSrpUtilities.ReadSrpParameter(input));
			this.m_context.SecurityParameters.m_srpIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(this.m_srpLoginParameters.Identity);
		}

		// Token: 0x06000B70 RID: 2928 RVA: 0x0002B720 File Offset: 0x00029920
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GeneratePreMasterSecret()
		{
			global::Org.BouncyCastle.Math.BigInteger S = (this.m_srpServer != null) ? this.m_srpServer.CalculateSecret(this.m_srpPeerCredentials) : this.m_srpClient.CalculateSecret(this.m_srpPeerCredentials);
			return this.m_context.Crypto.CreateSecret(global::Org.BouncyCastle.Utilities.BigIntegers.AsUnsignedByteArray(S));
		}

		// Token: 0x06000B71 RID: 2929 RVA: 0x0002B770 File Offset: 0x00029970
		protected static global::Org.BouncyCastle.Math.BigInteger ValidatePublicValue(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger val)
		{
			val = val.Mod(N);
			if (val.Equals(global::Org.BouncyCastle.Math.BigInteger.Zero))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(47);
			}
			return val;
		}

		// Token: 0x04000746 RID: 1862
		protected global::Org.BouncyCastle.Tls.TlsSrpIdentity m_srpIdentity;

		// Token: 0x04000747 RID: 1863
		protected global::Org.BouncyCastle.Tls.TlsSrpConfigVerifier m_srpConfigVerifier;

		// Token: 0x04000748 RID: 1864
		protected global::Org.BouncyCastle.Tls.Crypto.TlsCertificate m_serverCertificate;

		// Token: 0x04000749 RID: 1865
		protected byte[] m_srpSalt;

		// Token: 0x0400074A RID: 1866
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Client m_srpClient;

		// Token: 0x0400074B RID: 1867
		protected global::Org.BouncyCastle.Tls.TlsSrpLoginParameters m_srpLoginParameters;

		// Token: 0x0400074C RID: 1868
		protected global::Org.BouncyCastle.Tls.TlsCredentialedSigner m_serverCredentials;

		// Token: 0x0400074D RID: 1869
		protected global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Server m_srpServer;

		// Token: 0x0400074E RID: 1870
		protected global::Org.BouncyCastle.Math.BigInteger m_srpPeerCredentials;
	}
}
