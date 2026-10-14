using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000093 RID: 147
	public sealed class ByteQueueOutputStream : global::Org.BouncyCastle.Utilities.IO.BaseOutputStream
	{
		// Token: 0x06000624 RID: 1572 RVA: 0x00019D9D File Offset: 0x00017F9D
		public ByteQueueOutputStream()
		{
			this.m_buffer = new global::Org.BouncyCastle.Tls.ByteQueue();
		}

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000625 RID: 1573 RVA: 0x00019DB0 File Offset: 0x00017FB0
		public global::Org.BouncyCastle.Tls.ByteQueue Buffer
		{
			get
			{
				return this.m_buffer;
			}
		}

		// Token: 0x06000626 RID: 1574 RVA: 0x00019DB8 File Offset: 0x00017FB8
		public override void WriteByte(byte b)
		{
			this.m_buffer.AddData(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x06000627 RID: 1575 RVA: 0x00019DD1 File Offset: 0x00017FD1
		public override void Write(byte[] buf, int off, int len)
		{
			this.m_buffer.AddData(buf, off, len);
		}

		// Token: 0x04000336 RID: 822
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_buffer;
	}
}
