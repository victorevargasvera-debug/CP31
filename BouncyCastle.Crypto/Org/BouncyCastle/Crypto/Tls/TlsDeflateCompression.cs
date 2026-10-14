using System;
using System.IO;
using Org.BouncyCastle.Utilities.Zlib;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000363 RID: 867
	public class TlsDeflateCompression : global::Org.BouncyCastle.Crypto.Tls.TlsCompression
	{
		// Token: 0x06002331 RID: 9009 RVA: 0x0009A968 File Offset: 0x00098B68
		public TlsDeflateCompression() : this(-1)
		{
		}

		// Token: 0x06002332 RID: 9010 RVA: 0x0009A971 File Offset: 0x00098B71
		public TlsDeflateCompression(int level)
		{
			this.zIn = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			this.zIn.inflateInit();
			this.zOut = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			this.zOut.deflateInit(level);
		}

		// Token: 0x06002333 RID: 9011 RVA: 0x0009A9A8 File Offset: 0x00098BA8
		public virtual global::System.IO.Stream Compress(global::System.IO.Stream output)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDeflateCompression.DeflateOutputStream(output, this.zOut, true);
		}

		// Token: 0x06002334 RID: 9012 RVA: 0x0009A9B7 File Offset: 0x00098BB7
		public virtual global::System.IO.Stream Decompress(global::System.IO.Stream output)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsDeflateCompression.DeflateOutputStream(output, this.zIn, false);
		}

		// Token: 0x04000E49 RID: 3657
		public const int LEVEL_NONE = 0;

		// Token: 0x04000E4A RID: 3658
		public const int LEVEL_FASTEST = 1;

		// Token: 0x04000E4B RID: 3659
		public const int LEVEL_SMALLEST = 9;

		// Token: 0x04000E4C RID: 3660
		public const int LEVEL_DEFAULT = -1;

		// Token: 0x04000E4D RID: 3661
		protected readonly global::Org.BouncyCastle.Utilities.Zlib.ZStream zIn;

		// Token: 0x04000E4E RID: 3662
		protected readonly global::Org.BouncyCastle.Utilities.Zlib.ZStream zOut;

		// Token: 0x02000800 RID: 2048
		protected class DeflateOutputStream : global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream
		{
			// Token: 0x0600464D RID: 17997 RVA: 0x001364FF File Offset: 0x001346FF
			public DeflateOutputStream(global::System.IO.Stream output, global::Org.BouncyCastle.Utilities.Zlib.ZStream z, bool compress) : base(output, z)
			{
				this.compress = compress;
				this.FlushMode = 2;
			}

			// Token: 0x0600464E RID: 17998 RVA: 0x00136517 File Offset: 0x00134717
			public override void Flush()
			{
			}
		}
	}
}
