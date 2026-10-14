using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;

namespace MackinawCPS
{
	// Token: 0x0200001D RID: 29
	public class RibbonUpdataCallListEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000065 RID: 101 RVA: 0x0000CC64 File Offset: 0x0000AE64
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_34;
			}
			int num;
			short num2;
			bool flag2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					bool flag;
					if (!flag)
					{
						num2 = (short)1332281350;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				}
				case 1:
					goto IL_1F1;
				case 2:
				{
					num2 = (short)1469710337;
					if (num2 != 0)
					{
					}
					num2 = (short)1850146816;
					short num3 = num2;
					num2 = (short)379977728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 3:
				{
					num2 = (short)1036996687;
					short num4 = num2;
					num2 = (short)2029932623;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_67;
					default:
						num2 = (short)1140719616;
						if (num2 != 0)
						{
						}
						if (values[0] is global::AcpCommonLib.ApplicationMode)
						{
							num2 = (short)559808517;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1F3;
					}
					break;
				}
				case 4:
					goto IL_67;
				case 5:
					num2 = (short)1767702536;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					flag2 = true;
					num2 = (short)1421672449;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					if (values.Length == 3)
					{
						num2 = (short)362217476;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				case 8:
				{
					int num5 = (int)((global::AcpCommonLib.ApplicationMode)values[0]);
					bool flag3 = (bool)values[1];
					bool flag = (bool)values[2];
					if (num5 == 0 && flag3)
					{
						num2 = (short)636157954;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F3;
				}
				}
				goto IL_34;
				IL_67:
				num2 = (short)633470979;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_1F1:
			IL_1F3:
			return flag2;
			IL_34:
			flag2 = false;
			num2 = (short)1269760007;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000066 RID: 102 RVA: 0x0000CE6C File Offset: 0x0000B06C
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)374945980;
			short num2 = num;
			num = (short)842873020;
			switch (num2 == num)
			{
			}
			num = (short)2069954561;
			if (num != 0)
			{
			}
			num = (short)1265238016;
			if (num != 0)
			{
			}
			num = (short)1395851264;
			short num3 = num;
			return null;
		}

		// Token: 0x04000031 RID: 49
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
