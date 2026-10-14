using System;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000A6 RID: 166
	public class CombinedHash : global::Org.BouncyCastle.Tls.Crypto.TlsHash
	{
		// Token: 0x06000682 RID: 1666 RVA: 0x0001B0DC File Offset: 0x000192DC
		internal CombinedHash(global::Org.BouncyCastle.Tls.TlsContext context, global::Org.BouncyCastle.Tls.Crypto.TlsHash md5, global::Org.BouncyCastle.Tls.Crypto.TlsHash sha1)
		{
			this.m_context = context;
			this.m_crypto = context.Crypto;
			this.m_md5 = md5;
			this.m_sha1 = sha1;
		}

		// Token: 0x06000683 RID: 1667 RVA: 0x0001B105 File Offset: 0x00019305
		public CombinedHash(global::Org.BouncyCastle.Tls.Crypto.TlsCrypto crypto)
		{
			this.m_crypto = crypto;
			this.m_md5 = crypto.CreateHash(1);
			this.m_sha1 = crypto.CreateHash(2);
		}

		// Token: 0x06000684 RID: 1668 RVA: 0x0001B130 File Offset: 0x00019330
		public CombinedHash(global::Org.BouncyCastle.Tls.CombinedHash t)
		{
			this.m_context = t.m_context;
			this.m_crypto = t.m_crypto;
			this.m_md5 = t.m_md5.CloneHash();
			this.m_sha1 = t.m_sha1.CloneHash();
		}

		// Token: 0x06000685 RID: 1669 RVA: 0x0001B17D File Offset: 0x0001937D
		public virtual void Update(byte[] input, int inOff, int len)
		{
			this.m_md5.Update(input, inOff, len);
			this.m_sha1.Update(input, inOff, len);
		}

		// Token: 0x06000686 RID: 1670 RVA: 0x0001B19C File Offset: 0x0001939C
		public virtual byte[] CalculateHash()
		{
			if (this.m_context != null && global::Org.BouncyCastle.Tls.TlsUtilities.IsSsl(this.m_context))
			{
				global::Org.BouncyCastle.Tls.Ssl3Utilities.CompleteCombinedHash(this.m_context, this.m_md5, this.m_sha1);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.Concatenate(this.m_md5.CalculateHash(), this.m_sha1.CalculateHash());
		}

		// Token: 0x06000687 RID: 1671 RVA: 0x0001B1F0 File Offset: 0x000193F0
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsHash CloneHash()
		{
			return new global::Org.BouncyCastle.Tls.CombinedHash(this);
		}

		// Token: 0x06000688 RID: 1672 RVA: 0x0001B1F8 File Offset: 0x000193F8
		public virtual void Reset()
		{
			this.m_md5.Reset();
			this.m_sha1.Reset();
		}

		// Token: 0x040004B8 RID: 1208
		protected readonly global::Org.BouncyCastle.Tls.TlsContext m_context;

		// Token: 0x040004B9 RID: 1209
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCrypto m_crypto;

		// Token: 0x040004BA RID: 1210
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsHash m_md5;

		// Token: 0x040004BB RID: 1211
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsHash m_sha1;
	}
}
