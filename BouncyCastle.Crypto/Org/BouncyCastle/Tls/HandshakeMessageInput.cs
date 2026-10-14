using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000C8 RID: 200
	public sealed class HandshakeMessageInput : global::System.IO.MemoryStream
	{
		// Token: 0x0600076C RID: 1900 RVA: 0x0001FF12 File Offset: 0x0001E112
		internal HandshakeMessageInput(byte[] buf, int offset, int length) : base(buf, offset, length, false, true)
		{
			this.m_offset = offset;
		}

		// Token: 0x0600076D RID: 1901 RVA: 0x0001FF26 File Offset: 0x0001E126
		public void UpdateHash(global::Org.BouncyCastle.Tls.Crypto.TlsHash hash)
		{
			global::Org.BouncyCastle.Utilities.IO.Streams.WriteBufTo(this, new global::Org.BouncyCastle.Tls.Crypto.TlsHashSink(hash));
		}

		// Token: 0x0600076E RID: 1902 RVA: 0x0001FF34 File Offset: 0x0001E134
		internal void UpdateHashPrefix(global::Org.BouncyCastle.Tls.Crypto.TlsHash hash, int bindersSize)
		{
			byte[] buf = this.GetBuffer();
			int count = (int)this.Length;
			hash.Update(buf, this.m_offset, count - bindersSize);
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0001FF60 File Offset: 0x0001E160
		internal void UpdateHashSuffix(global::Org.BouncyCastle.Tls.Crypto.TlsHash hash, int bindersSize)
		{
			byte[] buf = this.GetBuffer();
			int count = (int)this.Length;
			hash.Update(buf, this.m_offset + count - bindersSize, bindersSize);
		}

		// Token: 0x0400056D RID: 1389
		private readonly int m_offset;
	}
}
