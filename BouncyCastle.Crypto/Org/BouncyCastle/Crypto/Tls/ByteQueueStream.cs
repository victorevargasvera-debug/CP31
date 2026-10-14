using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000302 RID: 770
	public class ByteQueueStream : global::System.IO.Stream
	{
		// Token: 0x060020E0 RID: 8416 RVA: 0x00092395 File Offset: 0x00090595
		public ByteQueueStream()
		{
			this.buffer = new global::Org.BouncyCastle.Crypto.Tls.ByteQueue();
		}

		// Token: 0x17000482 RID: 1154
		// (get) Token: 0x060020E1 RID: 8417 RVA: 0x000923A8 File Offset: 0x000905A8
		public virtual int Available
		{
			get
			{
				return this.buffer.Available;
			}
		}

		// Token: 0x17000483 RID: 1155
		// (get) Token: 0x060020E2 RID: 8418 RVA: 0x000923B5 File Offset: 0x000905B5
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x060020E3 RID: 8419 RVA: 0x000923B8 File Offset: 0x000905B8
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x060020E4 RID: 8420 RVA: 0x000923BB File Offset: 0x000905BB
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x060020E5 RID: 8421 RVA: 0x000923BE File Offset: 0x000905BE
		public override void Flush()
		{
		}

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x060020E6 RID: 8422 RVA: 0x000923C0 File Offset: 0x000905C0
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x060020E7 RID: 8423 RVA: 0x000923C8 File Offset: 0x000905C8
		public virtual int Peek(byte[] buf)
		{
			int bytesToRead = global::System.Math.Min(this.buffer.Available, buf.Length);
			this.buffer.Read(buf, 0, bytesToRead, 0);
			return bytesToRead;
		}

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x060020E8 RID: 8424 RVA: 0x000923F9 File Offset: 0x000905F9
		// (set) Token: 0x060020E9 RID: 8425 RVA: 0x00092400 File Offset: 0x00090600
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

		// Token: 0x060020EA RID: 8426 RVA: 0x00092407 File Offset: 0x00090607
		public virtual int Read(byte[] buf)
		{
			return this.Read(buf, 0, buf.Length);
		}

		// Token: 0x060020EB RID: 8427 RVA: 0x00092414 File Offset: 0x00090614
		public override int Read(byte[] buf, int off, int len)
		{
			int bytesToRead = global::System.Math.Min(this.buffer.Available, len);
			this.buffer.RemoveData(buf, off, bytesToRead, 0);
			return bytesToRead;
		}

		// Token: 0x060020EC RID: 8428 RVA: 0x00092443 File Offset: 0x00090643
		public override int ReadByte()
		{
			if (this.buffer.Available == 0)
			{
				return -1;
			}
			return (int)(this.buffer.RemoveData(1, 0)[0] & byte.MaxValue);
		}

		// Token: 0x060020ED RID: 8429 RVA: 0x00092469 File Offset: 0x00090669
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060020EE RID: 8430 RVA: 0x00092470 File Offset: 0x00090670
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x060020EF RID: 8431 RVA: 0x00092478 File Offset: 0x00090678
		public virtual int Skip(int n)
		{
			int bytesToSkip = global::System.Math.Min(this.buffer.Available, n);
			this.buffer.RemoveData(bytesToSkip);
			return bytesToSkip;
		}

		// Token: 0x060020F0 RID: 8432 RVA: 0x000924A4 File Offset: 0x000906A4
		public virtual void Write(byte[] buf)
		{
			this.buffer.AddData(buf, 0, buf.Length);
		}

		// Token: 0x060020F1 RID: 8433 RVA: 0x000924B6 File Offset: 0x000906B6
		public override void Write(byte[] buf, int off, int len)
		{
			this.buffer.AddData(buf, off, len);
		}

		// Token: 0x060020F2 RID: 8434 RVA: 0x000924C6 File Offset: 0x000906C6
		public override void WriteByte(byte b)
		{
			this.buffer.AddData(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x04000B94 RID: 2964
		private readonly global::Org.BouncyCastle.Crypto.Tls.ByteQueue buffer;
	}
}
