using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000301 RID: 769
	public class ByteQueue
	{
		// Token: 0x060020D3 RID: 8403 RVA: 0x00092005 File Offset: 0x00090205
		public static int NextTwoPow(int i)
		{
			i |= i >> 1;
			i |= i >> 2;
			i |= i >> 4;
			i |= i >> 8;
			i |= i >> 16;
			return i + 1;
		}

		// Token: 0x060020D4 RID: 8404 RVA: 0x0009202E File Offset: 0x0009022E
		public ByteQueue() : this(1024)
		{
		}

		// Token: 0x060020D5 RID: 8405 RVA: 0x0009203B File Offset: 0x0009023B
		public ByteQueue(int capacity)
		{
			this.databuf = ((capacity == 0) ? global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes : new byte[capacity]);
		}

		// Token: 0x060020D6 RID: 8406 RVA: 0x00092059 File Offset: 0x00090259
		public ByteQueue(byte[] buf, int off, int len)
		{
			this.databuf = buf;
			this.skipped = off;
			this.available = len;
			this.readOnlyBuf = true;
		}

		// Token: 0x060020D7 RID: 8407 RVA: 0x00092080 File Offset: 0x00090280
		public void AddData(byte[] data, int offset, int len)
		{
			if (this.readOnlyBuf)
			{
				throw new global::System.InvalidOperationException("Cannot add data to read-only buffer");
			}
			if (this.skipped + this.available + len > this.databuf.Length)
			{
				int desiredSize = global::Org.BouncyCastle.Crypto.Tls.ByteQueue.NextTwoPow(this.available + len);
				if (desiredSize > this.databuf.Length)
				{
					byte[] tmp = new byte[desiredSize];
					global::System.Array.Copy(this.databuf, this.skipped, tmp, 0, this.available);
					this.databuf = tmp;
				}
				else
				{
					global::System.Array.Copy(this.databuf, this.skipped, this.databuf, 0, this.available);
				}
				this.skipped = 0;
			}
			global::System.Array.Copy(data, offset, this.databuf, this.skipped + this.available, len);
			this.available += len;
		}

		// Token: 0x17000481 RID: 1153
		// (get) Token: 0x060020D8 RID: 8408 RVA: 0x00092149 File Offset: 0x00090349
		public int Available
		{
			get
			{
				return this.available;
			}
		}

		// Token: 0x060020D9 RID: 8409 RVA: 0x00092154 File Offset: 0x00090354
		public void CopyTo(global::System.IO.Stream output, int length)
		{
			if (length > this.available)
			{
				throw new global::System.InvalidOperationException("Cannot copy " + length.ToString() + " bytes, only got " + this.available.ToString());
			}
			output.Write(this.databuf, this.skipped, length);
		}

		// Token: 0x060020DA RID: 8410 RVA: 0x000921A4 File Offset: 0x000903A4
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
			if (this.available - skip < len)
			{
				throw new global::System.InvalidOperationException("Not enough data to read");
			}
			global::System.Array.Copy(this.databuf, this.skipped + skip, buf, offset, len);
		}

		// Token: 0x060020DB RID: 8411 RVA: 0x00092228 File Offset: 0x00090428
		public global::System.IO.MemoryStream ReadFrom(int length)
		{
			if (length > this.available)
			{
				throw new global::System.InvalidOperationException("Cannot read " + length.ToString() + " bytes, only got " + this.available.ToString());
			}
			int position = this.skipped;
			this.available -= length;
			this.skipped += length;
			return new global::System.IO.MemoryStream(this.databuf, position, length, false);
		}

		// Token: 0x060020DC RID: 8412 RVA: 0x00092298 File Offset: 0x00090498
		public void RemoveData(int i)
		{
			if (i > this.available)
			{
				throw new global::System.InvalidOperationException("Cannot remove " + i.ToString() + " bytes, only got " + this.available.ToString());
			}
			this.available -= i;
			this.skipped += i;
		}

		// Token: 0x060020DD RID: 8413 RVA: 0x000922F1 File Offset: 0x000904F1
		public void RemoveData(byte[] buf, int off, int len, int skip)
		{
			this.Read(buf, off, len, skip);
			this.RemoveData(skip + len);
		}

		// Token: 0x060020DE RID: 8414 RVA: 0x00092308 File Offset: 0x00090508
		public byte[] RemoveData(int len, int skip)
		{
			byte[] buf = new byte[len];
			this.RemoveData(buf, 0, len, skip);
			return buf;
		}

		// Token: 0x060020DF RID: 8415 RVA: 0x00092328 File Offset: 0x00090528
		public void Shrink()
		{
			if (this.available == 0)
			{
				this.databuf = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.EmptyBytes;
				this.skipped = 0;
				return;
			}
			int desiredSize = global::Org.BouncyCastle.Crypto.Tls.ByteQueue.NextTwoPow(this.available);
			if (desiredSize < this.databuf.Length)
			{
				byte[] tmp = new byte[desiredSize];
				global::System.Array.Copy(this.databuf, this.skipped, tmp, 0, this.available);
				this.databuf = tmp;
				this.skipped = 0;
			}
		}

		// Token: 0x04000B8F RID: 2959
		private const int DefaultCapacity = 1024;

		// Token: 0x04000B90 RID: 2960
		private byte[] databuf;

		// Token: 0x04000B91 RID: 2961
		private int skipped;

		// Token: 0x04000B92 RID: 2962
		private int available;

		// Token: 0x04000B93 RID: 2963
		private bool readOnlyBuf;
	}
}
