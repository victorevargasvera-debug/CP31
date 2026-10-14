using System;
using Org.BouncyCastle.Utilities.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000092 RID: 146
	public sealed class ByteQueueInputStream : global::Org.BouncyCastle.Utilities.IO.BaseInputStream
	{
		// Token: 0x0600061B RID: 1563 RVA: 0x00019CA5 File Offset: 0x00017EA5
		public ByteQueueInputStream()
		{
			this.m_buffer = new global::Org.BouncyCastle.Tls.ByteQueue();
		}

		// Token: 0x0600061C RID: 1564 RVA: 0x00019CB8 File Offset: 0x00017EB8
		public void AddBytes(byte[] buf)
		{
			this.m_buffer.AddData(buf, 0, buf.Length);
		}

		// Token: 0x0600061D RID: 1565 RVA: 0x00019CCA File Offset: 0x00017ECA
		public void AddBytes(byte[] buf, int bufOff, int bufLen)
		{
			this.m_buffer.AddData(buf, bufOff, bufLen);
		}

		// Token: 0x0600061E RID: 1566 RVA: 0x00019CDC File Offset: 0x00017EDC
		public int Peek(byte[] buf)
		{
			int bytesToRead = global::System.Math.Min(this.m_buffer.Available, buf.Length);
			this.m_buffer.Read(buf, 0, bytesToRead, 0);
			return bytesToRead;
		}

		// Token: 0x0600061F RID: 1567 RVA: 0x00019D0D File Offset: 0x00017F0D
		public override int ReadByte()
		{
			if (this.m_buffer.Available == 0)
			{
				return -1;
			}
			return (int)this.m_buffer.RemoveData(1, 0)[0];
		}

		// Token: 0x06000620 RID: 1568 RVA: 0x00019D30 File Offset: 0x00017F30
		public override int Read(byte[] buf, int off, int len)
		{
			int bytesToRead = global::System.Math.Min(this.m_buffer.Available, len);
			this.m_buffer.RemoveData(buf, off, bytesToRead, 0);
			return bytesToRead;
		}

		// Token: 0x06000621 RID: 1569 RVA: 0x00019D60 File Offset: 0x00017F60
		public long Skip(long n)
		{
			int bytesToRemove = global::System.Math.Min((int)n, this.m_buffer.Available);
			this.m_buffer.RemoveData(bytesToRemove);
			return (long)bytesToRemove;
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000622 RID: 1570 RVA: 0x00019D8E File Offset: 0x00017F8E
		public int Available
		{
			get
			{
				return this.m_buffer.Available;
			}
		}

		// Token: 0x06000623 RID: 1571 RVA: 0x00019D9B File Offset: 0x00017F9B
		public override void Close()
		{
		}

		// Token: 0x04000335 RID: 821
		private readonly global::Org.BouncyCastle.Tls.ByteQueue m_buffer;
	}
}
