using System;

namespace Motorola.Common.CommonLib
{
	// Token: 0x02000012 RID: 18
	public class FlashcodeMapping
	{
		// Token: 0x0600006F RID: 111 RVA: 0x000106C4 File Offset: 0x0000E8C4
		public bool IsCharInFlashcodeMap(char c)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1766247662;
					short num3 = num2;
					num2 = (short)1690160366;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						num2 = (short)594083840;
						if (num2 != 0)
						{
						}
						if (global::System.Array.IndexOf<char>(new global::Motorola.Common.CommonLib.FlashcodeMapping().flashcodeMap, c) != -1)
						{
							num2 = (short)1221656578;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return result;
					}
					break;
				}
				case 1:
					return result;
				case 2:
					num2 = (short)1445789697;
					if (num2 != 0)
					{
					}
					result = true;
					num2 = (short)1473839105;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			return result;
			IL_1C:
			num2 = (short)1884422144;
			short num4 = num2;
			result = false;
			num2 = (short)1364983808;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000107E8 File Offset: 0x0000E9E8
		public int GetFlashcodeIntValue(char c)
		{
			short num = (short)1839792128;
			short num2 = num;
			num = (short)545744246;
			short num3 = num;
			num = (short)1059415414;
			switch (num3 == num)
			{
			}
			num = (short)1645215744;
			if (num != 0)
			{
			}
			num = (short)1710686209;
			if (num != 0)
			{
			}
			return global::System.Array.IndexOf<char>(new global::Motorola.Common.CommonLib.FlashcodeMapping().flashcodeMap, c);
		}

		// Token: 0x06000071 RID: 113 RVA: 0x000108A0 File Offset: 0x0000EAA0
		internal char a(int A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_8E;
			}
			short num;
			int num4;
			char result;
			for (;;)
			{
				IL_0A:
				num = (short)1190202825;
				short num2 = num;
				num = (short)120524233;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)438697984;
					if (num != 0)
					{
					}
					num = (short)1170407424;
					short num3 = num;
					switch (num4)
					{
					case 0:
						goto IL_CB;
					case 1:
						goto IL_ED;
					case 2:
						if (A_0 < this.flashcodeMap.Length)
						{
							num = (short)276430848;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					goto IL_8E;
				}
				}
				IL_CB:
				result = this.flashcodeMap[A_0];
				num = (short)1220739073;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_ED:
			num = (short)1354235905;
			if (num != 0)
			{
			}
			return result;
			IL_8E:
			result = '\0';
			num = (short)651427842;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x04000056 RID: 86
		public const int FLASHCODE_MAPSIZE = 64;

		// Token: 0x04000057 RID: 87
		public readonly char[] flashcodeMap = new char[]
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
}
