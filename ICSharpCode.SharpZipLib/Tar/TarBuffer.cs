using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000045 RID: 69
	public class TarBuffer
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600030B RID: 779 RVA: 0x0000F440 File Offset: 0x0000D640
		public int RecordSize
		{
			get
			{
				return this.recordSize;
			}
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0000F448 File Offset: 0x0000D648
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.recordSize;
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600030D RID: 781 RVA: 0x0000F450 File Offset: 0x0000D650
		public int BlockFactor
		{
			get
			{
				return this.blockFactor;
			}
		}

		// Token: 0x0600030E RID: 782 RVA: 0x0000F458 File Offset: 0x0000D658
		[global::System.Obsolete("Use BlockFactor property instead")]
		public int GetBlockFactor()
		{
			return this.blockFactor;
		}

		// Token: 0x0600030F RID: 783 RVA: 0x0000F460 File Offset: 0x0000D660
		protected TarBuffer()
		{
		}

		// Token: 0x06000310 RID: 784 RVA: 0x0000F482 File Offset: 0x0000D682
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(global::System.IO.Stream inputStream)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateInputTarBuffer(inputStream, 20);
		}

		// Token: 0x06000311 RID: 785 RVA: 0x0000F49A File Offset: 0x0000D69A
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateInputTarBuffer(global::System.IO.Stream inputStream, int blockFactor)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			if (blockFactor <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarBuffer tarBuffer = new global::ICSharpCode.SharpZipLib.Tar.TarBuffer();
			tarBuffer.inputStream = inputStream;
			tarBuffer.outputStream = null;
			tarBuffer.Initialize(blockFactor);
			return tarBuffer;
		}

		// Token: 0x06000312 RID: 786 RVA: 0x0000F4D8 File Offset: 0x0000D6D8
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(global::System.IO.Stream outputStream)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateOutputTarBuffer(outputStream, 20);
		}

		// Token: 0x06000313 RID: 787 RVA: 0x0000F4F0 File Offset: 0x0000D6F0
		public static global::ICSharpCode.SharpZipLib.Tar.TarBuffer CreateOutputTarBuffer(global::System.IO.Stream outputStream, int blockFactor)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (blockFactor <= 0)
			{
				throw new global::System.ArgumentOutOfRangeException("blockFactor", "Factor cannot be negative");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarBuffer tarBuffer = new global::ICSharpCode.SharpZipLib.Tar.TarBuffer();
			tarBuffer.inputStream = null;
			tarBuffer.outputStream = outputStream;
			tarBuffer.Initialize(blockFactor);
			return tarBuffer;
		}

		// Token: 0x06000314 RID: 788 RVA: 0x0000F530 File Offset: 0x0000D730
		private void Initialize(int archiveBlockFactor)
		{
			this.blockFactor = archiveBlockFactor;
			this.recordSize = archiveBlockFactor * 512;
			this.recordBuffer = new byte[this.RecordSize];
			if (this.inputStream != null)
			{
				this.currentRecordIndex = -1;
				this.currentBlockIndex = this.BlockFactor;
				return;
			}
			this.currentRecordIndex = 0;
			this.currentBlockIndex = 0;
		}

		// Token: 0x06000315 RID: 789 RVA: 0x0000F58C File Offset: 0x0000D78C
		[global::System.Obsolete("Use IsEndOfArchiveBlock instead")]
		public bool IsEOFBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (block.Length != 512)
			{
				throw new global::System.ArgumentException("block length is invalid");
			}
			for (int i = 0; i < 512; i++)
			{
				if (block[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000316 RID: 790 RVA: 0x0000F5D4 File Offset: 0x0000D7D4
		public static bool IsEndOfArchiveBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (block.Length != 512)
			{
				throw new global::System.ArgumentException("block length is invalid");
			}
			for (int i = 0; i < 512; i++)
			{
				if (block[i] != 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x06000317 RID: 791 RVA: 0x0000F61C File Offset: 0x0000D81C
		public void SkipBlock()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("no input stream defined");
			}
			if (this.currentBlockIndex >= this.BlockFactor && !this.ReadRecord())
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Failed to read a record");
			}
			this.currentBlockIndex++;
		}

		// Token: 0x06000318 RID: 792 RVA: 0x0000F66C File Offset: 0x0000D86C
		public byte[] ReadBlock()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.ReadBlock - no input stream defined");
			}
			if (this.currentBlockIndex >= this.BlockFactor && !this.ReadRecord())
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Failed to read a record");
			}
			byte[] array = new byte[512];
			global::System.Array.Copy(this.recordBuffer, this.currentBlockIndex * 512, array, 0, 512);
			this.currentBlockIndex++;
			return array;
		}

		// Token: 0x06000319 RID: 793 RVA: 0x0000F6E8 File Offset: 0x0000D8E8
		private bool ReadRecord()
		{
			if (this.inputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("no input stream defined");
			}
			this.currentBlockIndex = 0;
			int num = 0;
			long num2;
			for (int i = this.RecordSize; i > 0; i -= (int)num2)
			{
				num2 = (long)this.inputStream.Read(this.recordBuffer, num, i);
				if (num2 <= 0L)
				{
					break;
				}
				num += (int)num2;
			}
			this.currentRecordIndex++;
			return true;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0000F751 File Offset: 0x0000D951
		public int CurrentBlock
		{
			get
			{
				return this.currentBlockIndex;
			}
		}

		// Token: 0x170000B3 RID: 179
		// (get) Token: 0x0600031B RID: 795 RVA: 0x0000F759 File Offset: 0x0000D959
		// (set) Token: 0x0600031C RID: 796 RVA: 0x0000F761 File Offset: 0x0000D961
		public bool IsStreamOwner { get; set; } = true;

		// Token: 0x0600031D RID: 797 RVA: 0x0000F76A File Offset: 0x0000D96A
		[global::System.Obsolete("Use CurrentBlock property instead")]
		public int GetCurrentBlockNum()
		{
			return this.currentBlockIndex;
		}

		// Token: 0x170000B4 RID: 180
		// (get) Token: 0x0600031E RID: 798 RVA: 0x0000F772 File Offset: 0x0000D972
		public int CurrentRecord
		{
			get
			{
				return this.currentRecordIndex;
			}
		}

		// Token: 0x0600031F RID: 799 RVA: 0x0000F77A File Offset: 0x0000D97A
		[global::System.Obsolete("Use CurrentRecord property instead")]
		public int GetCurrentRecordNum()
		{
			return this.currentRecordIndex;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x0000F784 File Offset: 0x0000D984
		public void WriteBlock(byte[] block)
		{
			if (block == null)
			{
				throw new global::System.ArgumentNullException("block");
			}
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteBlock - no output stream defined");
			}
			if (block.Length != 512)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(string.Format("TarBuffer.WriteBlock - block to write has length '{0}' which is not the block size of '{1}'", block.Length, 512));
			}
			if (this.currentBlockIndex >= this.BlockFactor)
			{
				this.WriteRecord();
			}
			global::System.Array.Copy(block, 0, this.recordBuffer, this.currentBlockIndex * 512, 512);
			this.currentBlockIndex++;
		}

		// Token: 0x06000321 RID: 801 RVA: 0x0000F820 File Offset: 0x0000DA20
		public void WriteBlock(byte[] buffer, int offset)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteBlock - no output stream defined");
			}
			if (offset < 0 || offset >= buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (offset + 512 > buffer.Length)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException(string.Format("TarBuffer.WriteBlock - record has length '{0}' with offset '{1}' which is less than the record size of '{2}'", buffer.Length, offset, this.recordSize));
			}
			if (this.currentBlockIndex >= this.BlockFactor)
			{
				this.WriteRecord();
			}
			global::System.Array.Copy(buffer, offset, this.recordBuffer, this.currentBlockIndex * 512, 512);
			this.currentBlockIndex++;
		}

		// Token: 0x06000322 RID: 802 RVA: 0x0000F8D8 File Offset: 0x0000DAD8
		private void WriteRecord()
		{
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteRecord no output stream defined");
			}
			this.outputStream.Write(this.recordBuffer, 0, this.RecordSize);
			this.outputStream.Flush();
			this.currentBlockIndex = 0;
			this.currentRecordIndex++;
		}

		// Token: 0x06000323 RID: 803 RVA: 0x0000F930 File Offset: 0x0000DB30
		private void WriteFinalRecord()
		{
			if (this.outputStream == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Tar.TarException("TarBuffer.WriteFinalRecord no output stream defined");
			}
			if (this.currentBlockIndex > 0)
			{
				int num = this.currentBlockIndex * 512;
				global::System.Array.Clear(this.recordBuffer, num, this.RecordSize - num);
				this.WriteRecord();
			}
			this.outputStream.Flush();
		}

		// Token: 0x06000324 RID: 804 RVA: 0x0000F98C File Offset: 0x0000DB8C
		public void Close()
		{
			if (this.outputStream != null)
			{
				this.WriteFinalRecord();
				if (this.IsStreamOwner)
				{
					this.outputStream.Dispose();
				}
				this.outputStream = null;
				return;
			}
			if (this.inputStream != null)
			{
				if (this.IsStreamOwner)
				{
					this.inputStream.Dispose();
				}
				this.inputStream = null;
			}
		}

		// Token: 0x040001D4 RID: 468
		public const int BlockSize = 512;

		// Token: 0x040001D5 RID: 469
		public const int DefaultBlockFactor = 20;

		// Token: 0x040001D6 RID: 470
		public const int DefaultRecordSize = 10240;

		// Token: 0x040001D8 RID: 472
		private global::System.IO.Stream inputStream;

		// Token: 0x040001D9 RID: 473
		private global::System.IO.Stream outputStream;

		// Token: 0x040001DA RID: 474
		private byte[] recordBuffer;

		// Token: 0x040001DB RID: 475
		private int currentBlockIndex;

		// Token: 0x040001DC RID: 476
		private int currentRecordIndex;

		// Token: 0x040001DD RID: 477
		private int recordSize = 10240;

		// Token: 0x040001DE RID: 478
		private int blockFactor = 20;
	}
}
