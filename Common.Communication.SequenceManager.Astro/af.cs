using System;

namespace Motorola.Common.Communication
{
	// Token: 0x02000022 RID: 34
	internal class af
	{
		// Token: 0x06000120 RID: 288 RVA: 0x00021DD0 File Offset: 0x0001FFD0
		private af()
		{
		}

		// Token: 0x06000121 RID: 289 RVA: 0x00021DE4 File Offset: 0x0001FFE4
		public static byte[] a(byte[] A_0)
		{
			short num = (short)2129526784;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1071841280;
				short num3 = num;
				switch (0)
				{
				case 0:
					goto IL_77;
				}
				byte[] array;
				uint num6;
				int num7;
				int num8;
				byte b;
				for (;;)
				{
					IL_50:
					switch (num2)
					{
					case 0:
						return array;
					case 1:
						goto IL_D1;
					case 2:
					{
						int num4;
						if (num4 <= 0)
						{
							num = (short)436731905;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num5 = (int)((num6 >> 9 & 1U) ^ (uint)(A_0[num7 - num8 - 1] >> num4 & 1));
						num6 = (num6 << 1) + (uint)num5;
						b ^= (byte)(num5 << num4);
						num4--;
						num = (short)765329414;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
					{
						num = (short)981324483;
						short num9 = num;
						num = (short)1930023619;
						switch ((num9 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D1;
						default:
							num = (short)196870144;
							if (num != 0)
							{
							}
							goto IL_19F;
						}
						break;
					}
					case 4:
						goto IL_140;
					case 5:
					{
						if (num8 >= num7)
						{
							num = (short)1791754240;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = A_0[num8];
						int num4 = 7;
						num = (short)1523777540;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
						goto IL_140;
					case 7:
						num = (short)1117585409;
						if (num != 0)
						{
						}
						goto IL_19F;
					}
					goto IL_77;
					IL_D1:
					array[num8] = b;
					num8++;
					num = (short)1559232515;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_140:
					num = (short)435224578;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19F:
					num = (short)1753022469;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_77:
				num7 = 32;
				array = new byte[num7];
				b = 0;
				num6 = 2260377433U;
				num8 = 0;
				num = (short)1379926023;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_50;
			}
			}
		}
	}
}
