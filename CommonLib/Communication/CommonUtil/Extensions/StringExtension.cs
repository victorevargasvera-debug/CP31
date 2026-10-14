using System;

namespace Motorola.Common.Communication.CommonUtil.Extensions
{
	// Token: 0x0200009E RID: 158
	public static class StringExtension
	{
		// Token: 0x06000418 RID: 1048 RVA: 0x000434D0 File Offset: 0x000416D0
		public static byte[] ToBch(this string input)
		{
			int a_ = 12;
			short num = (short)1862365476;
			short num2 = num;
			num = (short)1481732388;
			int num3;
			byte[] array;
			int num4;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_92:
				if (input.Length % 2 != 0)
				{
					num = (short)161415169;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)778043393;
					if (num != 0)
					{
					}
					array = new byte[input.Length / 2];
					num4 = 0;
					num = (short)1754988549;
					num3 = (int)((global::System.IntPtr)num);
				}
				break;
			default:
				num = (short)2042691584;
				if (num != 0)
				{
				}
				num = (short)547553283;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return array;
				case 1:
					goto IL_B0;
				case 2:
					goto IL_173;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_92;
					}
					continue;
				case 4:
					if (num4 >= input.Length)
					{
						num = (short)1558118400;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					array[num4 / 2] = global::System.Convert.ToByte(input.Substring(num4, 2), 16);
					num4 += 2;
					num = (short)391708674;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)1033568256;
					short num5 = num;
					goto IL_173;
				}
				}
				goto IL_92;
				IL_173:
				num = (short)1289355268;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_B0:
			throw new global::System.ArgumentException(global::Motorola.Common.Communication.CommonUtil.Extensions.StringExtension.b("匏紑稓怕紗栙栛笝䐟ȡ圣別娧䌩䈫䤭ု弱䄳䔵䰷ᨹ吻弽㘿❁摃⍅㹇⽉≋湍㱏㝑㩓ㅕⱗ㉙牛", a_));
		}

		// Token: 0x06000419 RID: 1049 RVA: 0x00043690 File Offset: 0x00041890
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(1472999014 + A_1) + (global::System.IntPtr)45 + (global::System.IntPtr)21 + (global::System.IntPtr)91);
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
