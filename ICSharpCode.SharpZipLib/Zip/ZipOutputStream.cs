using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000031 RID: 49
	public class ZipOutputStream : global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream
	{
		// Token: 0x060001EF RID: 495 RVA: 0x00009888 File Offset: 0x00007A88
		public ZipOutputStream(global::System.IO.Stream baseOutputStream) : base(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(-1, true))
		{
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x000098F4 File Offset: 0x00007AF4
		public ZipOutputStream(global::System.IO.Stream baseOutputStream, int bufferSize) : base(baseOutputStream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(-1, true), bufferSize)
		{
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001F1 RID: 497 RVA: 0x00009961 File Offset: 0x00007B61
		public bool IsFinished
		{
			get
			{
				return this.entries == null;
			}
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000996C File Offset: 0x00007B6C
		public void SetComment(string comment)
		{
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(comment);
			if (array.Length > 65535)
			{
				throw new global::System.ArgumentOutOfRangeException("comment");
			}
			this.zipComment = array;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x0000999C File Offset: 0x00007B9C
		public void SetLevel(int level)
		{
			this.deflater_.SetLevel(level);
			this.defaultCompressionLevel = level;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x000099B1 File Offset: 0x00007BB1
		public int GetLevel()
		{
			return this.deflater_.GetLevel();
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001F5 RID: 501 RVA: 0x000099BE File Offset: 0x00007BBE
		// (set) Token: 0x060001F6 RID: 502 RVA: 0x000099C6 File Offset: 0x00007BC6
		public global::ICSharpCode.SharpZipLib.Zip.UseZip64 UseZip64
		{
			get
			{
				return this.useZip64_;
			}
			set
			{
				this.useZip64_ = value;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001F7 RID: 503 RVA: 0x000099CF File Offset: 0x00007BCF
		// (set) Token: 0x060001F8 RID: 504 RVA: 0x000099D7 File Offset: 0x00007BD7
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform { get; set; } = new global::ICSharpCode.SharpZipLib.Zip.PathTransformer();

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001F9 RID: 505 RVA: 0x000099E0 File Offset: 0x00007BE0
		// (set) Token: 0x060001FA RID: 506 RVA: 0x000099E8 File Offset: 0x00007BE8
		public string Password
		{
			get
			{
				return this.password;
			}
			set
			{
				if (value != null && value.Length == 0)
				{
					this.password = null;
					return;
				}
				this.password = value;
			}
		}

		// Token: 0x060001FB RID: 507 RVA: 0x00009A04 File Offset: 0x00007C04
		private void WriteLeShort(int value)
		{
			this.baseOutputStream_.WriteByte((byte)(value & 255));
			this.baseOutputStream_.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x060001FC RID: 508 RVA: 0x00009A2E File Offset: 0x00007C2E
		private void WriteLeInt(int value)
		{
			this.WriteLeShort(value);
			this.WriteLeShort(value >> 16);
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00009A41 File Offset: 0x00007C41
		private void WriteLeLong(long value)
		{
			this.WriteLeInt((int)value);
			this.WriteLeInt((int)(value >> 32));
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00009A58 File Offset: 0x00007C58
		private void TransformEntryName(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (this.NameTransform != null)
			{
				if (entry.IsDirectory)
				{
					entry.Name = this.NameTransform.TransformDirectory(entry.Name);
					return;
				}
				entry.Name = this.NameTransform.TransformFile(entry.Name);
			}
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00009AA4 File Offset: 0x00007CA4
		public void PutNextEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (this.entries == null)
			{
				throw new global::System.InvalidOperationException("ZipOutputStream was finished");
			}
			if (this.curEntry != null)
			{
				this.CloseEntry();
			}
			if (this.entries.Count == 2147483647)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Too many entries for Zip file");
			}
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = entry.CompressionMethod;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated && compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				throw new global::System.NotImplementedException("Compression method not supported");
			}
			if (entry.AESKeySize > 0 && string.IsNullOrEmpty(this.Password))
			{
				throw new global::System.InvalidOperationException("The Password property must be set before AES encrypted entries can be added");
			}
			int level = this.defaultCompressionLevel;
			entry.Flags &= 2048;
			this.patchEntryHeader = false;
			bool flag;
			if (entry.Size == 0L)
			{
				entry.CompressedSize = entry.Size;
				entry.Crc = 0L;
				compressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
				flag = true;
			}
			else
			{
				flag = (entry.Size >= 0L && entry.HasCrc && entry.CompressedSize >= 0L);
				if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					if (!flag)
					{
						if (!base.CanPatchEntries)
						{
							compressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
							level = 0;
						}
					}
					else
					{
						entry.CompressedSize = entry.Size;
						flag = entry.HasCrc;
					}
				}
			}
			if (!flag)
			{
				if (!base.CanPatchEntries)
				{
					entry.Flags |= 8;
				}
				else
				{
					this.patchEntryHeader = true;
				}
			}
			if (this.Password != null)
			{
				entry.IsCrypted = true;
				if (entry.Crc < 0L)
				{
					entry.Flags |= 8;
				}
			}
			entry.Offset = this.offset;
			entry.CompressionMethod = compressionMethod;
			this.curMethod = compressionMethod;
			this.sizePatchPos = -1L;
			if (this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.On || (entry.Size < 0L && this.useZip64_ == global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic))
			{
				entry.ForceZip64();
			}
			this.WriteLeInt(67324752);
			this.WriteLeShort(entry.Version);
			this.WriteLeShort(entry.Flags);
			this.WriteLeShort((int)((byte)entry.CompressionMethodForHeader));
			this.WriteLeInt((int)entry.DosTime);
			if (flag)
			{
				this.WriteLeInt((int)entry.Crc);
				if (entry.LocalHeaderRequiresZip64)
				{
					this.WriteLeInt(-1);
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)entry.CompressedSize + entry.EncryptionOverheadSize);
					this.WriteLeInt((int)entry.Size);
				}
			}
			else
			{
				if (this.patchEntryHeader)
				{
					this.crcPatchPos = this.baseOutputStream_.Position;
				}
				this.WriteLeInt(0);
				if (this.patchEntryHeader)
				{
					this.sizePatchPos = this.baseOutputStream_.Position;
				}
				if (entry.LocalHeaderRequiresZip64 || this.patchEntryHeader)
				{
					this.WriteLeInt(-1);
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt(0);
					this.WriteLeInt(0);
				}
			}
			this.TransformEntryName(entry);
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name too long.");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(entry.ExtraData);
			if (entry.LocalHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				if (flag)
				{
					zipExtraData.AddLeLong(entry.Size);
					zipExtraData.AddLeLong(entry.CompressedSize + (long)entry.EncryptionOverheadSize);
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
				if (this.patchEntryHeader)
				{
					this.sizePatchPos = (long)zipExtraData.CurrentReadIndex;
				}
			}
			else
			{
				zipExtraData.Delete(1);
			}
			if (entry.AESKeySize > 0)
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream.AddExtraDataAES(entry, zipExtraData);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			this.WriteLeShort(array.Length);
			this.WriteLeShort(entryData.Length);
			if (array.Length != 0)
			{
				this.baseOutputStream_.Write(array, 0, array.Length);
			}
			if (entry.LocalHeaderRequiresZip64 && this.patchEntryHeader)
			{
				this.sizePatchPos += this.baseOutputStream_.Position;
			}
			if (entryData.Length != 0)
			{
				this.baseOutputStream_.Write(entryData, 0, entryData.Length);
			}
			this.offset += (long)(30 + array.Length + entryData.Length);
			if (entry.AESKeySize > 0)
			{
				this.offset += (long)entry.AESOverheadSize;
			}
			this.curEntry = entry;
			this.crc.Reset();
			if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				this.deflater_.Reset();
				this.deflater_.SetLevel(level);
			}
			this.size = 0L;
			if (entry.IsCrypted)
			{
				if (entry.AESKeySize > 0)
				{
					this.WriteAESHeader(entry);
					return;
				}
				if (entry.Crc < 0L)
				{
					this.WriteEncryptionHeader(entry.DosTime << 16);
					return;
				}
				this.WriteEncryptionHeader(entry.Crc);
			}
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00009F30 File Offset: 0x00008130
		public void CloseEntry()
		{
			if (this.curEntry == null)
			{
				throw new global::System.InvalidOperationException("No open entry");
			}
			long totalOut = this.size;
			if (this.curMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
				if (this.size >= 0L)
				{
					base.Finish();
					totalOut = this.deflater_.TotalOut;
				}
				else
				{
					this.deflater_.Reset();
				}
			}
			else if (this.curMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				base.GetAuthCodeIfAES();
			}
			if (this.curEntry.AESKeySize > 0)
			{
				this.baseOutputStream_.Write(this.AESAuthCode, 0, 10);
				this.curEntry.Crc = 0L;
			}
			else if (this.curEntry.Crc < 0L)
			{
				this.curEntry.Crc = this.crc.Value;
			}
			else if (this.curEntry.Crc != this.crc.Value)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("crc was {0}, but {1} was expected", this.crc.Value, this.curEntry.Crc));
			}
			if (this.curEntry.Size < 0L)
			{
				this.curEntry.Size = this.size;
			}
			else if (this.curEntry.Size != this.size)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("size was {0}, but {1} was expected", this.size, this.curEntry.Size));
			}
			if (this.curEntry.CompressedSize < 0L)
			{
				this.curEntry.CompressedSize = totalOut;
			}
			else if (this.curEntry.CompressedSize != totalOut)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("compressed size was {0}, but {1} expected", totalOut, this.curEntry.CompressedSize));
			}
			this.offset += totalOut;
			if (this.curEntry.IsCrypted)
			{
				this.curEntry.CompressedSize += (long)this.curEntry.EncryptionOverheadSize;
			}
			if (this.patchEntryHeader)
			{
				this.patchEntryHeader = false;
				long position = this.baseOutputStream_.Position;
				this.baseOutputStream_.Seek(this.crcPatchPos, global::System.IO.SeekOrigin.Begin);
				this.WriteLeInt((int)this.curEntry.Crc);
				if (this.curEntry.LocalHeaderRequiresZip64)
				{
					if (this.sizePatchPos == -1L)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry requires zip64 but this has been turned off");
					}
					this.baseOutputStream_.Seek(this.sizePatchPos, global::System.IO.SeekOrigin.Begin);
					this.WriteLeLong(this.curEntry.Size);
					this.WriteLeLong(this.curEntry.CompressedSize);
				}
				else
				{
					this.WriteLeInt((int)this.curEntry.CompressedSize);
					this.WriteLeInt((int)this.curEntry.Size);
				}
				this.baseOutputStream_.Seek(position, global::System.IO.SeekOrigin.Begin);
			}
			if ((this.curEntry.Flags & 8) != 0)
			{
				this.WriteLeInt(134695760);
				this.WriteLeInt((int)this.curEntry.Crc);
				if (this.curEntry.LocalHeaderRequiresZip64)
				{
					this.WriteLeLong(this.curEntry.CompressedSize);
					this.WriteLeLong(this.curEntry.Size);
					this.offset += 24L;
				}
				else
				{
					this.WriteLeInt((int)this.curEntry.CompressedSize);
					this.WriteLeInt((int)this.curEntry.Size);
					this.offset += 16L;
				}
			}
			this.entries.Add(this.curEntry);
			this.curEntry = null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000A2B0 File Offset: 0x000084B0
		private void InitializePassword(string password)
		{
			global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
			byte[] rgbKey = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(password));
			this.cryptoTransform_ = pkzipClassicManaged.CreateEncryptor(rgbKey, null);
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000A2E0 File Offset: 0x000084E0
		private void InitializeAESPassword(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string rawPassword, out byte[] salt, out byte[] pwdVerifier)
		{
			salt = new byte[entry.AESSaltLen];
			global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream._aesRnd.GetBytes(salt);
			int blockSize = entry.AESKeySize / 8;
			this.cryptoTransform_ = new global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform(rawPassword, salt, blockSize, true);
			pwdVerifier = ((global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform)this.cryptoTransform_).PwdVerifier;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x0000A334 File Offset: 0x00008534
		private void WriteEncryptionHeader(long crcValue)
		{
			this.offset += 12L;
			this.InitializePassword(this.Password);
			byte[] array = new byte[12];
			using (global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			array[11] = (byte)(crcValue >> 24);
			base.EncryptBlock(array, 0, array.Length);
			this.baseOutputStream_.Write(array, 0, array.Length);
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0000A3B4 File Offset: 0x000085B4
		private static void AddExtraDataAES(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.ZipExtraData extraData)
		{
			extraData.StartNewEntry();
			extraData.AddLeShort(2);
			extraData.AddLeShort(17729);
			extraData.AddData(entry.AESEncryptionStrength);
			extraData.AddLeShort((int)entry.CompressionMethod);
			extraData.AddNewEntry(39169);
		}

		// Token: 0x06000205 RID: 517 RVA: 0x0000A3F4 File Offset: 0x000085F4
		private void WriteAESHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			byte[] array;
			byte[] array2;
			this.InitializeAESPassword(entry, this.Password, out array, out array2);
			this.baseOutputStream_.Write(array, 0, array.Length);
			this.baseOutputStream_.Write(array2, 0, array2.Length);
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000A434 File Offset: 0x00008634
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.curEntry == null)
			{
				throw new global::System.InvalidOperationException("No open entry.");
			}
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
			if (this.curEntry.AESKeySize == 0)
			{
				this.crc.Update(new global::System.ArraySegment<byte>(buffer, offset, count));
			}
			this.size += (long)count;
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = this.curMethod;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				if (compressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					base.Write(buffer, offset, count);
					return;
				}
			}
			else
			{
				if (this.Password != null)
				{
					this.CopyAndEncrypt(buffer, offset, count);
					return;
				}
				this.baseOutputStream_.Write(buffer, offset, count);
			}
		}

		// Token: 0x06000207 RID: 519 RVA: 0x0000A504 File Offset: 0x00008704
		private void CopyAndEncrypt(byte[] buffer, int offset, int count)
		{
			byte[] array = new byte[4096];
			while (count > 0)
			{
				int num = (count < 4096) ? count : 4096;
				global::System.Array.Copy(buffer, offset, array, 0, num);
				base.EncryptBlock(array, 0, num);
				this.baseOutputStream_.Write(array, 0, num);
				count -= num;
				offset += num;
			}
		}

		// Token: 0x06000208 RID: 520 RVA: 0x0000A560 File Offset: 0x00008760
		public override void Finish()
		{
			if (this.entries == null)
			{
				return;
			}
			if (this.curEntry != null)
			{
				this.CloseEntry();
			}
			long noOfEntries = (long)this.entries.Count;
			long num = 0L;
			foreach (global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry in this.entries)
			{
				this.WriteLeInt(33639248);
				this.WriteLeShort(zipEntry.HostSystem << 8 | zipEntry.VersionMadeBy);
				this.WriteLeShort(zipEntry.Version);
				this.WriteLeShort(zipEntry.Flags);
				this.WriteLeShort((int)((short)zipEntry.CompressionMethodForHeader));
				this.WriteLeInt((int)zipEntry.DosTime);
				this.WriteLeInt((int)zipEntry.Crc);
				if (zipEntry.IsZip64Forced() || zipEntry.CompressedSize >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.CompressedSize);
				}
				if (zipEntry.IsZip64Forced() || zipEntry.Size >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.Size);
				}
				byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(zipEntry.Flags, zipEntry.Name);
				if (array.Length > 65535)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Name too long.");
				}
				global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(zipEntry.ExtraData);
				if (zipEntry.CentralHeaderRequiresZip64)
				{
					zipExtraData.StartNewEntry();
					if (zipEntry.IsZip64Forced() || zipEntry.Size >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.Size);
					}
					if (zipEntry.IsZip64Forced() || zipEntry.CompressedSize >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.CompressedSize);
					}
					if (zipEntry.Offset >= (long)((ulong)-1))
					{
						zipExtraData.AddLeLong(zipEntry.Offset);
					}
					zipExtraData.AddNewEntry(1);
				}
				else
				{
					zipExtraData.Delete(1);
				}
				if (zipEntry.AESKeySize > 0)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream.AddExtraDataAES(zipEntry, zipExtraData);
				}
				byte[] entryData = zipExtraData.GetEntryData();
				byte[] array2 = (zipEntry.Comment != null) ? global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(zipEntry.Flags, zipEntry.Comment) : global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
				if (array2.Length > 65535)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Comment too long.");
				}
				this.WriteLeShort(array.Length);
				this.WriteLeShort(entryData.Length);
				this.WriteLeShort(array2.Length);
				this.WriteLeShort(0);
				this.WriteLeShort(0);
				if (zipEntry.ExternalFileAttributes != -1)
				{
					this.WriteLeInt(zipEntry.ExternalFileAttributes);
				}
				else if (zipEntry.IsDirectory)
				{
					this.WriteLeInt(16);
				}
				else
				{
					this.WriteLeInt(0);
				}
				if (zipEntry.Offset >= (long)((ulong)-1))
				{
					this.WriteLeInt(-1);
				}
				else
				{
					this.WriteLeInt((int)zipEntry.Offset);
				}
				if (array.Length != 0)
				{
					this.baseOutputStream_.Write(array, 0, array.Length);
				}
				if (entryData.Length != 0)
				{
					this.baseOutputStream_.Write(entryData, 0, entryData.Length);
				}
				if (array2.Length != 0)
				{
					this.baseOutputStream_.Write(array2, 0, array2.Length);
				}
				num += (long)(46 + array.Length + entryData.Length + array2.Length);
			}
			using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseOutputStream_))
			{
				zipHelperStream.WriteEndOfCentralDirectory(noOfEntries, num, this.offset, this.zipComment);
			}
			this.entries = null;
		}

		// Token: 0x06000209 RID: 521 RVA: 0x0000A8B8 File Offset: 0x00008AB8
		public override void Flush()
		{
			if (this.curMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				this.baseOutputStream_.Flush();
				return;
			}
			base.Flush();
		}

		// Token: 0x040000FC RID: 252
		private global::System.Collections.Generic.List<global::ICSharpCode.SharpZipLib.Zip.ZipEntry> entries = new global::System.Collections.Generic.List<global::ICSharpCode.SharpZipLib.Zip.ZipEntry>();

		// Token: 0x040000FD RID: 253
		private global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();

		// Token: 0x040000FE RID: 254
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry curEntry;

		// Token: 0x040000FF RID: 255
		private int defaultCompressionLevel = -1;

		// Token: 0x04000100 RID: 256
		private global::ICSharpCode.SharpZipLib.Zip.CompressionMethod curMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;

		// Token: 0x04000101 RID: 257
		private long size;

		// Token: 0x04000102 RID: 258
		private long offset;

		// Token: 0x04000103 RID: 259
		private byte[] zipComment = global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();

		// Token: 0x04000104 RID: 260
		private bool patchEntryHeader;

		// Token: 0x04000105 RID: 261
		private long crcPatchPos = -1L;

		// Token: 0x04000106 RID: 262
		private long sizePatchPos = -1L;

		// Token: 0x04000107 RID: 263
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;

		// Token: 0x04000108 RID: 264
		private string password;

		// Token: 0x04000109 RID: 265
		private static global::System.Security.Cryptography.RandomNumberGenerator _aesRnd = global::System.Security.Cryptography.RandomNumberGenerator.Create();
	}
}
