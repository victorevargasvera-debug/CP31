using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FF RID: 767
	public class BasicTlsPskIdentity : global::Org.BouncyCastle.Crypto.Tls.TlsPskIdentity
	{
		// Token: 0x060020CC RID: 8396 RVA: 0x00091FA4 File Offset: 0x000901A4
		public BasicTlsPskIdentity(byte[] identity, byte[] psk)
		{
			this.mIdentity = global::Org.BouncyCastle.Utilities.Arrays.Clone(identity);
			this.mPsk = global::Org.BouncyCastle.Utilities.Arrays.Clone(psk);
		}

		// Token: 0x060020CD RID: 8397 RVA: 0x00091FC4 File Offset: 0x000901C4
		public BasicTlsPskIdentity(string identity, byte[] psk)
		{
			this.mIdentity = global::Org.BouncyCastle.Utilities.Strings.ToUtf8ByteArray(identity);
			this.mPsk = global::Org.BouncyCastle.Utilities.Arrays.Clone(psk);
		}

		// Token: 0x060020CE RID: 8398 RVA: 0x00091FE4 File Offset: 0x000901E4
		public virtual void SkipIdentityHint()
		{
		}

		// Token: 0x060020CF RID: 8399 RVA: 0x00091FE6 File Offset: 0x000901E6
		public virtual void NotifyIdentityHint(byte[] psk_identity_hint)
		{
		}

		// Token: 0x060020D0 RID: 8400 RVA: 0x00091FE8 File Offset: 0x000901E8
		public virtual byte[] GetPskIdentity()
		{
			return this.mIdentity;
		}

		// Token: 0x060020D1 RID: 8401 RVA: 0x00091FF0 File Offset: 0x000901F0
		public virtual byte[] GetPsk()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.mPsk);
		}

		// Token: 0x04000B85 RID: 2949
		protected byte[] mIdentity;

		// Token: 0x04000B86 RID: 2950
		protected byte[] mPsk;
	}
}
