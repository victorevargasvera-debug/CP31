using System;
using System.ComponentModel;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using AllFeatures;

namespace ConstraintHelper
{
	// Token: 0x020005FF RID: 1535
	public class LabelBindingApplicabilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600D10D RID: 53517 RVA: 0x00C3DC28 File Offset: 0x00C3BE28
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 7;
			short num = (short)1878196229;
			int num2 = (int)((global::System.IntPtr)num);
			bool flag2;
			for (;;)
			{
				int num3;
				bool flag;
				switch (num2)
				{
				case 0:
					if (num3 == 0)
					{
						num = (short)1160511489;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F4;
				case 1:
					num = (short)989462534;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_1D5;
				case 3:
					if (num3 >= values.Length)
					{
						num = (short)1666121735;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)997720078;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					goto IL_1D5;
				case 5:
					switch (0)
					{
					case 0:
						goto IL_7A;
					}
					continue;
				case 6:
					if (!global::ConstraintHelper.UtilityMack.ProductModelId.Equals(global::AllFeatures.CodeplugGuid.b("觇髉铋﷍", a_)))
					{
						num = (short)2108751889;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 7:
					goto IL_20C;
				case 8:
					goto IL_170;
				case 9:
					flag = bool.Parse(values[num3].ToString());
					goto IL_28D;
				case 10:
					goto IL_B4;
				case 11:
					if (!flag2)
					{
						num = (short)1510670351;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)819068944;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					if (values[num3] != global::System.Windows.DependencyProperty.UnsetValue)
					{
						num = (short)1972895762;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_170;
				case 13:
					num = (short)591724544;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 14:
					if (values.Length > 1)
					{
						num = (short)1273298957;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F4;
				case 15:
				{
					num = (short)847904768;
					short num4 = num;
					num = (short)682098697;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 16:
					flag = true;
					goto IL_28D;
				case 17:
					goto IL_2F4;
				case 18:
					num = (short)725680139;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_7A:
				if ((bool)global::System.ComponentModel.DesignerProperties.IsInDesignModeProperty.GetMetadata(typeof(global::System.Windows.DependencyObject)).DefaultValue)
				{
					num = (short)642383882;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				flag2 = false;
				num3 = 0;
				num = (short)405143556;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_170:
				num3++;
				num = (short)539295746;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1D5:
				num = (short)1276116995;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_28D:
				flag2 = flag;
				num = (short)207326607;
				short num5 = num;
				num = (short)1246137743;
				switch ((num5 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_286;
				default:
					num = (short)483459072;
					if (num != 0)
					{
					}
					num = (short)284426248;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_2F4:
				num = (short)1791426572;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B4:
			goto IL_286;
			IL_20C:
			num = (short)711065601;
			if (num != 0)
			{
			}
			return flag2;
			IL_286:
			return false;
		}

		// Token: 0x0600D10E RID: 53518 RVA: 0x00C3DFA8 File Offset: 0x00C3C1A8
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)829947904;
			short num2 = num;
			num = (short)1664713430;
			short num3 = num;
			num = (short)1598259926;
			switch (num3 == num)
			{
			}
			num = (short)1197604864;
			if (num != 0)
			{
			}
			num = (short)1869217793;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
