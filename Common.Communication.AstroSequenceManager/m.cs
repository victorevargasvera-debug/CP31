using System;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002B RID: 43
	internal class m
	{
		// Token: 0x0600017D RID: 381 RVA: 0x00026148 File Offset: 0x00024348
		private m()
		{
		}

		// Token: 0x0600017E RID: 382 RVA: 0x0002615C File Offset: 0x0002435C
		public static byte[] a(byte[] A_0)
		{
			short num = (short)1414004736;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_4E;
				}
				int num3;
				int num4;
				byte b;
				byte[] array;
				uint num9;
				for (;;)
				{
					IL_27:
					int num5;
					switch (num2)
					{
					case 0:
						if (num3 >= num4)
						{
							num = (short)971833348;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						b = A_0[num3];
						num5 = 7;
						num = (short)1598881799;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_19F;
					case 2:
						goto IL_15B;
					case 3:
					{
						num = (short)1418291797;
						short num6 = num;
						num = (short)572156501;
						switch ((num6 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_15B;
						default:
						{
							num = (short)575602688;
							if (num != 0)
							{
							}
							num = (short)188940288;
							short num7 = num;
							num = (short)1742667777;
							if (num != 0)
							{
							}
							array[num3] = b;
							num3++;
							num = (short)155189249;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
					}
					case 4:
						return array;
					case 5:
						goto IL_142;
					case 6:
						goto IL_19F;
					case 7:
						goto IL_142;
					}
					goto IL_4E;
					IL_142:
					num = (short)1265303554;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_15B:
					if (num5 <= 0)
					{
						num = (short)2080047107;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					int num8 = (int)((num9 >> 9 & 1U) ^ (uint)(A_0[num4 - num3 - 1] >> num5 & 1));
					num9 = (num9 << 1) + (uint)num8;
					b ^= (byte)(num8 << num5);
					num5--;
					num = (short)918749189;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_19F:
					num = (short)2106261504;
					num2 = (int)((global::System.IntPtr)num);
				}
				return array;
				IL_4E:
				num4 = 32;
				array = new byte[num4];
				b = 0;
				num9 = 2260377433U;
				num3 = 0;
				num = (short)1043726342;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_27;
			}
			}
		}
	}
}
