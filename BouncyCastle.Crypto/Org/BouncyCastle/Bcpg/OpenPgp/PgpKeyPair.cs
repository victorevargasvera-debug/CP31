using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005AA RID: 1450
	public class PgpKeyPair
	{
		// Token: 0x0600363B RID: 13883 RVA: 0x0010101E File Offset: 0x000FF21E
		public PgpKeyPair(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.AsymmetricCipherKeyPair keyPair, global::System.DateTime time) : this(algorithm, keyPair.Public, keyPair.Private, time)
		{
		}

		// Token: 0x0600363C RID: 13884 RVA: 0x00101034 File Offset: 0x000FF234
		public PgpKeyPair(global::Org.BouncyCastle.Bcpg.PublicKeyAlgorithmTag algorithm, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privKey, global::System.DateTime time)
		{
			this.pub = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey(algorithm, pubKey, time);
			this.priv = new global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey(this.pub.KeyId, this.pub.PublicKeyPacket, privKey);
		}

		// Token: 0x0600363D RID: 13885 RVA: 0x0010106D File Offset: 0x000FF26D
		public PgpKeyPair(global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pub, global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey priv)
		{
			this.pub = pub;
			this.priv = priv;
		}

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x0600363E RID: 13886 RVA: 0x00101083 File Offset: 0x000FF283
		public long KeyId
		{
			get
			{
				return this.pub.KeyId;
			}
		}

		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x0600363F RID: 13887 RVA: 0x00101090 File Offset: 0x000FF290
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey PublicKey
		{
			get
			{
				return this.pub;
			}
		}

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x06003640 RID: 13888 RVA: 0x00101098 File Offset: 0x000FF298
		public global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey PrivateKey
		{
			get
			{
				return this.priv;
			}
		}

		// Token: 0x040018B7 RID: 6327
		private readonly global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPublicKey pub;

		// Token: 0x040018B8 RID: 6328
		private readonly global::Org.BouncyCastle.Bcpg.OpenPgp.PgpPrivateKey priv;
	}
}
