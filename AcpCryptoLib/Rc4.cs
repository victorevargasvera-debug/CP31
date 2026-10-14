using System;

namespace AcpCryptoLib
{
	// Token: 0x0200001B RID: 27
	public class Rc4
	{
		// Token: 0x0600006D RID: 109 RVA: 0x0000B5D0 File Offset: 0x000097D0
		public static byte[] Encrypt(byte[] pwd, byte[] data)
		{
			int a_ = 2;
			short num = (short)1890385920;
			switch (num)
			{
			default:
			{
				num = (short)1717436420;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num2)
					{
					case 0:
					{
						if (data.Length == 0)
						{
							num = (short)1586888713;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array = new int[256];
						int[] array2 = new int[256];
						byte[] array3 = new byte[data.Length];
						int num3 = 0;
						num = (short)1594818561;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 1:
						goto IL_466;
					case 2:
					{
						byte[] array3;
						return array3;
					}
					case 3:
						goto IL_393;
					case 4:
						num = (short)859832321;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_C7;
						}
						continue;
					case 5:
						goto IL_293;
					case 6:
						goto IL_26D;
					case 7:
						goto IL_214;
					case 8:
					{
						int num3;
						if (num3 >= 256)
						{
							num = (short)1670709261;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array;
						int[] array2;
						int num4 = (num4 + array2[num3] + array[num3]) % 256;
						int num5 = array2[num3];
						array2[num3] = array2[num4];
						array2[num4] = num5;
						num3++;
						num = (short)50921472;
						short num6 = num;
						num = (short)485556238;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						goto IL_40C;
					case 10:
						goto IL_466;
					case 11:
						if (data == null)
						{
							num = (short)656932870;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1221591058;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
					{
						int num3;
						if (num3 >= 256)
						{
							num = (short)1351483407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int[] array;
						array[num3] = (int)pwd[num3 % pwd.Length];
						int[] array2;
						array2[num3] = num3;
						num3++;
						num = (short)1833893898;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
					{
						int num3;
						int num7;
						int num4 = num7 = (num3 = 0);
						num = (short)1131937809;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 14:
						goto IL_393;
					case 15:
					{
						int num4;
						int num3 = num4 = 0;
						num = (short)374472707;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 16:
						goto IL_133;
					case 17:
						goto IL_293;
					case 18:
						goto IL_1F5;
					case 19:
					{
						int num3;
						if (num3 >= data.Length)
						{
							num = (short)1394868226;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num7;
						num7++;
						num7 %= 256;
						int[] array2;
						int num4;
						num4 += array2[num7];
						num4 %= 256;
						int num5 = array2[num7];
						array2[num7] = array2[num4];
						array2[num4] = num5;
						int num8 = array2[(array2[num7] + array2[num4]) % 256];
						byte[] array3;
						array3[num3] = (byte)((int)data[num3] ^ num8);
						num3++;
						num = (short)996605957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_C7:
					if (pwd != null)
					{
						num = (short)2046296075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)561206422;
					short num9 = num;
					num = (short)874206358;
					switch ((num9 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)1592852480;
						if (num != 0)
						{
						}
						num = (short)1025441808;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_1F5:
					if (pwd.Length == 0)
					{
						num = (short)1970405383;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1207828480;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_293:
					num = (short)1765867539;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_393:
					num = (short)1140326408;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_466:
					num = (short)348913676;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_133:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("焀琂愄", a_));
				IL_214:
				throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("焀琂愄✆怈砊ⴌ樎簐挒愔渖", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("焀琂愄", a_));
				IL_26D:
				throw new global::System.ArgumentNullException(global::AcpCryptoLib.XmlEncryptionUtil.b("攀戂焄昆", a_));
				IL_40C:
				throw new global::System.ArgumentException(global::AcpCryptoLib.XmlEncryptionUtil.b("攀戂焄昆⤈戊縌⼎琐縒攔挖怘", a_), global::AcpCryptoLib.XmlEncryptionUtil.b("攀戂焄昆", a_));
			}
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000BA88 File Offset: 0x00009C88
		public static byte[] Decrypt(byte[] pwd, byte[] data)
		{
			short num = (short)1101461233;
			short num2 = num;
			num = (short)1868101361;
			switch (num2 == num)
			{
			}
			num = (short)1597767680;
			if (num != 0)
			{
			}
			num = (short)428408833;
			if (num != 0)
			{
			}
			num = (short)686424064;
			short num3 = num;
			return global::AcpCryptoLib.Rc4.Encrypt(pwd, data);
		}
	}
}
