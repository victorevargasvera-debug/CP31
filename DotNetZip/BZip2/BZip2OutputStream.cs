using System;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Ionic.BZip2
{
	// Token: 0x02000066 RID: 102
	public class BZip2OutputStream : global::System.IO.Stream
	{
		// Token: 0x0600050E RID: 1294 RVA: 0x0001FA43 File Offset: 0x0001DC43
		public BZip2OutputStream(global::System.IO.Stream output) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, false)
		{
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x0001FA52 File Offset: 0x0001DC52
		public BZip2OutputStream(global::System.IO.Stream output, int blockSize) : this(output, blockSize, false)
		{
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x0001FA5D File Offset: 0x0001DC5D
		public BZip2OutputStream(global::System.IO.Stream output, bool leaveOpen) : this(output, global::Ionic.BZip2.BZip2.MaxBlockSize, leaveOpen)
		{
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x0001FA6C File Offset: 0x0001DC6C
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

		// Token: 0x06000512 RID: 1298 RVA: 0x0001FB28 File Offset: 0x0001DD28
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

		// Token: 0x06000513 RID: 1299 RVA: 0x0001FB58 File Offset: 0x0001DD58
		public override void Flush()
		{
			if (this.output != null)
			{
				this.bw.Flush();
				this.output.Flush();
			}
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x0001FB78 File Offset: 0x0001DD78
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

		// Token: 0x06000515 RID: 1301 RVA: 0x0001FBB4 File Offset: 0x0001DDB4
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

		// Token: 0x06000516 RID: 1302 RVA: 0x0001FC30 File Offset: 0x0001DE30
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

		// Token: 0x17000139 RID: 313
		// (get) Token: 0x06000517 RID: 1303 RVA: 0x0001FCB4 File Offset: 0x0001DEB4
		public int BlockSize
		{
			get
			{
				return this.blockSize100k;
			}
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x0001FCBC File Offset: 0x0001DEBC
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

		// Token: 0x1700013A RID: 314
		// (get) Token: 0x06000519 RID: 1305 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700013B RID: 315
		// (get) Token: 0x0600051A RID: 1306 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700013C RID: 316
		// (get) Token: 0x0600051B RID: 1307 RVA: 0x0001FDBD File Offset: 0x0001DFBD
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

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600051C RID: 1308 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x0600051D RID: 1309 RVA: 0x0001FDDD File Offset: 0x0001DFDD
		// (set) Token: 0x0600051E RID: 1310 RVA: 0x000060ED File Offset: 0x000042ED
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

		// Token: 0x0600051F RID: 1311 RVA: 0x000060ED File Offset: 0x000042ED
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000520 RID: 1312 RVA: 0x000060ED File Offset: 0x000042ED
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000521 RID: 1313 RVA: 0x000060ED File Offset: 0x000042ED
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000522 RID: 1314 RVA: 0x0001FDE8 File Offset: 0x0001DFE8
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

		// Token: 0x0400038D RID: 909
		private int totalBytesWrittenIn;

		// Token: 0x0400038E RID: 910
		private bool leaveOpen;

		// Token: 0x0400038F RID: 911
		private global::Ionic.BZip2.BZip2Compressor compressor;

		// Token: 0x04000390 RID: 912
		private uint combinedCRC;

		// Token: 0x04000391 RID: 913
		private global::System.IO.Stream output;

		// Token: 0x04000392 RID: 914
		private global::Ionic.BZip2.BitWriter bw;

		// Token: 0x04000393 RID: 915
		private int blockSize100k;

		// Token: 0x04000394 RID: 916
		private global::Ionic.BZip2.BZip2OutputStream.TraceBits desiredTrace = global::Ionic.BZip2.BZip2OutputStream.TraceBits.Crc | global::Ionic.BZip2.BZip2OutputStream.TraceBits.Write;

		// Token: 0x0200007F RID: 127
		[global::System.Flags]
		private enum TraceBits : uint
		{
			// Token: 0x04000459 RID: 1113
			None = 0U,
			// Token: 0x0400045A RID: 1114
			Crc = 1U,
			// Token: 0x0400045B RID: 1115
			Write = 2U,
			// Token: 0x0400045C RID: 1116
			All = 4294967295U
		}
	}
}
