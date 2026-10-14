using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Ionic.BZip2;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000466 RID: 1126
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	internal class ZipEntry
	{
		// Token: 0x17000DDF RID: 3551
		// (get) Token: 0x0600306A RID: 12394 RVA: 0x000AB9B4 File Offset: 0x000A9BB4
		internal bool AttributesIndicateDirectory
		{
			get
			{
				return this._InternalFileAttrs == 0 && (this._ExternalFileAttrs & 16) == 16;
			}
		}

		// Token: 0x0600306B RID: 12395 RVA: 0x000AB9D0 File Offset: 0x000A9BD0
		internal void ResetDirEntry()
		{
			this.__FileDataPosition = -1L;
			this._LengthOfHeader = 0;
		}

		// Token: 0x17000DE0 RID: 3552
		// (get) Token: 0x0600306C RID: 12396 RVA: 0x000AB9E4 File Offset: 0x000A9BE4
		public string Info
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(string.Format("          ZipEntry: {0}\n", this.FileName)).Append(string.Format("   Version Made By: {0}\n", this._VersionMadeBy)).Append(string.Format(" Needed to extract: {0}\n", this.VersionNeeded));
				if (this._IsDirectory)
				{
					stringBuilder.Append("        Entry type: directory\n");
				}
				else
				{
					stringBuilder.Append(string.Format("         File type: {0}\n", this._IsText ? "text" : "binary")).Append(string.Format("       Compression: {0}\n", this.CompressionMethod)).Append(string.Format("        Compressed: 0x{0:X}\n", this.CompressedSize)).Append(string.Format("      Uncompressed: 0x{0:X}\n", this.UncompressedSize)).Append(string.Format("             CRC32: 0x{0:X8}\n", this._Crc32));
				}
				stringBuilder.Append(string.Format("       Disk Number: {0}\n", this._diskNumber));
				if (this._RelativeOffsetOfLocalHeader > (long)((ulong)-1))
				{
					stringBuilder.Append(string.Format("   Relative Offset: 0x{0:X16}\n", this._RelativeOffsetOfLocalHeader));
				}
				else
				{
					stringBuilder.Append(string.Format("   Relative Offset: 0x{0:X8}\n", this._RelativeOffsetOfLocalHeader));
				}
				stringBuilder.Append(string.Format("         Bit Field: 0x{0:X4}\n", this._BitField)).Append(string.Format("        Encrypted?: {0}\n", this._sourceIsEncrypted)).Append(string.Format("          Timeblob: 0x{0:X8}\n", this._TimeBlob)).Append(string.Format("              Time: {0}\n", global::Ionic.Zip.SharedUtilities.PackedToDateTime(this._TimeBlob)));
				stringBuilder.Append(string.Format("         Is Zip64?: {0}\n", this._InputUsesZip64));
				if (!string.IsNullOrEmpty(this._Comment))
				{
					stringBuilder.Append(string.Format("           Comment: {0}\n", this._Comment));
				}
				stringBuilder.Append("\n");
				return stringBuilder.ToString();
			}
		}

		// Token: 0x0600306D RID: 12397 RVA: 0x000ABC20 File Offset: 0x000A9E20
		internal static global::Ionic.Zip.ZipEntry ReadDirEntry(global::Ionic.Zip.ZipFile zf, global::System.Collections.Generic.Dictionary<string, object> previouslySeen)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			global::System.Text.Encoding encoding = (zf.AlternateEncodingUsage == global::Ionic.Zip.ZipOption.Always) ? zf.AlternateEncoding : global::Ionic.Zip.ZipFile.DefaultEncoding;
			int num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
			if (global::Ionic.Zip.ZipEntry.IsNotValidZipDirEntrySig(num))
			{
				readStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
				if ((long)num != 101010256L && (long)num != 101075792L && num != 67324752)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Bad signature (0x{0:X8}) at position 0x{1:X8}", num, readStream.Position));
				}
				return null;
			}
			else
			{
				int num2 = 46;
				byte[] array = new byte[42];
				int num3 = readStream.Read(array, 0, array.Length);
				if (num3 != array.Length)
				{
					return null;
				}
				int num4 = 0;
				global::Ionic.Zip.ZipEntry zipEntry = new global::Ionic.Zip.ZipEntry();
				zipEntry.AlternateEncoding = encoding;
				zipEntry._Source = global::Ionic.Zip.ZipEntrySource.ZipFile;
				zipEntry._container = new global::Ionic.Zip.ZipContainer(zf);
				zipEntry._VersionMadeBy = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._VersionNeeded = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._BitField = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._CompressionMethod = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._TimeBlob = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				zipEntry._LastModified = global::Ionic.Zip.SharedUtilities.PackedToDateTime(zipEntry._TimeBlob);
				zipEntry._timestamp |= global::Ionic.Zip.ZipEntryTimestamp.DOS;
				zipEntry._Crc32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				zipEntry._CompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				zipEntry._UncompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				zipEntry._CompressionMethod_FromZipFile = zipEntry._CompressionMethod;
				zipEntry._filenameLength = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._extraFieldLength = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._commentLength = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._diskNumber = (uint)array[num4++] + (uint)array[num4++] * 256U;
				zipEntry._InternalFileAttrs = (short)((int)array[num4++] + (int)array[num4++] * 256);
				zipEntry._ExternalFileAttrs = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				zipEntry._RelativeOffsetOfLocalHeader = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				zipEntry.IsText = ((zipEntry._InternalFileAttrs & 1) == 1);
				array = new byte[(int)zipEntry._filenameLength];
				num3 = readStream.Read(array, 0, array.Length);
				num2 += num3;
				if ((zipEntry._BitField & 2048) == 2048)
				{
					zipEntry._FileNameInArchive = global::Ionic.Zip.SharedUtilities.Utf8StringFromBuffer(array);
				}
				else
				{
					zipEntry._FileNameInArchive = global::Ionic.Zip.SharedUtilities.StringFromBuffer(array, encoding);
				}
				while (previouslySeen.ContainsKey(zipEntry._FileNameInArchive))
				{
					zipEntry._FileNameInArchive = global::Ionic.Zip.ZipEntry.CopyHelper.AppendCopyToFileName(zipEntry._FileNameInArchive);
					zipEntry._metadataChanged = true;
				}
				if (zipEntry.AttributesIndicateDirectory)
				{
					zipEntry.MarkAsDirectory();
				}
				else if (zipEntry._FileNameInArchive.EndsWith("/"))
				{
					zipEntry.MarkAsDirectory();
				}
				zipEntry._CompressedFileDataSize = zipEntry._CompressedSize;
				if ((zipEntry._BitField & 1) == 1)
				{
					zipEntry._Encryption_FromZipFile = (zipEntry._Encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak);
					zipEntry._sourceIsEncrypted = true;
				}
				if (zipEntry._extraFieldLength > 0)
				{
					zipEntry._InputUsesZip64 = (zipEntry._CompressedSize == (long)((ulong)-1) || zipEntry._UncompressedSize == (long)((ulong)-1) || zipEntry._RelativeOffsetOfLocalHeader == (long)((ulong)-1));
					num2 += zipEntry.ProcessExtraField(readStream, zipEntry._extraFieldLength);
					zipEntry._CompressedFileDataSize = zipEntry._CompressedSize;
				}
				if (zipEntry._Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
				{
					zipEntry._CompressedFileDataSize -= 12L;
				}
				else if (zipEntry.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || zipEntry.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
				{
					zipEntry._CompressedFileDataSize = zipEntry.CompressedSize - (long)(global::Ionic.Zip.ZipEntry.GetLengthOfCryptoHeaderBytes(zipEntry.Encryption) + 10);
					zipEntry._LengthOfTrailer = 10;
				}
				if ((zipEntry._BitField & 8) == 8)
				{
					if (zipEntry._InputUsesZip64)
					{
						zipEntry._LengthOfTrailer += 24;
					}
					else
					{
						zipEntry._LengthOfTrailer += 16;
					}
				}
				zipEntry.AlternateEncoding = (((zipEntry._BitField & 2048) == 2048) ? global::System.Text.Encoding.UTF8 : encoding);
				zipEntry.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				if (zipEntry._commentLength > 0)
				{
					array = new byte[(int)zipEntry._commentLength];
					num3 = readStream.Read(array, 0, array.Length);
					num2 += num3;
					if ((zipEntry._BitField & 2048) == 2048)
					{
						zipEntry._Comment = global::Ionic.Zip.SharedUtilities.Utf8StringFromBuffer(array);
					}
					else
					{
						zipEntry._Comment = global::Ionic.Zip.SharedUtilities.StringFromBuffer(array, encoding);
					}
				}
				return zipEntry;
			}
		}

		// Token: 0x0600306E RID: 12398 RVA: 0x000AC328 File Offset: 0x000AA528
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			return signature != 33639248;
		}

		// Token: 0x0600306F RID: 12399 RVA: 0x000AC338 File Offset: 0x000AA538
		public ZipEntry()
		{
			this._CompressionMethod = 8;
			this._CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
			this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
			this._Source = global::Ionic.Zip.ZipEntrySource.None;
			this.AlternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
		}

		// Token: 0x17000DE1 RID: 3553
		// (get) Token: 0x06003070 RID: 12400 RVA: 0x000AC3A4 File Offset: 0x000AA5A4
		// (set) Token: 0x06003071 RID: 12401 RVA: 0x000AC3B4 File Offset: 0x000AA5B4
		public global::System.DateTime LastModified
		{
			get
			{
				return this._LastModified.ToLocalTime();
			}
			set
			{
				this._LastModified = ((value.Kind == global::System.DateTimeKind.Unspecified) ? global::System.DateTime.SpecifyKind(value, global::System.DateTimeKind.Local) : value.ToLocalTime());
				this._Mtime = global::Ionic.Zip.SharedUtilities.AdjustTime_Reverse(this._LastModified).ToUniversalTime();
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DE2 RID: 3554
		// (get) Token: 0x06003072 RID: 12402 RVA: 0x000AC40C File Offset: 0x000AA60C
		private int BufferSize
		{
			get
			{
				return this._container.BufferSize;
			}
		}

		// Token: 0x17000DE3 RID: 3555
		// (get) Token: 0x06003073 RID: 12403 RVA: 0x000AC41C File Offset: 0x000AA61C
		// (set) Token: 0x06003074 RID: 12404 RVA: 0x000AC424 File Offset: 0x000AA624
		public global::System.DateTime ModifiedTime
		{
			get
			{
				return this._Mtime;
			}
			set
			{
				this.SetEntryTimes(this._Ctime, this._Atime, value);
			}
		}

		// Token: 0x17000DE4 RID: 3556
		// (get) Token: 0x06003075 RID: 12405 RVA: 0x000AC43C File Offset: 0x000AA63C
		// (set) Token: 0x06003076 RID: 12406 RVA: 0x000AC444 File Offset: 0x000AA644
		public global::System.DateTime AccessedTime
		{
			get
			{
				return this._Atime;
			}
			set
			{
				this.SetEntryTimes(this._Ctime, value, this._Mtime);
			}
		}

		// Token: 0x17000DE5 RID: 3557
		// (get) Token: 0x06003077 RID: 12407 RVA: 0x000AC45C File Offset: 0x000AA65C
		// (set) Token: 0x06003078 RID: 12408 RVA: 0x000AC464 File Offset: 0x000AA664
		public global::System.DateTime CreationTime
		{
			get
			{
				return this._Ctime;
			}
			set
			{
				this.SetEntryTimes(value, this._Atime, this._Mtime);
			}
		}

		// Token: 0x06003079 RID: 12409 RVA: 0x000AC47C File Offset: 0x000AA67C
		public void SetEntryTimes(global::System.DateTime created, global::System.DateTime accessed, global::System.DateTime modified)
		{
			this._ntfsTimesAreSet = true;
			if (created == global::Ionic.Zip.ZipEntry._zeroHour && created.Kind == global::Ionic.Zip.ZipEntry._zeroHour.Kind)
			{
				created = global::Ionic.Zip.ZipEntry._win32Epoch;
			}
			if (accessed == global::Ionic.Zip.ZipEntry._zeroHour && accessed.Kind == global::Ionic.Zip.ZipEntry._zeroHour.Kind)
			{
				accessed = global::Ionic.Zip.ZipEntry._win32Epoch;
			}
			if (modified == global::Ionic.Zip.ZipEntry._zeroHour && modified.Kind == global::Ionic.Zip.ZipEntry._zeroHour.Kind)
			{
				modified = global::Ionic.Zip.ZipEntry._win32Epoch;
			}
			this._Ctime = created.ToUniversalTime();
			this._Atime = accessed.ToUniversalTime();
			this._Mtime = modified.ToUniversalTime();
			this._LastModified = this._Mtime;
			if (!this._emitUnixTimes && !this._emitNtfsTimes)
			{
				this._emitNtfsTimes = true;
			}
			this._metadataChanged = true;
		}

		// Token: 0x17000DE6 RID: 3558
		// (get) Token: 0x0600307A RID: 12410 RVA: 0x000AC574 File Offset: 0x000AA774
		// (set) Token: 0x0600307B RID: 12411 RVA: 0x000AC57C File Offset: 0x000AA77C
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			get
			{
				return this._emitNtfsTimes;
			}
			set
			{
				this._emitNtfsTimes = value;
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DE7 RID: 3559
		// (get) Token: 0x0600307C RID: 12412 RVA: 0x000AC58C File Offset: 0x000AA78C
		// (set) Token: 0x0600307D RID: 12413 RVA: 0x000AC594 File Offset: 0x000AA794
		public bool EmitTimesInUnixFormatWhenSaving
		{
			get
			{
				return this._emitUnixTimes;
			}
			set
			{
				this._emitUnixTimes = value;
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DE8 RID: 3560
		// (get) Token: 0x0600307E RID: 12414 RVA: 0x000AC5A4 File Offset: 0x000AA7A4
		public global::Ionic.Zip.ZipEntryTimestamp Timestamp
		{
			get
			{
				return this._timestamp;
			}
		}

		// Token: 0x17000DE9 RID: 3561
		// (get) Token: 0x0600307F RID: 12415 RVA: 0x000AC5AC File Offset: 0x000AA7AC
		// (set) Token: 0x06003080 RID: 12416 RVA: 0x000AC5B4 File Offset: 0x000AA7B4
		public global::System.IO.FileAttributes Attributes
		{
			get
			{
				return (global::System.IO.FileAttributes)this._ExternalFileAttrs;
			}
			set
			{
				this._ExternalFileAttrs = (int)value;
				this._VersionMadeBy = 45;
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DEA RID: 3562
		// (get) Token: 0x06003081 RID: 12417 RVA: 0x000AC5CC File Offset: 0x000AA7CC
		internal string LocalFileName
		{
			get
			{
				return this._LocalFileName;
			}
		}

		// Token: 0x17000DEB RID: 3563
		// (get) Token: 0x06003082 RID: 12418 RVA: 0x000AC5D4 File Offset: 0x000AA7D4
		// (set) Token: 0x06003083 RID: 12419 RVA: 0x000AC5DC File Offset: 0x000AA7DC
		public string FileName
		{
			get
			{
				return this._FileNameInArchive;
			}
			set
			{
				if (this._container.ZipFile == null)
				{
					throw new global::Ionic.Zip.ZipException("Cannot rename; this is not supported in ZipOutputStream/ZipInputStream.");
				}
				if (string.IsNullOrEmpty(value))
				{
					throw new global::Ionic.Zip.ZipException("The FileName must be non empty and non-null.");
				}
				string text = global::Ionic.Zip.ZipEntry.NameInArchive(value, null);
				if (this._FileNameInArchive == text)
				{
					return;
				}
				this._container.ZipFile.RemoveEntry(this);
				this._container.ZipFile.InternalAddEntry(text, this);
				this._FileNameInArchive = text;
				this._container.ZipFile.NotifyEntryChanged();
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DEC RID: 3564
		// (get) Token: 0x06003084 RID: 12420 RVA: 0x000AC67C File Offset: 0x000AA87C
		// (set) Token: 0x06003085 RID: 12421 RVA: 0x000AC684 File Offset: 0x000AA884
		public global::System.IO.Stream InputStream
		{
			get
			{
				return this._sourceStream;
			}
			set
			{
				if (this._Source != global::Ionic.Zip.ZipEntrySource.Stream)
				{
					throw new global::Ionic.Zip.ZipException("You must not set the input stream for this entry.");
				}
				this._sourceWasJitProvided = true;
				this._sourceStream = value;
			}
		}

		// Token: 0x17000DED RID: 3565
		// (get) Token: 0x06003086 RID: 12422 RVA: 0x000AC6AC File Offset: 0x000AA8AC
		public bool InputStreamWasJitProvided
		{
			get
			{
				return this._sourceWasJitProvided;
			}
		}

		// Token: 0x17000DEE RID: 3566
		// (get) Token: 0x06003087 RID: 12423 RVA: 0x000AC6B4 File Offset: 0x000AA8B4
		public global::Ionic.Zip.ZipEntrySource Source
		{
			get
			{
				return this._Source;
			}
		}

		// Token: 0x17000DEF RID: 3567
		// (get) Token: 0x06003088 RID: 12424 RVA: 0x000AC6BC File Offset: 0x000AA8BC
		public short VersionNeeded
		{
			get
			{
				return this._VersionNeeded;
			}
		}

		// Token: 0x17000DF0 RID: 3568
		// (get) Token: 0x06003089 RID: 12425 RVA: 0x000AC6C4 File Offset: 0x000AA8C4
		// (set) Token: 0x0600308A RID: 12426 RVA: 0x000AC6CC File Offset: 0x000AA8CC
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment = value;
				this._metadataChanged = true;
			}
		}

		// Token: 0x17000DF1 RID: 3569
		// (get) Token: 0x0600308B RID: 12427 RVA: 0x000AC6DC File Offset: 0x000AA8DC
		public bool? RequiresZip64
		{
			get
			{
				return this._entryRequiresZip64;
			}
		}

		// Token: 0x17000DF2 RID: 3570
		// (get) Token: 0x0600308C RID: 12428 RVA: 0x000AC6E4 File Offset: 0x000AA8E4
		public bool? OutputUsedZip64
		{
			get
			{
				return this._OutputUsesZip64;
			}
		}

		// Token: 0x17000DF3 RID: 3571
		// (get) Token: 0x0600308D RID: 12429 RVA: 0x000AC6EC File Offset: 0x000AA8EC
		public short BitField
		{
			get
			{
				return this._BitField;
			}
		}

		// Token: 0x17000DF4 RID: 3572
		// (get) Token: 0x0600308E RID: 12430 RVA: 0x000AC6F4 File Offset: 0x000AA8F4
		// (set) Token: 0x0600308F RID: 12431 RVA: 0x000AC6FC File Offset: 0x000AA8FC
		public global::Ionic.Zip.CompressionMethod CompressionMethod
		{
			get
			{
				return (global::Ionic.Zip.CompressionMethod)this._CompressionMethod;
			}
			set
			{
				if (value == (global::Ionic.Zip.CompressionMethod)this._CompressionMethod)
				{
					return;
				}
				if (value != global::Ionic.Zip.CompressionMethod.None && value != global::Ionic.Zip.CompressionMethod.Deflate && value != global::Ionic.Zip.CompressionMethod.BZip2)
				{
					throw new global::System.InvalidOperationException("Unsupported compression method.");
				}
				this._CompressionMethod = (short)value;
				if (this._CompressionMethod == 0)
				{
					this._CompressionLevel = global::Ionic.Zlib.CompressionLevel.None;
				}
				else if (this.CompressionLevel == global::Ionic.Zlib.CompressionLevel.None)
				{
					this._CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
				}
				if (this._container.ZipFile != null)
				{
					this._container.ZipFile.NotifyEntryChanged();
				}
				this._restreamRequiredOnSave = true;
			}
		}

		// Token: 0x17000DF5 RID: 3573
		// (get) Token: 0x06003090 RID: 12432 RVA: 0x000AC794 File Offset: 0x000AA994
		// (set) Token: 0x06003091 RID: 12433 RVA: 0x000AC79C File Offset: 0x000AA99C
		public global::Ionic.Zlib.CompressionLevel CompressionLevel
		{
			get
			{
				return this._CompressionLevel;
			}
			set
			{
				if (this._CompressionMethod != 8 && this._CompressionMethod != 0)
				{
					return;
				}
				if (value == global::Ionic.Zlib.CompressionLevel.Default && this._CompressionMethod == 8)
				{
					return;
				}
				this._CompressionLevel = value;
				if (value == global::Ionic.Zlib.CompressionLevel.None && this._CompressionMethod == 0)
				{
					return;
				}
				if (this._CompressionLevel == global::Ionic.Zlib.CompressionLevel.None)
				{
					this._CompressionMethod = 0;
				}
				else
				{
					this._CompressionMethod = 8;
				}
				if (this._container.ZipFile != null)
				{
					this._container.ZipFile.NotifyEntryChanged();
				}
				this._restreamRequiredOnSave = true;
			}
		}

		// Token: 0x17000DF6 RID: 3574
		// (get) Token: 0x06003092 RID: 12434 RVA: 0x000AC838 File Offset: 0x000AAA38
		public long CompressedSize
		{
			get
			{
				return this._CompressedSize;
			}
		}

		// Token: 0x17000DF7 RID: 3575
		// (get) Token: 0x06003093 RID: 12435 RVA: 0x000AC840 File Offset: 0x000AAA40
		public long UncompressedSize
		{
			get
			{
				return this._UncompressedSize;
			}
		}

		// Token: 0x17000DF8 RID: 3576
		// (get) Token: 0x06003094 RID: 12436 RVA: 0x000AC848 File Offset: 0x000AAA48
		public double CompressionRatio
		{
			get
			{
				if (this.UncompressedSize == 0L)
				{
					return 0.0;
				}
				return 100.0 * (1.0 - 1.0 * (double)this.CompressedSize / (1.0 * (double)this.UncompressedSize));
			}
		}

		// Token: 0x17000DF9 RID: 3577
		// (get) Token: 0x06003095 RID: 12437 RVA: 0x000AC8A8 File Offset: 0x000AAAA8
		public int Crc
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x17000DFA RID: 3578
		// (get) Token: 0x06003096 RID: 12438 RVA: 0x000AC8B0 File Offset: 0x000AAAB0
		public bool IsDirectory
		{
			get
			{
				return this._IsDirectory;
			}
		}

		// Token: 0x17000DFB RID: 3579
		// (get) Token: 0x06003097 RID: 12439 RVA: 0x000AC8B8 File Offset: 0x000AAAB8
		public bool UsesEncryption
		{
			get
			{
				return this._Encryption_FromZipFile > global::Ionic.Zip.EncryptionAlgorithm.None;
			}
		}

		// Token: 0x17000DFC RID: 3580
		// (get) Token: 0x06003098 RID: 12440 RVA: 0x000AC8C4 File Offset: 0x000AAAC4
		// (set) Token: 0x06003099 RID: 12441 RVA: 0x000AC8CC File Offset: 0x000AAACC
		public global::Ionic.Zip.EncryptionAlgorithm Encryption
		{
			get
			{
				return this._Encryption;
			}
			set
			{
				if (value == this._Encryption)
				{
					return;
				}
				if (value == global::Ionic.Zip.EncryptionAlgorithm.Unsupported)
				{
					throw new global::System.InvalidOperationException("You may not set Encryption to that value.");
				}
				this._Encryption = value;
				this._restreamRequiredOnSave = true;
				if (this._container.ZipFile != null)
				{
					this._container.ZipFile.NotifyEntryChanged();
				}
			}
		}

		// Token: 0x17000DFD RID: 3581
		// (get) Token: 0x0600309B RID: 12443 RVA: 0x000AC988 File Offset: 0x000AAB88
		// (set) Token: 0x0600309A RID: 12442 RVA: 0x000AC92C File Offset: 0x000AAB2C
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (this._Password == null)
				{
					this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
					return;
				}
				if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipFile && !this._sourceIsEncrypted)
				{
					this._restreamRequiredOnSave = true;
				}
				if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
				{
					this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak;
				}
			}
		}

		// Token: 0x17000DFE RID: 3582
		// (get) Token: 0x0600309C RID: 12444 RVA: 0x000AC990 File Offset: 0x000AAB90
		internal bool IsChanged
		{
			get
			{
				return this._restreamRequiredOnSave | this._metadataChanged;
			}
		}

		// Token: 0x17000DFF RID: 3583
		// (get) Token: 0x0600309D RID: 12445 RVA: 0x000AC9A0 File Offset: 0x000AABA0
		// (set) Token: 0x0600309E RID: 12446 RVA: 0x000AC9A8 File Offset: 0x000AABA8
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x17000E00 RID: 3584
		// (get) Token: 0x0600309F RID: 12447 RVA: 0x000AC9B4 File Offset: 0x000AABB4
		// (set) Token: 0x060030A0 RID: 12448 RVA: 0x000AC9BC File Offset: 0x000AABBC
		public global::Ionic.Zip.ZipErrorAction ZipErrorAction { get; set; }

		// Token: 0x17000E01 RID: 3585
		// (get) Token: 0x060030A1 RID: 12449 RVA: 0x000AC9C8 File Offset: 0x000AABC8
		public bool IncludedInMostRecentSave
		{
			get
			{
				return !this._skippedDuringSave;
			}
		}

		// Token: 0x17000E02 RID: 3586
		// (get) Token: 0x060030A2 RID: 12450 RVA: 0x000AC9D4 File Offset: 0x000AABD4
		// (set) Token: 0x060030A3 RID: 12451 RVA: 0x000AC9DC File Offset: 0x000AABDC
		public global::Ionic.Zip.SetCompressionCallback SetCompression { get; set; }

		// Token: 0x17000E03 RID: 3587
		// (get) Token: 0x060030A4 RID: 12452 RVA: 0x000AC9E8 File Offset: 0x000AABE8
		// (set) Token: 0x060030A5 RID: 12453 RVA: 0x000ACA0C File Offset: 0x000AAC0C
		[global::System.Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				return this.AlternateEncoding == global::System.Text.Encoding.GetEncoding("UTF-8") && this.AlternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary;
			}
			set
			{
				if (value)
				{
					this.AlternateEncoding = global::System.Text.Encoding.GetEncoding("UTF-8");
					this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
					return;
				}
				this.AlternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
			}
		}

		// Token: 0x17000E04 RID: 3588
		// (get) Token: 0x060030A6 RID: 12454 RVA: 0x000ACA40 File Offset: 0x000AAC40
		// (set) Token: 0x060030A7 RID: 12455 RVA: 0x000ACA48 File Offset: 0x000AAC48
		[global::System.Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public global::System.Text.Encoding ProvisionalAlternateEncoding { get; set; }

		// Token: 0x17000E05 RID: 3589
		// (get) Token: 0x060030A8 RID: 12456 RVA: 0x000ACA54 File Offset: 0x000AAC54
		// (set) Token: 0x060030A9 RID: 12457 RVA: 0x000ACA5C File Offset: 0x000AAC5C
		public global::System.Text.Encoding AlternateEncoding { get; set; }

		// Token: 0x17000E06 RID: 3590
		// (get) Token: 0x060030AA RID: 12458 RVA: 0x000ACA68 File Offset: 0x000AAC68
		// (set) Token: 0x060030AB RID: 12459 RVA: 0x000ACA70 File Offset: 0x000AAC70
		public global::Ionic.Zip.ZipOption AlternateEncodingUsage { get; set; }

		// Token: 0x060030AC RID: 12460 RVA: 0x000ACA7C File Offset: 0x000AAC7C
		internal static string NameInArchive(string filename, string directoryPathInArchive)
		{
			string pathName;
			if (directoryPathInArchive == null)
			{
				pathName = filename;
			}
			else if (string.IsNullOrEmpty(directoryPathInArchive))
			{
				pathName = global::System.IO.Path.GetFileName(filename);
			}
			else
			{
				pathName = global::System.IO.Path.Combine(directoryPathInArchive, global::System.IO.Path.GetFileName(filename));
			}
			return global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(pathName);
		}

		// Token: 0x060030AD RID: 12461 RVA: 0x000ACAC8 File Offset: 0x000AACC8
		internal static global::Ionic.Zip.ZipEntry CreateFromNothing(string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.None, null, null);
		}

		// Token: 0x060030AE RID: 12462 RVA: 0x000ACAD4 File Offset: 0x000AACD4
		internal static global::Ionic.Zip.ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.FileSystem, filename, null);
		}

		// Token: 0x060030AF RID: 12463 RVA: 0x000ACAE0 File Offset: 0x000AACE0
		internal static global::Ionic.Zip.ZipEntry CreateForStream(string entryName, global::System.IO.Stream s)
		{
			return global::Ionic.Zip.ZipEntry.Create(entryName, global::Ionic.Zip.ZipEntrySource.Stream, s, null);
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x000ACAEC File Offset: 0x000AACEC
		internal static global::Ionic.Zip.ZipEntry CreateForWriter(string entryName, global::Ionic.Zip.WriteDelegate d)
		{
			return global::Ionic.Zip.ZipEntry.Create(entryName, global::Ionic.Zip.ZipEntrySource.WriteDelegate, d, null);
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x000ACAF8 File Offset: 0x000AACF8
		internal static global::Ionic.Zip.ZipEntry CreateForJitStreamProvider(string nameInArchive, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.JitStream, opener, closer);
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x000ACB04 File Offset: 0x000AAD04
		internal static global::Ionic.Zip.ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.ZipOutputStream, null, null);
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x000ACB10 File Offset: 0x000AAD10
		private static global::Ionic.Zip.ZipEntry Create(string nameInArchive, global::Ionic.Zip.ZipEntrySource source, object arg1, object arg2)
		{
			if (string.IsNullOrEmpty(nameInArchive))
			{
				throw new global::Ionic.Zip.ZipException("The entry name must be non-null and non-empty.");
			}
			global::Ionic.Zip.ZipEntry zipEntry = new global::Ionic.Zip.ZipEntry();
			zipEntry._VersionMadeBy = 45;
			zipEntry._Source = source;
			zipEntry._Mtime = (zipEntry._Atime = (zipEntry._Ctime = global::System.DateTime.UtcNow));
			if (source == global::Ionic.Zip.ZipEntrySource.Stream)
			{
				zipEntry._sourceStream = (arg1 as global::System.IO.Stream);
			}
			else if (source == global::Ionic.Zip.ZipEntrySource.WriteDelegate)
			{
				zipEntry._WriteDelegate = (arg1 as global::Ionic.Zip.WriteDelegate);
			}
			else if (source == global::Ionic.Zip.ZipEntrySource.JitStream)
			{
				zipEntry._OpenDelegate = (arg1 as global::Ionic.Zip.OpenDelegate);
				zipEntry._CloseDelegate = (arg2 as global::Ionic.Zip.CloseDelegate);
			}
			else if (source != global::Ionic.Zip.ZipEntrySource.ZipOutputStream)
			{
				if (source == global::Ionic.Zip.ZipEntrySource.None)
				{
					zipEntry._Source = global::Ionic.Zip.ZipEntrySource.FileSystem;
				}
				else
				{
					string text = arg1 as string;
					if (string.IsNullOrEmpty(text))
					{
						throw new global::Ionic.Zip.ZipException("The filename must be non-null and non-empty.");
					}
					try
					{
						zipEntry._Mtime = global::System.IO.File.GetLastWriteTime(text).ToUniversalTime();
						zipEntry._Ctime = global::System.IO.File.GetCreationTime(text).ToUniversalTime();
						zipEntry._Atime = global::System.IO.File.GetLastAccessTime(text).ToUniversalTime();
						if (global::System.IO.File.Exists(text) || global::System.IO.Directory.Exists(text))
						{
							zipEntry._ExternalFileAttrs = (int)global::System.IO.File.GetAttributes(text);
						}
						zipEntry._ntfsTimesAreSet = true;
						zipEntry._LocalFileName = global::System.IO.Path.GetFullPath(text);
					}
					catch (global::System.IO.PathTooLongException innerException)
					{
						throw new global::Ionic.Zip.ZipException(string.Format("The path is too long, filename={0}", text), innerException);
					}
				}
			}
			zipEntry._LastModified = zipEntry._Mtime;
			zipEntry._FileNameInArchive = global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(nameInArchive);
			return zipEntry;
		}

		// Token: 0x060030B4 RID: 12468 RVA: 0x000ACCA4 File Offset: 0x000AAEA4
		internal void MarkAsDirectory()
		{
			this._IsDirectory = true;
			if (!this._FileNameInArchive.EndsWith("/"))
			{
				this._FileNameInArchive += "/";
			}
		}

		// Token: 0x17000E07 RID: 3591
		// (get) Token: 0x060030B5 RID: 12469 RVA: 0x000ACCD8 File Offset: 0x000AAED8
		// (set) Token: 0x060030B6 RID: 12470 RVA: 0x000ACCE0 File Offset: 0x000AAEE0
		public bool IsText
		{
			get
			{
				return this._IsText;
			}
			set
			{
				this._IsText = value;
			}
		}

		// Token: 0x060030B7 RID: 12471 RVA: 0x000ACCEC File Offset: 0x000AAEEC
		public override string ToString()
		{
			return string.Format("ZipEntry::{0}", this.FileName);
		}

		// Token: 0x17000E08 RID: 3592
		// (get) Token: 0x060030B8 RID: 12472 RVA: 0x000ACD00 File Offset: 0x000AAF00
		internal global::System.IO.Stream ArchiveStream
		{
			get
			{
				if (this._archiveStream == null)
				{
					if (this._container.ZipFile != null)
					{
						global::Ionic.Zip.ZipFile zipFile = this._container.ZipFile;
						zipFile.Reset(false);
						this._archiveStream = zipFile.StreamForDiskNumber(this._diskNumber);
					}
					else
					{
						this._archiveStream = this._container.ZipOutputStream.OutputStream;
					}
				}
				return this._archiveStream;
			}
		}

		// Token: 0x060030B9 RID: 12473 RVA: 0x000ACD74 File Offset: 0x000AAF74
		private void SetFdpLoh()
		{
			long position = this.ArchiveStream.Position;
			try
			{
				this.ArchiveStream.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
			}
			catch (global::System.IO.IOException innerException)
			{
				throw new global::Ionic.Zip.BadStateException(string.Format("Exception seeking  entry({0}) offset(0x{1:X8}) len(0x{2:X8})", this.FileName, this._RelativeOffsetOfLocalHeader, this.ArchiveStream.Length), innerException);
			}
			byte[] array = new byte[30];
			this.ArchiveStream.Read(array, 0, array.Length);
			short num = (short)((int)array[26] + (int)array[27] * 256);
			short num2 = (short)((int)array[28] + (int)array[29] * 256);
			this.ArchiveStream.Seek((long)(num + num2), global::System.IO.SeekOrigin.Current);
			this._LengthOfHeader = (int)(30 + num2 + num) + global::Ionic.Zip.ZipEntry.GetLengthOfCryptoHeaderBytes(this._Encryption_FromZipFile);
			this.__FileDataPosition = this._RelativeOffsetOfLocalHeader + (long)this._LengthOfHeader;
			this.ArchiveStream.Seek(position, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x060030BA RID: 12474 RVA: 0x000ACE74 File Offset: 0x000AB074
		private static int GetKeyStrengthInBits(global::Ionic.Zip.EncryptionAlgorithm a)
		{
			if (a == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				return 256;
			}
			if (a == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128)
			{
				return 128;
			}
			return -1;
		}

		// Token: 0x060030BB RID: 12475 RVA: 0x000ACE94 File Offset: 0x000AB094
		internal static int GetLengthOfCryptoHeaderBytes(global::Ionic.Zip.EncryptionAlgorithm a)
		{
			if (a == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				return 0;
			}
			if (a == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || a == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				return global::Ionic.Zip.ZipEntry.GetKeyStrengthInBits(a) / 8 / 2 + 2;
			}
			if (a == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
			{
				return 12;
			}
			throw new global::Ionic.Zip.ZipException("internal error");
		}

		// Token: 0x17000E09 RID: 3593
		// (get) Token: 0x060030BC RID: 12476 RVA: 0x000ACED0 File Offset: 0x000AB0D0
		internal long FileDataPosition
		{
			get
			{
				if (this.__FileDataPosition == -1L)
				{
					this.SetFdpLoh();
				}
				return this.__FileDataPosition;
			}
		}

		// Token: 0x17000E0A RID: 3594
		// (get) Token: 0x060030BD RID: 12477 RVA: 0x000ACEEC File Offset: 0x000AB0EC
		private int LengthOfHeader
		{
			get
			{
				if (this._LengthOfHeader == 0)
				{
					this.SetFdpLoh();
				}
				return this._LengthOfHeader;
			}
		}

		// Token: 0x060030BE RID: 12478 RVA: 0x000ACF08 File Offset: 0x000AB108
		public void Extract()
		{
			this.InternalExtract(".", null, null);
		}

		// Token: 0x060030BF RID: 12479 RVA: 0x000ACF18 File Offset: 0x000AB118
		public void Extract(global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtract(".", null, null);
		}

		// Token: 0x060030C0 RID: 12480 RVA: 0x000ACF30 File Offset: 0x000AB130
		public void Extract(global::System.IO.Stream stream)
		{
			this.InternalExtract(null, stream, null);
		}

		// Token: 0x060030C1 RID: 12481 RVA: 0x000ACF3C File Offset: 0x000AB13C
		public void Extract(string baseDirectory)
		{
			this.InternalExtract(baseDirectory, null, null);
		}

		// Token: 0x060030C2 RID: 12482 RVA: 0x000ACF48 File Offset: 0x000AB148
		public void Extract(string baseDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtract(baseDirectory, null, null);
		}

		// Token: 0x060030C3 RID: 12483 RVA: 0x000ACF5C File Offset: 0x000AB15C
		public void ExtractWithPassword(string password)
		{
			this.InternalExtract(".", null, password);
		}

		// Token: 0x060030C4 RID: 12484 RVA: 0x000ACF6C File Offset: 0x000AB16C
		public void ExtractWithPassword(string baseDirectory, string password)
		{
			this.InternalExtract(baseDirectory, null, password);
		}

		// Token: 0x060030C5 RID: 12485 RVA: 0x000ACF78 File Offset: 0x000AB178
		public void ExtractWithPassword(global::Ionic.Zip.ExtractExistingFileAction extractExistingFile, string password)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtract(".", null, password);
		}

		// Token: 0x060030C6 RID: 12486 RVA: 0x000ACF90 File Offset: 0x000AB190
		public void ExtractWithPassword(string baseDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile, string password)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtract(baseDirectory, null, password);
		}

		// Token: 0x060030C7 RID: 12487 RVA: 0x000ACFA4 File Offset: 0x000AB1A4
		public void ExtractWithPassword(global::System.IO.Stream stream, string password)
		{
			this.InternalExtract(null, stream, password);
		}

		// Token: 0x060030C8 RID: 12488 RVA: 0x000ACFB0 File Offset: 0x000AB1B0
		public global::Ionic.Crc.CrcCalculatorStream OpenReader()
		{
			if (this._container.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.InternalOpenReader(this._Password ?? this._container.Password);
		}

		// Token: 0x060030C9 RID: 12489 RVA: 0x000ACFEC File Offset: 0x000AB1EC
		public global::Ionic.Crc.CrcCalculatorStream OpenReader(string password)
		{
			if (this._container.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.InternalOpenReader(password);
		}

		// Token: 0x060030CA RID: 12490 RVA: 0x000AD010 File Offset: 0x000AB210
		internal global::Ionic.Crc.CrcCalculatorStream InternalOpenReader(string password)
		{
			this.ValidateCompression();
			this.ValidateEncryption();
			this.SetupCryptoForExtract(password);
			if (this._Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::Ionic.Zip.BadStateException("You must call ZipFile.Save before calling OpenReader");
			}
			long length = (this._CompressionMethod_FromZipFile == 0) ? this._CompressedFileDataSize : this.UncompressedSize;
			global::System.IO.Stream archiveStream = this.ArchiveStream;
			this.ArchiveStream.Seek(this.FileDataPosition, global::System.IO.SeekOrigin.Begin);
			this._inputDecryptorStream = this.GetExtractDecryptor(archiveStream);
			return new global::Ionic.Crc.CrcCalculatorStream(this.GetExtractDecompressor(this._inputDecryptorStream), length);
		}

		// Token: 0x060030CB RID: 12491 RVA: 0x000AD0A4 File Offset: 0x000AB2A4
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnExtractBlock(this, bytesWritten, totalBytesToWrite);
			}
		}

		// Token: 0x060030CC RID: 12492 RVA: 0x000AD0E0 File Offset: 0x000AB2E0
		private void OnBeforeExtract(string path)
		{
			if (this._container.ZipFile != null && !this._container.ZipFile._inExtractAll)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnSingleEntryExtract(this, path, true);
			}
		}

		// Token: 0x060030CD RID: 12493 RVA: 0x000AD130 File Offset: 0x000AB330
		private void OnAfterExtract(string path)
		{
			if (this._container.ZipFile != null && !this._container.ZipFile._inExtractAll)
			{
				this._container.ZipFile.OnSingleEntryExtract(this, path, false);
			}
		}

		// Token: 0x060030CE RID: 12494 RVA: 0x000AD17C File Offset: 0x000AB37C
		private void OnExtractExisting(string path)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnExtractExisting(this, path);
			}
		}

		// Token: 0x060030CF RID: 12495 RVA: 0x000AD1A8 File Offset: 0x000AB3A8
		private static void ReallyDelete(string fileName)
		{
			if ((global::System.IO.File.GetAttributes(fileName) & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
			{
				global::System.IO.File.SetAttributes(fileName, global::System.IO.FileAttributes.Normal);
			}
			global::System.IO.File.Delete(fileName);
		}

		// Token: 0x060030D0 RID: 12496 RVA: 0x000AD1CC File Offset: 0x000AB3CC
		private void WriteStatus(string format, params object[] args)
		{
			if (this._container.ZipFile != null && this._container.ZipFile.Verbose)
			{
				this._container.ZipFile.StatusMessageTextWriter.WriteLine(format, args);
			}
		}

		// Token: 0x060030D1 RID: 12497 RVA: 0x000AD21C File Offset: 0x000AB41C
		private void InternalExtract(string baseDir, global::System.IO.Stream outstream, string password)
		{
			if (this._container == null)
			{
				throw new global::Ionic.Zip.BadStateException("This entry is an orphan");
			}
			if (this._container.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use Extract() only with ZipFile.");
			}
			this._container.ZipFile.Reset(false);
			if (this._Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::Ionic.Zip.BadStateException("You must call ZipFile.Save before calling any Extract method");
			}
			this.OnBeforeExtract(baseDir);
			this._ioOperationCanceled = false;
			string text = null;
			global::System.IO.Stream stream = null;
			bool flag = false;
			bool flag2 = false;
			try
			{
				this.ValidateCompression();
				this.ValidateEncryption();
				if (this.ValidateOutput(baseDir, outstream, out text))
				{
					this.WriteStatus("extract dir {0}...", new object[]
					{
						text
					});
					this.OnAfterExtract(baseDir);
				}
				else
				{
					if (text != null && global::System.IO.File.Exists(text))
					{
						flag = true;
						int num = this.CheckExtractExistingFile(baseDir, text);
						if (num == 2)
						{
							goto IL_2C7;
						}
						if (num == 1)
						{
							return;
						}
					}
					string text2 = password ?? (this._Password ?? this._container.Password);
					if (this._Encryption_FromZipFile != global::Ionic.Zip.EncryptionAlgorithm.None)
					{
						if (text2 == null)
						{
							throw new global::Ionic.Zip.BadPasswordException();
						}
						this.SetupCryptoForExtract(text2);
					}
					if (text != null)
					{
						this.WriteStatus("extract file {0}...", new object[]
						{
							text
						});
						text += ".tmp";
						string directoryName = global::System.IO.Path.GetDirectoryName(text);
						if (!global::System.IO.Directory.Exists(directoryName))
						{
							global::System.IO.Directory.CreateDirectory(directoryName);
						}
						else if (this._container.ZipFile != null)
						{
							flag2 = this._container.ZipFile._inExtractAll;
						}
						stream = new global::System.IO.FileStream(text, global::System.IO.FileMode.CreateNew);
					}
					else
					{
						this.WriteStatus("extract entry {0} to stream...", new object[]
						{
							this.FileName
						});
						stream = outstream;
					}
					if (!this._ioOperationCanceled)
					{
						int actualCrc = this.ExtractOne(stream);
						if (!this._ioOperationCanceled)
						{
							this.VerifyCrcAfterExtract(actualCrc);
							if (text != null)
							{
								stream.Close();
								stream = null;
								string text3 = text;
								string text4 = null;
								text = text3.Substring(0, text3.Length - 4);
								if (flag)
								{
									text4 = text + ".PendingOverwrite";
									global::System.IO.File.Move(text, text4);
								}
								global::System.IO.File.Move(text3, text);
								this._SetTimes(text, true);
								if (text4 != null && global::System.IO.File.Exists(text4))
								{
									global::Ionic.Zip.ZipEntry.ReallyDelete(text4);
								}
								if (flag2 && this.FileName.IndexOf('/') != -1)
								{
									string directoryName2 = global::System.IO.Path.GetDirectoryName(this.FileName);
									if (this._container.ZipFile[directoryName2] == null)
									{
										this._SetTimes(global::System.IO.Path.GetDirectoryName(text), false);
									}
								}
								if (((int)this._VersionMadeBy & 65280) == 2560 || ((int)this._VersionMadeBy & 65280) == 0)
								{
									global::System.IO.File.SetAttributes(text, (global::System.IO.FileAttributes)this._ExternalFileAttrs);
								}
							}
							this.OnAfterExtract(baseDir);
						}
					}
					IL_2C7:;
				}
			}
			catch (global::System.Exception)
			{
				this._ioOperationCanceled = true;
				throw;
			}
			finally
			{
				if (this._ioOperationCanceled && text != null)
				{
					if (stream != null)
					{
						stream.Close();
					}
					if (global::System.IO.File.Exists(text) && !flag)
					{
						global::System.IO.File.Delete(text);
					}
				}
			}
		}

		// Token: 0x060030D2 RID: 12498 RVA: 0x000AD568 File Offset: 0x000AB768
		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
			if (actualCrc32 != this._Crc32 && ((this.Encryption != global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 && this.Encryption != global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256) || this._WinZipAesMethod != 2))
			{
				throw new global::Ionic.Zip.BadCrcException("CRC error: the file being extracted appears to be corrupted. " + string.Format("Expected 0x{0:X8}, Actual 0x{1:X8}", this._Crc32, actualCrc32));
			}
			if (this.UncompressedSize == 0L)
			{
				return;
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				global::Ionic.Zip.WinZipAesCipherStream winZipAesCipherStream = this._inputDecryptorStream as global::Ionic.Zip.WinZipAesCipherStream;
				this._aesCrypto_forExtract.CalculatedMac = winZipAesCipherStream.FinalAuthentication;
				this._aesCrypto_forExtract.ReadAndVerifyMac(this.ArchiveStream);
			}
		}

		// Token: 0x060030D3 RID: 12499 RVA: 0x000AD628 File Offset: 0x000AB828
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			int num = 0;
			for (;;)
			{
				switch (this.ExtractExistingFile)
				{
				case global::Ionic.Zip.ExtractExistingFileAction.OverwriteSilently:
					goto IL_24;
				case global::Ionic.Zip.ExtractExistingFileAction.DoNotOverwrite:
					goto IL_3B;
				case global::Ionic.Zip.ExtractExistingFileAction.InvokeExtractProgressEvent:
					if (num > 0)
					{
						goto Block_2;
					}
					this.OnExtractExisting(baseDir);
					if (this._ioOperationCanceled)
					{
						return 2;
					}
					num++;
					continue;
				}
				break;
			}
			goto IL_8A;
			IL_24:
			this.WriteStatus("the file {0} exists; will overwrite it...", new object[]
			{
				targetFileName
			});
			return 0;
			IL_3B:
			this.WriteStatus("the file {0} exists; not extracting entry...", new object[]
			{
				this.FileName
			});
			this.OnAfterExtract(baseDir);
			return 1;
			Block_2:
			throw new global::Ionic.Zip.ZipException(string.Format("The file {0} already exists.", targetFileName));
			IL_8A:
			throw new global::Ionic.Zip.ZipException(string.Format("The file {0} already exists.", targetFileName));
		}

		// Token: 0x060030D4 RID: 12500 RVA: 0x000AD6DC File Offset: 0x000AB8DC
		private void _CheckRead(int nbytes)
		{
			if (nbytes == 0)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("bad read of entry {0} from compressed archive.", this.FileName));
			}
		}

		// Token: 0x060030D5 RID: 12501 RVA: 0x000AD6FC File Offset: 0x000AB8FC
		private int ExtractOne(global::System.IO.Stream output)
		{
			int result = 0;
			global::System.IO.Stream archiveStream = this.ArchiveStream;
			try
			{
				archiveStream.Seek(this.FileDataPosition, global::System.IO.SeekOrigin.Begin);
				byte[] array = new byte[this.BufferSize];
				long num = (this._CompressionMethod_FromZipFile != 0) ? this.UncompressedSize : this._CompressedFileDataSize;
				this._inputDecryptorStream = this.GetExtractDecryptor(archiveStream);
				global::System.IO.Stream extractDecompressor = this.GetExtractDecompressor(this._inputDecryptorStream);
				long num2 = 0L;
				using (global::Ionic.Crc.CrcCalculatorStream crcCalculatorStream = new global::Ionic.Crc.CrcCalculatorStream(extractDecompressor))
				{
					while (num > 0L)
					{
						int count = (num > (long)array.Length) ? array.Length : ((int)num);
						int num3 = crcCalculatorStream.Read(array, 0, count);
						this._CheckRead(num3);
						output.Write(array, 0, num3);
						num -= (long)num3;
						num2 += (long)num3;
						this.OnExtractProgress(num2, this.UncompressedSize);
						if (this._ioOperationCanceled)
						{
							break;
						}
					}
					result = crcCalculatorStream.Crc;
				}
			}
			finally
			{
				global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = archiveStream as global::Ionic.Zip.ZipSegmentedStream;
				if (zipSegmentedStream != null)
				{
					zipSegmentedStream.Dispose();
					this._archiveStream = null;
				}
			}
			return result;
		}

		// Token: 0x060030D6 RID: 12502 RVA: 0x000AD82C File Offset: 0x000ABA2C
		internal global::System.IO.Stream GetExtractDecompressor(global::System.IO.Stream input2)
		{
			short compressionMethod_FromZipFile = this._CompressionMethod_FromZipFile;
			if (compressionMethod_FromZipFile == 0)
			{
				return input2;
			}
			if (compressionMethod_FromZipFile == 8)
			{
				return new global::Ionic.Zlib.DeflateStream(input2, global::Ionic.Zlib.CompressionMode.Decompress, true);
			}
			if (compressionMethod_FromZipFile != 12)
			{
				return null;
			}
			return new global::Ionic.BZip2.BZip2InputStream(input2, true);
		}

		// Token: 0x060030D7 RID: 12503 RVA: 0x000AD874 File Offset: 0x000ABA74
		internal global::System.IO.Stream GetExtractDecryptor(global::System.IO.Stream input)
		{
			global::System.IO.Stream result;
			if (this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
			{
				result = new global::Ionic.Zip.ZipCipherStream(input, this._zipCrypto_forExtract, global::Ionic.Zip.CryptoMode.Decrypt);
			}
			else if (this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				result = new global::Ionic.Zip.WinZipAesCipherStream(input, this._aesCrypto_forExtract, this._CompressedFileDataSize, global::Ionic.Zip.CryptoMode.Decrypt);
			}
			else
			{
				result = input;
			}
			return result;
		}

		// Token: 0x060030D8 RID: 12504 RVA: 0x000AD8DC File Offset: 0x000ABADC
		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
			try
			{
				if (this._ntfsTimesAreSet)
				{
					if (isFile)
					{
						if (global::System.IO.File.Exists(fileOrDirectory))
						{
							global::System.IO.File.SetCreationTimeUtc(fileOrDirectory, this._Ctime);
							global::System.IO.File.SetLastAccessTimeUtc(fileOrDirectory, this._Atime);
							global::System.IO.File.SetLastWriteTimeUtc(fileOrDirectory, this._Mtime);
						}
					}
					else if (global::System.IO.Directory.Exists(fileOrDirectory))
					{
						global::System.IO.Directory.SetCreationTimeUtc(fileOrDirectory, this._Ctime);
						global::System.IO.Directory.SetLastAccessTimeUtc(fileOrDirectory, this._Atime);
						global::System.IO.Directory.SetLastWriteTimeUtc(fileOrDirectory, this._Mtime);
					}
				}
				else
				{
					global::System.DateTime lastWriteTime = global::Ionic.Zip.SharedUtilities.AdjustTime_Reverse(this.LastModified);
					if (isFile)
					{
						global::System.IO.File.SetLastWriteTime(fileOrDirectory, lastWriteTime);
					}
					else
					{
						global::System.IO.Directory.SetLastWriteTime(fileOrDirectory, lastWriteTime);
					}
				}
			}
			catch (global::System.IO.IOException ex)
			{
				this.WriteStatus("failed to set time on {0}: {1}", new object[]
				{
					fileOrDirectory,
					ex.Message
				});
			}
		}

		// Token: 0x17000E0B RID: 3595
		// (get) Token: 0x060030D9 RID: 12505 RVA: 0x000AD9C0 File Offset: 0x000ABBC0
		private string UnsupportedAlgorithm
		{
			get
			{
				string empty = string.Empty;
				uint unsupportedAlgorithmId = this._UnsupportedAlgorithmId;
				if (unsupportedAlgorithmId <= 26128U)
				{
					if (unsupportedAlgorithmId <= 26115U)
					{
						if (unsupportedAlgorithmId == 0U)
						{
							return "--";
						}
						switch (unsupportedAlgorithmId)
						{
						case 26113U:
							return "DES";
						case 26114U:
							return "RC2";
						case 26115U:
							return "3DES-168";
						}
					}
					else
					{
						if (unsupportedAlgorithmId == 26121U)
						{
							return "3DES-112";
						}
						switch (unsupportedAlgorithmId)
						{
						case 26126U:
							return "PKWare AES128";
						case 26127U:
							return "PKWare AES192";
						case 26128U:
							return "PKWare AES256";
						}
					}
				}
				else if (unsupportedAlgorithmId <= 26400U)
				{
					if (unsupportedAlgorithmId == 26370U)
					{
						return "RC2";
					}
					if (unsupportedAlgorithmId == 26400U)
					{
						return "Blowfish";
					}
				}
				else
				{
					if (unsupportedAlgorithmId == 26401U)
					{
						return "Twofish";
					}
					if (unsupportedAlgorithmId == 26625U)
					{
						return "RC4";
					}
					if (unsupportedAlgorithmId != 65535U)
					{
					}
				}
				return string.Format("Unknown (0x{0:X4})", this._UnsupportedAlgorithmId);
			}
		}

		// Token: 0x17000E0C RID: 3596
		// (get) Token: 0x060030DA RID: 12506 RVA: 0x000ADB28 File Offset: 0x000ABD28
		private string UnsupportedCompressionMethod
		{
			get
			{
				string empty = string.Empty;
				int compressionMethod = (int)this._CompressionMethod;
				if (compressionMethod <= 1)
				{
					if (compressionMethod == 0)
					{
						return "Store";
					}
					if (compressionMethod == 1)
					{
						return "Shrink";
					}
				}
				else
				{
					switch (compressionMethod)
					{
					case 8:
						return "DEFLATE";
					case 9:
						return "Deflate64";
					case 10:
					case 11:
					case 13:
						break;
					case 12:
						return "BZIP2";
					case 14:
						return "LZMA";
					default:
						if (compressionMethod == 19)
						{
							return "LZ77";
						}
						if (compressionMethod == 98)
						{
							return "PPMd";
						}
						break;
					}
				}
				return string.Format("Unknown (0x{0:X4})", this._CompressionMethod);
			}
		}

		// Token: 0x060030DB RID: 12507 RVA: 0x000ADC08 File Offset: 0x000ABE08
		internal void ValidateEncryption()
		{
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				return;
			}
			if (this._UnsupportedAlgorithmId != 0U)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Cannot extract: Entry {0} is encrypted with an algorithm not supported by DotNetZip: {1}", this.FileName, this.UnsupportedAlgorithm));
			}
			throw new global::Ionic.Zip.ZipException(string.Format("Cannot extract: Entry {0} uses an unsupported encryption algorithm ({1:X2})", this.FileName, (int)this.Encryption));
		}

		// Token: 0x060030DC RID: 12508 RVA: 0x000ADC90 File Offset: 0x000ABE90
		private void ValidateCompression()
		{
			if (this._CompressionMethod_FromZipFile != 0 && this._CompressionMethod_FromZipFile != 8 && this._CompressionMethod_FromZipFile != 12)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Entry {0} uses an unsupported compression method (0x{1:X2}, {2})", this.FileName, this._CompressionMethod_FromZipFile, this.UnsupportedCompressionMethod));
			}
		}

		// Token: 0x060030DD RID: 12509 RVA: 0x000ADCEC File Offset: 0x000ABEEC
		private void SetupCryptoForExtract(string password)
		{
			if (this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				return;
			}
			if (this._Encryption_FromZipFile != global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
			{
				if (this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
				{
					if (password == null)
					{
						throw new global::Ionic.Zip.ZipException("Missing password.");
					}
					if (this._aesCrypto_forExtract != null)
					{
						this._aesCrypto_forExtract.Password = password;
						return;
					}
					int lengthOfCryptoHeaderBytes = global::Ionic.Zip.ZipEntry.GetLengthOfCryptoHeaderBytes(this._Encryption_FromZipFile);
					this.ArchiveStream.Seek(this.FileDataPosition - (long)lengthOfCryptoHeaderBytes, global::System.IO.SeekOrigin.Begin);
					int keyStrengthInBits = global::Ionic.Zip.ZipEntry.GetKeyStrengthInBits(this._Encryption_FromZipFile);
					this._aesCrypto_forExtract = global::Ionic.Zip.WinZipAesCrypto.ReadFromStream(password, keyStrengthInBits, this.ArchiveStream);
				}
				return;
			}
			if (password == null)
			{
				throw new global::Ionic.Zip.ZipException("Missing password.");
			}
			this.ArchiveStream.Seek(this.FileDataPosition - 12L, global::System.IO.SeekOrigin.Begin);
			this._zipCrypto_forExtract = global::Ionic.Zip.ZipCrypto.ForRead(password, this);
		}

		// Token: 0x060030DE RID: 12510 RVA: 0x000ADDD0 File Offset: 0x000ABFD0
		private bool ValidateOutput(string basedir, global::System.IO.Stream outstream, out string outFileName)
		{
			if (basedir != null)
			{
				string text = this.FileName.Replace("\\", "/");
				if (text.IndexOf(':') == 1)
				{
					text = text.Substring(2);
				}
				if (text.StartsWith("/"))
				{
					text = text.Substring(1);
				}
				if (this._container.ZipFile.FlattenFoldersOnExtract)
				{
					outFileName = global::System.IO.Path.Combine(basedir, (text.IndexOf('/') != -1) ? global::System.IO.Path.GetFileName(text) : text);
				}
				else
				{
					outFileName = global::System.IO.Path.Combine(basedir, text);
				}
				outFileName = outFileName.Replace("/", "\\");
				if (this.IsDirectory || this.FileName.EndsWith("/"))
				{
					if (!global::System.IO.Directory.Exists(outFileName))
					{
						global::System.IO.Directory.CreateDirectory(outFileName);
						this._SetTimes(outFileName, false);
					}
					else if (this.ExtractExistingFile == global::Ionic.Zip.ExtractExistingFileAction.OverwriteSilently)
					{
						this._SetTimes(outFileName, false);
					}
					return true;
				}
				return false;
			}
			else
			{
				if (outstream != null)
				{
					outFileName = null;
					return this.IsDirectory || this.FileName.EndsWith("/");
				}
				throw new global::System.ArgumentNullException("outstream");
			}
		}

		// Token: 0x060030DF RID: 12511 RVA: 0x000ADF18 File Offset: 0x000AC118
		private void ReadExtraField()
		{
			this._readExtraDepth++;
			long position = this.ArchiveStream.Position;
			this.ArchiveStream.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
			byte[] array = new byte[30];
			this.ArchiveStream.Read(array, 0, array.Length);
			int num = 26;
			short num2 = (short)((int)array[num++] + (int)array[num++] * 256);
			short extraFieldLength = (short)((int)array[num++] + (int)array[num++] * 256);
			this.ArchiveStream.Seek((long)num2, global::System.IO.SeekOrigin.Current);
			this.ProcessExtraField(this.ArchiveStream, extraFieldLength);
			this.ArchiveStream.Seek(position, global::System.IO.SeekOrigin.Begin);
			this._readExtraDepth--;
		}

		// Token: 0x060030E0 RID: 12512 RVA: 0x000ADFDC File Offset: 0x000AC1DC
		private static bool ReadHeader(global::Ionic.Zip.ZipEntry ze, global::System.Text.Encoding defaultEncoding)
		{
			int num = 0;
			ze._RelativeOffsetOfLocalHeader = ze.ArchiveStream.Position;
			int num2 = global::Ionic.Zip.SharedUtilities.ReadEntrySignature(ze.ArchiveStream);
			num += 4;
			if (global::Ionic.Zip.ZipEntry.IsNotValidSig(num2))
			{
				ze.ArchiveStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
				if (global::Ionic.Zip.ZipEntry.IsNotValidZipDirEntrySig(num2) && (long)num2 != 101010256L)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Bad signature (0x{0:X8}) at position  0x{1:X8}", num2, ze.ArchiveStream.Position));
				}
				return false;
			}
			else
			{
				byte[] array = new byte[26];
				int num3 = ze.ArchiveStream.Read(array, 0, array.Length);
				if (num3 != array.Length)
				{
					return false;
				}
				num += num3;
				int num4 = 0;
				ze._VersionNeeded = (short)((int)array[num4++] + (int)array[num4++] * 256);
				ze._BitField = (short)((int)array[num4++] + (int)array[num4++] * 256);
				ze._CompressionMethod_FromZipFile = (ze._CompressionMethod = (short)((int)array[num4++] + (int)array[num4++] * 256));
				ze._TimeBlob = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				ze._LastModified = global::Ionic.Zip.SharedUtilities.PackedToDateTime(ze._TimeBlob);
				ze._timestamp |= global::Ionic.Zip.ZipEntryTimestamp.DOS;
				if ((ze._BitField & 1) == 1)
				{
					ze._Encryption_FromZipFile = (ze._Encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak);
					ze._sourceIsEncrypted = true;
				}
				ze._Crc32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
				ze._CompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				ze._UncompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
				if ((uint)ze._CompressedSize == 4294967295U || (uint)ze._UncompressedSize == 4294967295U)
				{
					ze._InputUsesZip64 = true;
				}
				int num5 = (int)((short)((int)array[num4++] + (int)array[num4++] * 256));
				short extraFieldLength = (short)((int)array[num4++] + (int)array[num4++] * 256);
				array = new byte[num5];
				num3 = ze.ArchiveStream.Read(array, 0, array.Length);
				num += num3;
				if ((ze._BitField & 2048) == 2048)
				{
					ze.AlternateEncoding = global::System.Text.Encoding.UTF8;
					ze.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				}
				ze._FileNameInArchive = ze.AlternateEncoding.GetString(array, 0, array.Length);
				if (ze._FileNameInArchive.EndsWith("/"))
				{
					ze.MarkAsDirectory();
				}
				num += ze.ProcessExtraField(ze.ArchiveStream, extraFieldLength);
				ze._LengthOfTrailer = 0;
				if (!ze._FileNameInArchive.EndsWith("/") && (ze._BitField & 8) == 8)
				{
					long position = ze.ArchiveStream.Position;
					bool flag = true;
					long num6 = 0L;
					int num7 = 0;
					while (flag)
					{
						num7++;
						if (ze._container.ZipFile != null)
						{
							ze._container.ZipFile.OnReadBytes(ze);
						}
						long num8 = global::Ionic.Zip.SharedUtilities.FindSignature(ze.ArchiveStream, 134695760);
						if (num8 == -1L)
						{
							return false;
						}
						num6 += num8;
						if (ze._InputUsesZip64)
						{
							array = new byte[20];
							num3 = ze.ArchiveStream.Read(array, 0, array.Length);
							if (num3 != 20)
							{
								return false;
							}
							num4 = 0;
							ze._Crc32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
							ze._CompressedSize = global::System.BitConverter.ToInt64(array, num4);
							num4 += 8;
							ze._UncompressedSize = global::System.BitConverter.ToInt64(array, num4);
							num4 += 8;
							ze._LengthOfTrailer += 24;
						}
						else
						{
							array = new byte[12];
							num3 = ze.ArchiveStream.Read(array, 0, array.Length);
							if (num3 != 12)
							{
								return false;
							}
							num4 = 0;
							ze._Crc32 = (int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256;
							ze._CompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
							ze._UncompressedSize = (long)((ulong)((int)array[num4++] + (int)array[num4++] * 256 + (int)array[num4++] * 256 * 256 + (int)array[num4++] * 256 * 256 * 256));
							ze._LengthOfTrailer += 16;
						}
						flag = (num6 != ze._CompressedSize);
						if (flag)
						{
							ze.ArchiveStream.Seek(-12L, global::System.IO.SeekOrigin.Current);
							num6 += 4L;
						}
					}
					ze.ArchiveStream.Seek(position, global::System.IO.SeekOrigin.Begin);
				}
				ze._CompressedFileDataSize = ze._CompressedSize;
				if ((ze._BitField & 1) == 1)
				{
					if (ze.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || ze.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
					{
						int keyStrengthInBits = global::Ionic.Zip.ZipEntry.GetKeyStrengthInBits(ze._Encryption_FromZipFile);
						ze._aesCrypto_forExtract = global::Ionic.Zip.WinZipAesCrypto.ReadFromStream(null, keyStrengthInBits, ze.ArchiveStream);
						num += ze._aesCrypto_forExtract.SizeOfEncryptionMetadata - 10;
						ze._CompressedFileDataSize -= (long)ze._aesCrypto_forExtract.SizeOfEncryptionMetadata;
						ze._LengthOfTrailer += 10;
					}
					else
					{
						ze._WeakEncryptionHeader = new byte[12];
						num += global::Ionic.Zip.ZipEntry.ReadWeakEncryptionHeader(ze._archiveStream, ze._WeakEncryptionHeader);
						ze._CompressedFileDataSize -= 12L;
					}
				}
				ze._LengthOfHeader = num;
				ze._TotalEntrySize = (long)ze._LengthOfHeader + ze._CompressedFileDataSize + (long)ze._LengthOfTrailer;
				return true;
			}
		}

		// Token: 0x060030E1 RID: 12513 RVA: 0x000AE70C File Offset: 0x000AC90C
		internal static int ReadWeakEncryptionHeader(global::System.IO.Stream s, byte[] buffer)
		{
			int num = s.Read(buffer, 0, 12);
			if (num != 12)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Unexpected end of data at position 0x{0:X8}", s.Position));
			}
			return num;
		}

		// Token: 0x060030E2 RID: 12514 RVA: 0x000AE73C File Offset: 0x000AC93C
		private static bool IsNotValidSig(int signature)
		{
			return signature != 67324752;
		}

		// Token: 0x060030E3 RID: 12515 RVA: 0x000AE74C File Offset: 0x000AC94C
		internal static global::Ionic.Zip.ZipEntry ReadEntry(global::Ionic.Zip.ZipContainer zc, bool first)
		{
			global::Ionic.Zip.ZipFile zipFile = zc.ZipFile;
			global::System.IO.Stream readStream = zc.ReadStream;
			global::System.Text.Encoding alternateEncoding = zc.AlternateEncoding;
			global::Ionic.Zip.ZipEntry zipEntry = new global::Ionic.Zip.ZipEntry();
			zipEntry._Source = global::Ionic.Zip.ZipEntrySource.ZipFile;
			zipEntry._container = zc;
			zipEntry._archiveStream = readStream;
			if (zipFile != null)
			{
				zipFile.OnReadEntry(true, null);
			}
			if (first)
			{
				global::Ionic.Zip.ZipEntry.HandlePK00Prefix(readStream);
			}
			if (!global::Ionic.Zip.ZipEntry.ReadHeader(zipEntry, alternateEncoding))
			{
				return null;
			}
			zipEntry.__FileDataPosition = zipEntry.ArchiveStream.Position;
			readStream.Seek(zipEntry._CompressedFileDataSize + (long)zipEntry._LengthOfTrailer, global::System.IO.SeekOrigin.Current);
			global::Ionic.Zip.ZipEntry.HandleUnexpectedDataDescriptor(zipEntry);
			if (zipFile != null)
			{
				zipFile.OnReadBytes(zipEntry);
				zipFile.OnReadEntry(false, zipEntry);
			}
			return zipEntry;
		}

		// Token: 0x060030E4 RID: 12516 RVA: 0x000AE7F8 File Offset: 0x000AC9F8
		internal static void HandlePK00Prefix(global::System.IO.Stream s)
		{
			if (global::Ionic.Zip.SharedUtilities.ReadInt(s) != 808471376)
			{
				s.Seek(-4L, global::System.IO.SeekOrigin.Current);
			}
		}

		// Token: 0x060030E5 RID: 12517 RVA: 0x000AE818 File Offset: 0x000ACA18
		private static void HandleUnexpectedDataDescriptor(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.IO.Stream archiveStream = entry.ArchiveStream;
			if ((ulong)global::Ionic.Zip.SharedUtilities.ReadInt(archiveStream) == (ulong)((long)entry._Crc32))
			{
				if ((long)global::Ionic.Zip.SharedUtilities.ReadInt(archiveStream) != entry._CompressedSize)
				{
					archiveStream.Seek(-8L, global::System.IO.SeekOrigin.Current);
					return;
				}
				if ((long)global::Ionic.Zip.SharedUtilities.ReadInt(archiveStream) != entry._UncompressedSize)
				{
					archiveStream.Seek(-12L, global::System.IO.SeekOrigin.Current);
					return;
				}
			}
			else
			{
				archiveStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
			}
		}

		// Token: 0x060030E6 RID: 12518 RVA: 0x000AE88C File Offset: 0x000ACA8C
		internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId)
		{
			int num = offx;
			while (num + 3 < extra.Length)
			{
				if ((ushort)((int)extra[num++] + (int)extra[num++] * 256) == targetHeaderId)
				{
					return num - 2;
				}
				short num2 = (short)((int)extra[num++] + (int)extra[num++] * 256);
				num += (int)num2;
			}
			return -1;
		}

		// Token: 0x060030E7 RID: 12519 RVA: 0x000AE8E8 File Offset: 0x000ACAE8
		internal int ProcessExtraField(global::System.IO.Stream s, short extraFieldLength)
		{
			int num = 0;
			if (extraFieldLength > 0)
			{
				byte[] array = this._Extra = new byte[(int)extraFieldLength];
				num = s.Read(array, 0, array.Length);
				long posn = s.Position - (long)num;
				int num2 = 0;
				while (num2 + 3 < array.Length)
				{
					int num3 = num2;
					ushort num4 = (ushort)((int)array[num2++] + (int)array[num2++] * 256);
					short num5 = (short)((int)array[num2++] + (int)array[num2++] * 256);
					if (num4 <= 21589)
					{
						if (num4 <= 10)
						{
							if (num4 != 1)
							{
								if (num4 == 10)
								{
									num2 = this.ProcessExtraFieldWindowsTimes(array, num2, num5, posn);
								}
							}
							else
							{
								num2 = this.ProcessExtraFieldZip64(array, num2, num5, posn);
							}
						}
						else if (num4 != 23)
						{
							if (num4 == 21589)
							{
								num2 = this.ProcessExtraFieldUnixTimes(array, num2, num5, posn);
							}
						}
						else
						{
							num2 = this.ProcessExtraFieldPkwareStrongEncryption(array, num2);
						}
					}
					else if (num4 <= 30805)
					{
						if (num4 != 22613)
						{
							if (num4 != 30805)
							{
							}
						}
						else
						{
							num2 = this.ProcessExtraFieldInfoZipTimes(array, num2, num5, posn);
						}
					}
					else if (num4 != 30837)
					{
						if (num4 == 39169)
						{
							num2 = this.ProcessExtraFieldWinZipAes(array, num2, num5, posn);
						}
					}
					num2 = num3 + (int)num5 + 4;
				}
			}
			return num;
		}

		// Token: 0x060030E8 RID: 12520 RVA: 0x000AEA78 File Offset: 0x000ACC78
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			j += 2;
			this._UnsupportedAlgorithmId = (uint)((ushort)((int)Buffer[j++] + (int)Buffer[j++] * 256));
			this._Encryption_FromZipFile = (this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.Unsupported);
			return j;
		}

		// Token: 0x060030E9 RID: 12521 RVA: 0x000AEAC0 File Offset: 0x000ACCC0
		private int ProcessExtraFieldWinZipAes(byte[] buffer, int j, short dataSize, long posn)
		{
			if (this._CompressionMethod == 99)
			{
				if ((this._BitField & 1) != 1)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Inconsistent metadata at position 0x{0:X16}", posn));
				}
				this._sourceIsEncrypted = true;
				if (dataSize != 7)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Inconsistent size (0x{0:X4}) in WinZip AES field at position 0x{1:X16}", dataSize, posn));
				}
				this._WinZipAesMethod = global::System.BitConverter.ToInt16(buffer, j);
				j += 2;
				if (this._WinZipAesMethod != 1 && this._WinZipAesMethod != 2)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Unexpected vendor version number (0x{0:X4}) for WinZip AES metadata at position 0x{1:X16}", this._WinZipAesMethod, posn));
				}
				short num = global::System.BitConverter.ToInt16(buffer, j);
				j += 2;
				if (num != 17729)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Unexpected vendor ID (0x{0:X4}) for WinZip AES metadata at position 0x{1:X16}", num, posn));
				}
				int num2 = (buffer[j] == 1) ? 128 : ((buffer[j] == 3) ? 256 : -1);
				if (num2 < 0)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("Invalid key strength ({0})", num2));
				}
				this._Encryption_FromZipFile = (this._Encryption = ((num2 == 128) ? global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 : global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256));
				j++;
				this._CompressionMethod_FromZipFile = (this._CompressionMethod = global::System.BitConverter.ToInt16(buffer, j));
				j += 2;
			}
			return j;
		}

		// Token: 0x060030EA RID: 12522 RVA: 0x000AEC38 File Offset: 0x000ACE38
		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			this._InputUsesZip64 = true;
			if (dataSize > 28)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Inconsistent size (0x{0:X4}) for ZIP64 extra field at position 0x{1:X16}", dataSize, posn));
			}
			int remainingData = (int)dataSize;
			global::Ionic.Zip.ZipEntry.Func<long> func = delegate()
			{
				if (remainingData < 8)
				{
					throw new global::Ionic.Zip.BadReadException(string.Format("  Missing data for ZIP64 extra field, position 0x{0:X16}", posn));
				}
				long result = global::System.BitConverter.ToInt64(buffer, j);
				j += 8;
				remainingData -= 8;
				return result;
			};
			if (this._UncompressedSize == (long)((ulong)-1))
			{
				this._UncompressedSize = func();
			}
			if (this._CompressedSize == (long)((ulong)-1))
			{
				this._CompressedSize = func();
			}
			if (this._RelativeOffsetOfLocalHeader == (long)((ulong)-1))
			{
				this._RelativeOffsetOfLocalHeader = func();
			}
			return j;
		}

		// Token: 0x060030EB RID: 12523 RVA: 0x000AECFC File Offset: 0x000ACEFC
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			if (dataSize != 12 && dataSize != 8)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Unexpected size (0x{0:X4}) for InfoZip v1 extra field at position 0x{1:X16}", dataSize, posn));
			}
			int num = global::System.BitConverter.ToInt32(buffer, j);
			this._Mtime = global::Ionic.Zip.ZipEntry._unixEpoch.AddSeconds((double)num);
			j += 4;
			num = global::System.BitConverter.ToInt32(buffer, j);
			this._Atime = global::Ionic.Zip.ZipEntry._unixEpoch.AddSeconds((double)num);
			j += 4;
			this._Ctime = global::System.DateTime.UtcNow;
			this._ntfsTimesAreSet = true;
			this._timestamp |= global::Ionic.Zip.ZipEntryTimestamp.InfoZip1;
			return j;
		}

		// Token: 0x060030EC RID: 12524 RVA: 0x000AED98 File Offset: 0x000ACF98
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			if (dataSize != 13 && dataSize != 9 && dataSize != 5)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Unexpected size (0x{0:X4}) for Extended Timestamp extra field at position 0x{1:X16}", dataSize, posn));
			}
			int remainingData = (int)dataSize;
			global::Ionic.Zip.ZipEntry.Func<global::System.DateTime> func = delegate()
			{
				int num2 = global::System.BitConverter.ToInt32(buffer, j);
				j += 4;
				remainingData -= 4;
				return global::Ionic.Zip.ZipEntry._unixEpoch.AddSeconds((double)num2);
			};
			if (dataSize == 13 || this._readExtraDepth > 0)
			{
				byte[] buffer2 = buffer;
				int num = j;
				j = num + 1;
				byte b = buffer2[num];
				num = remainingData;
				remainingData = num - 1;
				if ((b & 1) != 0 && remainingData >= 4)
				{
					this._Mtime = func();
				}
				this._Atime = (((b & 2) != 0 && remainingData >= 4) ? func() : global::System.DateTime.UtcNow);
				this._Ctime = (((b & 4) != 0 && remainingData >= 4) ? func() : global::System.DateTime.UtcNow);
				this._timestamp |= global::Ionic.Zip.ZipEntryTimestamp.Unix;
				this._ntfsTimesAreSet = true;
				this._emitUnixTimes = true;
			}
			else
			{
				this.ReadExtraField();
			}
			return j;
		}

		// Token: 0x060030ED RID: 12525 RVA: 0x000AEEE4 File Offset: 0x000AD0E4
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			if (dataSize != 32)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Unexpected size (0x{0:X4}) for NTFS times extra field at position 0x{1:X16}", dataSize, posn));
			}
			j += 4;
			int num = (int)((short)((int)buffer[j] + (int)buffer[j + 1] * 256));
			short num2 = (short)((int)buffer[j + 2] + (int)buffer[j + 3] * 256);
			j += 4;
			if (num == 1 && num2 == 24)
			{
				long fileTime = global::System.BitConverter.ToInt64(buffer, j);
				this._Mtime = global::System.DateTime.FromFileTimeUtc(fileTime);
				j += 8;
				fileTime = global::System.BitConverter.ToInt64(buffer, j);
				this._Atime = global::System.DateTime.FromFileTimeUtc(fileTime);
				j += 8;
				fileTime = global::System.BitConverter.ToInt64(buffer, j);
				this._Ctime = global::System.DateTime.FromFileTimeUtc(fileTime);
				j += 8;
				this._ntfsTimesAreSet = true;
				this._timestamp |= global::Ionic.Zip.ZipEntryTimestamp.Windows;
				this._emitNtfsTimes = true;
			}
			return j;
		}

		// Token: 0x060030EE RID: 12526 RVA: 0x000AEFC0 File Offset: 0x000AD1C0
		internal void WriteCentralDirectoryEntry(global::System.IO.Stream s)
		{
			byte[] array = new byte[4096];
			int num = 0;
			array[num++] = 80;
			array[num++] = 75;
			array[num++] = 1;
			array[num++] = 2;
			array[num++] = (byte)(this._VersionMadeBy & 255);
			array[num++] = (byte)(((int)this._VersionMadeBy & 65280) >> 8);
			short num2 = (this.VersionNeeded != 0) ? this.VersionNeeded : 20;
			if (this._OutputUsesZip64 == null)
			{
				this._OutputUsesZip64 = new bool?(this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always);
			}
			short num3 = this._OutputUsesZip64.Value ? 45 : num2;
			if (this.CompressionMethod == global::Ionic.Zip.CompressionMethod.BZip2)
			{
				num3 = 46;
			}
			array[num++] = (byte)(num3 & 255);
			array[num++] = (byte)(((int)num3 & 65280) >> 8);
			array[num++] = (byte)(this._BitField & 255);
			array[num++] = (byte)(((int)this._BitField & 65280) >> 8);
			array[num++] = (byte)(this._CompressionMethod & 255);
			array[num++] = (byte)(((int)this._CompressionMethod & 65280) >> 8);
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				num -= 2;
				array[num++] = 99;
				array[num++] = 0;
			}
			array[num++] = (byte)(this._TimeBlob & 255);
			array[num++] = (byte)((this._TimeBlob & 65280) >> 8);
			array[num++] = (byte)((this._TimeBlob & 16711680) >> 16);
			array[num++] = (byte)(((long)this._TimeBlob & (long)((ulong)-16777216)) >> 24);
			array[num++] = (byte)(this._Crc32 & 255);
			array[num++] = (byte)((this._Crc32 & 65280) >> 8);
			array[num++] = (byte)((this._Crc32 & 16711680) >> 16);
			array[num++] = (byte)(((long)this._Crc32 & (long)((ulong)-16777216)) >> 24);
			if (this._OutputUsesZip64.Value)
			{
				for (int i = 0; i < 8; i++)
				{
					array[num++] = byte.MaxValue;
				}
			}
			else
			{
				array[num++] = (byte)(this._CompressedSize & 255L);
				array[num++] = (byte)((this._CompressedSize & 65280L) >> 8);
				array[num++] = (byte)((this._CompressedSize & 16711680L) >> 16);
				array[num++] = (byte)((this._CompressedSize & (long)((ulong)-16777216)) >> 24);
				array[num++] = (byte)(this._UncompressedSize & 255L);
				array[num++] = (byte)((this._UncompressedSize & 65280L) >> 8);
				array[num++] = (byte)((this._UncompressedSize & 16711680L) >> 16);
				array[num++] = (byte)((this._UncompressedSize & (long)((ulong)-16777216)) >> 24);
			}
			byte[] encodedFileNameBytes = this.GetEncodedFileNameBytes();
			short num4 = (short)encodedFileNameBytes.Length;
			array[num++] = (byte)(num4 & 255);
			array[num++] = (byte)(((int)num4 & 65280) >> 8);
			this._presumeZip64 = this._OutputUsesZip64.Value;
			this._Extra = this.ConstructExtraField(true);
			short num5 = (short)((this._Extra == null) ? 0 : this._Extra.Length);
			array[num++] = (byte)(num5 & 255);
			array[num++] = (byte)(((int)num5 & 65280) >> 8);
			int num6 = (this._CommentBytes == null) ? 0 : this._CommentBytes.Length;
			if (num6 + num > array.Length)
			{
				num6 = array.Length - num;
			}
			array[num++] = (byte)(num6 & 255);
			array[num++] = (byte)((num6 & 65280) >> 8);
			if (this._container.ZipFile != null && this._container.ZipFile.MaxOutputSegmentSize != 0)
			{
				array[num++] = (byte)(this._diskNumber & 255U);
				array[num++] = (byte)((this._diskNumber & 65280U) >> 8);
			}
			else
			{
				array[num++] = 0;
				array[num++] = 0;
			}
			array[num++] = (this._IsText ? 1 : 0);
			array[num++] = 0;
			array[num++] = (byte)(this._ExternalFileAttrs & 255);
			array[num++] = (byte)((this._ExternalFileAttrs & 65280) >> 8);
			array[num++] = (byte)((this._ExternalFileAttrs & 16711680) >> 16);
			array[num++] = (byte)(((long)this._ExternalFileAttrs & (long)((ulong)-16777216)) >> 24);
			if (this._RelativeOffsetOfLocalHeader > (long)((ulong)-1))
			{
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
				array[num++] = byte.MaxValue;
			}
			else
			{
				array[num++] = (byte)(this._RelativeOffsetOfLocalHeader & 255L);
				array[num++] = (byte)((this._RelativeOffsetOfLocalHeader & 65280L) >> 8);
				array[num++] = (byte)((this._RelativeOffsetOfLocalHeader & 16711680L) >> 16);
				array[num++] = (byte)((this._RelativeOffsetOfLocalHeader & (long)((ulong)-16777216)) >> 24);
			}
			global::System.Buffer.BlockCopy(encodedFileNameBytes, 0, array, num, (int)num4);
			num += (int)num4;
			if (this._Extra != null)
			{
				global::System.Array extra = this._Extra;
				int srcOffset = 0;
				global::System.Buffer.BlockCopy(extra, srcOffset, array, num, (int)num5);
				num += (int)num5;
			}
			if (num6 != 0)
			{
				global::System.Buffer.BlockCopy(this._CommentBytes, 0, array, num, num6);
				num += num6;
			}
			s.Write(array, 0, num);
		}

		// Token: 0x060030EF RID: 12527 RVA: 0x000AF594 File Offset: 0x000AD794
		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			global::System.Collections.Generic.List<byte[]> list = new global::System.Collections.Generic.List<byte[]>();
			if (this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || (this._container.Zip64 == global::Ionic.Zip.Zip64Option.AsNecessary && (!forCentralDirectory || this._entryRequiresZip64.Value)))
			{
				int num = 4 + (forCentralDirectory ? 28 : 16);
				byte[] array = new byte[num];
				int num2 = 0;
				if (this._presumeZip64 || forCentralDirectory)
				{
					array[num2++] = 1;
					array[num2++] = 0;
				}
				else
				{
					array[num2++] = 153;
					array[num2++] = 153;
				}
				array[num2++] = (byte)(num - 4);
				array[num2++] = 0;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._UncompressedSize), 0, array, num2, 8);
				num2 += 8;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._CompressedSize), 0, array, num2, 8);
				num2 += 8;
				if (forCentralDirectory)
				{
					global::System.Array.Copy(global::System.BitConverter.GetBytes(this._RelativeOffsetOfLocalHeader), 0, array, num2, 8);
					num2 += 8;
					global::System.Array.Copy(global::System.BitConverter.GetBytes(0), 0, array, num2, 4);
				}
				list.Add(array);
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				byte[] array = new byte[11];
				int num3 = 0;
				array[num3++] = 1;
				array[num3++] = 153;
				array[num3++] = 7;
				array[num3++] = 0;
				array[num3++] = 1;
				array[num3++] = 0;
				array[num3++] = 65;
				array[num3++] = 69;
				int keyStrengthInBits = global::Ionic.Zip.ZipEntry.GetKeyStrengthInBits(this.Encryption);
				if (keyStrengthInBits == 128)
				{
					array[num3] = 1;
				}
				else if (keyStrengthInBits == 256)
				{
					array[num3] = 3;
				}
				else
				{
					array[num3] = byte.MaxValue;
				}
				num3++;
				array[num3++] = (byte)(this._CompressionMethod & 255);
				array[num3++] = (byte)((int)this._CompressionMethod & 65280);
				list.Add(array);
			}
			if (this._ntfsTimesAreSet && this._emitNtfsTimes)
			{
				byte[] array = new byte[36];
				int num4 = 0;
				array[num4++] = 10;
				array[num4++] = 0;
				array[num4++] = 32;
				array[num4++] = 0;
				num4 += 4;
				array[num4++] = 1;
				array[num4++] = 0;
				array[num4++] = 24;
				array[num4++] = 0;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._Mtime.ToFileTime()), 0, array, num4, 8);
				num4 += 8;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._Atime.ToFileTime()), 0, array, num4, 8);
				num4 += 8;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._Ctime.ToFileTime()), 0, array, num4, 8);
				num4 += 8;
				list.Add(array);
			}
			if (this._ntfsTimesAreSet && this._emitUnixTimes)
			{
				int num5 = 9;
				if (!forCentralDirectory)
				{
					num5 += 8;
				}
				byte[] array = new byte[num5];
				int num6 = 0;
				array[num6++] = 85;
				array[num6++] = 84;
				array[num6++] = (byte)(num5 - 4);
				array[num6++] = 0;
				array[num6++] = 7;
				global::System.Array.Copy(global::System.BitConverter.GetBytes((int)(this._Mtime - global::Ionic.Zip.ZipEntry._unixEpoch).TotalSeconds), 0, array, num6, 4);
				num6 += 4;
				if (!forCentralDirectory)
				{
					global::System.Array.Copy(global::System.BitConverter.GetBytes((int)(this._Atime - global::Ionic.Zip.ZipEntry._unixEpoch).TotalSeconds), 0, array, num6, 4);
					num6 += 4;
					global::System.Array.Copy(global::System.BitConverter.GetBytes((int)(this._Ctime - global::Ionic.Zip.ZipEntry._unixEpoch).TotalSeconds), 0, array, num6, 4);
					num6 += 4;
				}
				list.Add(array);
			}
			byte[] array2 = null;
			if (list.Count > 0)
			{
				int num7 = 0;
				int num8 = 0;
				for (int i = 0; i < list.Count; i++)
				{
					num7 += list[i].Length;
				}
				array2 = new byte[num7];
				for (int i = 0; i < list.Count; i++)
				{
					global::System.Array.Copy(list[i], 0, array2, num8, list[i].Length);
					num8 += list[i].Length;
				}
			}
			return array2;
		}

		// Token: 0x060030F0 RID: 12528 RVA: 0x000AFA14 File Offset: 0x000ADC14
		private string NormalizeFileName()
		{
			string text = this.FileName.Replace("\\", "/");
			string result;
			if (this._TrimVolumeFromFullyQualifiedPaths && this.FileName.Length >= 3 && this.FileName[1] == ':' && text[2] == '/')
			{
				result = text.Substring(3);
			}
			else if (this.FileName.Length >= 4 && text[0] == '/' && text[1] == '/')
			{
				int num = text.IndexOf('/', 2);
				if (num == -1)
				{
					throw new global::System.ArgumentException("The path for that entry appears to be badly formatted");
				}
				result = text.Substring(num + 1);
			}
			else if (this.FileName.Length >= 3 && text[0] == '.' && text[1] == '/')
			{
				result = text.Substring(2);
			}
			else
			{
				result = text;
			}
			return result;
		}

		// Token: 0x060030F1 RID: 12529 RVA: 0x000AFB1C File Offset: 0x000ADD1C
		private byte[] GetEncodedFileNameBytes()
		{
			string text = this.NormalizeFileName();
			global::Ionic.Zip.ZipOption alternateEncodingUsage = this.AlternateEncodingUsage;
			if (alternateEncodingUsage == global::Ionic.Zip.ZipOption.Default)
			{
				if (this._Comment != null && this._Comment.Length != 0)
				{
					this._CommentBytes = global::Ionic.Zip.ZipEntry.ibm437.GetBytes(this._Comment);
				}
				this._actualEncoding = global::Ionic.Zip.ZipEntry.ibm437;
				return global::Ionic.Zip.ZipEntry.ibm437.GetBytes(text);
			}
			if (alternateEncodingUsage == global::Ionic.Zip.ZipOption.Always)
			{
				if (this._Comment != null && this._Comment.Length != 0)
				{
					this._CommentBytes = this.AlternateEncoding.GetBytes(this._Comment);
				}
				this._actualEncoding = this.AlternateEncoding;
				return this.AlternateEncoding.GetBytes(text);
			}
			byte[] bytes = global::Ionic.Zip.ZipEntry.ibm437.GetBytes(text);
			string @string = global::Ionic.Zip.ZipEntry.ibm437.GetString(bytes, 0, bytes.Length);
			this._CommentBytes = null;
			if (@string != text)
			{
				bytes = this.AlternateEncoding.GetBytes(text);
				if (this._Comment != null && this._Comment.Length != 0)
				{
					this._CommentBytes = this.AlternateEncoding.GetBytes(this._Comment);
				}
				this._actualEncoding = this.AlternateEncoding;
				return bytes;
			}
			this._actualEncoding = global::Ionic.Zip.ZipEntry.ibm437;
			if (this._Comment == null || this._Comment.Length == 0)
			{
				return bytes;
			}
			byte[] bytes2 = global::Ionic.Zip.ZipEntry.ibm437.GetBytes(this._Comment);
			if (global::Ionic.Zip.ZipEntry.ibm437.GetString(bytes2, 0, bytes2.Length) != this.Comment)
			{
				bytes = this.AlternateEncoding.GetBytes(text);
				this._CommentBytes = this.AlternateEncoding.GetBytes(this._Comment);
				this._actualEncoding = this.AlternateEncoding;
				return bytes;
			}
			this._CommentBytes = bytes2;
			return bytes;
		}

		// Token: 0x060030F2 RID: 12530 RVA: 0x000AFCE8 File Offset: 0x000ADEE8
		private bool WantReadAgain()
		{
			return this._UncompressedSize >= 16L && this._CompressionMethod != 0 && this.CompressionLevel != global::Ionic.Zlib.CompressionLevel.None && this._CompressedSize >= this._UncompressedSize && (this._Source != global::Ionic.Zip.ZipEntrySource.Stream || this._sourceStream.CanSeek) && (this._aesCrypto_forWrite == null || this.CompressedSize - (long)this._aesCrypto_forWrite.SizeOfEncryptionMetadata > this.UncompressedSize + 16L) && (this._zipCrypto_forWrite == null || this.CompressedSize - 12L > this.UncompressedSize);
		}

		// Token: 0x060030F3 RID: 12531 RVA: 0x000AFDA8 File Offset: 0x000ADFA8
		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
			if (cycle > 1)
			{
				this._CompressionMethod = 0;
				return;
			}
			if (this.IsDirectory)
			{
				this._CompressionMethod = 0;
				return;
			}
			if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				return;
			}
			if (this._Source == global::Ionic.Zip.ZipEntrySource.Stream)
			{
				if (this._sourceStream != null && this._sourceStream.CanSeek && this._sourceStream.Length == 0L)
				{
					this._CompressionMethod = 0;
					return;
				}
			}
			else if (this._Source == global::Ionic.Zip.ZipEntrySource.FileSystem && global::Ionic.Zip.SharedUtilities.GetFileLength(this.LocalFileName) == 0L)
			{
				this._CompressionMethod = 0;
				return;
			}
			if (this.SetCompression != null)
			{
				this.CompressionLevel = this.SetCompression(this.LocalFileName, this._FileNameInArchive);
			}
			if (this.CompressionLevel == global::Ionic.Zlib.CompressionLevel.None && this.CompressionMethod == global::Ionic.Zip.CompressionMethod.Deflate)
			{
				this._CompressionMethod = 0;
			}
		}

		// Token: 0x060030F4 RID: 12532 RVA: 0x000AFE94 File Offset: 0x000AE094
		internal void WriteHeader(global::System.IO.Stream s, int cycle)
		{
			global::Ionic.Zip.CountingStream countingStream = s as global::Ionic.Zip.CountingStream;
			this._future_ROLH = ((countingStream != null) ? countingStream.ComputedPosition : s.Position);
			int num = 0;
			byte[] array = new byte[30];
			array[num++] = 80;
			array[num++] = 75;
			array[num++] = 3;
			array[num++] = 4;
			this._presumeZip64 = (this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || (this._container.Zip64 == global::Ionic.Zip.Zip64Option.AsNecessary && !s.CanSeek));
			short num2 = this._presumeZip64 ? 45 : 20;
			if (this.CompressionMethod == global::Ionic.Zip.CompressionMethod.BZip2)
			{
				num2 = 46;
			}
			array[num++] = (byte)(num2 & 255);
			array[num++] = (byte)(((int)num2 & 65280) >> 8);
			byte[] encodedFileNameBytes = this.GetEncodedFileNameBytes();
			short num3 = (short)encodedFileNameBytes.Length;
			if (this._Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				this._BitField &= -2;
			}
			else
			{
				this._BitField |= 1;
			}
			if (this._actualEncoding.CodePage == global::System.Text.Encoding.UTF8.CodePage)
			{
				this._BitField |= 2048;
			}
			if (this.IsDirectory || cycle == 99)
			{
				this._BitField &= -9;
				this._BitField &= -2;
				this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
				this.Password = null;
			}
			else if (!s.CanSeek)
			{
				this._BitField |= 8;
			}
			array[num++] = (byte)(this._BitField & 255);
			array[num++] = (byte)(((int)this._BitField & 65280) >> 8);
			if (this.__FileDataPosition == -1L)
			{
				this._CompressedSize = 0L;
				this._crcCalculated = false;
			}
			this.MaybeUnsetCompressionMethodForWriting(cycle);
			array[num++] = (byte)(this._CompressionMethod & 255);
			array[num++] = (byte)(((int)this._CompressionMethod & 65280) >> 8);
			if (cycle == 99)
			{
				this.SetZip64Flags();
			}
			else if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				num -= 2;
				array[num++] = 99;
				array[num++] = 0;
			}
			this._TimeBlob = global::Ionic.Zip.SharedUtilities.DateTimeToPacked(this.LastModified);
			array[num++] = (byte)(this._TimeBlob & 255);
			array[num++] = (byte)((this._TimeBlob & 65280) >> 8);
			array[num++] = (byte)((this._TimeBlob & 16711680) >> 16);
			array[num++] = (byte)(((long)this._TimeBlob & (long)((ulong)-16777216)) >> 24);
			array[num++] = (byte)(this._Crc32 & 255);
			array[num++] = (byte)((this._Crc32 & 65280) >> 8);
			array[num++] = (byte)((this._Crc32 & 16711680) >> 16);
			array[num++] = (byte)(((long)this._Crc32 & (long)((ulong)-16777216)) >> 24);
			if (this._presumeZip64)
			{
				for (int i = 0; i < 8; i++)
				{
					array[num++] = byte.MaxValue;
				}
			}
			else
			{
				array[num++] = (byte)(this._CompressedSize & 255L);
				array[num++] = (byte)((this._CompressedSize & 65280L) >> 8);
				array[num++] = (byte)((this._CompressedSize & 16711680L) >> 16);
				array[num++] = (byte)((this._CompressedSize & (long)((ulong)-16777216)) >> 24);
				array[num++] = (byte)(this._UncompressedSize & 255L);
				array[num++] = (byte)((this._UncompressedSize & 65280L) >> 8);
				array[num++] = (byte)((this._UncompressedSize & 16711680L) >> 16);
				array[num++] = (byte)((this._UncompressedSize & (long)((ulong)-16777216)) >> 24);
			}
			array[num++] = (byte)(num3 & 255);
			array[num++] = (byte)(((int)num3 & 65280) >> 8);
			this._Extra = this.ConstructExtraField(false);
			short num4 = (short)((this._Extra == null) ? 0 : this._Extra.Length);
			array[num++] = (byte)(num4 & 255);
			array[num++] = (byte)(((int)num4 & 65280) >> 8);
			byte[] array2 = new byte[num + (int)num3 + (int)num4];
			global::System.Buffer.BlockCopy(array, 0, array2, 0, num);
			global::System.Buffer.BlockCopy(encodedFileNameBytes, 0, array2, num, encodedFileNameBytes.Length);
			num += encodedFileNameBytes.Length;
			if (this._Extra != null)
			{
				global::System.Buffer.BlockCopy(this._Extra, 0, array2, num, this._Extra.Length);
				num += this._Extra.Length;
			}
			this._LengthOfHeader = num;
			global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = s as global::Ionic.Zip.ZipSegmentedStream;
			if (zipSegmentedStream != null)
			{
				zipSegmentedStream.ContiguousWrite = true;
				uint num5 = zipSegmentedStream.ComputeSegment(num);
				if (num5 != zipSegmentedStream.CurrentSegment)
				{
					this._future_ROLH = 0L;
				}
				else
				{
					this._future_ROLH = zipSegmentedStream.Position;
				}
				this._diskNumber = num5;
			}
			if (this._container.Zip64 == global::Ionic.Zip.Zip64Option.Default && (uint)this._RelativeOffsetOfLocalHeader >= 4294967295U)
			{
				throw new global::Ionic.Zip.ZipException("Offset within the zip archive exceeds 0xFFFFFFFF. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			s.Write(array2, 0, num);
			if (zipSegmentedStream != null)
			{
				zipSegmentedStream.ContiguousWrite = false;
			}
			this._EntryHeader = array2;
		}

		// Token: 0x060030F5 RID: 12533 RVA: 0x000B0414 File Offset: 0x000AE614
		private int FigureCrc32()
		{
			if (!this._crcCalculated)
			{
				global::System.IO.Stream stream = null;
				if (this._Source == global::Ionic.Zip.ZipEntrySource.WriteDelegate)
				{
					global::Ionic.Crc.CrcCalculatorStream crcCalculatorStream = new global::Ionic.Crc.CrcCalculatorStream(global::System.IO.Stream.Null);
					this._WriteDelegate(this.FileName, crcCalculatorStream);
					this._Crc32 = crcCalculatorStream.Crc;
				}
				else if (this._Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
				{
					if (this._Source == global::Ionic.Zip.ZipEntrySource.Stream)
					{
						this.PrepSourceStream();
						stream = this._sourceStream;
					}
					else if (this._Source == global::Ionic.Zip.ZipEntrySource.JitStream)
					{
						if (this._sourceStream == null)
						{
							this._sourceStream = this._OpenDelegate(this.FileName);
						}
						this.PrepSourceStream();
						stream = this._sourceStream;
					}
					else if (this._Source != global::Ionic.Zip.ZipEntrySource.ZipOutputStream)
					{
						stream = global::System.IO.File.Open(this.LocalFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
					}
					global::Ionic.Crc.CRC32 crc = new global::Ionic.Crc.CRC32();
					this._Crc32 = crc.GetCrc32(stream);
					if (this._sourceStream == null)
					{
						stream.Dispose();
					}
				}
				this._crcCalculated = true;
			}
			return this._Crc32;
		}

		// Token: 0x060030F6 RID: 12534 RVA: 0x000B0524 File Offset: 0x000AE724
		private void PrepSourceStream()
		{
			if (this._sourceStream == null)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("The input stream is null for entry '{0}'.", this.FileName));
			}
			if (this._sourceStreamOriginalPosition != null)
			{
				this._sourceStream.Position = this._sourceStreamOriginalPosition.Value;
				return;
			}
			if (this._sourceStream.CanSeek)
			{
				this._sourceStreamOriginalPosition = new long?(this._sourceStream.Position);
				return;
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak && this._Source != global::Ionic.Zip.ZipEntrySource.ZipFile && (this._BitField & 8) != 8)
			{
				throw new global::Ionic.Zip.ZipException("It is not possible to use PKZIP encryption on a non-seekable input stream");
			}
		}

		// Token: 0x060030F7 RID: 12535 RVA: 0x000B05D8 File Offset: 0x000AE7D8
		internal void CopyMetaData(global::Ionic.Zip.ZipEntry source)
		{
			this.__FileDataPosition = source.__FileDataPosition;
			this.CompressionMethod = source.CompressionMethod;
			this._CompressionMethod_FromZipFile = source._CompressionMethod_FromZipFile;
			this._CompressedFileDataSize = source._CompressedFileDataSize;
			this._UncompressedSize = source._UncompressedSize;
			this._BitField = source._BitField;
			this._Source = source._Source;
			this._LastModified = source._LastModified;
			this._Mtime = source._Mtime;
			this._Atime = source._Atime;
			this._Ctime = source._Ctime;
			this._ntfsTimesAreSet = source._ntfsTimesAreSet;
			this._emitUnixTimes = source._emitUnixTimes;
			this._emitNtfsTimes = source._emitNtfsTimes;
		}

		// Token: 0x060030F8 RID: 12536 RVA: 0x000B0694 File Offset: 0x000AE894
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnSaveBlock(this, bytesXferred, totalBytesToXfer);
			}
		}

		// Token: 0x060030F9 RID: 12537 RVA: 0x000B06D0 File Offset: 0x000AE8D0
		private void _WriteEntryData(global::System.IO.Stream s)
		{
			global::System.IO.Stream stream = null;
			long _FileDataPosition = -1L;
			try
			{
				_FileDataPosition = s.Position;
			}
			catch (global::System.Exception)
			{
			}
			try
			{
				long num = this.SetInputAndFigureFileLength(ref stream);
				global::Ionic.Zip.CountingStream countingStream = new global::Ionic.Zip.CountingStream(s);
				global::System.IO.Stream stream2;
				global::System.IO.Stream stream3;
				if (num != 0L)
				{
					stream2 = this.MaybeApplyEncryption(countingStream);
					stream3 = this.MaybeApplyCompression(stream2, num);
				}
				else
				{
					stream3 = (stream2 = countingStream);
				}
				global::Ionic.Crc.CrcCalculatorStream crcCalculatorStream = new global::Ionic.Crc.CrcCalculatorStream(stream3, true);
				if (this._Source == global::Ionic.Zip.ZipEntrySource.WriteDelegate)
				{
					this._WriteDelegate(this.FileName, crcCalculatorStream);
				}
				else
				{
					byte[] array = new byte[this.BufferSize];
					int count;
					while ((count = global::Ionic.Zip.SharedUtilities.ReadWithRetry(stream, array, 0, array.Length, this.FileName)) != 0)
					{
						crcCalculatorStream.Write(array, 0, count);
						this.OnWriteBlock(crcCalculatorStream.TotalBytesSlurped, num);
						if (this._ioOperationCanceled)
						{
							break;
						}
					}
				}
				this.FinishOutputStream(s, countingStream, stream2, stream3, crcCalculatorStream);
			}
			finally
			{
				if (this._Source == global::Ionic.Zip.ZipEntrySource.JitStream)
				{
					if (this._CloseDelegate != null)
					{
						this._CloseDelegate(this.FileName, stream);
					}
				}
				else if (stream is global::System.IO.FileStream)
				{
					stream.Dispose();
				}
			}
			if (this._ioOperationCanceled)
			{
				return;
			}
			this.__FileDataPosition = _FileDataPosition;
			this.PostProcessOutput(s);
		}

		// Token: 0x060030FA RID: 12538 RVA: 0x000B0830 File Offset: 0x000AEA30
		private long SetInputAndFigureFileLength(ref global::System.IO.Stream input)
		{
			long result = -1L;
			if (this._Source == global::Ionic.Zip.ZipEntrySource.Stream)
			{
				this.PrepSourceStream();
				input = this._sourceStream;
				try
				{
					return this._sourceStream.Length;
				}
				catch (global::System.NotSupportedException)
				{
					return result;
				}
			}
			if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				string password = (this._Encryption_FromZipFile == global::Ionic.Zip.EncryptionAlgorithm.None) ? null : (this._Password ?? this._container.Password);
				this._sourceStream = this.InternalOpenReader(password);
				this.PrepSourceStream();
				input = this._sourceStream;
				result = this._sourceStream.Length;
			}
			else
			{
				if (this._Source == global::Ionic.Zip.ZipEntrySource.JitStream)
				{
					if (this._sourceStream == null)
					{
						this._sourceStream = this._OpenDelegate(this.FileName);
					}
					this.PrepSourceStream();
					input = this._sourceStream;
					try
					{
						return this._sourceStream.Length;
					}
					catch (global::System.NotSupportedException)
					{
						return result;
					}
				}
				if (this._Source == global::Ionic.Zip.ZipEntrySource.FileSystem)
				{
					global::System.IO.FileShare fileShare = global::System.IO.FileShare.ReadWrite;
					fileShare |= global::System.IO.FileShare.Delete;
					input = global::System.IO.File.Open(this.LocalFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, fileShare);
					result = input.Length;
				}
			}
			return result;
		}

		// Token: 0x060030FB RID: 12539 RVA: 0x000B0970 File Offset: 0x000AEB70
		internal void FinishOutputStream(global::System.IO.Stream s, global::Ionic.Zip.CountingStream entryCounter, global::System.IO.Stream encryptor, global::System.IO.Stream compressor, global::Ionic.Crc.CrcCalculatorStream output)
		{
			if (output == null)
			{
				return;
			}
			output.Close();
			if (compressor is global::Ionic.Zlib.DeflateStream)
			{
				compressor.Close();
			}
			else if (compressor is global::Ionic.BZip2.BZip2OutputStream)
			{
				compressor.Close();
			}
			else if (compressor is global::Ionic.BZip2.ParallelBZip2OutputStream)
			{
				compressor.Close();
			}
			else if (compressor is global::Ionic.Zlib.ParallelDeflateOutputStream)
			{
				compressor.Close();
			}
			encryptor.Flush();
			encryptor.Close();
			this._LengthOfTrailer = 0;
			this._UncompressedSize = output.TotalBytesSlurped;
			global::Ionic.Zip.WinZipAesCipherStream winZipAesCipherStream = encryptor as global::Ionic.Zip.WinZipAesCipherStream;
			if (winZipAesCipherStream != null && this._UncompressedSize > 0L)
			{
				s.Write(winZipAesCipherStream.FinalAuthentication, 0, 10);
				this._LengthOfTrailer += 10;
			}
			this._CompressedFileDataSize = entryCounter.BytesWritten;
			this._CompressedSize = this._CompressedFileDataSize;
			this._Crc32 = output.Crc;
			this.StoreRelativeOffset();
		}

		// Token: 0x060030FC RID: 12540 RVA: 0x000B0A70 File Offset: 0x000AEC70
		internal void PostProcessOutput(global::System.IO.Stream s)
		{
			global::Ionic.Zip.CountingStream countingStream = s as global::Ionic.Zip.CountingStream;
			if (this._UncompressedSize == 0L && this._CompressedSize == 0L)
			{
				if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipOutputStream)
				{
					return;
				}
				if (this._Password != null)
				{
					int num = 0;
					if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
					{
						num = 12;
					}
					else if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
					{
						num = this._aesCrypto_forWrite._Salt.Length + this._aesCrypto_forWrite.GeneratedPV.Length;
					}
					if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipOutputStream && !s.CanSeek)
					{
						throw new global::Ionic.Zip.ZipException("Zero bytes written, encryption in use, and non-seekable output.");
					}
					if (this.Encryption != global::Ionic.Zip.EncryptionAlgorithm.None)
					{
						s.Seek((long)(-1 * num), global::System.IO.SeekOrigin.Current);
						s.SetLength(s.Position);
						if (countingStream != null)
						{
							countingStream.Adjust((long)num);
						}
						this._LengthOfHeader -= num;
						this.__FileDataPosition -= (long)num;
					}
					this._Password = null;
					this._BitField &= -2;
					int num2 = 6;
					this._EntryHeader[num2++] = (byte)(this._BitField & 255);
					this._EntryHeader[num2++] = (byte)(((int)this._BitField & 65280) >> 8);
					if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
					{
						short num3 = (short)((int)this._EntryHeader[26] + (int)this._EntryHeader[27] * 256);
						int offx = (int)(30 + num3);
						int num4 = global::Ionic.Zip.ZipEntry.FindExtraFieldSegment(this._EntryHeader, offx, 39169);
						if (num4 >= 0)
						{
							this._EntryHeader[num4++] = 153;
							this._EntryHeader[num4++] = 153;
						}
					}
				}
				this.CompressionMethod = global::Ionic.Zip.CompressionMethod.None;
				this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
			}
			else if (this._zipCrypto_forWrite != null || this._aesCrypto_forWrite != null)
			{
				if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
				{
					this._CompressedSize += 12L;
				}
				else if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
				{
					this._CompressedSize += (long)this._aesCrypto_forWrite.SizeOfEncryptionMetadata;
				}
			}
			int num5 = 8;
			this._EntryHeader[num5++] = (byte)(this._CompressionMethod & 255);
			this._EntryHeader[num5++] = (byte)(((int)this._CompressionMethod & 65280) >> 8);
			num5 = 14;
			this._EntryHeader[num5++] = (byte)(this._Crc32 & 255);
			this._EntryHeader[num5++] = (byte)((this._Crc32 & 65280) >> 8);
			this._EntryHeader[num5++] = (byte)((this._Crc32 & 16711680) >> 16);
			this._EntryHeader[num5++] = (byte)(((long)this._Crc32 & (long)((ulong)-16777216)) >> 24);
			this.SetZip64Flags();
			short num6 = (short)((int)this._EntryHeader[26] + (int)this._EntryHeader[27] * 256);
			short num7 = (short)((int)this._EntryHeader[28] + (int)this._EntryHeader[29] * 256);
			if (this._OutputUsesZip64.Value)
			{
				this._EntryHeader[4] = 45;
				this._EntryHeader[5] = 0;
				for (int i = 0; i < 8; i++)
				{
					this._EntryHeader[num5++] = byte.MaxValue;
				}
				num5 = (int)(30 + num6);
				this._EntryHeader[num5++] = 1;
				this._EntryHeader[num5++] = 0;
				num5 += 2;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._UncompressedSize), 0, this._EntryHeader, num5, 8);
				num5 += 8;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._CompressedSize), 0, this._EntryHeader, num5, 8);
			}
			else
			{
				this._EntryHeader[4] = 20;
				this._EntryHeader[5] = 0;
				num5 = 18;
				this._EntryHeader[num5++] = (byte)(this._CompressedSize & 255L);
				this._EntryHeader[num5++] = (byte)((this._CompressedSize & 65280L) >> 8);
				this._EntryHeader[num5++] = (byte)((this._CompressedSize & 16711680L) >> 16);
				this._EntryHeader[num5++] = (byte)((this._CompressedSize & (long)((ulong)-16777216)) >> 24);
				this._EntryHeader[num5++] = (byte)(this._UncompressedSize & 255L);
				this._EntryHeader[num5++] = (byte)((this._UncompressedSize & 65280L) >> 8);
				this._EntryHeader[num5++] = (byte)((this._UncompressedSize & 16711680L) >> 16);
				this._EntryHeader[num5++] = (byte)((this._UncompressedSize & (long)((ulong)-16777216)) >> 24);
				if (num7 != 0)
				{
					num5 = (int)(30 + num6);
					if ((short)((int)this._EntryHeader[num5 + 2] + (int)this._EntryHeader[num5 + 3] * 256) == 16)
					{
						this._EntryHeader[num5++] = 153;
						this._EntryHeader[num5++] = 153;
					}
				}
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				num5 = 8;
				this._EntryHeader[num5++] = 99;
				this._EntryHeader[num5++] = 0;
				num5 = (int)(30 + num6);
				do
				{
					int num8 = (int)((ushort)((int)this._EntryHeader[num5] + (int)this._EntryHeader[num5 + 1] * 256));
					short num9 = (short)((int)this._EntryHeader[num5 + 2] + (int)this._EntryHeader[num5 + 3] * 256);
					if (num8 != 39169)
					{
						num5 += (int)(num9 + 4);
					}
					else
					{
						num5 += 9;
						this._EntryHeader[num5++] = (byte)(this._CompressionMethod & 255);
						this._EntryHeader[num5++] = (byte)((int)this._CompressionMethod & 65280);
					}
				}
				while (num5 < (int)(num7 - 30 - num6));
			}
			if ((this._BitField & 8) != 8 || (this._Source == global::Ionic.Zip.ZipEntrySource.ZipOutputStream && s.CanSeek))
			{
				global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = s as global::Ionic.Zip.ZipSegmentedStream;
				if (zipSegmentedStream != null && this._diskNumber != zipSegmentedStream.CurrentSegment)
				{
					using (global::System.IO.Stream stream = global::Ionic.Zip.ZipSegmentedStream.ForUpdate(this._container.ZipFile.Name, this._diskNumber))
					{
						stream.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
						stream.Write(this._EntryHeader, 0, this._EntryHeader.Length);
						goto IL_6FB;
					}
				}
				s.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
				s.Write(this._EntryHeader, 0, this._EntryHeader.Length);
				if (countingStream != null)
				{
					countingStream.Adjust((long)this._EntryHeader.Length);
				}
				s.Seek(this._CompressedSize, global::System.IO.SeekOrigin.Current);
			}
			IL_6FB:
			if ((this._BitField & 8) == 8 && !this.IsDirectory)
			{
				byte[] array = new byte[16 + (this._OutputUsesZip64.Value ? 8 : 0)];
				num5 = 0;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(134695760), 0, array, num5, 4);
				num5 += 4;
				global::System.Array.Copy(global::System.BitConverter.GetBytes(this._Crc32), 0, array, num5, 4);
				num5 += 4;
				if (this._OutputUsesZip64.Value)
				{
					global::System.Array.Copy(global::System.BitConverter.GetBytes(this._CompressedSize), 0, array, num5, 8);
					num5 += 8;
					global::System.Array.Copy(global::System.BitConverter.GetBytes(this._UncompressedSize), 0, array, num5, 8);
					num5 += 8;
				}
				else
				{
					array[num5++] = (byte)(this._CompressedSize & 255L);
					array[num5++] = (byte)((this._CompressedSize & 65280L) >> 8);
					array[num5++] = (byte)((this._CompressedSize & 16711680L) >> 16);
					array[num5++] = (byte)((this._CompressedSize & (long)((ulong)-16777216)) >> 24);
					array[num5++] = (byte)(this._UncompressedSize & 255L);
					array[num5++] = (byte)((this._UncompressedSize & 65280L) >> 8);
					array[num5++] = (byte)((this._UncompressedSize & 16711680L) >> 16);
					array[num5++] = (byte)((this._UncompressedSize & (long)((ulong)-16777216)) >> 24);
				}
				s.Write(array, 0, array.Length);
				this._LengthOfTrailer += array.Length;
			}
		}

		// Token: 0x060030FD RID: 12541 RVA: 0x000B1338 File Offset: 0x000AF538
		private void SetZip64Flags()
		{
			this._entryRequiresZip64 = new bool?(this._CompressedSize >= (long)((ulong)-1) || this._UncompressedSize >= (long)((ulong)-1) || this._RelativeOffsetOfLocalHeader >= (long)((ulong)-1));
			if (this._container.Zip64 == global::Ionic.Zip.Zip64Option.Default && this._entryRequiresZip64.Value)
			{
				throw new global::Ionic.Zip.ZipException("Compressed or Uncompressed size, or offset exceeds the maximum value. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			this._OutputUsesZip64 = new bool?(this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || this._entryRequiresZip64.Value);
		}

		// Token: 0x060030FE RID: 12542 RVA: 0x000B13DC File Offset: 0x000AF5DC
		internal void PrepOutputStream(global::System.IO.Stream s, long streamLength, out global::Ionic.Zip.CountingStream outputCounter, out global::System.IO.Stream encryptor, out global::System.IO.Stream compressor, out global::Ionic.Crc.CrcCalculatorStream output)
		{
			outputCounter = new global::Ionic.Zip.CountingStream(s);
			if (streamLength != 0L)
			{
				encryptor = this.MaybeApplyEncryption(outputCounter);
				compressor = this.MaybeApplyCompression(encryptor, streamLength);
			}
			else
			{
				global::System.IO.Stream stream;
				compressor = (stream = outputCounter);
				encryptor = stream;
			}
			output = new global::Ionic.Crc.CrcCalculatorStream(compressor, true);
		}

		// Token: 0x060030FF RID: 12543 RVA: 0x000B1430 File Offset: 0x000AF630
		private global::System.IO.Stream MaybeApplyCompression(global::System.IO.Stream s, long streamLength)
		{
			if (this._CompressionMethod == 8 && this.CompressionLevel != global::Ionic.Zlib.CompressionLevel.None)
			{
				if (this._container.ParallelDeflateThreshold == 0L || (streamLength > this._container.ParallelDeflateThreshold && this._container.ParallelDeflateThreshold > 0L))
				{
					if (this._container.ParallelDeflater == null)
					{
						this._container.ParallelDeflater = new global::Ionic.Zlib.ParallelDeflateOutputStream(s, this.CompressionLevel, this._container.Strategy, true);
						if (this._container.CodecBufferSize > 0)
						{
							this._container.ParallelDeflater.BufferSize = this._container.CodecBufferSize;
						}
						if (this._container.ParallelDeflateMaxBufferPairs > 0)
						{
							this._container.ParallelDeflater.MaxBufferPairs = this._container.ParallelDeflateMaxBufferPairs;
						}
					}
					global::Ionic.Zlib.ParallelDeflateOutputStream parallelDeflater = this._container.ParallelDeflater;
					parallelDeflater.Reset(s);
					return parallelDeflater;
				}
				global::Ionic.Zlib.DeflateStream deflateStream = new global::Ionic.Zlib.DeflateStream(s, global::Ionic.Zlib.CompressionMode.Compress, this.CompressionLevel, true);
				if (this._container.CodecBufferSize > 0)
				{
					deflateStream.BufferSize = this._container.CodecBufferSize;
				}
				deflateStream.Strategy = this._container.Strategy;
				return deflateStream;
			}
			else
			{
				if (this._CompressionMethod != 12)
				{
					return s;
				}
				if (this._container.ParallelDeflateThreshold == 0L || (streamLength > this._container.ParallelDeflateThreshold && this._container.ParallelDeflateThreshold > 0L))
				{
					return new global::Ionic.BZip2.ParallelBZip2OutputStream(s, true);
				}
				return new global::Ionic.BZip2.BZip2OutputStream(s, true);
			}
		}

		// Token: 0x06003100 RID: 12544 RVA: 0x000B15C0 File Offset: 0x000AF7C0
		private global::System.IO.Stream MaybeApplyEncryption(global::System.IO.Stream s)
		{
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
			{
				return new global::Ionic.Zip.ZipCipherStream(s, this._zipCrypto_forWrite, global::Ionic.Zip.CryptoMode.Encrypt);
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				return new global::Ionic.Zip.WinZipAesCipherStream(s, this._aesCrypto_forWrite, global::Ionic.Zip.CryptoMode.Encrypt);
			}
			return s;
		}

		// Token: 0x06003101 RID: 12545 RVA: 0x000B1614 File Offset: 0x000AF814
		private void OnZipErrorWhileSaving(global::System.Exception e)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnZipErrorSaving(this, e);
			}
		}

		// Token: 0x06003102 RID: 12546 RVA: 0x000B1640 File Offset: 0x000AF840
		internal void Write(global::System.IO.Stream s)
		{
			global::Ionic.Zip.CountingStream countingStream = s as global::Ionic.Zip.CountingStream;
			global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = s as global::Ionic.Zip.ZipSegmentedStream;
			bool flag = false;
			do
			{
				try
				{
					if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipFile && !this._restreamRequiredOnSave)
					{
						this.CopyThroughOneEntry(s);
						break;
					}
					if (this.IsDirectory)
					{
						this.WriteHeader(s, 1);
						this.StoreRelativeOffset();
						this._entryRequiresZip64 = new bool?(this._RelativeOffsetOfLocalHeader >= (long)((ulong)-1));
						this._OutputUsesZip64 = new bool?(this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || this._entryRequiresZip64.Value);
						if (zipSegmentedStream != null)
						{
							this._diskNumber = zipSegmentedStream.CurrentSegment;
						}
						break;
					}
					int num = 0;
					bool flag2;
					do
					{
						num++;
						this.WriteHeader(s, num);
						this.WriteSecurityMetadata(s);
						this._WriteEntryData(s);
						this._TotalEntrySize = (long)this._LengthOfHeader + this._CompressedFileDataSize + (long)this._LengthOfTrailer;
						flag2 = (num <= 1 && s.CanSeek && this.WantReadAgain());
						if (flag2)
						{
							if (zipSegmentedStream != null)
							{
								zipSegmentedStream.TruncateBackward(this._diskNumber, this._RelativeOffsetOfLocalHeader);
							}
							else
							{
								s.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
							}
							s.SetLength(s.Position);
							if (countingStream != null)
							{
								countingStream.Adjust(this._TotalEntrySize);
							}
						}
					}
					while (flag2);
					this._skippedDuringSave = false;
					flag = true;
				}
				catch (global::System.Exception ex)
				{
					global::Ionic.Zip.ZipErrorAction zipErrorAction = this.ZipErrorAction;
					int num2 = 0;
					while (this.ZipErrorAction != global::Ionic.Zip.ZipErrorAction.Throw)
					{
						if (this.ZipErrorAction == global::Ionic.Zip.ZipErrorAction.Skip || this.ZipErrorAction == global::Ionic.Zip.ZipErrorAction.Retry)
						{
							long num3 = (countingStream != null) ? countingStream.ComputedPosition : s.Position;
							long num4 = num3 - this._future_ROLH;
							if (num4 > 0L)
							{
								s.Seek(num4, global::System.IO.SeekOrigin.Current);
								long position = s.Position;
								s.SetLength(s.Position);
								if (countingStream != null)
								{
									countingStream.Adjust(num3 - position);
								}
							}
							if (this.ZipErrorAction == global::Ionic.Zip.ZipErrorAction.Skip)
							{
								this.WriteStatus("Skipping file {0} (exception: {1})", new object[]
								{
									this.LocalFileName,
									ex.ToString()
								});
								this._skippedDuringSave = true;
								flag = true;
							}
							else
							{
								this.ZipErrorAction = zipErrorAction;
							}
						}
						else
						{
							if (num2 > 0)
							{
								throw;
							}
							if (this.ZipErrorAction == global::Ionic.Zip.ZipErrorAction.InvokeErrorEvent)
							{
								this.OnZipErrorWhileSaving(ex);
								if (this._ioOperationCanceled)
								{
									flag = true;
									goto IL_287;
								}
							}
							num2++;
							continue;
						}
						IL_287:
						goto IL_28C;
					}
					throw;
				}
				IL_28C:;
			}
			while (!flag);
		}

		// Token: 0x06003103 RID: 12547 RVA: 0x000B18FC File Offset: 0x000AFAFC
		internal void StoreRelativeOffset()
		{
			this._RelativeOffsetOfLocalHeader = this._future_ROLH;
		}

		// Token: 0x06003104 RID: 12548 RVA: 0x000B190C File Offset: 0x000AFB0C
		internal void NotifySaveComplete()
		{
			this._Encryption_FromZipFile = this._Encryption;
			this._CompressionMethod_FromZipFile = this._CompressionMethod;
			this._restreamRequiredOnSave = false;
			this._metadataChanged = false;
			this._Source = global::Ionic.Zip.ZipEntrySource.ZipFile;
		}

		// Token: 0x06003105 RID: 12549 RVA: 0x000B193C File Offset: 0x000AFB3C
		internal void WriteSecurityMetadata(global::System.IO.Stream outstream)
		{
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				return;
			}
			string password = this._Password;
			if (this._Source == global::Ionic.Zip.ZipEntrySource.ZipFile && password == null)
			{
				password = this._container.Password;
			}
			if (password == null)
			{
				this._zipCrypto_forWrite = null;
				this._aesCrypto_forWrite = null;
				return;
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak)
			{
				this._zipCrypto_forWrite = global::Ionic.Zip.ZipCrypto.ForWrite(password);
				global::System.Random random = new global::System.Random();
				byte[] array = new byte[12];
				random.NextBytes(array);
				if ((this._BitField & 8) == 8)
				{
					this._TimeBlob = global::Ionic.Zip.SharedUtilities.DateTimeToPacked(this.LastModified);
					array[11] = (byte)(this._TimeBlob >> 8 & 255);
				}
				else
				{
					this.FigureCrc32();
					array[11] = (byte)(this._Crc32 >> 24 & 255);
				}
				byte[] array2 = this._zipCrypto_forWrite.EncryptMessage(array, array.Length);
				outstream.Write(array2, 0, array2.Length);
				this._LengthOfHeader += array2.Length;
				return;
			}
			if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				int keyStrengthInBits = global::Ionic.Zip.ZipEntry.GetKeyStrengthInBits(this.Encryption);
				this._aesCrypto_forWrite = global::Ionic.Zip.WinZipAesCrypto.Generate(password, keyStrengthInBits);
				outstream.Write(this._aesCrypto_forWrite.Salt, 0, this._aesCrypto_forWrite._Salt.Length);
				outstream.Write(this._aesCrypto_forWrite.GeneratedPV, 0, this._aesCrypto_forWrite.GeneratedPV.Length);
				this._LengthOfHeader += this._aesCrypto_forWrite._Salt.Length + this._aesCrypto_forWrite.GeneratedPV.Length;
			}
		}

		// Token: 0x06003106 RID: 12550 RVA: 0x000B1AD4 File Offset: 0x000AFCD4
		private void CopyThroughOneEntry(global::System.IO.Stream outStream)
		{
			if (this.LengthOfHeader == 0)
			{
				throw new global::Ionic.Zip.BadStateException("Bad header length.");
			}
			if (this._metadataChanged || this.ArchiveStream is global::Ionic.Zip.ZipSegmentedStream || outStream is global::Ionic.Zip.ZipSegmentedStream || (this._InputUsesZip64 && this._container.UseZip64WhenSaving == global::Ionic.Zip.Zip64Option.Default) || (!this._InputUsesZip64 && this._container.UseZip64WhenSaving == global::Ionic.Zip.Zip64Option.Always))
			{
				this.CopyThroughWithRecompute(outStream);
			}
			else
			{
				this.CopyThroughWithNoChange(outStream);
			}
			this._entryRequiresZip64 = new bool?(this._CompressedSize >= (long)((ulong)-1) || this._UncompressedSize >= (long)((ulong)-1) || this._RelativeOffsetOfLocalHeader >= (long)((ulong)-1));
			this._OutputUsesZip64 = new bool?(this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || this._entryRequiresZip64.Value);
		}

		// Token: 0x06003107 RID: 12551 RVA: 0x000B1BE0 File Offset: 0x000AFDE0
		private void CopyThroughWithRecompute(global::System.IO.Stream outstream)
		{
			byte[] array = new byte[this.BufferSize];
			global::Ionic.Zip.CountingStream countingStream = new global::Ionic.Zip.CountingStream(this.ArchiveStream);
			long relativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader;
			int lengthOfHeader = this.LengthOfHeader;
			this.WriteHeader(outstream, 0);
			this.StoreRelativeOffset();
			if (!this.FileName.EndsWith("/"))
			{
				long num = relativeOffsetOfLocalHeader + (long)lengthOfHeader;
				int num2 = global::Ionic.Zip.ZipEntry.GetLengthOfCryptoHeaderBytes(this._Encryption_FromZipFile);
				num -= (long)num2;
				this._LengthOfHeader += num2;
				countingStream.Seek(num, global::System.IO.SeekOrigin.Begin);
				long num3 = this._CompressedSize;
				while (num3 > 0L)
				{
					num2 = ((num3 > (long)array.Length) ? array.Length : ((int)num3));
					int num4 = countingStream.Read(array, 0, num2);
					outstream.Write(array, 0, num4);
					num3 -= (long)num4;
					this.OnWriteBlock(countingStream.BytesRead, this._CompressedSize);
					if (this._ioOperationCanceled)
					{
						break;
					}
				}
				if ((this._BitField & 8) == 8)
				{
					int num5 = 16;
					if (this._InputUsesZip64)
					{
						num5 += 8;
					}
					byte[] buffer = new byte[num5];
					countingStream.Read(buffer, 0, num5);
					if (this._InputUsesZip64 && this._container.UseZip64WhenSaving == global::Ionic.Zip.Zip64Option.Default)
					{
						outstream.Write(buffer, 0, 8);
						if (this._CompressedSize > (long)((ulong)-1))
						{
							throw new global::System.InvalidOperationException("ZIP64 is required");
						}
						outstream.Write(buffer, 8, 4);
						if (this._UncompressedSize > (long)((ulong)-1))
						{
							throw new global::System.InvalidOperationException("ZIP64 is required");
						}
						outstream.Write(buffer, 16, 4);
						this._LengthOfTrailer -= 8;
					}
					else if (!this._InputUsesZip64 && this._container.UseZip64WhenSaving == global::Ionic.Zip.Zip64Option.Always)
					{
						byte[] buffer2 = new byte[4];
						outstream.Write(buffer, 0, 8);
						outstream.Write(buffer, 8, 4);
						outstream.Write(buffer2, 0, 4);
						outstream.Write(buffer, 12, 4);
						outstream.Write(buffer2, 0, 4);
						this._LengthOfTrailer += 8;
					}
					else
					{
						outstream.Write(buffer, 0, num5);
					}
				}
			}
			this._TotalEntrySize = (long)this._LengthOfHeader + this._CompressedFileDataSize + (long)this._LengthOfTrailer;
		}

		// Token: 0x06003108 RID: 12552 RVA: 0x000B1E1C File Offset: 0x000B001C
		private void CopyThroughWithNoChange(global::System.IO.Stream outstream)
		{
			byte[] array = new byte[this.BufferSize];
			global::Ionic.Zip.CountingStream countingStream = new global::Ionic.Zip.CountingStream(this.ArchiveStream);
			countingStream.Seek(this._RelativeOffsetOfLocalHeader, global::System.IO.SeekOrigin.Begin);
			if (this._TotalEntrySize == 0L)
			{
				this._TotalEntrySize = (long)this._LengthOfHeader + this._CompressedFileDataSize + (long)this._LengthOfTrailer;
			}
			global::Ionic.Zip.CountingStream countingStream2 = outstream as global::Ionic.Zip.CountingStream;
			this._RelativeOffsetOfLocalHeader = ((countingStream2 != null) ? countingStream2.ComputedPosition : outstream.Position);
			long num = this._TotalEntrySize;
			while (num > 0L)
			{
				int count = (num > (long)array.Length) ? array.Length : ((int)num);
				int num2 = countingStream.Read(array, 0, count);
				outstream.Write(array, 0, num2);
				num -= (long)num2;
				this.OnWriteBlock(countingStream.BytesRead, this._TotalEntrySize);
				if (this._ioOperationCanceled)
				{
					break;
				}
			}
		}

		// Token: 0x06003109 RID: 12553 RVA: 0x000B1F00 File Offset: 0x000B0100
		[global::System.Diagnostics.Conditional("Trace")]
		private void TraceWriteLine(string format, params object[] varParams)
		{
			object outputLock = this._outputLock;
			lock (outputLock)
			{
				int hashCode = global::System.Threading.Thread.CurrentThread.GetHashCode();
				global::System.Console.ForegroundColor = hashCode % 8 + global::System.ConsoleColor.DarkGray;
				global::System.Console.Write("{0:000} ZipEntry.Write ", hashCode);
				global::System.Console.WriteLine(format, varParams);
				global::System.Console.ResetColor();
			}
		}

		// Token: 0x040011BB RID: 4539
		private short _VersionMadeBy;

		// Token: 0x040011BC RID: 4540
		private short _InternalFileAttrs;

		// Token: 0x040011BD RID: 4541
		private int _ExternalFileAttrs;

		// Token: 0x040011BE RID: 4542
		private short _filenameLength;

		// Token: 0x040011BF RID: 4543
		private short _extraFieldLength;

		// Token: 0x040011C0 RID: 4544
		private short _commentLength;

		// Token: 0x040011C7 RID: 4551
		private global::Ionic.Zip.ZipCrypto _zipCrypto_forExtract;

		// Token: 0x040011C8 RID: 4552
		private global::Ionic.Zip.ZipCrypto _zipCrypto_forWrite;

		// Token: 0x040011C9 RID: 4553
		private global::Ionic.Zip.WinZipAesCrypto _aesCrypto_forExtract;

		// Token: 0x040011CA RID: 4554
		private global::Ionic.Zip.WinZipAesCrypto _aesCrypto_forWrite;

		// Token: 0x040011CB RID: 4555
		private short _WinZipAesMethod;

		// Token: 0x040011CC RID: 4556
		internal global::System.DateTime _LastModified;

		// Token: 0x040011CD RID: 4557
		private global::System.DateTime _Mtime;

		// Token: 0x040011CE RID: 4558
		private global::System.DateTime _Atime;

		// Token: 0x040011CF RID: 4559
		private global::System.DateTime _Ctime;

		// Token: 0x040011D0 RID: 4560
		private bool _ntfsTimesAreSet;

		// Token: 0x040011D1 RID: 4561
		private bool _emitNtfsTimes = true;

		// Token: 0x040011D2 RID: 4562
		private bool _emitUnixTimes;

		// Token: 0x040011D3 RID: 4563
		private bool _TrimVolumeFromFullyQualifiedPaths = true;

		// Token: 0x040011D4 RID: 4564
		internal string _LocalFileName;

		// Token: 0x040011D5 RID: 4565
		private string _FileNameInArchive;

		// Token: 0x040011D6 RID: 4566
		internal short _VersionNeeded;

		// Token: 0x040011D7 RID: 4567
		internal short _BitField;

		// Token: 0x040011D8 RID: 4568
		internal short _CompressionMethod;

		// Token: 0x040011D9 RID: 4569
		private short _CompressionMethod_FromZipFile;

		// Token: 0x040011DA RID: 4570
		private global::Ionic.Zlib.CompressionLevel _CompressionLevel;

		// Token: 0x040011DB RID: 4571
		internal string _Comment;

		// Token: 0x040011DC RID: 4572
		private bool _IsDirectory;

		// Token: 0x040011DD RID: 4573
		private byte[] _CommentBytes;

		// Token: 0x040011DE RID: 4574
		internal long _CompressedSize;

		// Token: 0x040011DF RID: 4575
		internal long _CompressedFileDataSize;

		// Token: 0x040011E0 RID: 4576
		internal long _UncompressedSize;

		// Token: 0x040011E1 RID: 4577
		internal int _TimeBlob;

		// Token: 0x040011E2 RID: 4578
		private bool _crcCalculated;

		// Token: 0x040011E3 RID: 4579
		internal int _Crc32;

		// Token: 0x040011E4 RID: 4580
		internal byte[] _Extra;

		// Token: 0x040011E5 RID: 4581
		private bool _metadataChanged;

		// Token: 0x040011E6 RID: 4582
		private bool _restreamRequiredOnSave;

		// Token: 0x040011E7 RID: 4583
		private bool _sourceIsEncrypted;

		// Token: 0x040011E8 RID: 4584
		private bool _skippedDuringSave;

		// Token: 0x040011E9 RID: 4585
		private uint _diskNumber;

		// Token: 0x040011EA RID: 4586
		private static global::System.Text.Encoding ibm437 = global::System.Text.Encoding.GetEncoding("IBM437");

		// Token: 0x040011EB RID: 4587
		private global::System.Text.Encoding _actualEncoding;

		// Token: 0x040011EC RID: 4588
		internal global::Ionic.Zip.ZipContainer _container;

		// Token: 0x040011ED RID: 4589
		private long __FileDataPosition = -1L;

		// Token: 0x040011EE RID: 4590
		private byte[] _EntryHeader;

		// Token: 0x040011EF RID: 4591
		internal long _RelativeOffsetOfLocalHeader;

		// Token: 0x040011F0 RID: 4592
		private long _future_ROLH;

		// Token: 0x040011F1 RID: 4593
		private long _TotalEntrySize;

		// Token: 0x040011F2 RID: 4594
		private int _LengthOfHeader;

		// Token: 0x040011F3 RID: 4595
		private int _LengthOfTrailer;

		// Token: 0x040011F4 RID: 4596
		internal bool _InputUsesZip64;

		// Token: 0x040011F5 RID: 4597
		private uint _UnsupportedAlgorithmId;

		// Token: 0x040011F6 RID: 4598
		internal string _Password;

		// Token: 0x040011F7 RID: 4599
		internal global::Ionic.Zip.ZipEntrySource _Source;

		// Token: 0x040011F8 RID: 4600
		internal global::Ionic.Zip.EncryptionAlgorithm _Encryption;

		// Token: 0x040011F9 RID: 4601
		internal global::Ionic.Zip.EncryptionAlgorithm _Encryption_FromZipFile;

		// Token: 0x040011FA RID: 4602
		internal byte[] _WeakEncryptionHeader;

		// Token: 0x040011FB RID: 4603
		internal global::System.IO.Stream _archiveStream;

		// Token: 0x040011FC RID: 4604
		private global::System.IO.Stream _sourceStream;

		// Token: 0x040011FD RID: 4605
		private long? _sourceStreamOriginalPosition;

		// Token: 0x040011FE RID: 4606
		private bool _sourceWasJitProvided;

		// Token: 0x040011FF RID: 4607
		private bool _ioOperationCanceled;

		// Token: 0x04001200 RID: 4608
		private bool _presumeZip64;

		// Token: 0x04001201 RID: 4609
		private bool? _entryRequiresZip64;

		// Token: 0x04001202 RID: 4610
		private bool? _OutputUsesZip64;

		// Token: 0x04001203 RID: 4611
		private bool _IsText;

		// Token: 0x04001204 RID: 4612
		private global::Ionic.Zip.ZipEntryTimestamp _timestamp;

		// Token: 0x04001205 RID: 4613
		private static global::System.DateTime _unixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04001206 RID: 4614
		private static global::System.DateTime _win32Epoch = global::System.DateTime.FromFileTimeUtc(0L);

		// Token: 0x04001207 RID: 4615
		private static global::System.DateTime _zeroHour = new global::System.DateTime(1, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04001208 RID: 4616
		private global::Ionic.Zip.WriteDelegate _WriteDelegate;

		// Token: 0x04001209 RID: 4617
		private global::Ionic.Zip.OpenDelegate _OpenDelegate;

		// Token: 0x0400120A RID: 4618
		private global::Ionic.Zip.CloseDelegate _CloseDelegate;

		// Token: 0x0400120B RID: 4619
		private global::System.IO.Stream _inputDecryptorStream;

		// Token: 0x0400120C RID: 4620
		private int _readExtraDepth;

		// Token: 0x0400120D RID: 4621
		private object _outputLock = new object();

		// Token: 0x020004E6 RID: 1254
		private class CopyHelper
		{
			// Token: 0x0600347F RID: 13439 RVA: 0x000BCD70 File Offset: 0x000BAF70
			internal static string AppendCopyToFileName(string f)
			{
				global::Ionic.Zip.ZipEntry.CopyHelper.callCount++;
				if (global::Ionic.Zip.ZipEntry.CopyHelper.callCount > 25)
				{
					throw new global::System.OverflowException("overflow while creating filename");
				}
				int num = 1;
				int num2 = f.LastIndexOf(".");
				if (num2 == -1)
				{
					global::System.Text.RegularExpressions.Match match = global::Ionic.Zip.ZipEntry.CopyHelper.re.Match(f);
					if (match.Success)
					{
						num = int.Parse(match.Groups[1].Value) + 1;
						string str = string.Format(" (copy {0})", num);
						f = f.Substring(0, match.Index) + str;
					}
					else
					{
						string str2 = string.Format(" (copy {0})", num);
						f += str2;
					}
				}
				else
				{
					global::System.Text.RegularExpressions.Match match2 = global::Ionic.Zip.ZipEntry.CopyHelper.re.Match(f.Substring(0, num2));
					if (match2.Success)
					{
						num = int.Parse(match2.Groups[1].Value) + 1;
						string str3 = string.Format(" (copy {0})", num);
						f = f.Substring(0, match2.Index) + str3 + f.Substring(num2);
					}
					else
					{
						string str4 = string.Format(" (copy {0})", num);
						f = f.Substring(0, num2) + str4 + f.Substring(num2);
					}
				}
				return f;
			}

			// Token: 0x04001460 RID: 5216
			private static global::System.Text.RegularExpressions.Regex re = new global::System.Text.RegularExpressions.Regex(" \\(copy (\\d+)\\)$");

			// Token: 0x04001461 RID: 5217
			private static int callCount = 0;
		}

		// Token: 0x020004E7 RID: 1255
		// (Invoke) Token: 0x06003483 RID: 13443
		private delegate T Func<T>();
	}
}
