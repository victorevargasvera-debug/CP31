using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000F0 RID: 240
	public static class FlashcodeMapping
	{
		// Token: 0x06000DE7 RID: 3559 RVA: 0x001331F0 File Offset: 0x001313F0
		internal static bool IsCharInFlashcodeMap(char c)
		{
			bool result;
			for (;;)
			{
				short num = (short)2073690112;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_45;
				}
				for (;;)
				{
					IL_33:
					int num3;
					switch (num3)
					{
					case 0:
						if (global::System.Array.IndexOf<char>(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.a, c) != -1)
						{
							num = (short)916258817;
							if (num != 0)
							{
							}
							num = (short)1905393666;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						result = true;
						num = (short)1068498945;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_45:
				result = false;
				num = (short)1760301627;
				short num4 = num;
				num = (short)556732987;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1713766400;
					if (num != 0)
					{
					}
					num = (short)247595008;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_33;
				}
				}
			}
			return result;
		}

		// Token: 0x06000DE8 RID: 3560 RVA: 0x00133314 File Offset: 0x00131514
		internal static int GetFlashcodeIntValue(char c)
		{
			short num = (short)214761472;
			short num2 = num;
			num = (short)722862081;
			if (num != 0)
			{
			}
			num = (short)443045024;
			short num3 = num;
			num = (short)382162080;
			switch (num3 == num)
			{
			}
			num = (short)582680576;
			if (num != 0)
			{
			}
			return global::System.Array.IndexOf<char>(global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.a, c);
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x001333C8 File Offset: 0x001315C8
		internal static char GetFlashcodeCharValue(int i)
		{
			char result;
			for (;;)
			{
				short num = (short)1441267712;
				short num2 = num;
				switch (0)
				{
				case 0:
					goto IL_47;
				}
				for (;;)
				{
					IL_35:
					int num3;
					switch (num3)
					{
					case 0:
						if (i < global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.a.Length)
						{
							num = (short)338100226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 1:
						return result;
					case 2:
						result = global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.a[i];
						num = (short)1657995265;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				IL_47:
				num = (short)819724289;
				if (num != 0)
				{
				}
				result = '\0';
				num = (short)1123629383;
				short num4 = num;
				num = (short)1944598855;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1096810496;
					if (num != 0)
					{
					}
					num = (short)756219904;
					int num3 = (int)((global::System.IntPtr)num);
					goto IL_35;
				}
				}
			}
			return result;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x001334F0 File Offset: 0x001316F0
		// Note: this type is marked as 'beforefieldinit'.
		static FlashcodeMapping()
		{
			short num = (short)839254016;
			short num2 = num;
			num = (short)495976449;
			if (num != 0)
			{
			}
			num = (short)434086912;
			short num3 = num;
			num = (short)1939055616;
			switch (num3 == num)
			{
			}
			num = (short)1121320960;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.a = new char[]
			{
				'0',
				'1',
				'2',
				'3',
				'4',
				'5',
				'6',
				'7',
				'8',
				'9',
				'A',
				'B',
				'C',
				'D',
				'E',
				'F',
				'G',
				'H',
				'J',
				'K',
				'L',
				'M',
				'N',
				'P',
				'Q',
				'R',
				'S',
				'T',
				'U',
				'V',
				'W',
				'X',
				'Y',
				'Z',
				'a',
				'b',
				'c',
				'd',
				'e',
				'f',
				'g',
				'h',
				'j',
				'k',
				'm',
				'n',
				'p',
				'q',
				'r',
				's',
				't',
				'u',
				'v',
				'w',
				'x',
				'y',
				'z',
				'#',
				'(',
				'+',
				'$',
				')',
				'&',
				'%'
			};
		}

		// Token: 0x04000734 RID: 1844
		internal const int FLASHCODE_MAPSIZE = 64;

		// Token: 0x04000735 RID: 1845
		private static readonly char[] a;
	}
}
