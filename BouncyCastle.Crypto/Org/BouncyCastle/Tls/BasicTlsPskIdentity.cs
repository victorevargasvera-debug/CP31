using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200008F RID: 143
	public class BasicTlsPskIdentity : global::Org.BouncyCastle.Tls.TlsPskIdentity
	{
		// Token: 0x06000603 RID: 1539 RVA: 0x0001984F File Offset: 0x00017A4F
		public BasicTlsPskIdentity(byte[] identity, byte[] psk)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.m_psk = global::Org.BouncyCastle.Utilities.Arrays.Clone(psk);
		}

		// Token: 0x06000604 RID: 1540 RVA: 0x0001986F File Offset: 0x00017A6F
		public BasicTlsPskIdentity(string identity, byte[] psk)
		{
			this.m_identity = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(identity);
			this.m_psk = global::Org.BouncyCastle.Utilities.Arrays.Clone(psk);
		}

		// Token: 0x06000605 RID: 1541 RVA: 0x0001988F File Offset: 0x00017A8F
		public virtual void SkipIdentityHint()
		{
		}

		// Token: 0x06000606 RID: 1542 RVA: 0x00019891 File Offset: 0x00017A91
		public virtual void NotifyIdentityHint(byte[] psk_identity_hint)
		{
		}

		// Token: 0x06000607 RID: 1543 RVA: 0x00019893 File Offset: 0x00017A93
		public virtual byte[] GetPskIdentity()
		{
			return this.m_identity;
		}

		// Token: 0x06000608 RID: 1544 RVA: 0x0001989B File Offset: 0x00017A9B
		public byte[] GetPsk()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.m_psk);
		}

		// Token: 0x0400032D RID: 813
		protected readonly byte[] m_identity;

		// Token: 0x0400032E RID: 814
		protected readonly byte[] m_psk;
	}
}
