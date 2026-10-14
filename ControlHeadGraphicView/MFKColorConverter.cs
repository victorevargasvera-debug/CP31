using System;
using System.Globalization;
using System.Windows;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using AcpBusinessLayer;
using ControlHeadGraphicView.converters;

namespace ControlHeadGraphicView
{
	// Token: 0x02000009 RID: 9
	public class MFKColorConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x060006F3 RID: 1779 RVA: 0x00062C68 File Offset: 0x00060E68
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 6;
			short num = (short)1341521920;
			switch (num)
			{
			default:
			{
				num = (short)162332685;
				int num2 = (int)((global::System.IntPtr)num);
				object result2;
				for (;;)
				{
					global::AcpBusinessLayer.AcpListField acpListField;
					object result;
					int num4;
					switch (num2)
					{
					case 0:
						num = (short)867172357;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (acpListField != null)
						{
							num = (short)1812267012;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 2:
						num = (short)663552009;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						num = (short)526778374;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						num = (short)602013704;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						if (values[1] != null)
						{
							num = (short)331481098;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 6:
						if (values[1] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)629932034;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 7:
						if (values[2] != null)
						{
							num = (short)1105133571;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					case 8:
						goto IL_112;
					case 9:
					{
						num = (short)240386048;
						short num3 = num;
						if (values[2] != global::System.Windows.DependencyProperty.UnsetValue)
						{
							num = (short)897253377;
							if (num != 0)
							{
							}
							num = (short)489226251;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_308;
					}
					case 10:
						num = (short)1093271559;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						result2 = (values[2] as global::System.Windows.Controls.Primitives.ToggleButton).FindResource(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("簰甲縴甶䰸伺䤼倾⽀၂ㅄ㹆╈⹊ཌ⹎≐㩒㙔ᑖᅘᑚ⽜㹞འѢd", a_));
						result = (values[2] as global::System.Windows.Controls.Primitives.ToggleButton).FindResource(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("簰甲縴甶䰸伺䤼倾⽀၂ㅄ㹆╈⹊ཌ⹎≐㩒㙔ᑖᅘ", a_));
						acpListField = (values[1] as global::AcpBusinessLayer.AcpListField);
						num4 = 31;
						num = (short)776732673;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						return result2;
					case 13:
						switch (0)
						{
						case 0:
							goto IL_86;
						}
						continue;
					}
					IL_86:
					num = (short)616539452;
					short num5 = num;
					num = (short)1648207164;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						IL_112:
						if (acpListField.Value != num4)
						{
							return result;
						}
						num = (short)1404960780;
						num2 = (int)((global::System.IntPtr)num);
						break;
					default:
						num = (short)1324875776;
						if (num != 0)
						{
						}
						if (values.Length != 3)
						{
							goto IL_308;
						}
						num = (short)194183168;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
				}
				return result2;
				IL_308:
				return null;
			}
			}
		}

		// Token: 0x060006F4 RID: 1780 RVA: 0x00062F80 File Offset: 0x00061180
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1144400869;
			short num2 = num;
			num = (short)884026341;
			switch (num2 == num)
			{
			}
			num = (short)264962049;
			if (num != 0)
			{
			}
			num = (short)1719861248;
			if (num != 0)
			{
			}
			num = (short)70254592;
			short num3 = num;
			return null;
		}
	}
}
