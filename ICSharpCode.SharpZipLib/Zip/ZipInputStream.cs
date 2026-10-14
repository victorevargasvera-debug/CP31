using System;
using System.IO;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002E RID: 46
	public class ZipInputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream
	{
		// Token: 0x060001CE RID: 462 RVA: 0x000089DC File Offset: 0x00006BDC
		public ZipInputStream(global::System.IO.Stream baseInputStream) : base(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true))
		{
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
		}

		// Token: 0x060001CF RID: 463 RVA: 0x00008A08 File Offset: 0x00006C08
		public ZipInputStream(global::System.IO.Stream baseInputStream, int bufferSize) : base(baseInputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true), bufferSize)
		{
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001D0 RID: 464 RVA: 0x00008A35 File Offset: 0x00006C35
		// (set) Token: 0x060001D1 RID: 465 RVA: 0x00008A3D File Offset: 0x00006C3D
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				this.password = value;
			}
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001D2 RID: 466 RVA: 0x00008A48 File Offset: 0x00006C48
		public bool CanDecompressEntry
		{
			get
			{
				return this.entry != null && global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.IsEntryCompressionMethodSupported(this.entry) && this.entry.CanDecompress && (!this.entry.HasFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.Descriptor) || this.entry.CompressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored || this.entry.IsCrypted);
			}
		}

		// Token: 0x060001D3 RID: 467 RVA: 0x00008AA4 File Offset: 0x00006CA4
		private static bool IsEntryCompressionMethodSupported(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethodForHeader = entry.CompressionMethodForHeader;
			return compressionMethodForHeader == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated || compressionMethodForHeader == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x00008AC4 File Offset: 0x00006CC4
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetNextEntry()
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed.");
			}
			if (this.entry != null)
			{
				this.CloseEntry();
			}
			int num = this.inputBuffer.ReadLeInt();
			if (num == 33639248 || num == 101010256 || num == 84233040 || num == 117853008 || num == 101075792)
			{
				base.Dispose();
				return null;
			}
			if (num == 808471376 || num == 134695760)
			{
				num = this.inputBuffer.ReadLeInt();
			}
			if (num != 67324752)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Wrong Local header signature: 0x" + string.Format("{0:X}", num));
			}
			short versionRequiredToExtract = (short)this.inputBuffer.ReadLeShort();
			this.flags = this.inputBuffer.ReadLeShort();
			this.method = (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)this.inputBuffer.ReadLeShort();
			uint num2 = (uint)this.inputBuffer.ReadLeInt();
			int num3 = this.inputBuffer.ReadLeInt();
			this.csize = (long)this.inputBuffer.ReadLeInt();
			this.size = (long)this.inputBuffer.ReadLeInt();
			int num4 = this.inputBuffer.ReadLeShort();
			int num5 = this.inputBuffer.ReadLeShort();
			bool flag = (this.flags & 1) == 1;
			byte[] array = new byte[num4];
			this.inputBuffer.ReadRawBuffer(array);
			string name = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(this.flags, array);
			this.entry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(name, (int)versionRequiredToExtract, 51, this.method)
			{
				Flags = this.flags
			};
			if ((this.flags & 8) == 0)
			{
				this.entry.Crc = ((long)num3 & (long)((ulong)-1));
				this.entry.Size = (this.size & (long)((ulong)-1));
				this.entry.CompressedSize = (this.csize & (long)((ulong)-1));
				this.entry.CryptoCheckValue = (byte)(num3 >> 24 & 255);
			}
			else
			{
				if (num3 != 0)
				{
					this.entry.Crc = ((long)num3 & (long)((ulong)-1));
				}
				if (this.size != 0L)
				{
					this.entry.Size = (this.size & (long)((ulong)-1));
				}
				if (this.csize != 0L)
				{
					this.entry.CompressedSize = (this.csize & (long)((ulong)-1));
				}
				this.entry.CryptoCheckValue = (byte)(num2 >> 8 & 255U);
			}
			this.entry.DosTime = (long)((ulong)num2);
			if (num5 > 0)
			{
				byte[] array2 = new byte[num5];
				this.inputBuffer.ReadRawBuffer(array2);
				this.entry.ExtraData = array2;
			}
			this.entry.ProcessExtraData(true);
			if (this.entry.CompressedSize >= 0L)
			{
				this.csize = this.entry.CompressedSize;
			}
			if (this.entry.Size >= 0L)
			{
				this.size = this.entry.Size;
			}
			if (this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored && ((!flag && this.csize != this.size) || (flag && this.csize - 12L != this.size)))
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Stored, but compressed != uncompressed");
			}
			if (global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.IsEntryCompressionMethodSupported(this.entry))
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.InitialRead);
			}
			else
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotSupported);
			}
			return this.entry;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x00008DF8 File Offset: 0x00006FF8
		private void ReadDataDescriptor()
		{
			if (this.inputBuffer.ReadLeInt() != 134695760)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data descriptor signature not found");
			}
			this.entry.Crc = ((long)this.inputBuffer.ReadLeInt() & (long)((ulong)-1));
			if (this.entry.LocalHeaderRequiresZip64)
			{
				this.csize = this.inputBuffer.ReadLeLong();
				this.size = this.inputBuffer.ReadLeLong();
			}
			else
			{
				this.csize = (long)this.inputBuffer.ReadLeInt();
				this.size = (long)this.inputBuffer.ReadLeInt();
			}
			this.entry.CompressedSize = this.csize;
			this.entry.Size = this.size;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x00008EB4 File Offset: 0x000070B4
		private void CompleteCloseEntry(bool testCrc)
		{
			base.StopDecrypting();
			if ((this.flags & 8) != 0)
			{
				this.ReadDataDescriptor();
			}
			this.size = 0L;
			if (testCrc && (this.crc.Value & (long)((ulong)-1)) != this.entry.Crc && this.entry.Crc != -1L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("CRC mismatch");
			}
			this.crc.Reset();
			if (this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				this.inf.Reset();
			}
			this.entry = null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x00008F40 File Offset: 0x00007140
		public void CloseEntry()
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed");
			}
			if (this.entry == null)
			{
				return;
			}
			if (this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				if ((this.flags & 8) != 0)
				{
					byte[] array = new byte[4096];
					while (this.Read(array, 0, array.Length) > 0)
					{
					}
					return;
				}
				this.csize -= this.inf.TotalIn;
				this.inputBuffer.Available += this.inf.RemainingInput;
			}
			if ((long)this.inputBuffer.Available > this.csize && this.csize >= 0L)
			{
				this.inputBuffer.Available = (int)((long)this.inputBuffer.Available - this.csize);
			}
			else
			{
				this.csize -= (long)this.inputBuffer.Available;
				this.inputBuffer.Available = 0;
				while (this.csize != 0L)
				{
					long num = base.Skip(this.csize);
					if (num <= 0L)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Zip archive ends early.");
					}
					this.csize -= num;
				}
			}
			this.CompleteCloseEntry(false);
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x0000906B File Offset: 0x0000726B
		public override int Available
		{
			get
			{
				if (this.entry == null)
				{
					return 0;
				}
				return 1;
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x060001D9 RID: 473 RVA: 0x00009078 File Offset: 0x00007278
		public override long Length
		{
			get
			{
				if (this.entry == null)
				{
					throw new global::System.InvalidOperationException("No current entry");
				}
				if (this.entry.Size >= 0L)
				{
					return this.entry.Size;
				}
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Length not available for the current entry");
			}
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000090B4 File Offset: 0x000072B4
		public override int ReadByte()
		{
			byte[] array = new byte[1];
			if (this.Read(array, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)(array[0] & byte.MaxValue);
		}

		// Token: 0x060001DB RID: 475 RVA: 0x000090DF File Offset: 0x000072DF
		private int ReadingNotAvailable(byte[] destination, int offset, int count)
		{
			throw new global::System.InvalidOperationException("Unable to read from this stream");
		}

		// Token: 0x060001DC RID: 476 RVA: 0x000090EB File Offset: 0x000072EB
		private int ReadingNotSupported(byte[] destination, int offset, int count)
		{
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("The compression method for this entry is not supported");
		}

		// Token: 0x060001DD RID: 477 RVA: 0x000090F7 File Offset: 0x000072F7
		private int StoredDescriptorEntry(byte[] destination, int offset, int count)
		{
			throw new global::ICSharpCode.SharpZipLib.StreamUnsupportedException("The combination of Stored compression method and Descriptor flag is not possible to read using ZipInputStream");
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00009104 File Offset: 0x00007304
		private int InitialRead(byte[] destination, int offset, int count)
		{
			bool flag = (this.entry.Flags & 8) != 0;
			if (this.entry.IsCrypted)
			{
				if (this.password == null)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password set.");
				}
				global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
				byte[] rgbKey = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(this.password));
				this.inputBuffer.CryptoTransform = pkzipClassicManaged.CreateDecryptor(rgbKey, null);
				byte[] array = new byte[12];
				this.inputBuffer.ReadClearTextBuffer(array, 0, 12);
				if (array[11] != this.entry.CryptoCheckValue)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid password");
				}
				if (this.csize >= 12L)
				{
					this.csize -= 12L;
				}
				else if (!flag)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Entry compressed size {0} too small for encryption", this.csize));
				}
			}
			else
			{
				this.inputBuffer.CryptoTransform = null;
			}
			if (this.csize <= 0L && !flag)
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
				return 0;
			}
			if (this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated && this.inputBuffer.Available > 0)
			{
				this.inputBuffer.SetInflaterInput(this.inf);
			}
			if (!this.entry.IsCrypted && this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored && flag)
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.StoredDescriptorEntry);
				return this.StoredDescriptorEntry(destination, offset, count);
			}
			if (!this.CanDecompressEntry)
			{
				this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotSupported);
				return this.ReadingNotSupported(destination, offset, count);
			}
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.BodyRead);
			return this.BodyRead(destination, offset, count);
		}

		// Token: 0x060001DF RID: 479 RVA: 0x000092B0 File Offset: 0x000074B0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (buffer.Length - offset < count)
			{
				throw new global::System.ArgumentException("Invalid offset/count combination");
			}
			return this.internalReader(buffer, offset, count);
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00009314 File Offset: 0x00007514
		private int BodyRead(byte[] buffer, int offset, int count)
		{
			if (this.crc == null)
			{
				throw new global::System.InvalidOperationException("Closed");
			}
			if (this.entry == null || count <= 0)
			{
				return 0;
			}
			if (offset + count > buffer.Length)
			{
				throw new global::System.ArgumentException("Offset + count exceeds buffer size");
			}
			bool flag = false;
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = this.method;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					count = base.Read(buffer, offset, count);
					if (count <= 0)
					{
						if (!this.inf.IsFinished)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Inflater not finished!");
						}
						this.inputBuffer.Available = this.inf.RemainingInput;
						if ((this.flags & 8) == 0 && ((this.inf.TotalIn != this.csize && this.csize != (long)((ulong)-1) && this.csize != -1L) || this.inf.TotalOut != this.size))
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Concat(new string[]
							{
								"Size mismatch: ",
								this.csize.ToString(),
								";",
								this.size.ToString(),
								" <-> ",
								this.inf.TotalIn.ToString(),
								";",
								this.inf.TotalOut.ToString()
							}));
						}
						this.inf.Reset();
						flag = true;
					}
				}
			}
			else
			{
				if ((long)count > this.csize && this.csize >= 0L)
				{
					count = (int)this.csize;
				}
				if (count > 0)
				{
					count = this.inputBuffer.ReadClearTextBuffer(buffer, offset, count);
					if (count > 0)
					{
						this.csize -= (long)count;
						this.size -= (long)count;
					}
				}
				if (this.csize == 0L)
				{
					flag = true;
				}
				else if (count < 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("EOF in stored block");
				}
			}
			if (count > 0)
			{
				this.crc.Update(new global::System.ArraySegment<byte>(buffer, offset, count));
			}
			if (flag)
			{
				this.CompleteCloseEntry(true);
			}
			return count;
		}

		// Token: 0x060001E1 RID: 481 RVA: 0x0000950A File Offset: 0x0000770A
		protected override void Dispose(bool disposing)
		{
			this.internalReader = new global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler(this.ReadingNotAvailable);
			this.crc = null;
			this.entry = null;
			base.Dispose(disposing);
		}

		// Token: 0x040000F1 RID: 241
		private global::ICSharpCode.SharpZipLib.Zip.ZipInputStream.ReadDataHandler internalReader;

		// Token: 0x040000F2 RID: 242
		private global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();

		// Token: 0x040000F3 RID: 243
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry;

		// Token: 0x040000F4 RID: 244
		private long size;

		// Token: 0x040000F5 RID: 245
		private global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method;

		// Token: 0x040000F6 RID: 246
		private int flags;

		// Token: 0x040000F7 RID: 247
		private string password;

		// Token: 0x02000089 RID: 137
		// (Invoke) Token: 0x0600055A RID: 1370
		private delegate int ReadDataHandler(byte[] b, int offset, int length);
	}
}
