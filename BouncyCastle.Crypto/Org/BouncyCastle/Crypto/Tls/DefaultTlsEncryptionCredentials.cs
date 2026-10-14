using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200031A RID: 794
	public class DefaultTlsEncryptionCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsEncryptionCredentials
	{
		// Token: 0x06002174 RID: 8564 RVA: 0x00093924 File Offset: 0x00091B24
		public DefaultTlsEncryptionCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			if (certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("cannot be empty", "certificate");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("'privateKey' cannot be null");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be private", "privateKey");
			}
			if (!(privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters))
			{
				throw new global::System.ArgumentException("type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey), "privateKey");
			}
			this.mContext = context;
			this.mCertificate = certificate;
			this.mPrivateKey = privateKey;
		}

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06002175 RID: 8565 RVA: 0x000939BB File Offset: 0x00091BBB
		public override global::Org.BouncyCastle.Crypto.Tls.Certificate Certificate
		{
			get
			{
				return this.mCertificate;
			}
		}

		// Token: 0x06002176 RID: 8566 RVA: 0x000939C3 File Offset: 0x00091BC3
		public override byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret)
		{
			return global::Org.BouncyCastle.Crypto.Tls.TlsRsaUtilities.SafeDecryptPreMasterSecret(this.mContext, (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.mPrivateKey, encryptedPreMasterSecret);
		}

		// Token: 0x04000CD4 RID: 3284
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext mContext;

		// Token: 0x04000CD5 RID: 3285
		protected readonly global::Org.BouncyCastle.Crypto.Tls.Certificate mCertificate;

		// Token: 0x04000CD6 RID: 3286
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter mPrivateKey;
	}
}
