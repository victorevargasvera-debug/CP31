using System;
using System.Globalization;
using System.Windows.Data;
using CommonResources;
using SpecialFeatures.AcpReportManagerLib;

namespace SpecialFeatures.Ucl.Contact
{
	// Token: 0x02000213 RID: 531
	public class DecToHexConverter : global::System.Windows.Data.IValueConverter
	{
		// Token: 0x06001B22 RID: 6946 RVA: 0x00230020 File Offset: 0x0022E220
		public object Convert(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int a_ = 9;
			short num;
			object result;
			try
			{
				num = (short)408293107;
				short num2 = num;
				num = (short)1306529523;
				int num4;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
				{
					IL_B1:
					int num3;
					result = (num3 = 0);
					num = (short)1691484162;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				default:
					num = (short)275185664;
					if (num != 0)
					{
					}
					num = (short)197722115;
					num4 = (int)((global::System.IntPtr)num);
					break;
				}
				for (;;)
				{
					switch (num4)
					{
					case 0:
						goto IL_117;
					case 1:
						goto IL_AF;
					case 2:
						goto IL_CE;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_89;
						}
						continue;
					}
					IL_89:
					if ((string)value == global::CommonResources.AppResources.Unassigned_ID)
					{
						num = (short)1863843841;
						num4 = (int)((global::System.IntPtr)num);
					}
					else
					{
						int num3;
						int.TryParse((string)value, global::System.Globalization.NumberStyles.Integer, global::System.Globalization.CultureInfo.InvariantCulture, out num3);
						result = num3.ToString(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("풋", a_), global::System.Globalization.CultureInfo.CurrentCulture);
						num = (short)914620416;
						num4 = (int)((global::System.IntPtr)num);
					}
				}
				IL_AF:
				goto IL_B1;
				IL_CE:
				IL_117:;
			}
			catch
			{
				result = string.Empty;
			}
			num = (short)1217462273;
			if (num != 0)
			{
			}
			num = (short)1307901952;
			short num5 = num;
			return result;
		}

		// Token: 0x06001B23 RID: 6947 RVA: 0x002301C0 File Offset: 0x0022E3C0
		public object ConvertBack(object value, global::System.Type targetType, object parameter, global::System.Globalization.CultureInfo culture)
		{
			int num;
			if (!int.TryParse((string)value, global::System.Globalization.NumberStyles.HexNumber, global::System.Globalization.CultureInfo.InvariantCulture, out num))
			{
				short num2 = (short)723313204;
				short num3 = num2;
				num2 = (short)2031411764;
				switch ((num3 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1091633152;
					if (num2 != 0)
					{
					}
					num2 = (short)935395328;
					short num4 = num2;
					num2 = (short)326041601;
					if (num2 != 0)
					{
					}
					return 0;
				}
				}
			}
			return num;
		}
	}
}
