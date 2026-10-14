using System;
using System.Collections;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000023 RID: 35
	internal class ag : global::System.Collections.IComparer
	{
		// Token: 0x06000122 RID: 290 RVA: 0x00022018 File Offset: 0x00020218
		internal static int a(string A_0, string A_1)
		{
			int a_ = 7;
			short num = (short)370278400;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_9F;
				}
				int num4;
				for (;;)
				{
					IL_30:
					switch (num2)
					{
					case 0:
						goto IL_1E8;
					case 1:
					{
						num = (short)1418133504;
						short num3 = num;
						num = (short)706936838;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						num = (short)1995177995;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (A_1 != null)
						{
							num = (short)55771156;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return 1;
					case 4:
						goto IL_497;
					case 5:
						if (A_0.Length >= 6)
						{
							num = (short)271056912;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4DB;
					case 6:
						if (A_1 == null)
						{
							num = (short)936378387;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41D;
					case 7:
						num4 = -1;
						num = (short)1927282709;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
					{
						string text;
						string text2;
						if (text != text2)
						{
							goto IL_147;
						}
						return num4;
					}
					case 9:
						num4 = 1;
						num = (short)1359151117;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
					{
						if (A_1.Length < 6)
						{
							num = (short)1192034318;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						string text = A_0;
						string text2 = A_1;
						text = text.ToLowerInvariant();
						text2 = text2.ToLowerInvariant();
						text = text.Replace(global::Motorola.Common.Communication.Crc32.c("財", a_), "");
						text2 = text2.Replace(global::Motorola.Common.Communication.Crc32.c("財", a_), "");
						num = (short)53739528;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 11:
					{
						char c;
						char c2;
						if (c < c2)
						{
							num = (short)927924231;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1844117519;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (num4 == 0)
						{
							num = (short)283312130;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num4;
					case 13:
						goto IL_37D;
					case 14:
						goto IL_1A0;
					case 15:
					{
						num = (short)1416953857;
						if (num != 0)
						{
						}
						char c;
						char c2;
						if (c > c2)
						{
							num = (short)600637449;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return num4;
					}
					case 16:
						num = (short)1774583818;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 17:
						if (A_0 == string.Empty)
						{
							num = (short)1057947648;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)2047410179;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 18:
						if (A_0 != null)
						{
							num = (short)900333591;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return -1;
					case 19:
						return 0;
					case 20:
						num = (short)611319830;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 21:
						goto IL_207;
					case 22:
						if (A_1 == string.Empty)
						{
							num = (short)942014468;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1412759557;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						num = (short)1546780689;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 24:
						if (A_0 == null)
						{
							num = (short)1900609537;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_41D;
					case 25:
					{
						string text;
						char c = text[0];
						string text2;
						char c2 = text2[0];
						text = text.Remove(0, 1);
						text2 = text2.Remove(0, 1);
						num4 = string.Compare(text, text2, global::System.StringComparison.Ordinal);
						num = (short)90759879;
						short num5 = num;
						num = (short)1189536455;
						switch ((num5 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_147;
						default:
							num = (short)1880489984;
							if (num != 0)
							{
							}
							num = (short)1020461068;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					goto IL_9F;
					IL_147:
					num = (short)1389428761;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_41D:
					num = (short)1971191826;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				goto IL_4DB;
				IL_1E8:
				return -1;
				IL_207:
				return num4;
				IL_37D:
				return num4;
				IL_497:
				return 1;
				IL_4DB:
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ValidateInfosFailure);
				IL_9F:
				num4 = 0;
				num = (short)283050008;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0002250C File Offset: 0x0002070C
		public int Compare(object x, object y)
		{
			short num = (short)59294023;
			short num2 = num;
			num = (short)558481735;
			switch (num2 == num)
			{
			}
			num = (short)1887043585;
			if (num != 0)
			{
			}
			num = (short)2057175040;
			short num3 = num;
			num = (short)368050176;
			if (num != 0)
			{
			}
			return global::Motorola.Common.Communication.ag.a((string)x, (string)y);
		}
	}
}
