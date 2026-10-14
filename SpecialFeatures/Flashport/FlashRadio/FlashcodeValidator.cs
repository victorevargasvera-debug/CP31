using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000EF RID: 239
	public static class FlashcodeValidator
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x001324A0 File Offset: 0x001306A0
		public static bool Validate(string flashcode)
		{
			return true;
		}

		// Token: 0x06000DE5 RID: 3557 RVA: 0x001329AC File Offset: 0x00130BAC
		public static bool ValidateOldFlashcode(string flashcode)
		{
			return true;
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x00132E14 File Offset: 0x00131014
		internal static byte CalculateFlashCodeCheckDigit(string flashCode)
		{
			short num = (short)469368832;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_7B;
				}
				byte b;
				byte[] array;
				byte b3;
				for (;;)
				{
					IL_28:
					int num3;
					byte b2;
					switch (num2)
					{
					case 0:
						num3 = 0;
						num = (short)1357447176;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_2B8;
					case 2:
						return b;
					case 3:
						return b;
					case 4:
						if (array != null)
						{
							num = (short)1128726528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = byte.MaxValue;
						num = (short)530186242;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_256;
					case 6:
						b2 = b3 * 2 / 100 + b3 * 2 % 100 / 10 + b3 * 2 % 100 % 10;
						num = (short)1180631041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						if (b3 * 2 >= 100)
						{
							num = (short)59375622;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b2 = b3 * 2 / 10 + b3 * 2 % 10;
						num = (short)584974337;
						if (num != 0)
						{
						}
						num = (short)1648164881;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_256;
					case 9:
					{
						byte b4 = b % 10;
						num = (short)1584726028;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 10:
						return b;
					case 11:
					{
						byte b4;
						b = 10 - b4;
						num = (short)837812227;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
					{
						byte b4;
						if (b4 > 0)
						{
							num = (short)858390539;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = b4;
						num = (short)1641349130;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 13:
						if (num3 >= 24)
						{
							num = (short)1124466697;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b3 = array[num3];
						num = (short)1762852880;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
					{
						num = (short)1136955158;
						short num4 = num;
						num = (short)223645462;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_2B8;
						default:
							num = (short)971374592;
							if (num != 0)
							{
							}
							goto IL_333;
						}
						break;
					}
					case 15:
						goto IL_333;
					case 16:
					{
						if (num3 % 2 == 0)
						{
							num = (short)2002255890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						byte b5 = b3 / 10 + b3 % 10;
						b += b5;
						num = (short)181010446;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 17:
						goto IL_2B8;
					case 18:
					{
						num = (short)647233536;
						short num5 = num;
						num = (short)1354760199;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_7B;
					IL_256:
					num = (short)654966797;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_2B8:
					b += b2;
					num = (short)1722351631;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_333:
					num3++;
					num = (short)1541996549;
					num2 = (int)((global::System.IntPtr)num);
				}
				return b;
				IL_7B:
				b = 0;
				b3 = 0;
				array = new byte[25];
				global::SpecialFeatures.Flashport.FlashRadio.FlashcodeDecoder.Decode(flashCode, ref array);
				num = (short)136773636;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_28;
			}
			}
		}
	}
}
