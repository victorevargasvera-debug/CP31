using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000142 RID: 322
	public sealed class TlsDecodeResult
	{
		// Token: 0x06000D26 RID: 3366 RVA: 0x000323E6 File Offset: 0x000305E6
		public TlsDecodeResult(byte[] buf, int off, int len, short contentType)
		{
			this.buf = buf;
			this.off = off;
			this.len = len;
			this.contentType = contentType;
		}

		// Token: 0x040007C6 RID: 1990
		public readonly byte[] buf;

		// Token: 0x040007C7 RID: 1991
		public readonly int off;

		// Token: 0x040007C8 RID: 1992
		public readonly int len;

		// Token: 0x040007C9 RID: 1993
		public readonly short contentType;
	}
}
