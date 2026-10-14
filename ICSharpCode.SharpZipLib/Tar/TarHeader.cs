using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000049 RID: 73
	public class TarHeader
	{
		// Token: 0x06000353 RID: 851 RVA: 0x00010080 File Offset: 0x0000E280
		public TarHeader()
		{
			this.Magic = "ustar";
			this.Version = " ";
			this.Name = "";
			this.LinkName = "";
			this.UserId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId;
			this.GroupId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId;
			this.UserName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser;
			this.GroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName;
			this.Size = 0L;
		}

		// Token: 0x170000C0 RID: 192
		// (get) Token: 0x06000354 RID: 852 RVA: 0x000100F3 File Offset: 0x0000E2F3
		// (set) Token: 0x06000355 RID: 853 RVA: 0x000100FB File Offset: 0x0000E2FB
		public string Name
		{
			get
			{
				return this.name;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.name = value;
			}
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00010112 File Offset: 0x0000E312
		[global::System.Obsolete("Use the Name property instead", true)]
		public string GetName()
		{
			return this.name;
		}

		// Token: 0x170000C1 RID: 193
		// (get) Token: 0x06000357 RID: 855 RVA: 0x0001011A File Offset: 0x0000E31A
		// (set) Token: 0x06000358 RID: 856 RVA: 0x00010122 File Offset: 0x0000E322
		public int Mode
		{
			get
			{
				return this.mode;
			}
			set
			{
				this.mode = value;
			}
		}

		// Token: 0x170000C2 RID: 194
		// (get) Token: 0x06000359 RID: 857 RVA: 0x0001012B File Offset: 0x0000E32B
		// (set) Token: 0x0600035A RID: 858 RVA: 0x00010133 File Offset: 0x0000E333
		public int UserId
		{
			get
			{
				return this.userId;
			}
			set
			{
				this.userId = value;
			}
		}

		// Token: 0x170000C3 RID: 195
		// (get) Token: 0x0600035B RID: 859 RVA: 0x0001013C File Offset: 0x0000E33C
		// (set) Token: 0x0600035C RID: 860 RVA: 0x00010144 File Offset: 0x0000E344
		public int GroupId
		{
			get
			{
				return this.groupId;
			}
			set
			{
				this.groupId = value;
			}
		}

		// Token: 0x170000C4 RID: 196
		// (get) Token: 0x0600035D RID: 861 RVA: 0x0001014D File Offset: 0x0000E34D
		// (set) Token: 0x0600035E RID: 862 RVA: 0x00010155 File Offset: 0x0000E355
		public long Size
		{
			get
			{
				return this.size;
			}
			set
			{
				if (value < 0L)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "Cannot be less than zero");
				}
				this.size = value;
			}
		}

		// Token: 0x170000C5 RID: 197
		// (get) Token: 0x0600035F RID: 863 RVA: 0x00010173 File Offset: 0x0000E373
		// (set) Token: 0x06000360 RID: 864 RVA: 0x0001017C File Offset: 0x0000E37C
		public global::System.DateTime ModTime
		{
			get
			{
				return this.modTime;
			}
			set
			{
				if (value < global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "ModTime cannot be before Jan 1st 1970");
				}
				this.modTime = new global::System.DateTime(value.Year, value.Month, value.Day, value.Hour, value.Minute, value.Second);
			}
		}

		// Token: 0x170000C6 RID: 198
		// (get) Token: 0x06000361 RID: 865 RVA: 0x000101DB File Offset: 0x0000E3DB
		public int Checksum
		{
			get
			{
				return this.checksum;
			}
		}

		// Token: 0x170000C7 RID: 199
		// (get) Token: 0x06000362 RID: 866 RVA: 0x000101E3 File Offset: 0x0000E3E3
		public bool IsChecksumValid
		{
			get
			{
				return this.isChecksumValid;
			}
		}

		// Token: 0x170000C8 RID: 200
		// (get) Token: 0x06000363 RID: 867 RVA: 0x000101EB File Offset: 0x0000E3EB
		// (set) Token: 0x06000364 RID: 868 RVA: 0x000101F3 File Offset: 0x0000E3F3
		public byte TypeFlag
		{
			get
			{
				return this.typeFlag;
			}
			set
			{
				this.typeFlag = value;
			}
		}

		// Token: 0x170000C9 RID: 201
		// (get) Token: 0x06000365 RID: 869 RVA: 0x000101FC File Offset: 0x0000E3FC
		// (set) Token: 0x06000366 RID: 870 RVA: 0x00010204 File Offset: 0x0000E404
		public string LinkName
		{
			get
			{
				return this.linkName;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.linkName = value;
			}
		}

		// Token: 0x170000CA RID: 202
		// (get) Token: 0x06000367 RID: 871 RVA: 0x0001021B File Offset: 0x0000E41B
		// (set) Token: 0x06000368 RID: 872 RVA: 0x00010223 File Offset: 0x0000E423
		public string Magic
		{
			get
			{
				return this.magic;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.magic = value;
			}
		}

		// Token: 0x170000CB RID: 203
		// (get) Token: 0x06000369 RID: 873 RVA: 0x0001023A File Offset: 0x0000E43A
		// (set) Token: 0x0600036A RID: 874 RVA: 0x00010242 File Offset: 0x0000E442
		public string Version
		{
			get
			{
				return this.version;
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				this.version = value;
			}
		}

		// Token: 0x170000CC RID: 204
		// (get) Token: 0x0600036B RID: 875 RVA: 0x00010259 File Offset: 0x0000E459
		// (set) Token: 0x0600036C RID: 876 RVA: 0x00010264 File Offset: 0x0000E464
		public string UserName
		{
			get
			{
				return this.userName;
			}
			set
			{
				if (value != null)
				{
					this.userName = value.Substring(0, global::System.Math.Min(32, value.Length));
					return;
				}
				string text = "user";
				if (text.Length > 32)
				{
					text = text.Substring(0, 32);
				}
				this.userName = text;
			}
		}

		// Token: 0x170000CD RID: 205
		// (get) Token: 0x0600036D RID: 877 RVA: 0x000102B0 File Offset: 0x0000E4B0
		// (set) Token: 0x0600036E RID: 878 RVA: 0x000102B8 File Offset: 0x0000E4B8
		public string GroupName
		{
			get
			{
				return this.groupName;
			}
			set
			{
				if (value == null)
				{
					this.groupName = "None";
					return;
				}
				this.groupName = value;
			}
		}

		// Token: 0x170000CE RID: 206
		// (get) Token: 0x0600036F RID: 879 RVA: 0x000102D0 File Offset: 0x0000E4D0
		// (set) Token: 0x06000370 RID: 880 RVA: 0x000102D8 File Offset: 0x0000E4D8
		public int DevMajor
		{
			get
			{
				return this.devMajor;
			}
			set
			{
				this.devMajor = value;
			}
		}

		// Token: 0x170000CF RID: 207
		// (get) Token: 0x06000371 RID: 881 RVA: 0x000102E1 File Offset: 0x0000E4E1
		// (set) Token: 0x06000372 RID: 882 RVA: 0x000102E9 File Offset: 0x0000E4E9
		public int DevMinor
		{
			get
			{
				return this.devMinor;
			}
			set
			{
				this.devMinor = value;
			}
		}

		// Token: 0x06000373 RID: 883 RVA: 0x000102F2 File Offset: 0x0000E4F2
		public object Clone()
		{
			return base.MemberwiseClone();
		}

		// Token: 0x06000374 RID: 884 RVA: 0x000102FC File Offset: 0x0000E4FC
		public void ParseBuffer(byte[] header, global::System.Text.Encoding nameEncoding)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			int num = 0;
			this.name = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 100, nameEncoding).ToString();
			num += 100;
			this.mode = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.UserId = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.GroupId = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.Size = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseBinaryOrOctal(header, num, 12);
			num += 12;
			this.ModTime = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetDateTimeFromCTime(global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 12));
			num += 12;
			this.checksum = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
			num += 8;
			this.TypeFlag = header[num++];
			this.LinkName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 100, nameEncoding).ToString();
			num += 100;
			this.Magic = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 6, nameEncoding).ToString();
			num += 6;
			if (this.Magic == "ustar")
			{
				this.Version = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 2, nameEncoding).ToString();
				num += 2;
				this.UserName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 32, nameEncoding).ToString();
				num += 32;
				this.GroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 32, nameEncoding).ToString();
				num += 32;
				this.DevMajor = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
				num += 8;
				this.DevMinor = (int)global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, num, 8);
				num += 8;
				string text = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, num, 155, nameEncoding).ToString();
				if (!string.IsNullOrEmpty(text))
				{
					this.Name = text + "/" + this.Name;
				}
			}
			this.isChecksumValid = (this.Checksum == global::ICSharpCode.SharpZipLib.Tar.TarHeader.MakeCheckSum(header));
		}

		// Token: 0x06000375 RID: 885 RVA: 0x000104B8 File Offset: 0x0000E6B8
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public void ParseBuffer(byte[] header)
		{
			this.ParseBuffer(header, null);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000104C2 File Offset: 0x0000E6C2
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public void WriteHeader(byte[] outBuffer)
		{
			this.WriteHeader(outBuffer, null);
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000104CC File Offset: 0x0000E6CC
		public void WriteHeader(byte[] outBuffer, global::System.Text.Encoding nameEncoding)
		{
			if (outBuffer == null)
			{
				throw new global::System.ArgumentNullException("outBuffer");
			}
			int i = 0;
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.Name, outBuffer, i, 100, nameEncoding);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.mode, outBuffer, i, 8);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.UserId, outBuffer, i, 8);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.GroupId, outBuffer, i, 8);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetBinaryOrOctalBytes(this.Size, outBuffer, i, 12);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetCTime(this.ModTime), outBuffer, i, 12);
			int offset = i;
			for (int j = 0; j < 8; j++)
			{
				outBuffer[i++] = 32;
			}
			outBuffer[i++] = this.TypeFlag;
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.LinkName, outBuffer, i, 100, nameEncoding);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetAsciiBytes(this.Magic, 0, outBuffer, i, 6, nameEncoding);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.Version, outBuffer, i, 2, nameEncoding);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.UserName, outBuffer, i, 32, nameEncoding);
			i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(this.GroupName, outBuffer, i, 32, nameEncoding);
			if (this.TypeFlag == 51 || this.TypeFlag == 52)
			{
				i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.DevMajor, outBuffer, i, 8);
				i = global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes((long)this.DevMinor, outBuffer, i, 8);
			}
			while (i < outBuffer.Length)
			{
				outBuffer[i++] = 0;
			}
			this.checksum = global::ICSharpCode.SharpZipLib.Tar.TarHeader.ComputeCheckSum(outBuffer);
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetCheckSumOctalBytes((long)this.checksum, outBuffer, offset, 8);
			this.isChecksumValid = true;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001062E File Offset: 0x0000E82E
		public override int GetHashCode()
		{
			return this.Name.GetHashCode();
		}

		// Token: 0x06000379 RID: 889 RVA: 0x0001063C File Offset: 0x0000E83C
		public override bool Equals(object obj)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader tarHeader = obj as global::ICSharpCode.SharpZipLib.Tar.TarHeader;
			return tarHeader != null && (this.name == tarHeader.name && this.mode == tarHeader.mode && this.UserId == tarHeader.UserId && this.GroupId == tarHeader.GroupId && this.Size == tarHeader.Size && this.ModTime == tarHeader.ModTime && this.Checksum == tarHeader.Checksum && this.TypeFlag == tarHeader.TypeFlag && this.LinkName == tarHeader.LinkName && this.Magic == tarHeader.Magic && this.Version == tarHeader.Version && this.UserName == tarHeader.UserName && this.GroupName == tarHeader.GroupName && this.DevMajor == tarHeader.DevMajor) && this.DevMinor == tarHeader.DevMinor;
		}

		// Token: 0x0600037A RID: 890 RVA: 0x00010769 File Offset: 0x0000E969
		internal static void SetValueDefaults(int userId, string userName, int groupId, string groupName)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.userIdAsSet = userId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId = userId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.userNameAsSet = userName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser = userName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupIdAsSet = groupId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId = groupId;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupNameAsSet = groupName;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName = groupName;
		}

		// Token: 0x0600037B RID: 891 RVA: 0x0001079B File Offset: 0x0000E99B
		internal static void RestoreSetValues()
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUserId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.userIdAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultUser = global::ICSharpCode.SharpZipLib.Tar.TarHeader.userNameAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupId = global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupIdAsSet;
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.defaultGroupName = global::ICSharpCode.SharpZipLib.Tar.TarHeader.groupNameAsSet;
		}

		// Token: 0x0600037C RID: 892 RVA: 0x000107C8 File Offset: 0x0000E9C8
		private static long ParseBinaryOrOctal(byte[] header, int offset, int length)
		{
			if (header[offset] >= 128)
			{
				long num = 0L;
				for (int i = length - 8; i < length; i++)
				{
					num = (num << 8 | (long)((ulong)header[offset + i]));
				}
				return num;
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseOctal(header, offset, length);
		}

		// Token: 0x0600037D RID: 893 RVA: 0x00010808 File Offset: 0x0000EA08
		public static long ParseOctal(byte[] header, int offset, int length)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			long num = 0L;
			bool flag = true;
			int num2 = offset + length;
			int num3 = offset;
			while (num3 < num2 && header[num3] != 0)
			{
				if (header[num3] != 32 && header[num3] != 48)
				{
					goto IL_38;
				}
				if (!flag)
				{
					if (header[num3] != 32)
					{
						goto IL_38;
					}
					break;
				}
				IL_46:
				num3++;
				continue;
				IL_38:
				flag = false;
				num = (num << 3) + (long)(header[num3] - 48);
				goto IL_46;
			}
			return num;
		}

		// Token: 0x0600037E RID: 894 RVA: 0x00010864 File Offset: 0x0000EA64
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static global::System.Text.StringBuilder ParseName(byte[] header, int offset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.ParseName(header, offset, length, null);
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00010870 File Offset: 0x0000EA70
		public static global::System.Text.StringBuilder ParseName(byte[] header, int offset, int length, global::System.Text.Encoding encoding)
		{
			if (header == null)
			{
				throw new global::System.ArgumentNullException("header");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be less than zero");
			}
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length", "Cannot be less than zero");
			}
			if (offset + length > header.Length)
			{
				throw new global::System.ArgumentException("Exceeds header size", "length");
			}
			global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder(length);
			int num = 0;
			if (encoding == null)
			{
				for (int i = offset; i < offset + length; i++)
				{
					if (header[i] == 0)
					{
						break;
					}
					stringBuilder.Append((char)header[i]);
				}
			}
			else
			{
				int num2 = offset;
				while (num2 < offset + length && header[num2] != 0)
				{
					num2++;
					num++;
				}
				stringBuilder.Append(encoding.GetString(header, offset, num));
			}
			return stringBuilder;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x0001091E File Offset: 0x0000EB1E
		public static int GetNameBytes(global::System.Text.StringBuilder name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name.ToString(), nameOffset, buffer, bufferOffset, length, null);
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00010931 File Offset: 0x0000EB31
		public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name, nameOffset, buffer, bufferOffset, length, null);
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00010940 File Offset: 0x0000EB40
		public static int GetNameBytes(string name, int nameOffset, byte[] buffer, int bufferOffset, int length, global::System.Text.Encoding encoding)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int i;
			if (encoding != null)
			{
				char[] array = name.ToCharArray(nameOffset, global::System.Math.Min(name.Length - nameOffset, length));
				byte[] bytes = encoding.GetBytes(array, 0, array.Length);
				i = global::System.Math.Min(bytes.Length, length);
				global::System.Array.Copy(bytes, 0, buffer, bufferOffset, i);
			}
			else
			{
				for (i = 0; i < length; i++)
				{
					if (nameOffset + i >= name.Length)
					{
						break;
					}
					buffer[bufferOffset + i] = (byte)name[nameOffset + i];
				}
			}
			while (i < length)
			{
				buffer[bufferOffset + i] = 0;
				i++;
			}
			return bufferOffset + length;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x000109E2 File Offset: 0x0000EBE2
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static int GetNameBytes(global::System.Text.StringBuilder name, byte[] buffer, int offset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name, buffer, offset, length, null);
		}

		// Token: 0x06000384 RID: 900 RVA: 0x000109EE File Offset: 0x0000EBEE
		public static int GetNameBytes(global::System.Text.StringBuilder name, byte[] buffer, int offset, int length, global::System.Text.Encoding encoding)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name.ToString(), 0, buffer, offset, length, encoding);
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00010A1D File Offset: 0x0000EC1D
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static int GetNameBytes(string name, byte[] buffer, int offset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name, buffer, offset, length, null);
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00010A29 File Offset: 0x0000EC29
		public static int GetNameBytes(string name, byte[] buffer, int offset, int length, global::System.Text.Encoding encoding)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetNameBytes(name, 0, buffer, offset, length, encoding);
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00010A53 File Offset: 0x0000EC53
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetAsciiBytes(toAdd, nameOffset, buffer, bufferOffset, length, null);
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00010A64 File Offset: 0x0000EC64
		public static int GetAsciiBytes(string toAdd, int nameOffset, byte[] buffer, int bufferOffset, int length, global::System.Text.Encoding encoding)
		{
			if (toAdd == null)
			{
				throw new global::System.ArgumentNullException("toAdd");
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int i;
			if (encoding == null)
			{
				for (i = 0; i < length; i++)
				{
					if (nameOffset + i >= toAdd.Length)
					{
						break;
					}
					buffer[bufferOffset + i] = (byte)toAdd[nameOffset + i];
				}
			}
			else
			{
				char[] chars = toAdd.ToCharArray();
				byte[] bytes = encoding.GetBytes(chars, nameOffset, global::System.Math.Min(toAdd.Length - nameOffset, length));
				i = global::System.Math.Min(bytes.Length, length);
				global::System.Array.Copy(bytes, 0, buffer, bufferOffset, i);
			}
			while (i < length)
			{
				buffer[bufferOffset + i] = 0;
				i++;
			}
			return bufferOffset + length;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00010B04 File Offset: 0x0000ED04
		public static int GetOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			int i = length - 1;
			buffer[offset + i] = 0;
			i--;
			if (value > 0L)
			{
				long num = value;
				while (i >= 0)
				{
					if (num <= 0L)
					{
						break;
					}
					buffer[offset + i] = 48 + (byte)(num & 7L);
					num >>= 3;
					i--;
				}
			}
			while (i >= 0)
			{
				buffer[offset + i] = 48;
				i--;
			}
			return offset + length;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00010B6C File Offset: 0x0000ED6C
		private static int GetBinaryOrOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			if (value > 8589934591L)
			{
				for (int i = length - 1; i > 0; i--)
				{
					buffer[offset + i] = (byte)value;
					value >>= 8;
				}
				buffer[offset] = 128;
				return offset + length;
			}
			return global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes(value, buffer, offset, length);
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00010BB4 File Offset: 0x0000EDB4
		private static void GetCheckSumOctalBytes(long value, byte[] buffer, int offset, int length)
		{
			global::ICSharpCode.SharpZipLib.Tar.TarHeader.GetOctalBytes(value, buffer, offset, length - 1);
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00010BC4 File Offset: 0x0000EDC4
		private static int ComputeCheckSum(byte[] buffer)
		{
			int num = 0;
			for (int i = 0; i < buffer.Length; i++)
			{
				num += (int)buffer[i];
			}
			return num;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00010BE8 File Offset: 0x0000EDE8
		private static int MakeCheckSum(byte[] buffer)
		{
			int num = 0;
			for (int i = 0; i < 148; i++)
			{
				num += (int)buffer[i];
			}
			for (int j = 0; j < 8; j++)
			{
				num += 32;
			}
			for (int k = 156; k < buffer.Length; k++)
			{
				num += (int)buffer[k];
			}
			return num;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00010C38 File Offset: 0x0000EE38
		private static int GetCTime(global::System.DateTime dateTime)
		{
			return (int)((dateTime.Ticks - global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970.Ticks) / 10000000L);
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00010C64 File Offset: 0x0000EE64
		private static global::System.DateTime GetDateTimeFromCTime(long ticks)
		{
			global::System.DateTime result;
			try
			{
				result = new global::System.DateTime(global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970.Ticks + ticks * 10000000L);
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				result = global::ICSharpCode.SharpZipLib.Tar.TarHeader.dateTime1970;
			}
			return result;
		}

		// Token: 0x040001EE RID: 494
		public const int NAMELEN = 100;

		// Token: 0x040001EF RID: 495
		public const int MODELEN = 8;

		// Token: 0x040001F0 RID: 496
		public const int UIDLEN = 8;

		// Token: 0x040001F1 RID: 497
		public const int GIDLEN = 8;

		// Token: 0x040001F2 RID: 498
		public const int CHKSUMLEN = 8;

		// Token: 0x040001F3 RID: 499
		public const int CHKSUMOFS = 148;

		// Token: 0x040001F4 RID: 500
		public const int SIZELEN = 12;

		// Token: 0x040001F5 RID: 501
		public const int MAGICLEN = 6;

		// Token: 0x040001F6 RID: 502
		public const int VERSIONLEN = 2;

		// Token: 0x040001F7 RID: 503
		public const int MODTIMELEN = 12;

		// Token: 0x040001F8 RID: 504
		public const int UNAMELEN = 32;

		// Token: 0x040001F9 RID: 505
		public const int GNAMELEN = 32;

		// Token: 0x040001FA RID: 506
		public const int DEVLEN = 8;

		// Token: 0x040001FB RID: 507
		public const int PREFIXLEN = 155;

		// Token: 0x040001FC RID: 508
		public const byte LF_OLDNORM = 0;

		// Token: 0x040001FD RID: 509
		public const byte LF_NORMAL = 48;

		// Token: 0x040001FE RID: 510
		public const byte LF_LINK = 49;

		// Token: 0x040001FF RID: 511
		public const byte LF_SYMLINK = 50;

		// Token: 0x04000200 RID: 512
		public const byte LF_CHR = 51;

		// Token: 0x04000201 RID: 513
		public const byte LF_BLK = 52;

		// Token: 0x04000202 RID: 514
		public const byte LF_DIR = 53;

		// Token: 0x04000203 RID: 515
		public const byte LF_FIFO = 54;

		// Token: 0x04000204 RID: 516
		public const byte LF_CONTIG = 55;

		// Token: 0x04000205 RID: 517
		public const byte LF_GHDR = 103;

		// Token: 0x04000206 RID: 518
		public const byte LF_XHDR = 120;

		// Token: 0x04000207 RID: 519
		public const byte LF_ACL = 65;

		// Token: 0x04000208 RID: 520
		public const byte LF_GNU_DUMPDIR = 68;

		// Token: 0x04000209 RID: 521
		public const byte LF_EXTATTR = 69;

		// Token: 0x0400020A RID: 522
		public const byte LF_META = 73;

		// Token: 0x0400020B RID: 523
		public const byte LF_GNU_LONGLINK = 75;

		// Token: 0x0400020C RID: 524
		public const byte LF_GNU_LONGNAME = 76;

		// Token: 0x0400020D RID: 525
		public const byte LF_GNU_MULTIVOL = 77;

		// Token: 0x0400020E RID: 526
		public const byte LF_GNU_NAMES = 78;

		// Token: 0x0400020F RID: 527
		public const byte LF_GNU_SPARSE = 83;

		// Token: 0x04000210 RID: 528
		public const byte LF_GNU_VOLHDR = 86;

		// Token: 0x04000211 RID: 529
		public const string TMAGIC = "ustar";

		// Token: 0x04000212 RID: 530
		public const string GNU_TMAGIC = "ustar  ";

		// Token: 0x04000213 RID: 531
		private const long timeConversionFactor = 10000000L;

		// Token: 0x04000214 RID: 532
		private static readonly global::System.DateTime dateTime1970 = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0);

		// Token: 0x04000215 RID: 533
		private string name;

		// Token: 0x04000216 RID: 534
		private int mode;

		// Token: 0x04000217 RID: 535
		private int userId;

		// Token: 0x04000218 RID: 536
		private int groupId;

		// Token: 0x04000219 RID: 537
		private long size;

		// Token: 0x0400021A RID: 538
		private global::System.DateTime modTime;

		// Token: 0x0400021B RID: 539
		private int checksum;

		// Token: 0x0400021C RID: 540
		private bool isChecksumValid;

		// Token: 0x0400021D RID: 541
		private byte typeFlag;

		// Token: 0x0400021E RID: 542
		private string linkName;

		// Token: 0x0400021F RID: 543
		private string magic;

		// Token: 0x04000220 RID: 544
		private string version;

		// Token: 0x04000221 RID: 545
		private string userName;

		// Token: 0x04000222 RID: 546
		private string groupName;

		// Token: 0x04000223 RID: 547
		private int devMajor;

		// Token: 0x04000224 RID: 548
		private int devMinor;

		// Token: 0x04000225 RID: 549
		internal static int userIdAsSet;

		// Token: 0x04000226 RID: 550
		internal static int groupIdAsSet;

		// Token: 0x04000227 RID: 551
		internal static string userNameAsSet;

		// Token: 0x04000228 RID: 552
		internal static string groupNameAsSet = "None";

		// Token: 0x04000229 RID: 553
		internal static int defaultUserId;

		// Token: 0x0400022A RID: 554
		internal static int defaultGroupId;

		// Token: 0x0400022B RID: 555
		internal static string defaultGroupName = "None";

		// Token: 0x0400022C RID: 556
		internal static string defaultUser;
	}
}
