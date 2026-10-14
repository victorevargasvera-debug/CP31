using System;
using System.IO;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200004B RID: 75
	public class TarOutputStream : global::System.IO.Stream
	{
		// Token: 0x060003B0 RID: 944 RVA: 0x00011396 File Offset: 0x0000F596
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public TarOutputStream(global::System.IO.Stream outputStream) : this(outputStream, 20)
		{
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x000113A1 File Offset: 0x0000F5A1
		public TarOutputStream(global::System.IO.Stream outputStream, global::System.Text.Encoding nameEncoding) : this(outputStream, 20, nameEncoding)
		{
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x000113B0 File Offset: 0x0000F5B0
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public TarOutputStream(global::System.IO.Stream outputStream, int blockFactor)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			this.outputStream = outputStream;
			this.buffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateOutputTarBuffer(outputStream, blockFactor);
			this.assemblyBuffer = new byte[512];
			this.blockBuffer = new byte[512];
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00011408 File Offset: 0x0000F608
		public TarOutputStream(global::System.IO.Stream outputStream, int blockFactor, global::System.Text.Encoding nameEncoding)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			this.outputStream = outputStream;
			this.buffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateOutputTarBuffer(outputStream, blockFactor);
			this.assemblyBuffer = new byte[512];
			this.blockBuffer = new byte[512];
			this.nameEncoding = nameEncoding;
		}

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x060003B4 RID: 948 RVA: 0x00011464 File Offset: 0x0000F664
		// (set) Token: 0x060003B5 RID: 949 RVA: 0x00011471 File Offset: 0x0000F671
		public bool IsStreamOwner
		{
			get
			{
				return this.buffer.IsStreamOwner;
			}
			set
			{
				this.buffer.IsStreamOwner = value;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x060003B6 RID: 950 RVA: 0x0001147F File Offset: 0x0000F67F
		public override bool CanRead
		{
			get
			{
				return this.outputStream.CanRead;
			}
		}

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x060003B7 RID: 951 RVA: 0x0001148C File Offset: 0x0000F68C
		public override bool CanSeek
		{
			get
			{
				return this.outputStream.CanSeek;
			}
		}

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x060003B8 RID: 952 RVA: 0x00011499 File Offset: 0x0000F699
		public override bool CanWrite
		{
			get
			{
				return this.outputStream.CanWrite;
			}
		}

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x060003B9 RID: 953 RVA: 0x000114A6 File Offset: 0x0000F6A6
		public override long Length
		{
			get
			{
				return this.outputStream.Length;
			}
		}

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x060003BA RID: 954 RVA: 0x000114B3 File Offset: 0x0000F6B3
		// (set) Token: 0x060003BB RID: 955 RVA: 0x000114C0 File Offset: 0x0000F6C0
		public override long Position
		{
			get
			{
				return this.outputStream.Position;
			}
			set
			{
				this.outputStream.Position = value;
			}
		}

		// Token: 0x060003BC RID: 956 RVA: 0x000114CE File Offset: 0x0000F6CE
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.outputStream.Seek(offset, origin);
		}

		// Token: 0x060003BD RID: 957 RVA: 0x000114DD File Offset: 0x0000F6DD
		public override void SetLength(long value)
		{
			this.outputStream.SetLength(value);
		}

		// Token: 0x060003BE RID: 958 RVA: 0x000114EB File Offset: 0x0000F6EB
		public override int ReadByte()
		{
			return this.outputStream.ReadByte();
		}

		// Token: 0x060003BF RID: 959 RVA: 0x000114F8 File Offset: 0x0000F6F8
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.outputStream.Read(buffer, offset, count);
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x00011508 File Offset: 0x0000F708
		public override void Flush()
		{
			this.outputStream.Flush();
		}

		// Token: 0x060003C1 RID: 961 RVA: 0x00011515 File Offset: 0x0000F715
		public void Finish()
		{
			if (this.IsEntryOpen)
			{
				this.CloseEntry();
			}
			this.WriteEofBlock();
		}

		// Token: 0x060003C2 RID: 962 RVA: 0x0001152B File Offset: 0x0000F72B
		protected override void Dispose(bool disposing)
		{
			if (!this.isClosed)
			{
				this.isClosed = true;
				this.Finish();
				this.buffer.Close();
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x0001154D File Offset: 0x0000F74D
		public int RecordSize
		{
			get
			{
				return this.buffer.RecordSize;
			}
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x0001155A File Offset: 0x0000F75A
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.buffer.RecordSize;
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x060003C5 RID: 965 RVA: 0x00011567 File Offset: 0x0000F767
		private bool IsEntryOpen
		{
			get
			{
				return this.currBytes < this.currSize;
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00011578 File Offset: 0x0000F778
		public void PutNextEntry(global::ICSharpCode.SharpZipLib.Tar.TarEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			int num = (this.nameEncoding != null) ? this.nameEncoding.GetByteCount(entry.TarHeader.Name) : entry.TarHeader.Name.Length;
			if (num > 100)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
				tarHeader.TypeFlag = 76;
				tarHeader.Name += "././@LongLink";
				tarHeader.Mode = 420;
				tarHeader.UserId = entry.UserId;
				tarHeader.GroupId = entry.GroupId;
				tarHeader.GroupName = entry.GroupName;
				tarHeader.UserName = entry.UserName;
				tarHeader.LinkName = "";
				tarHeader.Size = (long)(num + 1);
				tarHeader.WriteHeader(this.blockBuffer, this.nameEncoding);
				this.buffer.WriteBlock(this.blockBuffer);
				int i = 0;
				while (i < num + 1)
				{
					global::System.Array.Clear(this.blockBuffer, 0, this.blockBuffer.Length);
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetAsciiBytes(entry.TarHeader.Name, i, this.blockBuffer, 0, 512, this.nameEncoding);
					i += 512;
					this.buffer.WriteBlock(this.blockBuffer);
				}
			}
			entry.WriteEntryHeader(this.blockBuffer, this.nameEncoding);
			this.buffer.WriteBlock(this.blockBuffer);
			this.currBytes = 0L;
			this.currSize = (entry.IsDirectory ? 0L : entry.Size);
		}

		// Token: 0x060003C7 RID: 967 RVA: 0x00011700 File Offset: 0x0000F900
		public void CloseEntry()
		{
			if (this.assemblyBufferLength > 0)
			{
				global::System.Array.Clear(this.assemblyBuffer, this.assemblyBufferLength, this.assemblyBuffer.Length - this.assemblyBufferLength);
				this.buffer.WriteBlock(this.assemblyBuffer);
				this.currBytes += (long)this.assemblyBufferLength;
				this.assemblyBufferLength = 0;
			}
			if (this.currBytes < this.currSize)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(string.Format("Entry closed at '{0}' before the '{1}' bytes specified in the header were written", this.currBytes, this.currSize));
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00011796 File Offset: 0x0000F996
		public override void WriteByte(byte value)
		{
			this.Write(new byte[]
			{
				value
			}, 0, 1);
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x000117AC File Offset: 0x0000F9AC
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (buffer.Length - offset < count)
			{
				throw new global::System.ArgumentException("offset and count combination is invalid");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (this.currBytes + (long)count > this.currSize)
			{
				string message = string.Format("request to write '{0}' bytes exceeds size in header of '{1}' bytes", count, this.currSize);
				throw new global::System.ArgumentOutOfRangeException("count", message);
			}
			if (this.assemblyBufferLength > 0)
			{
				if (this.assemblyBufferLength + count >= this.blockBuffer.Length)
				{
					int num = this.blockBuffer.Length - this.assemblyBufferLength;
					global::System.Array.Copy(this.assemblyBuffer, 0, this.blockBuffer, 0, this.assemblyBufferLength);
					global::System.Array.Copy(buffer, offset, this.blockBuffer, this.assemblyBufferLength, num);
					this.buffer.WriteBlock(this.blockBuffer);
					this.currBytes += (long)this.blockBuffer.Length;
					offset += num;
					count -= num;
					this.assemblyBufferLength = 0;
				}
				else
				{
					global::System.Array.Copy(buffer, offset, this.assemblyBuffer, this.assemblyBufferLength, count);
					offset += count;
					this.assemblyBufferLength += count;
					count -= count;
				}
			}
			while (count > 0)
			{
				if (count < this.blockBuffer.Length)
				{
					global::System.Array.Copy(buffer, offset, this.assemblyBuffer, this.assemblyBufferLength, count);
					this.assemblyBufferLength += count;
					return;
				}
				this.buffer.WriteBlock(buffer, offset);
				int num2 = this.blockBuffer.Length;
				this.currBytes += (long)num2;
				count -= num2;
				offset += num2;
			}
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00011962 File Offset: 0x0000FB62
		private void WriteEofBlock()
		{
			global::System.Array.Clear(this.blockBuffer, 0, this.blockBuffer.Length);
			this.buffer.WriteBlock(this.blockBuffer);
			this.buffer.WriteBlock(this.blockBuffer);
		}

		// Token: 0x04000236 RID: 566
		private long currBytes;

		// Token: 0x04000237 RID: 567
		private int assemblyBufferLength;

		// Token: 0x04000238 RID: 568
		private bool isClosed;

		// Token: 0x04000239 RID: 569
		protected long currSize;

		// Token: 0x0400023A RID: 570
		protected byte[] blockBuffer;

		// Token: 0x0400023B RID: 571
		protected byte[] assemblyBuffer;

		// Token: 0x0400023C RID: 572
		protected global::ICSharpCode.SharpZipLib.Tar.TarBuffer buffer;

		// Token: 0x0400023D RID: 573
		protected global::System.IO.Stream outputStream;

		// Token: 0x0400023E RID: 574
		protected global::System.Text.Encoding nameEncoding;
	}
}
