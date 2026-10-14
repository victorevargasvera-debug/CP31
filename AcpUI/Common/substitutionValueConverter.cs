using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace AcpUI.Common
{
	// Token: 0x02000093 RID: 147
	public class substitutionValueConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000628 RID: 1576 RVA: 0x0007EB70 File Offset: 0x0007CD70
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 5;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			global::System.Windows.Media.NumberSubstitutionMethod numberSubstitutionMethod;
			short num2;
			for (;;)
			{
				IL_13:
				int num;
				switch (num)
				{
				case 0:
					numberSubstitutionMethod = global::System.Windows.Media.NumberSubstitutionMethod.European;
					num2 = (short)107020289;
					if (num2 != 0)
					{
					}
					num2 = (short)10878977;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
					goto IL_119;
				case 2:
					num2 = (short)1348993028;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)269025280;
					short num3 = num2;
					if (value != null)
					{
						num2 = (short)867565570;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16A;
				}
				case 4:
					if (value.ToString() == global::AcpUI.Common.Utility.c("漢", a_))
					{
						num2 = (short)1159069696;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_16A;
				}
				goto IL_2D;
			}
			IL_119:
			goto IL_16A;
			IL_2D:
			numberSubstitutionMethod = global::System.Windows.Media.NumberSubstitutionMethod.AsCulture;
			num2 = (short)27788162;
			short num4 = num2;
			num2 = (short)1985217410;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_16A:
				return numberSubstitutionMethod;
			default:
			{
				num2 = (short)1269301248;
				if (num2 != 0)
				{
				}
				num2 = (short)1555365891;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
		}

		// Token: 0x06000629 RID: 1577 RVA: 0x0007ECF0 File Offset: 0x0007CEF0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)54267663;
			short num2 = num;
			num = (short)951783183;
			switch (num2 == num)
			{
			}
			num = (short)345243648;
			if (num != 0)
			{
			}
			num = (short)1466499073;
			if (num != 0)
			{
			}
			num = (short)1571291136;
			short num3 = num;
			throw new global::System.NotImplementedException();
		}
	}
}
