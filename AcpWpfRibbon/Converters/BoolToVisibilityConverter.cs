using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace DevComponents.WpfRibbon.Converters
{
	// Token: 0x020000D3 RID: 211
	public class BoolToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060008C2 RID: 2242 RVA: 0x000C7E38 File Offset: 0x000C6038
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 18;
			switch (0)
			{
			case 0:
				goto IL_41;
			}
			int num;
			short num2;
			bool flag;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1937571840;
					short num3 = num2;
					if (!flag)
					{
						num2 = (short)1456734213;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14A;
				}
				case 1:
					goto IL_86;
				case 2:
					goto IL_C0;
				case 3:
					if (flag)
					{
						num2 = (short)1275265026;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_151;
				case 4:
				{
					num2 = (short)1404705935;
					short num4 = num2;
					num2 = (short)1245584527;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_10A;
					default:
						num2 = (short)462094336;
						if (num2 != 0)
						{
						}
						num2 = (short)1987379200;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 5:
					goto IL_204;
				case 6:
					if ((string)parameter == global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("⍩ɫᡭᕯqݳ፵", a_))
					{
						num2 = (short)1355939844;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)286392323;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					goto IL_10A;
				case 8:
					if (targetType == typeof(string))
					{
						num2 = (short)1024000001;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1316356103;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					num2 = (short)1469644806;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_41;
				IL_10A:
				if (!(targetType == typeof(global::System.Windows.Visibility)))
				{
					goto IL_25B;
				}
				num2 = (short)1641676809;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_86:
			return flag.ToString();
			IL_C0:
			num2 = (short)66715649;
			if (num2 != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
			IL_14A:
			return global::System.Windows.Visibility.Collapsed;
			IL_151:
			return global::System.Windows.Visibility.Collapsed;
			IL_204:
			return global::System.Windows.Visibility.Visible;
			IL_25B:
			return null;
			IL_41:
			flag = (bool)value;
			num2 = (short)1288634376;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x060008C3 RID: 2243 RVA: 0x000C80A4 File Offset: 0x000C62A4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			short num = (short)404488194;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1981415424;
				short num3 = num;
				num = (short)1585512449;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
					goto IL_144;
				case 1:
					goto IL_10C;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_91;
					}
					continue;
				case 3:
					if ((global::System.Windows.Visibility)value == global::System.Windows.Visibility.Visible)
					{
						num = (short)367984640;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_FE;
				}
				IL_91:
				num = (short)354446993;
				short num4 = num;
				num = (short)1432383121;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					IL_10C:
					num = (short)1894842371;
					num2 = (int)((global::System.IntPtr)num);
					break;
				default:
					num = (short)1076953088;
					if (num != 0)
					{
					}
					if (!(value is global::System.Windows.Visibility))
					{
						goto IL_146;
					}
					num = (short)1381433345;
					num2 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			IL_FE:
			return false;
			IL_144:
			return true;
			IL_146:
			throw new global::System.Exception(global::DevComponents.WpfRibbon.Converters.PopupPlacementConverter.b("ㅤས౨䭪l੮հ᭲ᩴ፶奸ᑺོ彾ﾊﾐ뎒ﲔ릘膠쪢좤힦얨캪사쪮\udfb0잲킴펶鞸", a_));
		}
	}
}
