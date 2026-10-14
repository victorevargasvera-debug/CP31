using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000BF RID: 191
	public sealed class DtlsRequest
	{
		// Token: 0x06000742 RID: 1858 RVA: 0x0001EA4A File Offset: 0x0001CC4A
		internal DtlsRequest(long recordSeq, byte[] message, global::Org.BouncyCastle.Tls.ClientHello clientHello)
		{
			this.m_recordSeq = recordSeq;
			this.m_message = message;
			this.m_clientHello = clientHello;
		}

		// Token: 0x17000130 RID: 304
		// (get) Token: 0x06000743 RID: 1859 RVA: 0x0001EA67 File Offset: 0x0001CC67
		internal global::Org.BouncyCastle.Tls.ClientHello ClientHello
		{
			get
			{
				return this.m_clientHello;
			}
		}

		// Token: 0x17000131 RID: 305
		// (get) Token: 0x06000744 RID: 1860 RVA: 0x0001EA6F File Offset: 0x0001CC6F
		internal byte[] Message
		{
			get
			{
				return this.m_message;
			}
		}

		// Token: 0x17000132 RID: 306
		// (get) Token: 0x06000745 RID: 1861 RVA: 0x0001EA77 File Offset: 0x0001CC77
		internal int MessageSeq
		{
			get
			{
				return global::Org.BouncyCastle.Tls.TlsUtilities.ReadUint16(this.m_message, 4);
			}
		}

		// Token: 0x17000133 RID: 307
		// (get) Token: 0x06000746 RID: 1862 RVA: 0x0001EA85 File Offset: 0x0001CC85
		internal long RecordSeq
		{
			get
			{
				return this.m_recordSeq;
			}
		}

		// Token: 0x04000512 RID: 1298
		private readonly long m_recordSeq;

		// Token: 0x04000513 RID: 1299
		private readonly byte[] m_message;

		// Token: 0x04000514 RID: 1300
		private readonly global::Org.BouncyCastle.Tls.ClientHello m_clientHello;
	}
}
