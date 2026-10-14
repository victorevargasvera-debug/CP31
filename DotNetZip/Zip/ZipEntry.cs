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
using Ionic.Zip.Deflate64;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x0200004B RID: 75
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	public class ZipEntry
	{
		// Token: 0x170000B6 RID: 182
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00013177 File Offset: 0x00011377
		internal bool AttributesIndicateDirectory
		{
			get
			{
				return this._InternalFileAttrs == 0 && (this._ExternalFileAttrs & 16) == 16;
			}
		}

		// Token: 0x06000343 RID: 835 RVA: 0x00013190 File Offset: 0x00011390
		internal void ResetDirEntry()
		{
			this.__FileDataPosition = -1L;
			this._LengthOfHeader = 0;
			global::Ionic.Zip.ZipEntry.CopyHelper.Reset();
		}

		// Token: 0x170000B7 RID: 183
		// (get) Token: 0x06000344 RID: 836 RVA: 0x000131A8 File Offset: 0x000113A8
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

		// Token: 0x06000345 RID: 837 RVA: 0x000133D0 File Offset: 0x000115D0
		internal static global::Ionic.Zip.ZipEntry ReadDirEntry(global::Ionic.Zip.ZipFile zf, global::System.Collections.Generic.Dictionary<string, object> previouslySeen)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			global::System.Text.Encoding encoding = (zf.AlternateEncodingUsage == global::Ionic.Zip.ZipOption.Always) ? zf.AlternateEncoding : global::Ionic.Zip.ZipFile.DefaultEncoding;
			int num;
			for (;;)
			{
				num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
				if (global::Ionic.Zip.ZipEntry.IsNotValidZipDirEntrySig(num))
				{
					break;
				}
				int num2 = 46;
				byte[] array = new byte[42];
				int num3 = readStream.Read(array, 0, array.Length);
				if (num3 != array.Length)
				{
					goto Block_6;
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
				while (!zf.IgnoreDuplicateFiles && previouslySeen.ContainsKey(zipEntry._FileNameInArchive))
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
				if (!zf.IgnoreDuplicateFiles || !previouslySeen.ContainsKey(zipEntry._FileNameInArchive))
				{
					return zipEntry;
				}
			}
			readStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
			if ((long)num != 101010256L && (long)num != 101075792L && num != 67324752)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Bad signature (0x{0:X8}) at position 0x{1:X8}", num, readStream.Position));
			}
			return null;
			Block_6:
			return null;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x00013A9A File Offset: 0x00011C9A
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			return signature != 33639248;
		}

		// Token: 0x06000347 RID: 839 RVA: 0x00013AA8 File Offset: 0x00011CA8
		public ZipEntry()
		{
			this._CompressionMethod = 8;
			this._CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
			this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
			this._Source = global::Ionic.Zip.ZipEntrySource.None;
			this.AlternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
		}

		// Token: 0x170000B8 RID: 184
		// (get) Token: 0x06000348 RID: 840 RVA: 0x00013B0F File Offset: 0x00011D0F
		// (set) Token: 0x06000349 RID: 841 RVA: 0x00013B1C File Offset: 0x00011D1C
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

		// Token: 0x170000B9 RID: 185
		// (get) Token: 0x0600034A RID: 842 RVA: 0x00013B68 File Offset: 0x00011D68
		// (set) Token: 0x0600034B RID: 843 RVA: 0x00013B70 File Offset: 0x00011D70
		public bool DontEmitLastModified
		{
			get
			{
				return this._dontEmitLastModified;
			}
			set
			{
				this._dontEmitLastModified = value;
			}
		}

		// Token: 0x170000BA RID: 186
		// (get) Token: 0x0600034C RID: 844 RVA: 0x00013B79 File Offset: 0x00011D79
		private int BufferSize
		{
			get
			{
				return this._container.BufferSize;
			}
		}

		// Token: 0x170000BB RID: 187
		// (get) Token: 0x0600034D RID: 845 RVA: 0x00013B86 File Offset: 0x00011D86
		// (set) Token: 0x0600034E RID: 846 RVA: 0x00013B8E File Offset: 0x00011D8E
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

		// Token: 0x170000BC RID: 188
		// (get) Token: 0x0600034F RID: 847 RVA: 0x00013BA3 File Offset: 0x00011DA3
		// (set) Token: 0x06000350 RID: 848 RVA: 0x00013BAB File Offset: 0x00011DAB
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

		// Token: 0x170000BD RID: 189
		// (get) Token: 0x06000351 RID: 849 RVA: 0x00013BC0 File Offset: 0x00011DC0
		// (set) Token: 0x06000352 RID: 850 RVA: 0x00013BC8 File Offset: 0x00011DC8
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

		// Token: 0x06000353 RID: 851 RVA: 0x00013BE0 File Offset: 0x00011DE0
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

		// Token: 0x170000BE RID: 190
		// (get) Token: 0x06000354 RID: 852 RVA: 0x00013CBA File Offset: 0x00011EBA
		// (set) Token: 0x06000355 RID: 853 RVA: 0x00013CC2 File Offset: 0x00011EC2
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

		// Token: 0x170000BF RID: 191
		// (get) Token: 0x06000356 RID: 854 RVA: 0x00013CD2 File Offset: 0x00011ED2
		// (set) Token: 0x06000357 RID: 855 RVA: 0x00013CDA File Offset: 0x00011EDA
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

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000358 RID: 856 RVA: 0x00013CEA File Offset: 0x00011EEA
		public global::Ionic.Zip.ZipEntryTimestamp Timestamp
		{
			get
			{
				return this._timestamp;
			}
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000359 RID: 857 RVA: 0x00013CF2 File Offset: 0x00011EF2
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00013CFA File Offset: 0x00011EFA
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

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x0600035B RID: 859 RVA: 0x00013D12 File Offset: 0x00011F12
		internal string LocalFileName
		{
			get
			{
				return this._LocalFileName;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600035C RID: 860 RVA: 0x00013D1A File Offset: 0x00011F1A
		// (set) Token: 0x0600035D RID: 861 RVA: 0x00013D24 File Offset: 0x00011F24
		public string FileName
		{
			get
			{
				return this._FileNameInArchive;
			}
			set
			{
				if (this._container != null && this._container.ZipFile == null)
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
				if (this._container != null)
				{
					this._container.ZipFile.RemoveEntry(this);
					this._container.ZipFile.InternalAddEntry(text, this);
				}
				this._FileNameInArchive = text;
				if (this._container != null)
				{
					this._container.ZipFile.NotifyEntryChanged();
				}
				this._metadataChanged = true;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600035E RID: 862 RVA: 0x00013DCC File Offset: 0x00011FCC
		// (set) Token: 0x0600035F RID: 863 RVA: 0x00013DD4 File Offset: 0x00011FD4
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

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x06000360 RID: 864 RVA: 0x00013DF8 File Offset: 0x00011FF8
		public bool InputStreamWasJitProvided
		{
			get
			{
				return this._sourceWasJitProvided;
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000361 RID: 865 RVA: 0x00013E00 File Offset: 0x00012000
		public global::Ionic.Zip.ZipEntrySource Source
		{
			get
			{
				return this._Source;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00013E08 File Offset: 0x00012008
		public short VersionNeeded
		{
			get
			{
				return this._VersionNeeded;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00013E10 File Offset: 0x00012010
		// (set) Token: 0x06000364 RID: 868 RVA: 0x00013E18 File Offset: 0x00012018
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

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000365 RID: 869 RVA: 0x00013E28 File Offset: 0x00012028
		public bool? RequiresZip64
		{
			get
			{
				return this._entryRequiresZip64;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000366 RID: 870 RVA: 0x00013E30 File Offset: 0x00012030
		public bool? OutputUsedZip64
		{
			get
			{
				return this._OutputUsesZip64;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000367 RID: 871 RVA: 0x00013E38 File Offset: 0x00012038
		public short BitField
		{
			get
			{
				return this._BitField;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x06000368 RID: 872 RVA: 0x00013E40 File Offset: 0x00012040
		// (set) Token: 0x06000369 RID: 873 RVA: 0x00013E48 File Offset: 0x00012048
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

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600036A RID: 874 RVA: 0x00013EC2 File Offset: 0x000120C2
		// (set) Token: 0x0600036B RID: 875 RVA: 0x00013ECC File Offset: 0x000120CC
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

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600036C RID: 876 RVA: 0x00013F48 File Offset: 0x00012148
		public long CompressedSize
		{
			get
			{
				return this._CompressedSize;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x0600036D RID: 877 RVA: 0x00013F50 File Offset: 0x00012150
		public long UncompressedSize
		{
			get
			{
				return this._UncompressedSize;
			}
		}

		// Token: 0x170000D0 RID: 208
		// (get) Token: 0x0600036E RID: 878 RVA: 0x00013F58 File Offset: 0x00012158
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

		// Token: 0x170000D1 RID: 209
		// (get) Token: 0x0600036F RID: 879 RVA: 0x00013FAE File Offset: 0x000121AE
		public int Crc
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x170000D2 RID: 210
		// (get) Token: 0x06000370 RID: 880 RVA: 0x00013FB6 File Offset: 0x000121B6
		public bool IsDirectory
		{
			get
			{
				return this._IsDirectory;
			}
		}

		// Token: 0x170000D3 RID: 211
		// (get) Token: 0x06000371 RID: 881 RVA: 0x00013FBE File Offset: 0x000121BE
		public bool UsesEncryption
		{
			get
			{
				return this._Encryption_FromZipFile > global::Ionic.Zip.EncryptionAlgorithm.None;
			}
		}

		// Token: 0x170000D4 RID: 212
		// (get) Token: 0x06000372 RID: 882 RVA: 0x00013FC9 File Offset: 0x000121C9
		// (set) Token: 0x06000373 RID: 883 RVA: 0x00013FD4 File Offset: 0x000121D4
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

		// Token: 0x170000D5 RID: 213
		// (get) Token: 0x06000375 RID: 885 RVA: 0x00014065 File Offset: 0x00012265
		// (set) Token: 0x06000374 RID: 884 RVA: 0x00014025 File Offset: 0x00012225
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

		// Token: 0x170000D6 RID: 214
		// (get) Token: 0x06000376 RID: 886 RVA: 0x0001406D File Offset: 0x0001226D
		internal bool IsChanged
		{
			get
			{
				return this._restreamRequiredOnSave | this._metadataChanged;
			}
		}

		// Token: 0x170000D7 RID: 215
		// (get) Token: 0x06000377 RID: 887 RVA: 0x0001407C File Offset: 0x0001227C
		// (set) Token: 0x06000378 RID: 888 RVA: 0x00014084 File Offset: 0x00012284
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x170000D8 RID: 216
		// (get) Token: 0x06000379 RID: 889 RVA: 0x0001408D File Offset: 0x0001228D
		// (set) Token: 0x0600037A RID: 890 RVA: 0x00014095 File Offset: 0x00012295
		public global::Ionic.Zip.ZipErrorAction ZipErrorAction { get; set; }

		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600037B RID: 891 RVA: 0x0001409E File Offset: 0x0001229E
		public bool IncludedInMostRecentSave
		{
			get
			{
				return !this._skippedDuringSave;
			}
		}

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600037C RID: 892 RVA: 0x000140A9 File Offset: 0x000122A9
		// (set) Token: 0x0600037D RID: 893 RVA: 0x000140B1 File Offset: 0x000122B1
		public global::Ionic.Zip.SetCompressionCallback SetCompression { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600037E RID: 894 RVA: 0x000140BA File Offset: 0x000122BA
		// (set) Token: 0x0600037F RID: 895 RVA: 0x000140D9 File Offset: 0x000122D9
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

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000380 RID: 896 RVA: 0x00014108 File Offset: 0x00012308
		// (set) Token: 0x06000381 RID: 897 RVA: 0x00014110 File Offset: 0x00012310
		[global::System.Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		public global::System.Text.Encoding ProvisionalAlternateEncoding { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000382 RID: 898 RVA: 0x00014119 File Offset: 0x00012319
		// (set) Token: 0x06000383 RID: 899 RVA: 0x00014121 File Offset: 0x00012321
		public global::System.Text.Encoding AlternateEncoding { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000384 RID: 900 RVA: 0x0001412A File Offset: 0x0001232A
		// (set) Token: 0x06000385 RID: 901 RVA: 0x00014132 File Offset: 0x00012332
		public global::Ionic.Zip.ZipOption AlternateEncodingUsage { get; set; }

		// Token: 0x06000386 RID: 902 RVA: 0x0001413C File Offset: 0x0001233C
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

		// Token: 0x06000387 RID: 903 RVA: 0x00014178 File Offset: 0x00012378
		internal static global::Ionic.Zip.ZipEntry CreateFromNothing(string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.None, null, null);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00014183 File Offset: 0x00012383
		internal static global::Ionic.Zip.ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.FileSystem, filename, null);
		}

		// Token: 0x06000389 RID: 905 RVA: 0x0001418E File Offset: 0x0001238E
		internal static global::Ionic.Zip.ZipEntry CreateForStream(string entryName, global::System.IO.Stream s)
		{
			return global::Ionic.Zip.ZipEntry.Create(entryName, global::Ionic.Zip.ZipEntrySource.Stream, s, null);
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00014199 File Offset: 0x00012399
		internal static global::Ionic.Zip.ZipEntry CreateForWriter(string entryName, global::Ionic.Zip.WriteDelegate d)
		{
			return global::Ionic.Zip.ZipEntry.Create(entryName, global::Ionic.Zip.ZipEntrySource.WriteDelegate, d, null);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x000141A4 File Offset: 0x000123A4
		internal static global::Ionic.Zip.ZipEntry CreateForJitStreamProvider(string nameInArchive, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.JitStream, opener, closer);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x000141AF File Offset: 0x000123AF
		internal static global::Ionic.Zip.ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			return global::Ionic.Zip.ZipEntry.Create(nameInArchive, global::Ionic.Zip.ZipEntrySource.ZipOutputStream, null, null);
		}

		// Token: 0x0600038D RID: 909 RVA: 0x000141BC File Offset: 0x000123BC
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

		// Token: 0x0600038E RID: 910 RVA: 0x00014334 File Offset: 0x00012534
		public global::Ionic.Zip.ZipEntry CloneForNewZipFile(global::Ionic.Zip.ZipFile newZipFile)
		{
			if (this.Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::System.InvalidOperationException("The entry you are trying to add wasn't loaded from a zip file.");
			}
			if (this.IsChanged)
			{
				throw new global::System.InvalidOperationException("The entry you are trying to add was modified.");
			}
			if (this.IsDirectory)
			{
				throw new global::System.InvalidOperationException("The entry you are trying to add is a directory.");
			}
			if (!this.CompressionMethod.Equals(newZipFile.CompressionMethod))
			{
				throw new global::System.InvalidOperationException("The entry you are trying to add uses another compression method.");
			}
			if (this.ArchiveStream is global::Ionic.Zip.ZipSegmentedStream)
			{
				throw new global::System.InvalidOperationException("The entry you are trying to add is from a multi-part zip.");
			}
			return new global::Ionic.Zip.ZipEntry
			{
				__FileDataPosition = this.__FileDataPosition,
				_actualEncoding = this._actualEncoding,
				_archiveStream = this._archiveStream,
				_Atime = this._Atime,
				_Comment = this._Comment,
				_CompressedSize = this._CompressedSize,
				_CompressionLevel = this._CompressionLevel,
				_CompressionMethod = this._CompressionMethod,
				_Crc32 = this._Crc32,
				_Ctime = this._Ctime,
				_emitNtfsTimes = this._emitNtfsTimes,
				_emitUnixTimes = this._emitUnixTimes,
				_Encryption = this._Encryption,
				_Encryption_FromZipFile = this._Encryption_FromZipFile,
				_entryRequiresZip64 = this._entryRequiresZip64,
				_FileNameInArchive = this._FileNameInArchive,
				_LastModified = this._LastModified,
				_LengthOfHeader = this._LengthOfHeader,
				_metadataChanged = this._metadataChanged,
				_Mtime = this._Mtime,
				_ntfsTimesAreSet = this._ntfsTimesAreSet,
				_Password = this._Password,
				_presumeZip64 = this._presumeZip64,
				_RelativeOffsetOfLocalHeader = this._RelativeOffsetOfLocalHeader,
				_restreamRequiredOnSave = this._restreamRequiredOnSave,
				_sourceIsEncrypted = this._sourceIsEncrypted,
				_TimeBlob = this._TimeBlob,
				_timestamp = this._timestamp,
				_UncompressedSize = this._UncompressedSize,
				_VersionMadeBy = this._VersionMadeBy,
				_VersionNeeded = this._VersionNeeded,
				AlternateEncoding = this.AlternateEncoding,
				AlternateEncodingUsage = this.AlternateEncodingUsage,
				ExtractExistingFile = this.ExtractExistingFile,
				SetCompression = this.SetCompression,
				ZipErrorAction = this.ZipErrorAction,
				_Source = this._Source
			};
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00014580 File Offset: 0x00012780
		internal void MarkAsDirectory()
		{
			this._IsDirectory = true;
			if (!this._FileNameInArchive.EndsWith("/"))
			{
				this._FileNameInArchive += "/";
			}
		}

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000390 RID: 912 RVA: 0x000145B1 File Offset: 0x000127B1
		// (set) Token: 0x06000391 RID: 913 RVA: 0x000145B9 File Offset: 0x000127B9
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

		// Token: 0x06000392 RID: 914 RVA: 0x000145C2 File Offset: 0x000127C2
		public override string ToString()
		{
			return string.Format("ZipEntry::{0}", this.FileName);
		}

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000393 RID: 915 RVA: 0x000145D4 File Offset: 0x000127D4
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

		// Token: 0x06000394 RID: 916 RVA: 0x0001463C File Offset: 0x0001283C
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

		// Token: 0x06000395 RID: 917 RVA: 0x00014738 File Offset: 0x00012938
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

		// Token: 0x06000396 RID: 918 RVA: 0x0001474F File Offset: 0x0001294F
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

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x06000397 RID: 919 RVA: 0x0001477C File Offset: 0x0001297C
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

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x06000398 RID: 920 RVA: 0x00014794 File Offset: 0x00012994
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

		// Token: 0x06000399 RID: 921 RVA: 0x000147AA File Offset: 0x000129AA
		public void Extract()
		{
			this.InternalExtractToBaseDir(".", null, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039A RID: 922 RVA: 0x000147CA File Offset: 0x000129CA
		public void Extract(global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtractToBaseDir(".", null, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039B RID: 923 RVA: 0x000147F1 File Offset: 0x000129F1
		public void Extract(global::System.IO.Stream stream)
		{
			this.InternalExtractToStream(stream, null, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039C RID: 924 RVA: 0x0001480D File Offset: 0x00012A0D
		public void Extract(string baseDirectory)
		{
			this.InternalExtractToBaseDir(baseDirectory, null, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00014829 File Offset: 0x00012A29
		public void Extract(string baseDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtractToBaseDir(baseDirectory, null, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x0001484C File Offset: 0x00012A4C
		public void ExtractWithPassword(string password)
		{
			this.InternalExtractToBaseDir(".", password, this._container, this._Source, this.FileName);
		}

		// Token: 0x0600039F RID: 927 RVA: 0x0001486C File Offset: 0x00012A6C
		public void ExtractWithPassword(string baseDirectory, string password)
		{
			this.InternalExtractToBaseDir(baseDirectory, password, this._container, this._Source, this.FileName);
		}

		// Token: 0x060003A0 RID: 928 RVA: 0x00014888 File Offset: 0x00012A88
		public void ExtractWithPassword(global::Ionic.Zip.ExtractExistingFileAction extractExistingFile, string password)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtractToBaseDir(".", password, this._container, this._Source, this.FileName);
		}

		// Token: 0x060003A1 RID: 929 RVA: 0x000148AF File Offset: 0x00012AAF
		public void ExtractWithPassword(string baseDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile, string password)
		{
			this.ExtractExistingFile = extractExistingFile;
			this.InternalExtractToBaseDir(baseDirectory, password, this._container, this._Source, this.FileName);
		}

		// Token: 0x060003A2 RID: 930 RVA: 0x000148D2 File Offset: 0x00012AD2
		public void ExtractWithPassword(global::System.IO.Stream stream, string password)
		{
			this.InternalExtractToStream(stream, password, this._container, this._Source, this.FileName);
		}

		// Token: 0x060003A3 RID: 931 RVA: 0x000148EE File Offset: 0x00012AEE
		public global::Ionic.Crc.CrcCalculatorStream OpenReader()
		{
			if (this._container.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.InternalOpenReader(this._Password ?? this._container.Password);
		}

		// Token: 0x060003A4 RID: 932 RVA: 0x00014923 File Offset: 0x00012B23
		public global::Ionic.Crc.CrcCalculatorStream OpenReader(string password)
		{
			if (this._container.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use OpenReader() only with ZipFile.");
			}
			return this.InternalOpenReader(password);
		}

		// Token: 0x060003A5 RID: 933 RVA: 0x00014944 File Offset: 0x00012B44
		internal global::Ionic.Crc.CrcCalculatorStream InternalOpenReader(string password)
		{
			global::Ionic.Zip.ZipEntry.ValidateCompression(this._CompressionMethod_FromZipFile, this.FileName, global::Ionic.Zip.ZipEntry.GetUnsupportedCompressionMethod(this._CompressionMethod));
			global::Ionic.Zip.ZipEntry.ValidateEncryption(this.Encryption, this.FileName, this._UnsupportedAlgorithmId);
			this.SetupCryptoForExtract(password);
			if (this._Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::Ionic.Zip.BadStateException("You must call ZipFile.Save before calling OpenReader");
			}
			long length = (this._CompressionMethod_FromZipFile == 0) ? this._CompressedFileDataSize : this.UncompressedSize;
			this.ArchiveStream.Seek(this.FileDataPosition, global::System.IO.SeekOrigin.Begin);
			this._inputDecryptorStream = this.GetExtractDecryptor(this.ArchiveStream);
			return new global::Ionic.Crc.CrcCalculatorStream(this.GetExtractDecompressor(this._inputDecryptorStream), length);
		}

		// Token: 0x060003A6 RID: 934 RVA: 0x000149ED File Offset: 0x00012BED
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnExtractBlock(this, bytesWritten, totalBytesToWrite);
			}
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x00014A15 File Offset: 0x00012C15
		private static void OnBeforeExtract(global::Ionic.Zip.ZipEntry zipEntryInstance, string path, global::Ionic.Zip.ZipFile zipFile)
		{
			if (zipFile == null)
			{
				return;
			}
			if (zipFile._inExtractAll)
			{
				return;
			}
			zipFile.OnSingleEntryExtract(zipEntryInstance, path, true);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00014A2E File Offset: 0x00012C2E
		private void OnAfterExtract(string path)
		{
			if (this._container.ZipFile == null)
			{
				return;
			}
			if (this._container.ZipFile._inExtractAll)
			{
				return;
			}
			this._container.ZipFile.OnSingleEntryExtract(this, path, false);
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00014A65 File Offset: 0x00012C65
		private void OnExtractExisting(string path)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnExtractExisting(this, path);
			}
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00014A8C File Offset: 0x00012C8C
		private static void ReallyDelete(string fileName)
		{
			if ((global::System.IO.File.GetAttributes(fileName) & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
			{
				global::System.IO.File.SetAttributes(fileName, global::System.IO.FileAttributes.Normal);
			}
			global::System.IO.File.Delete(fileName);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00014AAA File Offset: 0x00012CAA
		private void WriteStatus(string format, params object[] args)
		{
			if (this._container.ZipFile != null && this._container.ZipFile.Verbose)
			{
				this._container.ZipFile.StatusMessageTextWriter.WriteLine(format, args);
			}
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00014AE4 File Offset: 0x00012CE4
		private void InternalExtractToBaseDir(string baseDir, string password, global::Ionic.Zip.ZipContainer zipContainer, global::Ionic.Zip.ZipEntrySource zipEntrySource, string fileName)
		{
			if (baseDir == null)
			{
				throw new global::System.ArgumentNullException("baseDir");
			}
			if (zipContainer == null)
			{
				throw new global::Ionic.Zip.BadStateException("This entry is an orphan");
			}
			if (zipContainer.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use Extract() only with ZipFile.");
			}
			zipContainer.ZipFile.Reset(false);
			if (zipEntrySource != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::Ionic.Zip.BadStateException("You must call ZipFile.Save before calling any Extract method");
			}
			global::Ionic.Zip.ZipEntry.OnBeforeExtract(this, baseDir, zipContainer.ZipFile);
			this._ioOperationCanceled = false;
			bool flag = false;
			bool checkLaterForResetDirTimes = false;
			string text = null;
			try
			{
				global::Ionic.Zip.ZipEntry.ValidateCompression(this._CompressionMethod_FromZipFile, fileName, global::Ionic.Zip.ZipEntry.GetUnsupportedCompressionMethod(this._CompressionMethod));
				global::Ionic.Zip.ZipEntry.ValidateEncryption(this.Encryption, fileName, this._UnsupportedAlgorithmId);
				if (this.IsDoneWithOutputToBaseDir(baseDir, out text))
				{
					this.WriteStatus("extract dir {0}...", new object[]
					{
						text
					});
					this.OnAfterExtract(baseDir);
				}
				else
				{
					if (global::System.IO.File.Exists(text))
					{
						flag = true;
						int num = this.CheckExtractExistingFile(baseDir, text);
						if (num == 2)
						{
							goto IL_16B;
						}
						if (num == 1)
						{
							return;
						}
					}
					if (this._Encryption_FromZipFile != global::Ionic.Zip.EncryptionAlgorithm.None)
					{
						this.EnsurePassword(password);
					}
					string path = global::Ionic.Zip.SharedUtilities.InternalGetTempFileName();
					string tmpPath = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(text), path);
					this.WriteStatus("extract file {0}...", new object[]
					{
						text
					});
					using (global::System.IO.Stream stream = this.OpenFileStream(tmpPath, ref checkLaterForResetDirTimes))
					{
						if (this.ExtractToStream(this.ArchiveStream, stream, this.Encryption, this._Crc32))
						{
							goto IL_16B;
						}
						stream.Close();
					}
					this.MoveFileInPlace(flag, text, tmpPath, checkLaterForResetDirTimes);
					this.OnAfterExtract(baseDir);
					IL_16B:;
				}
			}
			catch (global::System.Exception)
			{
				this._ioOperationCanceled = true;
				throw;
			}
			finally
			{
				if (this._ioOperationCanceled && text != null && global::System.IO.File.Exists(text) && !flag)
				{
					global::System.IO.File.Delete(text);
				}
			}
		}

		// Token: 0x060003AD RID: 941 RVA: 0x00014CD4 File Offset: 0x00012ED4
		private void InternalExtractToStream(global::System.IO.Stream outStream, string password, global::Ionic.Zip.ZipContainer zipContainer, global::Ionic.Zip.ZipEntrySource zipEntrySource, string fileName)
		{
			if (zipContainer == null)
			{
				throw new global::Ionic.Zip.BadStateException("This entry is an orphan");
			}
			if (zipContainer.ZipFile == null)
			{
				throw new global::System.InvalidOperationException("Use Extract() only with ZipFile.");
			}
			zipContainer.ZipFile.Reset(false);
			if (zipEntrySource != global::Ionic.Zip.ZipEntrySource.ZipFile)
			{
				throw new global::Ionic.Zip.BadStateException("You must call ZipFile.Save before calling any Extract method");
			}
			global::Ionic.Zip.ZipEntry.OnBeforeExtract(this, null, zipContainer.ZipFile);
			this._ioOperationCanceled = false;
			try
			{
				global::Ionic.Zip.ZipEntry.ValidateCompression(this._CompressionMethod_FromZipFile, fileName, global::Ionic.Zip.ZipEntry.GetUnsupportedCompressionMethod(this._CompressionMethod));
				global::Ionic.Zip.ZipEntry.ValidateEncryption(this.Encryption, fileName, this._UnsupportedAlgorithmId);
				if (this.IsDoneWithOutputToStream())
				{
					this.WriteStatus("extract dir {0}...", null);
					this.OnAfterExtract(null);
				}
				else
				{
					if (this._Encryption_FromZipFile != global::Ionic.Zip.EncryptionAlgorithm.None)
					{
						this.EnsurePassword(password);
					}
					this.WriteStatus("extract entry {0} to stream...", new object[]
					{
						fileName
					});
					global::System.IO.Stream archiveStream = this.ArchiveStream;
					if (!this.ExtractToStream(archiveStream, outStream, this.Encryption, this._Crc32))
					{
						this.OnAfterExtract(null);
					}
				}
			}
			catch (global::System.Exception)
			{
				this._ioOperationCanceled = true;
				throw;
			}
		}

		// Token: 0x060003AE RID: 942 RVA: 0x00014DE0 File Offset: 0x00012FE0
		private bool ExtractToStream(global::System.IO.Stream archiveStream, global::System.IO.Stream output, global::Ionic.Zip.EncryptionAlgorithm encryptionAlgorithm, int expectedCrc32)
		{
			if (this._ioOperationCanceled)
			{
				return true;
			}
			bool result;
			try
			{
				int calculatedCrc = this.ExtractAndCrc(archiveStream, output, this._CompressionMethod_FromZipFile, this._CompressedFileDataSize, this.UncompressedSize);
				if (this._ioOperationCanceled)
				{
					result = true;
				}
				else
				{
					this.VerifyCrcAfterExtract(calculatedCrc, encryptionAlgorithm, expectedCrc32, archiveStream, this.UncompressedSize);
					result = false;
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

		// Token: 0x060003AF RID: 943 RVA: 0x00014E60 File Offset: 0x00013060
		private void MoveFileInPlace(bool fileExistsBeforeExtraction, string targetFileName, string tmpPath, bool checkLaterForResetDirTimes)
		{
			string text = null;
			if (fileExistsBeforeExtraction)
			{
				text = targetFileName + global::System.IO.Path.GetRandomFileName() + ".PendingOverwrite";
				global::System.IO.File.Move(targetFileName, text);
			}
			global::System.IO.File.Move(tmpPath, targetFileName);
			this._SetTimes(targetFileName, true);
			if (text != null && global::System.IO.File.Exists(text))
			{
				global::Ionic.Zip.ZipEntry.ReallyDelete(text);
			}
			if (checkLaterForResetDirTimes && this.FileName.Contains("/"))
			{
				string directoryName = global::System.IO.Path.GetDirectoryName(this.FileName);
				if (this._container.ZipFile[directoryName] == null)
				{
					this._SetTimes(global::System.IO.Path.GetDirectoryName(targetFileName), false);
				}
			}
			if (((int)this._VersionMadeBy & 65280) == 2560 || ((int)this._VersionMadeBy & 65280) == 0)
			{
				global::System.IO.File.SetAttributes(targetFileName, (global::System.IO.FileAttributes)this._ExternalFileAttrs);
			}
		}

		// Token: 0x060003B0 RID: 944 RVA: 0x00014F1C File Offset: 0x0001311C
		private void EnsurePassword(string password)
		{
			string text = password ?? (this._Password ?? this._container.Password);
			if (text == null)
			{
				throw new global::Ionic.Zip.BadPasswordException();
			}
			this.SetupCryptoForExtract(text);
		}

		// Token: 0x060003B1 RID: 945 RVA: 0x00014F54 File Offset: 0x00013154
		private global::System.IO.Stream OpenFileStream(string tmpPath, ref bool checkLaterForResetDirTimes)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(tmpPath);
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				global::System.IO.Directory.CreateDirectory(directoryName);
			}
			else if (this._container.ZipFile != null)
			{
				checkLaterForResetDirTimes = this._container.ZipFile._inExtractAll;
			}
			return new global::System.IO.FileStream(tmpPath, global::System.IO.FileMode.CreateNew);
		}

		// Token: 0x060003B2 RID: 946 RVA: 0x00014FA0 File Offset: 0x000131A0
		internal void VerifyCrcAfterExtract(int calculatedCrc32, global::Ionic.Zip.EncryptionAlgorithm encryptionAlgorithm, int expectedCrc32, global::System.IO.Stream archiveStream, long uncompressedSize)
		{
			if (calculatedCrc32 != expectedCrc32 && ((encryptionAlgorithm != global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 && encryptionAlgorithm != global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256) || this._WinZipAesMethod != 2))
			{
				throw new global::Ionic.Zip.BadCrcException("CRC error: the file being extracted appears to be corrupted. " + string.Format("Expected 0x{0:X8}, Actual 0x{1:X8}", expectedCrc32, calculatedCrc32));
			}
			if (uncompressedSize == 0L)
			{
				return;
			}
			if (encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256)
			{
				global::Ionic.Zip.WinZipAesCipherStream winZipAesCipherStream = this._inputDecryptorStream as global::Ionic.Zip.WinZipAesCipherStream;
				byte[] buffer = new byte[256];
				winZipAesCipherStream.Read(buffer, 0, 256);
				this._aesCrypto_forExtract.CalculatedMac = winZipAesCipherStream.FinalAuthentication;
				this._aesCrypto_forExtract.ReadAndVerifyMac(archiveStream);
			}
		}

		// Token: 0x060003B3 RID: 947 RVA: 0x00015038 File Offset: 0x00013238
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			int num = 0;
			for (;;)
			{
				switch (this.ExtractExistingFile)
				{
				case global::Ionic.Zip.ExtractExistingFileAction.OverwriteSilently:
					goto IL_21;
				case global::Ionic.Zip.ExtractExistingFileAction.DoNotOverwrite:
					goto IL_38;
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
			goto IL_81;
			IL_21:
			this.WriteStatus("the file {0} exists; will overwrite it...", new object[]
			{
				targetFileName
			});
			return 0;
			IL_38:
			this.WriteStatus("the file {0} exists; not extracting entry...", new object[]
			{
				this.FileName
			});
			this.OnAfterExtract(baseDir);
			return 1;
			Block_2:
			throw new global::Ionic.Zip.ZipException(string.Format("The file {0} already exists.", targetFileName));
			IL_81:
			throw new global::Ionic.Zip.ZipException(string.Format("The file {0} already exists.", targetFileName));
		}

		// Token: 0x060003B4 RID: 948 RVA: 0x000150DF File Offset: 0x000132DF
		private void _CheckRead(int nbytes)
		{
			if (nbytes == 0)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("bad read of entry {0} from compressed archive.", this.FileName));
			}
		}

		// Token: 0x060003B5 RID: 949 RVA: 0x000150FC File Offset: 0x000132FC
		private int ExtractAndCrc(global::System.IO.Stream archiveStream, global::System.IO.Stream targetOutput, short compressionMethod, long compressedFileDataSize, long uncompressedSize)
		{
			archiveStream.Seek(this.FileDataPosition, global::System.IO.SeekOrigin.Begin);
			byte[] array = new byte[this.BufferSize];
			long num = (compressionMethod != 0) ? uncompressedSize : compressedFileDataSize;
			this._inputDecryptorStream = this.GetExtractDecryptor(archiveStream);
			global::System.IO.Stream extractDecompressor = this.GetExtractDecompressor(this._inputDecryptorStream);
			long num2 = 0L;
			int crc;
			using (global::Ionic.Crc.CrcCalculatorStream crcCalculatorStream = new global::Ionic.Crc.CrcCalculatorStream(extractDecompressor))
			{
				while (num > 0L)
				{
					int count = (num > (long)array.Length) ? array.Length : ((int)num);
					int num3 = crcCalculatorStream.Read(array, 0, count);
					this._CheckRead(num3);
					targetOutput.Write(array, 0, num3);
					num -= (long)num3;
					num2 += (long)num3;
					this.OnExtractProgress(num2, uncompressedSize);
					if (this._ioOperationCanceled)
					{
						break;
					}
				}
				crc = crcCalculatorStream.Crc;
			}
			return crc;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000151D0 File Offset: 0x000133D0
		private global::System.IO.Stream GetExtractDecompressor(global::System.IO.Stream input2)
		{
			if (input2 == null)
			{
				throw new global::System.ArgumentNullException("input2");
			}
			short compressionMethod_FromZipFile = this._CompressionMethod_FromZipFile;
			if (compressionMethod_FromZipFile != 0)
			{
				switch (compressionMethod_FromZipFile)
				{
				case 8:
					return new global::Ionic.Zlib.DeflateStream(input2, global::Ionic.Zlib.CompressionMode.Decompress, true);
				case 9:
					return new global::Ionic.Zip.Deflate64.Deflate64Stream(input2, -1L);
				case 12:
					return new global::Ionic.BZip2.BZip2InputStream(input2, true);
				}
				throw new global::System.Exception(string.Format("Failed to find decompressor matching {0}", this._CompressionMethod_FromZipFile));
			}
			return input2;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x0001524C File Offset: 0x0001344C
		private global::System.IO.Stream GetExtractDecryptor(global::System.IO.Stream input)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
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

		// Token: 0x060003B8 RID: 952 RVA: 0x000152AC File Offset: 0x000134AC
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

		// Token: 0x060003B9 RID: 953 RVA: 0x00015374 File Offset: 0x00013574
		private static string GetUnsupportedAlgorithm(uint unsupportedAlgorithmId)
		{
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
			return string.Format("Unknown (0x{0:X4})", unsupportedAlgorithmId);
		}

		// Token: 0x060003BA RID: 954 RVA: 0x0001547C File Offset: 0x0001367C
		private static string GetUnsupportedCompressionMethod(short compressionMethod)
		{
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
			return string.Format("Unknown (0x{0:X4})", compressionMethod);
		}

		// Token: 0x060003BB RID: 955 RVA: 0x0001551C File Offset: 0x0001371C
		private static void ValidateEncryption(global::Ionic.Zip.EncryptionAlgorithm encryptionAlgorithm, string fileName, uint unsupportedAlgorithmId)
		{
			if (encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak || encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes128 || encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.WinZipAes256 || encryptionAlgorithm == global::Ionic.Zip.EncryptionAlgorithm.None)
			{
				return;
			}
			if (unsupportedAlgorithmId != 0U)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Cannot extract: Entry {0} is encrypted with an algorithm not supported by DotNetZip: {1}", fileName, global::Ionic.Zip.ZipEntry.GetUnsupportedAlgorithm(unsupportedAlgorithmId)));
			}
			throw new global::Ionic.Zip.ZipException(string.Format("Cannot extract: Entry {0} uses an unsupported encryption algorithm ({1:X2})", fileName, (int)encryptionAlgorithm));
		}

		// Token: 0x060003BC RID: 956 RVA: 0x00015569 File Offset: 0x00013769
		private static void ValidateCompression(short compressionMethod, string fileName, string compressionMethodName)
		{
			if (compressionMethod != 0 && compressionMethod != 8 && compressionMethod != 9 && compressionMethod != 12)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Entry {0} uses an unsupported compression method (0x{1:X2}, {2})", fileName, compressionMethod, compressionMethodName));
			}
		}

		// Token: 0x060003BD RID: 957 RVA: 0x00015594 File Offset: 0x00013794
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

		// Token: 0x060003BE RID: 958 RVA: 0x0001565C File Offset: 0x0001385C
		private bool IsDoneWithOutputToBaseDir(string baseDir, out string outFileName)
		{
			if (baseDir == null)
			{
				throw new global::System.ArgumentNullException("baseDir");
			}
			string text = this.FileName.Replace(global::System.IO.Path.DirectorySeparatorChar, '/');
			if (text.IndexOf(':') == 1)
			{
				text = text.Substring(2);
			}
			if (text.StartsWith("/"))
			{
				text = text.Substring(1);
			}
			text = global::Ionic.Zip.SharedUtilities.SanitizePath(text);
			outFileName = (this._container.ZipFile.FlattenFoldersOnExtract ? global::System.IO.Path.Combine(baseDir, text.Contains("/") ? global::System.IO.Path.GetFileName(text) : text) : global::System.IO.Path.Combine(baseDir, text));
			outFileName = outFileName.Replace('/', global::System.IO.Path.DirectorySeparatorChar);
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

		// Token: 0x060003BF RID: 959 RVA: 0x0001574D File Offset: 0x0001394D
		private bool IsDoneWithOutputToStream()
		{
			return this.IsDirectory || this.FileName.EndsWith("/");
		}

		// Token: 0x060003C0 RID: 960 RVA: 0x0001576C File Offset: 0x0001396C
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

		// Token: 0x060003C1 RID: 961 RVA: 0x0001582C File Offset: 0x00013A2C
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
				ze._FileNameInArchive = ze.AlternateEncoding.GetString(array);
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
						}
						flag = (num6 != ze._CompressedSize);
						if (flag)
						{
							ze.ArchiveStream.Seek(-12L, global::System.IO.SeekOrigin.Current);
							num6 += 4L;
						}
					}
					ze.ArchiveStream.Seek(position, global::System.IO.SeekOrigin.Begin);
					ze._LengthOfTrailer += (ze._InputUsesZip64 ? 24 : 16);
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

		// Token: 0x060003C2 RID: 962 RVA: 0x00015F1D File Offset: 0x0001411D
		internal static int ReadWeakEncryptionHeader(global::System.IO.Stream s, byte[] buffer)
		{
			int num = s.Read(buffer, 0, 12);
			if (num != 12)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Unexpected end of data at position 0x{0:X8}", s.Position));
			}
			return num;
		}

		// Token: 0x060003C3 RID: 963 RVA: 0x00015F49 File Offset: 0x00014149
		private static bool IsNotValidSig(int signature)
		{
			return signature != 67324752;
		}

		// Token: 0x060003C4 RID: 964 RVA: 0x00015F58 File Offset: 0x00014158
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

		// Token: 0x060003C5 RID: 965 RVA: 0x00015FF4 File Offset: 0x000141F4
		internal static void HandlePK00Prefix(global::System.IO.Stream s)
		{
			if (global::Ionic.Zip.SharedUtilities.ReadInt(s) != 808471376)
			{
				s.Seek(-4L, global::System.IO.SeekOrigin.Current);
			}
		}

		// Token: 0x060003C6 RID: 966 RVA: 0x00016010 File Offset: 0x00014210
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

		// Token: 0x060003C7 RID: 967 RVA: 0x00016078 File Offset: 0x00014278
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

		// Token: 0x060003C8 RID: 968 RVA: 0x000160CC File Offset: 0x000142CC
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
					ushort num5 = (ushort)((int)array[num2++] + (int)array[num2++] * 256);
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

		// Token: 0x060003C9 RID: 969 RVA: 0x00016210 File Offset: 0x00014410
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			j += 2;
			this._UnsupportedAlgorithmId = (uint)((ushort)((int)Buffer[j++] + (int)Buffer[j++] * 256));
			this._Encryption_FromZipFile = (this._Encryption = global::Ionic.Zip.EncryptionAlgorithm.Unsupported);
			return j;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00016254 File Offset: 0x00014454
		private int ProcessExtraFieldWinZipAes(byte[] buffer, int j, ushort dataSize, long posn)
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

		// Token: 0x060003CB RID: 971 RVA: 0x000163A4 File Offset: 0x000145A4
		private int ProcessExtraFieldZip64(byte[] buffer, int j, ushort dataSize, long posn)
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
			if (this._diskNumber == 65535U && remainingData >= 4)
			{
				this._diskNumber = global::System.BitConverter.ToUInt32(buffer, j);
				j += 4;
				remainingData -= 4;
			}
			return j;
		}

		// Token: 0x060003CC RID: 972 RVA: 0x000164A0 File Offset: 0x000146A0
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, ushort dataSize, long posn)
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

		// Token: 0x060003CD RID: 973 RVA: 0x00016534 File Offset: 0x00014734
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, ushort dataSize, long posn)
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

		// Token: 0x060003CE RID: 974 RVA: 0x00016654 File Offset: 0x00014854
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, ushort dataSize, long posn)
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

		// Token: 0x060003CF RID: 975 RVA: 0x00016720 File Offset: 0x00014920
		internal void WriteCentralDirectoryEntry(global::System.IO.Stream s)
		{
			byte[] array = new byte[8192];
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
			num += 2;
			if (this._container.ZipFile != null && this._container.ZipFile.MaxOutputSegmentSize64 != 0L)
			{
				if (this._presumeZip64 || this._diskNumber > 65535U)
				{
					array[num++] = byte.MaxValue;
					array[num++] = byte.MaxValue;
				}
				else
				{
					array[num++] = (byte)(this._diskNumber & 255U);
					array[num++] = (byte)((this._diskNumber & 65280U) >> 8);
				}
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
			if (this._presumeZip64 || this._RelativeOffsetOfLocalHeader > (long)((ulong)-1))
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
				if (num6 + num > array.Length)
				{
					num6 = array.Length - num;
				}
				global::System.Buffer.BlockCopy(this._CommentBytes, 0, array, num, num6);
				num += num6;
			}
			array[32] = (byte)(num6 & 255);
			array[33] = (byte)((num6 & 65280) >> 8);
			s.Write(array, 0, num);
		}

		// Token: 0x060003D0 RID: 976 RVA: 0x00016CDC File Offset: 0x00014EDC
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
					global::System.Array.Copy(global::System.BitConverter.GetBytes(this._diskNumber), 0, array, num2, 4);
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

		// Token: 0x060003D1 RID: 977 RVA: 0x0001713C File Offset: 0x0001533C
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

		// Token: 0x060003D2 RID: 978 RVA: 0x00017218 File Offset: 0x00015418
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
			string @string = global::Ionic.Zip.ZipEntry.ibm437.GetString(bytes);
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

		// Token: 0x060003D3 RID: 979 RVA: 0x000173BC File Offset: 0x000155BC
		private bool WantReadAgain()
		{
			return this._UncompressedSize >= 16L && this._CompressionMethod != 0 && this.CompressionLevel != global::Ionic.Zlib.CompressionLevel.None && this._CompressedSize >= this._UncompressedSize && (this._Source != global::Ionic.Zip.ZipEntrySource.Stream || this._sourceStream.CanSeek) && (this._aesCrypto_forWrite == null || this.CompressedSize - (long)this._aesCrypto_forWrite.SizeOfEncryptionMetadata > this.UncompressedSize + 16L) && (this._zipCrypto_forWrite == null || this.CompressedSize - 12L > this.UncompressedSize);
		}

		// Token: 0x060003D4 RID: 980 RVA: 0x00017458 File Offset: 0x00015658
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

		// Token: 0x060003D5 RID: 981 RVA: 0x0001751C File Offset: 0x0001571C
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
			if (this._dontEmitLastModified)
			{
				this._TimeBlob = 0;
			}
			else
			{
				this._TimeBlob = global::Ionic.Zip.SharedUtilities.DateTimeToPacked(this.LastModified);
			}
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

		// Token: 0x060003D6 RID: 982 RVA: 0x00017A48 File Offset: 0x00015C48
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

		// Token: 0x060003D7 RID: 983 RVA: 0x00017B3C File Offset: 0x00015D3C
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

		// Token: 0x060003D8 RID: 984 RVA: 0x00017BD8 File Offset: 0x00015DD8
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

		// Token: 0x060003D9 RID: 985 RVA: 0x00017C8D File Offset: 0x00015E8D
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnSaveBlock(this, bytesXferred, totalBytesToXfer);
			}
		}

		// Token: 0x060003DA RID: 986 RVA: 0x00017CB8 File Offset: 0x00015EB8
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
					this._sourceStream = null;
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

		// Token: 0x060003DB RID: 987 RVA: 0x00017DF8 File Offset: 0x00015FF8
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
					global::System.IO.FileShare share = global::System.IO.FileShare.Read | global::System.IO.FileShare.Write | global::System.IO.FileShare.Delete;
					input = global::System.IO.File.Open(this.LocalFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, share);
					result = input.Length;
				}
			}
			return result;
		}

		// Token: 0x060003DC RID: 988 RVA: 0x00017F10 File Offset: 0x00016110
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

		// Token: 0x060003DD RID: 989 RVA: 0x00017FEC File Offset: 0x000161EC
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
						goto IL_65E;
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
			IL_65E:
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

		// Token: 0x060003DE RID: 990 RVA: 0x000187F0 File Offset: 0x000169F0
		private void SetZip64Flags()
		{
			this._entryRequiresZip64 = new bool?(this._CompressedSize >= (long)((ulong)-1) || this._UncompressedSize >= (long)((ulong)-1) || this._RelativeOffsetOfLocalHeader >= (long)((ulong)-1));
			if (this._container.Zip64 == global::Ionic.Zip.Zip64Option.Default && this._entryRequiresZip64.Value)
			{
				throw new global::Ionic.Zip.ZipException("Compressed or Uncompressed size, or offset exceeds the maximum value. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
			}
			this._OutputUsesZip64 = new bool?(this._container.Zip64 == global::Ionic.Zip.Zip64Option.Always || this._entryRequiresZip64.Value);
		}

		// Token: 0x060003DF RID: 991 RVA: 0x00018878 File Offset: 0x00016A78
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

		// Token: 0x060003E0 RID: 992 RVA: 0x000188C4 File Offset: 0x00016AC4
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

		// Token: 0x060003E1 RID: 993 RVA: 0x00018A33 File Offset: 0x00016C33
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

		// Token: 0x060003E2 RID: 994 RVA: 0x00018A6D File Offset: 0x00016C6D
		private void OnZipErrorWhileSaving(global::System.Exception e)
		{
			if (this._container.ZipFile != null)
			{
				this._ioOperationCanceled = this._container.ZipFile.OnZipErrorSaving(this, e);
			}
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00018A94 File Offset: 0x00016C94
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
									goto IL_236;
								}
							}
							num2++;
							continue;
						}
						IL_236:
						goto IL_238;
					}
					throw;
				}
				IL_238:;
			}
			while (!flag);
		}

		// Token: 0x060003E4 RID: 996 RVA: 0x00018CFC File Offset: 0x00016EFC
		internal void StoreRelativeOffset()
		{
			this._RelativeOffsetOfLocalHeader = this._future_ROLH;
		}

		// Token: 0x060003E5 RID: 997 RVA: 0x00018D0A File Offset: 0x00016F0A
		internal void NotifySaveComplete()
		{
			this._Encryption_FromZipFile = this._Encryption;
			this._CompressionMethod_FromZipFile = this._CompressionMethod;
			this._restreamRequiredOnSave = false;
			this._metadataChanged = false;
			this._Source = global::Ionic.Zip.ZipEntrySource.ZipFile;
		}

		// Token: 0x060003E6 RID: 998 RVA: 0x00018D3C File Offset: 0x00016F3C
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
					if (this._dontEmitLastModified)
					{
						this._TimeBlob = 0;
					}
					else
					{
						this._TimeBlob = global::Ionic.Zip.SharedUtilities.DateTimeToPacked(this.LastModified);
					}
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

		// Token: 0x060003E7 RID: 999 RVA: 0x00018EC8 File Offset: 0x000170C8
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

		// Token: 0x060003E8 RID: 1000 RVA: 0x00018FA0 File Offset: 0x000171A0
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
					this._CheckRead(num4);
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

		// Token: 0x060003E9 RID: 1001 RVA: 0x000191B8 File Offset: 0x000173B8
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
				this._CheckRead(num2);
				outstream.Write(array, 0, num2);
				num -= (long)num2;
				this.OnWriteBlock(countingStream.BytesRead, this._TotalEntrySize);
				if (this._ioOperationCanceled)
				{
					break;
				}
			}
		}

		// Token: 0x060003EA RID: 1002 RVA: 0x0001928C File Offset: 0x0001748C
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

		// Token: 0x04000235 RID: 565
		private short _VersionMadeBy;

		// Token: 0x04000236 RID: 566
		private short _InternalFileAttrs;

		// Token: 0x04000237 RID: 567
		private int _ExternalFileAttrs;

		// Token: 0x04000238 RID: 568
		private short _filenameLength;

		// Token: 0x04000239 RID: 569
		private short _extraFieldLength;

		// Token: 0x0400023A RID: 570
		private short _commentLength;

		// Token: 0x04000241 RID: 577
		private global::Ionic.Zip.ZipCrypto _zipCrypto_forExtract;

		// Token: 0x04000242 RID: 578
		private global::Ionic.Zip.ZipCrypto _zipCrypto_forWrite;

		// Token: 0x04000243 RID: 579
		private global::Ionic.Zip.WinZipAesCrypto _aesCrypto_forExtract;

		// Token: 0x04000244 RID: 580
		private global::Ionic.Zip.WinZipAesCrypto _aesCrypto_forWrite;

		// Token: 0x04000245 RID: 581
		private short _WinZipAesMethod;

		// Token: 0x04000246 RID: 582
		internal global::System.DateTime _LastModified;

		// Token: 0x04000247 RID: 583
		private bool _dontEmitLastModified;

		// Token: 0x04000248 RID: 584
		private global::System.DateTime _Mtime;

		// Token: 0x04000249 RID: 585
		private global::System.DateTime _Atime;

		// Token: 0x0400024A RID: 586
		private global::System.DateTime _Ctime;

		// Token: 0x0400024B RID: 587
		private bool _ntfsTimesAreSet;

		// Token: 0x0400024C RID: 588
		private bool _emitNtfsTimes = true;

		// Token: 0x0400024D RID: 589
		private bool _emitUnixTimes;

		// Token: 0x0400024E RID: 590
		private bool _TrimVolumeFromFullyQualifiedPaths = true;

		// Token: 0x0400024F RID: 591
		internal string _LocalFileName;

		// Token: 0x04000250 RID: 592
		private string _FileNameInArchive;

		// Token: 0x04000251 RID: 593
		internal short _VersionNeeded;

		// Token: 0x04000252 RID: 594
		internal short _BitField;

		// Token: 0x04000253 RID: 595
		internal short _CompressionMethod;

		// Token: 0x04000254 RID: 596
		private short _CompressionMethod_FromZipFile;

		// Token: 0x04000255 RID: 597
		private global::Ionic.Zlib.CompressionLevel _CompressionLevel;

		// Token: 0x04000256 RID: 598
		internal string _Comment;

		// Token: 0x04000257 RID: 599
		private bool _IsDirectory;

		// Token: 0x04000258 RID: 600
		private byte[] _CommentBytes;

		// Token: 0x04000259 RID: 601
		internal long _CompressedSize;

		// Token: 0x0400025A RID: 602
		internal long _CompressedFileDataSize;

		// Token: 0x0400025B RID: 603
		internal long _UncompressedSize;

		// Token: 0x0400025C RID: 604
		internal int _TimeBlob;

		// Token: 0x0400025D RID: 605
		private bool _crcCalculated;

		// Token: 0x0400025E RID: 606
		internal int _Crc32;

		// Token: 0x0400025F RID: 607
		internal byte[] _Extra;

		// Token: 0x04000260 RID: 608
		private bool _metadataChanged;

		// Token: 0x04000261 RID: 609
		private bool _restreamRequiredOnSave;

		// Token: 0x04000262 RID: 610
		private bool _sourceIsEncrypted;

		// Token: 0x04000263 RID: 611
		private bool _skippedDuringSave;

		// Token: 0x04000264 RID: 612
		private uint _diskNumber;

		// Token: 0x04000265 RID: 613
		private static global::System.Text.Encoding ibm437 = global::System.Text.Encoding.GetEncoding("IBM437");

		// Token: 0x04000266 RID: 614
		private global::System.Text.Encoding _actualEncoding;

		// Token: 0x04000267 RID: 615
		internal global::Ionic.Zip.ZipContainer _container;

		// Token: 0x04000268 RID: 616
		private long __FileDataPosition = -1L;

		// Token: 0x04000269 RID: 617
		private byte[] _EntryHeader;

		// Token: 0x0400026A RID: 618
		internal long _RelativeOffsetOfLocalHeader;

		// Token: 0x0400026B RID: 619
		private long _future_ROLH;

		// Token: 0x0400026C RID: 620
		private long _TotalEntrySize;

		// Token: 0x0400026D RID: 621
		private int _LengthOfHeader;

		// Token: 0x0400026E RID: 622
		private int _LengthOfTrailer;

		// Token: 0x0400026F RID: 623
		internal bool _InputUsesZip64;

		// Token: 0x04000270 RID: 624
		private uint _UnsupportedAlgorithmId;

		// Token: 0x04000271 RID: 625
		internal string _Password;

		// Token: 0x04000272 RID: 626
		internal global::Ionic.Zip.ZipEntrySource _Source;

		// Token: 0x04000273 RID: 627
		internal global::Ionic.Zip.EncryptionAlgorithm _Encryption;

		// Token: 0x04000274 RID: 628
		internal global::Ionic.Zip.EncryptionAlgorithm _Encryption_FromZipFile;

		// Token: 0x04000275 RID: 629
		internal byte[] _WeakEncryptionHeader;

		// Token: 0x04000276 RID: 630
		internal global::System.IO.Stream _archiveStream;

		// Token: 0x04000277 RID: 631
		private global::System.IO.Stream _sourceStream;

		// Token: 0x04000278 RID: 632
		private long? _sourceStreamOriginalPosition;

		// Token: 0x04000279 RID: 633
		private bool _sourceWasJitProvided;

		// Token: 0x0400027A RID: 634
		private bool _ioOperationCanceled;

		// Token: 0x0400027B RID: 635
		private bool _presumeZip64;

		// Token: 0x0400027C RID: 636
		private bool? _entryRequiresZip64;

		// Token: 0x0400027D RID: 637
		private bool? _OutputUsesZip64;

		// Token: 0x0400027E RID: 638
		private bool _IsText;

		// Token: 0x0400027F RID: 639
		private global::Ionic.Zip.ZipEntryTimestamp _timestamp;

		// Token: 0x04000280 RID: 640
		private static global::System.DateTime _unixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04000281 RID: 641
		private static global::System.DateTime _win32Epoch = global::System.DateTime.FromFileTimeUtc(0L);

		// Token: 0x04000282 RID: 642
		private static global::System.DateTime _zeroHour = new global::System.DateTime(1, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04000283 RID: 643
		private global::Ionic.Zip.WriteDelegate _WriteDelegate;

		// Token: 0x04000284 RID: 644
		private global::Ionic.Zip.OpenDelegate _OpenDelegate;

		// Token: 0x04000285 RID: 645
		private global::Ionic.Zip.CloseDelegate _CloseDelegate;

		// Token: 0x04000286 RID: 646
		private global::System.IO.Stream _inputDecryptorStream;

		// Token: 0x04000287 RID: 647
		private int _readExtraDepth;

		// Token: 0x04000288 RID: 648
		private object _outputLock = new object();

		// Token: 0x02000077 RID: 119
		private class CopyHelper
		{
			// Token: 0x06000559 RID: 1369 RVA: 0x00020A5E File Offset: 0x0001EC5E
			internal static void Reset()
			{
				global::Ionic.Zip.ZipEntry.CopyHelper.callCount = 0;
			}

			// Token: 0x0600055A RID: 1370 RVA: 0x00020A68 File Offset: 0x0001EC68
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

			// Token: 0x04000418 RID: 1048
			private static global::System.Text.RegularExpressions.Regex re = new global::System.Text.RegularExpressions.Regex(" \\(copy (\\d+)\\)$");

			// Token: 0x04000419 RID: 1049
			private static int callCount = 0;
		}

		// Token: 0x02000078 RID: 120
		// (Invoke) Token: 0x0600055E RID: 1374
		private delegate T Func<T>();
	}
}
