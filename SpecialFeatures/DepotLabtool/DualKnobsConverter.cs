using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.DepotLabtool
{
	// Token: 0x02000139 RID: 313
	public class DualKnobsConverter : global::System.Windows.Data.IMultiValueConverter
	{
		// Token: 0x0600104F RID: 4175 RVA: 0x0016CF54 File Offset: 0x0016B154
		public object Convert(object[] values, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 11;
			short num = (short)474677248;
			short num2 = num;
			num = (short)1901461508;
			int num3 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num3)
				{
				case 0:
					num = (short)252248065;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (values.Length == 1)
					{
						num = (short)1702166531;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2A5;
				case 2:
					goto IL_262;
				case 3:
				{
					object[] array = new string[]
					{
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ솓햕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ얓튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ잓튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ\udf93튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ솓햕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ얓튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ잓튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꂑ\udf93튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ솓햕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ얓튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ잓튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ\udf93튕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ쎓햕\ude97ꎙ첛증隟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ솓햕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ얓튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ잓튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ\udf93튕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꖏꎑ쎓햕킗ꎙ첛증鞟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꢏꚑ쎓햕\udc97ꎙ첛증閟", a_),
						global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("욍ꢏꚑ쎓햕\ude97ꎙ첛증隟", a_)
					};
					num = (short)322764805;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_6F;
					}
					continue;
				case 5:
				{
					object[] array;
					if (global::System.Array.IndexOf<object>(array, values[0]) > -1)
					{
						goto IL_223;
					}
					goto IL_2A5;
				}
				}
				IL_6F:
				if (values != null)
				{
					num = (short)395444224;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_2A5;
				IL_223:
				num = (short)1336803329;
				if (num != 0)
				{
				}
				num = (short)1424293890;
				num3 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A5:
				num = (short)756074706;
				short num4 = num;
				num = (short)1392101586;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_223;
				default:
					goto IL_2DA;
				}
			}
			IL_262:
			return global::System.Windows.Visibility.Visible;
			IL_2DA:
			num = (short)951582720;
			if (num != 0)
			{
			}
			return global::System.Windows.Visibility.Hidden;
		}

		// Token: 0x06001050 RID: 4176 RVA: 0x0016D258 File Offset: 0x0016B458
		public object[] ConvertBack(object value, global::System.Type[] targetTypes, object parameter, global::System.Globalization.CultureInfo culture)
		{
			short num = (short)2086140199;
			short num2 = num;
			num = (short)1980954919;
			switch (num2 == num)
			{
			}
			num = (short)1311113217;
			if (num != 0)
			{
			}
			num = (short)1789526016;
			short num3 = num;
			num = (short)368443392;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}
	}
}
