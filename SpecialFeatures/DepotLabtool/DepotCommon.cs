using System;
using AcpKeyValidatorLib;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013B RID: 315
	public class DepotCommon
	{
		// Token: 0x06001055 RID: 4181 RVA: 0x0016D644 File Offset: 0x0016B844
		public string GetDepotKeySerialNum(global::AcpKeyValidatorLib.AcpKeyValidator acpKeyValidator)
		{
			int a_ = 3;
			short num = (short)1124007936;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_64;
				}
				string text;
				for (;;)
				{
					IL_31:
					switch (num2)
					{
					case 0:
						if (text.Length > 16)
						{
							num = (short)1900549;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return text;
					case 1:
					{
						byte[] depotKeySerialNum;
						byte[] array = depotKeySerialNum;
						int num3 = 0;
						num = (short)1589772290;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 2:
						goto IL_22B;
					case 3:
						if (acpKeyValidator != null)
						{
							num = (short)275644423;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					case 4:
					{
						byte[] depotKeySerialNum;
						if (depotKeySerialNum != null)
						{
							num = (short)1169031169;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_11A;
					}
					case 5:
						text = text.Remove(16);
						num = (short)863633417;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 6:
						goto IL_22B;
					case 7:
					{
						byte[] depotKeySerialNum = acpKeyValidator.DepotKeySerialNum;
						num = (short)953745412;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 8:
						goto IL_11A;
					case 9:
						return text;
					case 10:
					{
						num = (short)2036531201;
						if (num != 0)
						{
						}
						byte[] array;
						int num3;
						if (num3 >= array.Length)
						{
							num = (short)2034958344;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						int num4 = (int)array[num3];
						text += num4.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ude85몇", a_));
						num3++;
						num = (short)833814534;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_64;
					IL_11A:
					num = (short)474021888;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_22B:
					num = (short)1805451274;
					num2 = (int)((global::System.IntPtr)num);
				}
				return text;
				IL_64:
				num = (short)1526840605;
				short num5 = num;
				num = (short)822852893;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)545456128;
					if (num != 0)
					{
					}
					text = "";
					break;
				}
				num = (short)2052980736;
				short num6 = num;
				num = (short)375717891;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_31;
			}
			}
		}
	}
}
