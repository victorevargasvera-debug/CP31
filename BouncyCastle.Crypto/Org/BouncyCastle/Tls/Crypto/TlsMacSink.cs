using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200014D RID: 333
	public class TlsMacSink : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06000D41 RID: 3393 RVA: 0x000324DD File Offset: 0x000306DD
		public TlsMacSink(global::Org.BouncyCastle.Tls.Crypto.TlsMac mac)
		{
			this.m_mac = mac;
		}

		// Token: 0x170001F7 RID: 503
		// (get) Token: 0x06000D42 RID: 3394 RVA: 0x000324EC File Offset: 0x000306EC
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsMac Mac
		{
			get
			{
				return this.m_mac;
			}
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000324F4 File Offset: 0x000306F4
		public override void WriteByte(byte b)
		{
			this.m_mac.Update(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x06000D44 RID: 3396 RVA: 0x0003250D File Offset: 0x0003070D
		public override void Write(byte[] buf, int off, int len)
		{
			if (len > 0)
			{
				this.m_mac.Update(buf, off, len);
			}
		}

		// Token: 0x040007D3 RID: 2003
		private readonly global::Org.BouncyCastle.Tls.Crypto.TlsMac m_mac;
	}
}
