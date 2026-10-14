using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x0200003F RID: 63
	public class InflaterInputStream : global::System.IO.Stream
	{
		// Token: 0x060002A9 RID: 681 RVA: 0x0000DFBE File Offset: 0x0000C1BE
		public InflaterInputStream(global::System.IO.Stream baseInputStream) : this(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(), 4096)
		{
		}

		// Token: 0x060002AA RID: 682 RVA: 0x0000DFD1 File Offset: 0x0000C1D1
		public InflaterInputStream(global::System.IO.Stream baseInputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf) : this(baseInputStream, inf, 4096)
		{
		}

		// Token: 0x060002AB RID: 683 RVA: 0x0000DFE0 File Offset: 0x0000C1E0
		public InflaterInputStream(global::System.IO.Stream baseInputStream, global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inflater, int bufferSize)
		{
			if (baseInputStream == null)
			{
				throw new global::System.ArgumentNullException("baseInputStream");
			}
			if (inflater == null)
			{
				throw new global::System.ArgumentNullException("inflater");
			}
			if (bufferSize <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("bufferSize");
			}
			this.baseInputStream = baseInputStream;
			this.inf = inflater;
			this.inputBuffer = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer(baseInputStream, bufferSize);
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002AC RID: 684 RVA: 0x0000E040 File Offset: 0x0000C240
		// (set) Token: 0x060002AD RID: 685 RVA: 0x0000E048 File Offset: 0x0000C248
		public bool IsStreamOwner { get; set; } = true;

		// Token: 0x060002AE RID: 686 RVA: 0x0000E054 File Offset: 0x0000C254
		public long Skip(long count)
		{
			if (count <= 0L)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (this.baseInputStream.CanSeek)
			{
				this.baseInputStream.Seek(count, global::System.IO.SeekOrigin.Current);
				return count;
			}
			int num = 2048;
			if (count < (long)num)
			{
				num = (int)count;
			}
			byte[] buffer = new byte[num];
			int num2 = 1;
			long num3 = count;
			while (num3 > 0L && num2 > 0)
			{
				if (num3 < (long)num)
				{
					num = (int)num3;
				}
				num2 = this.baseInputStream.Read(buffer, 0, num);
				num3 -= (long)num2;
			}
			return count - num3;
		}

		// Token: 0x060002AF RID: 687 RVA: 0x0000E0D1 File Offset: 0x0000C2D1
		protected void StopDecrypting()
		{
			this.inputBuffer.CryptoTransform = null;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x060002B0 RID: 688 RVA: 0x0000E0DF File Offset: 0x0000C2DF
		public virtual int Available
		{
			get
			{
				if (!this.inf.IsFinished)
				{
					return 1;
				}
				return 0;
			}
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x0000E0F4 File Offset: 0x0000C2F4
		protected void Fill()
		{
			if (this.inputBuffer.Available <= 0)
			{
				this.inputBuffer.Fill();
				if (this.inputBuffer.Available <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Unexpected EOF");
				}
			}
			this.inputBuffer.SetInflaterInput(this.inf);
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x060002B2 RID: 690 RVA: 0x0000E144 File Offset: 0x0000C344
		public override bool CanRead
		{
			get
			{
				return this.baseInputStream.CanRead;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x060002B3 RID: 691 RVA: 0x0000E151 File Offset: 0x0000C351
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x060002B4 RID: 692 RVA: 0x0000E154 File Offset: 0x0000C354
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x060002B5 RID: 693 RVA: 0x0000E157 File Offset: 0x0000C357
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException("InflaterInputStream Length is not supported");
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x060002B6 RID: 694 RVA: 0x0000E163 File Offset: 0x0000C363
		// (set) Token: 0x060002B7 RID: 695 RVA: 0x0000E170 File Offset: 0x0000C370
		public override long Position
		{
			get
			{
				return this.baseInputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("InflaterInputStream Position not supported");
			}
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x0000E17C File Offset: 0x0000C37C
		public override void Flush()
		{
			this.baseInputStream.Flush();
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x0000E189 File Offset: 0x0000C389
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("Seek not supported");
		}

		// Token: 0x060002BA RID: 698 RVA: 0x0000E195 File Offset: 0x0000C395
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream SetLength not supported");
		}

		// Token: 0x060002BB RID: 699 RVA: 0x0000E1A1 File Offset: 0x0000C3A1
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("InflaterInputStream Write not supported");
		}

		// Token: 0x060002BC RID: 700 RVA: 0x0000E1AD File Offset: 0x0000C3AD
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("InflaterInputStream WriteByte not supported");
		}

		// Token: 0x060002BD RID: 701 RVA: 0x0000E1B9 File Offset: 0x0000C3B9
		protected override void Dispose(bool disposing)
		{
			if (!this.isClosed)
			{
				this.isClosed = true;
				if (this.IsStreamOwner)
				{
					this.baseInputStream.Dispose();
				}
			}
		}

		// Token: 0x060002BE RID: 702 RVA: 0x0000E1E0 File Offset: 0x0000C3E0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.inf.IsNeedingDictionary)
			{
				throw new global::ICSharpCode.SharpZipLib.SharpZipBaseException("Need a dictionary");
			}
			int num = count;
			for (;;)
			{
				int num2 = this.inf.Inflate(buffer, offset, num);
				offset += num2;
				num -= num2;
				if (num == 0 || this.inf.IsFinished)
				{
					goto IL_65;
				}
				if (this.inf.IsNeedingInput)
				{
					this.Fill();
				}
				else if (num2 == 0)
				{
					break;
				}
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid input data");
			IL_65:
			return count - num;
		}

		// Token: 0x040001B8 RID: 440
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater inf;

		// Token: 0x040001B9 RID: 441
		protected global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputBuffer inputBuffer;

		// Token: 0x040001BA RID: 442
		private global::System.IO.Stream baseInputStream;

		// Token: 0x040001BB RID: 443
		protected long csize;

		// Token: 0x040001BC RID: 444
		private bool isClosed;
	}
}
