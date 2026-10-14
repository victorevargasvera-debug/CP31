using System;
using System.Globalization;
using System.Windows.Data;

namespace SpecialFeatures.Programming
{
	// Token: 0x02000086 RID: 134
	public class CheckToNotEnabled : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06000A6E RID: 2670 RVA: 0x000C1978 File Offset: 0x000BFB78
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
					goto IL_18D;
				case 1:
				{
					bool? flag = flag2;
					bool flag3 = true;
					num2 = (short)373161990;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_128;
				case 3:
				{
					num2 = (short)1530728631;
					short num3 = num2;
					num2 = (short)1963004087;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_18D;
					default:
						num2 = (short)27000833;
						if (num2 != 0)
						{
						}
						num2 = (short)1990787072;
						if (num2 != 0)
						{
						}
						if (value is bool?)
						{
							num2 = (short)925499397;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_12D;
					}
					break;
				}
				case 4:
					if (flag2 != null)
					{
						num2 = (short)179240961;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1BC;
				case 5:
					flag2 = (value as bool?);
					num2 = (short)1429405696;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
				{
					bool? flag;
					bool flag3;
					if (flag.GetValueOrDefault() == flag3 & flag != null)
					{
						num2 = (short)273219586;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1C3;
				}
				}
				goto IL_2C;
				IL_12D:
				num2 = (short)690749444;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_18D:
				num2 = (short)783548416;
				short num4 = num2;
				goto IL_12D;
			}
			IL_128:
			IL_1BC:
			return false;
			IL_1C3:
			return true;
			IL_2C:
			flag2 = new bool?(true);
			num2 = (short)166920195;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000A6F RID: 2671 RVA: 0x000C1B50 File Offset: 0x000BFD50
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1922121529;
			short num2 = num;
			num = (short)560742201;
			switch (num2 == num)
			{
			}
			num = (short)206897153;
			if (num != 0)
			{
			}
			num = (short)508362752;
			short num3 = num;
			num = (short)941424640;
			if (num != 0)
			{
			}
			return null;
		}
	}
}
