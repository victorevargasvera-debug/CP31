using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x0200002D RID: 45
	internal class ZipHelperStream : global::System.IO.Stream
	{
		// Token: 0x060001AE RID: 430 RVA: 0x000082F2 File Offset: 0x000064F2
		public ZipHelperStream(string name)
		{
			this.stream_ = new global::System.IO.FileStream(name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite);
			this.isOwner_ = true;
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0000830F File Offset: 0x0000650F
		public ZipHelperStream(global::System.IO.Stream stream)
		{
			this.stream_ = stream;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x060001B0 RID: 432 RVA: 0x0000831E File Offset: 0x0000651E
		// (set) Token: 0x060001B1 RID: 433 RVA: 0x00008326 File Offset: 0x00006526
		public bool IsStreamOwner
		{
			get
			{
				return this.isOwner_;
			}
			set
			{
				this.isOwner_ = value;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001B2 RID: 434 RVA: 0x0000832F File Offset: 0x0000652F
		public override bool CanRead
		{
			get
			{
				return this.stream_.CanRead;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001B3 RID: 435 RVA: 0x0000833C File Offset: 0x0000653C
		public override bool CanSeek
		{
			get
			{
				return this.stream_.CanSeek;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00008349 File Offset: 0x00006549
		public override bool CanTimeout
		{
			get
			{
				return this.stream_.CanTimeout;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001B5 RID: 437 RVA: 0x00008356 File Offset: 0x00006556
		public override long Length
		{
			get
			{
				return this.stream_.Length;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00008363 File Offset: 0x00006563
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00008370 File Offset: 0x00006570
		public override long Position
		{
			get
			{
				return this.stream_.Position;
			}
			set
			{
				this.stream_.Position = value;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x0000837E File Offset: 0x0000657E
		public override bool CanWrite
		{
			get
			{
				return this.stream_.CanWrite;
			}
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x0000838B File Offset: 0x0000658B
		public override void Flush()
		{
			this.stream_.Flush();
		}

		// Token: 0x060001BA RID: 442 RVA: 0x00008398 File Offset: 0x00006598
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.stream_.Seek(offset, origin);
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000083A7 File Offset: 0x000065A7
		public override void SetLength(long value)
		{
			this.stream_.SetLength(value);
		}

		// Token: 0x060001BC RID: 444 RVA: 0x000083B5 File Offset: 0x000065B5
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this.stream_.Read(buffer, offset, count);
		}

		// Token: 0x060001BD RID: 445 RVA: 0x000083C5 File Offset: 0x000065C5
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.stream_.Write(buffer, offset, count);
		}

		// Token: 0x060001BE RID: 446 RVA: 0x000083D8 File Offset: 0x000065D8
		protected override void Dispose(bool disposing)
		{
			global::System.IO.Stream stream = this.stream_;
			this.stream_ = null;
			if (this.isOwner_ && stream != null)
			{
				this.isOwner_ = false;
				stream.Dispose();
			}
		}

		// Token: 0x060001BF RID: 447 RVA: 0x0000840C File Offset: 0x0000660C
		private void WriteLocalHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.EntryPatchData patchData)
		{
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = entry.CompressionMethod;
			bool flag = true;
			bool flag2 = false;
			this.WriteLEInt(67324752);
			this.WriteLEShort(entry.Version);
			this.WriteLEShort(entry.Flags);
			this.WriteLEShort((int)((byte)compressionMethod));
			this.WriteLEInt((int)entry.DosTime);
			if (flag)
			{
				this.WriteLEInt((int)entry.Crc);
				if (entry.LocalHeaderRequiresZip64)
				{
					this.WriteLEInt(-1);
					this.WriteLEInt(-1);
				}
				else
				{
					this.WriteLEInt(entry.IsCrypted ? ((int)entry.CompressedSize + 12) : ((int)entry.CompressedSize));
					this.WriteLEInt((int)entry.Size);
				}
			}
			else
			{
				if (patchData != null)
				{
					patchData.CrcPatchOffset = this.stream_.Position;
				}
				this.WriteLEInt(0);
				if (patchData != null)
				{
					patchData.SizePatchOffset = this.stream_.Position;
				}
				if (entry.LocalHeaderRequiresZip64 && flag2)
				{
					this.WriteLEInt(-1);
					this.WriteLEInt(-1);
				}
				else
				{
					this.WriteLEInt(0);
					this.WriteLEInt(0);
				}
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name too long.");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(entry.ExtraData);
			if (entry.LocalHeaderRequiresZip64 && (flag || flag2))
			{
				zipExtraData.StartNewEntry();
				if (flag)
				{
					zipExtraData.AddLeLong(entry.Size);
					zipExtraData.AddLeLong(entry.CompressedSize);
				}
				else
				{
					zipExtraData.AddLeLong(-1L);
					zipExtraData.AddLeLong(-1L);
				}
				zipExtraData.AddNewEntry(1);
				if (!zipExtraData.Find(1))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Internal error cant find extra data");
				}
				if (patchData != null)
				{
					patchData.SizePatchOffset = (long)zipExtraData.CurrentReadIndex;
				}
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			this.WriteLEShort(array.Length);
			this.WriteLEShort(entryData.Length);
			if (array.Length != 0)
			{
				this.stream_.Write(array, 0, array.Length);
			}
			if (entry.LocalHeaderRequiresZip64 && flag2)
			{
				patchData.SizePatchOffset += this.stream_.Position;
			}
			if (entryData.Length != 0)
			{
				this.stream_.Write(entryData, 0, entryData.Length);
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x0000862C File Offset: 0x0000682C
		public long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			long num = endLocation - (long)minimumBlockSize;
			if (num < 0L)
			{
				return -1L;
			}
			long num2 = global::System.Math.Max(num - (long)maximumVariableData, 0L);
			while (num >= num2)
			{
				long num3 = num;
				num = num3 - 1L;
				this.Seek(num3, global::System.IO.SeekOrigin.Begin);
				if (this.ReadLEInt() == signature)
				{
					return this.Position;
				}
			}
			return -1L;
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00008678 File Offset: 0x00006878
		public void WriteZip64EndOfCentralDirectory(long noOfEntries, long sizeEntries, long centralDirOffset)
		{
			long value = centralDirOffset + sizeEntries;
			this.WriteLEInt(101075792);
			this.WriteLELong(44L);
			this.WriteLEShort(51);
			this.WriteLEShort(45);
			this.WriteLEInt(0);
			this.WriteLEInt(0);
			this.WriteLELong(noOfEntries);
			this.WriteLELong(noOfEntries);
			this.WriteLELong(sizeEntries);
			this.WriteLELong(centralDirOffset);
			this.WriteLEInt(117853008);
			this.WriteLEInt(0);
			this.WriteLELong(value);
			this.WriteLEInt(1);
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x000086F8 File Offset: 0x000068F8
		public void WriteEndOfCentralDirectory(long noOfEntries, long sizeEntries, long startOfCentralDirectory, byte[] comment)
		{
			if (noOfEntries >= 65535L || startOfCentralDirectory >= (long)((ulong)-1) || sizeEntries >= (long)((ulong)-1))
			{
				this.WriteZip64EndOfCentralDirectory(noOfEntries, sizeEntries, startOfCentralDirectory);
			}
			this.WriteLEInt(101010256);
			this.WriteLEShort(0);
			this.WriteLEShort(0);
			if (noOfEntries >= 65535L)
			{
				this.WriteLEUshort(ushort.MaxValue);
				this.WriteLEUshort(ushort.MaxValue);
			}
			else
			{
				this.WriteLEShort((int)((short)noOfEntries));
				this.WriteLEShort((int)((short)noOfEntries));
			}
			if (sizeEntries >= (long)((ulong)-1))
			{
				this.WriteLEUint(uint.MaxValue);
			}
			else
			{
				this.WriteLEInt((int)sizeEntries);
			}
			if (startOfCentralDirectory >= (long)((ulong)-1))
			{
				this.WriteLEUint(uint.MaxValue);
			}
			else
			{
				this.WriteLEInt((int)startOfCentralDirectory);
			}
			int num = (comment != null) ? comment.Length : 0;
			if (num > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Comment length({0}) is too long can only be 64K", num));
			}
			this.WriteLEShort(num);
			if (num > 0)
			{
				this.Write(comment, 0, comment.Length);
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000087DC File Offset: 0x000069DC
		public int ReadLEShort()
		{
			int num = this.stream_.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			int num2 = this.stream_.ReadByte();
			if (num2 < 0)
			{
				throw new global::System.IO.EndOfStreamException();
			}
			return num | num2 << 8;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x00008818 File Offset: 0x00006A18
		public int ReadLEInt()
		{
			return this.ReadLEShort() | this.ReadLEShort() << 16;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x0000882A File Offset: 0x00006A2A
		public long ReadLELong()
		{
			return (long)((ulong)this.ReadLEInt() | (ulong)((ulong)((long)this.ReadLEInt()) << 32));
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x0000883E File Offset: 0x00006A3E
		public void WriteLEShort(int value)
		{
			this.stream_.WriteByte((byte)(value & 255));
			this.stream_.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x060001C7 RID: 455 RVA: 0x00008868 File Offset: 0x00006A68
		public void WriteLEUshort(ushort value)
		{
			this.stream_.WriteByte((byte)(value & 255));
			this.stream_.WriteByte((byte)(value >> 8));
		}

		// Token: 0x060001C8 RID: 456 RVA: 0x0000888C File Offset: 0x00006A8C
		public void WriteLEInt(int value)
		{
			this.WriteLEShort(value);
			this.WriteLEShort(value >> 16);
		}

		// Token: 0x060001C9 RID: 457 RVA: 0x0000889F File Offset: 0x00006A9F
		public void WriteLEUint(uint value)
		{
			this.WriteLEUshort((ushort)(value & 65535U));
			this.WriteLEUshort((ushort)(value >> 16));
		}

		// Token: 0x060001CA RID: 458 RVA: 0x000088BA File Offset: 0x00006ABA
		public void WriteLELong(long value)
		{
			this.WriteLEInt((int)value);
			this.WriteLEInt((int)(value >> 32));
		}

		// Token: 0x060001CB RID: 459 RVA: 0x000088CF File Offset: 0x00006ACF
		public void WriteLEUlong(ulong value)
		{
			this.WriteLEUint((uint)(value & (ulong)-1));
			this.WriteLEUint((uint)(value >> 32));
		}

		// Token: 0x060001CC RID: 460 RVA: 0x000088E8 File Offset: 0x00006AE8
		public int WriteDataDescriptor(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			int num = 0;
			if ((entry.Flags & 8) != 0)
			{
				this.WriteLEInt(134695760);
				this.WriteLEInt((int)entry.Crc);
				num += 8;
				if (entry.LocalHeaderRequiresZip64)
				{
					this.WriteLELong(entry.CompressedSize);
					this.WriteLELong(entry.Size);
					num += 16;
				}
				else
				{
					this.WriteLEInt((int)entry.CompressedSize);
					this.WriteLEInt((int)entry.Size);
					num += 8;
				}
			}
			return num;
		}

		// Token: 0x060001CD RID: 461 RVA: 0x00008974 File Offset: 0x00006B74
		public void ReadDataDescriptor(bool zip64, global::ICSharpCode.SharpZipLib.Zip.DescriptorData data)
		{
			if (this.ReadLEInt() != 134695760)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Data descriptor signature not found");
			}
			data.Crc = (long)this.ReadLEInt();
			if (zip64)
			{
				data.CompressedSize = this.ReadLELong();
				data.Size = this.ReadLELong();
				return;
			}
			data.CompressedSize = (long)this.ReadLEInt();
			data.Size = (long)this.ReadLEInt();
		}

		// Token: 0x040000EF RID: 239
		private bool isOwner_;

		// Token: 0x040000F0 RID: 240
		private global::System.IO.Stream stream_;
	}
}
