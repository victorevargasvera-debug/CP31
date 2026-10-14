using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000037 RID: 55
	public class RMTabHeaderStyleToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000164 RID: 356 RVA: 0x000184D4 File Offset: 0x000166D4
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle rmtabHeaderStyle;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_103;
				case 1:
					goto IL_11D;
				case 2:
					goto IL_9C;
				case 3:
				{
					num2 = (short)1499463681;
					if (num2 != 0)
					{
					}
					if (!value.Equals(rmtabHeaderStyle))
					{
						num2 = (short)1238040578;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)515424497;
					short num3 = num2;
					num2 = (short)1808908529;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9C;
					default:
						num2 = (short)295305216;
						if (num2 != 0)
						{
						}
						num2 = (short)733216768;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
				IL_9C:
				num2 = (short)1914765313;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_103:
			global::System.Windows.Visibility visibility = global::System.Windows.Visibility.Visible;
			goto IL_149;
			IL_11D:
			num2 = (short)8192000;
			short num4 = num2;
			visibility = global::System.Windows.Visibility.Collapsed;
			IL_149:
			return visibility;
			IL_20:
			rmtabHeaderStyle = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle)global::System.Enum.Parse(typeof(global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle), (string)parameter);
			num2 = (short)934739971;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00018630 File Offset: 0x00016830
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1018742825;
			short num2 = num;
			num = (short)224839721;
			switch (num2 == num)
			{
			}
			num = (short)916258817;
			if (num != 0)
			{
			}
			num = (short)2119696384;
			short num3 = num;
			num = (short)2119303168;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
