using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x02000021 RID: 33
	public class ComparatorMenuItemsEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000073 RID: 115 RVA: 0x0000DFE4 File Offset: 0x0000C1E4
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_30;
			}
			int num;
			bool flag;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					flag = false;
					num2 = (short)588447750;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)2064777216;
					short num3 = num2;
					num2 = (short)480182276;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
				{
					num2 = (short)1201588433;
					short num4 = num2;
					num2 = (short)2003880145;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_1BF;
					default:
						num2 = (short)1123352576;
						if (num2 != 0)
						{
						}
						if (values.Length == 2)
						{
							num2 = (short)984481793;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1BF;
					}
					break;
				}
				case 3:
					goto IL_1BD;
				case 4:
					if (values[0] is global::AcpCommonLib.ApplicationMode)
					{
						num2 = (short)120651783;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BF;
				case 5:
				{
					int num5 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
					bool flag2 = (bool)values[1];
					if (num5 == 1)
					{
						num2 = (short)1750073344;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					flag = flag2;
					num2 = (short)351600643;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 6:
					goto IL_11E;
				case 7:
					num2 = (short)1897398277;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_30;
			}
			IL_11E:
			IL_1BD:
			IL_1BF:
			return flag;
			IL_30:
			num2 = (short)241303553;
			if (num2 != 0)
			{
			}
			flag = true;
			num2 = (short)1712324610;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000E1B8 File Offset: 0x0000C3B8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)183107584;
			short num2 = num;
			num = (short)506322954;
			short num3 = num;
			num = (short)457891850;
			switch (num3 == num)
			{
			}
			num = (short)362807296;
			if (num != 0)
			{
			}
			num = (short)422576129;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x04000036 RID: 54
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
