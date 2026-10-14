using System;
using System.Globalization;
using System.Windows.Data;

namespace Motorola.CommonCPS.RadioManagement.Converters
{
	// Token: 0x02000047 RID: 71
	public class EmptyStringToZeroConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x060000D7 RID: 215 RVA: 0x0000BAE0 File Offset: 0x00009CE0
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)546598216;
			short num2 = num;
			num = (short)1577479496;
			switch (num2 == num)
			{
			}
			num = (short)2057240577;
			if (num != 0)
			{
			}
			num = (short)1962278912;
			short num3 = num;
			num = (short)859570176;
			if (num != 0)
			{
			}
			return value;
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000BB8C File Offset: 0x00009D8C
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 2;
			short num = (short)1814757379;
			int num2 = (int)((global::System.IntPtr)num);
			int num3;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C9;
				case 1:
					if (value.ToString() == string.Empty)
					{
						num = (short)255262720;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 2:
					int.TryParse(value.ToString(), out num3);
					num = (short)77332489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_59;
					}
					continue;
				case 4:
					if (targetType == typeof(string))
					{
						num = (short)828899338;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return value;
				case 5:
					goto IL_175;
				case 6:
				{
					if (value != null)
					{
						num = (short)690683905;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2106001963;
					short num4 = num;
					num = (short)1809386027;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						return value;
					default:
						num = (short)1348075521;
						if (num != 0)
						{
						}
						num = (short)835584000;
						if (num != 0)
						{
						}
						num = (short)76152837;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 7:
					if (value != null)
					{
						num = (short)1292435458;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26D;
				case 8:
					num3 = 0;
					num = (short)1284112391;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_19C;
				case 10:
					num = (short)2025324550;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_59:
				if (targetType == typeof(int))
				{
					num = (short)1663434760;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1441071108;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_C9:
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\uddec", a_);
			IL_175:
			num = (short)1596325888;
			short num5 = num;
			return global::Motorola.CommonCPS.RadioManagement.Converters.ZeroBasedAccessTextToOneBasedAccessText.b("\uddec", a_);
			IL_19C:
			goto IL_26D;
			IL_221:
			return value.ToString();
			IL_26D:
			return num3;
		}
	}
}
