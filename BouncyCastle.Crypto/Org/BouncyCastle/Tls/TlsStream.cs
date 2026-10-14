using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012D RID: 301
	internal class TlsStream : global::System.IO.Stream
	{
		// Token: 0x06000B84 RID: 2948 RVA: 0x0002B95F File Offset: 0x00029B5F
		internal TlsStream(global::Org.BouncyCastle.Tls.TlsProtocol handler)
		{
			this.m_handler = handler;
		}

		// Token: 0x170001D4 RID: 468
		// (get) Token: 0x06000B85 RID: 2949 RVA: 0x0002B96E File Offset: 0x00029B6E
		public override bool CanRead
		{
			get
			{
				return !this.m_handler.IsClosed;
			}
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000B86 RID: 2950 RVA: 0x0002B97E File Offset: 0x00029B7E
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000B87 RID: 2951 RVA: 0x0002B981 File Offset: 0x00029B81
		public override bool CanWrite
		{
			get
			{
				return !this.m_handler.IsClosed;
			}
		}

		// Token: 0x06000B88 RID: 2952 RVA: 0x0002B991 File Offset: 0x00029B91
		public override void Close()
		{
			this.m_handler.Close();
			base.Close();
		}

		// Token: 0x06000B89 RID: 2953 RVA: 0x0002B9A4 File Offset: 0x00029BA4
		public override void Flush()
		{
			this.m_handler.Flush();
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000B8A RID: 2954 RVA: 0x0002B9B1 File Offset: 0x00029BB1
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170001D8 RID: 472
		// (get) Token: 0x06000B8B RID: 2955 RVA: 0x0002B9B8 File Offset: 0x00029BB8
		// (set) Token: 0x06000B8C RID: 2956 RVA: 0x0002B9BF File Offset: 0x00029BBF
		public override long Position
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000B8D RID: 2957 RVA: 0x0002B9C6 File Offset: 0x00029BC6
		public override int Read(byte[] buf, int off, int len)
		{
			return this.m_handler.ReadApplicationData(buf, off, len);
		}

		// Token: 0x06000B8E RID: 2958 RVA: 0x0002B9D8 File Offset: 0x00029BD8
		public override int ReadByte()
		{
			byte[] buf = new byte[1];
			if (this.Read(buf, 0, 1) > 0)
			{
				return (int)buf[0];
			}
			return -1;
		}

		// Token: 0x06000B8F RID: 2959 RVA: 0x0002B9FD File Offset: 0x00029BFD
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000B90 RID: 2960 RVA: 0x0002BA04 File Offset: 0x00029C04
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000B91 RID: 2961 RVA: 0x0002BA0B File Offset: 0x00029C0B
		public override void Write(byte[] buf, int off, int len)
		{
			this.m_handler.WriteApplicationData(buf, off, len);
		}

		// Token: 0x06000B92 RID: 2962 RVA: 0x0002BA1B File Offset: 0x00029C1B
		public override void WriteByte(byte b)
		{
			this.Write(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x04000753 RID: 1875
		private readonly global::Org.BouncyCastle.Tls.TlsProtocol m_handler;
	}
}
