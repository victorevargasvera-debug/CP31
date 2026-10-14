using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace Ionic.Zip
{
	// Token: 0x02000043 RID: 67
	internal static class SharedUtilities
	{
		// Token: 0x060002E5 RID: 741 RVA: 0x00011960 File Offset: 0x0000FB60
		public static long GetFileLength(string fileName)
		{
			if (!global::System.IO.File.Exists(fileName))
			{
				throw new global::System.IO.FileNotFoundException(string.Format("Could not find file '{0}'.", fileName), fileName);
			}
			global::System.IO.FileShare share = global::System.IO.FileShare.Read | global::System.IO.FileShare.Write | global::System.IO.FileShare.Delete;
			long length;
			using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, share))
			{
				length = fileStream.Length;
			}
			return length;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x000119B8 File Offset: 0x0000FBB8
		private static string SimplifyFwdSlashPath(string path)
		{
			if (path.StartsWith("./"))
			{
				path = path.Substring(2);
			}
			path = path.Replace("/./", "/");
			path = global::Ionic.Zip.SharedUtilities.doubleDotRegex1.Replace(path, "$1$3");
			return path;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x000119F8 File Offset: 0x0000FBF8
		public static string NormalizePathForUseInZipFile(string pathName)
		{
			if (string.IsNullOrEmpty(pathName))
			{
				return pathName;
			}
			if (pathName.Length >= 2 && pathName[1] == ':' && pathName[2] == '\\')
			{
				pathName = pathName.Substring(3);
			}
			pathName = pathName.Replace('\\', '/');
			while (pathName.StartsWith("/"))
			{
				pathName = pathName.Substring(1);
			}
			return global::Ionic.Zip.SharedUtilities.SimplifyFwdSlashPath(pathName);
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00011A64 File Offset: 0x0000FC64
		public static string SanitizePath(string path)
		{
			global::System.Collections.Generic.List<string> list = new global::System.Collections.Generic.List<string>();
			int num = 0;
			foreach (string text in path.Split(new char[]
			{
				'/'
			}))
			{
				if (text == "..")
				{
					if (num != 0)
					{
						num--;
					}
				}
				else
				{
					if (list.Count - 1 < num)
					{
						list.Add(text);
					}
					else
					{
						list[num] = text;
					}
					num++;
				}
			}
			path = "";
			for (int j = 0; j < num; j++)
			{
				if (j > 0)
				{
					path += "/";
				}
				path += list[j];
			}
			return path;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00011B11 File Offset: 0x0000FD11
		internal static byte[] StringToByteArray(string value, global::System.Text.Encoding encoding)
		{
			return encoding.GetBytes(value);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x00011B1C File Offset: 0x0000FD1C
		internal static byte[] StringToByteArray(string value)
		{
			global::System.Text.Encoding encoding = null;
			try
			{
				encoding = global::System.Text.Encoding.GetEncoding("IBM437");
			}
			catch (global::System.Exception)
			{
			}
			if (encoding == null)
			{
				try
				{
					encoding = global::System.Text.Encoding.GetEncoding(1252);
				}
				catch (global::System.Exception)
				{
				}
			}
			return global::Ionic.Zip.SharedUtilities.StringToByteArray(value, encoding);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x00011B74 File Offset: 0x0000FD74
		internal static string Utf8StringFromBuffer(byte[] buf)
		{
			return global::Ionic.Zip.SharedUtilities.StringFromBuffer(buf, global::Ionic.Zip.SharedUtilities.utf8);
		}

		// Token: 0x060002EC RID: 748 RVA: 0x00011B81 File Offset: 0x0000FD81
		internal static string StringFromBuffer(byte[] buf, global::System.Text.Encoding encoding)
		{
			return encoding.GetString(buf);
		}

		// Token: 0x060002ED RID: 749 RVA: 0x00011B8C File Offset: 0x0000FD8C
		internal static int ReadSignature(global::System.IO.Stream s)
		{
			int result = 0;
			try
			{
				result = global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "n/a");
			}
			catch (global::Ionic.Zip.BadReadException)
			{
			}
			return result;
		}

		// Token: 0x060002EE RID: 750 RVA: 0x00011BC0 File Offset: 0x0000FDC0
		internal static int ReadEntrySignature(global::System.IO.Stream s)
		{
			int num = 0;
			try
			{
				num = global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "n/a");
				if (num == 134695760)
				{
					s.Seek(12L, global::System.IO.SeekOrigin.Current);
					num = global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "n/a");
					if (num != 67324752)
					{
						s.Seek(8L, global::System.IO.SeekOrigin.Current);
						num = global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "n/a");
						if (num != 67324752)
						{
							s.Seek(-24L, global::System.IO.SeekOrigin.Current);
							num = global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "n/a");
						}
					}
				}
			}
			catch (global::Ionic.Zip.BadReadException)
			{
			}
			return num;
		}

		// Token: 0x060002EF RID: 751 RVA: 0x00011C50 File Offset: 0x0000FE50
		internal static int ReadInt(global::System.IO.Stream s)
		{
			return global::Ionic.Zip.SharedUtilities._ReadFourBytes(s, "Could not read block - no data!  (position 0x{0:X8})");
		}

		// Token: 0x060002F0 RID: 752 RVA: 0x00011C60 File Offset: 0x0000FE60
		private static int _ReadFourBytes(global::System.IO.Stream s, string message)
		{
			byte[] array = new byte[4];
			if (s.Read(array, 0, array.Length) != array.Length)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format(message, s.Position));
			}
			return (((int)array[3] * 256 + (int)array[2]) * 256 + (int)array[1]) * 256 + (int)array[0];
		}

		// Token: 0x060002F1 RID: 753 RVA: 0x00011CBC File Offset: 0x0000FEBC
		internal static long FindSignature(global::System.IO.Stream stream, int SignatureToFind)
		{
			long position = stream.Position;
			int num = 65536;
			byte[] array = new byte[]
			{
				(byte)(SignatureToFind >> 24),
				(byte)((SignatureToFind & 16711680) >> 16),
				(byte)((SignatureToFind & 65280) >> 8),
				(byte)(SignatureToFind & 255)
			};
			byte[] array2 = new byte[num];
			bool flag = false;
			do
			{
				int num2 = stream.Read(array2, 0, array2.Length);
				if (num2 == 0)
				{
					break;
				}
				for (int i = 0; i < num2; i++)
				{
					if (array2[i] == array[3])
					{
						long position2 = stream.Position;
						stream.Seek((long)(i - num2), global::System.IO.SeekOrigin.Current);
						flag = (global::Ionic.Zip.SharedUtilities.ReadSignature(stream) == SignatureToFind);
						if (flag)
						{
							break;
						}
						stream.Seek(position2, global::System.IO.SeekOrigin.Begin);
					}
				}
			}
			while (!flag);
			if (!flag)
			{
				stream.Seek(position, global::System.IO.SeekOrigin.Begin);
				return -1L;
			}
			return stream.Position - position - 4L;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00011D8C File Offset: 0x0000FF8C
		internal static global::System.DateTime AdjustTime_Reverse(global::System.DateTime time)
		{
			if (time.Kind == global::System.DateTimeKind.Utc)
			{
				return time;
			}
			global::System.DateTime result = time;
			if (global::System.DateTime.Now.IsDaylightSavingTime() && !time.IsDaylightSavingTime())
			{
				result = time - new global::System.TimeSpan(1, 0, 0);
			}
			else if (!global::System.DateTime.Now.IsDaylightSavingTime() && time.IsDaylightSavingTime())
			{
				result = time + new global::System.TimeSpan(1, 0, 0);
			}
			return result;
		}

		// Token: 0x060002F3 RID: 755 RVA: 0x00011DF8 File Offset: 0x0000FFF8
		internal static global::System.DateTime PackedToDateTime(int packedDateTime)
		{
			if (packedDateTime == 65535 || packedDateTime == 0)
			{
				return new global::System.DateTime(1995, 1, 1, 0, 0, 0, 0);
			}
			short num = (short)(packedDateTime & 65535);
			short num2 = (short)(((long)packedDateTime & (long)((ulong)-65536)) >> 16);
			int i = 1980 + (((int)num2 & 65024) >> 9);
			int j = (num2 & 480) >> 5;
			int k = (int)(num2 & 31);
			int num3 = ((int)num & 63488) >> 11;
			int l = (num & 2016) >> 5;
			int m = (int)((num & 31) * 2);
			if (m >= 60)
			{
				l++;
				m = 0;
			}
			if (l >= 60)
			{
				num3++;
				l = 0;
			}
			if (num3 >= 24)
			{
				k++;
				num3 = 0;
			}
			global::System.DateTime dateTime = global::System.DateTime.Now;
			bool flag = false;
			try
			{
				dateTime = new global::System.DateTime(i, j, k, num3, l, m, 0);
				flag = true;
			}
			catch (global::System.ArgumentOutOfRangeException)
			{
				if (i == 1980 && (j == 0 || k == 0))
				{
					try
					{
						dateTime = new global::System.DateTime(1980, 1, 1, num3, l, m, 0);
						flag = true;
						goto IL_1A1;
					}
					catch (global::System.ArgumentOutOfRangeException)
					{
						try
						{
							dateTime = new global::System.DateTime(1980, 1, 1, 0, 0, 0, 0);
							flag = true;
						}
						catch (global::System.ArgumentOutOfRangeException)
						{
						}
						goto IL_1A1;
					}
				}
				try
				{
					while (i < 1980)
					{
						i++;
					}
					while (i > 2030)
					{
						i--;
					}
					while (j < 1)
					{
						j++;
					}
					while (j > 12)
					{
						j--;
					}
					while (k < 1)
					{
						k++;
					}
					while (k > 28)
					{
						k--;
					}
					while (l < 0)
					{
						l++;
					}
					while (l > 59)
					{
						l--;
					}
					while (m < 0)
					{
						m++;
					}
					while (m > 59)
					{
						m--;
					}
					dateTime = new global::System.DateTime(i, j, k, num3, l, m, 0);
					flag = true;
				}
				catch (global::System.ArgumentOutOfRangeException)
				{
				}
				IL_1A1:;
			}
			if (!flag)
			{
				string arg = string.Format("y({0}) m({1}) d({2}) h({3}) m({4}) s({5})", new object[]
				{
					i,
					j,
					k,
					num3,
					l,
					m
				});
				throw new global::Ionic.Zip.ZipException(string.Format("Bad date/time format in the zip file. ({0})", arg));
			}
			dateTime = global::System.DateTime.SpecifyKind(dateTime, global::System.DateTimeKind.Local);
			return dateTime;
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0001204C File Offset: 0x0001024C
		internal static int DateTimeToPacked(global::System.DateTime time)
		{
			time = time.ToLocalTime();
			int num = (int)((ushort)((time.Day & 31) | (time.Month << 5 & 480) | (time.Year - 1980 << 9 & 65024)));
			ushort num2 = (ushort)((time.Second / 2 & 31) | (time.Minute << 5 & 2016) | (time.Hour << 11 & 63488));
			return num << 16 | (int)num2;
		}

		// Token: 0x060002F5 RID: 757 RVA: 0x000120C8 File Offset: 0x000102C8
		public static void CreateAndOpenUniqueTempFile(string dir, out global::System.IO.Stream fs, out string filename)
		{
			for (int i = 0; i < 3; i++)
			{
				try
				{
					filename = global::System.IO.Path.Combine(dir, global::Ionic.Zip.SharedUtilities.InternalGetTempFileName());
					fs = new global::System.IO.FileStream(filename, global::System.IO.FileMode.CreateNew);
					return;
				}
				catch (global::System.IO.IOException)
				{
					if (i == 2)
					{
						throw;
					}
				}
			}
			throw new global::System.IO.IOException();
		}

		// Token: 0x060002F6 RID: 758 RVA: 0x0001211C File Offset: 0x0001031C
		public static string InternalGetTempFileName()
		{
			return "DotNetZip-" + global::System.IO.Path.GetRandomFileName().Substring(0, 8) + ".tmp";
		}

		// Token: 0x060002F7 RID: 759 RVA: 0x0001213C File Offset: 0x0001033C
		internal static int ReadWithRetry(global::System.IO.Stream s, byte[] buffer, int offset, int count, string FileName)
		{
			int result = 0;
			bool flag = false;
			int num = 0;
			do
			{
				try
				{
					result = s.Read(buffer, offset, count);
					flag = true;
				}
				catch (global::System.IO.IOException ex)
				{
					if (!new global::System.Security.Permissions.SecurityPermission(global::System.Security.Permissions.SecurityPermissionFlag.UnmanagedCode).IsUnrestricted())
					{
						throw;
					}
					if (global::Ionic.Zip.SharedUtilities._HRForException(ex) != 2147942433U)
					{
						throw new global::System.IO.IOException(string.Format("Cannot read file {0}", FileName), ex);
					}
					num++;
					if (num > 10)
					{
						throw new global::System.IO.IOException(string.Format("Cannot read file {0}, at offset 0x{1:X8} after 10 retries", FileName, offset), ex);
					}
					global::System.Threading.Thread.Sleep(250 + num * 550);
				}
			}
			while (!flag);
			return result;
		}

		// Token: 0x060002F8 RID: 760 RVA: 0x000121DC File Offset: 0x000103DC
		private static uint _HRForException(global::System.Exception ex1)
		{
			return (uint)global::System.Runtime.InteropServices.Marshal.GetHRForException(ex1);
		}

		// Token: 0x040001FC RID: 508
		private static global::System.Text.RegularExpressions.Regex doubleDotRegex1 = new global::System.Text.RegularExpressions.Regex("^(.*/)?([^/\\\\.]+/\\\\.\\\\./)(.+)$");

		// Token: 0x040001FD RID: 509
		private static global::System.Text.Encoding utf8 = global::System.Text.Encoding.GetEncoding("UTF-8");
	}
}
