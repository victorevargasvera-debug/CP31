using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000091 RID: 145
	public sealed class ByteQueue
	{
		// Token: 0x0600060D RID: 1549 RVA: 0x000198F8 File Offset: 0x00017AF8
		public static int NextTwoPow(int i)
		{
			i |= i >> 1;
			i |= i >> 2;
			i |= i >> 4;
			i |= i >> 8;
			i |= i >> 16;
			return i + 1;
		}

		// Token: 0x0600060E RID: 1550 RVA: 0x00019921 File Offset: 0x00017B21
		public ByteQueue() : this(0)
		{
		}

		// Token: 0x0600060F RID: 1551 RVA: 0x0001992A File Offset: 0x00017B2A
		public ByteQueue(int capacity)
		{
			this.m_databuf = ((capacity == 0) ? global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes : new byte[capacity]);
		}

		// Token: 0x06000610 RID: 1552 RVA: 0x00019948 File Offset: 0x00017B48
		public ByteQueue(byte[] buf, int off, int len)
		{
			this.m_databuf = buf;
			this.m_skipped = off;
			this.m_available = len;
			this.m_readOnlyBuf = true;
		}

		// Token: 0x06000611 RID: 1553 RVA: 0x0001996C File Offset: 0x00017B6C
		public void AddData(byte[] buf, int off, int len)
		{
			if (this.m_readOnlyBuf)
			{
				throw new global::System.InvalidOperationException("Cannot add data to read-only buffer");
			}
			if (this.m_skipped + this.m_available + len > this.m_databuf.Length)
			{
				int desiredSize = global::Org.BouncyCastle.Tls.ByteQueue.NextTwoPow(this.m_available + len);
				if (desiredSize > this.m_databuf.Length)
				{
					byte[] tmp = new byte[desiredSize];
					global::System.Array.Copy(this.m_databuf, this.m_skipped, tmp, 0, this.m_available);
					this.m_databuf = tmp;
				}
				else
				{
					global::System.Array.Copy(this.m_databuf, this.m_skipped, this.m_databuf, 0, this.m_available);
				}
				this.m_skipped = 0;
			}
			global::System.Array.Copy(buf, off, this.m_databuf, this.m_skipped + this.m_available, len);
			this.m_available += len;
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000612 RID: 1554 RVA: 0x00019A35 File Offset: 0x00017C35
		public int Available
		{
			get
			{
				return this.m_available;
			}
		}

		// Token: 0x06000613 RID: 1555 RVA: 0x00019A40 File Offset: 0x00017C40
		public void CopyTo(global::System.IO.Stream output, int length)
		{
			if (length > this.m_available)
			{
				throw new global::System.InvalidOperationException("Cannot copy " + length.ToString() + " bytes, only got " + this.m_available.ToString());
			}
			output.Write(this.m_databuf, this.m_skipped, length);
		}

		// Token: 0x06000614 RID: 1556 RVA: 0x00019A90 File Offset: 0x00017C90
		public void Read(byte[] buf, int offset, int len, int skip)
		{
			if (buf.Length - offset < len)
			{
				throw new global::System.ArgumentException(string.Concat(new string[]
				{
					"Buffer size of ",
					buf.Length.ToString(),
					" is too small for a read of ",
					len.ToString(),
					" bytes"
				}));
			}
			if (this.m_available - skip < len)
			{
				throw new global::System.InvalidOperationException("Not enough data to read");
			}
			global::System.Array.Copy(this.m_databuf, this.m_skipped + skip, buf, offset, len);
		}

		// Token: 0x06000615 RID: 1557 RVA: 0x00019B14 File Offset: 0x00017D14
		internal global::Org.BouncyCastle.Tls.HandshakeMessageInput ReadHandshakeMessage(int length)
		{
			if (length > this.m_available)
			{
				throw new global::System.InvalidOperationException("Cannot read " + length.ToString() + " bytes, only got " + this.m_available.ToString());
			}
			int position = this.m_skipped;
			this.m_available -= length;
			this.m_skipped += length;
			return new global::Org.BouncyCastle.Tls.HandshakeMessageInput(this.m_databuf, position, length);
		}

		// Token: 0x06000616 RID: 1558 RVA: 0x00019B81 File Offset: 0x00017D81
		public int ReadInt32()
		{
			if (this.m_available < 4)
			{
				throw new global::System.InvalidOperationException("Not enough data to read");
			}
			return global::Org.BouncyCastle.Tls.TlsUtilities.ReadInt32(this.m_databuf, this.m_skipped);
		}

		// Token: 0x06000617 RID: 1559 RVA: 0x00019BA8 File Offset: 0x00017DA8
		public void RemoveData(int i)
		{
			if (i > this.m_available)
			{
				throw new global::System.InvalidOperationException("Cannot remove " + i.ToString() + " bytes, only got " + this.m_available.ToString());
			}
			this.m_available -= i;
			this.m_skipped += i;
		}

		// Token: 0x06000618 RID: 1560 RVA: 0x00019C01 File Offset: 0x00017E01
		public void RemoveData(byte[] buf, int off, int len, int skip)
		{
			this.Read(buf, off, len, skip);
			this.RemoveData(skip + len);
		}

		// Token: 0x06000619 RID: 1561 RVA: 0x00019C18 File Offset: 0x00017E18
		public byte[] RemoveData(int len, int skip)
		{
			byte[] buf = new byte[len];
			this.RemoveData(buf, 0, len, skip);
			return buf;
		}

		// Token: 0x0600061A RID: 1562 RVA: 0x00019C38 File Offset: 0x00017E38
		public void Shrink()
		{
			if (this.m_available == 0)
			{
				this.m_databuf = global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes;
				this.m_skipped = 0;
				return;
			}
			int desiredSize = global::Org.BouncyCastle.Tls.ByteQueue.NextTwoPow(this.m_available);
			if (desiredSize < this.m_databuf.Length)
			{
				byte[] tmp = new byte[desiredSize];
				global::System.Array.Copy(this.m_databuf, this.m_skipped, tmp, 0, this.m_available);
				this.m_databuf = tmp;
				this.m_skipped = 0;
			}
		}

		// Token: 0x04000331 RID: 817
		private byte[] m_databuf;

		// Token: 0x04000332 RID: 818
		private int m_skipped;

		// Token: 0x04000333 RID: 819
		private int m_available;

		// Token: 0x04000334 RID: 820
		private bool m_readOnlyBuf;
	}
}
