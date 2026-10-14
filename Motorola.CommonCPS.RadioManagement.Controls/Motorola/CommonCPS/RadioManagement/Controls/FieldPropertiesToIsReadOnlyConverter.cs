using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200008C RID: 140
	internal class FieldPropertiesToIsReadOnlyConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600034C RID: 844 RVA: 0x0003705C File Offset: 0x0003525C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)950534144;
			switch (num)
			{
			default:
			{
				num = (short)1632043014;
				int num2 = (int)((global::System.IntPtr)num);
				bool flag;
				bool flag4;
				for (;;)
				{
					bool flag2;
					bool flag3;
					switch (num2)
					{
					case 0:
					{
						num = (short)805418914;
						short num3 = num;
						num = (short)1707915170;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_1CC;
						default:
							num = (short)1606746112;
							if (num != 0)
							{
							}
							if (flag)
							{
								num = (short)1875705859;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1644363777;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						goto IL_20C;
					case 2:
						goto IL_1E4;
					case 3:
						num = (short)1471283207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (!flag2)
						{
							goto IL_1CC;
						}
						num = (short)679018501;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (flag3)
						{
							num = (short)360448009;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_24E;
					case 6:
						switch (0)
						{
						case 0:
							goto IL_6D;
						}
						continue;
					case 7:
						goto IL_D5;
					case 8:
						goto IL_8F;
					case 9:
						num = (short)1907359744;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_6D:
					if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)13434888;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					flag = (bool)values[0];
					flag3 = (bool)values[1];
					flag4 = (bool)values[2];
					flag2 = (bool)values[3];
					num = (short)1839792132;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_1CC:
					num = (short)1800536066;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_8F:
				num = (short)1979777025;
				if (num != 0)
				{
				}
				return false;
				IL_D5:
				num = (short)1396244480;
				short num4 = num;
				bool flag5 = flag4;
				goto IL_1E6;
				IL_1E4:
				return false;
				IL_1E6:
				return flag5;
				IL_20C:
				flag5 = true;
				goto IL_1E6;
				IL_24E:
				return !flag;
			}
			}
		}

		// Token: 0x0600034D RID: 845 RVA: 0x000372C0 File Offset: 0x000354C0
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1127020967;
			short num2 = num;
			num = (short)378730919;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1420099584;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2085289985;
			if (num != 0)
			{
			}
			num = (short)1714225152;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
