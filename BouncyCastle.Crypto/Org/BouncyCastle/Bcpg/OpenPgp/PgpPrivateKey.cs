using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005B7 RID: 1463
	public class PgpPrivateKey
	{
		// Token: 0x06003690 RID: 13968 RVA: 0x00102256 File Offset: 0x00100456
		public PgpPrivateKey(long keyID, global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicKeyPacket, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("Expected a private key", "privateKey");
			}
			this.keyID = keyID;
			this.publicKeyPacket = publicKeyPacket;
			this.privateKey = privateKey;
		}

		// Token: 0x17000759 RID: 1881
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x0010228B File Offset: 0x0010048B
		public long KeyId
		{
			get
			{
				return this.keyID;
			}
		}

		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x06003692 RID: 13970 RVA: 0x00102293 File Offset: 0x00100493
		public global::Org.BouncyCastle.Bcpg.PublicKeyPacket PublicKeyPacket
		{
			get
			{
				return this.publicKeyPacket;
			}
		}

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x06003693 RID: 13971 RVA: 0x0010229B File Offset: 0x0010049B
		public global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter Key
		{
			get
			{
				return this.privateKey;
			}
		}

		// Token: 0x040018D7 RID: 6359
		private readonly long keyID;

		// Token: 0x040018D8 RID: 6360
		private readonly global::Org.BouncyCastle.Bcpg.PublicKeyPacket publicKeyPacket;

		// Token: 0x040018D9 RID: 6361
		private readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey;
	}
}
