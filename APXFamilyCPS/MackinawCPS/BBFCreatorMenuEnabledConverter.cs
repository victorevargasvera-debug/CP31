using System;
using System.Globalization;
using System.Windows.Data;

namespace MackinawCPS
{
	// Token: 0x02000025 RID: 37
	public class BBFCreatorMenuEnabledConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600007F RID: 127 RVA: 0x0000EE9C File Offset: 0x0000D09C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			switch (0)
			{
			case 0:
				goto IL_B1;
			}
			short num;
			int num4;
			bool flag2;
			for (;;)
			{
				IL_0A:
				num = (short)1761148928;
				short num2 = num;
				num = (short)1233745372;
				short num3 = num;
				num = (short)18118108;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)2134704128;
					if (num != 0)
					{
					}
					bool flag;
					switch (num4)
					{
					case 0:
						num = (short)779550724;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (values.Length == 2)
						{
							num = (short)974716937;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 2:
						num = (short)1413087235;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (values[1] is bool)
						{
							num = (short)1425473536;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 4:
						goto IL_126;
					case 5:
						flag = false;
						goto IL_1B2;
					case 6:
						goto IL_1CA;
					case 7:
						if (values[0] is bool)
						{
							num = (short)853540866;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_22B;
					case 8:
						flag = (bool)values[1];
						goto IL_1B2;
					case 9:
						num = (short)1107230727;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						num = (short)2005008392;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B1;
					IL_1B2:
					flag2 = flag;
					num = (short)1331691526;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_126:
				num = (short)520093697;
				if (num != 0)
				{
				}
				if ((bool)values[0])
				{
					num = (short)303562762;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1436549125;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_1CA:
			IL_22B:
			return flag2;
			IL_B1:
			flag2 = false;
			num = (short)924647425;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000080 RID: 128 RVA: 0x0000F0DC File Offset: 0x0000D2DC
		public object[] ConvertBack(object value, global::System.Type[] targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1015373071;
			short num2 = num;
			num = (short)2088262927;
			switch (num2 == num)
			{
			}
			num = (short)1276116992;
			if (num != 0)
			{
			}
			num = (short)1189806080;
			short num3 = num;
			num = (short)1261961217;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x0400003A RID: 58
		[global::System.NonSerialized]
		string VafgnaprSvryq = 32;
	}
}
