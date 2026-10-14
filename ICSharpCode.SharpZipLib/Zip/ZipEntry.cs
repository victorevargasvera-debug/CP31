using System;
using System.IO;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000012 RID: 18
	public class ZipEntry
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000328F File Offset: 0x0000148F
		public ZipEntry(string name) : this(name, 0, 51, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
		{
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000329C File Offset: 0x0000149C
		internal ZipEntry(string name, int versionRequiredToExtract) : this(name, versionRequiredToExtract, 51, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
		{
		}

		// Token: 0x0600006B RID: 107 RVA: 0x000032AC File Offset: 0x000014AC
		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method)
		{
			this.externalFileAttributes = -1;
			this.method = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
			this.zipFileIndex = -1L;
			base..ctor();
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (name.Length > 65535)
			{
				throw new global::System.ArgumentException("Name is too long", "name");
			}
			if (versionRequiredToExtract != 0 && versionRequiredToExtract < 10)
			{
				throw new global::System.ArgumentOutOfRangeException("versionRequiredToExtract");
			}
			this.DateTime = global::System.DateTime.Now;
			this.name = name;
			this.versionMadeBy = (ushort)madeByInfo;
			this.versionToExtract = (ushort)versionRequiredToExtract;
			this.method = method;
			this.IsUnicodeText = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.UseUnicode;
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00003348 File Offset: 0x00001548
		[global::System.Obsolete("Use Clone instead")]
		public ZipEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			this.externalFileAttributes = -1;
			this.method = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated;
			this.zipFileIndex = -1L;
			base..ctor();
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.known = entry.known;
			this.name = entry.name;
			this.size = entry.size;
			this.compressedSize = entry.compressedSize;
			this.crc = entry.crc;
			this.dateTime = entry.DateTime;
			this.method = entry.method;
			this.comment = entry.comment;
			this.versionToExtract = entry.versionToExtract;
			this.versionMadeBy = entry.versionMadeBy;
			this.externalFileAttributes = entry.externalFileAttributes;
			this.flags = entry.flags;
			this.zipFileIndex = entry.zipFileIndex;
			this.offset = entry.offset;
			this.forceZip64_ = entry.forceZip64_;
			if (entry.extra != null)
			{
				this.extra = new byte[entry.extra.Length];
				global::System.Array.Copy(entry.extra, 0, this.extra, 0, entry.extra.Length);
			}
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x0600006D RID: 109 RVA: 0x00003469 File Offset: 0x00001669
		public bool HasCrc
		{
			get
			{
				return (this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc) > global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None;
			}
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600006E RID: 110 RVA: 0x00003476 File Offset: 0x00001676
		// (set) Token: 0x0600006F RID: 111 RVA: 0x0000347F File Offset: 0x0000167F
		public bool IsCrypted
		{
			get
			{
				return this.HasFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.Encrypted);
			}
			set
			{
				this.SetFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.Encrypted, value);
			}
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000070 RID: 112 RVA: 0x00003489 File Offset: 0x00001689
		// (set) Token: 0x06000071 RID: 113 RVA: 0x00003496 File Offset: 0x00001696
		public bool IsUnicodeText
		{
			get
			{
				return this.HasFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.UnicodeText);
			}
			set
			{
				this.SetFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.UnicodeText, value);
			}
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x06000072 RID: 114 RVA: 0x000034A4 File Offset: 0x000016A4
		// (set) Token: 0x06000073 RID: 115 RVA: 0x000034AC File Offset: 0x000016AC
		internal byte CryptoCheckValue
		{
			get
			{
				return this.cryptoCheckValue_;
			}
			set
			{
				this.cryptoCheckValue_ = value;
			}
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000074 RID: 116 RVA: 0x000034B5 File Offset: 0x000016B5
		// (set) Token: 0x06000075 RID: 117 RVA: 0x000034BD File Offset: 0x000016BD
		public int Flags
		{
			get
			{
				return this.flags;
			}
			set
			{
				this.flags = value;
			}
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x06000076 RID: 118 RVA: 0x000034C6 File Offset: 0x000016C6
		// (set) Token: 0x06000077 RID: 119 RVA: 0x000034CE File Offset: 0x000016CE
		public long ZipFileIndex
		{
			get
			{
				return this.zipFileIndex;
			}
			set
			{
				this.zipFileIndex = value;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000078 RID: 120 RVA: 0x000034D7 File Offset: 0x000016D7
		// (set) Token: 0x06000079 RID: 121 RVA: 0x000034DF File Offset: 0x000016DF
		public long Offset
		{
			get
			{
				return this.offset;
			}
			set
			{
				this.offset = value;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x0600007A RID: 122 RVA: 0x000034E8 File Offset: 0x000016E8
		// (set) Token: 0x0600007B RID: 123 RVA: 0x000034FD File Offset: 0x000016FD
		public int ExternalFileAttributes
		{
			get
			{
				if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes) != global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
				{
					return this.externalFileAttributes;
				}
				return -1;
			}
			set
			{
				this.externalFileAttributes = value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x0600007C RID: 124 RVA: 0x00003515 File Offset: 0x00001715
		public int VersionMadeBy
		{
			get
			{
				return (int)(this.versionMadeBy & 255);
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x0600007D RID: 125 RVA: 0x00003523 File Offset: 0x00001723
		public bool IsDOSEntry
		{
			get
			{
				return this.HostSystem == 0 || this.HostSystem == 10;
			}
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000353C File Offset: 0x0000173C
		private bool HasDosAttributes(int attributes)
		{
			bool flag = false;
			if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.ExternalAttributes) != global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
			{
				flag |= ((this.HostSystem == 0 || this.HostSystem == 10) && (this.ExternalFileAttributes & attributes) == attributes);
			}
			return flag;
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x0600007F RID: 127 RVA: 0x0000357A File Offset: 0x0000177A
		// (set) Token: 0x06000080 RID: 128 RVA: 0x0000358A File Offset: 0x0000178A
		public int HostSystem
		{
			get
			{
				return this.versionMadeBy >> 8 & 255;
			}
			set
			{
				this.versionMadeBy &= 255;
				this.versionMadeBy |= (ushort)((value & 255) << 8);
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000081 RID: 129 RVA: 0x000035B8 File Offset: 0x000017B8
		public int Version
		{
			get
			{
				if (this.versionToExtract != 0)
				{
					return (int)(this.versionToExtract & 255);
				}
				if (this.AESKeySize > 0)
				{
					return 51;
				}
				if (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.BZip2 == this.method)
				{
					return 46;
				}
				if (this.CentralHeaderRequiresZip64)
				{
					return 45;
				}
				if (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated == this.method || this.IsDirectory || this.IsCrypted)
				{
					return 20;
				}
				if (this.HasDosAttributes(8))
				{
					return 11;
				}
				return 10;
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x06000082 RID: 130 RVA: 0x00003628 File Offset: 0x00001828
		public bool CanDecompress
		{
			get
			{
				return this.Version <= 51 && (this.Version == 10 || this.Version == 11 || this.Version == 20 || this.Version == 45 || this.Version == 46 || this.Version == 51) && this.IsCompressionMethodSupported();
			}
		}

		// Token: 0x06000083 RID: 131 RVA: 0x00003683 File Offset: 0x00001883
		public void ForceZip64()
		{
			this.forceZip64_ = true;
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000368C File Offset: 0x0000188C
		public bool IsZip64Forced()
		{
			return this.forceZip64_;
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x06000085 RID: 133 RVA: 0x00003694 File Offset: 0x00001894
		public bool LocalHeaderRequiresZip64
		{
			get
			{
				bool flag = this.forceZip64_;
				if (!flag)
				{
					ulong num = this.compressedSize;
					if (this.versionToExtract == 0 && this.IsCrypted)
					{
						num += (ulong)((long)this.EncryptionOverheadSize);
					}
					flag = ((this.size >= (ulong)-1 || num >= (ulong)-1) && (this.versionToExtract == 0 || this.versionToExtract >= 45));
				}
				return flag;
			}
		}

		// Token: 0x17000021 RID: 33
		// (get) Token: 0x06000086 RID: 134 RVA: 0x000036F8 File Offset: 0x000018F8
		public bool CentralHeaderRequiresZip64
		{
			get
			{
				return this.LocalHeaderRequiresZip64 || this.offset >= (long)((ulong)-1);
			}
		}

		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000087 RID: 135 RVA: 0x00003714 File Offset: 0x00001914
		// (set) Token: 0x06000088 RID: 136 RVA: 0x000037F4 File Offset: 0x000019F4
		public long DosTime
		{
			get
			{
				if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Time) == global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
				{
					return 0L;
				}
				uint num = (uint)this.DateTime.Year;
				uint num2 = (uint)this.DateTime.Month;
				uint num3 = (uint)this.DateTime.Day;
				uint num4 = (uint)this.DateTime.Hour;
				uint num5 = (uint)this.DateTime.Minute;
				uint num6 = (uint)this.DateTime.Second;
				if (num < 1980U)
				{
					num = 1980U;
					num2 = 1U;
					num3 = 1U;
					num4 = 0U;
					num5 = 0U;
					num6 = 0U;
				}
				else if (num > 2107U)
				{
					num = 2107U;
					num2 = 12U;
					num3 = 31U;
					num4 = 23U;
					num5 = 59U;
					num6 = 59U;
				}
				return (long)((ulong)((num - 1980U & 127U) << 25 | num2 << 21 | num3 << 16 | num4 << 11 | num5 << 5 | num6 >> 1));
			}
			set
			{
				uint num = (uint)value;
				uint second = global::System.Math.Min(59U, 2U * (num & 31U));
				uint minute = global::System.Math.Min(59U, num >> 5 & 63U);
				uint hour = global::System.Math.Min(23U, num >> 11 & 31U);
				uint month = global::System.Math.Max(1U, global::System.Math.Min(12U, (uint)(value >> 21) & 15U));
				uint year = (num >> 25 & 127U) + 1980U;
				int day = global::System.Math.Max(1, global::System.Math.Min(global::System.DateTime.DaysInMonth((int)year, (int)month), (int)(value >> 16 & 31L)));
				this.DateTime = new global::System.DateTime((int)year, (int)month, day, (int)hour, (int)minute, (int)second, global::System.DateTimeKind.Unspecified);
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000089 RID: 137 RVA: 0x00003889 File Offset: 0x00001A89
		// (set) Token: 0x0600008A RID: 138 RVA: 0x00003891 File Offset: 0x00001A91
		public global::System.DateTime DateTime
		{
			get
			{
				return this.dateTime;
			}
			set
			{
				this.dateTime = value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Time;
			}
		}

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008B RID: 139 RVA: 0x000038A8 File Offset: 0x00001AA8
		// (set) Token: 0x0600008C RID: 140 RVA: 0x000038B0 File Offset: 0x00001AB0
		public string Name
		{
			get
			{
				return this.name;
			}
			internal set
			{
				this.name = value;
			}
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x0600008D RID: 141 RVA: 0x000038B9 File Offset: 0x00001AB9
		// (set) Token: 0x0600008E RID: 142 RVA: 0x000038CE File Offset: 0x00001ACE
		public long Size
		{
			get
			{
				if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Size) == global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
				{
					return -1L;
				}
				return (long)this.size;
			}
			set
			{
				this.size = (ulong)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Size;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x0600008F RID: 143 RVA: 0x000038E5 File Offset: 0x00001AE5
		// (set) Token: 0x06000090 RID: 144 RVA: 0x000038FA File Offset: 0x00001AFA
		public long CompressedSize
		{
			get
			{
				if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.CompressedSize) == global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
				{
					return -1L;
				}
				return (long)this.compressedSize;
			}
			set
			{
				this.compressedSize = (ulong)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.CompressedSize;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x06000091 RID: 145 RVA: 0x00003911 File Offset: 0x00001B11
		// (set) Token: 0x06000092 RID: 146 RVA: 0x0000392A File Offset: 0x00001B2A
		public long Crc
		{
			get
			{
				if ((this.known & global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc) == global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.None)
				{
					return -1L;
				}
				return (long)((ulong)this.crc & (ulong)-1);
			}
			set
			{
				if (((ulong)this.crc & 18446744069414584320UL) != 0UL)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.crc = (uint)value;
				this.known |= global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known.Crc;
			}
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x06000093 RID: 147 RVA: 0x00003960 File Offset: 0x00001B60
		// (set) Token: 0x06000094 RID: 148 RVA: 0x00003968 File Offset: 0x00001B68
		public global::ICSharpCode.SharpZipLib.Zip.CompressionMethod CompressionMethod
		{
			get
			{
				return this.method;
			}
			set
			{
				this.method = value;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x06000095 RID: 149 RVA: 0x00003971 File Offset: 0x00001B71
		internal global::ICSharpCode.SharpZipLib.Zip.CompressionMethod CompressionMethodForHeader
		{
			get
			{
				if (this.AESKeySize <= 0)
				{
					return this.method;
				}
				return global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.WinZipAES;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x06000096 RID: 150 RVA: 0x00003985 File Offset: 0x00001B85
		// (set) Token: 0x06000097 RID: 151 RVA: 0x00003990 File Offset: 0x00001B90
		public byte[] ExtraData
		{
			get
			{
				return this.extra;
			}
			set
			{
				if (value == null)
				{
					this.extra = null;
					return;
				}
				if (value.Length > 65535)
				{
					throw new global::System.ArgumentOutOfRangeException("value");
				}
				this.extra = new byte[value.Length];
				global::System.Array.Copy(value, 0, this.extra, 0, value.Length);
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x06000098 RID: 152 RVA: 0x000039DC File Offset: 0x00001BDC
		// (set) Token: 0x06000099 RID: 153 RVA: 0x00003A38 File Offset: 0x00001C38
		public int AESKeySize
		{
			get
			{
				switch (this._aesEncryptionStrength)
				{
				case 0:
					return 0;
				case 1:
					return 128;
				case 2:
					return 192;
				case 3:
					return 256;
				default:
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid AESEncryptionStrength " + this._aesEncryptionStrength.ToString());
				}
			}
			set
			{
				if (value == 0)
				{
					this._aesEncryptionStrength = 0;
					return;
				}
				if (value == 128)
				{
					this._aesEncryptionStrength = 1;
					return;
				}
				if (value != 256)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("AESKeySize must be 0, 128 or 256: " + value.ToString());
				}
				this._aesEncryptionStrength = 3;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x0600009A RID: 154 RVA: 0x00003A88 File Offset: 0x00001C88
		internal byte AESEncryptionStrength
		{
			get
			{
				return (byte)this._aesEncryptionStrength;
			}
		}

		// Token: 0x1700002D RID: 45
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00003A91 File Offset: 0x00001C91
		internal int AESSaltLen
		{
			get
			{
				return this.AESKeySize / 16;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x0600009C RID: 156 RVA: 0x00003A9C File Offset: 0x00001C9C
		internal int AESOverheadSize
		{
			get
			{
				return 12 + this.AESSaltLen;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x0600009D RID: 157 RVA: 0x00003AA7 File Offset: 0x00001CA7
		internal int EncryptionOverheadSize
		{
			get
			{
				if (!this.IsCrypted)
				{
					return 0;
				}
				if (this._aesEncryptionStrength != 0)
				{
					return this.AESOverheadSize;
				}
				return 12;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00003AC4 File Offset: 0x00001CC4
		internal void ProcessExtraData(bool localHeader)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(this.extra);
			if (zipExtraData.Find(1))
			{
				this.forceZip64_ = true;
				if (zipExtraData.ValueLength < 4)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Extra data extended Zip64 information length is invalid");
				}
				if (this.size == (ulong)-1)
				{
					this.size = (ulong)zipExtraData.ReadLong();
				}
				if (this.compressedSize == (ulong)-1)
				{
					this.compressedSize = (ulong)zipExtraData.ReadLong();
				}
				if (!localHeader && this.offset == (long)((ulong)-1))
				{
					this.offset = zipExtraData.ReadLong();
				}
			}
			else if ((this.versionToExtract & 255) >= 45 && (this.size == (ulong)-1 || this.compressedSize == (ulong)-1))
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Zip64 Extended information required but is missing.");
			}
			this.DateTime = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry.GetDateTime(zipExtraData) ?? this.DateTime);
			if (this.method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.WinZipAES)
			{
				this.ProcessAESExtraData(zipExtraData);
			}
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00003BB0 File Offset: 0x00001DB0
		private static global::System.DateTime? GetDateTime(global::ICSharpCode.SharpZipLib.Zip.ZipExtraData extraData)
		{
			global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData data = extraData.GetData<global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData>();
			if (data != null && data.Include.HasFlag(global::ICSharpCode.SharpZipLib.Zip.ExtendedUnixData.Flags.ModificationTime))
			{
				return new global::System.DateTime?(data.ModificationTime);
			}
			return null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00003BF4 File Offset: 0x00001DF4
		private void ProcessAESExtraData(global::ICSharpCode.SharpZipLib.Zip.ZipExtraData extraData)
		{
			if (!extraData.Find(39169))
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("AES Extra Data missing");
			}
			this.versionToExtract = 51;
			int valueLength = extraData.ValueLength;
			if (valueLength < 7)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("AES Extra Data Length " + valueLength.ToString() + " invalid.");
			}
			int aesVer = extraData.ReadShort();
			extraData.ReadShort();
			int aesEncryptionStrength = extraData.ReadByte();
			int num = extraData.ReadShort();
			this._aesVer = aesVer;
			this._aesEncryptionStrength = aesEncryptionStrength;
			this.method = (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)num;
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000A1 RID: 161 RVA: 0x00003C79 File Offset: 0x00001E79
		// (set) Token: 0x060000A2 RID: 162 RVA: 0x00003C81 File Offset: 0x00001E81
		public string Comment
		{
			get
			{
				return this.comment;
			}
			set
			{
				if (value != null && value.Length > 65535)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "cannot exceed 65535");
				}
				this.comment = value;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00003CAC File Offset: 0x00001EAC
		public bool IsDirectory
		{
			get
			{
				return (this.name.Length > 0 && (this.name[this.name.Length - 1] == '/' || this.name[this.name.Length - 1] == '\\')) || this.HasDosAttributes(16);
			}
		}

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00003D09 File Offset: 0x00001F09
		public bool IsFile
		{
			get
			{
				return !this.IsDirectory && !this.HasDosAttributes(8);
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00003D1F File Offset: 0x00001F1F
		public bool IsCompressionMethodSupported()
		{
			return global::ICSharpCode.SharpZipLib.Zip.ZipEntry.IsCompressionMethodSupported(this.CompressionMethod);
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00003D2C File Offset: 0x00001F2C
		public object Clone()
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)base.MemberwiseClone();
			if (this.extra != null)
			{
				zipEntry.extra = new byte[this.extra.Length];
				global::System.Array.Copy(this.extra, 0, zipEntry.extra, 0, this.extra.Length);
			}
			return zipEntry;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x00003D7C File Offset: 0x00001F7C
		public override string ToString()
		{
			return this.name;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00003D84 File Offset: 0x00001F84
		public static bool IsCompressionMethodSupported(global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method)
		{
			return method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated || method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored || method == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.BZip2;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00003D94 File Offset: 0x00001F94
		public static string CleanName(string name)
		{
			if (name == null)
			{
				return string.Empty;
			}
			if (global::System.IO.Path.IsPathRooted(name))
			{
				name = name.Substring(global::System.IO.Path.GetPathRoot(name).Length);
			}
			name = name.Replace("\\", "/");
			while (name.Length > 0 && name[0] == '/')
			{
				name = name.Remove(0, 1);
			}
			return name;
		}

		// Token: 0x0400008F RID: 143
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry.Known known;

		// Token: 0x04000090 RID: 144
		private int externalFileAttributes;

		// Token: 0x04000091 RID: 145
		private ushort versionMadeBy;

		// Token: 0x04000092 RID: 146
		private string name;

		// Token: 0x04000093 RID: 147
		private ulong size;

		// Token: 0x04000094 RID: 148
		private ulong compressedSize;

		// Token: 0x04000095 RID: 149
		private ushort versionToExtract;

		// Token: 0x04000096 RID: 150
		private uint crc;

		// Token: 0x04000097 RID: 151
		private global::System.DateTime dateTime;

		// Token: 0x04000098 RID: 152
		private global::ICSharpCode.SharpZipLib.Zip.CompressionMethod method;

		// Token: 0x04000099 RID: 153
		private byte[] extra;

		// Token: 0x0400009A RID: 154
		private string comment;

		// Token: 0x0400009B RID: 155
		private int flags;

		// Token: 0x0400009C RID: 156
		private long zipFileIndex;

		// Token: 0x0400009D RID: 157
		private long offset;

		// Token: 0x0400009E RID: 158
		private bool forceZip64_;

		// Token: 0x0400009F RID: 159
		private byte cryptoCheckValue_;

		// Token: 0x040000A0 RID: 160
		private int _aesVer;

		// Token: 0x040000A1 RID: 161
		private int _aesEncryptionStrength;

		// Token: 0x0200007D RID: 125
		[global::System.Flags]
		private enum Known : byte
		{
			// Token: 0x0400032A RID: 810
			None = 0,
			// Token: 0x0400032B RID: 811
			Size = 1,
			// Token: 0x0400032C RID: 812
			CompressedSize = 2,
			// Token: 0x0400032D RID: 813
			Crc = 4,
			// Token: 0x0400032E RID: 814
			Time = 8,
			// Token: 0x0400032F RID: 815
			ExternalAttributes = 16
		}
	}
}
