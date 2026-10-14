using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;
using CommonResources;

namespace MackinawCPS
{
	// Token: 0x02000023 RID: 35
	public class TreeRootHeaderConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000079 RID: 121 RVA: 0x0000E574 File Offset: 0x0000C774
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_40;
			}
			int num;
			short num2;
			string result;
			for (;;)
			{
				IL_0A:
				int num5;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1390950143;
					short num3 = num2;
					num2 = (short)85538559;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_19D;
					default:
					{
						num2 = (short)1051394049;
						if (num2 != 0)
						{
						}
						num2 = (short)229703680;
						if (num2 != 0)
						{
						}
						num2 = (short)1289682944;
						short num4 = num2;
						goto IL_19D;
					}
					}
					break;
				}
				case 1:
					if (global::AcpCommonLib.AppInfoManager.AppMode == global::AcpCommonLib.ApplicationMode.CustomViewConfigurationMode)
					{
						num2 = (short)93913097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num5 = 0;
					num2 = (short)1973813248;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_19D;
				case 3:
					if (!string.IsNullOrEmpty((string)values[num5]))
					{
						num2 = (short)762970116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				case 4:
					result = (string)values[num5];
					num2 = (short)1027604487;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (num5 >= values.Length)
					{
						num2 = (short)1112866827;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)89653254;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (values[num5] is string)
					{
						num2 = (short)1647443976;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1F7;
				case 7:
					return result;
				case 8:
					num2 = (short)1706229763;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					result = global::CommonResources.AppResources.View_Manager;
					num2 = (short)759627786;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					return result;
				case 11:
					return result;
				}
				goto IL_40;
				IL_19D:
				num2 = (short)2010316805;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_1F7:
				num5++;
				num2 = (short)1050935298;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_40:
			result = global::CommonResources.AppResources.Unkown_Id;
			num2 = (short)2020409345;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000E7D8 File Offset: 0x0000C9D8
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)404643508;
			short num2 = num;
			num = (short)1016553140;
			switch (num2 == num)
			{
			}
			num = (short)972554240;
			short num3 = num;
			num = (short)1632960512;
			if (num != 0)
			{
			}
			num = (short)1287585793;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x04000038 RID: 56
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
