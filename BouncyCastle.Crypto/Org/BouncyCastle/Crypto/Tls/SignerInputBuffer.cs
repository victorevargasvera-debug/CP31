using System;
using System.IO;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200034C RID: 844
	internal class SignerInputBuffer : global::System.IO.MemoryStream
	{
		// Token: 0x060022B9 RID: 8889 RVA: 0x00098A18 File Offset: 0x00096C18
		internal void UpdateSigner(global::Org.BouncyCastle.Crypto.ISigner s)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, new global::Org.BouncyCastle.Crypto.Tls.SignerInputBuffer.SigStream(s));
		}

		// Token: 0x020007FF RID: 2047
		private class SigStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
		{
			// Token: 0x0600464A RID: 17994 RVA: 0x001364D2 File Offset: 0x001346D2
			internal SigStream(global::Org.BouncyCastle.Crypto.ISigner s)
			{
				this.s = s;
			}

			// Token: 0x0600464B RID: 17995 RVA: 0x001364E1 File Offset: 0x001346E1
			public override void WriteByte(byte b)
			{
				this.s.Update(b);
			}

			// Token: 0x0600464C RID: 17996 RVA: 0x001364EF File Offset: 0x001346EF
			public override void Write(byte[] buf, int off, int len)
			{
				this.s.BlockUpdate(buf, off, len);
			}

			// Token: 0x040024B2 RID: 9394
			private readonly global::Org.BouncyCastle.Crypto.ISigner s;
		}
	}
}
