using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x02000445 RID: 1093
	internal class BZip2OutputStream : global::System.IO.Stream
	{
		// Token: 0x06002F6A RID: 12138 RVA: 0x000A8B40 File Offset: 0x000A6D40
		public BZip2OutputStream(global::System.IO.Stream output) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, false)
		{
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x000A8B50 File Offset: 0x000A6D50
		public BZip2OutputStream(global::System.IO.Stream output, int blockSize) : this(output, blockSize, false)
		{
		}

		// Token: 0x06002F6C RID: 12140 RVA: 0x000A8B5C File Offset: 0x000A6D5C
		public BZip2OutputStream(global::System.IO.Stream output, bool leaveOpen) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, leaveOpen)
		{
		}

		// Token: 0x06002F6D RID: 12141 RVA: 0x000A8B6C File Offset: 0x000A6D6C
		public BZip2OutputStream(global::System.IO.Stream output, int blockSize, bool leaveOpen)
		{
			if (blockSize < global::Ionic.BZip2.BZip2.MinBlockSize || blockSize > global::Ionic.BZip2.BZip2.MaxBlockSize)
			{
				throw new global::System.ArgumentException(string.Format("blockSize={0} is out of range; must be between {1} and {2}", blockSize, global::Ionic.BZip2.BZip2.MinBlockSize, global::Ionic.BZip2.BZip2.MaxBlockSize), "blockSize");
			}
			this.output = output;
			if (!this.output.CanWrite)
			{
				throw new global::System.ArgumentException("The stream is not writable.", "output");
			}
			this.bw = new global::Ionic.BZip2.BitWriter(this.output);
			this.blockSize100k = blockSize;
			this.compressor = new global::Ionic.BZip2.BZip2Compressor(this.bw, blockSize);
			this.leaveOpen = leaveOpen;
			this.combinedCRC = 0U;
			this.EmitHeader();
		}

		// Token: 0x06002F6E RID: 12142 RVA: 0x000A8C34 File Offset: 0x000A6E34
		public override void Close()
		{
			if (this.output != null)
			{
				global::System.IO.Stream stream = this.output;
				this.Finish();
				if (!this.leaveOpen)
				{
					stream.Close();
				}
			}
		}

		// Token: 0x06002F6F RID: 12143 RVA: 0x000A8C70 File Offset: 0x000A6E70
		public override void Flush()
		{
			if (this.output != null)
			{
				this.bw.Flush();
				this.output.Flush();
			}
		}

		// Token: 0x06002F70 RID: 12144 RVA: 0x000A8C94 File Offset: 0x000A6E94
		private void EmitHeader()
		{
			byte[] array = new byte[]
			{
				66,
				90,
				104,
				0
			};
			this.output.Write(array, 0, array.Length);
		}

		// Token: 0x06002F71 RID: 12145 RVA: 0x000A8CD4 File Offset: 0x000A6ED4
		private void EmitTrailer()
		{
			this.bw.WriteByte(23);
			this.bw.WriteByte(114);
			this.bw.WriteByte(69);
			this.bw.WriteByte(56);
			this.bw.WriteByte(80);
			this.bw.WriteByte(144);
			this.bw.WriteInt(this.combinedCRC);
			this.bw.FinishAndPad();
		}

		// Token: 0x06002F72 RID: 12146 RVA: 0x000A8D54 File Offset: 0x000A6F54
		private void Finish()
		{
			try
			{
				int totalBytesWrittenOut = this.bw.TotalBytesWrittenOut;
				this.compressor.CompressAndWrite();
				this.combinedCRC = (this.combinedCRC << 1 | this.combinedCRC >> 31);
				this.combinedCRC ^= this.compressor.Crc32;
				this.EmitTrailer();
			}
			finally
			{
				this.output = null;
				this.compressor = null;
				this.bw = null;
			}
		}

		// Token: 0x17000DA3 RID: 3491
		// (get) Token: 0x06002F73 RID: 12147 RVA: 0x000A8DDC File Offset: 0x000A6FDC
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x06002F74 RID: 12148 RVA: 0x000A8DE4 File Offset: 0x000A6FE4
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (offset < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset ({0}) must be > 0", offset));
			}
			if (count < 0)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("count ({0}) must be > 0", count));
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("offset({0}) count({1}) bLength({2})", offset, count, buffer.Length));
			}
			if (this.output == null)
			{
				throw new global::System.IO.IOException("the stream is not open");
			}
			if (count == 0)
			{
				return;
			}
			int num = 0;
			int num2 = count;
			do
			{
				int num3 = this.compressor.Fill(buffer, offset, num2);
				if (num3 != num2)
				{
					int totalBytesWrittenOut = this.bw.TotalBytesWrittenOut;
					this.compressor.CompressAndWrite();
					this.combinedCRC = (this.combinedCRC << 1 | this.combinedCRC >> 31);
					this.combinedCRC ^= this.compressor.Crc32;
					offset += num3;
				}
				num2 -= num3;
				num += num3;
			}
			while (num2 > 0);
			this.totalBytesWrittenIn += num;
		}

		// Token: 0x17000DA4 RID: 3492
		// (get) Token: 0x06002F75 RID: 12149 RVA: 0x000A8EFC File Offset: 0x000A70FC
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DA5 RID: 3493
		// (get) Token: 0x06002F76 RID: 12150 RVA: 0x000A8F00 File Offset: 0x000A7100
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000DA6 RID: 3494
		// (get) Token: 0x06002F77 RID: 12151 RVA: 0x000A8F04 File Offset: 0x000A7104
		public override bool CanWrite
		{
			get
			{
				if (this.output == null)
				{
					throw new global::System.ObjectDisposedException("BZip2Stream");
				}
				return this.output.CanWrite;
			}
		}

		// Token: 0x17000DA7 RID: 3495
		// (get) Token: 0x06002F78 RID: 12152 RVA: 0x000A8F28 File Offset: 0x000A7128
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000DA8 RID: 3496
		// (get) Token: 0x06002F79 RID: 12153 RVA: 0x000A8F30 File Offset: 0x000A7130
		// (set) Token: 0x06002F7A RID: 12154 RVA: 0x000A8F3C File Offset: 0x000A713C
		public override long Position
		{
			get
			{
				return (long)this.totalBytesWrittenIn;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06002F7B RID: 12155 RVA: 0x000A8F44 File Offset: 0x000A7144
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F7C RID: 12156 RVA: 0x000A8F4C File Offset: 0x000A714C
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F7D RID: 12157 RVA: 0x000A8F54 File Offset: 0x000A7154
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002F7E RID: 12158 RVA: 0x000A8F5C File Offset: 0x000A715C
		[global::System.Diagnostics.Conditional("Trace")]
		private void TraceOutput(global::Ionic.BZip2.BZip2OutputStream.TraceBits bits, string format, params object[] varParams)
		{
			if ((bits & this.desiredTrace) != global::Ionic.BZip2.BZip2OutputStream.TraceBits.None)
			{
				int hashCode = global::System.Threading.Thread.CurrentThread.GetHashCode();
				global::System.Console.ForegroundColor = hashCode % 8 + global::System.ConsoleColor.Green;
				global::System.Console.Write("{0:000} PBOS ", hashCode);
				global::System.Console.WriteLine(format, varParams);
				global::System.Console.ResetColor();
			}
		}

		// Token: 0x04001129 RID: 4393
		private int totalBytesWrittenIn;

		// Token: 0x0400112A RID: 4394
		private bool leaveOpen;

		// Token: 0x0400112B RID: 4395
		private global::Ionic.BZip2.BZip2Compressor compressor;

		// Token: 0x0400112C RID: 4396
		private uint combinedCRC;

		// Token: 0x0400112D RID: 4397
		private global::System.IO.Stream output;

		// Token: 0x0400112E RID: 4398
		private global::Ionic.BZip2.BitWriter bw;

		// Token: 0x0400112F RID: 4399
		private int blockSize100k;

		// Token: 0x04001130 RID: 4400
		private global::Ionic.BZip2.BZip2OutputStream.TraceBits desiredTrace = global::Ionic.BZip2.BZip2OutputStream.TraceBits.Crc | global::Ionic.BZip2.BZip2OutputStream.TraceBits.Write;

		// Token: 0x020004E4 RID: 1252
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x04001457 RID: 5207
			None = 0U,
			// Token: 0x04001458 RID: 5208
			Crc = 1U,
			// Token: 0x04001459 RID: 5209
			Write = 2U,
			// Token: 0x0400145A RID: 5210
			All = 4294967295U
		}
	}
}
