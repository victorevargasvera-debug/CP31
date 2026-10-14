using System;
using System.Globalization;
using System.Windows.Data;
using Motorola.CommonCPS.RadioManagement.Controls;

namespace Motorola.CommonCPS.RadioManagement.Common
{
	// Token: 0x02000036 RID: 54
	public class RMTabHeaderStyleToIntConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000161 RID: 353 RVA: 0x000181EC File Offset: 0x000163EC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle rmtabHeaderStyle;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					if (rmtabHeaderStyle == global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.IconWithText)
					{
						goto IL_14E;
					}
					num2 = (short)1972590911;
					short num3 = num2;
					num2 = (short)2141346111;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_155;
					default:
						num2 = (short)857276416;
						if (num2 != 0)
						{
						}
						num2 = (short)1962737666;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_9E;
				case 2:
					num2 = (short)33292289;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1818361856;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (rmtabHeaderStyle != global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.Icon)
					{
						num2 = (short)359727107;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_80;
				}
				goto IL_24;
			}
			IL_80:
			return 0;
			IL_9E:
			num2 = (short)680853504;
			short num4 = num2;
			goto IL_155;
			IL_14E:
			return 1;
			IL_155:
			return 2;
			IL_24:
			num2 = (short)308412417;
			if (num2 != 0)
			{
			}
			rmtabHeaderStyle = (global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle)value;
			num2 = (short)940572676;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00018354 File Offset: 0x00016554
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			int num3;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1583415297;
					if (num2 != 0)
					{
					}
					if (num3 == 1)
					{
						goto IL_150;
					}
					num2 = (short)1992675800;
					short num4 = num2;
					num2 = (short)1200476632;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_157;
					default:
						num2 = (short)261357568;
						if (num2 != 0)
						{
						}
						num2 = (short)2145189890;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					goto IL_75;
				case 2:
					num2 = (short)280821761;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
				{
					num2 = (short)104726528;
					short num5 = num2;
					num2 = (short)619118592;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 4:
					if (num3 != 0)
					{
						num2 = (short)6160387;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_59;
				}
				goto IL_24;
			}
			IL_59:
			return global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.Icon;
			IL_75:
			goto IL_157;
			IL_150:
			return global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.IconWithText;
			IL_157:
			return global::Motorola.CommonCPS.RadioManagement.Controls.RMTabHeaderStyle.Text;
			IL_24:
			num3 = (int)value;
			num2 = (short)1688469508;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}
	}
}
