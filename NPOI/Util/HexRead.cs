using System;
using System.Collections;
using System.IO;
using System.Text;

namespace NPOI.Util
{
	// Token: 0x0200026A RID: 618
	public class HexRead
	{
		// Token: 0x06001034 RID: 4148 RVA: 0x00031DA0 File Offset: 0x0002FFA0
		public static byte[] ReadData(string filename)
		{
			global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filename, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read);
			byte[] result;
			try
			{
				result = global::NPOI.Util.HexRead.ReadData(fileStream, -1);
			}
			finally
			{
				fileStream.Close();
			}
			return result;
		}

		// Token: 0x06001035 RID: 4149 RVA: 0x00031DD8 File Offset: 0x0002FFD8
		public static byte[] ReadData(global::System.IO.Stream stream, string section)
		{
			try
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				bool flag = false;
				int num = stream.ReadByte();
				while (num != -1)
				{
					if (num <= 13)
					{
						if (num != 10 && num != 13)
						{
							goto IL_5F;
						}
						flag = false;
						stringBuilder = new global::System.Text.StringBuilder();
					}
					else if (num != 91)
					{
						if (num != 93)
						{
							goto IL_5F;
						}
						flag = false;
						if (stringBuilder.ToString().Equals(section))
						{
							return global::NPOI.Util.HexRead.ReadData(stream, 91);
						}
						stringBuilder = new global::System.Text.StringBuilder();
					}
					else
					{
						flag = true;
					}
					IL_6B:
					num = stream.ReadByte();
					continue;
					IL_5F:
					if (flag)
					{
						stringBuilder.Append((char)num);
						goto IL_6B;
					}
					goto IL_6B;
				}
			}
			finally
			{
				stream.Close();
			}
			throw new global::System.IO.IOException("Section '" + section + "' not found");
		}

		// Token: 0x06001036 RID: 4150 RVA: 0x00031E8C File Offset: 0x0003008C
		public static byte[] ReadData(string filename, string section)
		{
			byte[] result;
			using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(filename, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read))
			{
				result = global::NPOI.Util.HexRead.ReadData(fileStream, section);
			}
			return result;
		}

		// Token: 0x06001037 RID: 4151 RVA: 0x00031EC8 File Offset: 0x000300C8
		public static byte[] ReadData(global::System.IO.Stream stream, int eofChar)
		{
			int num = 0;
			byte b = 0;
			global::System.Collections.ArrayList arrayList = new global::System.Collections.ArrayList();
			char c = 'W';
			char c2 = '7';
			for (;;)
			{
				int num2 = stream.ReadByte();
				int num3 = -1;
				if (48 <= num2 && num2 <= 57)
				{
					num3 = num2 - 48;
				}
				else if (65 <= num2 && num2 <= 70)
				{
					num3 = num2 - (int)c2;
				}
				else if (97 <= num2 && num2 <= 102)
				{
					num3 = num2 - (int)c;
				}
				else if (35 == num2)
				{
					global::NPOI.Util.HexRead.ReadToEOL(stream);
				}
				else if (-1 == num2 || eofChar == num2)
				{
					break;
				}
				if (num3 != -1)
				{
					b = (byte)(b << 4);
					b += (byte)num3;
					num++;
					if (num == 2)
					{
						arrayList.Add(b);
						num = 0;
						b = 0;
					}
				}
			}
			return (byte[])arrayList.ToArray(typeof(byte));
		}

		// Token: 0x06001038 RID: 4152 RVA: 0x00031F8C File Offset: 0x0003018C
		public static byte[] ReadFromString(string data)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(global::System.Text.Encoding.UTF8.GetBytes(data)))
			{
				result = global::NPOI.Util.HexRead.ReadData(memoryStream, -1);
			}
			return result;
		}

		// Token: 0x06001039 RID: 4153 RVA: 0x00031FD0 File Offset: 0x000301D0
		private static void ReadToEOL(global::System.IO.Stream stream)
		{
			int num = stream.ReadByte();
			while (num != -1 && num != 10 && num != 13)
			{
				num = stream.ReadByte();
			}
		}
	}
}
