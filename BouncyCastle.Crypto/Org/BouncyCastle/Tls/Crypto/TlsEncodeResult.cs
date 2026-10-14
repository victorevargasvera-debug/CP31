using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000147 RID: 327
	public sealed class TlsEncodeResult
	{
		// Token: 0x06000D30 RID: 3376 RVA: 0x00032474 File Offset: 0x00030674
		public TlsEncodeResult(byte[] buf, int off, int len, short recordType)
		{
			this.buf = buf;
			this.off = off;
			this.len = len;
			this.recordType = recordType;
		}

		// Token: 0x040007CE RID: 1998
		public readonly byte[] buf;

		// Token: 0x040007CF RID: 1999
		public readonly int off;

		// Token: 0x040007D0 RID: 2000
		public readonly int len;

		// Token: 0x040007D1 RID: 2001
		public readonly short recordType;
	}
}
