using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000036 RID: 54
	public class MultiBoolsToGridWidthConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00009550 File Offset: 0x00007750
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)2123825158;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_1E8;
				case 1:
					num = (short)724828162;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_96;
				case 3:
					goto IL_128;
				case 4:
				{
					num = (short)201719808;
					short num3 = num;
					num = (short)761921536;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_6E;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_49;
					}
					continue;
				}
				goto IL_49;
				IL_96:
				if (!(parameter.ToString() == global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("엮", a_)))
				{
					num = (short)1127284740;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)250871813;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_49:
				if (!values.All(new global::System.Func<object, bool>(global::Motorola.CommonCPS.RadioManagement.Converters.MultiBoolsToGridWidthConverter.<>c.<>9.a)))
				{
					num = (short)748574131;
					short num4 = num;
					num = (short)938038707;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_96;
					default:
						num = (short)230686720;
						if (num != 0)
						{
						}
						num = (short)162922497;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				else
				{
					num = (short)1487929347;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_6E:
			global::System.Windows.GridLength gridLength = new global::System.Windows.GridLength(1.0, global::System.Windows.GridUnitType.Star);
			goto IL_1F8;
			IL_128:
			num = (short)1858732033;
			if (num != 0)
			{
			}
			gridLength = new global::System.Windows.GridLength(0.0);
			goto IL_1F8;
			IL_1E8:
			gridLength = new global::System.Windows.GridLength(100.0);
			IL_1F8:
			return gridLength;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000975C File Offset: 0x0000795C
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1489911939;
			short num2 = num;
			num = (short)556155011;
			switch (num2 == num)
			{
			}
			num = (short)940376065;
			if (num != 0)
			{
			}
			num = (short)537919488;
			short num3 = num;
			num = (short)1219231744;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
