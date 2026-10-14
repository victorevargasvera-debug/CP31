using System;
using System.IO;

namespace AcpUtility
{
	// Token: 0x02000006 RID: 6
	public static class StreamExtensions
	{
		// Token: 0x0600000A RID: 10 RVA: 0x00002BB4 File Offset: 0x00000DB4
		public static byte[] ReadRequestedBytes(this global::System.IO.Stream stream, int count)
		{
			short num = (short)2077032448;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_46;
				}
				int num3;
				byte[] array;
				int num5;
				for (;;)
				{
					IL_27:
					switch (num2)
					{
					case 0:
						goto IL_DF;
					case 1:
					{
						num = (short)1510604801;
						if (num != 0)
						{
						}
						if (num3 <= 0)
						{
							num = (short)1425080322;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = stream.Read(array, num5, num3);
						num = (short)1398472707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						return array;
					case 3:
					{
						int num4;
						if (num4 != 0)
						{
							num = (short)894304260;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return array;
					}
					case 4:
						goto IL_1A4;
					case 5:
						goto IL_DF;
					}
					goto IL_46;
					IL_DF:
					num = (short)2004418561;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_46:
				num3 = count;
				array = new byte[count];
				num5 = 0;
				num = (short)106561536;
				short num6 = num;
				num = (short)1885442369;
				short num7 = num;
				num = (short)630493505;
				switch ((num7 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_1A4:
					int num4;
					num5 += num4;
					num3 -= num4;
					num = (short)301006848;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				default:
					num = (short)800849920;
					if (num != 0)
					{
					}
					num = (short)2044067845;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				break;
			}
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00002D68 File Offset: 0x00000F68
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1730809043 + A_1) + (global::System.IntPtr)46 + (global::System.IntPtr)58 + (global::System.IntPtr)33);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_5C;
			}
			IL_29:
			int num5;
			int num4 = num5 = num2;
			char[] array2 = array;
			int num6 = num5;
			char c = array[num5];
			byte b = (byte)((int)(c & 'ÿ') ^ num++);
			byte b2 = (byte)((int)(c >> 8) ^ num++);
			byte b3 = b2;
			b2 = b;
			b = b3;
			array2[num6] = (ushort)((int)b2 << 8 | (int)b);
			num3 = num4 + 1;
			IL_5C:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_29;
		}
	}
}
