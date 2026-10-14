using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000137 RID: 311
	public class UltraLowPowerConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001049 RID: 4169 RVA: 0x0016C93C File Offset: 0x0016AB3C
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 16;
			short num = (short)1590886401;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_2A8;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_66;
					}
					continue;
				case 2:
					if (!values[1].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔꺖좘\udf9a햜ꚞ銤", a_)))
					{
						num = (short)886112262;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17B;
				case 3:
					num = (short)1659240449;
					if (num != 0)
					{
					}
					if (values[1].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔꺖좘\udf9a\ud99cꚞ邤", a_)))
					{
						num = (short)724107264;
						short num3 = num;
						num = (short)1748828160;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_301;
				case 4:
					goto IL_9A;
				case 5:
					num = (short)102760461;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					num = (short)1464139783;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					if (!values[1].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔꺖좘\udf9a햜ꚞ銤", a_)))
					{
						num = (short)1722023944;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_17B;
				case 8:
					num = (short)1092222980;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					num = (short)1814102019;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 10:
				{
					num = (short)1570647905;
					short num4 = num;
					num = (short)904474465;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_9A;
					default:
						num = (short)924254208;
						if (num != 0)
						{
						}
						if (values.Length == 2)
						{
							num = (short)764936197;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_301;
					}
					break;
				}
				case 11:
					num = (short)708771842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 12:
					num = (short)670105610;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					if (values[0].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("삒잔쾖ꮘꦚ궜꾞", a_)))
					{
						num = (short)2038104075;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_301;
				}
				IL_66:
				if (values != null)
				{
					num = (short)1299906572;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_301;
				IL_9A:
				if (values[1].ToString().Equals(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\udb92겔꺖좘\udf9a\ud99cꚞ邤", a_)))
				{
					break;
				}
				num = (short)416612361;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_17B:
			return global::System.Windows.Visibility.Visible;
			IL_2A8:
			goto IL_17B;
			IL_301:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x0600104A RID: 4170 RVA: 0x0016CC50 File Offset: 0x0016AE50
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)1198898208;
			short num2 = num;
			num = (short)1949088800;
			switch (num2 == num)
			{
			}
			num = (short)417726464;
			if (num != 0)
			{
			}
			num = (short)1324089344;
			short num3 = num;
			num = (short)70516737;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
