using System;
using System.Globalization;
using System.Windows.Data;
using AcpCommonLib;
using AllFeatures;

namespace ConstraintHelper
{
	// Token: 0x020005F5 RID: 1525
	public class ReverseConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x0600D0E6 RID: 53478 RVA: 0x00C3A964 File Offset: 0x00C38B64
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)1935933442;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 1:
					num2 = (short)1921712128;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_FD;
				case 3:
				{
					if (!global::System.Globalization.CultureInfo.CurrentCulture.Name.ToLower().StartsWith(global::AllFeatures.CodeplugGuid.b("꿍ꋏ", a_)))
					{
						return text;
					}
					num2 = (short)834373984;
					short num3 = num2;
					num2 = (short)1210026336;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FD;
					default:
						num2 = (short)1477378048;
						if (num2 != 0)
						{
						}
						num2 = (short)1176764417;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return text;
				}
				goto IL_2D;
				IL_FD:
				num2 = (short)1215561728;
				short num4 = num2;
				text = global::AcpCommonLib.Utility.reverseConverter(text);
				num2 = (short)1107755012;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_2D:
			num2 = (short)106102785;
			if (num2 != 0)
			{
			}
			text = value.ToString();
			num2 = (short)1910046723;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600D0E7 RID: 53479 RVA: 0x00C3AAF8 File Offset: 0x00C38CF8
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 15;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			string text;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (!string.IsNullOrEmpty(text))
					{
						num2 = (short)1092222978;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return text;
				case 1:
					num2 = (short)1649082368;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_FC;
				case 3:
				{
					num2 = (short)1437925377;
					if (num2 != 0)
					{
					}
					if (!global::System.Globalization.CultureInfo.CurrentCulture.Name.ToLower().StartsWith(global::AllFeatures.CodeplugGuid.b("뇏ꃑ", a_)))
					{
						return text;
					}
					num2 = (short)1575683967;
					short num3 = num2;
					num2 = (short)862455679;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FC;
					default:
						num2 = (short)482803712;
						if (num2 != 0)
						{
						}
						num2 = (short)241172481;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 4:
					return text;
				}
				goto IL_2D;
				IL_FC:
				num2 = (short)539623424;
				short num4 = num2;
				text = global::AcpCommonLib.Utility.reverseConverterBack(text);
				num2 = (short)1702035460;
				num = (int)((global::System.IntPtr)num2);
			}
			return text;
			IL_2D:
			text = value.ToString();
			num2 = (short)1982922755;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
