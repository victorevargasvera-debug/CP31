using System;
using System.IO;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.IO
{
	// Token: 0x0200045A RID: 1114
	public class CipherStream : global::System.IO.Stream
	{
		// Token: 0x06002B32 RID: 11058 RVA: 0x000B9CC3 File Offset: 0x000B7EC3
		public CipherStream(global::System.IO.Stream stream, global::Org.BouncyCastle.Crypto.IBufferedCipher readCipher, global::Org.BouncyCastle.Crypto.IBufferedCipher writeCipher)
		{
			this.stream = stream;
			if (readCipher != null)
			{
				this.inCipher = readCipher;
				this.mInBuf = null;
			}
			if (writeCipher != null)
			{
				this.outCipher = writeCipher;
			}
		}

		// Token: 0x170005EF RID: 1519
		// (get) Token: 0x06002B33 RID: 11059 RVA: 0x000B9CED File Offset: 0x000B7EED
		public global::Org.BouncyCastle.Crypto.IBufferedCipher ReadCipher
		{
			get
			{
				return this.inCipher;
			}
		}

		// Token: 0x170005F0 RID: 1520
		// (get) Token: 0x06002B34 RID: 11060 RVA: 0x000B9CF5 File Offset: 0x000B7EF5
		public global::Org.BouncyCastle.Crypto.IBufferedCipher WriteCipher
		{
			get
			{
				return this.outCipher;
			}
		}

		// Token: 0x06002B35 RID: 11061 RVA: 0x000B9D00 File Offset: 0x000B7F00
		public override int ReadByte()
		{
			if (this.inCipher == null)
			{
				return this.stream.ReadByte();
			}
			if ((this.mInBuf == null || this.mInPos >= this.mInBuf.Length) && !this.FillInBuf())
			{
				return -1;
			}
			byte[] array = this.mInBuf;
			int num = this.mInPos;
			this.mInPos = num + 1;
			return array[num];
		}

		// Token: 0x06002B36 RID: 11062 RVA: 0x000B9D5C File Offset: 0x000B7F5C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.inCipher == null)
			{
				return this.stream.Read(buffer, offset, count);
			}
			int num = 0;
			while (num < count && ((this.mInBuf != null && this.mInPos < this.mInBuf.Length) || this.FillInBuf()))
			{
				int numToCopy = global::System.Math.Min(count - num, this.mInBuf.Length - this.mInPos);
				global::System.Array.Copy(this.mInBuf, this.mInPos, buffer, offset + num, numToCopy);
				this.mInPos += numToCopy;
				num += numToCopy;
			}
			return num;
		}

		// Token: 0x06002B37 RID: 11063 RVA: 0x000B9DE9 File Offset: 0x000B7FE9
		private bool FillInBuf()
		{
			if (this.inStreamEnded)
			{
				return false;
			}
			this.mInPos = 0;
			do
			{
				this.mInBuf = this.ReadAndProcessBlock();
			}
			while (!this.inStreamEnded && this.mInBuf == null);
			return this.mInBuf != null;
		}

		// Token: 0x06002B38 RID: 11064 RVA: 0x000B9E24 File Offset: 0x000B8024
		private byte[] ReadAndProcessBlock()
		{
			int blockSize = this.inCipher.GetBlockSize();
			byte[] block = new byte[(blockSize == 0) ? 256 : blockSize];
			int numRead = 0;
			for (;;)
			{
				int count = this.stream.Read(block, numRead, block.Length - numRead);
				if (count < 1)
				{
					break;
				}
				numRead += count;
				if (numRead >= block.Length)
				{
					goto IL_4C;
				}
			}
			this.inStreamEnded = true;
			IL_4C:
			byte[] bytes = this.inStreamEnded ? this.inCipher.DoFinal(block, 0, numRead) : this.inCipher.ProcessBytes(block);
			if (bytes != null && bytes.Length == 0)
			{
				bytes = null;
			}
			return bytes;
		}

		// Token: 0x06002B39 RID: 11065 RVA: 0x000B9EAC File Offset: 0x000B80AC
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.outCipher == null)
			{
				this.stream.Write(buffer, offset, count);
				return;
			}
			byte[] data = this.outCipher.ProcessBytes(buffer, offset, count);
			if (data != null)
			{
				this.stream.Write(data, 0, data.Length);
			}
		}

		// Token: 0x06002B3A RID: 11066 RVA: 0x000B9EF4 File Offset: 0x000B80F4
		public override void WriteByte(byte b)
		{
			if (this.outCipher == null)
			{
				this.stream.WriteByte(b);
				return;
			}
			byte[] data = this.outCipher.ProcessByte(b);
			if (data != null)
			{
				this.stream.Write(data, 0, data.Length);
			}
		}

		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002B3B RID: 11067 RVA: 0x000B9F36 File Offset: 0x000B8136
		public override bool CanRead
		{
			get
			{
				return this.stream.CanRead && this.inCipher != null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002B3C RID: 11068 RVA: 0x000B9F50 File Offset: 0x000B8150
		public override bool CanWrite
		{
			get
			{
				return this.stream.CanWrite && this.outCipher != null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002B3D RID: 11069 RVA: 0x000B9F6A File Offset: 0x000B816A
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170005F4 RID: 1524
		// (get) Token: 0x06002B3E RID: 11070 RVA: 0x000B9F6D File Offset: 0x000B816D
		public sealed override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x170005F5 RID: 1525
		// (get) Token: 0x06002B3F RID: 11071 RVA: 0x000B9F74 File Offset: 0x000B8174
		// (set) Token: 0x06002B40 RID: 11072 RVA: 0x000B9F7B File Offset: 0x000B817B
		public sealed override long Position
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

		// Token: 0x06002B41 RID: 11073 RVA: 0x000B9F84 File Offset: 0x000B8184
		public override void Close()
		{
			if (this.outCipher != null)
			{
				byte[] data = this.outCipher.DoFinal();
				this.stream.Write(data, 0, data.Length);
				this.stream.Flush();
			}
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.stream);
			base.Close();
		}

		// Token: 0x06002B42 RID: 11074 RVA: 0x000B9FD1 File Offset: 0x000B81D1
		public override void Flush()
		{
			this.stream.Flush();
		}

		// Token: 0x06002B43 RID: 11075 RVA: 0x000B9FDE File Offset: 0x000B81DE
		public sealed override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002B44 RID: 11076 RVA: 0x000B9FE5 File Offset: 0x000B81E5
		public sealed override void SetLength(long length)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040011ED RID: 4589
		internal global::System.IO.Stream stream;

		// Token: 0x040011EE RID: 4590
		internal global::Org.BouncyCastle.Crypto.IBufferedCipher inCipher;

		// Token: 0x040011EF RID: 4591
		internal global::Org.BouncyCastle.Crypto.IBufferedCipher outCipher;

		// Token: 0x040011F0 RID: 4592
		private byte[] mInBuf;

		// Token: 0x040011F1 RID: 4593
		private int mInPos;

		// Token: 0x040011F2 RID: 4594
		private bool inStreamEnded;
	}
}
