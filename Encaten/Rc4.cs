using System;

namespace Encaten
{
	// Token: 0x02000009 RID: 9
	public class Rc4
	{
		// Token: 0x06000013 RID: 19 RVA: 0x00002938 File Offset: 0x00000B38
		public static byte[] Encrypt(byte[] pwd, byte[] data)
		{
			int a_ = 14;
			short num = (short)380633088;
			switch (num)
			{
			default:
			{
				num = (short)1125384200;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (pwd.Length == 0)
						{
							num = (short)1051262981;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)903675904;
						short num3 = num;
						num = (short)1721106435;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_21A;
					case 2:
						goto IL_1F3;
					case 3:
					{
						if (data.Length == 0)
						{
							num = (short)1674969094;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array = new int[256];
						int[] array2 = new int[256];
						byte[] array3 = new byte[data.Length];
						int num4 = 0;
						num = (short)1665662991;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
						goto IL_21A;
					case 5:
						goto IL_197;
					case 6:
						goto IL_408;
					case 7:
						goto IL_B9;
					case 8:
						switch (0)
						{
						case 0:
							goto IL_9E;
						}
						continue;
					case 9:
						num = (short)246677505;
						if (num != 0)
						{
						}
						goto IL_31A;
					case 10:
						goto IL_31A;
					case 11:
					{
						int num4;
						if (num4 >= 256)
						{
							num = (short)1685389330;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array;
						array[num4] = (int)pwd[num4 % pwd.Length];
						int[] array2;
						array2[num4] = num4;
						num4++;
						num = (short)1723138060;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_462;
					case 13:
						if (data == null)
						{
							num = (short)52035586;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)512884736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						int num4;
						if (num4 >= 256)
						{
							num = (short)510853137;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array;
						int[] array2;
						int num5 = (num5 + array2[num4] + array[num4]) % 256;
						int num6 = array2[num4];
						array2[num4] = array2[num5];
						array2[num5] = num6;
						num4++;
						num = (short)694222857;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 15:
						goto IL_462;
					case 16:
					{
						byte[] array3;
						return array3;
					}
					case 17:
					{
						num = (short)1098147943;
						short num7 = num;
						num = (short)371091559;
						switch ((num7 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_31A;
						default:
						{
							num = (short)1749417984;
							if (num != 0)
							{
							}
							int num4;
							int num8;
							int num5 = num8 = (num4 = 0);
							num = (short)776142849;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 18:
					{
						int num5;
						int num4 = num5 = 0;
						num = (short)160497674;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 19:
					{
						int num4;
						if (num4 >= data.Length)
						{
							num = (short)1963982864;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num8;
						num8++;
						num8 %= 256;
						int[] array2;
						int num5;
						num5 += array2[num8];
						num5 %= 256;
						int num6 = array2[num8];
						array2[num8] = array2[num5];
						array2[num5] = num6;
						int num9 = array2[(array2[num8] + array2[num5]) % 256];
						byte[] array3;
						array3[num4] = (byte)((int)data[num4] ^ num9);
						num4++;
						num = (short)1898774532;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_9E:
					if (pwd == null)
					{
						num = (short)570490887;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)601686029;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_21A:
					num = (short)240844819;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_31A:
					num = (short)1429143566;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_462:
					num = (short)1361707019;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_B9:
				throw new global::System.ArgumentNullException(global::Encaten.Rc4.b("⍒≔㍖", a_));
				IL_197:
				throw new global::System.ArgumentException(global::Encaten.Rc4.b("⍒≔㍖祘㉚⹜罞Ѡ๢ᕤ፦ၨ", a_), global::Encaten.Rc4.b("⍒≔㍖", a_));
				IL_1F3:
				throw new global::System.ArgumentNullException(global::Encaten.Rc4.b("㝒㑔⍖㡘", a_));
				IL_408:
				throw new global::System.ArgumentException(global::Encaten.Rc4.b("㝒㑔⍖㡘筚㑜ⱞ䅠٢ࡤᝦᵨቪ", a_), global::Encaten.Rc4.b("㝒㑔⍖㡘", a_));
			}
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00002DEC File Offset: 0x00000FEC
		public static byte[] Decrypt(byte[] pwd, byte[] data)
		{
			short num = (short)2130771968;
			short num2 = num;
			num = (short)661466394;
			short num3 = num;
			num = (short)816917786;
			switch (num3 == num)
			{
			}
			num = (short)378470400;
			if (num != 0)
			{
			}
			num = (short)81920001;
			if (num != 0)
			{
			}
			return global::Encaten.Rc4.Encrypt(pwd, data);
		}

		// Token: 0x06000016 RID: 22 RVA: 0x00002EB0 File Offset: 0x000010B0
		internal static string b(string A_0, int A_1)
		{
			char[] array = A_0.ToCharArray();
			int num = (int)((global::System.IntPtr)(215944764 + A_1) + (global::System.IntPtr)6 + (global::System.IntPtr)2);
			int num3;
			int num2;
			if ((num2 = (num3 = 0)) < 1)
			{
				goto IL_55;
			}
			IL_22:
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
			IL_55:
			if ((num2 = num3) >= array.Length)
			{
				return string.Intern(new string(array));
			}
			goto IL_22;
		}
	}
}
