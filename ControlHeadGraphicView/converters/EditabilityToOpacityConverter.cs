using System;
using System.Globalization;
using System.Windows.Data;

namespace ControlHeadGraphicView.converters
{
	// Token: 0x02000012 RID: 18
	public class EditabilityToOpacityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000D42 RID: 3394 RVA: 0x000C6B6C File Offset: 0x000C4D6C
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_4E;
			}
			short num;
			int num3;
			double num4;
			for (;;)
			{
				IL_0A:
				num = (short)772079616;
				short num2 = num;
				switch (num3)
				{
				case 0:
					num = (short)642252801;
					if (num != 0)
					{
					}
					num = (short)138870786;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_101;
				case 2:
					if (!(bool)value)
					{
						num = (short)1427701763;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_167;
				case 3:
					num4 = 0.25;
					num = (short)806944769;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)192754210;
					short num5 = num;
					num = (short)782053922;
					switch ((num5 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_167;
					default:
						num = (short)1744240640;
						if (num != 0)
						{
						}
						if (value is bool)
						{
							num = (short)996671488;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_167;
					}
					break;
				}
				}
				goto IL_4E;
			}
			IL_101:
			IL_167:
			return num4;
			IL_4E:
			num4 = 1.0;
			num = (short)1091436548;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000D43 RID: 3395 RVA: 0x000C6CE8 File Offset: 0x000C4EE8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			short num = (short)2123650869;
			short num2 = num;
			num = (short)131290933;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1730740224;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2105344001;
			if (num != 0)
			{
			}
			num = (short)1092354048;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException(global::ControlHeadGraphicView.converters.O9GraphicviewMenuItemsVisibilityConverter.b("怬䨮䔰嬲娴匶ᤸ唺刼䬾慀⩂⡄㝆╈⹊⁌⩎㽐❒ご㍖", a_));
		}
	}
}
