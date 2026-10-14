using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x0200008B RID: 139
	internal class FieldPropertiesToIsEnableConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000349 RID: 841 RVA: 0x00036DB0 File Offset: 0x00034FB0
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1855258628;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag;
			bool flag3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					if (!flag)
					{
						num = (short)892928001;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)305205133;
					short num3 = num;
					num = (short)1294012301;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)863633408;
						if (num != 0)
						{
						}
						num = (short)721027072;
						short num4 = num;
						num = (short)1010827266;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 1:
					goto IL_AA;
				case 2:
					num = (short)1369964551;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					bool flag2;
					if (flag2)
					{
						num = (short)1893400581;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 5:
					num = (short)1277034496;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_8C;
				case 7:
					goto IL_1CF;
				}
				IL_45:
				num = (short)518914049;
				if (num != 0)
				{
				}
				if (values[1] == global::System.Windows.DependencyProperty.UnsetValue)
				{
					num = (short)984285190;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					flag = (bool)values[0];
					bool flag2 = (bool)values[1];
					flag3 = (bool)values[2];
					num = (short)1168441347;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_8C:
			return false;
			IL_AA:
			bool flag4 = false;
			IL_15D:
			return flag4;
			IL_1CF:
			flag4 = !flag3;
			goto IL_15D;
			IL_1D5:
			return flag;
		}

		// Token: 0x0600034A RID: 842 RVA: 0x00036F98 File Offset: 0x00035198
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1096070940;
			short num2 = num;
			num = (short)968079132;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1122959360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)526188544;
			if (num != 0)
			{
			}
			num = (short)1163657217;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
