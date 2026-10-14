using System;

namespace AcpBusinessLayer
{
	// Token: 0x02000026 RID: 38
	public static class VAUtilities
	{
		// Token: 0x0600030B RID: 779 RVA: 0x0003BCB4 File Offset: 0x00039EB4
		internal static byte[] StrToByteArray(string str)
		{
			short num = (short)1352400898;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_127;
				case 1:
				{
					num = (short)295043072;
					short num3 = num;
					num = (short)278331395;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 2:
					goto IL_14;
				case 3:
					num = (short)1581645825;
					if (num != 0)
					{
					}
					if (str == string.Empty)
					{
						num = (short)982843392;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_12C;
				}
				goto IL_34;
				IL_14:
				switch (0)
				{
				case 0:
				{
					IL_34:
					num = (short)1043846285;
					short num4 = num;
					num = (short)397399181;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_14;
					default:
						num = (short)407044096;
						if (num != 0)
						{
						}
						if (str == null)
						{
							goto IL_99;
						}
						num = (short)2082930689;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					break;
				}
				}
			}
			IL_99:
			return null;
			IL_127:
			goto IL_99;
			IL_12C:
			return global::System.Convert.FromBase64String(str);
		}

		// Token: 0x0600030C RID: 780 RVA: 0x0003BDF4 File Offset: 0x00039FF4
		internal static string ByteArrayToStr(byte[] byteArr, int length)
		{
			if (byteArr != null)
			{
				short num = (short)197235300;
				short num2 = num;
				num = (short)802198116;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2063663104;
					if (num != 0)
					{
					}
					num = (short)810352640;
					short num3 = num;
					num = (short)1040384001;
					if (num != 0)
					{
					}
					return global::System.Convert.ToBase64String(byteArr, 0, length);
				}
				}
			}
			return string.Empty;
		}
	}
}
