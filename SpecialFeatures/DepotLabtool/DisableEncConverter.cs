using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x0200013A RID: 314
	public class DisableEncConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x06001052 RID: 4178 RVA: 0x0016D308 File Offset: 0x0016B508
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 4;
			short num = (short)642121734;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (values.Length == 1)
					{
						num = (short)1737228293;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 1:
				{
					string[] array;
					if (global::System.Array.IndexOf<string>(array, values[0].ToString().Substring(0, 3)) > -1)
					{
						num = (short)832307207;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				}
				case 2:
					if (values[0].ToString().Length >= 3)
					{
						num = (short)2138832900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_27C;
				case 3:
					num = (short)803143680;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					num = (short)1162280961;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					string[] array = new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈벊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈몊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈뮊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쮆몈뮊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆몈벊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈뎊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆낈늊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쪆뮈뺊", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("쾆불늊", a_)
					};
					num = (short)1522073602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
				{
					num = (short)1626707487;
					short num3 = num;
					num = (short)1995347487;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_127;
					case 1:
						break;
					default:
					{
						num = (short)110231552;
						short num4 = num;
						break;
					}
					}
					num = (short)765067264;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_C0;
					}
					continue;
				}
				case 7:
					goto IL_127;
				}
				IL_C0:
				if (values == null)
				{
					goto IL_27C;
				}
				num = (short)1420623875;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_127:
			num = (short)1424359425;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Visible;
			IL_27C:
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06001053 RID: 4179 RVA: 0x0016D598 File Offset: 0x0016B798
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)79101953;
			if (num != 0)
			{
			}
			num = (short)1514405888;
			short num2 = num;
			num = (short)2041199866;
			short num3 = num;
			num = (short)590822650;
			switch (num3 == num)
			{
			}
			num = (short)1077411840;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
