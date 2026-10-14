using System;
using System.IO;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x0200004A RID: 74
	public class TarInputStream : global::System.IO.Stream
	{
		// Token: 0x06000391 RID: 913 RVA: 0x00010CD7 File Offset: 0x0000EED7
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public TarInputStream(global::System.IO.Stream inputStream) : this(inputStream, 20, null)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00010CE3 File Offset: 0x0000EEE3
		public TarInputStream(global::System.IO.Stream inputStream, global::System.Text.Encoding nameEncoding) : this(inputStream, 20, nameEncoding)
		{
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00010CEF File Offset: 0x0000EEEF
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public TarInputStream(global::System.IO.Stream inputStream, int blockFactor)
		{
			this.inputStream = inputStream;
			this.tarBuffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateInputTarBuffer(inputStream, blockFactor);
			this.encoding = null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00010D12 File Offset: 0x0000EF12
		public TarInputStream(global::System.IO.Stream inputStream, int blockFactor, global::System.Text.Encoding nameEncoding)
		{
			this.inputStream = inputStream;
			this.tarBuffer = global::ICSharpCode.SharpZipLib.Tar.TarBuffer.CreateInputTarBuffer(inputStream, blockFactor);
			this.encoding = nameEncoding;
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00010D35 File Offset: 0x0000EF35
		// (set) Token: 0x06000396 RID: 918 RVA: 0x00010D42 File Offset: 0x0000EF42
		public bool IsStreamOwner
		{
			get
			{
				return this.tarBuffer.IsStreamOwner;
			}
			set
			{
				this.tarBuffer.IsStreamOwner = value;
			}
		}

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00010D50 File Offset: 0x0000EF50
		public override bool CanRead
		{
			get
			{
				return this.inputStream.CanRead;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00010D5D File Offset: 0x0000EF5D
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000399 RID: 921 RVA: 0x00010D60 File Offset: 0x0000EF60
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x0600039A RID: 922 RVA: 0x00010D63 File Offset: 0x0000EF63
		public override long Length
		{
			get
			{
				return this.inputStream.Length;
			}
		}

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x0600039B RID: 923 RVA: 0x00010D70 File Offset: 0x0000EF70
		// (set) Token: 0x0600039C RID: 924 RVA: 0x00010D7D File Offset: 0x0000EF7D
		public override long Position
		{
			get
			{
				return this.inputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException("TarInputStream Seek not supported");
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00010D89 File Offset: 0x0000EF89
		public override void Flush()
		{
			this.inputStream.Flush();
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00010D96 File Offset: 0x0000EF96
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("TarInputStream Seek not supported");
		}

		// Token: 0x0600039F RID: 927 RVA: 0x00010DA2 File Offset: 0x0000EFA2
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException("TarInputStream SetLength not supported");
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00010DAE File Offset: 0x0000EFAE
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("TarInputStream Write not supported");
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x00010DBA File Offset: 0x0000EFBA
		public override void WriteByte(byte value)
		{
			throw new global::System.NotSupportedException("TarInputStream WriteByte not supported");
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x00010DC8 File Offset: 0x0000EFC8
		public override int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)array[0];
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x00010DF0 File Offset: 0x0000EFF0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int num = 0;
			if (this.entryOffset >= this.entrySize)
			{
				return 0;
			}
			long num2 = (long)count;
			if (num2 + this.entryOffset > this.entrySize)
			{
				num2 = this.entrySize - this.entryOffset;
			}
			if (this.readBuffer != null)
			{
				int num3 = (num2 > (long)this.readBuffer.Length) ? this.readBuffer.Length : ((int)num2);
				global::System.Array.Copy(this.readBuffer, 0, buffer, offset, num3);
				if (num3 >= this.readBuffer.Length)
				{
					this.readBuffer = null;
				}
				else
				{
					int num4 = this.readBuffer.Length - num3;
					byte[] destinationArray = new byte[num4];
					global::System.Array.Copy(this.readBuffer, num3, destinationArray, 0, num4);
					this.readBuffer = destinationArray;
				}
				num += num3;
				num2 -= (long)num3;
				offset += num3;
			}
			while (num2 > 0L)
			{
				byte[] array = this.tarBuffer.ReadBlock();
				if (array == null)
				{
					throw new global::ICSharpCode.SharpZipLib.Tar.TarException("unexpected EOF with " + num2.ToString() + " bytes unread");
				}
				int num5 = (int)num2;
				int num6 = array.Length;
				if (num6 > num5)
				{
					global::System.Array.Copy(array, 0, buffer, offset, num5);
					this.readBuffer = new byte[num6 - num5];
					global::System.Array.Copy(array, num5, this.readBuffer, 0, num6 - num5);
				}
				else
				{
					num5 = num6;
					global::System.Array.Copy(array, 0, buffer, offset, num6);
				}
				num += num5;
				num2 -= (long)num5;
				offset += num5;
			}
			this.entryOffset += (long)num;
			return num;
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00010F6C File Offset: 0x0000F16C
		protected override void Dispose(bool disposing)
		{
			if (disposing)
			{
				this.tarBuffer.Close();
			}
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00010F7C File Offset: 0x0000F17C
		public void SetEntryFactory(global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory factory)
		{
			this.entryFactory = factory;
		}

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x060003A6 RID: 934 RVA: 0x00010F85 File Offset: 0x0000F185
		public int RecordSize
		{
			get
			{
				return this.tarBuffer.RecordSize;
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00010F92 File Offset: 0x0000F192
		[global::System.Obsolete("Use RecordSize property instead")]
		public int GetRecordSize()
		{
			return this.tarBuffer.RecordSize;
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x060003A8 RID: 936 RVA: 0x00010F9F File Offset: 0x0000F19F
		public long Available
		{
			get
			{
				return this.entrySize - this.entryOffset;
			}
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00010FB0 File Offset: 0x0000F1B0
		public void Skip(long skipCount)
		{
			byte[] array = new byte[8192];
			int num2;
			for (long num = skipCount; num > 0L; num -= (long)num2)
			{
				int count = (num > (long)array.Length) ? array.Length : ((int)num);
				num2 = this.Read(array, 0, count);
				if (num2 == -1)
				{
					break;
				}
			}
		}

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x060003AA RID: 938 RVA: 0x00010FF3 File Offset: 0x0000F1F3
		public bool IsMarkSupported
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00010FF6 File Offset: 0x0000F1F6
		public void Mark(int markLimit)
		{
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00010FF8 File Offset: 0x0000F1F8
		public void Reset()
		{
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00010FFC File Offset: 0x0000F1FC
		public global::ICSharpCode.SharpZipLib.Tar.TarEntry GetNextEntry()
		{
			if (this.hasHitEOF)
			{
				return null;
			}
			if (this.currentEntry != null)
			{
				this.SkipToNextEntry();
			}
			byte[] array = this.tarBuffer.ReadBlock();
			if (array == null)
			{
				this.hasHitEOF = true;
			}
			else if (global::ICSharpCode.SharpZipLib.Tar.TarBuffer.IsEndOfArchiveBlock(array))
			{
				this.hasHitEOF = true;
				this.tarBuffer.ReadBlock();
			}
			else
			{
				this.hasHitEOF = false;
			}
			if (this.hasHitEOF)
			{
				this.currentEntry = null;
			}
			else
			{
				try
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = new global::ICSharpCode.SharpZipLib.Tar.TarHeader();
					tarHeader.ParseBuffer(array, this.encoding);
					if (!tarHeader.IsChecksumValid)
					{
						throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Header checksum is invalid");
					}
					this.entryOffset = 0L;
					this.entrySize = tarHeader.Size;
					global::System.Text.StringBuilder stringBuilder = null;
					if (tarHeader.TypeFlag == 76)
					{
						byte[] array2 = new byte[512];
						long num = this.entrySize;
						stringBuilder = new global::System.Text.StringBuilder();
						while (num > 0L)
						{
							int num2 = this.Read(array2, 0, (num > (long)array2.Length) ? array2.Length : ((int)num));
							if (num2 == -1)
							{
								throw new global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException("Failed to read long name entry");
							}
							stringBuilder.Append(global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(array2, 0, num2, this.encoding).ToString());
							num -= (long)num2;
						}
						this.SkipToNextEntry();
						array = this.tarBuffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 103)
					{
						this.SkipToNextEntry();
						array = this.tarBuffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 120)
					{
						byte[] array3 = new byte[512];
						long num3 = this.entrySize;
						global::ICSharpCode.SharpZipLib.Tar.TarExtendedHeaderReader tarExtendedHeaderReader = new global::ICSharpCode.SharpZipLib.Tar.TarExtendedHeaderReader();
						while (num3 > 0L)
						{
							int num4 = this.Read(array3, 0, (num3 > (long)array3.Length) ? array3.Length : ((int)num3));
							if (num4 == -1)
							{
								throw new global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException("Failed to read long name entry");
							}
							tarExtendedHeaderReader.Read(array3, num4);
							num3 -= (long)num4;
						}
						string value;
						if (tarExtendedHeaderReader.Headers.TryGetValue("path", out value))
						{
							stringBuilder = new global::System.Text.StringBuilder(value);
						}
						this.SkipToNextEntry();
						array = this.tarBuffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag == 86)
					{
						this.SkipToNextEntry();
						array = this.tarBuffer.ReadBlock();
					}
					else if (tarHeader.TypeFlag != 48 && tarHeader.TypeFlag != 0 && tarHeader.TypeFlag != 49 && tarHeader.TypeFlag != 50 && tarHeader.TypeFlag != 53)
					{
						this.SkipToNextEntry();
						array = this.tarBuffer.ReadBlock();
					}
					if (this.entryFactory == null)
					{
						this.currentEntry = new global::ICSharpCode.SharpZipLib.Tar.TarEntry(array, this.encoding);
						if (stringBuilder != null)
						{
							this.currentEntry.Name = stringBuilder.ToString();
						}
					}
					else
					{
						this.currentEntry = this.entryFactory.CreateEntry(array);
					}
					this.entryOffset = 0L;
					this.entrySize = this.currentEntry.Size;
				}
				catch (global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException ex)
				{
					this.entrySize = 0L;
					this.entryOffset = 0L;
					this.currentEntry = null;
					throw new global::ICSharpCode.SharpZipLib.Tar.InvalidHeaderException(string.Format("Bad header in record {0} block {1} {2}", this.tarBuffer.CurrentRecord, this.tarBuffer.CurrentBlock, ex.Message));
				}
			}
			return this.currentEntry;
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00011334 File Offset: 0x0000F534
		public void CopyEntryContents(global::System.IO.Stream outputStream)
		{
			byte[] array = new byte[32768];
			for (;;)
			{
				int num = this.Read(array, 0, array.Length);
				if (num <= 0)
				{
					break;
				}
				outputStream.Write(array, 0, num);
			}
		}

		// Token: 0x060003AF RID: 943 RVA: 0x00011368 File Offset: 0x0000F568
		private void SkipToNextEntry()
		{
			long num = this.entrySize - this.entryOffset;
			if (num > 0L)
			{
				this.Skip(num);
			}
			this.readBuffer = null;
		}

		// Token: 0x0400022D RID: 557
		protected bool hasHitEOF;

		// Token: 0x0400022E RID: 558
		protected long entrySize;

		// Token: 0x0400022F RID: 559
		protected long entryOffset;

		// Token: 0x04000230 RID: 560
		protected byte[] readBuffer;

		// Token: 0x04000231 RID: 561
		protected global::ICSharpCode.SharpZipLib.Tar.TarBuffer tarBuffer;

		// Token: 0x04000232 RID: 562
		private global::ICSharpCode.SharpZipLib.Tar.TarEntry currentEntry;

		// Token: 0x04000233 RID: 563
		protected global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory entryFactory;

		// Token: 0x04000234 RID: 564
		private readonly global::System.IO.Stream inputStream;

		// Token: 0x04000235 RID: 565
		private readonly global::System.Text.Encoding encoding;

		// Token: 0x0200008D RID: 141
		public interface IEntryFactory
		{
			// Token: 0x06000570 RID: 1392
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name);

			// Token: 0x06000571 RID: 1393
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName);

			// Token: 0x06000572 RID: 1394
			global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuffer);
		}

		// Token: 0x0200008E RID: 142
		public class EntryFactoryAdapter : global::ICSharpCode.SharpZipLib.Tar.TarInputStream.IEntryFactory
		{
			// Token: 0x06000573 RID: 1395 RVA: 0x00019143 File Offset: 0x00017343
			[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
			public EntryFactoryAdapter()
			{
			}

			// Token: 0x06000574 RID: 1396 RVA: 0x0001914B File Offset: 0x0001734B
			public EntryFactoryAdapter(global::System.Text.Encoding nameEncoding)
			{
				this.nameEncoding = nameEncoding;
			}

			// Token: 0x06000575 RID: 1397 RVA: 0x0001915A File Offset: 0x0001735A
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(string name)
			{
				return global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateTarEntry(name);
			}

			// Token: 0x06000576 RID: 1398 RVA: 0x00019162 File Offset: 0x00017362
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntryFromFile(string fileName)
			{
				return global::ICSharpCode.SharpZipLib.Tar.TarEntry.CreateEntryFromFile(fileName);
			}

			// Token: 0x06000577 RID: 1399 RVA: 0x0001916A File Offset: 0x0001736A
			public global::ICSharpCode.SharpZipLib.Tar.TarEntry CreateEntry(byte[] headerBuffer)
			{
				return new global::ICSharpCode.SharpZipLib.Tar.TarEntry(headerBuffer, this.nameEncoding);
			}

			// Token: 0x0400036E RID: 878
			private global::System.Text.Encoding nameEncoding;
		}
	}
}
