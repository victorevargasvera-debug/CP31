using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000009 RID: 9
	public class BoolToGridRowHeightConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000014 RID: 20 RVA: 0x00002CA8 File Offset: 0x00000EA8
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_135;
				case 1:
					num2 = (short)699465728;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
				{
					num2 = (short)865446139;
					short num3 = num2;
					num2 = (short)897951995;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_B1;
					}
					break;
				}
				case 3:
					if (!(bool)value)
					{
						num2 = (short)1424949249;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)640811010;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_20;
			}
			IL_B1:
			num2 = (short)228917249;
			if (num2 != 0)
			{
			}
			num2 = (short)285147136;
			if (num2 != 0)
			{
			}
			num2 = (short)65142784;
			short num4 = num2;
			int num5;
			global::System.Windows.GridLength gridLength = new global::System.Windows.GridLength((double)num5, global::System.Windows.GridUnitType.Pixel);
			goto IL_145;
			IL_135:
			gridLength = new global::System.Windows.GridLength(0.0);
			IL_145:
			return gridLength;
			IL_20:
			num5 = int.Parse(parameter as string, global::System.Globalization.CultureInfo.CurrentCulture);
			num2 = (short)1956708355;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000015 RID: 21 RVA: 0x00002E00 File Offset: 0x00001000
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1192755202;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				string a;
				switch (num2)
				{
				case 0:
					a = value.ToString();
					goto IL_89;
				case 1:
					goto IL_D9;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_3D;
					}
					continue;
				case 3:
					a = null;
					goto IL_89;
				case 4:
					return value;
				case 5:
					num = (short)1873477635;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_3D:
				if (value == null)
				{
					num = (short)453246981;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)889788153;
				short num3 = num;
				num = (short)2058688249;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_D9;
				default:
					num = (short)1215299584;
					if (num != 0)
					{
					}
					num = (short)603127808;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_89:
				if (!(a == string.Empty))
				{
					num = (short)1557463040;
					short num4 = num;
					num = (short)2028273665;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_170;
				IL_D9:
				num = (short)1206714369;
				if (num != 0)
				{
				}
				num = (short)292028420;
				num2 = (int)((global::System.IntPtr)num);
			}
			return value;
			IL_170:
			return null;
		}
	}
}
