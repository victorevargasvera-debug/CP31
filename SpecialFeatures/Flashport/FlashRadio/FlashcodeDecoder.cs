using System;

namespace SpecialFeatures.Flashport.FlashRadio
{
	// Token: 0x020000ED RID: 237
	public static class FlashcodeDecoder
	{
		// Token: 0x06000DDF RID: 3551 RVA: 0x00131078 File Offset: 0x0012F278
		public static void Decode(string flashcode, ref byte[] decoded)
		{
			short num = (short)1130430464;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)437842430;
				short num3 = num;
				num = (short)1706029566;
				int num5;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_288;
				default:
				{
					num = (short)1948385280;
					if (num != 0)
					{
					}
					int num4;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_A6;
						}
						continue;
					case 1:
						decoded[num4++] = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(flashcode[num5]);
						num = (short)1777598467;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						global::System.Array.Resize<byte>(ref decoded, 24);
						num = (short)1050017800;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)1480720385;
						if (num != 0)
						{
						}
						goto IL_15D;
					case 4:
						if (num5 >= flashcode.Length)
						{
							num = (short)39649291;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1015283717;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_288;
					case 6:
						num = (short)1022165001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)987365386;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_110;
					case 9:
						if (num5 != 14)
						{
							num = (short)371589127;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15D;
					case 10:
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(flashcode[num5]))
						{
							num = (short)1533607937;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_CB;
					case 11:
						return;
					case 12:
						goto IL_1FB;
					case 13:
						goto IL_1FB;
					}
					IL_A6:
					if (decoded.Length != 24)
					{
						num = (short)92078082;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_110:
					num4 = 0;
					num5 = 0;
					num = (short)579993600;
					short num6 = num;
					num = (short)351141901;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1FB:
					num = (short)917438468;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_15D:
				num5++;
				num = (short)2137915404;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_288:
				if (flashcode[num5] == '-')
				{
					goto IL_15D;
				}
				num = (short)2119106566;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_CB:
			decoded = null;
		}

		// Token: 0x06000DE0 RID: 3552 RVA: 0x00131334 File Offset: 0x0012F534
		public static void DecodeOldFlashcode(string flashcode, ref byte[] decoded)
		{
			short num = (short)1688797184;
			switch (num)
			{
			default:
			{
				num = (short)193396745;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					int num3;
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)198246401;
						if (num != 0)
						{
						}
						num = (short)2014052356;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_10A;
					case 2:
					{
						if (num3 >= flashcode.Length)
						{
							num = (short)1955790855;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						char c = flashcode[num3];
						num = (short)1530986501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						goto IL_1E8;
					case 4:
					{
						IL_E5:
						char c;
						if (global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.IsCharInFlashcodeMap(c))
						{
							num = (short)1481572363;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_A2;
					}
					case 5:
					{
						char c;
						if (c != '-')
						{
							num = (short)1446117382;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					}
					case 6:
						num = (short)1180106764;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						return;
					case 8:
						goto IL_12D;
					case 9:
						switch (0)
						{
						case 0:
							goto IL_7D;
						}
						continue;
					case 10:
						goto IL_1E8;
					case 11:
					{
						char c;
						decoded[num4++] = (byte)global::SpecialFeatures.Flashport.FlashRadio.FlashcodeMapping.GetFlashcodeIntValue(c);
						num = (short)2078736392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						if (num4 != 12)
						{
							num = (short)501743616;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_12D;
					case 13:
						global::System.Array.Resize<byte>(ref decoded, 12);
						num = (short)1778778113;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_7D:
					if (decoded.Length != 12)
					{
						num = (short)420478989;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10A;
					IL_12D:
					num3++;
					num = (short)2139031663;
					short num5 = num;
					num = (short)1651312751;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_E5;
					default:
						num = (short)1307246592;
						if (num != 0)
						{
						}
						num = (short)400752643;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_10A:
					num4 = 0;
					num3 = 0;
					num = (short)620167178;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1E8:
					num = (short)8847360;
					short num6 = num;
					num = (short)556466178;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_A2:
				decoded = null;
				return;
			}
			}
		}
	}
}
