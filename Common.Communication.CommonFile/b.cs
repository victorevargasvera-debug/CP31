using System;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.CommonFile
{
	// Token: 0x0200000B RID: 11
	internal class b
	{
		// Token: 0x0600000D RID: 13 RVA: 0x00002C7C File Offset: 0x00000E7C
		private b()
		{
		}

		// Token: 0x0600000E RID: 14 RVA: 0x00002C90 File Offset: 0x00000E90
		public static ushort b(byte[] A_0, int A_1)
		{
			if (A_1 + 2 <= A_0.Length)
			{
				short num = (short)1485111297;
				if (num != 0)
				{
				}
				num = (short)287996694;
				short num2 = num;
				num = (short)1552907030;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_0A;
				case 1:
					break;
				default:
				{
					num = (short)1141833728;
					short num3 = num;
					break;
				}
				}
				num = (short)1931018240;
				if (num != 0)
				{
				}
				return (ushort)((int)A_0[A_1 + 1] << 8 | (int)A_0[A_1]);
			}
			IL_0A:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
		}

		// Token: 0x0600000F RID: 15 RVA: 0x00002D58 File Offset: 0x00000F58
		public static uint a(byte[] A_0, int A_1)
		{
			if (A_1 + 4 <= A_0.Length)
			{
				short num = (short)1928496807;
				short num2 = num;
				num = (short)351766183;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1617297408;
					short num3 = num;
					num = (short)858783744;
					if (num != 0)
					{
					}
					num = (short)770834433;
					if (num != 0)
					{
					}
					return (uint)((int)A_0[A_1 + 3] << 24 | (int)A_0[A_1 + 2] << 16 | (int)A_0[A_1 + 1] << 8 | (int)A_0[A_1]);
				}
				}
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.ArgumentOutOfRange);
		}
	}
}
