using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000087 RID: 135
	public class CheckToVisibilityConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000A71 RID: 2673 RVA: 0x000C1BFC File Offset: 0x000BFDFC
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_2C;
			}
			int num;
			bool? flag2;
			short num2;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_191;
				case 1:
				{
					bool? flag = flag2;
					bool flag3 = true;
					num2 = (short)619249670;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_12B;
				case 3:
				{
					num2 = (short)1527227437;
					short num3 = num2;
					num2 = (short)690070573;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_191;
					default:
						num2 = (short)914620417;
						if (num2 != 0)
						{
						}
						num2 = (short)212467712;
						if (num2 != 0)
						{
						}
						if (value is bool?)
						{
							num2 = (short)55771141;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_130;
					}
					break;
				}
				case 4:
					if (flag2 != null)
					{
						num2 = (short)333381633;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BE;
				case 5:
					flag2 = (value as bool?);
					num2 = (short)587923456;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					bool? flag;
					bool flag3;
					if (flag.GetValueOrDefault() == flag3 & flag != null)
					{
						num2 = (short)1538588674;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C5;
				}
				}
				goto IL_2C;
				IL_130:
				num2 = (short)1547108356;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_191:
				num2 = (short)1591869440;
				short num4 = num2;
				goto IL_130;
			}
			IL_12B:
			IL_1BE:
			return global::System.Windows.Visibility.Visible;
			IL_1C5:
			return global::System.Windows.Visibility.Collapsed;
			IL_2C:
			flag2 = new bool?(true);
			num2 = (short)202113027;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A72 RID: 2674 RVA: 0x000C1DD4 File Offset: 0x000BFFD4
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)660932404;
			short num2 = num;
			num = (short)455608116;
			switch (num2 == num)
			{
			}
			num = (short)2033582080;
			if (num != 0)
			{
			}
			num = (short)1594032128;
			short num3 = num;
			num = (short)1741553665;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
