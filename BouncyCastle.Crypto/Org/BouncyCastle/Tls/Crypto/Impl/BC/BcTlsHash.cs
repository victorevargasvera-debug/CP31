using System;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200017D RID: 381
	internal sealed class BcTlsHash : global::Org.BouncyCastle.Tls.Crypto.TlsHash
	{
		// Token: 0x06000E9F RID: 3743 RVA: 0x00035FC7 File Offset: 0x000341C7
		internal BcTlsHash(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, int cryptoHashAlgorithm) : this(crypto, cryptoHashAlgorithm, crypto.CreateDigest(cryptoHashAlgorithm))
		{
		}

		// Token: 0x06000EA0 RID: 3744 RVA: 0x00035FD8 File Offset: 0x000341D8
		private BcTlsHash(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, int cryptoHashAlgorithm, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			this.m_crypto = crypto;
			this.m_cryptoHashAlgorithm = cryptoHashAlgorithm;
			this.m_digest = digest;
		}

		// Token: 0x06000EA1 RID: 3745 RVA: 0x00035FF5 File Offset: 0x000341F5
		public void Update(byte[] data, int offSet, int length)
		{
			this.m_digest.BlockUpdate(data, offSet, length);
		}

		// Token: 0x06000EA2 RID: 3746 RVA: 0x00036008 File Offset: 0x00034208
		public byte[] CalculateHash()
		{
			byte[] rv = new byte[this.m_digest.GetDigestSize()];
			this.m_digest.DoFinal(rv, 0);
			return rv;
		}

		// Token: 0x06000EA3 RID: 3747 RVA: 0x00036038 File Offset: 0x00034238
		public global::Org.BouncyCastle.Tls.Crypto.TlsHash CloneHash()
		{
			global::Org.BouncyCastle.Crypto.IDigest clone = this.m_crypto.CloneDigest(this.m_cryptoHashAlgorithm, this.m_digest);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsHash(this.m_crypto, this.m_cryptoHashAlgorithm, clone);
		}

		// Token: 0x06000EA4 RID: 3748 RVA: 0x0003606F File Offset: 0x0003426F
		public void Reset()
		{
			this.m_digest.Reset();
		}

		// Token: 0x0400082B RID: 2091
		private readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x0400082C RID: 2092
		private readonly int m_cryptoHashAlgorithm;

		// Token: 0x0400082D RID: 2093
		private readonly global::Org.BouncyCastle.Crypto.IDigest m_digest;
	}
}
