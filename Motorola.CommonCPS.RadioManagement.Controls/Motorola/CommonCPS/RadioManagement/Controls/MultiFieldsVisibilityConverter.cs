using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Controls
{
	// Token: 0x020000E7 RID: 231
	public class MultiFieldsVisibilityConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06000659 RID: 1625 RVA: 0x00065FDC File Offset: 0x000641DC
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)120586243;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				bool flag;
				switch (num2)
				{
				case 0:
					num = (short)721420289;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_5A;
				case 2:
					if (!flag)
					{
						num = (short)1809580032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1968504836;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_38;
					}
					continue;
				case 4:
					goto IL_16E;
				}
				IL_38:
				flag = values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Controls.MultiFieldsVisibilityConverter.<>c.<>9.a));
				num = (short)689817855;
				short num3 = num;
				num = (short)40093951;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_5A;
				default:
				{
					num = (short)1159987200;
					short num4 = num;
					num = (short)90046465;
					if (num != 0)
					{
					}
					num = (short)887226368;
					if (num != 0)
					{
					}
					num = (short)67567618;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
				}
			}
			IL_5A:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_171;
			IL_16E:
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_171:
			return visibility;
		}

		// Token: 0x0600065A RID: 1626 RVA: 0x00066160 File Offset: 0x00064360
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)914038150;
			short num2 = num;
			num = (short)502013318;
			switch (num2 == num)
			{
			}
			num = (short)1472659456;
			if (num != 0)
			{
			}
			num = (short)115081216;
			short num3 = num;
			num = (short)1399128065;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
