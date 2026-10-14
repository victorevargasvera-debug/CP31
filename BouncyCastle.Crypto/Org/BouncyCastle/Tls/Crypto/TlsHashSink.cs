using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200014A RID: 330
	public class TlsHashSink : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06000D36 RID: 3382 RVA: 0x00032499 File Offset: 0x00030699
		public TlsHashSink(global::Org.BouncyCastle.Tls.Crypto.TlsHash hash)
		{
			this.m_hash = hash;
		}

		// Token: 0x170001F4 RID: 500
		// (get) Token: 0x06000D37 RID: 3383 RVA: 0x000324A8 File Offset: 0x000306A8
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsHash Hash
		{
			get
			{
				return this.m_hash;
			}
		}

		// Token: 0x06000D38 RID: 3384 RVA: 0x000324B0 File Offset: 0x000306B0
		public override void WriteByte(byte b)
		{
			this.m_hash.Update(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x06000D39 RID: 3385 RVA: 0x000324C9 File Offset: 0x000306C9
		public override void Write(byte[] buf, int off, int len)
		{
			if (len > 0)
			{
				this.m_hash.Update(buf, off, len);
			}
		}

		// Token: 0x040007D2 RID: 2002
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsHash m_hash;
	}
}
